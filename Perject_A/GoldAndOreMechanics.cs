using System;
using System.Collections;
using TMPro;
using UnityEngine;

// Token: 0x02000028 RID: 40
public class GoldAndOreMechanics : MonoBehaviour, IDataPersistence
{
	// Token: 0x060000F6 RID: 246 RVA: 0x00013A42 File Offset: 0x00011C42
	private void Start()
	{
		GoldAndOreMechanics.totalGoldore = 0.0;
		base.StartCoroutine(this.Wait());
	}

	// Token: 0x060000F7 RID: 247 RVA: 0x00013A5F File Offset: 0x00011C5F
	private IEnumerator Wait()
	{
		this.checkUpdate = false;
		yield return new WaitForSeconds(0.1f);
		this.SetTotalResourcesText();
		yield return new WaitForSeconds(1f);
		this.checkUpdate = true;
		yield break;
	}

	// Token: 0x060000F8 RID: 248 RVA: 0x00013A70 File Offset: 0x00011C70
	private void Update()
	{
		if (this.checkUpdate)
		{
			if (GoldAndOreMechanics.totalGoldBars < 0.0)
			{
				GoldAndOreMechanics.totalGoldBars = 0.0;
			}
			if (GoldAndOreMechanics.totalCopperBars < 0.0)
			{
				GoldAndOreMechanics.totalCopperBars = 0.0;
			}
			if (GoldAndOreMechanics.totalIronBars < 0.0)
			{
				GoldAndOreMechanics.totalIronBars = 0.0;
			}
			if (GoldAndOreMechanics.totalCobaltBars < 0.0)
			{
				GoldAndOreMechanics.totalCobaltBars = 0.0;
			}
			if (GoldAndOreMechanics.totalUraniumBars < 0.0)
			{
				GoldAndOreMechanics.totalUraniumBars = 0.0;
			}
			if (GoldAndOreMechanics.totalIsmiumBar < 0.0)
			{
				GoldAndOreMechanics.totalIsmiumBar = 0.0;
			}
			if (GoldAndOreMechanics.totalIridiumBars < 0.0)
			{
				GoldAndOreMechanics.totalIridiumBars = 0.0;
			}
			if (GoldAndOreMechanics.totalPainiteBars < 0.0)
			{
				GoldAndOreMechanics.totalPainiteBars = 0.0;
			}
		}
	}

	// Token: 0x060000F9 RID: 249 RVA: 0x00013B78 File Offset: 0x00011D78
	public void GiveMaterialOre(int materialType, int materialAmount)
	{
		bool flag = false;
		if (LevelMechanics.itsHammerTime_chosen && LevelMechanics.rocksMinedByHammer > 0)
		{
			materialAmount *= 2;
			AllStats.doubleOreGained++;
			LevelMechanics.rocksMinedByHammer--;
			flag = true;
		}
		if (Artifacts.goldStack_found)
		{
			int num = 25;
			if (LevelMechanics.archaeologist_chosen && Artifacts.rune_found)
			{
				num = 22;
			}
			else
			{
				if (LevelMechanics.archaeologist_chosen)
				{
					num = 23;
				}
				if (Artifacts.rune_found)
				{
					num = 24;
				}
			}
			this.goldSackIncrement++;
			if (this.goldSackIncrement >= num)
			{
				this.goldSackIncrement = 0;
				materialAmount *= 2;
				AllStats.doubleOreGained++;
				flag = true;
			}
		}
		if ((float)Random.Range(0, 100) < SkillTree.doubleXpAndGoldChance + SetRockScreen.potionDoubleChance_increase && !flag)
		{
			materialAmount *= 2;
			AllStats.doubleOreGained++;
		}
		float num2 = SkillTree.materialsTotalWorth + SetRockScreen.potionMaterialWorthMore_increase;
		switch (materialType)
		{
		case 1:
			GoldAndOreMechanics.totalGoldore += (double)((float)materialAmount * num2);
			this.goldText_MineScreen.text = FormatNumbers.FormatPoints(GoldAndOreMechanics.totalGoldore);
			break;
		case 2:
			GoldAndOreMechanics.totalCopperOre += (double)((float)materialAmount * num2);
			this.copperText_MineScreen.text = FormatNumbers.FormatPoints(GoldAndOreMechanics.totalCopperOre);
			break;
		case 3:
			GoldAndOreMechanics.totalIronOre += (double)((float)materialAmount * num2);
			this.ironText_MineScreen.text = FormatNumbers.FormatPoints(GoldAndOreMechanics.totalIronOre);
			break;
		case 4:
			GoldAndOreMechanics.totalCobaltOre += (double)((float)materialAmount * num2);
			this.cobaltText_MineScreen.text = FormatNumbers.FormatPoints(GoldAndOreMechanics.totalCobaltOre);
			break;
		case 5:
			GoldAndOreMechanics.totalUraniumOre += (double)((float)materialAmount * num2);
			this.uraniumText_MineScreen.text = FormatNumbers.FormatPoints(GoldAndOreMechanics.totalUraniumOre);
			break;
		case 6:
			GoldAndOreMechanics.totalIsmiumOre += (double)((float)materialAmount * num2);
			this.ismiumText_MineScreen.text = FormatNumbers.FormatPoints(GoldAndOreMechanics.totalIsmiumOre);
			break;
		case 7:
			GoldAndOreMechanics.totalIridiumOre += (double)((float)materialAmount * num2);
			this.iridiumText_MineScreen.text = FormatNumbers.FormatPoints(GoldAndOreMechanics.totalIridiumOre);
			break;
		case 8:
			GoldAndOreMechanics.totalPainiteOre += (double)((float)materialAmount * num2);
			this.painiteText_MineScreen.text = FormatNumbers.FormatPoints(GoldAndOreMechanics.totalPainiteOre);
			break;
		}
		AllStats.oresMined += (double)((float)materialAmount * num2);
	}

