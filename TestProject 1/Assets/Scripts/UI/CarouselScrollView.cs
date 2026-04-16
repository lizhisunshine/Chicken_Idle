using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using DG.Tweening;

/// <summary>
/// 旋转木马滚动选择器：中间的卡片最大，越远越小越透明。
/// 支持拖拽滑动 + 左右按钮 + 吸附。
///
/// 搭建方式：
/// 1. 创建一个空的 RectTransform 作为容器，挂上此脚本
/// 2. 把所有卡片（Image/Panel）作为子物体放进去
/// 3. 脚本会自动排列和缩放，不需要 Layout Group
/// </summary>
public class CarouselScrollView : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [Header("布局")]
    [Tooltip("卡片之间的水平间距")]
    public float spacing = 200f;

    [Header("缩放效果")]
    [Tooltip("选中卡片的缩放")]
    public float selectedScale = 1f;
    [Tooltip("最远处卡片的最小缩放")]
    public float minScale = 0.5f;
    [Tooltip("缩放影响范围（几个卡片距离内从最大缩到最小）")]
    public float scaleRange = 2f;

    [Header("透明度效果")]
    [Tooltip("选中卡片的透明度")]
    public float selectedAlpha = 1f;
    [Tooltip("最远处卡片的最小透明度")]
    public float minAlpha = 0.3f;

    [Header("吸附")]
    [Tooltip("吸附动画时长")]
    public float snapDuration = 0.25f;

    [Header("可选按钮")]
    public Button leftButton;
    public Button rightButton;

    /// <summary>
    /// 当前选中的卡片索引
    /// </summary>
    public int CurrentIndex { get; private set; }

    // 内部状态
    private List<RectTransform> cards = new();
    private List<CanvasGroup> cardGroups = new();
    private float currentOffset;   // 当前滚动偏移量（像素）
    private float targetOffset;    // 吸附目标偏移量
    private bool isDragging;
    private float dragStartOffset;
    private Vector2 dragStartPos;
    private Tweener snapTween;

    private void Awake()
    {
        // 收集所有子物体作为卡片
        for (int i = 0; i < transform.childCount; i++)
        {
            var child = transform.GetChild(i) as RectTransform;
            if (child == null) continue;

            cards.Add(child);

            // 确保每张卡片有 CanvasGroup（用于控制透明度）
            var cg = child.GetComponent<CanvasGroup>();
            if (cg == null) cg = child.gameObject.AddComponent<CanvasGroup>();
            cardGroups.Add(cg);
        }

        if (leftButton != null) leftButton.onClick.AddListener(GoLeft);
        if (rightButton != null) rightButton.onClick.AddListener(GoRight);

        // 初始偏移为0（第一张卡片居中）
        currentOffset = 0f;
        targetOffset = 0f;
    }

    private void Start()
    {
        UpdateCarousel();
    }

    // ════════════════════════════════════
    //  拖拽
    // ════════════════════════════════════

    public void OnBeginDrag(PointerEventData eventData)
    {
        isDragging = true;
        snapTween?.Kill();
        dragStartOffset = currentOffset;
        dragStartPos = eventData.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        float delta = eventData.position.x - dragStartPos.x;
        currentOffset = dragStartOffset - delta; // 向左拖 = offset增大 = 后面的卡片移到中间
        UpdateCarousel();
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        isDragging = false;
        SnapToNearest();
    }

    // ════════════════════════════════════
    //  按钮
    // ════════════════════════════════════

    public void GoLeft()
    {
        if (CurrentIndex > 0)
            SnapToIndex(CurrentIndex - 1);
    }

    public void GoRight()
    {
        if (CurrentIndex < cards.Count - 1)
            SnapToIndex(CurrentIndex + 1);
    }

    // ════════════════════════════════════
    //  吸附
    // ════════════════════════════════════

    private void SnapToNearest()
    {
        // 根据当前偏移量算出最近的索引
        int nearest = Mathf.RoundToInt(currentOffset / spacing);
        nearest = Mathf.Clamp(nearest, 0, cards.Count - 1);
        SnapToIndex(nearest);
    }

    public void SnapToIndex(int index)
    {
        index = Mathf.Clamp(index, 0, cards.Count - 1);
        CurrentIndex = index;
        targetOffset = index * spacing;

        snapTween?.Kill();
        snapTween = DOTween.To(() => currentOffset, x =>
        {
            currentOffset = x;
            UpdateCarousel();
        }, targetOffset, snapDuration).SetEase(Ease.OutCubic);

        UpdateButtons();
    }

    // ════════════════════════════════════
    //  核心：更新所有卡片的位置、缩放、透明度、层级
    // ════════════════════════════════════

    private void UpdateCarousel()
    {
        for (int i = 0; i < cards.Count; i++)
        {
            // 该卡片相对于中心的偏移（单位：卡片个数）
            float distInCards = (i * spacing - currentOffset) / spacing;
            float absDist = Mathf.Abs(distInCards);

            // 位置：水平偏移
            float xPos = distInCards * spacing;
            cards[i].anchoredPosition = new Vector2(xPos, 0f);

            // 缩放：距离越远越小
            float t = Mathf.Clamp01(absDist / scaleRange);
            float scale = Mathf.Lerp(selectedScale, minScale, t);
            cards[i].localScale = Vector3.one * scale;

            // 透明度：距离越远越透明
            float alpha = Mathf.Lerp(selectedAlpha, minAlpha, t);
            cardGroups[i].alpha = alpha;

            // 层级排序：距离越近的排在越前面（sibling index 越大越前面）
            // 先收集距离，后面统一排序
        }

        // 按距离排序层级：离中心越近的 sibling index 越大（渲染在最前面）
        var sorted = new List<(int index, float dist)>();
        for (int i = 0; i < cards.Count; i++)
        {
            float dist = Mathf.Abs(i * spacing - currentOffset);
            sorted.Add((i, dist));
        }
        sorted.Sort((a, b) => b.dist.CompareTo(a.dist)); // 远的先设（排在后面）
        for (int i = 0; i < sorted.Count; i++)
        {
            cards[sorted[i].index].SetSiblingIndex(i);
        }
    }

    private void UpdateButtons()
    {
        if (leftButton != null) leftButton.interactable = CurrentIndex > 0;
        if (rightButton != null) rightButton.interactable = CurrentIndex < cards.Count - 1;
    }
}
