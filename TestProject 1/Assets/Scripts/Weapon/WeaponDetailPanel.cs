using UnityEngine;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// 武器详情面板：显示旋转木马当前选中武器的属性。
/// 挂在详情面板物体上，引用 CarouselScrollView 来监听切换。
/// </summary>
public class WeaponDetailPanel : MonoBehaviour
{
    [Header("引用")]
    [Tooltip("旋转木马组件")]
    public CarouselScrollView carousel;

    [Header("UI组件")]
    [Tooltip("武器名称")] public TextMeshProUGUI nameText;
    [Tooltip("挖矿间隔")] public TextMeshProUGUI mineTimeText;
    [Tooltip("挖矿力量")] public TextMeshProUGUI minePowerText;
    [Tooltip("双倍概率")] public TextMeshProUGUI doubleChanceText;
    [Tooltip("挖矿范围")] public TextMeshProUGUI miningAreaText;
    [Tooltip("解锁状态")] public TextMeshProUGUI lockStatusText;
    [Tooltip("装备按钮")] public Button equipButton;
    [Tooltip("装备按钮文字")] public TextMeshProUGUI equipButtonText;

    private int lastIndex = -1;

    private void Start()
    {
        if (equipButton != null)
            equipButton.onClick.AddListener(OnClickEquip);

        Refresh();
    }

    private void Update()
    {
        // 检测旋转木马索引变化，变了就刷新
        if (carousel != null && carousel.CurrentIndex != lastIndex)
        {
            lastIndex = carousel.CurrentIndex;
            Refresh();
        }
    }

    private void Refresh()
    {
        if (carousel == null || WeaponManager.instance == null) return;

        int index = carousel.CurrentIndex;
        if (index < 0 || index >= WeaponManager.instance.WeaponList.Count) return;

        GameObject weaponObj = WeaponManager.instance.WeaponList[index];
        WeaponManager.Weapon weapon = WeaponManager.instance.WeaponDic[weaponObj];

        // 武器名称
        if (nameText != null)
            nameText.text = weaponObj.name;

        // 属性数值
        if (mineTimeText != null)
            mineTimeText.text = $"挖矿间隔：{weapon.mineTime:F2}s";

        if (minePowerText != null)
            minePowerText.text = $"挖矿力量：{weapon.minePower:F1}";

        if (doubleChanceText != null)
            doubleChanceText.text = $"双倍概率：{weapon.doubleEffectChance * 100:F1}%";

        if (miningAreaText != null)
            miningAreaText.text = $"挖矿范围：{weapon.miningAreaSize:F2}";

        // 解锁状态
        bool isUnlocked = index < WeaponManager.instance.WeaponUnlockNum;
        bool isEquipped = index == WeaponManager.instance.WeaponIndex;

        if (lockStatusText != null)
        {
            if (isEquipped)
            {
                lockStatusText.text = "当前装备";
                lockStatusText.color = Color.cyan;
            }
            else if (isUnlocked)
            {
                lockStatusText.text = "已解锁";
                lockStatusText.color = Color.green;
            }
            else
            {
                lockStatusText.text = "未解锁";
                lockStatusText.color = Color.gray;
            }
        }

        // 装备按钮
        if (equipButton != null)
        {
            equipButton.interactable = isUnlocked && !isEquipped;
        }

        if (equipButtonText != null)
        {
            if (isEquipped) equipButtonText.text = "已装备";
            else if (isUnlocked) equipButtonText.text = "装备";
            else equipButtonText.text = "未解锁";
        }
    }

    private void OnClickEquip()
    {
        int index = carousel.CurrentIndex;
        if (index < 0 || index >= WeaponManager.instance.WeaponUnlockNum) return;

        WeaponManager.instance.WeaponIndex = index;

        // 把武器属性写入 GameManager
        GameObject weaponObj = WeaponManager.instance.WeaponList[index];
        WeaponManager.Weapon weapon = WeaponManager.instance.WeaponDic[weaponObj];
        GameManager.instance.mineTime = weapon.mineTime;
        GameManager.instance.minePower = weapon.minePower;
        GameManager.instance.doubleEffectChance = weapon.doubleEffectChance;
        GameManager.instance.miningAreaSize = weapon.miningAreaSize;

        Refresh();
    }
}
