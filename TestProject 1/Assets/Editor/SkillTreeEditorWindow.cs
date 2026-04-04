using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

/// <summary>
/// 技能树编辑器窗口：统一创建、调整、删除所有 SkillNodeSO 资产。
/// 打开方式：菜单栏 Tools > Skill Tree Editor
/// </summary>
public class SkillTreeEditorWindow : EditorWindow
{
    // ── 常量 ──
    private const string DEFAULT_SAVE_FOLDER = "Assets/Scripts/SkillTrees/Nodes";

    // ── 所有已加载的 SO 列表 ──
    private List<SkillNodeSO> allNodes = new();

    // ── 滚动位置 ──
    private Vector2 listScroll;
    private Vector2 detailScroll;

    // ── 当前选中的节点索引（-1=未选中）──
    private int selectedIndex = -1;

    // ── 搜索/筛选 ──
    private string searchText = "";
    private enum FilterType { All, UnlockType, StackType }
    private FilterType filterType = FilterType.All;
    private E_OreType? filterResource = null;

    // ── 新建节点的临时名称 ──
    private string newNodeName = "NewSkill";

    // ── 样式缓存 ──
    private GUIStyle headerStyle;
    private GUIStyle selectedBtnStyle;
    private bool stylesInitialized;

    [MenuItem("Tools/Skill Tree Editor")]
    public static void OpenWindow()
    {
        var win = GetWindow<SkillTreeEditorWindow>("Skill Tree Editor");
        win.minSize = new Vector2(860, 500);
    }

    private void OnEnable()
    {
        RefreshNodeList();
    }

    private void OnFocus()
    {
        // 窗口获得焦点时刷新，防止外部修改后不同步
        RefreshNodeList();
    }

    // ══════════════════════════════════════
    //  主绘制
    // ══════════════════════════════════════
    private void OnGUI()
    {
        InitStyles();

        EditorGUILayout.BeginHorizontal();

        // 左侧：节点列表（宽度 280）
        EditorGUILayout.BeginVertical(GUILayout.Width(280));
        DrawLeftPanel();
        EditorGUILayout.EndVertical();

        // 分隔线
        DrawSeparator();

        // 右侧：节点详情编辑
        EditorGUILayout.BeginVertical();
        DrawRightPanel();
        EditorGUILayout.EndVertical();

        EditorGUILayout.EndHorizontal();
    }

    // ══════════════════════════════════════
    //  左侧面板：搜索 + 筛选 + 节点列表 + 新建
    // ══════════════════════════════════════
    private void DrawLeftPanel()
    {
        // ── 搜索栏 ──
        EditorGUILayout.LabelField("搜索 / 筛选", headerStyle);
        searchText = EditorGUILayout.TextField("搜索名称", searchText);
        filterType = (FilterType)EditorGUILayout.EnumPopup("类型筛选", filterType);

        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.PrefixLabel("资源筛选");
        if (filterResource.HasValue)
        {
            filterResource = (E_OreType)EditorGUILayout.EnumPopup(filterResource.Value);
            if (GUILayout.Button("×", GUILayout.Width(22)))
                filterResource = null;
        }
        else
        {
            if (GUILayout.Button("选择资源类型"))
                filterResource = E_OreType.Gold;
        }
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.Space(6);

        // ── 节点列表 ──
        EditorGUILayout.LabelField($"技能节点 ({GetFilteredNodes().Count})", headerStyle);

        listScroll = EditorGUILayout.BeginScrollView(listScroll);

        var filtered = GetFilteredNodes();
        for (int i = 0; i < filtered.Count; i++)
        {
            var node = filtered[i];
            int realIndex = allNodes.IndexOf(node);

            // 选中高亮
            bool isSelected = realIndex == selectedIndex;
            GUIStyle style = isSelected ? selectedBtnStyle : GUI.skin.button;

            // 按钮文字：名称 + 类型标记
            string label = node.nodeName;
            if (string.IsNullOrEmpty(label)) label = node.name;
            string tag = node.isUnlockType ? " [解锁]" : $" [叠加×{node.maxPurchaseCount}]";

            if (GUILayout.Button(label + tag, style, GUILayout.Height(26)))
            {
                selectedIndex = realIndex;
                GUI.FocusControl(null); // 清除文本框焦点，防止编辑冲突
            }
        }

        EditorGUILayout.EndScrollView();

        EditorGUILayout.Space(6);

        // ── 新建节点 ──
        EditorGUILayout.LabelField("新建节点", headerStyle);
        newNodeName = EditorGUILayout.TextField("节点名称", newNodeName);

        if (GUILayout.Button("＋ 创建新技能节点", GUILayout.Height(30)))
        {
            CreateNewNode(newNodeName);
        }

        EditorGUILayout.Space(4);

        // ── 刷新按钮 ──
        if (GUILayout.Button("刷新列表"))
            RefreshNodeList();
    }

