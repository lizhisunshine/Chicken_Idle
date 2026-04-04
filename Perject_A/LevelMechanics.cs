using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200002B RID: 43
public class LevelMechanics : MonoBehaviour, IDataPersistence
{
	// Token: 0x0600010D RID: 269 RVA: 0x0001489E File Offset: 0x00012A9E
	private void Awake()
	{
		this.SetOriginalStats();
		base.StartCoroutine(this.Wait());
	}

	// Token: 0x0600010E RID: 270 RVA: 0x000148B4 File Offset: 0x00012AB4
	public void SetOriginalStats()
	{
		LevelMechanics.talentLevelHpIncrease = 2;
		LevelMechanics.inflationBurstIncrease = 0.4f;
		LevelMechanics.totalGoldenChestMaterials = 50;
		LevelMechanics.totalChestMaterials = 25;
		LevelMechanics.archeologistIncrease = 0f;
		LevelMechanics.archeologistIncreaseDISPLAY = 0.08f;
		LevelMechanics.steamSaleDiscount = 1f;
		LevelMechanics.blacksmithDecrease = 1f;
		LevelMechanics.blacksmithDecreaseDISPLAY = 0.75f;
		LevelMechanics.shapeShifterSizeIncrease = 0f;
		LevelMechanics.shapeShifterSizeIncreaseDISPLAY = 0.06f;
		LevelMechanics.rockSpawnChance = 0.6f;
		LevelMechanics.skilledMinersFastChance = 10f;
		LevelMechanics.skilledMinersDoubleChance = 8f;
		LevelMechanics.bigMiningAreaChance = 7f;
		LevelMechanics.bigMiningAreaTime = 3f;
		LevelMechanics.hammerChance = 0.4f;
		LevelMechanics.midasTouchChance = 20;
		LevelMechanics.midasTouchSpawnChance = 25;
		LevelMechanics.zeusChance = 5;
		LevelMechanics.zeusLightningAmount = 15;
		LevelMechanics.energiDrinkChance = 7;
		LevelMechanics.energiDrinkTime = 3;
		LevelMechanics.flowerIncrease = 0.015f;
	}

	// Token: 0x0600010F RID: 271 RVA: 0x00014992 File Offset: 0x00012B92
	private IEnumerator Wait()
	{
		yield return new WaitForSeconds(0.1f);
		if (!MobileAndTesting.isMobile)
		{
			this.goldenCursorCard.SetActive(true);
			this.goldenCursorLeft.SetActive(true);
			this.goldenCircleCard.SetActive(false);
			this.goldenCircleLeft.SetActive(false);
		}
		else
		{
			this.potionTooltipAnim.enabled = false;
			this.talentTooltipAnim.enabled = false;
			this.talentLevelAnim.enabled = false;
			this.goldenCursorCard.SetActive(false);
			this.goldenCursorLeft.SetActive(false);
			this.goldenCircleCard.SetActive(true);
			this.goldenCircleLeft.SetActive(true);
		}
		if (LevelMechanics.potionDrinker_chosen)
		{
			this.potionDrinker_unlocked.SetActive(true);
		}
		if (LevelMechanics.potionChugger_chosen)
		{
			this.potionChugger_unlocked.SetActive(true);
		}
		if (LevelMechanics.chests_chosen)
		{
			this.chests_unlocked.SetActive(true);
		}
		if (LevelMechanics.goldenChests_chosen)
		{
			this.goldenChests_unlocked.SetActive(true);
		}
		if (LevelMechanics.skilledMiners_chosen)
		{
			this.skilledMiners_unlocked.SetActive(true);
		}
		if (LevelMechanics.efficientBlacksmith_chosen)
		{
			this.efficientBlacksmith_unlocked.SetActive(true);
			LevelMechanics.blacksmithDecrease = LevelMechanics.blacksmithDecreaseDISPLAY;
		}
		if (LevelMechanics.itsASign_chosen)
		{
			this.itsASign_unlocked.SetActive(true);
			base.StartCoroutine(this.ChangeSignBuff());
			this.sign.SetActive(true);
		}
		if (LevelMechanics.steamSale_chosen)
		{
			this.steamSale_unlocked.SetActive(true);
			LevelMechanics.steamSaleDiscount = 0.93f;
		}
		if (LevelMechanics.bigMiningArea_chosen)
		{
			this.bigMiningArea_unlocked.SetActive(true);
			base.StartCoroutine(this.ChanceToIncreaseMiningErea());
		}
		if (LevelMechanics.itsHammerTime_chosen)
		{
			this.itsHammerTime_unlocked.SetActive(true);
		}
		if (LevelMechanics.goldenTouch_chosen)
		{
			this.goldenTouch_unlocked.SetActive(true);
		}
		if (LevelMechanics.zeus_chosen)
		{
			this.zeus_unlocked.SetActive(true);
			base.StartCoroutine(this.StartZeus());
		}
		if (LevelMechanics.shapeShifter_chosen)
		{
			this.shapeShifter_unlocked.SetActive(true);
			LevelMechanics.shapeShifterSizeIncrease = LevelMechanics.shapeShifterSizeIncreaseDISPLAY;
		}
		if (LevelMechanics.xMarksTheSpor_chosen)
		{
			this.xMarksTheSpor_unlocked.SetActive(true);
		}
		if (LevelMechanics.explorer_chosen)
		{
			this.explorer_unlocked.SetActive(true);
		}
		if (LevelMechanics.archaeologist_chosen)
		{
			this.archaeologist_unlocked.SetActive(true);
			LevelMechanics.archeologistIncrease = LevelMechanics.archeologistIncreaseDISPLAY;
		}
		if (LevelMechanics.energiDrinker_chosen)
		{
			this.energiDrinker_unlocked.SetActive(true);
			base.StartCoroutine(this.ChanceToDrinkEnergiDRink());
		}
		if (LevelMechanics.springSeason_chosen)
		{
			this.springSeason_unlocked.SetActive(true);
		}
		if (LevelMechanics.camper_chosen)
		{
			this.camper_unlocked.SetActive(true);
		}
		if (LevelMechanics.d100_chosen)
		{
			this.d100_unlocked.SetActive(true);
		}
		if (LevelMechanics.isInChoose1)
		{
			this.unlockParent.SetActive(false);
			this.blockBtn.SetActive(true);
			this.choose1Parent.SetActive(true);
			this.lockedTalent1.Play("RemoveBlockedCard");
			this.lockedTalent2.Play("RemoveBlockedCard");
			this.lockedTalent3.Play("RemoveBlockedCard");
			if (LevelMechanics.talentCard1Picked == 0 || LevelMechanics.talentCard2Picked == 0 || LevelMechanics.talentCard3Picked == 0)
			{
				this.setSpecificCards = false;
				this.AddTalentCards();
			}
			else
			{
				this.setSpecificCards = true;
				this.AddTalentCards();
				this.startCardsAdded++;
				this.SetCard();
				if (LevelMechanics.cardsLeft > 1)
				{
					this.startCardsAdded++;
					this.SetCard();
				}
				if (LevelMechanics.cardsLeft > 2)
				{
					this.startCardsAdded++;
					this.SetCard();
				}
			}
		}
		else
		{
			this.setSpecificCards = false;
			this.AddTalentCards();
		}
		this.SetTalentTexts();
		yield break;
	}

	// Token: 0x06000110 RID: 272 RVA: 0x000149A4 File Offset: 0x00012BA4
	private void Update()
	{
		if (MainMenu.isInTalents)
		{
			string arg;
			if (LevelMechanics.totalTalentPoints >= LevelMechanics.newTalentsPrice)
			{
				arg = "<color=green>";
			}
			else
			{
				arg = "<color=red>";
			}
			this.revealTalentsPriceText.text = string.Format("{0} {1}{2}", LocalizationScript.price, arg, LevelMechanics.newTalentsPrice);
		}
	}

	// Token: 0x06000111 RID: 273 RVA: 0x00014A00 File Offset: 0x00012C00
	public void SetTalentTexts()
	{
		this.talentLevelText.text = LocalizationScript.talentLevel + " " + LevelMechanics.talentLevel.ToString();
		float num = (float)(10 + LevelMechanics.talentLevelHpIncrease * LevelMechanics.talentLevel);
		num -= (float)LevelMechanics.talentLevelHpIncrease;
		if (Artifacts.horn_found)
		{
			float num2 = 1f - Artifacts.hornRockDecrease;
			if (LevelMechanics.archaeologist_chosen)
			{
				num2 -= Artifacts.hornRockDecrease * LevelMechanics.archeologistIncreaseDISPLAY;
			}
			if (Artifacts.rune_found)
			{
				num2 -= Artifacts.hornRockDecrease * Artifacts.runeImproveAll;
			}
			num *= num2;
			this.rockDurabilityTooltipText.text = "= " + num.ToString("F2") + " " + LocalizationScript.durability;
		}
		else
		{
			this.rockDurabilityTooltipText.text = "= " + num.ToString("F0") + " " + LocalizationScript.durability;
		}
		this.xpSlider.minValue = 0f;
		this.xpSlider.maxValue = this.xpNeedForNextLvl;
		this.xpSlider.value = this.currentXP;
		float value = this.xpSlider.value;
		this.needToReachText.text = FormatNumbers.FormatPoints((double)(value * 100f)) + "/" + FormatNumbers.FormatPoints((double)(this.xpSlider.maxValue * 100f)) + "XP";
		this.levelText.text = (LevelMechanics.level.ToString() ?? "");
		this.talentScreen_talentPoints.text = LevelMechanics.totalTalentPoints.ToString("F0");
	}

