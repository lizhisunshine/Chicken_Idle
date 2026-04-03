using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OreResoureces : MonoBehaviour
{
    public E_OreType oreType;

    public List<GameObject> OreIcons;

    new Vector3 targetPosition;

    public void OnEnable()
    {
        float a = Random.Range(0.8f, 1f);
        this.transform.DOScale(new Vector3(a, a, 1), 0.1f).OnComplete(() =>
        {
            SetRandomOre();
            this.transform.DOMove(targetPosition, 0.3f).OnComplete(() => {

                ObjectPool.instance.Release(this.gameObject);
            });
        });

        
    }

    public void OnDisable()
    {
        if (OreManager.instance == null || UIManager.instance == null) return;
        //添加矿石数
        OreManager.instance.AddOre(oreType);
        //播放ui动画
        UIManager.instance.Pulse(UIManager.instance.ObjList_OreText[(int)oreType]);
        for (int i = 0; i < OreIcons.Count; i++)
        {
            OreIcons[i].SetActive(false);
        }
    }

    public void SetRandomOre()
    {
        switch (oreType)
        {
            case E_OreType.Gold:
                OreIcons[0].SetActive(true);
                targetPosition = UIManager.instance.VectorList_OreTarget[0];
                break;
            case E_OreType.Copper:
                OreIcons[1].SetActive(true);
                targetPosition = UIManager.instance.VectorList_OreTarget[1];
                break;
            case E_OreType.Iron:
                OreIcons[2].SetActive(true);
                targetPosition = UIManager.instance.VectorList_OreTarget[2];
                break;
            case E_OreType.Chromium:
                OreIcons[3].SetActive(true);
                targetPosition = UIManager.instance.VectorList_OreTarget[3];
                break;
            case E_OreType.Uranium:
                OreIcons[4].SetActive(true);
                targetPosition = UIManager.instance.VectorList_OreTarget[4];
                break;
            case E_OreType.Osmium:
                OreIcons[5].SetActive(true);
                targetPosition = UIManager.instance.VectorList_OreTarget[5];
                break;
            case E_OreType.Tourmaline:
                OreIcons[6].SetActive(true);
                targetPosition = UIManager.instance.VectorList_OreTarget[6];
                break;
            case E_OreType.Iridium:
                OreIcons[7].SetActive(true);
                targetPosition = UIManager.instance.VectorList_OreTarget[7];
                break;
        }
    }

}
