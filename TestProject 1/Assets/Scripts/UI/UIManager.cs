using DG.Tweening;
using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    
    /// <summary>
    /// 矿石ui坐标位置
    /// </summary>
    public List<GameObject> ObjList_OreText = new();
    /// <summary>
    /// 矿石文字列表
    /// </summary>
    private List<TextMeshProUGUI> TmpList_OreText = new();

    /// <summary>
    /// 矿石目标位置列表
    /// </summary>
    [HideInInspector]public List<Vector3> VectorList_OreTarget = new();
    
    
    private void Awake()
    {
        instance = this;

        for (int a = 0; a < 8; a++)
        {
            //VectorList_OreTarget.Add(Camera.main.ScreenToWorldPoint( VectorList_OreText[a].position));
            Vector3 screenPos = ObjList_OreText[a].transform.position;
            screenPos.z =10; // 2D游戏摄像机通常在z=-10
            VectorList_OreTarget.Add(Camera.main.ScreenToWorldPoint(screenPos));
        }

        for (int i = 0; i < ObjList_OreText.Count; i++)
        {
            TmpList_OreText.Add( ObjList_OreText[i].GetComponentInChildren<TextMeshProUGUI>());
        }
        //Debug.Log(ObjList_OreText[0].GetComponent<TextMeshProUGUI>());
    }

    private void Update()
    {
        UpdateOreText();

    }

    //文字更新方法
    void UpdateOreText()
    {
        for (int a = 0; a < TmpList_OreText.Count; a++) 
        {
            E_OreType oreType = (E_OreType)a;
            TmpList_OreText[a].text = OreManager.instance.oreDic[oreType].ToString();
            //TmpList_OreText[a].text = OreManager.instance.oreDic<a>;
        }
    }

    //文字动画方法
    public void Pulse(GameObject target)
    {
        RectTransform rect = target.GetComponent<RectTransform>();
        float current = rect.localScale.x;
        float next = Mathf.Min(current + 0.1f, 1.5f);
        rect.DOKill();
        rect.DOScale(next, 0.05f).SetEase(Ease.OutBack)
            .OnComplete(() => {
                rect.DOScale(Vector3.one, 0.3f).SetEase(Ease.InBack);
            });
    }
}