	// Token: 0x06000112 RID: 274 RVA: 0x00014B98 File Offset: 0x00012D98
	public void GiveXP()
	{
		float num = (float)Random.Range(0, 100);
		float num2 = LevelMechanics.xpFromRock;
		if (num < SkillTree.doubleXpAndGoldChance + SetRockScreen.potionDoubleChance_increase)
		{
			if (LevelMechanics.springSeason_chosen)
			{
				float num3 = LevelMechanics.flowerIncrease * (float)SetRockScreen.flowersOnScreen;
				num3 += 1f;
				if (SetRockScreen.isPotionXp)
				{
					num3 += SetRockScreen.potionXp_increase;
				}
				num2 *= num3;
			}
			else if (SetRockScreen.isPotionXp)
			{
				num2 *= 1f + SetRockScreen.potionXp_increase;
			}
			this.xpSlider.value += num2 * 2f;
			LevelMechanics.xpThisRound += num2 * 2f;
			AllStats.doubleXPGained++;
		}
		else
		{
			if (LevelMechanics.springSeason_chosen)
			{
				float num4 = LevelMechanics.flowerIncrease * (float)SetRockScreen.flowersOnScreen;
				num4 += 1f;
				if (SetRockScreen.isPotionXp)
				{
					num4 += SetRockScreen.potionXp_increase;
				}
				num2 *= num4;
			}
			else if (SetRockScreen.isPotionXp)
			{
				num2 *= 1f + SetRockScreen.potionXp_increase;
			}
			if (Artifacts.purpleRing_found)
			{
				float num5 = 1f + LevelMechanics.archeologistIncrease + Artifacts.runeImproveAll;
				if (Random.Range(0f, 100f) < Artifacts.purpleRingChance * num5)
				{
					num2 *= 2f;
				}
			}
			this.xpSlider.value += num2;
			LevelMechanics.xpThisRound += num2;
		}
		this.currentXP += num2;
		AllStats.experienceGained += num2;
		if (this.xpSlider.value >= this.xpNeedForNextLvl)
		{
			if (!Tutorial.pressedOkTalent)
			{
				this.tutorialScript.SetTutorial(2);
			}
			this.audioManager.Play("LevelUp");
			AllStats.totalLevelUps++;
			this.currentXP = 0f;
			this.xpSlider.value = 0f;
			LevelMechanics.level++;
			this.achScript.CheckAch();
			this.levelText.text = (LevelMechanics.level.ToString() ?? "");
			float num6 = 1.7f;
			if (LevelMechanics.level > 2)
			{
				for (int i = 0; i < LevelMechanics.level - 1; i++)
				{
					num6 -= 0.024f;
					if (num6 < 1.075f)
					{
						num6 = 1.075f;
					}
				}
			}
			this.xpNeedForNextLvl *= num6;
			this.xpSlider.minValue = 0f;
			this.xpSlider.maxValue = this.xpNeedForNextLvl;
			int num7 = 0;
			LevelMechanics.totalTalentPoints++;
			num7++;
			LevelMechanics.didLevelUp = true;
			if (SkillTree.talentPointsPerXlevel_1_purchased || SkillTree.talentPointsPerXlevel_2_purchased || SkillTree.talentPointsPerXlevel_3_purchased)
			{
				LevelMechanics.extraTalentPointPerLevelCOUNT++;
				if (LevelMechanics.extraTalentPointPerLevelCOUNT >= SkillTree.extraTalentPointPerLevel)
				{
					LevelMechanics.extraTalentPointPerLevelCOUNT = 0;
					LevelMechanics.totalTalentPoints++;
					num7++;
				}
			}
			if (Artifacts.book_found)
			{
				LevelMechanics.extraTalentPointBOOK++;
				if (LevelMechanics.extraTalentPointBOOK == 5)
				{
					LevelMechanics.totalTalentPoints++;
					num7++;
					LevelMechanics.extraTalentPointBOOK = 0;
				}
			}
			LevelMechanics.didLevelUpTotalTalentPoints = num7;
			this.levelUpAnim.GetComponent<TextMeshProUGUI>().text = LocalizationScript.levelUp + " <color=purple>+" + num7.ToString();
			this.levelUpAnim.gameObject.SetActive(true);
			this.levelUpAnim.Play();
			base.StartCoroutine(this.SetLevelAnimOff());
			this.talentScreen_talentPoints.text = LevelMechanics.totalTalentPoints.ToString("F0");
		}
		float value = this.xpSlider.value;
		this.needToReachText.text = FormatNumbers.FormatPoints((double)(value * 100f)) + "/" + FormatNumbers.FormatPoints((double)(this.xpSlider.maxValue * 100f)) + "XP";
	}

	// Token: 0x06000113 RID: 275 RVA: 0x00014F52 File Offset: 0x00013152
	private IEnumerator SetLevelAnimOff()
	{
		yield return new WaitForSeconds(2.08f);
		this.levelUpAnim.gameObject.SetActive(false);
		yield break;
	}

	// Token: 0x06000114 RID: 276 RVA: 0x00014F64 File Offset: 0x00013164
	public void UnlockTalents()
	{
		if (LevelMechanics.totalTalentPoints >= LevelMechanics.newTalentsPrice && !LevelMechanics.isInChoose1)
		{
			LevelMechanics.totalTalentPoints -= LevelMechanics.newTalentsPrice;
			this.talentScreen_talentPoints.text = LevelMechanics.totalTalentPoints.ToString("F0");
			LevelMechanics.newTalentsPrice++;
			this.blockBtn.SetActive(true);
			LevelMechanics.isBlockFrameActive = true;
			this.unlockParent.SetActive(false);
			this.choose1Parent.SetActive(true);
			LevelMechanics.isInChoose1 = true;
			this.blockFrame.SetActive(true);
			base.StartCoroutine(this.RemoveBlockedTalentCards());
			return;
		}
		this.audioManager.Play("CantAfford");
	}

	// Token: 0x06000115 RID: 277 RVA: 0x0001501A File Offset: 0x0001321A
	private IEnumerator RemoveBlockedTalentCards()
	{
		this.audioManager.Play("FadeIn");
		this.lockedTalent1.Play("RemoveBlockedCard");
		yield return new WaitForSeconds(0.2f);
		this.audioManager.Play("FadeIn");
		this.lockedTalent2.Play("RemoveBlockedCard");
		yield return new WaitForSeconds(0.2f);
		this.audioManager.Play("FadeIn");
		this.lockedTalent3.Play("RemoveBlockedCard");
		yield return new WaitForSeconds(0.35f);
		this.blockFrame.SetActive(false);
		yield break;
	}

	// Token: 0x06000116 RID: 278 RVA: 0x0001502C File Offset: 0x0001322C
	public void AddTalentCards()
	{
		if (LevelMechanics.cardsLeft < 3)
		{
			this.card1Left.SetActive(true);
		}
		if (LevelMechanics.cardsLeft < 2)
		{
			this.card2Left.SetActive(true);
		}
		if (LevelMechanics.cardsLeft < 1)
		{
			this.cardAllChosen.SetActive(true);
			if (MainMenu.isInTalents)
			{
				this.allTalentCardsChosenBlockBtn.SetActive(true);
			}
		}
		this.locScript.TalentCardsLeftText();
		this.cardsChosen = 0;
		this.potionDrinker_card.SetActive(false);
		this.potionChugger_Card.SetActive(false);
		this.chests_card.SetActive(false);
		this.goldenChests_card.SetActive(false);
		this.skilledMiners_card.SetActive(false);
		this.efficientBlacksmith_card.SetActive(false);
		this.itsASign_card.SetActive(false);
		this.steamSale_card.SetActive(false);
		this.bigMiningArea_card.SetActive(false);
		this.itsHammerTime_card.SetActive(false);
		this.goldenTouch_card.SetActive(false);
		this.zeus_card.SetActive(false);
		this.shapeShifter_card.SetActive(false);
		this.xMarksTheSpor_card.SetActive(false);
		this.explorer_card.SetActive(false);
		this.archaeologist_Card.SetActive(false);
		this.energiDrinker_card.SetActive(false);
		this.springSeason_card.SetActive(false);
		this.camper_card.SetActive(false);
		this.d100_card.SetActive(false);
		if (!this.setSpecificCards)
		{
			this.SetCard();
		}
	}

