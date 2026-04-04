using UnityEngine;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// 挂在技能树面板中每个技能按钮上。
/// 只负责：显示图标状态 + 点击时通知 SkillDetailPanel 打开。
/// </summary>
public class SkillNodeUI : MonoBehaviour
{
    [Header("绑定数据")]
    [Tooltip("拖入该按钮对应的 SkillNodeSO 文件")]
    public SkillNodeSO nodeData;

    [Header("按钮表面UI")]
    [Tooltip("技能图标")]
    public Image iconImage;
    [Tooltip("可购买时显示的提示标记")]
    public GameObject plusIndicator;
    [Tooltip("已满级时显示的标记")]
    public GameObject maxedIndicator;

    private SkillNodeRuntime runtime;

    private void Start()
    {
        // ── 调试：检查关键依赖 ──
        if (nodeData == null)
            Debug.LogError($"[SkillNodeUI] {gameObject.name} 的 nodeData 未赋值！请在Inspector拖入SO文件", this);

        if (SkillTreeManager.instance == null)
            Debug.LogError($"[SkillNodeUI] SkillTreeManager.instance 为空！确认场景中有挂载 SkillTreeManager 的物体", this);

        if (SkillDetailPanel.instance == null)
            Debug.LogError($"[SkillNodeUI] SkillDetailPanel.instance 为空！确认场景中有挂载 SkillDetailPanel 的物体，且该物体的Awake已执行", this);

        var btn = GetComponent<Button>();
        if (btn == null)
            Debug.LogError($"[SkillNodeUI] {gameObject.name} 上没有 Button 组件！", this);

        runtime = SkillTreeManager.instance.GetNode(nodeData);
        Debug.Log($"[SkillNodeUI] {gameObject.name} 初始化完成，绑定节点：{nodeData.nodeName}");

        if (iconImage != null && nodeData.icon != null)
            iconImage.sprite = nodeData.icon;

        btn.onClick.AddListener(OnClick);

        EventCenter.Instance.AddEventListener<SkillNodeSO>(
            SkillTreeManager.EVENT_SKILL_PURCHASED, OnAnySkillPurchased);
        EventCenter.Instance.AddEventListener(
            "OnResourceChanged", RefreshButton);

        RefreshButton();
    }

    private void OnDestroy()
    {
        EventCenter.Instance.RemoveEventListener<SkillNodeSO>(
            SkillTreeManager.EVENT_SKILL_PURCHASED, OnAnySkillPurchased);
        EventCenter.Instance.RemoveEventListener(
            "OnResourceChanged", RefreshButton);
    }

    private void OnClick()
    {
        Debug.Log($"[SkillNodeUI] 点击了 {nodeData.nodeName}");

        if (SkillDetailPanel.instance == null)
        {
            Debug.LogError("[SkillNodeUI] SkillDetailPanel.instance 为空！面板可能在Awake中SetActive(false)后instance未赋值，或场景中没有该物体");
            return;
        }

        Debug.Log($"[SkillNodeUI] 调用 SkillDetailPanel.Show()，面板物体：{SkillDetailPanel.instance.gameObject.name}，当前active={SkillDetailPanel.instance.gameObject.activeSelf}");
        SkillDetailPanel.instance.Show(nodeData);
    }

    private void OnAnySkillPurchased(SkillNodeSO node) => RefreshButton();

    private void RefreshButton()
    {
        if (runtime == null) return;

        if (plusIndicator != null) plusIndicator.SetActive(runtime.CanPurchase());
        if (maxedIndicator != null) maxedIndicator.SetActive(runtime.IsMaxed);
        if (iconImage != null)
            iconImage.color = runtime.IsUnlocked ? Color.white : new Color(0.4f, 0.4f, 0.4f);
    }
}
