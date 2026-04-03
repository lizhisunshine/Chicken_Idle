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

    /// <summary>
    /// 创造矿石方法
    /// </summary>
    public void CreatRock(Vector3 vector)
    {
        ObjectPool.instance.Get(ObjectPool.instance.prefabs[0], vector);
    }

    //添加矿石资源方法
    public void AddOre(E_OreType type)
    {
        //switch (type)
        //{ 
        //    case E_RockType.Rock:
        //        oreDic[E_OreType.Gold] += 1* OreMultiplier;
        //        break;
        //    case E_RockType.ChunkGold:
        //        oreDic[E_OreType.Gold] +=  OreMultiplier;
        //        break;
        //    case E_RockType.FullGold:
        //        oreDic[E_OreType.Gold] +=  OreMultiplier;
        //        break;
        //    case E_RockType.ChunkCopper:
        //        oreDic[E_OreType.Copper] += OreMultiplier;
        //        break;
        //    case E_RockType.FullCopper:
        //        oreDic[E_OreType.Copper] +=  OreMultiplier;
        //        break;
        //    case E_RockType.ChunkIron:
        //        oreDic[E_OreType.Copper] +=  OreMultiplier;
        //        break;
        //    case E_RockType.FullIron:
        //        oreDic[E_OreType.Copper] +=  OreMultiplier;
        //        break;
        //    case E_RockType.ChunkChromium:
        //        oreDic[E_OreType.Chromium] +=  OreMultiplier;
        //        break;
        //    case E_RockType.FullChromium:
        //        oreDic[E_OreType.Chromium] +=  OreMultiplier;
        //        break;
        //    case E_RockType.ChunkOsmium:
        //        oreDic[E_OreType.Osmium] +=  OreMultiplier;
        //        break;
        //    case E_RockType.FullOsmium:
        //        oreDic[E_OreType.Osmium] +=  OreMultiplier;
        //        break;
        //    case E_RockType.ChunkUranium:
        //        oreDic[E_OreType.Uranium] +=  OreMultiplier;
        //        break;
        //    case E_RockType.FullUranium:
        //        oreDic[E_OreType.Uranium] +=  OreMultiplier;
        //        break;
        //    case E_RockType.ChunkTourmaline:
        //        oreDic[E_OreType.Tourmaline] +=  OreMultiplier;
        //        break;
        //    case E_RockType.FullTourmaline:
        //        oreDic[E_OreType.Tourmaline] +=  OreMultiplier;
        //        break;
        //    case E_RockType.ChunkIridium:
        //        oreDic[E_OreType.Iridium] +=  OreMultiplier;
        //        break;
        //    case E_RockType.FullIridium:
        //        oreDic[E_OreType.Iridium] +=  OreMultiplier;
        //        break;
        //}

        oreDic[type] += OreMultiplier;
    }
}