	// Token: 0x06000117 RID: 279 RVA: 0x00015198 File Offset: 0x00013398
	public void SetCard()
	{
		if (LevelMechanics.cardsLeft == 0)
		{
			return;
		}
		int num = 0;
		if (this.setSpecificCards)
		{
			if (this.startCardsAdded == 1)
			{
				num = LevelMechanics.talentCard1Picked;
			}
			if (this.startCardsAdded == 2)
			{
				num = LevelMechanics.talentCard2Picked;
			}
			if (this.startCardsAdded == 3)
			{
				num = LevelMechanics.talentCard3Picked;
			}
		}
		else
		{
			num = Random.Range(1, 21);
		}
		if (num == 1 && !LevelMechanics.potionDrinker_chosen)
		{
			if (this.card1Number == num || this.card2Number == num || this.card3Number == num)
			{
				this.SetCard();
				return;
			}
			this.storeCard[this.cardsChosen] = this.potionDrinker_card;
			this.storeCard[this.cardsChosen].SetActive(true);
			this.locScript.TalentTexts(num);
		}
		else if (num == 2 && !LevelMechanics.potionChugger_chosen)
		{
			if (LevelMechanics.cardsLeft > 5 && !LevelMechanics.potionDrinker_chosen)
			{
				this.SetCard();
				return;
			}
			if (this.card1Number == num || this.card2Number == num || this.card3Number == num)
			{
				this.SetCard();
				return;
			}
			this.storeCard[this.cardsChosen] = this.potionChugger_Card;
			this.storeCard[this.cardsChosen].SetActive(true);
			this.locScript.TalentTexts(num);
		}
		else if (num == 3 && !LevelMechanics.chests_chosen)
		{
			if (this.card1Number == num || this.card2Number == num || this.card3Number == num)
			{
				this.SetCard();
				return;
			}
			this.storeCard[this.cardsChosen] = this.chests_card;
			this.storeCard[this.cardsChosen].SetActive(true);
			this.locScript.TalentTexts(num);
		}
		else if (num == 4 && !LevelMechanics.goldenChests_chosen)
		{
			if (this.card1Number == num || this.card2Number == num || this.card3Number == num)
			{
				this.SetCard();
				return;
			}
			this.storeCard[this.cardsChosen] = this.goldenChests_card;
			this.storeCard[this.cardsChosen].SetActive(true);
			this.locScript.TalentTexts(num);
		}
		else if (num == 5 && !LevelMechanics.skilledMiners_chosen)
		{
			if (LevelMechanics.cardsLeft > 7 && !TheMine.isTheMineUnlocked)
			{
				this.SetCard();
				return;
			}
			if (this.card1Number == num || this.card2Number == num || this.card3Number == num)
			{
				this.SetCard();
				return;
			}
			this.storeCard[this.cardsChosen] = this.skilledMiners_card;
			this.storeCard[this.cardsChosen].SetActive(true);
			this.locScript.TalentTexts(num);
		}
		else if (num == 6 && !LevelMechanics.efficientBlacksmith_chosen)
		{
			if (LevelMechanics.cardsLeft > 7 && !TheAnvil.isTheAnvilUnlocked)
			{
				this.SetCard();
				return;
			}
			if (this.card1Number == num || this.card2Number == num || this.card3Number == num)
			{
				this.SetCard();
				return;
			}
			this.storeCard[this.cardsChosen] = this.efficientBlacksmith_card;
			this.storeCard[this.cardsChosen].SetActive(true);
			this.locScript.TalentTexts(7);
		}
		else if (num == 7 && !LevelMechanics.itsASign_chosen)
		{
			if (LevelMechanics.cardsLeft > 7 && !TheMine.isTheMineUnlocked)
			{
				this.SetCard();
				return;
			}
			if (this.card1Number == num || this.card2Number == num || this.card3Number == num)
			{
				this.SetCard();
				return;
			}
			this.storeCard[this.cardsChosen] = this.itsASign_card;
			this.storeCard[this.cardsChosen].SetActive(true);
			this.locScript.TalentTexts(6);
		}
		else if (num == 8 && !LevelMechanics.steamSale_chosen)
		{
			if (this.card1Number == num || this.card2Number == num || this.card3Number == num)
			{
				this.SetCard();
				return;
			}
			this.storeCard[this.cardsChosen] = this.steamSale_card;
			this.storeCard[this.cardsChosen].SetActive(true);
			this.locScript.TalentTexts(num);
		}
		else if (num == 9 && !LevelMechanics.bigMiningArea_chosen)
		{
			if (this.card1Number == num || this.card2Number == num || this.card3Number == num)
			{
				this.SetCard();
				return;
			}
			this.storeCard[this.cardsChosen] = this.bigMiningArea_card;
			this.storeCard[this.cardsChosen].SetActive(true);
			this.locScript.TalentTexts(num);
		}
		else if (num == 10 && !LevelMechanics.itsHammerTime_chosen)
		{
			if (this.card1Number == num || this.card2Number == num || this.card3Number == num)
			{
				this.SetCard();
				return;
			}
			this.storeCard[this.cardsChosen] = this.itsHammerTime_card;
			this.storeCard[this.cardsChosen].SetActive(true);
			this.locScript.TalentTexts(num);
		}
		else if (num == 11 && !LevelMechanics.goldenTouch_chosen)
		{
			if (this.card1Number == num || this.card2Number == num || this.card3Number == num)
			{
				this.SetCard();
				return;
			}
			this.storeCard[this.cardsChosen] = this.goldenTouch_card;
			this.storeCard[this.cardsChosen].SetActive(true);
			this.locScript.TalentTexts(num);
		}
		else if (num == 12 && !LevelMechanics.zeus_chosen)
		{
			if (!SkillTree.lightningBeamChancePH_1_purchased && !SkillTree.lightningBeamChanceS_1_purchased)
			{
				if (LevelMechanics.cardsLeft > 8)
				{
					if (!SkillTree.lightningBeamChancePH_1_purchased)
					{
						this.SetCard();
						return;
					}
					if (!SkillTree.lightningBeamChanceS_1_purchased)
					{
						this.SetCard();
						return;
					}
				}
			}
			else if (LevelMechanics.cardsLeft > 6)
			{
				if (!SkillTree.lightningBeamChancePH_1_purchased)
				{
					this.SetCard();
					return;
				}
				if (!SkillTree.lightningBeamChanceS_1_purchased)
				{
					this.SetCard();
					return;
				}
			}
			if (this.card1Number == num || this.card2Number == num || this.card3Number == num)
			{
				this.SetCard();
				return;
			}
			this.storeCard[this.cardsChosen] = this.zeus_card;
			this.storeCard[this.cardsChosen].SetActive(true);
			this.locScript.TalentTexts(num);
		}
		else if (num == 13 && !LevelMechanics.shapeShifter_chosen)
		{
			if (this.card1Number == num || this.card2Number == num || this.card3Number == num)
			{
				this.SetCard();
				return;
			}
			this.storeCard[this.cardsChosen] = this.shapeShifter_card;
			this.storeCard[this.cardsChosen].SetActive(true);
			this.locScript.TalentTexts(num);
		}
		else if (num == 14 && !LevelMechanics.xMarksTheSpor_chosen)
		{
			if (this.card1Number == num || this.card2Number == num || this.card3Number == num)
			{
				this.SetCard();
				return;
			}
			if (LevelMechanics.cardsLeft > 7 && Artifacts.artifactsFound == 0)
			{
				this.SetCard();
				return;
			}
			this.storeCard[this.cardsChosen] = this.xMarksTheSpor_card;
			this.storeCard[this.cardsChosen].SetActive(true);
			this.locScript.TalentTexts(num);
		}
		else if (num == 15 && !LevelMechanics.explorer_chosen)
		{
			if (this.card1Number == num || this.card2Number == num || this.card3Number == num)
			{
				this.SetCard();
				return;
			}
			if (LevelMechanics.cardsLeft > 7)
			{
				if (!LevelMechanics.xMarksTheSpor_chosen)
				{
					this.SetCard();
					return;
				}
				if (Artifacts.artifactsFound == 0)
				{
					this.SetCard();
					return;
				}
			}
			this.storeCard[this.cardsChosen] = this.explorer_card;
			this.storeCard[this.cardsChosen].SetActive(true);
			this.locScript.TalentTexts(num);
		}
		else if (num == 16 && !LevelMechanics.archaeologist_chosen)
		{
			if (this.card1Number == num || this.card2Number == num || this.card3Number == num)
			{
				this.SetCard();
				return;
			}
			if (LevelMechanics.cardsLeft > 7 && Artifacts.artifactsFound == 0)
			{
				this.SetCard();
				return;
			}
			this.storeCard[this.cardsChosen] = this.archaeologist_Card;
			this.storeCard[this.cardsChosen].SetActive(true);
			this.locScript.TalentTexts(num);
		}
		else if (num == 17 && !LevelMechanics.energiDrinker_chosen)
		{
			if (this.card1Number == num || this.card2Number == num || this.card3Number == num)
			{
				this.SetCard();
				return;
			}
			this.storeCard[this.cardsChosen] = this.energiDrinker_card;
			this.storeCard[this.cardsChosen].SetActive(true);
			this.locScript.TalentTexts(num);
		}
		else if (num == 18 && !LevelMechanics.springSeason_chosen)
		{
			if (this.card1Number == num || this.card2Number == num || this.card3Number == num)
			{
				this.SetCard();
				return;
			}
			this.storeCard[this.cardsChosen] = this.springSeason_card;
			this.storeCard[this.cardsChosen].SetActive(true);
			this.locScript.TalentTexts(num);
		}
		else if (num == 19 && !LevelMechanics.camper_chosen)
		{
			if (this.card1Number == num || this.card2Number == num || this.card3Number == num)
			{
				this.SetCard();
				return;
			}
			this.storeCard[this.cardsChosen] = this.camper_card;
			this.storeCard[this.cardsChosen].SetActive(true);
			this.locScript.TalentTexts(num);
		}
		else
		{
			if (num != 20 || LevelMechanics.d100_chosen)
			{
				this.SetCard();
				return;
			}
			if (this.card1Number == num || this.card2Number == num || this.card3Number == num)
			{
				this.SetCard();
				return;
			}
			this.storeCard[this.cardsChosen] = this.d100_card;
			this.storeCard[this.cardsChosen].SetActive(true);
			this.locScript.TalentTexts(num);
		}
		this.cardsChosen++;
		if (this.cardsChosen == 1)
		{
			this.card1Number = num;
			LevelMechanics.talentCard1Picked = num;
		}
		if (this.cardsChosen == 2)
		{
			this.card2Number = num;
			LevelMechanics.talentCard2Picked = num;
		}
		if (this.cardsChosen == 3)
		{
			this.card3Number = num;
			LevelMechanics.talentCard3Picked = num;
		}
		if (LevelMechanics.cardsLeft > 2)
		{
			if (this.cardsChosen == 1 && !this.setSpecificCards)
			{
				this.SetCard();
			}
			if (this.cardsChosen == 2 && !this.setSpecificCards)
			{
				this.SetCard();
			}
			if (this.cardsChosen == 3)
			{
				this.storeCard[0].SetActive(true);
				this.storeCard[1].SetActive(true);
				this.storeCard[2].SetActive(true);
				this.storeCard[0].transform.localPosition = new Vector2(-424f, 14.6f);
				this.storeCard[1].transform.localPosition = new Vector2(0f, 14.6f);
				this.storeCard[2].transform.localPosition = new Vector2(424f, 14.6f);
				return;
			}
		}
		else if (LevelMechanics.cardsLeft == 2)
		{
			if (this.cardsChosen == 1 && !this.setSpecificCards)
			{
				this.SetCard();
			}
			if (this.cardsChosen == 2)
			{
				this.storeCard[0].SetActive(true);
				this.storeCard[1].SetActive(true);
				this.storeCard[0].transform.localPosition = new Vector2(-424f, 14.6f);
				this.storeCard[1].transform.localPosition = new Vector2(0f, 14.6f);
				return;
			}
		}
		else if (LevelMechanics.cardsLeft == 1 && this.cardsChosen == 1)
		{
			this.storeCard[0].SetActive(true);
			this.storeCard[0].transform.localPosition = new Vector2(-424f, 14.6f);
		}
	}

	// Token: 0x06000118 RID: 280 RVA: 0x00015CE4 File Offset: 0x00013EE4
	public void ChooseTalent()
	{
		this.audioManager.Play("FadeIn");
		this.blockFrame.SetActive(true);
		if (HoverOverIncreaseSize.xPos < -423f)
		{
			this.cardNumberToMove = 0;
		}
		if (HoverOverIncreaseSize.xPos < 1f && HoverOverIncreaseSize.xPos > -1f)
		{
			this.cardNumberToMove = 1;
		}
		if (HoverOverIncreaseSize.xPos > 423f)
		{
			this.cardNumberToMove = 2;
		}
		if (this.cardNumberToMove == 0)
		{
			if (LevelMechanics.cardsLeft > 1)
			{
				this.storeCard[1].GetComponent<Animation>().Play("TalentCardDown");
			}
			if (LevelMechanics.cardsLeft > 2)
			{
				this.storeCard[2].GetComponent<Animation>().Play("TalentCardDown");
				return;
			}
		}
		else if (this.cardNumberToMove == 1)
		{
			this.storeCard[0].GetComponent<Animation>().Play("TalentCardDown");
			if (LevelMechanics.cardsLeft > 2)
			{
				this.storeCard[2].GetComponent<Animation>().Play("TalentCardDown");
				return;
			}
		}
		else if (this.cardNumberToMove == 2)
		{
			this.storeCard[0].GetComponent<Animation>().Play("TalentCardDown");
			this.storeCard[1].GetComponent<Animation>().Play("TalentCardDown");
		}
	}

	// Token: 0x06000119 RID: 281 RVA: 0x00015E19 File Offset: 0x00014019
	public void MoveCard(string name)
	{
		base.StartCoroutine(this.MoveCardToUnlockedTalents(this.storeCard[this.cardNumberToMove], name));
	}

