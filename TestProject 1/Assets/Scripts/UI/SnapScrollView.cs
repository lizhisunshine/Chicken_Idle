using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using DG.Tweening;

/// <summary>
/// 左右滚动吸附选择器：挂在 ScrollView 物体上。
/// Content 下的每个子物体就是一个页面，滑动结束后自动吸附到最近的页面。
/// 
/// 搭建方式：
/// 1. 创建 ScrollView，取消 Vertical，勾选 Horizontal
/// 2. Content 上挂 HorizontalLayoutGroup + ContentSizeFitter(Horizontal=Preferred)
/// 3. 每个子Panel宽度 = ScrollView视口宽度
/// 4. 把此脚本挂在 ScrollView 物体上
/// 5. 可选：拖入左右箭头按钮
/// </summary>
[RequireComponent(typeof(ScrollRect))]
public class SnapScrollView : MonoBehaviour, IEndDragHandler, IBeginDragHandler
{
    [Header("吸附设置")]
    [Tooltip("吸附动画时长")]
    public float snapDuration = 0.3f;
    [Tooltip("吸附动画曲线")]
    public Ease snapEase = Ease.OutCubic;

    [Header("可选：左右箭头按钮")]
    [Tooltip("左箭头按钮，不需要可留空")]
    public Button leftButton;
    [Tooltip("右箭头按钮，不需要可留空")]
    public Button rightButton;

    [Header("可选：页面指示器小圆点")]
    [Tooltip("指示器小圆点的父物体，不需要可留空。子物体数量需与页面数一致")]
    public Transform dotsParent;
    [Tooltip("小圆点激活颜色")]
    public Color dotActiveColor = Color.white;
    [Tooltip("小圆点未激活颜色")]
    public Color dotInactiveColor = new Color(1, 1, 1, 0.3f);

    /// <summary>
    /// 当前页面索引
    /// </summary>
    public int CurrentIndex { get; private set; }

    /// <summary>
    /// 总页面数
    /// </summary>
    public int PageCount { get; private set; }

    private ScrollRect scrollRect;
    private bool isDragging;
    private float[] pagePositions; // 每个页面对应的 normalizedPosition (0~1)
    private Tweener snapTween;

    private void Awake()
    {
        scrollRect = GetComponent<ScrollRect>();
    }

    private void Start()
    {
        InitPages();

        if (leftButton != null)
            leftButton.onClick.AddListener(GoLeft);
        if (rightButton != null)
            rightButton.onClick.AddListener(GoRight);

        // 初始吸附到第一页
        SnapToPage(0, 0f);
    }

    /// <summary>
    /// 计算每个页面的归一化位置
    /// </summary>
    private void InitPages()
    {
        PageCount = scrollRect.content.childCount;

        if (PageCount <= 1)
        {
            pagePositions = new float[] { 0f };
            return;
        }

        pagePositions = new float[PageCount];
        for (int i = 0; i < PageCount; i++)
        {
            pagePositions[i] = (float)i / (PageCount - 1);
        }
    }

    // ════════════════════════════════════
    //  拖拽事件
    // ════════════════════════════════════

    public void OnBeginDrag(PointerEventData eventData)
    {
        isDragging = true;
        // 拖拽开始时停止正在进行的吸附动画
        snapTween?.Kill();
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        isDragging = false;
        // 拖拽结束，吸附到最近的页面
        SnapToNearest();
    }

    // ════════════════════════════════════
    //  左右按钮
    // ════════════════════════════════════

    public void GoLeft()
    {
        if (CurrentIndex > 0)
            SnapToPage(CurrentIndex - 1);
    }

    public void GoRight()
    {
        if (CurrentIndex < PageCount - 1)
            SnapToPage(CurrentIndex + 1);
    }

    // ════════════════════════════════════
    //  吸附逻辑
    // ════════════════════════════════════

    /// <summary>
    /// 吸附到最近的页面
    /// </summary>
    private void SnapToNearest()
    {
        float currentPos = scrollRect.horizontalNormalizedPosition;
        int nearest = 0;
        float minDist = float.MaxValue;

        for (int i = 0; i < pagePositions.Length; i++)
        {
            float dist = Mathf.Abs(currentPos - pagePositions[i]);
            if (dist < minDist)
            {
                minDist = dist;
                nearest = i;
            }
        }

        SnapToPage(nearest);
    }

    /// <summary>
    /// 吸附到指定页面
    /// </summary>
    public void SnapToPage(int index, float duration = -1f)
    {
        if (index < 0 || index >= PageCount) return;
        if (duration < 0f) duration = snapDuration;

        CurrentIndex = index;
        snapTween?.Kill();

        float target = pagePositions[index];

        if (duration <= 0f)
        {
            scrollRect.horizontalNormalizedPosition = target;
        }
        else
        {
            snapTween = DOTween.To(
                () => scrollRect.horizontalNormalizedPosition,
                x => scrollRect.horizontalNormalizedPosition = x,
                target,
                duration
            ).SetEase(snapEase);
        }

        UpdateDots();
        UpdateArrowButtons();
    }

    // ════════════════════════════════════
    //  指示器 & 箭头状态
    // ════════════════════════════════════

    private void UpdateDots()
    {
        if (dotsParent == null) return;

        for (int i = 0; i < dotsParent.childCount; i++)
        {
            var img = dotsParent.GetChild(i).GetComponent<Image>();
            if (img != null)
                img.color = (i == CurrentIndex) ? dotActiveColor : dotInactiveColor;
        }
    }

    private void UpdateArrowButtons()
    {
        if (leftButton != null)
            leftButton.interactable = CurrentIndex > 0;
        if (rightButton != null)
            rightButton.interactable = CurrentIndex < PageCount - 1;
    }
}