	// Token: 0x060000FA RID: 250 RVA: 0x00013DCC File Offset: 0x00011FCC
	public void GiveGoldBar(int materialAmount, int materialType)
	{
		float num = SkillTree.materialsTotalWorth + SetRockScreen.potionMaterialWorthMore_increase;
		switch (materialType)
		{
		case 1:
			GoldAndOreMechanics.totalGoldBars += (double)((float)materialAmount * num);
			this.ScaleTotalGoldText(this.goldBarText_mainMenu);
			break;
		case 2:
			GoldAndOreMechanics.totalCopperBars += (double)((float)materialAmount * num);
			this.ScaleTotalGoldText(this.copperBarText_mainMenu);
			break;
		case 3:
			GoldAndOreMechanics.totalIronBars += (double)((float)materialAmount * num);
			this.ScaleTotalGoldText(this.ironBarText_mainMenu);
			break;
		case 4:
			GoldAndOreMechanics.totalCobaltBars += (double)((float)materialAmount * num);
			this.ScaleTotalGoldText(this.cobaltBarText_mainMenu);
			break;
		case 5:
			GoldAndOreMechanics.totalUraniumBars += (double)((float)materialAmount * num);
			this.ScaleTotalGoldText(this.uraniumBarText_mainMenu);
			break;
		case 6:
			GoldAndOreMechanics.totalIsmiumBar += (double)((float)materialAmount * num);
			this.ScaleTotalGoldText(this.ismiumBarText_mainMenu);
			break;
		case 7:
			GoldAndOreMechanics.totalIridiumBars += (double)((float)materialAmount * num);
			this.ScaleTotalGoldText(this.iridiumBarText_mainMenu);
			break;
		case 8:
			GoldAndOreMechanics.totalPainiteBars += (double)((float)materialAmount * num);
			this.ScaleTotalGoldText(this.painiteBarText_mainMenu);
			break;
		}
		AllStats.bardMinedTHEMINE += (double)((float)materialAmount * num);
		this.SetTotalResourcesText();
	}

	// Token: 0x060000FB RID: 251 RVA: 0x00013F1F File Offset: 0x0001211F
	public void ScaleTotalGoldText(TextMeshProUGUI text)
	{
		this.scaleGoldTextCoroutine = base.StartCoroutine(this.ScaleGoldTextAnim(text, 1f));
	}

	// Token: 0x060000FC RID: 252 RVA: 0x00013F3C File Offset: 0x0001213C
	public void SetTotalResourcesText()
	{
		this.goldBarText_mainMenu.text = FormatNumbers.FormatPoints(GoldAndOreMechanics.totalGoldBars);
		this.copperBarText_mainMenu.text = FormatNumbers.FormatPoints(GoldAndOreMechanics.totalCopperBars);
		this.ironBarText_mainMenu.text = FormatNumbers.FormatPoints(GoldAndOreMechanics.totalIronBars);
		this.cobaltBarText_mainMenu.text = FormatNumbers.FormatPoints(GoldAndOreMechanics.totalCobaltBars);
		this.uraniumBarText_mainMenu.text = FormatNumbers.FormatPoints(GoldAndOreMechanics.totalUraniumBars);
		this.ismiumBarText_mainMenu.text = FormatNumbers.FormatPoints(GoldAndOreMechanics.totalIsmiumBar);
		this.iridiumBarText_mainMenu.text = FormatNumbers.FormatPoints(GoldAndOreMechanics.totalIridiumBars);
		this.painiteBarText_mainMenu.text = FormatNumbers.FormatPoints(GoldAndOreMechanics.totalPainiteBars);
	}