	// Token: 0x0600011A RID: 282 RVA: 0x00015E36 File Offset: 0x00014036
	private IEnumerator MoveCardToUnlockedTalents(GameObject objectToMove, string name)
	{
		Vector3 startScale = objectToMove.transform.localScale;
		Vector3 maxScale = startScale * 1.15f;
		Vector3 startPos = objectToMove.transform.position;
		Vector3 liftedPos = startPos + Vector3.up * 0.5f;
		float prepDuration = 0.45f;
		float prepElapsed = 0f;
		while (prepElapsed < prepDuration)
		{
			prepElapsed += Time.deltaTime;
			float t = prepElapsed / prepDuration;
			objectToMove.transform.localScale = Vector3.Lerp(startScale, maxScale, t);
			objectToMove.transform.position = Vector3.Lerp(startPos, liftedPos, t);
			yield return null;
		}
		yield return new WaitForSeconds(0.2f);
		this.audioManager.Play("CardWoosh");
		float moveDuration = 0.5f;
		float moveElapsed = 0f;
		Vector3 curveStart = liftedPos;
		Vector3 curveEnd = this.moveCardHere.position;
		Vector3 midPoint = (curveStart + curveEnd) / 2f + Vector3.up * 1f;
		float startRotZ = objectToMove.transform.eulerAngles.z;
		float endRotZ = startRotZ + 360f;
		Vector3 endScale = Vector3.one * 0.2f;
		while (moveElapsed < moveDuration)
		{
			moveElapsed += Time.deltaTime;
			float num = moveElapsed / moveDuration;
			Vector3 position = Mathf.Pow(1f - num, 2f) * curveStart + 2f * (1f - num) * num * midPoint + Mathf.Pow(num, 2f) * curveEnd;
			objectToMove.transform.position = position;
			objectToMove.transform.localScale = Vector3.Lerp(maxScale, endScale, num);
			float z = Mathf.Lerp(startRotZ, endRotZ, num);
			objectToMove.transform.rotation = Quaternion.Euler(0f, 0f, z);
			yield return null;
		}
		objectToMove.transform.position = this.moveCardHere.position;
		objectToMove.transform.localScale = endScale;
		objectToMove.transform.rotation = Quaternion.Euler(0f, 0f, endRotZ);
		objectToMove.SetActive(false);
		LevelMechanics.talentLevel++;
		this.talentLevelText.gameObject.GetComponent<Animation>().Play();
		this.audioManager.Play("CardPop");
		LevelMechanics.cardsLeft--;
		this.achScript.CheckAch();
		if (name == "potionDrinker")
		{
			this.potionDrinker_unlocked.transform.SetSiblingIndex(20);
			this.moveCardHere.SetSiblingIndex(20);
			this.potionDrinker_unlocked.SetActive(true);
			LevelMechanics.potionDrinker_chosen = true;
		}
		if (name == "potionChugger")
		{
			this.potionChugger_unlocked.transform.SetSiblingIndex(20);
			this.moveCardHere.SetSiblingIndex(20);
			this.potionChugger_unlocked.SetActive(true);
			LevelMechanics.potionChugger_chosen = true;
		}
		if (name == "chests")
		{
			this.chests_unlocked.transform.SetSiblingIndex(20);
			this.moveCardHere.SetSiblingIndex(20);
			this.chests_unlocked.SetActive(true);
			LevelMechanics.chests_chosen = true;
		}
		if (name == "goldenChests")
		{
			this.goldenChests_unlocked.transform.SetSiblingIndex(20);
			this.moveCardHere.SetSiblingIndex(20);
			this.goldenChests_unlocked.SetActive(true);
			LevelMechanics.goldenChests_chosen = true;
		}
		if (name == "skilledMiners")
		{
			this.skilledMiners_unlocked.transform.SetSiblingIndex(20);
			this.moveCardHere.SetSiblingIndex(20);
			this.skilledMiners_unlocked.SetActive(true);
			LevelMechanics.skilledMiners_chosen = true;
		}
		if (name == "efficientBlacksmith")
		{
			this.efficientBlacksmith_unlocked.transform.SetSiblingIndex(20);
			this.moveCardHere.SetSiblingIndex(20);
			this.efficientBlacksmith_unlocked.SetActive(true);
			LevelMechanics.efficientBlacksmith_chosen = true;
			LevelMechanics.blacksmithDecrease = LevelMechanics.blacksmithDecreaseDISPLAY;
		}
		if (name == "itsASign")
		{
			this.itsASign_unlocked.transform.SetSiblingIndex(20);
			this.moveCardHere.SetSiblingIndex(20);
			this.itsASign_unlocked.SetActive(true);
			LevelMechanics.itsASign_chosen = true;
			this.sign.SetActive(true);
			base.StartCoroutine(this.ChangeSignBuff());
		}
		if (name == "steamSale")
		{
			this.steamSale_unlocked.transform.SetSiblingIndex(20);
			this.moveCardHere.SetSiblingIndex(20);
			this.steamSale_unlocked.SetActive(true);
			LevelMechanics.steamSale_chosen = true;
			LevelMechanics.steamSaleDiscount = 0.93f;
			this.skillTreeScript.SkillTreePrices();
		}
		if (name == "bigMiningArea")
		{
			this.bigMiningArea_unlocked.transform.SetSiblingIndex(20);
			this.moveCardHere.SetSiblingIndex(20);
			this.bigMiningArea_unlocked.SetActive(true);
			LevelMechanics.bigMiningArea_chosen = true;
			base.StartCoroutine(this.ChanceToIncreaseMiningErea());
		}
		if (name == "itsHammerTime")
		{
			this.itsHammerTime_unlocked.transform.SetSiblingIndex(20);
			this.moveCardHere.SetSiblingIndex(20);
			this.itsHammerTime_unlocked.SetActive(true);
			LevelMechanics.itsHammerTime_chosen = true;
		}
		if (name == "goldenTouch")
		{
			this.goldenTouch_unlocked.transform.SetSiblingIndex(20);
			this.moveCardHere.SetSiblingIndex(20);
			this.goldenTouch_unlocked.SetActive(true);
			LevelMechanics.goldenTouch_chosen = true;
		}
		if (name == "zeus")
		{
			this.zeus_unlocked.transform.SetSiblingIndex(20);
			this.moveCardHere.SetSiblingIndex(20);
			this.zeus_unlocked.SetActive(true);
			LevelMechanics.zeus_chosen = true;
			base.StartCoroutine(this.StartZeus());
		}
		if (name == "shapeShifter")
		{
			this.shapeShifter_unlocked.transform.SetSiblingIndex(20);
			this.moveCardHere.SetSiblingIndex(20);
			this.shapeShifter_unlocked.SetActive(true);
			LevelMechanics.shapeShifter_chosen = true;
			LevelMechanics.shapeShifterSizeIncrease = LevelMechanics.shapeShifterSizeIncreaseDISPLAY;
		}
		if (name == "xMarksTheSpor")
		{
			this.xMarksTheSpor_unlocked.transform.SetSiblingIndex(20);
			this.moveCardHere.SetSiblingIndex(20);
			this.xMarksTheSpor_unlocked.SetActive(true);
			LevelMechanics.xMarksTheSpor_chosen = true;
			this.artifactScript.SetArtifactChances();
		}
		if (name == "explorer")
		{
			this.explorer_unlocked.transform.SetSiblingIndex(20);
			this.moveCardHere.SetSiblingIndex(20);
			this.explorer_unlocked.SetActive(true);
			LevelMechanics.explorer_chosen = true;
			this.artifactScript.SetArtifactChances();
		}
		if (name == "archaeologist")
		{
			this.archaeologist_unlocked.transform.SetSiblingIndex(20);
			this.moveCardHere.SetSiblingIndex(20);
			this.archaeologist_unlocked.SetActive(true);
			LevelMechanics.archaeologist_chosen = true;
			LevelMechanics.archeologistIncrease = LevelMechanics.archeologistIncreaseDISPLAY;
			SkillTree.improvedPickaxeStrength += 0.02f * LevelMechanics.archeologistIncrease;
			SkillTree.reducePickaxeMineTime -= 0.02f * LevelMechanics.archeologistIncrease;
			float num2 = 1f + 0.03f * LevelMechanics.archeologistIncrease;
			SkillTree.fullGoldRockChance *= num2;
			SkillTree.fullCopperRockChance *= num2;
			SkillTree.fullIronRockChance *= num2;
			SkillTree.fullCobaltRockChance *= num2;
			SkillTree.fullUraniumRockChance *= num2;
			SkillTree.fullIsmiumRockChance *= num2;
			SkillTree.fullIridiumRockChance *= num2;
			SkillTree.fullPainiteRockChance *= num2;
		}
		if (name == "energiDrinker")
		{
			this.energiDrinker_unlocked.transform.SetSiblingIndex(20);
			this.moveCardHere.SetSiblingIndex(20);
			this.energiDrinker_unlocked.SetActive(true);
			LevelMechanics.energiDrinker_chosen = true;
			base.StartCoroutine(this.ChanceToDrinkEnergiDRink());
		}
		if (name == "springSeason")
		{
			this.springSeason_unlocked.transform.SetSiblingIndex(20);
			this.moveCardHere.SetSiblingIndex(20);
			this.springSeason_unlocked.SetActive(true);
			LevelMechanics.springSeason_chosen = true;
		}
		if (name == "camper")
		{
			this.camper_unlocked.transform.SetSiblingIndex(20);
			this.moveCardHere.SetSiblingIndex(20);
			this.camper_unlocked.SetActive(true);
			LevelMechanics.camper_chosen = true;
		}
		if (name == "d100")
		{
			this.d100_unlocked.transform.SetSiblingIndex(20);
			this.moveCardHere.SetSiblingIndex(20);
			this.d100_unlocked.SetActive(true);
			LevelMechanics.d100_chosen = true;
		}
		this.SetTalentTexts();
		this.locScript.TalentCardsLeftText();
		if (LevelMechanics.cardsLeft < 3)
		{
			this.card1Left.SetActive(true);
		}
		if (LevelMechanics.cardsLeft < 2)
		{
			this.card2Left.SetActive(true);
		}
		if (LevelMechanics.cardsLeft < 1)
		{
			this.cardAllChosen.SetActive(true);
		}
		this.lockedTalent1.Play("BlockedCardDown");
		this.lockedTalent2.Play("BlockedCardDown");
		this.lockedTalent3.Play("BlockedCardDown");
		yield return new WaitForSeconds(0.45f);
		this.card1Number = 0;
		this.card2Number = 0;
		this.card3Number = 0;
		this.setSpecificCards = false;
		this.AddTalentCards();
		this.blockFrame.SetActive(false);
		this.unlockParent.SetActive(true);
		this.choose1Parent.SetActive(false);
		LevelMechanics.isInChoose1 = false;
		this.blockBtn.SetActive(false);
		LevelMechanics.isBlockFrameActive = false;
		yield break;
	}