    // ══════════════════════════════════════
    //  右侧面板：选中节点的详细编辑
    // ══════════════════════════════════════
    private void DrawRightPanel()
    {
        if (selectedIndex < 0 || selectedIndex >= allNodes.Count)
        {
            EditorGUILayout.HelpBox("← 从左侧选择一个技能节点进行编辑，或创建新节点。", MessageType.Info);
            return;
        }

        var node = allNodes[selectedIndex];
        if (node == null)
        {
            selectedIndex = -1;
            return;
        }

        // 使用 SerializedObject 确保 Undo 和 Dirty 正确工作
        var so = new SerializedObject(node);
        so.Update();

        detailScroll = EditorGUILayout.BeginScrollView(detailScroll);

        // ── 标题 ──
        EditorGUILayout.LabelField($"编辑：{node.nodeName}", headerStyle);
        EditorGUILayout.LabelField($"资产路径：{AssetDatabase.GetAssetPath(node)}", EditorStyles.miniLabel);
        EditorGUILayout.Space(4);

        // ── 基本信息 ──
        DrawSectionHeader("基本信息");
        EditorGUILayout.PropertyField(so.FindProperty("nodeName"), new GUIContent("节点名称（唯一Key）"));
        EditorGUILayout.PropertyField(so.FindProperty("description"), new GUIContent("技能描述"));
        EditorGUILayout.PropertyField(so.FindProperty("icon"), new GUIContent("技能图标"));

        EditorGUILayout.Space(6);

        // ── 购买配置 ──
        DrawSectionHeader("购买配置");
        EditorGUILayout.PropertyField(so.FindProperty("maxPurchaseCount"), new GUIContent("最大购买次数"));
        EditorGUILayout.PropertyField(so.FindProperty("basePrice"), new GUIContent("基础价格"));
        EditorGUILayout.PropertyField(so.FindProperty("priceMultiplier"), new GUIContent("涨价倍数"));

        // 价格预览
        if (node.maxPurchaseCount > 1 && node.priceMultiplier > 1f)
        {
            EditorGUILayout.Space(2);
            EditorGUILayout.LabelField("价格预览：", EditorStyles.boldLabel);
            for (int i = 0; i < Mathf.Min(node.maxPurchaseCount, 8); i++)
            {
                double price = node.basePrice * System.Math.Pow(node.priceMultiplier, i);
                EditorGUILayout.LabelField($"  第{i + 1}次：{price:F0}", EditorStyles.miniLabel);
            }
            if (node.maxPurchaseCount > 8)
                EditorGUILayout.LabelField($"  ... 共{node.maxPurchaseCount}次", EditorStyles.miniLabel);
        }

        EditorGUILayout.Space(6);

        // ── 消耗资源 ──
        DrawSectionHeader("消耗资源");
        EditorGUILayout.PropertyField(so.FindProperty("costResource"), new GUIContent("消耗矿条类型"));

        EditorGUILayout.Space(6);

        // ── 前置条件 ──
        DrawSectionHeader("前置条件");
        EditorGUILayout.PropertyField(so.FindProperty("prerequisites"), new GUIContent("前置节点"), true);

        EditorGUILayout.Space(6);

        // ── 效果配置 ──
        DrawSectionHeader("效果配置");
        EditorGUILayout.PropertyField(so.FindProperty("isUnlockType"), new GUIContent("是否为解锁型"));
        EditorGUILayout.PropertyField(so.FindProperty("effectEventName"), new GUIContent("效果事件名"));
        EditorGUILayout.PropertyField(so.FindProperty("effectValue"), new GUIContent("效果数值"));

        // 常用事件名快捷按钮
        EditorGUILayout.Space(2);
        EditorGUILayout.LabelField("常用事件名（点击填入）：", EditorStyles.miniLabel);
        DrawEventNameButtons(so);

        EditorGUILayout.Space(10);

        // ── 操作按钮 ──
        EditorGUILayout.BeginHorizontal();

        if (GUILayout.Button("复制此节点", GUILayout.Height(28)))
            DuplicateNode(node);

        GUI.backgroundColor = new Color(1f, 0.4f, 0.4f);
        if (GUILayout.Button("删除此节点", GUILayout.Height(28)))
        {
            if (EditorUtility.DisplayDialog("确认删除",
                $"确定要删除技能节点 \"{node.nodeName}\" 吗？\n此操作不可撤销。", "删除", "取消"))
            {
                DeleteNode(node);
            }
        }
        GUI.backgroundColor = Color.white;

        EditorGUILayout.EndHorizontal();

        EditorGUILayout.EndScrollView();

        // 应用修改
        if (so.ApplyModifiedProperties())
            EditorUtility.SetDirty(node);
    }

