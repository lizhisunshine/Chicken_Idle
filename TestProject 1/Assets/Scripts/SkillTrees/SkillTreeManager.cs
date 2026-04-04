using System.Collections.Generic;
using UnityEngine;

public class SkillTreeManager : MonoBehaviour
{
    public static SkillTreeManager instance;

    [Header("所有技能节点（拖入所有SO文件）")]
    public SkillNodeSO[] allNodes;

    // SO → 运行时状态
    private Dictionary<SkillNodeSO, SkillNodeRuntime> runtimeNodes = new();

    // 技能购买事件名（固定字符串，各系统用这个名字订阅）
    public const string EVENT_SKILL_PURCHASED = "OnSkillPurchased";

    private void Awake()
    {
        instance = this;
        foreach (var node in allNodes)
            runtimeNodes[node] = new SkillNodeRuntime { data = node };
    }

    // 获取某节点的运行时状态（供SkillNodeRuntime.IsUnlocked和UI调用）
    public SkillNodeRuntime GetNode(SkillNodeSO node) => runtimeNodes[node];

    /// <summary>
    /// 尝试购买技能。成功返回true，失败返回false。
    /// </summary>
    public bool TryPurchase(SkillNodeSO node)
    {
        var runtime = runtimeNodes[node];
        if (!runtime.CanPurchase()) return false;

        // 扣除矿条
        OreManager.instance.ingotDic[node.costResource] -= (float)runtime.CurrentPrice;

        // 购买次数+1
        runtime.purchaseCount++;

        // 通过EventCenter广播，传递节点数据
        // 使用带泛型的重载，携带SkillNodeSO参数
        EventCenter.Instance.EventTrigger(EVENT_SKILL_PURCHASED, node);

        // 同时触发资源变化事件，让UI刷新矿条显示
        EventCenter.Instance.EventTrigger("OnResourceChanged");

        return true;
    }

    /// <summary>
    /// 读档时恢复技能状态（不扣资源，但重新触发效果事件）
    /// </summary>
    public void LoadNode(SkillNodeSO node, int count)
    {
        var runtime = runtimeNodes[node];
        for (int i = 0; i < count; i++)
        {
            runtime.purchaseCount++;
            EventCenter.Instance.EventTrigger(EVENT_SKILL_PURCHASED, node);
        }
    }
}