	// Token: 0x060000FD RID: 253 RVA: 0x00013FF4 File Offset: 0x000121F4
	public void ScaleGoldAnim(int materialType)
	{
		TextMeshProUGUI textToScale = null;
		switch (materialType)
		{
		case 1:
			textToScale = this.goldText_MineScreen;
			break;
		case 2:
			textToScale = this.copperText_MineScreen;
			break;
		case 3:
			textToScale = this.ironText_MineScreen;
			break;
		case 4:
			textToScale = this.cobaltText_MineScreen;
			break;
		case 5:
			textToScale = this.uraniumText_MineScreen;
			break;
		case 6:
			textToScale = this.ismiumText_MineScreen;
			break;
		case 7:
			textToScale = this.iridiumText_MineScreen;
			break;
		case 8:
			textToScale = this.painiteText_MineScreen;
			break;
		}
		this.scaleGoldTextCoroutine = base.StartCoroutine(this.ScaleGoldTextAnim(textToScale, 1.4f));
	}

	// Token: 0x060000FE RID: 254 RVA: 0x0001408B File Offset: 0x0001228B
	private IEnumerator ScaleGoldTextAnim(TextMeshProUGUI textToScale, float startScale)
	{
		Vector2 originalScale = new Vector2(startScale, startScale);
		textToScale.transform.localScale = originalScale;
		float num = Random.Range(startScale * 1.1f, startScale * 1.4f);
		Vector2 targetScale = new Vector2(num, num);
		float scaleDuration = Random.Range(0.06f, 0.12f);
		float elapsedTime = 0f;
		while (elapsedTime < scaleDuration)
		{
			elapsedTime += Time.deltaTime;
			float t = elapsedTime / scaleDuration;
			textToScale.transform.localScale = Vector2.Lerp(originalScale, targetScale, t);
			yield return null;
		}
		textToScale.transform.localScale = targetScale;
		float scaleDownDuration = Random.Range(0.06f, 0.12f);
		elapsedTime = 0f;
		while (elapsedTime < scaleDownDuration)
		{
			elapsedTime += Time.deltaTime;
			float t2 = elapsedTime / scaleDownDuration;
			textToScale.transform.localScale = Vector2.Lerp(targetScale, originalScale, t2);
			yield return null;
		}
		textToScale.transform.localScale = originalScale;
		this.scaleGoldTextCoroutine = null;
		yield break;
	}

	// Token: 0x060000FF RID: 255 RVA: 0x000140A8 File Offset: 0x000122A8
	public void ResetStuff()
	{
		GoldAndOreMechanics.totalGoldore = 0.0;
		GoldAndOreMechanics.totalCopperOre = 0.0;
		GoldAndOreMechanics.totalIronOre = 0.0;
		GoldAndOreMechanics.totalCobaltOre = 0.0;
		GoldAndOreMechanics.totalUraniumOre = 0.0;
		GoldAndOreMechanics.totalIsmiumOre = 0.0;
		GoldAndOreMechanics.totalIridiumOre = 0.0;
		GoldAndOreMechanics.totalPainiteOre = 0.0;
		this.goldText_MineScreen.text = GoldAndOreMechanics.totalGoldore.ToString("F0");
		this.copperText_MineScreen.text = GoldAndOreMechanics.totalCopperOre.ToString("F0");
		this.ironText_MineScreen.text = GoldAndOreMechanics.totalIronOre.ToString("F0");
		this.cobaltText_MineScreen.text = GoldAndOreMechanics.totalCobaltOre.ToString("F0");
		this.uraniumText_MineScreen.text = GoldAndOreMechanics.totalUraniumOre.ToString("F0");
		this.ismiumText_MineScreen.text = GoldAndOreMechanics.totalIsmiumOre.ToString("F0");
		this.iridiumText_MineScreen.text = GoldAndOreMechanics.totalIridiumOre.ToString("F0");
		this.painiteText_MineScreen.text = GoldAndOreMechanics.totalPainiteOre.ToString("F0");
	}