	// Token: 0x0600011B RID: 283 RVA: 0x00015E53 File Offset: 0x00014053
	private IEnumerator ChanceToIncreaseMiningErea()
	{
		for (;;)
		{
			yield return new WaitForSeconds(1f);
			if (LevelMechanics.bigMiningArea_chosen && SetRockScreen.isInMiningSession && (float)Random.Range(0, 100) < LevelMechanics.bigMiningAreaChance && !LevelMechanics.isDoubleAreaSize)
			{
				AllStats.inflateBurstTriggers++;
				LevelMechanics.isDoubleAreaSize = true;
				base.StartCoroutine(this.DoubleSizeCooldown());
			}
		}
		yield break;
	}

	// Token: 0x0600011C RID: 284 RVA: 0x00015E62 File Offset: 0x00014062
	private IEnumerator DoubleSizeCooldown()
	{
		yield return new WaitForSeconds(LevelMechanics.bigMiningAreaTime);
		LevelMechanics.isDoubleAreaSize = false;
		yield break;
	}

	// Token: 0x0600011D RID: 285 RVA: 0x00015E6A File Offset: 0x0001406A
	private IEnumerator StartZeus()
	{
		for (;;)
		{
			yield return new WaitForSeconds(1f);
			if (LevelMechanics.zeus_chosen && SetRockScreen.isInMiningSession && (float)Random.Range(0, 100) < (float)LevelMechanics.zeusChance && !LevelMechanics.isZeusActive)
			{
				AllStats.zeusTriggers++;
				int num2;
				for (int i = 0; i < LevelMechanics.zeusLightningAmount; i = num2 + 1)
				{
					LevelMechanics.isZeusActive = true;
					int num = Random.Range(0, 2);
					if (num == 0)
					{
						this.spawnProjectilesScript.SelectRandomActiveRock(2);
					}
					if (num == 1)
					{
						this.spawnProjectilesScript.SelectRandomActiveRock(6);
					}
					yield return new WaitForSeconds(Random.Range(0.05f, 0.1f));
					num2 = i;
				}
			}
			LevelMechanics.isZeusActive = false;
		}
		yield break;
	}

	// Token: 0x0600011E RID: 286 RVA: 0x00015E79 File Offset: 0x00014079
	private IEnumerator ChanceToDrinkEnergiDRink()
	{
		for (;;)
		{
			yield return new WaitForSeconds(1f);
			if (LevelMechanics.energiDrinker_chosen && SetRockScreen.isInMiningSession && (float)Random.Range(0, 100) < (float)LevelMechanics.energiDrinkChance && !LevelMechanics.isEnergiDrinkActive)
			{
				AllStats.energiDrinksDrank++;
				this.energiDrinkTopRight.SetActive(true);
				LevelMechanics.isEnergiDrinkActive = true;
				yield return new WaitForSeconds((float)LevelMechanics.energiDrinkTime);
			}
			LevelMechanics.isEnergiDrinkActive = false;
			this.energiDrinkTopRight.SetActive(false);
		}
		yield break;
	}

	// Token: 0x0600011F RID: 287 RVA: 0x00015E88 File Offset: 0x00014088
	private IEnumerator ChangeSignBuff()
	{
		for (;;)
		{
			LevelMechanics.isSignFasterMine = false;
			LevelMechanics.isSignMineMoreMaterials = false;
			LevelMechanics.isSignDoubleMaterialsChance = false;
			LevelMechanics.isSignChanceToMine3XFaster = false;
			LevelMechanics.signFasterMineAmount = 0f;
			LevelMechanics.signDoubleMaterialsChance = 0;
			LevelMechanics.signMoreMaterialsAmount = 0;
			LevelMechanics.signMine3XFasterChance = 0f;
			int num;
			do
			{
				num = Random.Range(1, 5);
			}
			while (this.signBuff == num);
			this.signBuff = num;
			if (num == 1)
			{
				LevelMechanics.isSignFasterMine = true;
				LevelMechanics.signFasterMineAmount = Random.Range(0.04f, 0.07f);
			}
			if (num == 2)
			{
				LevelMechanics.isSignMineMoreMaterials = true;
				LevelMechanics.signMoreMaterialsAmount = Random.Range(4, 9);
			}
			if (num == 3)
			{
				LevelMechanics.isSignDoubleMaterialsChance = true;
				LevelMechanics.signDoubleMaterialsChance = Random.Range(4, 8);
			}
			if (num == 4)
			{
				LevelMechanics.isSignChanceToMine3XFaster = true;
				LevelMechanics.signMine3XFasterChance = Random.Range(4f, 8f);
			}
			this.SetSignText();
			yield return new WaitForSeconds(300f);
		}
		yield break;
	}

	// Token: 0x06000120 RID: 288 RVA: 0x00015E98 File Offset: 0x00014098
	public void SetSignText()
	{
		if (LevelMechanics.isSignFasterMine)
		{
			if (LocalizationScript.isEnglish)
			{
				this.signBuffText.text = "The Mine is " + (LevelMechanics.signFasterMineAmount * 100f).ToString("F1") + "% faster";
			}
			if (LocalizationScript.isFrench)
			{
				this.signBuffText.text = "La Mine est " + (LevelMechanics.signFasterMineAmount * 100f).ToString("F1") + "% plus rapide";
			}
			if (LocalizationScript.isItalian)
			{
				this.signBuffText.text = "La Miniera è più veloce del " + (LevelMechanics.signFasterMineAmount * 100f).ToString("F1") + "%";
			}
			if (LocalizationScript.isGerman)
			{
				this.signBuffText.text = "Die Mine ist " + (LevelMechanics.signFasterMineAmount * 100f).ToString("F1") + "% schneller";
			}
			if (LocalizationScript.isSpanish)
			{
				this.signBuffText.text = "La Mina es " + (LevelMechanics.signFasterMineAmount * 100f).ToString("F1") + "% más rápida";
			}
			if (LocalizationScript.isJapanese)
			{
				this.signBuffText.text = "ザ・マインの速度が" + (LevelMechanics.signFasterMineAmount * 100f).ToString("F1") + "%アップ";
			}
			if (LocalizationScript.isKorean)
			{
				this.signBuffText.text = "광산 속도가 " + (LevelMechanics.signFasterMineAmount * 100f).ToString("F1") + "% 빨라집니다";
			}
			if (LocalizationScript.isPolish)
			{
				this.signBuffText.text = "Kopalnia działa o " + (LevelMechanics.signFasterMineAmount * 100f).ToString("F1") + "% szybciej";
			}
			if (LocalizationScript.isPortugese)
			{
				this.signBuffText.text = "A Mina está " + (LevelMechanics.signFasterMineAmount * 100f).ToString("F1") + "% mais rápida";
			}
			if (LocalizationScript.isRussian)
			{
				this.signBuffText.text = "Шахта работает на " + (LevelMechanics.signFasterMineAmount * 100f).ToString("F1") + "% быстрее";
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.signBuffText.text = "矿井速度提升 " + (LevelMechanics.signFasterMineAmount * 100f).ToString("F1") + "%";
			}
		}
		if (LevelMechanics.isSignMineMoreMaterials)
		{
			if (LocalizationScript.isEnglish)
			{
				this.signBuffText.text = string.Format("Mines {0} more bars", LevelMechanics.signMoreMaterialsAmount);
			}
			if (LocalizationScript.isFrench)
			{
				this.signBuffText.text = string.Format("Mine {0} lingots de plus", LevelMechanics.signMoreMaterialsAmount);
			}
			if (LocalizationScript.isItalian)
			{
				this.signBuffText.text = string.Format("Estrae {0} lingotti in più", LevelMechanics.signMoreMaterialsAmount);
			}
			if (LocalizationScript.isGerman)
			{
				this.signBuffText.text = string.Format("Fördert {0} zusätzliche Barren", LevelMechanics.signMoreMaterialsAmount);
			}
			if (LocalizationScript.isSpanish)
			{
				this.signBuffText.text = string.Format("Extrae {0} lingotes más", LevelMechanics.signMoreMaterialsAmount);
			}
			if (LocalizationScript.isJapanese)
			{
				this.signBuffText.text = string.Format("バーを{0}個多く採掘", LevelMechanics.signMoreMaterialsAmount);
			}
			if (LocalizationScript.isKorean)
			{
				this.signBuffText.text = string.Format("바를 {0}개 더 채굴", LevelMechanics.signMoreMaterialsAmount);
			}
			if (LocalizationScript.isPolish)
			{
				this.signBuffText.text = string.Format("Wydobywa o {0} sztabek więcej", LevelMechanics.signMoreMaterialsAmount);
			}
			if (LocalizationScript.isPortugese)
			{
				this.signBuffText.text = string.Format("Minerar mais {0} barras", LevelMechanics.signMoreMaterialsAmount);
			}
			if (LocalizationScript.isRussian)
			{
				this.signBuffText.text = string.Format("Добывает на {0} слитков больше", LevelMechanics.signMoreMaterialsAmount);
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.signBuffText.text = string.Format("多开采 {0} 个锭", LevelMechanics.signMoreMaterialsAmount);
			}
		}
		if (LevelMechanics.isSignDoubleMaterialsChance)
		{
			if (LocalizationScript.isEnglish)
			{
				this.signBuffText.text = string.Format("{0}% chance to double mined bars", LevelMechanics.signDoubleMaterialsChance);
			}
			if (LocalizationScript.isFrench)
			{
				this.signBuffText.text = string.Format("{0}% de chance de doubler les lingots extraits", LevelMechanics.signDoubleMaterialsChance);
			}
			if (LocalizationScript.isItalian)
			{
				this.signBuffText.text = string.Format("{0}% di probabilità di raddoppiare i lingotti estratti", LevelMechanics.signDoubleMaterialsChance);
			}
			if (LocalizationScript.isGerman)
			{
				this.signBuffText.text = string.Format("{0}% Chance, geförderte Barren zu verdoppeln", LevelMechanics.signDoubleMaterialsChance);
			}
			if (LocalizationScript.isSpanish)
			{
				this.signBuffText.text = string.Format("{0}% de probabilidad de duplicar los lingotes extraídos", LevelMechanics.signDoubleMaterialsChance);
			}
			if (LocalizationScript.isJapanese)
			{
				this.signBuffText.text = string.Format("採掘したバーを2倍にする確率: {0}%", LevelMechanics.signDoubleMaterialsChance);
			}
			if (LocalizationScript.isKorean)
			{
				this.signBuffText.text = string.Format("채굴된 바 2배 확률: {0}%", LevelMechanics.signDoubleMaterialsChance);
			}
			if (LocalizationScript.isPolish)
			{
				this.signBuffText.text = string.Format("{0}% szansy na podwojenie wydobytych sztabek", LevelMechanics.signDoubleMaterialsChance);
			}
			if (LocalizationScript.isPortugese)
			{
				this.signBuffText.text = string.Format("{0}% de chance de dobrar as barras mineradas", LevelMechanics.signDoubleMaterialsChance);
			}
			if (LocalizationScript.isRussian)
			{
				this.signBuffText.text = string.Format("{0}% шанс удвоить добытые слитки", LevelMechanics.signDoubleMaterialsChance);
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.signBuffText.text = string.Format("有 {0}% 概率使开采锭数量翻倍", LevelMechanics.signDoubleMaterialsChance);
			}
		}
		if (LevelMechanics.isSignChanceToMine3XFaster)
		{
			if (LocalizationScript.isEnglish)
			{
				this.signBuffText.text = LevelMechanics.signMine3XFasterChance.ToString("F2") + "% chance to mine 3X faster";
			}
			if (LocalizationScript.isFrench)
			{
				this.signBuffText.text = LevelMechanics.signMine3XFasterChance.ToString("F2") + "% de chance de miner 3X plus vite";
			}
			if (LocalizationScript.isItalian)
			{
				this.signBuffText.text = LevelMechanics.signMine3XFasterChance.ToString("F2") + "% di probabilità di minare 3X più velocemente";
			}
			if (LocalizationScript.isGerman)
			{
				this.signBuffText.text = LevelMechanics.signMine3XFasterChance.ToString("F2") + "% Chance, 3X schneller zu fördern";
			}
			if (LocalizationScript.isSpanish)
			{
				this.signBuffText.text = LevelMechanics.signMine3XFasterChance.ToString("F2") + "% de probabilidad de minar 3X más rápido";
			}
			if (LocalizationScript.isJapanese)
			{
				this.signBuffText.text = LevelMechanics.signMine3XFasterChance.ToString("F2") + "%の確率で採掘速度が3倍になる";
			}
			if (LocalizationScript.isKorean)
			{
				this.signBuffText.text = "채굴 속도 3배 확률: " + LevelMechanics.signMine3XFasterChance.ToString("F2") + "%";
			}
			if (LocalizationScript.isPolish)
			{
				this.signBuffText.text = LevelMechanics.signMine3XFasterChance.ToString("F2") + "% szansy na 3X szybsze wydobycie";
			}
			if (LocalizationScript.isPortugese)
			{
				this.signBuffText.text = LevelMechanics.signMine3XFasterChance.ToString("F2") + "% de chance de minerar 3X mais rápido";
			}
			if (LocalizationScript.isRussian)
			{
				this.signBuffText.text = LevelMechanics.signMine3XFasterChance.ToString("F2") + "% шанс добывать в 3 раза быстрее";
			}
			if (LocalizationScript.isSimplefiedChinese)
			{
				this.signBuffText.text = "有 " + LevelMechanics.signMine3XFasterChance.ToString("F2") + "% 概率采矿速度提高 3 倍";
			}
		}
	}