    // ══════════════════════════════════════
    //  常用事件名快捷按钮
    // ══════════════════════════════════════
    private void DrawEventNameButtons(SerializedObject so)
    {
        var prop = so.FindProperty("effectEventName");

        // 分组显示
        DrawEventGroup("矿种概率", prop, new[] {
            "chunkGoldChance", "fullGoldChance",
            "chunkCopperChance", "fullCopperChance",
            "chunkIronChance", "fullIronChance",
            "chunkChromiumChance", "fullChromiumChance",
            "chunkUraniumChance", "fullUraniumChance",
            "chunkOsmiumChance", "fullOsmiumChance",
            "chunkTourmalineChance", "fullTourmalineChance",
            "chunkIridiumChance", "fullIridiumChance",
        });

        DrawEventGroup("矿种解锁", prop, new[] {
            "unlockCopper", "unlockIron", "unlockChromium", "unlockUranium",
            "unlockOsmium", "unlockTourmaline", "unlockIridium",
        });

        DrawEventGroup("挖矿属性", prop, new[] {
            "minePower", "mineTimeDecrease", "miningAreaSize",
            "doubleEffectChance", "startingOreCount",
        });

        DrawEventGroup("矿石产出", prop, new[] {
            "oreMultiplier", "chunkOreCount", "fullOreCount",
        });

        DrawEventGroup("武器", prop, new[] {
            "unlockWeapon",
        });
    }

    private void DrawEventGroup(string groupName, SerializedProperty prop, string[] names)
    {
        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField(groupName, GUILayout.Width(60));
        foreach (var n in names)
        {
            // 当前选中的高亮
            bool isCurrent = prop.stringValue == n;
            GUI.backgroundColor = isCurrent ? Color.cyan : Color.white;

            // 显示缩短的名称
            string display = n.Length > 14 ? n.Substring(0, 12) + ".." : n;
            if (GUILayout.Button(display, EditorStyles.miniButton, GUILayout.MinWidth(50)))
            {
                prop.stringValue = n;
            }
        }
        GUI.backgroundColor = Color.white;
        EditorGUILayout.EndHorizontal();
    }

    // ══════════════════════════════════════
    //  节点操作：创建 / 复制 / 删除
    // ══════════════════════════════════════
    private void CreateNewNode(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            EditorUtility.DisplayDialog("错误", "节点名称不能为空。", "确定");
            return;
        }

        // 检查重名
        if (allNodes.Any(n => n.nodeName == name))
        {
            EditorUtility.DisplayDialog("错误", $"已存在名为 \"{name}\" 的节点。", "确定");
            return;
        }

        EnsureFolderExists(DEFAULT_SAVE_FOLDER);

        string path = AssetDatabase.GenerateUniqueAssetPath($"{DEFAULT_SAVE_FOLDER}/{name}.asset");
        var node = CreateInstance<SkillNodeSO>();
        node.nodeName = name;
        node.maxPurchaseCount = 1;
        node.basePrice = 100;
        node.priceMultiplier = 1f;
        node.effectValue = 0f;
        node.isUnlockType = false;

        AssetDatabase.CreateAsset(node, path);
        AssetDatabase.SaveAssets();

        RefreshNodeList();
        selectedIndex = allNodes.IndexOf(node);
        newNodeName = "NewSkill";

