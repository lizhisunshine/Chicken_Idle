using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;

    public GameState gameState;

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
        //LoadLevel();
        //for (int i = 0; i < GameManager.instance.startingOreCount; i++)
        //{
        //    OreManager.instance.CreatRock(MapManager.instance.GetRandomSpawnPos());
        //}

        LoadLevel();
        Debug.Log("开始生成岩石，数量：" + GameManager.instance.startingOreCount);
        for (int i = 0; i < GameManager.instance.startingOreCount; i++)
        {
            Vector3 pos = MapManager.instance.GetRandomSpawnPos();
            Debug.Log("生成岩石位置：" + pos);
            OreManager.instance.CreatRock(pos);
        }
    }
    /// <summary>
    /// 退出关卡的方法
    /// </summary>
    public void ExitLevel() 
    {
        
        
    }
}