	// Token: 0x06000100 RID: 256 RVA: 0x000141F8 File Offset: 0x000123F8
	public void LoadData(GameData data)
	{
		GoldAndOreMechanics.totalGoldBars = data.totalGoldBars;
		GoldAndOreMechanics.totalCopperBars = data.totalCopperBars;
		GoldAndOreMechanics.totalIronBars = data.totalIronBars;
		GoldAndOreMechanics.totalCobaltBars = data.totalCobaltBars;
		GoldAndOreMechanics.totalUraniumBars = data.totalUraniumBars;
		GoldAndOreMechanics.totalIsmiumBar = data.totalIsmiumBar;
		GoldAndOreMechanics.totalIridiumBars = data.totalIridiumBars;
		GoldAndOreMechanics.totalPainiteBars = data.totalPainiteBars;
	}

	// Token: 0x06000101 RID: 257 RVA: 0x00014260 File Offset: 0x00012460
	public void SaveData(ref GameData data)
	{
		data.totalGoldBars = GoldAndOreMechanics.totalGoldBars;
		data.totalCopperBars = GoldAndOreMechanics.totalCopperBars;
		data.totalIronBars = GoldAndOreMechanics.totalIronBars;
		data.totalCobaltBars = GoldAndOreMechanics.totalCobaltBars;
		data.totalUraniumBars = GoldAndOreMechanics.totalUraniumBars;
		data.totalIsmiumBar = GoldAndOreMechanics.totalIsmiumBar;
		data.totalIridiumBars = GoldAndOreMechanics.totalIridiumBars;
		data.totalPainiteBars = GoldAndOreMechanics.totalPainiteBars;
	}

	// Token: 0x06000102 RID: 258 RVA: 0x000142D0 File Offset: 0x000124D0
	public void ResetBars()
	{
		GoldAndOreMechanics.totalGoldBars = 0.49399998784065247;
		GoldAndOreMechanics.totalCopperBars = 0.49399998784065247;
		GoldAndOreMechanics.totalIronBars = 0.49399998784065247;
		GoldAndOreMechanics.totalCobaltBars = 0.49399998784065247;
		GoldAndOreMechanics.totalUraniumBars = 0.49399998784065247;
		GoldAndOreMechanics.totalIsmiumBar = 0.49399998784065247;
		GoldAndOreMechanics.totalIridiumBars = 0.49399998784065247;
		GoldAndOreMechanics.totalPainiteBars = 0.49399998784065247;
		this.SetTotalResourcesText();
	}

	// Token: 0x06000103 RID: 259 RVA: 0x00014354 File Offset: 0x00012554
	public void TestingButtons(int buttonType)
	{
		if (buttonType == 1)
		{
			GoldAndOreMechanics.totalGoldBars += 2000.0;
			return;
		}
		if (buttonType == 2)
		{
			GoldAndOreMechanics.totalGoldBars += 100000.0;
			return;
		}
		if (buttonType == 3)
		{
			GoldAndOreMechanics.totalGoldBars += 1000.0;
			GoldAndOreMechanics.totalIronBars += 1000.0;
			GoldAndOreMechanics.totalCopperBars += 1000.0;
			GoldAndOreMechanics.totalCobaltBars += 1000.0;
			GoldAndOreMechanics.totalUraniumBars += 1000.0;
			GoldAndOreMechanics.totalIsmiumBar += 1000.0;
			GoldAndOreMechanics.totalIridiumBars += 1000.0;
			GoldAndOreMechanics.totalPainiteBars += 1000.0;
			return;
		}
		if (buttonType == 4)
		{
			GoldAndOreMechanics.totalGoldBars += 100000.0;
			GoldAndOreMechanics.totalIronBars += 100000.0;
			GoldAndOreMechanics.totalCopperBars += 100000.0;
			GoldAndOreMechanics.totalCobaltBars += 100000.0;
			GoldAndOreMechanics.totalUraniumBars += 100000.0;
			GoldAndOreMechanics.totalIsmiumBar += 100000.0;
			GoldAndOreMechanics.totalIridiumBars += 100000.0;
			GoldAndOreMechanics.totalPainiteBars += 100000.0;
			return;
		}
		if (buttonType == 5)
		{
			GoldAndOreMechanics.totalGoldBars += 1000000.0;
			GoldAndOreMechanics.totalIronBars += 1000000.0;
			GoldAndOreMechanics.totalCopperBars += 1000000.0;
			GoldAndOreMechanics.totalCobaltBars += 1000000.0;
			GoldAndOreMechanics.totalUraniumBars += 1000000.0;
			GoldAndOreMechanics.totalIsmiumBar += 1000000.0;
			GoldAndOreMechanics.totalIridiumBars += 1000000.0;
			GoldAndOreMechanics.totalPainiteBars += 1000000.0;
			return;
		}
		if (buttonType == 6)
		{
			LevelMechanics.totalTalentPoints += 10;
			return;
		}
		GoldAndOreMechanics.totalGoldBars = 0.0;
		GoldAndOreMechanics.totalIronBars = 0.0;
		GoldAndOreMechanics.totalCopperBars = 0.0;
		GoldAndOreMechanics.totalCobaltBars = 0.0;
		GoldAndOreMechanics.totalUraniumBars = 0.0;
		GoldAndOreMechanics.totalIsmiumBar = 0.0;
		GoldAndOreMechanics.totalIridiumBars = 0.0;
		GoldAndOreMechanics.totalPainiteBars = 0.0;
	}

