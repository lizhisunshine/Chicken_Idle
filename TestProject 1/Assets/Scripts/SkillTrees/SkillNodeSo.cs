using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SkillTree/SkillNode")]
public class SkillNodeSO : ScriptableObject
{
    [Header("基本信息")]
    public string nodeName;
    [Header("技能简介")]// 唯一标识符，同时作为存档key，确定后不要改
    [TextArea] public string description;
    public Sprite icon;

    [Header("购买配置")]
    public int maxPurchaseCount;    // 最大购买次数（解锁型填1）
    public double basePrice;        // 基础价格
    public float priceMultiplier;   // 涨价倍数（不涨价填1）

    [Header("消耗资源")]
    public E_OreType costResource;  // 消耗哪种矿条（对应OreManager.ingotDic）

    [Header("前置条件")]
    public SkillNodeSO[] prerequisites; // 所有前置节点都购买过才解锁，空=无前置

    [Header("效果配置")]
    public string effectEventName;  // 购买时触发的事件名，各系统通过此名响应
    public float effectValue;       // 效果数值（解锁型填0）
    public bool isUnlockType;       // true=解锁型（购买一次解锁功能），false=叠加型
}
