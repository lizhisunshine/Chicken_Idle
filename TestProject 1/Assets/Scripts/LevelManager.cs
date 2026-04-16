using System;
using System.Collections;
using System.Collections.Generic;
//using UnityEditor.PackageManager;
using UnityEngine;



public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;

    public GameState gameState;

    //关卡倒计时时间
    public float LevelTime;

    [Header("过场动画ui")]
    [SerializeField] GameObject Cutscene;
    [Header("开始ui")]
    [SerializeField] GameObject StartUi;
    [Header("商店场景ui")]
    [SerializeField] GameObject ShopUi;
    [Header("挖矿场景ui")]
    [SerializeField] GameObject MiningUi;

    private void Awake()
    {
        Instance = this;

        //gameState = GameState.Shoping;
    }
    // Start is called before the first frame update
    void Start()
    {
        EnterLevel();

        //计时器结束时，退出关卡
        EventCenter.Instance.AddEventListener("OnMineTimeUp", LevelComplete);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadLevel()
    {
        MapManager.instance.CreatMap();
    }

    /// <summary>
    /// 进入关卡的方法
    /// </summary>
    public void EnterLevel()
    {
        Debug.Log($"[LevelManager] EnterLevel 开始，startingOreCount={GameManager.instance.startingOreCount}");

        //清除石头
        OreManager.instance.ClearOreAndRock();

        //关闭商店ui，打开关卡ui
        ShopUi.SetActive(false);
        MiningUi.SetActive(true);

        //创建关卡
        LoadLevel();

        Debug.Log($"[LevelManager] LoadLevel 完成，准备生成 {GameManager.instance.startingOreCount} 个岩石");
        
        //创建岩石
        for (int i = 0; i < GameManager.instance.startingOreCount; i++)
        {
            Vector3 pos = MapManager.instance.GetRandomSpawnPos();
            Debug.Log($"[LevelManager] 生成岩石 [{i}]，位置={pos}");
            OreManager.instance.CreatRock(pos);
        }

        Debug.Log($"[LevelManager] 岩石生成完成");

        //启动计时器
        MineTimer.instance.StartTimer();
    }

    /// <summary>
    /// 退出关卡的方法
    /// </summary>
    public void ExitLevel()
    {
        //关闭关卡ui，打开商店ui
        ShopUi.SetActive(true);
        MiningUi.SetActive(false);

        //清除地图
        MapManager.instance.ClearMap();
        
    }


    /// <summary>
    /// 计时器到0后结束关卡的方法
    /// </summary>
    public void LevelComplete()
    {
        foreach (E_OreType type in Enum.GetValues(typeof(E_OreType)))
        {
            OreManager.instance.AddIngot(type, OreManager.instance.oreDic[type]);
        }
    }



}
