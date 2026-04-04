using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200001D RID: 29
public class TheMine : MonoBehaviour, IDataPersistence
{
	// Token: 0x060000B0 RID: 176 RVA: 0x0000E53F File Offset: 0x0000C73F
	private void Awake()
	{
		base.StartCoroutine(this.Wait());
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x0000E54E File Offset: 0x0000C74E
	private IEnumerator Wait()
	{
		yield return new WaitForSeconds(0.1f);
		if (MobileAndTesting.isMobile)
		{
			this.btn1Outline.enabled = true;
			this.btn2Outline.enabled = true;
			this.infoTooltipAnim.enabled = false;
			this.locScript.TheMineTexts(false);
			this.locScript.TheMineTexts(true);
			Transform transform = this.tooltipSpeed.transform;
			int siblingIndex = transform.GetSiblingIndex();
			if (siblingIndex > 0)
			{
				transform.SetSiblingIndex(siblingIndex - 2);
			}
			Transform transform2 = this.tooltipBars.transform;
			int siblingIndex2 = transform2.GetSiblingIndex();
			if (siblingIndex2 > 0)
			{
				transform2.SetSiblingIndex(siblingIndex2 - 2);
			}
			this.tooltip1Anim.enabled = false;
			this.tooltip2Anim.enabled = false;
			this.tooltipSpeed.transform.localScale = new Vector2(0.76f, 0.76f);
			this.tooltipSpeed.transform.localPosition = new Vector2(-179f, -337f);
			this.tooltipBars.transform.localScale = new Vector2(0.76f, 0.76f);
			this.tooltipBars.transform.localPosition = new Vector2(207f, -337f);
			this.speedBUTTON.transform.localScale = new Vector2(0.58f, 0.58f);
			this.speedBUTTON.transform.localPosition = new Vector2(-178f, -447f);
			this.barsBUTTON.transform.localScale = new Vector2(0.58f, 0.58f);
			this.barsBUTTON.transform.localPosition = new Vector2(207f, -447f);
		}
		else
		{
			this.btn1Outline.enabled = false;
			this.btn2Outline.enabled = false;
		}
		TheMine.mineTimeDecrase = TheMine.miningTime / 18f;
		this.UpdateChances();
		if (TheMine.isTheMineUnlocked)
		{
			base.StartCoroutine(this.Mining());
		}
		yield break;
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x0000E560 File Offset: 0x0000C760
	private void Update()
	{
		if (MainMenu.isInTheMine)
		{
			string str;
			if (GoldAndOreMechanics.totalGoldBars >= TheMine.mineTimePrice)
			{
				str = "<color=green>";
			}
			else
			{
				str = "<color=red>";
			}
			string str2;
			if (GoldAndOreMechanics.totalGoldBars >= TheMine.mineMaterialsPrice)
			{
				str2 = "<color=green>";
			}
			else
			{
				str2 = "<color=red>";
			}
			string str3;
			if (GoldAndOreMechanics.totalGoldBars >= TheMine.theMinePrice)
			{
				str3 = "<color=green>";
			}
			else
			{
				str3 = "<color=red>";
			}
			this.mineTimePriceText.text = LocalizationScript.price + " " + str + FormatNumbers.FormatPoints(TheMine.mineTimePrice);
			this.mineMaterialPriceText.text = LocalizationScript.price + " " + str2 + FormatNumbers.FormatPoints(TheMine.mineMaterialsPrice);
			this.theMinePriceText.text = LocalizationScript.price + " " + str3 + TheMine.theMinePrice.ToString("F0");
		}
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x0000E64C File Offset: 0x0000C84C
	public void UpdateChances()
	{
		if (!SkillTree.spawnCopper_purchased)
		{
			TheMine.goldChance = 100f;
			this.goldChance_text.text = TheMine.goldChance.ToString("F0") + "%";
			this.goldChance_text.gameObject.SetActive(false);
			return;
		}
		float num = 100f;
		if (SkillTree.spawnCopper_purchased)
		{
			TheMine.copperChance = SkillTree.copperRockChance + SkillTree.fullCopperRockChance;
			this.copperChance_text.text = TheMine.copperChance.ToString("F1") + "%";
			num -= TheMine.copperChance;
		}
		if (SkillTree.spawnIron_purchased)
		{
			TheMine.ironChance = SkillTree.ironRockChance + SkillTree.fullIronRockChance;
			this.ironChance_text.text = TheMine.ironChance.ToString("F1") + "%";
			num -= TheMine.ironChance;
		}
		if (SkillTree.cobaltSpawn_purchased)
		{
			TheMine.cobaltChance = SkillTree.cobaltRockChance + SkillTree.fullCobaltRockChance;
			this.cobaltChance_text.text = TheMine.cobaltChance.ToString("F1") + "%";
			num -= TheMine.cobaltChance;
		}
		if (SkillTree.uraniumSpawn_purchased)
		{
			TheMine.uraniumChance = SkillTree.uraniumRockChance + SkillTree.fullUraniumRockChance;
			this.uraniumChance_text.text = TheMine.uraniumChance.ToString("F1") + "%";
			num -= TheMine.uraniumChance;
		}
		if (SkillTree.ismiumSpawn_purchased)
		{
			TheMine.ismiumChance = SkillTree.ismiumRockChance + SkillTree.fullIsmiumRockChance;
			this.ismiumChance_text.text = TheMine.ismiumChance.ToString("F1") + "%";
			num -= TheMine.ismiumChance;
		}
		if (SkillTree.iridiumSpawn_purchased)
		{
			TheMine.iridiumChance = SkillTree.iridiumRockChance + SkillTree.fullIridiumRockChance;
			this.iridiumChance_text.text = TheMine.iridiumChance.ToString("F1") + "%";
			num -= TheMine.iridiumChance;
		}
		if (SkillTree.painiteSpawn_purchased)
		{
			TheMine.painiteChance = SkillTree.painiteRockChance + SkillTree.fullPainiteRockChance;
			this.painiteChance_text.text = TheMine.painiteChance.ToString("F1") + "%";
			num -= TheMine.painiteChance;
		}
		TheMine.goldChance = num;
		this.goldChance_text.text = TheMine.goldChance.ToString("F1") + "%";
		if (MainMenu.isInTheMine)
		{
			this.goldChance_text.gameObject.SetActive(true);
			this.copperChance_text.gameObject.SetActive(true);
			this.ironChance_text.gameObject.SetActive(true);
			this.cobaltChance_text.gameObject.SetActive(true);
			this.uraniumChance_text.gameObject.SetActive(true);
			this.ismiumChance_text.gameObject.SetActive(true);
			this.iridiumChance_text.gameObject.SetActive(true);
			this.painiteChance_text.gameObject.SetActive(true);
			return;
		}
		this.goldChance_text.gameObject.SetActive(false);
		this.copperChance_text.gameObject.SetActive(false);
		this.ironChance_text.gameObject.SetActive(false);
		this.cobaltChance_text.gameObject.SetActive(false);
		this.uraniumChance_text.gameObject.SetActive(false);
		this.ismiumChance_text.gameObject.SetActive(false);
		this.iridiumChance_text.gameObject.SetActive(false);
		this.painiteChance_text.gameObject.SetActive(false);
	}

	// Token: 0x060000B4 RID: 180 RVA: 0x0000E9C0 File Offset: 0x0000CBC0
	public void PurchaseTheMine()
	{
		if (GoldAndOreMechanics.totalGoldBars >= TheMine.theMinePrice)
		{
			if (MobileAndTesting.isMobile)
			{
				this.tooltipSpeed.SetActive(true);
				this.tooltipBars.SetActive(true);
			}
			GoldAndOreMechanics.totalGoldBars -= TheMine.theMinePrice;
			this.goldScript.SetTotalResourcesText();
			this.audioManager.Play("Click_1");
			TheMine.isTheMineUnlocked = true;
			this.achScript.CheckAch();
			this.mineProgressBar.SetActive(true);
			this.mineSpeedBtn.SetActive(true);
			this.mineOreBtn.SetActive(true);
			this.lockedMine.SetActive(false);
			this.purchaseMineBtn.SetActive(false);
			base.StartCoroutine(this.Mining());
			return;
		}
		this.audioManager.Play("CantAfford");
	}

	// Token: 0x060000B5 RID: 181 RVA: 0x0000EA91 File Offset: 0x0000CC91
	private IEnumerator Mining()
	{
		this.mineSlider.value = 0f;
		float totalMineTime = TheMine.miningTime;
		float num = 1f;
		if (Artifacts.ancientDevice_found)
		{
			float num2 = Artifacts.ancientDeviceTimeReduction;
			if (LevelMechanics.archaeologist_chosen && Artifacts.rune_found)
			{
				num2 *= 1f + LevelMechanics.archeologistIncrease + Artifacts.runeImproveAll;
			}
			else
			{
				if (LevelMechanics.archaeologist_chosen)
				{
					num2 *= 1f + LevelMechanics.archeologistIncrease;
				}
				if (Artifacts.rune_found)
				{
					num2 *= 1f + Artifacts.runeImproveAll;
				}
			}
			num = 1f - num2;
		}
		if (LevelMechanics.isSignFasterMine)
		{
			num -= LevelMechanics.signFasterMineAmount;
		}
		totalMineTime *= num;
		bool flag = false;
		if (LevelMechanics.skilledMiners_chosen && Random.Range(0f, 100f) < LevelMechanics.skilledMinersFastChance)
		{
			AllStats.theMine2XTriggers++;
			totalMineTime = TheMine.miningTime / 2f;
			flag = true;
		}
		if (LevelMechanics.isSignChanceToMine3XFaster && !flag && Random.Range(0f, 100f) < LevelMechanics.signMine3XFasterChance)
		{
			totalMineTime = TheMine.miningTime / 3f;
		}
		float currentTime = 0f;
		while (currentTime < totalMineTime)
		{
			currentTime += Time.deltaTime;
			this.mineSlider.value = Mathf.Clamp01(currentTime / totalMineTime);
			yield return null;
		}
		this.mineSlider.value = 1f;
		this.MinedMaterials();
		yield break;
	}

	// Token: 0x060000B6 RID: 182 RVA: 0x0000EAA0 File Offset: 0x0000CCA0
	public void MinedMaterials()
	{
		bool flag = false;
		if (LevelMechanics.skilledMiners_chosen && Random.Range(0f, 100f) < LevelMechanics.skilledMinersDoubleChance)
		{
			AllStats.theMineDoubleTriggers++;
			flag = true;
		}
		int num = TheMine.barsMined;
		if (flag)
		{
			num *= 2;
		}
		if (LevelMechanics.isSignMineMoreMaterials)
		{
			num += LevelMechanics.signMoreMaterialsAmount;
		}
		if (LevelMechanics.isSignDoubleMaterialsChance && Random.Range(0f, 100f) < (float)LevelMechanics.signDoubleMaterialsChance && !flag)
		{
			num *= 2;
		}
		this.mineMinedAnim.Play();
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = false;
		bool flag5 = false;
		bool flag6 = false;
		bool flag7 = false;
		bool flag8 = false;
		bool flag9 = false;
		float num2 = 100f;
		Random.Range(0f, num2);
		bool flag10 = false;
		if (SkillTree.painiteSpawn_purchased)
		{
			if (Random.Range(0f, num2) < TheMine.painiteChance && !flag10)
			{
				flag10 = true;
				flag9 = true;
			}
			num2 -= TheMine.painiteChance;
		}
		if (SkillTree.iridiumSpawn_purchased)
		{
			if (Random.Range(0f, num2) < TheMine.iridiumChance && !flag10)
			{
				flag10 = true;
				flag8 = true;
			}
			num2 -= TheMine.iridiumChance;
		}
		if (SkillTree.ismiumSpawn_purchased)
		{
			if (Random.Range(0f, num2) < TheMine.ismiumChance && !flag10)
			{
				flag10 = true;
				flag7 = true;
			}
			num2 -= TheMine.ismiumChance;
		}
		if (SkillTree.uraniumSpawn_purchased)
		{
			if (Random.Range(0f, num2) < TheMine.uraniumChance && !flag10)
			{
				flag10 = true;
				flag6 = true;
			}
			num2 -= TheMine.uraniumChance;
		}
		if (SkillTree.cobaltSpawn_purchased)
		{
			if (Random.Range(0f, num2) < TheMine.cobaltChance && !flag10)
			{
				flag10 = true;
				flag5 = true;
			}
			num2 -= TheMine.cobaltChance;
		}
		if (SkillTree.spawnIron_purchased)
		{
			if (Random.Range(0f, num2) < TheMine.ironChance && !flag10)
			{
				flag10 = true;
				flag4 = true;
			}
			num2 -= TheMine.ironChance;
		}
		if (SkillTree.spawnCopper_purchased && Random.Range(0f, num2) < TheMine.copperChance && !flag10)
		{
			flag10 = true;
			flag3 = true;
		}
		if (!flag10)
		{
			flag2 = true;
		}
		for (int i = 0; i < num; i++)
		{
			if (MainMenu.isInTheMine)
			{
				GameObject theMineMaterialFromPool = ObjectPool.instance.GetTheMineMaterialFromPool();
				theMineMaterialFromPool.transform.localPosition = new Vector2((float)Random.Range(-30, -120), (float)Random.Range(-75, 60));
				if (flag2)
				{
					theMineMaterialFromPool.gameObject.transform.localScale = new Vector2(0.25f, 0.25f);
				}
				else if (flag3)
				{
					theMineMaterialFromPool.gameObject.transform.localScale = new Vector2(0.35f, 0.35f);
				}
				else if (flag4)
				{
					theMineMaterialFromPool.gameObject.transform.localScale = new Vector2(0.45f, 0.45f);
				}
				else if (flag5)
				{
					theMineMaterialFromPool.gameObject.transform.localScale = new Vector2(0.55f, 0.55f);
				}
				else if (flag6)
				{
					theMineMaterialFromPool.gameObject.transform.localScale = new Vector2(0.65f, 0.65f);
				}
				else if (flag7)
				{
					theMineMaterialFromPool.gameObject.transform.localScale = new Vector2(0.75f, 0.75f);
				}
				else if (flag8)
				{
					theMineMaterialFromPool.gameObject.transform.localScale = new Vector2(0.85f, 0.85f);
				}
				else if (flag9)
				{
					theMineMaterialFromPool.gameObject.transform.localScale = new Vector2(0.95f, 0.95f);
				}
				else
				{
					theMineMaterialFromPool.gameObject.transform.localScale = new Vector2(0.25f, 0.25f);
				}
			}
			else if (flag2)
			{
				this.goldScript.GiveGoldBar(1, 1);
			}
			else if (flag3)
			{
				this.goldScript.GiveGoldBar(1, 2);
			}
			else if (flag4)
			{
				this.goldScript.GiveGoldBar(1, 3);
			}
			else if (flag5)
			{
				this.goldScript.GiveGoldBar(1, 4);
			}
			else if (flag6)
			{
				this.goldScript.GiveGoldBar(1, 5);
			}
			else if (flag7)
			{
				this.goldScript.GiveGoldBar(1, 6);
			}
			else if (flag8)
			{
				this.goldScript.GiveGoldBar(1, 7);
			}
			else if (flag9)
			{
				this.goldScript.GiveGoldBar(1, 8);
			}
		}
		base.StartCoroutine(this.Mining());
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x0000EF24 File Offset: 0x0000D124
	public void UpgradeMineTime()
	{
		if (GoldAndOreMechanics.totalGoldBars >= TheMine.mineTimePrice)
		{
			GoldAndOreMechanics.totalGoldBars -= TheMine.mineTimePrice;
			this.goldScript.SetTotalResourcesText();
			TheMine.mineTimePrice *= 1.4199999570846558;
			TheMine.mineTimeDecrase = TheMine.miningTime / 18f;
			TheMine.miningTime -= TheMine.mineTimeDecrase;
			this.audioManager.Play("Click_1");
			this.locScript.TheMineTexts(true);
			return;
		}
		this.audioManager.Play("CantAfford");
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x0000EFBC File Offset: 0x0000D1BC
	public void UpgradeMinedMaterials()
	{
		if (GoldAndOreMechanics.totalGoldBars >= TheMine.mineMaterialsPrice)
		{
			TheMine.barsMined += TheMine.bersMinedIncrease;
			GoldAndOreMechanics.totalGoldBars -= TheMine.mineMaterialsPrice;
			this.goldScript.SetTotalResourcesText();
			TheMine.mineMaterialsPrice *= 1.899999976158142;
			TheMine.bersMinedIncrease = 2;
			this.audioManager.Play("Click_1");
			this.locScript.TheMineTexts(false);
			return;
		}
		this.audioManager.Play("CantAfford");
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x0000F048 File Offset: 0x0000D248
	public void LoadData(GameData data)
	{
		TheMine.isTheMineUnlocked = data.isTheMineUnlocked;
		TheMine.theMinePrice = data.theMinePrice;
		TheMine.mineTimeDecrase = data.mineTimeDecrase;
		TheMine.mineTimePrice = data.mineTimePrice;
		TheMine.mineMaterialsPrice = data.mineMaterialsPrice;
		TheMine.miningTime = data.miningTime;
		TheMine.barsMined = data.barsMined;
		TheMine.bersMinedIncrease = data.bersMinedIncrease;
	}

	// Token: 0x060000BA RID: 186 RVA: 0x0000F0B0 File Offset: 0x0000D2B0
	public void SaveData(ref GameData data)
	{
		data.isTheMineUnlocked = TheMine.isTheMineUnlocked;
		data.theMinePrice = TheMine.theMinePrice;
		data.mineTimeDecrase = TheMine.mineTimeDecrase;
		data.mineTimePrice = TheMine.mineTimePrice;
		data.mineMaterialsPrice = TheMine.mineMaterialsPrice;
		data.miningTime = TheMine.miningTime;
		data.barsMined = TheMine.barsMined;
		data.bersMinedIncrease = TheMine.bersMinedIncrease;
	}

	// Token: 0x060000BB RID: 187 RVA: 0x0000F120 File Offset: 0x0000D320
	public void ResetTheMine()
	{
		this.tooltipBars.SetActive(false);
		this.tooltipSpeed.SetActive(false);
		this.mineProgressBar.SetActive(false);
		this.mineSpeedBtn.SetActive(false);
		this.mineOreBtn.SetActive(false);
		this.purchaseMineBtn.SetActive(false);
		this.lockedMine.SetActive(true);
		TheMine.isTheMineUnlocked = false;
		TheMine.theMinePrice = 500.0;
		TheMine.miningTime = 15f;
		TheMine.mineTimeDecrase = TheMine.miningTime / 18f;
		TheMine.mineTimePrice = 300.0;
		TheMine.mineMaterialsPrice = 750.0;
		TheMine.barsMined = 2;
		TheMine.bersMinedIncrease = 2;
		base.StopAllCoroutines();
	}

	// Token: 0x060000BC RID: 188 RVA: 0x0000F1E0 File Offset: 0x0000D3E0
	public void OpenTooltip()
	{
		if (MobileAndTesting.isMobile)
		{
			this.audioManager.Play("UI_Click1");
			this.infoTooltip.transform.localScale = new Vector2(2.1f, 2.1f);
			this.infoTooltip.transform.localPosition = new Vector2(0f, 45f);
			this.infoTooltip.SetActive(true);
			this.closeInfoTooltip.SetActive(true);
			this.infoTooltipDark.SetActive(true);
		}
	}

	// Token: 0x060000BD RID: 189 RVA: 0x0000F270 File Offset: 0x0000D470
	public void CloseTooltip()
	{
		this.audioManager.Play("UI_Click1");
		this.infoTooltip.SetActive(false);
		this.closeInfoTooltip.SetActive(false);
		this.infoTooltipDark.SetActive(false);
	}

	// Token: 0x040003B8 RID: 952
	public GoldAndOreMechanics goldScript;

	// Token: 0x040003B9 RID: 953
	public LocalizationScript locScript;

	// Token: 0x040003BA RID: 954
	public AudioManager audioManager;

	// Token: 0x040003BB RID: 955
	public Achievements achScript;

	// Token: 0x040003BC RID: 956
	public GameObject mineProgressBar;

	// Token: 0x040003BD RID: 957
	public GameObject mineSpeedBtn;

	// Token: 0x040003BE RID: 958
	public GameObject mineOreBtn;

	// Token: 0x040003BF RID: 959
	public GameObject lockedMine;

	// Token: 0x040003C0 RID: 960
	public GameObject purchaseMineBtn;

	// Token: 0x040003C1 RID: 961
	public TextMeshProUGUI goldChance_text;

	// Token: 0x040003C2 RID: 962
	public TextMeshProUGUI copperChance_text;

	// Token: 0x040003C3 RID: 963
	public TextMeshProUGUI ironChance_text;

	// Token: 0x040003C4 RID: 964
	public TextMeshProUGUI cobaltChance_text;

	// Token: 0x040003C5 RID: 965
	public TextMeshProUGUI uraniumChance_text;

	// Token: 0x040003C6 RID: 966
	public TextMeshProUGUI ismiumChance_text;

	// Token: 0x040003C7 RID: 967
	public TextMeshProUGUI iridiumChance_text;

	// Token: 0x040003C8 RID: 968
	public TextMeshProUGUI painiteChance_text;

	// Token: 0x040003C9 RID: 969
	public static float goldChance;

	// Token: 0x040003CA RID: 970
	public static float copperChance;

	// Token: 0x040003CB RID: 971
	public static float ironChance;

	// Token: 0x040003CC RID: 972
	public static float cobaltChance;

	// Token: 0x040003CD RID: 973
	public static float uraniumChance;

	// Token: 0x040003CE RID: 974
	public static float ismiumChance;

	// Token: 0x040003CF RID: 975
	public static float iridiumChance;

	// Token: 0x040003D0 RID: 976
	public static float painiteChance;

	// Token: 0x040003D1 RID: 977
	public static bool isTheMineUnlocked;

	// Token: 0x040003D2 RID: 978
	public static double theMinePrice;

	// Token: 0x040003D3 RID: 979
	public static float mineTimeDecrase;

	// Token: 0x040003D4 RID: 980
	public static double mineTimePrice;

	// Token: 0x040003D5 RID: 981
	public static double mineMaterialsPrice;

	// Token: 0x040003D6 RID: 982
	public static float miningTime;

	// Token: 0x040003D7 RID: 983
	public static int barsMined;

	// Token: 0x040003D8 RID: 984
	public static int bersMinedIncrease;

	// Token: 0x040003D9 RID: 985
	public GameObject tooltipSpeed;

	// Token: 0x040003DA RID: 986
	public GameObject tooltipBars;

	// Token: 0x040003DB RID: 987
	public GameObject speedBUTTON;

	// Token: 0x040003DC RID: 988
	public GameObject barsBUTTON;

	// Token: 0x040003DD RID: 989
	public Animation tooltip1Anim;

	// Token: 0x040003DE RID: 990
	public Animation tooltip2Anim;

	// Token: 0x040003DF RID: 991
	public Outline btn1Outline;

	// Token: 0x040003E0 RID: 992
	public Outline btn2Outline;

	// Token: 0x040003E1 RID: 993
	public TextMeshProUGUI mineTimePriceText;

	// Token: 0x040003E2 RID: 994
	public TextMeshProUGUI mineMaterialPriceText;

	// Token: 0x040003E3 RID: 995
	public TextMeshProUGUI theMinePriceText;

	// Token: 0x040003E4 RID: 996
	public Slider mineSlider;

	// Token: 0x040003E5 RID: 997
	public Animation mineMinedAnim;

	// Token: 0x040003E6 RID: 998
	public GameObject infoTooltip;

	// Token: 0x040003E7 RID: 999
	public GameObject closeInfoTooltip;

	// Token: 0x040003E8 RID: 1000
	public GameObject infoTooltipDark;

	// Token: 0x040003E9 RID: 1001
	public Animation infoTooltipAnim;
}
