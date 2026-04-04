using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 游戏状态枚举
/// </summary>
public enum GameState
{
    /// <summary>
    /// 商店状态，集成了技能书，天赋，铁砧，矿场，文物等一系列内容
    /// </summary>
    Shoping,
    /// <summary>
    /// 挖矿状态，仅处理挖矿时的内容
    /// </summary>
    Mining,
}

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    //挖掘时间
    public float mineTime;
    //挖掘概率
    public float minePower;
    //双倍概率
    public float doubleEffectChance;
    //挖掘区域大小 
    public float miningAreaSize;

    //当前关卡索引
    public int CurrentLevelIndex;
    //进入关卡时候生成的矿石数
    public int startingOreCount = 25;

    private void Awake()
    {
        instance = this;
    }
    private void OnEnable()
    {
        EventCenter.Instance.AddEventListener<SkillNodeSO>(
            SkillTreeManager.EVENT_SKILL_PURCHASED, OnSkillPurchased);
    }

    private void OnDisable()
    {
        EventCenter.Instance.RemoveEventListener<SkillNodeSO>(
            SkillTreeManager.EVENT_SKILL_PURCHASED, OnSkillPurchased);
    }

    private void OnSkillPurchased(SkillNodeSO node)
    {
        switch (node.effectEventName)
        {
            case "minePower": minePower += node.effectValue; break;
            case "mineTimeDecrease": mineTime += node.effectValue; break; 
            case "miningAreaSize": miningAreaSize += node.effectValue; break;
            case "doubleEffectChance": doubleEffectChance += node.effectValue; break;
            case "startingOreCount": startingOreCount += (int)node.effectValue; break;
        }
    }
}
