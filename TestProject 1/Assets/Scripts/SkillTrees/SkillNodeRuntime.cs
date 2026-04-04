using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;
using UnityEngine;

public class SkillNodeRuntime 
{
    public SkillNodeSO data;
    public int purchaseCount;

    // 当前价格（随购买次数自动涨价）
    public double CurrentPrice =>
        data.basePrice * Math.Pow(data.priceMultiplier, purchaseCount);

    // 是否已达购买上限
    public bool IsMaxed => purchaseCount >= data.maxPurchaseCount;

    // 前置节点是否全部已购买（空数组=直接解锁）
    public bool IsUnlocked =>
        data.prerequisites == null ||
        data.prerequisites.Length == 0 ||
        data.prerequisites.All(p => SkillTreeManager.instance.GetNode(p).purchaseCount > 0);

    // 资源是否足够（从OreManager.ingotDic查询）
    public bool CanAfford()
    {
        if (OreManager.instance == null) return false;
        return OreManager.instance.ingotDic[data.costResource] >= (float)CurrentPrice;
    }

    // 综合判断：可以购买
    public bool CanPurchase() => !IsMaxed && IsUnlocked && CanAfford();



}