	// Token: 0x06000121 RID: 289 RVA: 0x00016668 File Offset: 0x00014868
	public void OpenTalenTooltip()
	{
		if (MobileAndTesting.isMobile)
		{
			this.audioManager.Play("UI_Click1");
			this.talentTooltip.transform.localScale = new Vector2(2.1f, 2.1f);
			this.talentTooltip.transform.localPosition = new Vector2(0f, 45f);
			this.talentDark.SetActive(true);
			this.talentTooltip.SetActive(true);
			this.closeTalentBtn.SetActive(true);
		}
	}

	// Token: 0x06000122 RID: 290 RVA: 0x000166F8 File Offset: 0x000148F8
	public void CloseTalentTooltip()
	{
		this.audioManager.Play("UI_Click1");
		this.talentDark.SetActive(false);
		this.talentTooltip.SetActive(false);
		this.closeTalentBtn.SetActive(false);
	}

	// Token: 0x06000123 RID: 291 RVA: 0x00016730 File Offset: 0x00014930
	public void OpenTalentLevelTooltip()
	{
		if (MobileAndTesting.isMobile)
		{
			this.audioManager.Play("UI_Click1");
			this.talentLevelTooltip.transform.localScale = new Vector2(2.1f, 2.1f);
			this.talentLevelTooltip.transform.localPosition = new Vector2(0f, 45f);
			this.talentLevelDark.SetActive(true);
			this.talentLevelTooltip.SetActive(true);
			this.closeTalentLevelTooltip.SetActive(true);
		}
	}

	// Token: 0x06000124 RID: 292 RVA: 0x000167C0 File Offset: 0x000149C0
	public void CloseTalentLevelTooltip()
	{
		this.audioManager.Play("UI_Click1");
		this.talentLevelDark.SetActive(false);
		this.talentLevelTooltip.SetActive(false);
		this.closeTalentLevelTooltip.SetActive(false);
	}

	// Token: 0x06000125 RID: 293 RVA: 0x000167F8 File Offset: 0x000149F8
	public void LoadData(GameData data)
	{
		LevelMechanics.cardsLeft = data.cardsLeft;
		this.currentXP = data.currentXP;
		LevelMechanics.level = data.level;
		LevelMechanics.totalTalentPoints = data.totalTalentPoints;
		LevelMechanics.extraTalentPointPerLevelCOUNT = data.extraTalentPointPerLevelCOUNT;
		LevelMechanics.extraTalentPointBOOK = data.extraTalentPointBOOK;
		LevelMechanics.talentLevel = data.talentLevel;
		LevelMechanics.newTalentsPrice = data.newTalentsPrice;
		LevelMechanics.xpFromRock = data.xpFromRock;
		this.xpNeedForNextLvl = data.xpNeedForNextLvl;
		LevelMechanics.isInChoose1 = data.isInChoose1;
		LevelMechanics.isBlockFrameActive = data.isBlockFrameActive;
		LevelMechanics.potionDrinker_chosen = data.potionDrinker_chosen;
		LevelMechanics.potionChugger_chosen = data.potionChugger_chosen;
		LevelMechanics.chests_chosen = data.chests_chosen;
		LevelMechanics.goldenChests_chosen = data.goldenChests_chosen;
		LevelMechanics.skilledMiners_chosen = data.skilledMiners_chosen;
		LevelMechanics.efficientBlacksmith_chosen = data.efficientBlacksmith_chosen;
		LevelMechanics.itsASign_chosen = data.itsASign_chosen;
		LevelMechanics.steamSale_chosen = data.steamSale_chosen;
		LevelMechanics.bigMiningArea_chosen = data.bigMiningArea_chosen;
		LevelMechanics.itsHammerTime_chosen = data.itsHammerTime_chosen;
		LevelMechanics.goldenTouch_chosen = data.goldenTouch_chosen;
		LevelMechanics.zeus_chosen = data.zeus_chosen;
		LevelMechanics.shapeShifter_chosen = data.shapeShifter_chosen;
		LevelMechanics.xMarksTheSpor_chosen = data.xMarksTheSpor_chosen;
		LevelMechanics.explorer_chosen = data.explorer_chosen;
		LevelMechanics.archaeologist_chosen = data.archaeologist_chosen;
		LevelMechanics.energiDrinker_chosen = data.energiDrinker_chosen;
		LevelMechanics.springSeason_chosen = data.springSeason_chosen;
		LevelMechanics.camper_chosen = data.camper_chosen;
		LevelMechanics.d100_chosen = data.d100_chosen;
		LevelMechanics.talentCard1Picked = data.talentCard1Picked;
		LevelMechanics.talentCard2Picked = data.talentCard2Picked;
		LevelMechanics.talentCard3Picked = data.talentCard3Picked;
	}

	// Token: 0x06000126 RID: 294 RVA: 0x00016988 File Offset: 0x00014B88
	public void SaveData(ref GameData data)
	{
		data.cardsLeft = LevelMechanics.cardsLeft;
		data.currentXP = this.currentXP;
		data.level = LevelMechanics.level;
		data.totalTalentPoints = LevelMechanics.totalTalentPoints;
		data.extraTalentPointPerLevelCOUNT = LevelMechanics.extraTalentPointPerLevelCOUNT;
		data.extraTalentPointBOOK = LevelMechanics.extraTalentPointBOOK;
		data.talentLevel = LevelMechanics.talentLevel;
		data.newTalentsPrice = LevelMechanics.newTalentsPrice;
		data.xpFromRock = LevelMechanics.xpFromRock;
		data.xpNeedForNextLvl = this.xpNeedForNextLvl;
		data.isInChoose1 = LevelMechanics.isInChoose1;
		data.isBlockFrameActive = LevelMechanics.isBlockFrameActive;
		data.potionDrinker_chosen = LevelMechanics.potionDrinker_chosen;
		data.potionChugger_chosen = LevelMechanics.potionChugger_chosen;
		data.chests_chosen = LevelMechanics.chests_chosen;
		data.goldenChests_chosen = LevelMechanics.goldenChests_chosen;
		data.skilledMiners_chosen = LevelMechanics.skilledMiners_chosen;
		data.efficientBlacksmith_chosen = LevelMechanics.efficientBlacksmith_chosen;
		data.itsASign_chosen = LevelMechanics.itsASign_chosen;
		data.steamSale_chosen = LevelMechanics.steamSale_chosen;
		data.bigMiningArea_chosen = LevelMechanics.bigMiningArea_chosen;
		data.itsHammerTime_chosen = LevelMechanics.itsHammerTime_chosen;
		data.goldenTouch_chosen = LevelMechanics.goldenTouch_chosen;
		data.zeus_chosen = LevelMechanics.zeus_chosen;
		data.shapeShifter_chosen = LevelMechanics.shapeShifter_chosen;
		data.xMarksTheSpor_chosen = LevelMechanics.xMarksTheSpor_chosen;
		data.explorer_chosen = LevelMechanics.explorer_chosen;
		data.archaeologist_chosen = LevelMechanics.archaeologist_chosen;
		data.energiDrinker_chosen = LevelMechanics.energiDrinker_chosen;
		data.springSeason_chosen = LevelMechanics.springSeason_chosen;
		data.camper_chosen = LevelMechanics.camper_chosen;
		data.d100_chosen = LevelMechanics.d100_chosen;
		data.talentCard1Picked = LevelMechanics.talentCard1Picked;
		data.talentCard2Picked = LevelMechanics.talentCard2Picked;
		data.talentCard3Picked = LevelMechanics.talentCard3Picked;
	}

