using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Xml.Serialization;
using Unity.VisualScripting;
using UnityEngine;

//矿石根物体脚本
public class RockMechanics : MonoBehaviour
{
    //存储不同种类矿石的列表
    public List<GameObject> Rocks = new();
    //破碎矿石列表
    public List<GameObject> BrokenRocks = new();

    public float rockHealth;

    public E_RockType currentRockType;
    
    //检查抽取是否完成的标签
    public bool CompleteDraw;


    //每次激活时调用
    private void OnEnable()
    {
        if (OreManager.instance == null) return;
        CreatRock();
        GetComponentInChildren<SpriteRenderer>().sortingOrder = -(int)(transform.position.y * 100);
    }

    private void OnDisable()
    {
        if (OreManager.instance == null) return;
        if (Rocks == null || Rocks.Count == 0) return;
        OreManager.instance.UnregisterRock(this.gameObject);
        // 收回时，关闭所有贴图，防止对象池复用时残留
        for (int i = 0; i < Rocks.Count; i++)
            Rocks[i].SetActive(false);
        for (int i = 0; i < BrokenRocks.Count; i++)
            BrokenRocks[i].SetActive(false);
        CompleteDraw = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("AttackArea")) 
        {
            Mine();
        }
    }

    void CreatRock()
    { 
        //1.随机矿物种类
        SetRandomRock();
        //2.更新矿物血量
        rockHealth = OreManager.instance.Health;
        //3.播放动画
        RockAnim_Creat();
    }

    /// <summary>
    /// 选择矿物方法，当要生成矿物的时候调用 
    /// </summary>
    void SetRandomRock()
    {

        Debug.Log($"概率检查: Gold={OreManager.instance.chunkGoldChance}");
        float num = 100f;
        //铱
        if (UnityEngine.Random.Range(0f, num) < OreManager.instance.chunkIridiumChance)
        {
            Rocks[Rocks.Count-1].SetActive(true);
            currentRockType = E_RockType.ChunkIridium;
            CompleteDraw = true;
        }
        num -= OreManager.instance.chunkIridiumChance;
        
        if (UnityEngine.Random.Range(0f, num) < OreManager.instance.fullIridiumChance&&!CompleteDraw)
        {
            Rocks[Rocks.Count - 2].SetActive(true);
            currentRockType = E_RockType.FullIridium;
            CompleteDraw = true;
        }
        num -= OreManager.instance.fullIridiumChance;

        //电气石
        if (UnityEngine.Random.Range(0f, num) < OreManager.instance.chunkTourmalineChance && !CompleteDraw)
        {
            Rocks[Rocks.Count - 3].SetActive(true);
            currentRockType = E_RockType.ChunkTourmaline;
            CompleteDraw = true;
        }
        num -= OreManager.instance.chunkTourmalineChance;

        if (UnityEngine.Random.Range(0f, num) < OreManager.instance.fullTourmalineChance && !CompleteDraw)
        {
            Rocks[Rocks.Count - 4].SetActive(true);
            currentRockType = E_RockType.FullTourmaline;
            CompleteDraw = true;
        }
        num -= OreManager.instance.fullTourmalineChance;

        //锇矿石
        if (UnityEngine.Random.Range(0f, num) < OreManager.instance.chunkOsmiumChance && !CompleteDraw)
        {
            Rocks[Rocks.Count - 5].SetActive(true);
            currentRockType = E_RockType.ChunkOsmium;
            CompleteDraw = true;
        }
        num -= OreManager.instance.chunkOsmiumChance;

        if (UnityEngine.Random.Range(0f, num) < OreManager.instance.fullOsmiumChance && !CompleteDraw)
        {
            Rocks[Rocks.Count - 6].SetActive(true);
            currentRockType = E_RockType.FullOsmium;
            CompleteDraw = true;
        }
        num -= OreManager.instance.fullOsmiumChance;

        //铀矿石
        if (UnityEngine.Random.Range(0f, num) < OreManager.instance.chunkUraniumChance && !CompleteDraw)
        {
            Rocks[Rocks.Count - 7].SetActive(true);
            currentRockType = E_RockType.ChunkUranium;
            CompleteDraw = true;
        }
        num -= OreManager.instance.chunkUraniumChance;

        if (UnityEngine.Random.Range(0f, num) < OreManager.instance.fullUraniumChance && !CompleteDraw)
        {
            Rocks[Rocks.Count - 8].SetActive(true);
            currentRockType = E_RockType.FullUranium;
            CompleteDraw = true;
        }
        num -= OreManager.instance.fullUraniumChance;

        //铬矿石
        if (UnityEngine.Random.Range(0f, num) < OreManager.instance.chunkChromiumChance && !CompleteDraw)
        {
            Rocks[Rocks.Count - 9].SetActive(true);
            currentRockType = E_RockType.ChunkChromium;
            CompleteDraw = true;
        }
        num -= OreManager.instance.chunkChromiumChance;

        if (UnityEngine.Random.Range(0f, num) < OreManager.instance.fullChromiumChance && !CompleteDraw)
        {
            Rocks[Rocks.Count - 10].SetActive(true);
            currentRockType = E_RockType.FullChromium;
            CompleteDraw = true;
        }
        num -= OreManager.instance.fullChromiumChance;

        //铁矿石
        if (UnityEngine.Random.Range(0f, num) < OreManager.instance.chunkIronChance && !CompleteDraw)
        {
            Rocks[Rocks.Count - 11].SetActive(true);
            currentRockType = E_RockType.ChunkIron;
            CompleteDraw = true;
        }
        num -= OreManager.instance.chunkIronChance;

        if (UnityEngine.Random.Range(0f, num) < OreManager.instance.fullIronChance && !CompleteDraw)
        {
            Rocks[Rocks.Count - 12].SetActive(true);
            currentRockType = E_RockType.FullIron;
            CompleteDraw = true;
        }
        num -= OreManager.instance.fullIronChance;

        //铜矿石
        if (UnityEngine.Random.Range(0f, num) < OreManager.instance.chunkCopperChance && !CompleteDraw)
        {
            Rocks[Rocks.Count - 13].SetActive(true);
            currentRockType = E_RockType.ChunkCopper;
            CompleteDraw = true;
        }
        num -= OreManager.instance.chunkCopperChance;

        if (UnityEngine.Random.Range(0f, num) < OreManager.instance.fullCopperChance && !CompleteDraw)
        {
            Rocks[Rocks.Count - 14].SetActive(true);
            currentRockType = E_RockType.FullCopper;
            CompleteDraw = true;
        }
        num -= OreManager.instance.fullCopperChance;

        //金矿石
        if (UnityEngine.Random.Range(0f, num) < OreManager.instance.chunkGoldChance && !CompleteDraw)
        {
            Rocks[Rocks.Count - 15].SetActive(true);
            currentRockType = E_RockType.ChunkGold;
            CompleteDraw = true;
        }
        num -= OreManager.instance.chunkGoldChance;

        if (UnityEngine.Random.Range(0f, num) < OreManager.instance.fullGoldChance && !CompleteDraw)
        {
            Rocks[Rocks.Count - 16].SetActive(true);
            currentRockType = E_RockType.FullGold;
            CompleteDraw = true;
        }
        num -= OreManager.instance.fullGoldChance;
        //全部都未选中，则使用最基础的石头
        if (!CompleteDraw)
        {
            Rocks[Rocks.Count - 17].SetActive(true);
            currentRockType = E_RockType.Rock;
            CompleteDraw = true;
        }
    }

    /// <summary>
    /// 矿物分发矿石的方法，当矿物被挖掉的时候调用
    /// </summary>
    public void GiveResource()
    {
        //1.播放动画
        switch (currentRockType)
        {
            case E_RockType.Rock:
                    ObjectPool.instance.Get(E_OreType.Gold, ObjectPool.instance.prefabs[6], this.transform.position, Vector3.zero);
                break;
            case E_RockType.ChunkGold:
                for (int a = 0; a < 3; a++)
                { 
                    ObjectPool.instance.Get(E_OreType.Gold, ObjectPool.instance.prefabs[6], this.transform.position, Vector3.zero);
                }
                break;
            case E_RockType.FullGold:
                for (int a = 0; a < 7; a++)
                {
                    ObjectPool.instance.Get(E_OreType.Gold, ObjectPool.instance.prefabs[6], this.transform.position, Vector3.zero);
                }
                break;
            case E_RockType.ChunkCopper:
                for (int a = 0; a < 3; a++)
                {
                    ObjectPool.instance.Get(E_OreType.Copper, ObjectPool.instance.prefabs[6], this.transform.position, Vector3.zero);
                }
                break;
            case E_RockType.FullCopper:
                for (int a = 0; a < 7; a++)
                {
                    ObjectPool.instance.Get(E_OreType.Copper, ObjectPool.instance.prefabs[6], this.transform.position, Vector3.zero);
                }
                break;
            case E_RockType.ChunkIron:
                for (int a = 0; a < 3; a++)
                {
                    ObjectPool.instance.Get(E_OreType.Iron, ObjectPool.instance.prefabs[6], this.transform.position, Vector3.zero);
                }
                break;
            case E_RockType.FullIron:
                for (int a = 0; a < 7; a++)
                {
                    ObjectPool.instance.Get(E_OreType.Iron, ObjectPool.instance.prefabs[6], this.transform.position, Vector3.zero);
                }
                break;
            case E_RockType.ChunkChromium:
                for (int a = 0; a < 3; a++)
                {
                    ObjectPool.instance.Get(E_OreType.Chromium, ObjectPool.instance.prefabs[6], this.transform.position, Vector3.zero);
                }
                break;
            case E_RockType.FullChromium:
                for (int a = 0; a < 7; a++)
                {
                    ObjectPool.instance.Get(E_OreType.Chromium, ObjectPool.instance.prefabs[6], this.transform.position, Vector3.zero);
                }
                break;
            case E_RockType.ChunkOsmium:
                for (int a = 0; a < 3; a++)
                {
                    ObjectPool.instance.Get(E_OreType.Osmium, ObjectPool.instance.prefabs[6], this.transform.position, Vector3.zero);
                }
                break;
            case E_RockType.FullOsmium:
                for (int a = 0; a < 7; a++)
                {
                    ObjectPool.instance.Get(E_OreType.Osmium, ObjectPool.instance.prefabs[6], this.transform.position, Vector3.zero);
                }
                break;
            case E_RockType.ChunkUranium:
                for (int a = 0; a < 3; a++)
                {
                    ObjectPool.instance.Get(E_OreType.Uranium, ObjectPool.instance.prefabs[6], this.transform.position, Vector3.zero);
                }
                break;
            case E_RockType.FullUranium:
                for (int a = 0; a < 7; a++)
                {
                    ObjectPool.instance.Get(E_OreType.Uranium, ObjectPool.instance.prefabs[6], this.transform.position, Vector3.zero);
                }
                break;
            case E_RockType.ChunkTourmaline:
                for (int a = 0; a < 3; a++)
                {
                    ObjectPool.instance.Get(E_OreType.Tourmaline, ObjectPool.instance.prefabs[6], this.transform.position, Vector3.zero);
                }
                break;
            case E_RockType.FullTourmaline:
                for (int a = 0; a < 7; a++)
                {
                    ObjectPool.instance.Get(E_OreType.Tourmaline, ObjectPool.instance.prefabs[6], this.transform.position, Vector3.zero);
                }
                break;
            case E_RockType.ChunkIridium:
                for (int a = 0; a < 3; a++)
                {
                    ObjectPool.instance.Get(E_OreType.Iridium, ObjectPool.instance.prefabs[6], this.transform.position, Vector3.zero);
                }
                break;
            case E_RockType.FullIridium:
                for (int a = 0; a < 7; a++)
                {
                    ObjectPool.instance.Get(E_OreType.Iridium, ObjectPool.instance.prefabs[6], this.transform.position, Vector3.zero);
                }
                break;
        
    }
}

    /// <summary>
    /// 切换贴图方法,矿石裂纹时调用
    /// </summary>
    public void ChangeTexture()
    {    
        BrokenRocks[(int)currentRockType].SetActive(true);
        Rocks[(int)currentRockType].SetActive(false);
    }


    /// <summary>
    /// 岩石动画：创建
    /// </summary>
    void RockAnim_Creat()
    {
        float a = UnityEngine.Random.Range(0.8f, 1f);
        this.transform.localScale = Vector3.zero;
        this.transform.DOScale(new Vector3(a, a, 1f), 0.18f);
    }

    /// <summary>
    /// 岩石动画：受击
    /// </summary>
    void RockAnim_BeAttack()
    {
        Vector3 currentScale = this.transform.localScale;
        this.transform.DOScale(new Vector3(1.15f*currentScale.x, 0.85f*currentScale.y, 1f), 0.1f).OnComplete(() => {
            this.transform.DOScale(new Vector3(currentScale.x,currentScale.y, 1f), 0.1f);
        });
    }

    #region 弃用挖掘方法
    //public void Mine()
    //{
    //    //1.播放稿子动画
    //    ObjectPool.instance.Get(ObjectPool.instance.prefabs[1], this.transform.position);
    //    //这里问题是，我们希望动画完成的时候检查血量
    //    //解决方案1：利用协程让逻辑停止一会

    //    //2.检查血量
    //    if (rockHealth <= 0)
    //    {
    //        GiveResource();
    //        ObjectPool.instance.Release(this.gameObject);
    //        return;
    //    }
    //    else if (rockHealth <= (OreManager.instance.Health) * 0.5f)
    //    {
    //        //切换贴图
    //        ChangeTexture();
    //    }

    //    //3.播放岩石弹跳动画
    //}
    #endregion

    /// <summary>
    /// 挖掘方法,完成后检查血量
    /// </summary>
    public void Mine()
    {
        // 照常生成镐头动画
        ObjectPool.instance.Get(ObjectPool.instance.prefabs[1], this.transform.position);

        // 协程等待动画时长后扣血
        StartCoroutine(MineCoroutine());
    }

    private IEnumerator MineCoroutine()
    {
        yield return new WaitForSeconds(GameManager.instance.mineTime);

        rockHealth -= GameManager.instance.minePower;
        //检查血量
        if (rockHealth <= 0)
        {
            GiveResource();
            ObjectPool.instance.Release(this.gameObject);
        }
        else if (rockHealth <= OreManager.instance.Health * 0.5f)
        {
            ChangeTexture();
        }

        //播放岩石动画
        RockAnim_BeAttack();
    }
}

