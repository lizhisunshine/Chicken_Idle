using UnityEngine;
using UnityEditor;

public class LevelEditorWindow : EditorWindow
{
    private LevelConfig config;
    private const float CELL_SIZE = 40f;

    // 菜单入口
    [MenuItem("Tools/Level Editor")]
    public static void OpenWindow()
    {
        GetWindow<LevelEditorWindow>("Level Editor");
    }

    private void OnGUI()
    {
        // 拖拽选择配置文件
        config = (LevelConfig)EditorGUILayout.ObjectField(
            "Level Config", config, typeof(LevelConfig), false);

        if (config == null)
        {
            EditorGUILayout.HelpBox("请拖入一个 LevelConfig", MessageType.Info);
            return;
        }

        EditorGUILayout.Space();

        // 地图尺寸设置
        EditorGUI.BeginChangeCheck();
        int newWidth = EditorGUILayout.IntField("宽度", config.mapWidth);
        int newHeight = EditorGUILayout.IntField("高度", config.mapHeight);

        // 尺寸改变时重新初始化
        if (EditorGUI.EndChangeCheck())
        {
            Undo.RecordObject(config, "Resize Map");
            config.mapWidth = Mathf.Max(1, newWidth);
            config.mapHeight = Mathf.Max(1, newHeight);
            config.InitLayout();
            EditorUtility.SetDirty(config);
        }

        config.tileSpacing = EditorGUILayout.FloatField("瓦片间距", config.tileSpacing);
        config.rockOffsetRange = EditorGUILayout.FloatField("岩石偏移范围", config.rockOffsetRange);
        config.rockCount = EditorGUILayout.IntField("岩石数量", config.rockCount);

        EditorGUILayout.Space();
        EditorGUILayout.LabelField("点击格子切换空洞/瓦片（灰=空洞 绿=瓦片）");
        EditorGUILayout.Space();

        // 确保数组长度正确
        if (config.mapLayout == null ||
            config.mapLayout.Length != config.mapWidth * config.mapHeight)
            config.InitLayout();

        // 绘制地图格子
        DrawMapGrid();

        EditorGUILayout.Space();

        // 快捷操作按钮
        EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("全部填充"))
        {
            Undo.RecordObject(config, "Fill All");
            for (int i = 0; i < config.mapLayout.Length; i++)
                config.mapLayout[i] = 1;
            EditorUtility.SetDirty(config);
        }
        if (GUILayout.Button("全部清空"))
        {
            Undo.RecordObject(config, "Clear All");
            for (int i = 0; i < config.mapLayout.Length; i++)
                config.mapLayout[i] = 0;
            EditorUtility.SetDirty(config);
        }
        EditorGUILayout.EndHorizontal();
    }

    private void DrawMapGrid()
    {
        for (int row = 0; row < config.mapHeight; row++)
        {
            EditorGUILayout.BeginHorizontal();
            for (int col = 0; col < config.mapWidth; col++)
            {
                int index = row * config.mapWidth + col;
                bool isTile = config.mapLayout[index] == 1;

                // 有瓦片=绿色，空洞=灰色
                GUI.backgroundColor = isTile ? Color.green : Color.gray;

                if (GUILayout.Button("", GUILayout.Width(CELL_SIZE), GUILayout.Height(CELL_SIZE)))
                {
                    Undo.RecordObject(config, "Toggle Tile");
                    config.mapLayout[index] = isTile ? 0 : 1; // 点击切换
                    EditorUtility.SetDirty(config);
                }
            }
            EditorGUILayout.EndHorizontal();
        }
        GUI.backgroundColor = Color.white; // 重置颜色
    }
}