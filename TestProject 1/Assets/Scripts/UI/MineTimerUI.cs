using UnityEngine;
using TMPro;

/// <summary>
/// 挖矿倒计时UI：挂在一个 TextMeshProUGUI 物体上。
/// 始终可见，未开始时显示初始时间，倒计时结束后停在 00:00。
/// </summary>
public class MineTimerUI : MonoBehaviour
{
    [Tooltip("倒计时文字组件（不填则自动获取自身的TMP）")]
    public TextMeshProUGUI timerText;

    [Tooltip("剩余多少秒时文字变红")]
    public float warningThreshold = 3f;

    [Tooltip("正常颜色")]
    public Color normalColor = Color.white;

    [Tooltip("警告颜色")]
    public Color warningColor = Color.red;

    private void Awake()
    {
        if (timerText == null)
            timerText = GetComponent<TextMeshProUGUI>();

        // 不再隐藏，始终可见
        timerText.text = "--:--";
        timerText.color = normalColor;
    }

    private void OnEnable()
    {
        Debug.Log("[MineTimerUI] OnEnable，开始订阅事件");
        EventCenter.Instance.AddEventListener(MineTimer.EVENT_MINE_START, OnMineStart);
        EventCenter.Instance.AddEventListener<float>(MineTimer.EVENT_TIMER_TICK, OnTick);
        EventCenter.Instance.AddEventListener(MineTimer.EVENT_TIME_UP, OnTimeUp);
    }

    private void OnDisable()
    {
        Debug.Log("[MineTimerUI] OnDisable，取消订阅事件");
        EventCenter.Instance.RemoveEventListener(MineTimer.EVENT_MINE_START, OnMineStart);
        EventCenter.Instance.RemoveEventListener<float>(MineTimer.EVENT_TIMER_TICK, OnTick);
        EventCenter.Instance.RemoveEventListener(MineTimer.EVENT_TIME_UP, OnTimeUp);
    }

    private void OnMineStart()
    {
        Debug.Log("[MineTimerUI] 收到 OnMineStart 事件");
        timerText.color = normalColor;
    }

    private void OnTick(float timeLeft)
    {
        int sec = (int)timeLeft;
        int ms = (int)((timeLeft - sec) * 100);
        timerText.text = $"{sec:00}:{ms:00}";

        timerText.color = timeLeft <= warningThreshold ? warningColor : normalColor;
    }

    private void OnTimeUp()
    {
        Debug.Log("[MineTimerUI] 收到 OnTimeUp 事件");
        timerText.text = "00:00";
        timerText.color = warningColor;
        // 停在 00:00，不隐藏
    }
}
