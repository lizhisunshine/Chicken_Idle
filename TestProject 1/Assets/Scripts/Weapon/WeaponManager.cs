using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public static WeaponManager instance;

    //挖掘时间
    public float mineTime;
    //挖掘概率
    public float minePower;
    //双倍概率
    public float doubleEffectChance;
    //挖掘区域大小 
    public float miningAreaSize;


    /// <summary>
    /// 武器列表,这个列表中的武器用来显示解锁情况
    /// </summary>
    public List<GameObject> WeaponList = new();

    /// <summary>
    /// 武器解锁数，记录当前解锁多少武器
    /// </summary>
    public int WeaponUnlockNum;

    /// <summary>
    /// 武器索引
    /// </summary>
    public int WeaponIndex;

    /// <summary>
    /// 武器字典
    /// </summary>
    public Dictionary<GameObject, Weapon> WeaponDic;

    /// <summary>
    /// 武器结构体
    /// </summary>
    public struct Weapon
    {
        //挖掘时间
        float mineTime;
        //挖掘概率
        float minePower;
        //双倍概率
        float doubleEffectChance;
        //挖掘区域大小 
        float miningAreaSize;
        //解锁状态
        bool UnLockd;


        public Weapon(float a,float b,float c, float d, bool e)
        { 
            mineTime = a;
            minePower = b;
            doubleEffectChance = c;
            miningAreaSize = d;
            UnLockd = e;
        }
    }
    private void Awake()
    {
        WeaponManager.instance = this;

        if (WeaponDic == null)
        {
            WeaponDic = new();
            WeaponDic.Add(WeaponList[0], new Weapon(0.34f, 2.5f, 0.011f, 1.21f,false));
            WeaponDic.Add(WeaponList[1], new Weapon(0.33f, 2.9f, 0.014f, 1.30f, false));
            WeaponDic.Add(WeaponList[2], new Weapon(0.32f, 3.3f, 0.019f, 1.40f, false));
            WeaponDic.Add(WeaponList[3], new Weapon(0.31f, 3.7f, 0.021f, 1.43f, false));
            WeaponDic.Add(WeaponList[4], new Weapon(0.30f, 3.9f, 0.023f, 1.47f, false));
            WeaponDic.Add(WeaponList[5], new Weapon(0.30f, 4.3f, 0.026f, 1.50f, false));
            WeaponDic.Add(WeaponList[6], new Weapon(0.285f, 4.7f, 0.029f, 1.52f, false));
            WeaponDic.Add(WeaponList[7], new Weapon(0.28f, 5.0f, 0.031f, 1.60f, false));
            WeaponDic.Add(WeaponList[8], new Weapon(0.27f, 5.2f, 0.038f, 1.60f, false));
            WeaponDic.Add(WeaponList[9], new Weapon(0.26f, 5.6f, 0.041f, 1.67f, false));
            WeaponDic.Add(WeaponList[10], new Weapon(0.25f, 6.1f, 0.046f, 1.70f, false));
            WeaponDic.Add(WeaponList[11], new Weapon(0.24f, 6.6f, 0.051f, 1.70f, false));
            WeaponDic.Add(WeaponList[12], new Weapon(0.23f, 7.4f, 0.057f, 1.76f, false));
            WeaponDic.Add(WeaponList[13], new Weapon(0.20f, 8.0f, 0.065f, 1.80f, false));
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
