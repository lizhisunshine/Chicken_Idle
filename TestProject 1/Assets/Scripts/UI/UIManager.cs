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
    /// ��ʯui����λ��
    /// </summary>
    public List<GameObject> ObjList_OreText = new();
    /// <summary>
    /// ��ʯ�����б�
    /// </summary>
    private List<TextMeshProUGUI> TmpList_OreText = new();

    /// <summary>
    /// ��ʯui����λ��
    /// </summary>
    public List<GameObject> ObjList_IngotText = new();
    /// <summary>
    /// �������б�
    /// </summary>
    private List<TextMeshProUGUI> TmpList_IngotText = new();

    /// <summary>
    /// ��ʯĿ��λ���б�
    /// </summary>
    [HideInInspector]public List<Vector3> VectorList_OreTarget = new();

    [Header("选项卡系统")]
    [Tooltip("选项卡按钮，顺序与页面一一对应")]
    public List<UnityEngine.UI.Button> tabButtons = new();
    [Tooltip("选项卡页面Panel，顺序与按钮一一对应")]
    public List<GameObject> tabPanels = new();
    [Tooltip("按钮未选中时的Sprite")]
    public Sprite tabNormalSprite;
    [Tooltip("按钮选中时的Sprite")]
    public Sprite tabSelectedSprite;

    // 内部缓存：从按钮上提取的Image组件
    private List<UnityEngine.UI.Image> tabButtonImages = new();
    /// <summary>
    /// 当前选中的选项卡索引（-1=无）
    /// </summary>
    [HideInInspector] public int currentTabIndex = -1;
    
    
    private void Awake()
    {
        instance = this;

        for (int a = 0; a < 8; a++)
        {
            Vector3 screenPos = ObjList_OreText[a].transform.position;
            screenPos.z = 10;
            VectorList_OreTarget.Add(Camera.main.ScreenToWorldPoint(screenPos));
        }

        for (int i = 0; i < ObjList_OreText.Count; i++)
        {
            TmpList_OreText.Add(ObjList_OreText[i].GetComponentInChildren<TextMeshProUGUI>());
        }

        for (int i = 0; i < ObjList_IngotText.Count; i++)
        {
            TmpList_IngotText.Add(ObjList_IngotText[i].GetComponentInChildren<TextMeshProUGUI>());
        }

        // 选项卡初始化：提取Image组件 + 绑定点击事件
        for (int i = 0; i < tabButtons.Count; i++)
        {
            tabButtonImages.Add(tabButtons[i].GetComponent<UnityEngine.UI.Image>());

            int index = i; // 闭包捕获
            tabButtons[i].onClick.AddListener(() => SwitchTab(index));
        }
    }

    private void Update()
    {
        UpdateOreText();
        UpdateIngotText();

    }

    //���ָ��·���
    void UpdateOreText()
    {
        for (int a = 0; a < TmpList_OreText.Count; a++) 
        {
            E_OreType oreType = (E_OreType)a;
            TmpList_OreText[a].text = OreManager.instance.oreDic[oreType].ToString();
            //TmpList_OreText[a].text = OreManager.instance.oreDic<a>;
        }
    }

    void UpdateIngotText()
    {
        for (int a = 0; a < TmpList_IngotText.Count; a++)
        {
            E_OreType oreType = (E_OreType)a;
            TmpList_IngotText[a].text = OreManager.instance.ingotDic[oreType].ToString();
            //TmpList_OreText[a].text = OreManager.instance.oreDic<a>;
        }
    }

    //脉冲动画方法
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

    //  选项卡切换

    /// <summary>
    /// 切换到指定索引的选项卡。Awake中已自动绑定到按钮，无需手动设置OnClick。
    /// </summary>
    public void SwitchTab(int index)
    {
        if (index == currentTabIndex) return;

        for (int i = 0; i < tabPanels.Count; i++)
        {
            tabPanels[i].SetActive(false);
            if (i < tabButtonImages.Count && tabButtonImages[i] != null && tabNormalSprite != null)
                tabButtonImages[i].sprite = tabNormalSprite;
        }

        if (index >= 0 && index < tabPanels.Count)
        {
            tabPanels[index].SetActive(true);
            if (index < tabButtonImages.Count && tabButtonImages[index] != null && tabSelectedSprite != null)
                tabButtonImages[index].sprite = tabSelectedSprite;
            currentTabIndex = index;
        }
    }

    /// <summary>
    /// 关闭所有选项卡（回到无选中状态）
    /// </summary>
    public void CloseAllTabs()
    {
        for (int i = 0; i < tabPanels.Count; i++)
        {
            tabPanels[i].SetActive(false);
            if (i < tabButtonImages.Count && tabButtonImages[i] != null && tabNormalSprite != null)
                tabButtonImages[i].sprite = tabNormalSprite;
        }
        currentTabIndex = -1;
    }
}