        EditorUtility.FocusProjectWindow();
        Selection.activeObject = node;
    }

    private void DuplicateNode(SkillNodeSO source)
    {
        string folder = Path.GetDirectoryName(AssetDatabase.GetAssetPath(source));
        if (string.IsNullOrEmpty(folder)) folder = DEFAULT_SAVE_FOLDER;

        EnsureFolderExists(folder);

        string newName = source.nodeName + "_Copy";
        string path = AssetDatabase.GenerateUniqueAssetPath($"{folder}/{newName}.asset");

        var copy = Instantiate(source);
        copy.nodeName = newName;

        AssetDatabase.CreateAsset(copy, path);
        AssetDatabase.SaveAssets();

        RefreshNodeList();
        selectedIndex = allNodes.IndexOf(copy);
    }

    private void DeleteNode(SkillNodeSO node)
    {
        string path = AssetDatabase.GetAssetPath(node);
        selectedIndex = -1;
        AssetDatabase.DeleteAsset(path);
        AssetDatabase.SaveAssets();
        RefreshNodeList();
    }

    // ══════════════════════════════════════
    //  数据加载 / 筛选
    // ══════════════════════════════════════
    private void RefreshNodeList()
    {
        allNodes.Clear();
        string[] guids = AssetDatabase.FindAssets("t:SkillNodeSO");
        foreach (string guid in guids)
        {
            string path = AssetDatabase.GUIDToAssetPath(guid);
            var node = AssetDatabase.LoadAssetAtPath<SkillNodeSO>(path);
            if (node != null)
                allNodes.Add(node);
        }
        // 按名称排序
        allNodes.Sort((a, b) => string.Compare(a.nodeName, b.nodeName, System.StringComparison.Ordinal));

        // 修正选中索引
        if (selectedIndex >= allNodes.Count)
            selectedIndex = allNodes.Count - 1;
    }

    private List<SkillNodeSO> GetFilteredNodes()
    {
        return allNodes.Where(n =>
        {
            // 搜索过滤
            if (!string.IsNullOrEmpty(searchText))
            {
                bool matchName = (n.nodeName ?? "").ToLower().Contains(searchText.ToLower());
                bool matchEvent = (n.effectEventName ?? "").ToLower().Contains(searchText.ToLower());
                if (!matchName && !matchEvent) return false;
            }

            // 类型过滤
            if (filterType == FilterType.UnlockType && !n.isUnlockType) return false;
            if (filterType == FilterType.StackType && n.isUnlockType) return false;

            // 资源过滤
            if (filterResource.HasValue && n.costResource != filterResource.Value) return false;

            return true;
        }).ToList();
    }

    // ══════════════════════════════════════
    //  工具方法
    // ══════════════════════════════════════
    private void InitStyles()
    {
        if (stylesInitialized) return;
        stylesInitialized = true;

        headerStyle = new GUIStyle(EditorStyles.boldLabel)
        {
            fontSize = 13,
            margin = new RectOffset(0, 0, 6, 4)
        };

        selectedBtnStyle = new GUIStyle(GUI.skin.button)
        {
            fontStyle = FontStyle.Bold,
            normal = { textColor = Color.white, background = MakeTex(1, 1, new Color(0.2f, 0.5f, 0.8f)) },
            hover = { textColor = Color.white, background = MakeTex(1, 1, new Color(0.3f, 0.6f, 0.9f)) }
        };
    }

    private void DrawSectionHeader(string title)
    {
        EditorGUILayout.Space(2);
        var rect = EditorGUILayout.GetControlRect(false, 20);
        EditorGUI.DrawRect(rect, new Color(0.22f, 0.22f, 0.22f));
        rect.x += 6;
        EditorGUI.LabelField(rect, title, EditorStyles.boldLabel);
        EditorGUILayout.Space(2);
    }

    private void DrawSeparator()
    {
        var rect = EditorGUILayout.GetControlRect(false, 1, GUILayout.Width(2));
        rect.height = position.height;
        EditorGUI.DrawRect(rect, new Color(0.15f, 0.15f, 0.15f));
    }

    private static void EnsureFolderExists(string folderPath)
    {
        if (AssetDatabase.IsValidFolder(folderPath)) return;

        string[] parts = folderPath.Split('/');
        string current = parts[0]; // "Assets"
        for (int i = 1; i < parts.Length; i++)
        {
            string next = current + "/" + parts[i];
            if (!AssetDatabase.IsValidFolder(next))
                AssetDatabase.CreateFolder(current, parts[i]);
            current = next;
        }
    }

    private static Texture2D MakeTex(int w, int h, Color col)
    {
        var pix = new Color[w * h];
        for (int i = 0; i < pix.Length; i++) pix[i] = col;
        var tex = new Texture2D(w, h);
        tex.SetPixels(pix);
        tex.Apply();
        return tex;
    }
}