	// Token: 0x04000465 RID: 1125
	public TextMeshProUGUI goldText_MineScreen;

	// Token: 0x04000466 RID: 1126
	public TextMeshProUGUI goldBarText_mainMenu;

	// Token: 0x04000467 RID: 1127
	public TextMeshProUGUI copperText_MineScreen;

	// Token: 0x04000468 RID: 1128
	public TextMeshProUGUI copperBarText_mainMenu;

	// Token: 0x04000469 RID: 1129
	public TextMeshProUGUI ironText_MineScreen;

	// Token: 0x0400046A RID: 1130
	public TextMeshProUGUI ironBarText_mainMenu;

	// Token: 0x0400046B RID: 1131
	public TextMeshProUGUI cobaltText_MineScreen;

	// Token: 0x0400046C RID: 1132
	public TextMeshProUGUI cobaltBarText_mainMenu;

	// Token: 0x0400046D RID: 1133
	public TextMeshProUGUI uraniumText_MineScreen;

	// Token: 0x0400046E RID: 1134
	public TextMeshProUGUI uraniumBarText_mainMenu;

	// Token: 0x0400046F RID: 1135
	public TextMeshProUGUI ismiumText_MineScreen;

	// Token: 0x04000470 RID: 1136
	public TextMeshProUGUI ismiumBarText_mainMenu;

	// Token: 0x04000471 RID: 1137
	public TextMeshProUGUI iridiumText_MineScreen;

	// Token: 0x04000472 RID: 1138
	public TextMeshProUGUI iridiumBarText_mainMenu;

	// Token: 0x04000473 RID: 1139
	public TextMeshProUGUI painiteText_MineScreen;

	// Token: 0x04000474 RID: 1140
	public TextMeshProUGUI painiteBarText_mainMenu;

	// Token: 0x04000475 RID: 1141
	public static double totalGoldore;

	// Token: 0x04000476 RID: 1142
	public static double totalGoldBars;

	// Token: 0x04000477 RID: 1143
	public static double totalCopperOre;

	// Token: 0x04000478 RID: 1144
	public static double totalCopperBars;

	// Token: 0x04000479 RID: 1145
	public static double totalIronOre;

	// Token: 0x0400047A RID: 1146
	public static double totalIronBars;

	// Token: 0x0400047B RID: 1147
	public static double totalCobaltOre;

	// Token: 0x0400047C RID: 1148
	public static double totalCobaltBars;

	// Token: 0x0400047D RID: 1149
	public static double totalUraniumOre;

	// Token: 0x0400047E RID: 1150
	public static double totalUraniumBars;

	// Token: 0x0400047F RID: 1151
	public static double totalIsmiumOre;

	// Token: 0x04000480 RID: 1152
	public static double totalIsmiumBar;

	// Token: 0x04000481 RID: 1153
	public static double totalIridiumOre;

	// Token: 0x04000482 RID: 1154
	public static double totalIridiumBars;

	// Token: 0x04000483 RID: 1155
	public static double totalPainiteOre;

	// Token: 0x04000484 RID: 1156
	public static double totalPainiteBars;

	// Token: 0x04000485 RID: 1157
	private int goldSackIncrement;

	// Token: 0x04000486 RID: 1158
	private bool checkUpdate;

	// Token: 0x04000487 RID: 1159
	public Coroutine scaleGoldTextCoroutine;
}
