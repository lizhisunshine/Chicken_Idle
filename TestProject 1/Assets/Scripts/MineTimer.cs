using UnityEngine;

/// <summary>
/// 挖矿计时器：独立模块，只负责倒计时。
/// 通过 EventCenter 广播事件，不直接操作任何其他系统。
///
/// 事件列表：
///   "OnMineStart"          — 挖矿开始（倒计时启动）
///   "OnMineTimerTick"      — 每帧触发，传递剩余时间 float
///   "OnMineSecondPassed"   — 每过1秒触发一次
///   "OnMineTimeUp"         — 时间到
/// </summary>
public class MineTimer : MonoBehaviour
{
    public static MineTimer instance;

    public const string EVENT_MINE_START = "OnMineStart";
    public const string EVENT_TIMER_TICK = "OnMineTimerTick";
    public const string EVENT_SECOND_PASSED = "OnMineSecondPassed";
    public const string EVENT_TIME_UP = "OnMineTimeUp";

    public bool IsMining { get; private set; }
    public float TimeLeft { get; private set; }

    private float totalTime;
    private float elapsed;
    private float secondAccumulator;

    private void Awake()
    {
        instance = this;
        Debug.Log("[MineTimer] Awake，instance 已赋值");
    }

    public void StartTimer(float duration)
    {
        Debug.Log($"[MineTimer] StartTimer 调用，时长={duration}秒");

        totalTime = duration;
        elapsed = 0f;
        secondAccumulator = 0f;
        TimeLeft = duration;
        IsMining = true;

        Debug.Log("[MineTimer] 触发 EVENT_MINE_START");
        EventCenter.Instance.EventTrigger(EVENT_MINE_START);
    }

    public void StartTimer()
    {
        float time = LevelManager.Instance.LevelTime;
        Debug.Log($"[MineTimer] StartTimer() 无参版本，从 LevelManager 读取时间={time}");
        StartTimer(time);
    }

    public void AddTime(float seconds)
    {
        if (!IsMining) return;
        totalTime += seconds;
        Debug.Log($"[MineTimer] AddTime({seconds})，新总时间={totalTime}");
    }

    public void StopTimer()
    {
        if (!IsMining) return;
        Debug.Log("[MineTimer] StopTimer 强制停止");
        IsMining = false;
        TimeLeft = 0f;
        EventCenter.Instance.EventTrigger(EVENT_TIME_UP);
    }

    private void Update()
    {
        if (!IsMining) return;

        elapsed += Time.deltaTime;
        TimeLeft = Mathf.Max(0f, totalTime - elapsed);

        EventCenter.Instance.EventTrigger<float>(EVENT_TIMER_TICK, TimeLeft);

        secondAccumulator += Time.deltaTime;
        if (secondAccumulator >= 1f)
        {
            secondAccumulator -= 1f;
            EventCenter.Instance.EventTrigger(EVENT_SECOND_PASSED);
        }

        if (TimeLeft <= 0f)
        {
            Debug.Log("[MineTimer] 时间到！触发 EVENT_TIME_UP");
            IsMining = false;
            EventCenter.Instance.EventTrigger(EVENT_TIME_UP);
        }
    }
}
