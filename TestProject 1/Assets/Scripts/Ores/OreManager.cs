using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/// <summary>
/// 矿物（游戏对象）类型枚举
/// </summary>
public enum E_RockType
{ 
    //none,
    Rock,
    /// <summary>
    /// 金矿石
    /// </summary>
    ChunkGold,
    FullGold,
    /// <summary>
    ///铜矿石
    /// </summary>
    ChunkCopper,
    FullCopper,
    /// <summary>
    /// 铁矿石
    /// </summary>
    ChunkIron,
    FullIron,
    /// <summary>
    /// 铬矿石
    /// </summary>
    ChunkChromium,
    FullChromium,
    /// <summary>
    /// 铀矿石
    /// </summary>
    ChunkUranium,
    FullUranium,
    /// <summary>
    /// 锇矿石
    /// </summary>
    ChunkOsmium,
    FullOsmium,
    /// <summary>
    /// 电气石
    /// </summary>
    ChunkTourmaline,
    FullTourmaline,
    /// <summary>
    /// 铱矿石
    /// </summary>
    ChunkIridium,
    FullIridium,
}

/// <summary>
/// 矿石资源类型枚举
/// </summary>
public enum E_OreType
{ 
    Gold,
    Copper,
    Iron,
    Chromium,
    Uranium,
    Osmium,
    Tourmaline,
    Iridium,
}

public class OreManager : MonoBehaviour
{
    public static OreManager instance;

    /// <summary>
    /// 矿石数量字典
    /// </summary>
    public Dictionary<E_OreType,float> oreDic = new();
    /// <summary>
    /// 矿锭数量字典
    /// </summary>
    public Dictionary<E_OreType,float> ingotDic = new();

    /// <summary>
    /// 矿石/矿锭转换系数，含义为一个矿锭需要的矿石数量
    /// </summary>
    public float oreToIngotRatio;
    /// <summary>
    /// 矿石血量
    /// </summary>
    public float Health;

    //半块矿物生成矿石数
    public float chunkOreSpawnCount = 3;
    
    //整块矿石生成矿石数
    public float fullOreSpawnCount = 7;

    //矿石获取乘数
    public float OreMultiplier = 1;

    /// <summary>
    /// 当生成的时候，各种矿物的概率
    /// </summary>
    public float fullRock = 0; 
    public float chunkGoldChance = 0;
    public float fullGoldChance = 0;
    public float chunkCopperChance = 0;
    public float fullCopperChance = 0;
    public float chunkIronChance = 0;
    public float fullIronChance = 0;
    public float chunkChromiumChance = 0;
    public float fullChromiumChance = 0;
    public float chunkUraniumChance = 0;
    public float fullUraniumChance = 0;
    public float chunkOsmiumChance = 0;
    public float fullOsmiumChance = 0;
    public float chunkTourmalineChance = 0;
    public float fullTourmalineChance = 0;
    public float chunkIridiumChance = 0;
    public float fullIridiumChance = 0;


    public void Awake()
    {
        instance = this;

        //对字典遍历赋值
        foreach (E_OreType ore in Enum.GetValues(typeof(E_OreType)))
        {
            if (!oreDic.ContainsKey(ore))
            { 
                oreDic.Add(ore, 0);
            }
        }
        foreach (E_OreType ore in Enum.GetValues(typeof(E_OreType)))
        {
            if (!ingotDic.ContainsKey(ore))
            {
                ingotDic.Add(ore, 0);
            }
        }
    }

    private void OnEnable()
    {
        //订阅事件，通知者为SkillTreeManager
        EventCenter.Instance.AddEventListener<SkillNodeSO>(
            SkillTreeManager.EVENT_SKILL_PURCHASED, OnSkillPurchased);
    }

    private void OnDisable()
    {
        //退订
        EventCenter.Instance.RemoveEventListener<SkillNodeSO>(
            SkillTreeManager.EVENT_SKILL_PURCHASED, OnSkillPurchased);
    }

