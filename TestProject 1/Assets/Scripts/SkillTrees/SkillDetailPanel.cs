using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

/// <summary>
/// 技能详情面板：场景中只有一个，由 SkillNodeUI 点击时调用 Show() 传入数据。
/// </summary>
public class SkillDetailPanel : MonoBehaviour
{
    public static SkillDetailPanel instance;

    [Header("UI组件")]
    [Tooltip("技能名称")] public TextMeshProUGUI detailName;
    [Tooltip("技能描述/效果说明")] public TextMeshProUGUI detailDesc;
    [Tooltip("购买进度，如 2/5")] public TextMeshProUGUI detailProgress;
    [Tooltip("当前价格")] public TextMeshProUGUI detailPrice;
    [Tooltip("效果数值说明")] public TextMeshProUGUI detailEffect;
    [Tooltip("购买按钮")] public Button buyButton;
    [Tooltip("购买按钮文字")] public TextMeshProUGUI buyButtonText;
    [Tooltip("关闭按钮")] public Button closeButton;

    [Header("资源图标（按 E_OreType 顺序：Gold, Copper, Iron, Chromium, Uranium, Osmium, Tourmaline, Iridium）")]
    [Tooltip("跟在价格数字后面的小图标，放在价格Text同一行的右侧")]
    public Image resourceIcon;
    [Tooltip("8个资源类型对应的Sprite，顺序必须和 E_OreType 枚举一致")]
    public Sprite[] resourceSprites = new Sprite[8];

    // 当前显示的节点数据
    private SkillNodeSO currentNode;
    private SkillNodeRuntime currentRuntime;

    private void Awake()
    {
        instance = this;
        Debug.Log($"[SkillDetailPanel] Awake 执行，instance 已赋值，物体：{gameObject.name}");
        gameObject.SetActive(false);
        Debug.Log($"[SkillDetailPanel] 已 SetActive(false)");

        if (buyButton != null)
            buyButton.onClick.AddListener(OnClickBuy);
        if (closeButton != null)
            closeButton.onClick.AddListener(Hide);
    }

    private void OnEnable()
    {
        EventCenter.Instance.AddEventListener<SkillNodeSO>(
            SkillTreeManager.EVENT_SKILL_PURCHASED, OnAnySkillPurchased);
        EventCenter.Instance.AddEventListener(
            "OnResourceChanged", Refresh);
    }

    private void OnDisable()
    {
        EventCenter.Instance.RemoveEventListener<SkillNodeSO>(
            SkillTreeManager.EVENT_SKILL_PURCHASED, OnAnySkillPurchased);
        EventCenter.Instance.RemoveEventListener(
            "OnResourceChanged", Refresh);
    }

    /// <summary>
    /// 由 SkillNodeUI 调用，传入要显示的节点
    /// </summary>
    public void Show(SkillNodeSO node)
    {
        Debug.Log($"[SkillDetailPanel] Show() 被调用，节点：{node.nodeName}");

        currentNode = node;
        currentRuntime = SkillTreeManager.instance.GetNode(node);

        if (currentRuntime == null)
        {
            Debug.LogError($"[SkillDetailPanel] GetNode 返回 null！节点 {node.nodeName} 可能没有加入 SkillTreeManager.allNodes 数组");
            return;
        }

        gameObject.SetActive(true);
        Debug.Log($"[SkillDetailPanel] SetActive(true)，当前 activeSelf={gameObject.activeSelf}，activeInHierarchy={gameObject.activeInHierarchy}");

        // 如果 activeInHierarchy 仍然是 false，说明父物体被隐藏了
        if (!gameObject.activeInHierarchy)
            Debug.LogWarning("[SkillDetailPanel] 面板的某个父物体处于隐藏状态！即使 SetActive(true) 也不会显示");

        transform.localScale = Vector3.one * 0.8f;
        transform.DOScale(Vector3.one, 0.15f).SetEase(Ease.OutBack);

        Refresh();
    }

    public void Hide()
    {
        transform.DOScale(Vector3.one * 0.8f, 0.1f)
            .SetEase(Ease.InBack)
            .OnComplete(() =>
            {
                gameObject.SetActive(false);
                currentNode = null;
                currentRuntime = null;
            });
    }

    private void OnAnySkillPurchased(SkillNodeSO node) => Refresh();

    private void OnClickBuy()
    {
        if (currentNode == null) return;
        if (SkillTreeManager.instance.TryPurchase(currentNode))
        {
            if (buyButton != null)
                buyButton.transform.DOPunchScale(Vector3.one * 0.15f, 0.3f);
        }
    }

    private void Refresh()
    {
        if (currentNode == null || currentRuntime == null) return;

        bool isMaxed = currentRuntime.IsMaxed;
        bool canAfford = currentRuntime.CanAfford();
        bool canPurchase = currentRuntime.CanPurchase();

        if (detailName != null)
            detailName.text = currentNode.nodeName;

        if (detailDesc != null)
            detailDesc.text = currentNode.description;

        if (detailProgress != null)
            detailProgress.text = $"{currentRuntime.purchaseCount} / {currentNode.maxPurchaseCount}";

        if (detailPrice != null)
        {
            if (isMaxed)
            {
                detailPrice.text = "已满级";
                detailPrice.color = Color.yellow;
            }
            else
            {
                detailPrice.text = currentRuntime.CurrentPrice.ToString("F0");
                detailPrice.color = canAfford ? Color.green : Color.red;
            }
        }

        if (detailEffect != null)
        {
            if (currentNode.isUnlockType)
            {
                bool unlocked = currentRuntime.purchaseCount > 0;
                detailEffect.text = unlocked ? "已解锁" : "未解锁";
                detailEffect.color = unlocked ? Color.green : Color.gray;
            }
            else
            {
                float total = currentNode.effectValue * currentRuntime.purchaseCount;
                detailEffect.text = isMaxed
                    ? $"效果：+{total:F2}（已满）"
                    : $"效果：+{total:F2}（下次 +{currentNode.effectValue:F2}）";
            }
        }

        // 资源图标：根据 costResource 切换对应的小图标
        if (resourceIcon != null && resourceSprites != null)
        {
            int idx = (int)currentNode.costResource;
            if (idx >= 0 && idx < resourceSprites.Length && resourceSprites[idx] != null)
            {
                resourceIcon.sprite = resourceSprites[idx];
                resourceIcon.gameObject.SetActive(!isMaxed); // 满级时隐藏资源图标
            }
        }

        if (buyButton != null)
            buyButton.interactable = canPurchase;

        if (buyButtonText != null)
        {
            if (isMaxed) buyButtonText.text = "已满级";
            else if (!currentRuntime.IsUnlocked) buyButtonText.text = "未解锁";
            else if (!canAfford) buyButtonText.text = "资源不足";
            else buyButtonText.text = "购买";
        }
    }
}