	// Token: 0x06000127 RID: 295 RVA: 0x00016B3C File Offset: 0x00014D3C
	public void ResetLevel()
	{
		this.sign.SetActive(false);
		this.SetOriginalStats();
		this.skillTreeScript.SkillTreePrices();
		this.potionDrinker_card.SetActive(false);
		this.potionChugger_Card.SetActive(false);
		this.chests_card.SetActive(false);
		this.goldenChests_card.SetActive(false);
		this.skilledMiners_card.SetActive(false);
		this.efficientBlacksmith_card.SetActive(false);
		this.itsASign_card.SetActive(false);
		this.steamSale_card.SetActive(false);
		this.bigMiningArea_card.SetActive(false);
		this.itsHammerTime_card.SetActive(false);
		this.goldenTouch_card.SetActive(false);
		this.zeus_card.SetActive(false);
		this.shapeShifter_card.SetActive(false);
		this.xMarksTheSpor_card.SetActive(false);
		this.explorer_card.SetActive(false);
		this.archaeologist_Card.SetActive(false);
		this.energiDrinker_card.SetActive(false);
		this.springSeason_card.SetActive(false);
		this.camper_card.SetActive(false);
		this.d100_card.SetActive(false);
		this.potionDrinker_unlocked.SetActive(false);
		this.potionChugger_unlocked.SetActive(false);
		this.chests_unlocked.SetActive(false);
		this.goldenChests_unlocked.SetActive(false);
		this.skilledMiners_unlocked.SetActive(false);
		this.efficientBlacksmith_unlocked.SetActive(false);
		this.itsASign_unlocked.SetActive(false);
		this.steamSale_unlocked.SetActive(false);
		this.bigMiningArea_unlocked.SetActive(false);
		this.itsHammerTime_unlocked.SetActive(false);
		this.goldenTouch_unlocked.SetActive(false);
		this.zeus_unlocked.SetActive(false);
		this.shapeShifter_unlocked.SetActive(false);
		this.xMarksTheSpor_unlocked.SetActive(false);
		this.explorer_unlocked.SetActive(false);
		this.archaeologist_unlocked.SetActive(false);
		this.energiDrinker_unlocked.SetActive(false);
		this.springSeason_unlocked.SetActive(false);
		this.camper_unlocked.SetActive(false);
		this.d100_unlocked.SetActive(false);
		this.currentXP = 0f;
		LevelMechanics.level = 1;
		LevelMechanics.totalTalentPoints = 0;
		LevelMechanics.extraTalentPointPerLevelCOUNT = 0;
		LevelMechanics.extraTalentPointBOOK = 0;
		LevelMechanics.talentLevel = 1;
		LevelMechanics.newTalentsPrice = 1;
		LevelMechanics.xpFromRock = 0.03f;
		this.xpNeedForNextLvl = 1f;
		LevelMechanics.isInChoose1 = false;
		LevelMechanics.isBlockFrameActive = false;
		LevelMechanics.potionDrinker_chosen = false;
		LevelMechanics.potionChugger_chosen = false;
		LevelMechanics.chests_chosen = false;
		LevelMechanics.goldenChests_chosen = false;
		LevelMechanics.skilledMiners_chosen = false;
		LevelMechanics.efficientBlacksmith_chosen = false;
		LevelMechanics.itsASign_chosen = false;
		LevelMechanics.steamSale_chosen = false;
		LevelMechanics.bigMiningArea_chosen = false;
		LevelMechanics.itsHammerTime_chosen = false;
		LevelMechanics.goldenTouch_chosen = false;
		LevelMechanics.zeus_chosen = false;
		LevelMechanics.shapeShifter_chosen = false;
		LevelMechanics.xMarksTheSpor_chosen = false;
		LevelMechanics.explorer_chosen = false;
		LevelMechanics.archaeologist_chosen = false;
		LevelMechanics.energiDrinker_chosen = false;
		LevelMechanics.springSeason_chosen = false;
		LevelMechanics.camper_chosen = false;
		LevelMechanics.d100_chosen = false;
		base.StopAllCoroutines();
		this.SetTalentTexts();
		this.card1Number = 0;
		this.card2Number = 0;
		this.card3Number = 0;
		LevelMechanics.talentCard1Picked = 0;
		LevelMechanics.talentCard2Picked = 0;
		LevelMechanics.talentCard3Picked = 0;
		this.setSpecificCards = false;
		LevelMechanics.cardsLeft = 20;
		this.AddTalentCards();
		this.potionDrinker_card.transform.localScale = new Vector2(1f, 1f);
		this.potionChugger_Card.transform.localScale = new Vector2(1f, 1f);
		this.chests_card.transform.localScale = new Vector2(1f, 1f);
		this.goldenChests_card.transform.localScale = new Vector2(1f, 1f);
		this.skilledMiners_card.transform.localScale = new Vector2(1f, 1f);
		this.efficientBlacksmith_card.transform.localScale = new Vector2(1f, 1f);
		this.itsASign_card.transform.localScale = new Vector2(1f, 1f);
		this.steamSale_card.transform.localScale = new Vector2(1f, 1f);
		this.bigMiningArea_card.transform.localScale = new Vector2(1f, 1f);
		this.itsHammerTime_card.transform.localScale = new Vector2(1f, 1f);
		this.goldenTouch_card.transform.localScale = new Vector2(1f, 1f);
		this.zeus_card.transform.localScale = new Vector2(1f, 1f);
		this.shapeShifter_card.transform.localScale = new Vector2(1f, 1f);
		this.xMarksTheSpor_card.transform.localScale = new Vector2(1f, 1f);
		this.explorer_card.transform.localScale = new Vector2(1f, 1f);
		this.archaeologist_Card.transform.localScale = new Vector2(1f, 1f);
		this.energiDrinker_card.transform.localScale = new Vector2(1f, 1f);
		this.springSeason_card.transform.localScale = new Vector2(1f, 1f);
		this.camper_card.transform.localScale = new Vector2(1f, 1f);
		this.d100_card.transform.localScale = new Vector2(1f, 1f);
		this.card1Left.SetActive(false);
		this.card2Left.SetActive(false);
		this.cardAllChosen.SetActive(false);
		this.allTalentCardsChosenBlockBtn.SetActive(true);
		this.lockedTalent1.gameObject.SetActive(true);
		this.lockedTalent1.transform.localScale = new Vector3(1f, 1f, 1f);
		this.lockedTalent1.transform.localPosition = new Vector3(0f, 0f, 0f);
		this.lockedTalent2.gameObject.SetActive(true);
		this.lockedTalent2.transform.localScale = new Vector3(1f, 1f, 1f);
		this.lockedTalent2.transform.localPosition = new Vector3(0f, 0f, 0f);
		this.lockedTalent3.gameObject.SetActive(true);
		this.lockedTalent3.transform.localScale = new Vector3(1f, 1f, 1f);
		this.lockedTalent3.transform.localPosition = new Vector3(0f, 0f, 0f);
		this.choose1Parent.SetActive(false);
		this.unlockParent.SetActive(true);
		if (!LevelMechanics.isInChoose1)
		{
			this.lockedTalent1.Play("BlockedCardDown");
			this.lockedTalent2.Play("BlockedCardDown");
			this.lockedTalent3.Play("BlockedCardDown");
		}
	}

	// Token: 0x0400048E RID: 1166
	public SkillTree skillTreeScript;

	// Token: 0x0400048F RID: 1167
	public SpawnProjectiles spawnProjectilesScript;

	// Token: 0x04000490 RID: 1168
	public Artifacts artifactScript;

	// Token: 0x04000491 RID: 1169
	public AudioManager audioManager;

	// Token: 0x04000492 RID: 1170
	public Tutorial tutorialScript;

	// Token: 0x04000493 RID: 1171
	public LocalizationScript locScript;

	// Token: 0x04000494 RID: 1172
	public Achievements achScript;

	// Token: 0x04000495 RID: 1173
	public Slider xpSlider;

	// Token: 0x04000496 RID: 1174
	public static int level;

	// Token: 0x04000497 RID: 1175
	public static int totalTalentPoints;

	// Token: 0x04000498 RID: 1176
	public static int extraTalentPointPerLevelCOUNT;

	// Token: 0x04000499 RID: 1177
	public static int extraTalentPointBOOK;

	// Token: 0x0400049A RID: 1178
	public static int talentLevel;

	// Token: 0x0400049B RID: 1179
	public static float xpFromRock;

	// Token: 0x0400049C RID: 1180
	public float xpNeedForNextLvl;

	// Token: 0x0400049D RID: 1181
	public float currentXP;

	// Token: 0x0400049E RID: 1182
	public static bool isInChoose1;

	// Token: 0x0400049F RID: 1183
	public static bool isBlockFrameActive;

	// Token: 0x040004A0 RID: 1184
	public static int newTalentsPrice;

	// Token: 0x040004A1 RID: 1185
	public static bool potionDrinker_chosen;

	// Token: 0x040004A2 RID: 1186
	public static bool potionChugger_chosen;

	// Token: 0x040004A3 RID: 1187
	public static bool chests_chosen;

	// Token: 0x040004A4 RID: 1188
	public static bool goldenChests_chosen;

	// Token: 0x040004A5 RID: 1189
	public static bool skilledMiners_chosen;

	// Token: 0x040004A6 RID: 1190
	public static bool efficientBlacksmith_chosen;

	// Token: 0x040004A7 RID: 1191
	public static bool itsASign_chosen;

	// Token: 0x040004A8 RID: 1192
	public static bool steamSale_chosen;

	// Token: 0x040004A9 RID: 1193
	public static bool bigMiningArea_chosen;

	// Token: 0x040004AA RID: 1194
	public static bool itsHammerTime_chosen;

	// Token: 0x040004AB RID: 1195
	public static bool goldenTouch_chosen;

	// Token: 0x040004AC RID: 1196
	public static bool zeus_chosen;

	// Token: 0x040004AD RID: 1197
	public static bool shapeShifter_chosen;

	// Token: 0x040004AE RID: 1198
	public static bool xMarksTheSpor_chosen;

	// Token: 0x040004AF RID: 1199
	public static bool explorer_chosen;

	// Token: 0x040004B0 RID: 1200
	public static bool archaeologist_chosen;

	// Token: 0x040004B1 RID: 1201
	public static bool energiDrinker_chosen;

	// Token: 0x040004B2 RID: 1202
	public static bool springSeason_chosen;

	// Token: 0x040004B3 RID: 1203
	public static bool camper_chosen;

	// Token: 0x040004B4 RID: 1204
	public static bool d100_chosen;

	// Token: 0x040004B5 RID: 1205
	public static int talentLevelHpIncrease;

	// Token: 0x040004B6 RID: 1206
	public TextMeshProUGUI levelText;

	// Token: 0x040004B7 RID: 1207
	public Animation lockedTalent1;

	// Token: 0x040004B8 RID: 1208
	public Animation lockedTalent2;

	// Token: 0x040004B9 RID: 1209
	public Animation lockedTalent3;