    private void OnSkillPurchased(SkillNodeSO node)
    {
        switch (node.effectEventName)
        {
            // ── 矿石概率叠加 ──
            case "chunkGoldChance": chunkGoldChance += node.effectValue; break;
            case "fullGoldChance": fullGoldChance += node.effectValue; break;
            case "chunkCopperChance": chunkCopperChance += node.effectValue; break;
            case "fullCopperChance": fullCopperChance += node.effectValue; break;
            case "chunkIronChance": chunkIronChance += node.effectValue; break;
            case "fullIronChance": fullIronChance += node.effectValue; break;
            case "chunkChromiumChance": chunkChromiumChance += node.effectValue; break;
            case "fullChromiumChance": fullChromiumChance += node.effectValue; break;
            case "chunkUraniumChance": chunkUraniumChance += node.effectValue; break;
            case "fullUraniumChance": fullUraniumChance += node.effectValue; break;
            case "chunkOsmiumChance": chunkOsmiumChance += node.effectValue; break;
            case "fullOsmiumChance": fullOsmiumChance += node.effectValue; break;
            case "chunkTourmalineChance": chunkTourmalineChance += node.effectValue; break;
            case "fullTourmalineChance": fullTourmalineChance += node.effectValue; break;
            case "chunkIridiumChance": chunkIridiumChance += node.effectValue; break;
            case "fullIridiumChance": fullIridiumChance += node.effectValue; break;

            // ── 矿石产出倍率 ──
            case "oreMultiplier": OreMultiplier += node.effectValue; break;
            case "chunkOreCount": chunkOreSpawnCount += node.effectValue; break;
            case "fullOreCount": fullOreSpawnCount += node.effectValue; break;

            // ── 解锁矿种（isUnlockType=true，effectValue=0）──
            // 解锁矿种只需要让概率从0变为有意义的值，
            // 实际概率由后续叠加型技能控制，这里只做标记
            case "unlockCopper":
                if (chunkCopperChance == 0) chunkCopperChance = 3f;
                if (fullCopperChance == 0) fullCopperChance = 2f;
                break;
            case "unlockIron":
                if (chunkIronChance == 0) chunkIronChance = 2.4f;
                if (fullIronChance == 0) fullIronChance = 1.7f;
                break;
            case "unlockChromium":
                if (chunkChromiumChance == 0) chunkChromiumChance = 1.5f;
                if (fullChromiumChance == 0) fullChromiumChance = 1.3f;
                break;
            case "unlockUranium":
                if (chunkUraniumChance == 0) chunkUraniumChance = 1.1f;
                if (fullUraniumChance == 0) fullUraniumChance = 1.0f;
                break;
            case "unlockOsmium":
                if (chunkOsmiumChance == 0) chunkOsmiumChance = 0.9f;
                if (fullOsmiumChance == 0) fullOsmiumChance = 0.8f;
                break;
            case "unlockTourmaline":
                if (chunkTourmalineChance == 0) chunkTourmalineChance = 0.7f;
                if (fullTourmalineChance == 0) fullTourmalineChance = 0.6f;
                break;
            case "unlockIridium":
                if (chunkIridiumChance == 0) chunkIridiumChance = 0.5f;
                if (fullIridiumChance == 0) fullIridiumChance = 0.4f;
                break;
        }
    }

    /// <summary>
    /// 当前场景中激活的岩石物体列表（动态变化）
    /// </summary>
    private List<GameObject> activeRocks = new();

    /// <summary>
    /// 创造矿石方法
    /// </summary>
    public void CreatRock(Vector3 vector)
    {
        GameObject rock = ObjectPool.instance.Get(ObjectPool.instance.prefabs[0], vector);
        activeRocks.Add(rock);
    }

    /// <summary>
    /// 从激活列表中移除（由 RockMechanics.OnDisable 调用）
    /// </summary>
    public void UnregisterRock(GameObject rock)
    {
        activeRocks.Remove(rock);
    }

    //添加矿石资源方法
    public void AddOre(E_OreType type)
    {
        oreDic[type] += OreMultiplier;
    }

    //计算并添加矿锭资源的方法
    public void AddIngot(E_OreType type,float a)
    {
        ingotDic[type] += (int)(a/oreToIngotRatio);
    }

    //清除所有岩石并重置矿石数量
    public void ClearOreAndRock()
    {
        // 先收回所有激活的岩石到对象池
        for (int i = activeRocks.Count - 1; i >= 0; i--)
        {
            ObjectPool.instance.Release(activeRocks[i]);
        }
        activeRocks.Clear();

        // 再清零矿石数量
        foreach (E_OreType ore in Enum.GetValues(typeof(E_OreType)))
        {
            oreDic[ore] = 0;
        }
    }

}