	// Token: 0x040004BA RID: 1210
	public TextMeshProUGUI needToReachText;

	// Token: 0x040004BB RID: 1211
	public TextMeshProUGUI talentScreen_talentPoints;

	// Token: 0x040004BC RID: 1212
	public static float steamSaleDiscount;

	// Token: 0x040004BD RID: 1213
	public static int rocksMinedByHammer;

	// Token: 0x040004BE RID: 1214
	public static float archeologistIncrease;

	// Token: 0x040004BF RID: 1215
	public static float archeologistIncreaseDISPLAY;

	// Token: 0x040004C0 RID: 1216
	public static float blacksmithDecrease;

	// Token: 0x040004C1 RID: 1217
	public static float blacksmithDecreaseDISPLAY;

	// Token: 0x040004C2 RID: 1218
	public static int totalChestMaterials;

	// Token: 0x040004C3 RID: 1219
	public static int totalGoldenChestMaterials;

	// Token: 0x040004C4 RID: 1220
	public static float shapeShifterSizeIncrease;

	// Token: 0x040004C5 RID: 1221
	public static float shapeShifterSizeIncreaseDISPLAY;

	// Token: 0x040004C6 RID: 1222
	public static float rockSpawnChance;

	// Token: 0x040004C7 RID: 1223
	public static float skilledMinersFastChance;

	// Token: 0x040004C8 RID: 1224
	public static float skilledMinersDoubleChance;

	// Token: 0x040004C9 RID: 1225
	public static float bigMiningAreaChance;

	// Token: 0x040004CA RID: 1226
	public static float bigMiningAreaTime;

	// Token: 0x040004CB RID: 1227
	public static float hammerChance;

	// Token: 0x040004CC RID: 1228
	public static int midasTouchChance;

	// Token: 0x040004CD RID: 1229
	public static int midasTouchSpawnChance;

	// Token: 0x040004CE RID: 1230
	public static int zeusChance;

	// Token: 0x040004CF RID: 1231
	public static int zeusLightningAmount;

	// Token: 0x040004D0 RID: 1232
	public static int energiDrinkChance;

	// Token: 0x040004D1 RID: 1233
	public static int energiDrinkTime;

	// Token: 0x040004D2 RID: 1234
	public static float flowerIncrease;

	// Token: 0x040004D3 RID: 1235
	public GameObject sign;

	// Token: 0x040004D4 RID: 1236
	public GameObject blockFrame;

	// Token: 0x040004D5 RID: 1237
	public GameObject unlockParent;

	// Token: 0x040004D6 RID: 1238
	public GameObject choose1Parent;

	// Token: 0x040004D7 RID: 1239
	public GameObject blockBtn;

	// Token: 0x040004D8 RID: 1240
	public static float inflationBurstIncrease;

	// Token: 0x040004D9 RID: 1241
	public static int cardsLeft;

	// Token: 0x040004DA RID: 1242
	public GameObject card1Left;

	// Token: 0x040004DB RID: 1243
	public GameObject card2Left;

	// Token: 0x040004DC RID: 1244
	public GameObject cardAllChosen;

	// Token: 0x040004DD RID: 1245
	public GameObject allTalentCardsChosenBlockBtn;

	// Token: 0x040004DE RID: 1246
	public Animation potionTooltipAnim;

	// Token: 0x040004DF RID: 1247
	public static int talentCard1Picked;

	// Token: 0x040004E0 RID: 1248
	public static int talentCard2Picked;

	// Token: 0x040004E1 RID: 1249
	public static int talentCard3Picked;

	// Token: 0x040004E2 RID: 1250
	public int startCardsAdded;

	// Token: 0x040004E3 RID: 1251
	public GameObject goldenCursorCard;

	// Token: 0x040004E4 RID: 1252
	public GameObject goldenCursorLeft;

	// Token: 0x040004E5 RID: 1253
	public GameObject goldenCircleCard;

	// Token: 0x040004E6 RID: 1254
	public GameObject goldenCircleLeft;

	// Token: 0x040004E7 RID: 1255
	public bool setSpecificCards;

	// Token: 0x040004E8 RID: 1256
	public TextMeshProUGUI revealTalentsPriceText;

	// Token: 0x040004E9 RID: 1257
	public TextMeshProUGUI rockDurabilityTooltipText;

	// Token: 0x040004EA RID: 1258
	public static bool didLevelUp;

	// Token: 0x040004EB RID: 1259
	public static int didLevelUpTotalTalentPoints;

	// Token: 0x040004EC RID: 1260
	public static float xpThisRound;

	// Token: 0x040004ED RID: 1261
	public Animation levelUpAnim;

	// Token: 0x040004EE RID: 1262
	public GameObject potionDrinker_card;

	// Token: 0x040004EF RID: 1263
	public GameObject potionChugger_Card;

	// Token: 0x040004F0 RID: 1264
	public GameObject chests_card;

	// Token: 0x040004F1 RID: 1265
	public GameObject goldenChests_card;

	// Token: 0x040004F2 RID: 1266
	public GameObject skilledMiners_card;

	// Token: 0x040004F3 RID: 1267
	public GameObject efficientBlacksmith_card;

	// Token: 0x040004F4 RID: 1268
	public GameObject itsASign_card;

	// Token: 0x040004F5 RID: 1269
	public GameObject steamSale_card;

	// Token: 0x040004F6 RID: 1270
	public GameObject bigMiningArea_card;

	// Token: 0x040004F7 RID: 1271
	public GameObject itsHammerTime_card;

	// Token: 0x040004F8 RID: 1272
	public GameObject goldenTouch_card;

	// Token: 0x040004F9 RID: 1273
	public GameObject zeus_card;

	// Token: 0x040004FA RID: 1274
	public GameObject shapeShifter_card;

	// Token: 0x040004FB RID: 1275
	public GameObject xMarksTheSpor_card;

	// Token: 0x040004FC RID: 1276
	public GameObject explorer_card;

	// Token: 0x040004FD RID: 1277
	public GameObject archaeologist_Card;

	// Token: 0x040004FE RID: 1278
	public GameObject energiDrinker_card;

	// Token: 0x040004FF RID: 1279
	public GameObject springSeason_card;

	// Token: 0x04000500 RID: 1280
	public GameObject camper_card;

	// Token: 0x04000501 RID: 1281
	public GameObject d100_card;

	// Token: 0x04000502 RID: 1282
	public Transform moveCardHere;

	// Token: 0x04000503 RID: 1283
	public GameObject[] storeCard;

	// Token: 0x04000504 RID: 1284
	public int card1Number;

	// Token: 0x04000505 RID: 1285
	public int card2Number;

	// Token: 0x04000506 RID: 1286
	public int card3Number;

	// Token: 0x04000507 RID: 1287
	public int cardsChosen;

	// Token: 0x04000508 RID: 1288
	public int cardNumberToMove;

	// Token: 0x04000509 RID: 1289
	public GridLayoutGroup talentGrid;

	// Token: 0x0400050A RID: 1290
	public TextMeshProUGUI talentLevelText;

	// Token: 0x0400050B RID: 1291
	public GameObject potionDrinker_unlocked;

	// Token: 0x0400050C RID: 1292
	public GameObject potionChugger_unlocked;

	// Token: 0x0400050D RID: 1293
	public GameObject chests_unlocked;

	// Token: 0x0400050E RID: 1294
	public GameObject goldenChests_unlocked;

	// Token: 0x0400050F RID: 1295
	public GameObject skilledMiners_unlocked;

	// Token: 0x04000510 RID: 1296
	public GameObject efficientBlacksmith_unlocked;

	// Token: 0x04000511 RID: 1297
	public GameObject itsASign_unlocked;

	// Token: 0x04000512 RID: 1298
	public GameObject steamSale_unlocked;

	// Token: 0x04000513 RID: 1299
	public GameObject bigMiningArea_unlocked;

	// Token: 0x04000514 RID: 1300
	public GameObject itsHammerTime_unlocked;

	// Token: 0x04000515 RID: 1301
	public GameObject goldenTouch_unlocked;

	// Token: 0x04000516 RID: 1302
	public GameObject zeus_unlocked;

	// Token: 0x04000517 RID: 1303
	public GameObject shapeShifter_unlocked;

	// Token: 0x04000518 RID: 1304
	public GameObject xMarksTheSpor_unlocked;

	// Token: 0x04000519 RID: 1305
	public GameObject explorer_unlocked;

	// Token: 0x0400051A RID: 1306
	public GameObject archaeologist_unlocked;

	// Token: 0x0400051B RID: 1307
	public GameObject energiDrinker_unlocked;

	// Token: 0x0400051C RID: 1308
	public GameObject springSeason_unlocked;

	// Token: 0x0400051D RID: 1309
	public GameObject camper_unlocked;

	// Token: 0x0400051E RID: 1310
	public GameObject d100_unlocked;

	// Token: 0x0400051F RID: 1311
	public static bool isDoubleAreaSize;

	// Token: 0x04000520 RID: 1312
	public static bool isZeusActive;

	// Token: 0x04000521 RID: 1313
	public static bool isEnergiDrinkActive;

	// Token: 0x04000522 RID: 1314
	public GameObject energiDrinkTopRight;

	// Token: 0x04000523 RID: 1315
	public TextMeshProUGUI signBuffText;

	// Token: 0x04000524 RID: 1316
	public static bool isSignFasterMine;

	// Token: 0x04000525 RID: 1317
	public static bool isSignMineMoreMaterials;

	// Token: 0x04000526 RID: 1318
	public static bool isSignDoubleMaterialsChance;

	// Token: 0x04000527 RID: 1319
	public static bool isSignChanceToMine3XFaster;

	// Token: 0x04000528 RID: 1320
	public static float signFasterMineAmount;

	// Token: 0x04000529 RID: 1321
	public static float signMine3XFasterChance;

	// Token: 0x0400052A RID: 1322
	public static int signMoreMaterialsAmount;

	// Token: 0x0400052B RID: 1323
	public static int signDoubleMaterialsChance;

	// Token: 0x0400052C RID: 1324
	private int signBuff;

	// Token: 0x0400052D RID: 1325
	public GameObject talentTooltip;

	// Token: 0x0400052E RID: 1326
	public GameObject closeTalentBtn;

	// Token: 0x0400052F RID: 1327
	public GameObject talentDark;

	// Token: 0x04000530 RID: 1328
	public Animation talentTooltipAnim;

	// Token: 0x04000531 RID: 1329
	public GameObject talentLevelTooltip;

	// Token: 0x04000532 RID: 1330
	public GameObject closeTalentLevelTooltip;

	// Token: 0x04000533 RID: 1331
	public GameObject talentLevelDark;

	// Token: 0x04000534 RID: 1332
	public Animation talentLevelAnim;
}
