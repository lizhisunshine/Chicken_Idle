using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000037 RID: 55
public class SkillTree : MonoBehaviour, IDataPersistence
{
	// Token: 0x060001C1 RID: 449 RVA: 0x00041320 File Offset: 0x0003F520
	private void Start()
	{
		this.particleSkillTree.SetActive(false);
		for (int i = 0; i < this.lines.Length; i++)
		{
			this.lines[i].SetActive(false);
			this.finaLine.SetActive(false);
		}
		base.StartCoroutine(this.Wait());
	}

	// Token: 0x060001C2 RID: 450 RVA: 0x00041373 File Offset: 0x0003F573
	private IEnumerator Wait()
	{
		yield return new WaitForSeconds(0.1f);
		if (MobileAndTesting.isMobile)
		{
			this.skillTreeTooltipAnim.enabled = false;
		}
		if (SkillTree.totalSkillTreeUpgradesPurchased >= 399)
		{
			if (SkillTree.hasPressedEndlessOK)
			{
				this.endlessUpgradesParent.SetActive(true);
			}
			else
			{
				this.endlessUpgradesPopUp.SetActive(true);
				SkillTree.isInEndlessPopUp = true;
				this.endlessUpgradesParent.SetActive(true);
			}
		}
		if (SkillTree.spawnCopper_purchased)
		{
			this.fallingCopper_skillTree.SetActive(true);
			this.fallingCopper_MainMenu.SetActive(true);
		}
		if (SkillTree.spawnIron_purchased)
		{
			this.fallingIron_skillTree.SetActive(true);
			this.fallingIron_MainMenu.SetActive(true);
		}
		if (SkillTree.cobaltSpawn_purchased)
		{
			this.fallingCobalt_skillTree.SetActive(true);
			this.fallingCobalt_MainMenu.SetActive(true);
		}
		if (SkillTree.uraniumSpawn_purchased)
		{
			this.fallingUranium_skillTree.SetActive(true);
			this.fallingUranium_MainMenu.SetActive(true);
		}
		if (SkillTree.ismiumSpawn_purchased)
		{
			this.fallingIsmium_skillTree.SetActive(true);
			this.fallingIsmium_MainMenu.SetActive(true);
		}
		if (SkillTree.iridiumSpawn_purchased)
		{
			this.fallingIridium_skillTree.SetActive(true);
			this.fallingIridium_MainMenu.SetActive(true);
		}
		if (SkillTree.painiteSpawn_purchased)
		{
			this.fallingPainite_skillTree.SetActive(true);
			this.fallingPainite_MainMenu.SetActive(true);
		}
		yield return new WaitForSeconds(0.1f);
		this.SkillTreePrices();
		this.CheckUpgrades();
		SkillTree.circleShootChance = 30f;
		SkillTree.chanceToAdd1SecEverySec = 9f;
		SkillTree.chanceToAdd1SecEveryRockMined = 0.075f;
		SkillTree.triggerAnotherLighntingChance = 12f;
		SkillTree.lightningSplashChance = 17f;
		SkillTree.lightningSparkDamage = 15f;
		SkillTree.lightningSpawnRockChance = 24f;
		SkillTree.lightningSpawnExplosionChance = 20f;
		SkillTree.lightningAddTimeChance = 0.8f;
		SkillTree.spawn2DynamiteChance = 10f;
		SkillTree.chanceToSpawnRockFromExplosion = 21f;
		SkillTree.explosionAdd1SecondChance = 0.8f;
		SkillTree.explosionChanceToSpawnLightning = 10f;
		SkillTree.plazmaballExplosionChance = 17f;
		SkillTree.plazmaBallSpawnSmallBallChance = 13f;
		SkillTree.plazmaBallChanceToSpawnPickaxe = 4f;
		SkillTree.allProjectileDoubleDamageIncrease = 5f;
		SkillTree.allProjcetileTriggerChance = 15f;
		SkillTree.allRockSpawnChanceIncrease = 5f;
		bool pickaxe14_crafted = TheAnvil.pickaxe14_crafted;
		yield break;
	}

	// Token: 0x060001C3 RID: 451 RVA: 0x00041384 File Offset: 0x0003F584
	public void SkillTreePrices()
	{
		SkillTree.moreXP_1_price = (double)(12f * LevelMechanics.steamSaleDiscount);
		SkillTree.moreXP_2_price = (double)(125f * LevelMechanics.steamSaleDiscount);
		SkillTree.moreXP_3_price = (double)(21000f * LevelMechanics.steamSaleDiscount);
		SkillTree.moreXP_4_price = (double)(600f * LevelMechanics.steamSaleDiscount);
		SkillTree.moreXP_5_price = (double)(2100f * LevelMechanics.steamSaleDiscount);
		SkillTree.moreXP_6_price = (double)(4500f * LevelMechanics.steamSaleDiscount);
		SkillTree.moreXP_7_price = (double)(100000f * LevelMechanics.steamSaleDiscount);
		SkillTree.moreXP_8_price = (double)(1000000f * LevelMechanics.steamSaleDiscount);
		SkillTree.talentPointsPerXlevel_1_price = (double)(100f * LevelMechanics.steamSaleDiscount);
		SkillTree.talentPointsPerXlevel_2_price = (double)(1200f * LevelMechanics.steamSaleDiscount);
		SkillTree.talentPointsPerXlevel_3_price = (double)(1500000f * LevelMechanics.steamSaleDiscount);
		SkillTree.lightningBeamChanceS_1_price = (double)(500f * LevelMechanics.steamSaleDiscount);
		SkillTree.lightningBeamChanceS_2_price = (double)(1600f * LevelMechanics.steamSaleDiscount);
		SkillTree.lightningBeamChancePH_1_price = (double)(200f * LevelMechanics.steamSaleDiscount);
		SkillTree.lightningBeamChancePH_2_price = (double)(9000f * LevelMechanics.steamSaleDiscount);
		SkillTree.lightningBeamSpawnAnotherOneChance_price = (double)(95000f * LevelMechanics.steamSaleDiscount);
		SkillTree.lightningBeamDamage_price = (double)(1000f * LevelMechanics.steamSaleDiscount);
		SkillTree.lightningBeamSize_price = (double)(1200f * LevelMechanics.steamSaleDiscount);
		SkillTree.lightningSplashes_price = (double)(20000f * LevelMechanics.steamSaleDiscount);
		SkillTree.lightningBeamSpawnRock_price = (double)(100000f * LevelMechanics.steamSaleDiscount);
		SkillTree.lightningBeamExplosion_price = (double)(250000f * LevelMechanics.steamSaleDiscount);
		SkillTree.lightningBeamAddTime_price = (double)(500000f * LevelMechanics.steamSaleDiscount);
		SkillTree.dynamiteChance_1_price = (double)(1000f * LevelMechanics.steamSaleDiscount);
		SkillTree.dynamiteChance_2_price = (double)(3500f * LevelMechanics.steamSaleDiscount);
		SkillTree.dynamiteSpawn2SmallChance_price = (double)(2500f * LevelMechanics.steamSaleDiscount);
		SkillTree.dynamiteExplosionSize_price = (double)(32000f * LevelMechanics.steamSaleDiscount);
		SkillTree.dynamiteDamage_price = (double)(10000f * LevelMechanics.steamSaleDiscount);
		SkillTree.dynamiteExplosionSpawnRock_price = (double)(6000f * LevelMechanics.steamSaleDiscount);
		SkillTree.dynamiteExplosionAddTimeChance_price = (double)(50000f * LevelMechanics.steamSaleDiscount);
		SkillTree.dynamiteExplosionSpawnLightning_price = (double)(600000f * LevelMechanics.steamSaleDiscount);
		SkillTree.plazmaBallSpawn_1_price = (double)(10000f * LevelMechanics.steamSaleDiscount);
		SkillTree.plazmaBallSpawn_2_price = (double)(22000f * LevelMechanics.steamSaleDiscount);
		SkillTree.plazmaBallTime_price = (double)(430000f * LevelMechanics.steamSaleDiscount);
		SkillTree.plazmaBallSize_price = (double)(30000f * LevelMechanics.steamSaleDiscount);
		SkillTree.plazmaBallExplosionChance_price = (double)(610000f * LevelMechanics.steamSaleDiscount);
		SkillTree.plazmaBallSpawnSmallChance_price = (double)(100000f * LevelMechanics.steamSaleDiscount);
		SkillTree.plazmaBallDamage_price = (double)(4600000f * LevelMechanics.steamSaleDiscount);
		SkillTree.plazmaBallSpawnPickaxeChance_price = (double)(30000f * LevelMechanics.steamSaleDiscount);
		SkillTree.spawnMoreRocks_1_price = (double)(3f * LevelMechanics.steamSaleDiscount);
		SkillTree.spawnMoreRocks_2_price = (double)(6f * LevelMechanics.steamSaleDiscount);
		SkillTree.spawnMoreRocks_3_price = (double)(15f * LevelMechanics.steamSaleDiscount);
		SkillTree.spawnMoreRocks_4_price = (double)(25f * LevelMechanics.steamSaleDiscount);
		SkillTree.spawnMoreRocks_5_price = (double)(350f * LevelMechanics.steamSaleDiscount);
		SkillTree.spawnMoreRocks_6_price = (double)(3800f * LevelMechanics.steamSaleDiscount);
		SkillTree.spawnMoreRocks_7_price = (double)(27000f * LevelMechanics.steamSaleDiscount);
		SkillTree.spawnMoreRocks_8_price = (double)(270000f * LevelMechanics.steamSaleDiscount);
		SkillTree.spawnMoreRocks_9_price = (double)(350000f * LevelMechanics.steamSaleDiscount);
		SkillTree.moreMeterialsFromRock_1_price = (double)(350f * LevelMechanics.steamSaleDiscount);
		SkillTree.moreMeterialsFromRock_2_price = (double)(500000f * LevelMechanics.steamSaleDiscount);
		SkillTree.moreMeterialsFromRock_3_price = (double)(400000f * LevelMechanics.steamSaleDiscount);
		SkillTree.moreMeterialsFromRock_4_price = (double)(10000f * LevelMechanics.steamSaleDiscount);
		SkillTree.moreMeterialsFromRock_5_price = (double)(700000f * LevelMechanics.steamSaleDiscount);
		SkillTree.marterialsWorthMore_1_price = (double)(100f * LevelMechanics.steamSaleDiscount);
		SkillTree.marterialsWorthMore_2_price = (double)(2000f * LevelMechanics.steamSaleDiscount);
		SkillTree.marterialsWorthMore_3_price = (double)(3000f * LevelMechanics.steamSaleDiscount);
		SkillTree.marterialsWorthMore_4_price = (double)(44000f * LevelMechanics.steamSaleDiscount);
		SkillTree.marterialsWorthMore_5_price = (double)(110000f * LevelMechanics.steamSaleDiscount);
		SkillTree.marterialsWorthMore_6_price = (double)(5500f * LevelMechanics.steamSaleDiscount);
		SkillTree.marterialsWorthMore_7_price = (double)(300000f * LevelMechanics.steamSaleDiscount);
		SkillTree.marterialsWorthMore_8_price = (double)(9000000f * LevelMechanics.steamSaleDiscount);
		SkillTree.goldChunk_1_price = (double)(7f * LevelMechanics.steamSaleDiscount);
		SkillTree.goldChunk_2_price = (double)(600f * LevelMechanics.steamSaleDiscount);
		SkillTree.goldChunk_3_price = (double)(900f * LevelMechanics.steamSaleDiscount);
		SkillTree.goldChunk_4_price = (double)(7600f * LevelMechanics.steamSaleDiscount);
		SkillTree.goldChunk_5__price = (double)(250000f * LevelMechanics.steamSaleDiscount);
		SkillTree.fullGold_1_price = (double)(30f * LevelMechanics.steamSaleDiscount);
		SkillTree.fullGold_2_price = (double)(220000f * LevelMechanics.steamSaleDiscount);
		SkillTree.fullGold_3_price = (double)(1700000f * LevelMechanics.steamSaleDiscount);
		SkillTree.spawnCopper_price = (double)(100f * LevelMechanics.steamSaleDiscount);
		SkillTree.copperChunk_1_price = (double)(70f * LevelMechanics.steamSaleDiscount);
		SkillTree.copperChunk_2_price = (double)(2100f * LevelMechanics.steamSaleDiscount);
		SkillTree.copperChunk_3_price = (double)(15000f * LevelMechanics.steamSaleDiscount);
		SkillTree.fullCopper_1_price = (double)(90f * LevelMechanics.steamSaleDiscount);
		SkillTree.fullCopper_2_price = (double)(5500f * LevelMechanics.steamSaleDiscount);
		SkillTree.fullCopper_3_price = (double)(460000f * LevelMechanics.steamSaleDiscount);
		SkillTree.spawnIron_price = (double)(400f * LevelMechanics.steamSaleDiscount);
		SkillTree.ironChunk_1_price = (double)(500f * LevelMechanics.steamSaleDiscount);
		SkillTree.ironChunk_2_price = (double)(500000f * LevelMechanics.steamSaleDiscount);
		SkillTree.fullIron_1_price = (double)(920f * LevelMechanics.steamSaleDiscount);
		SkillTree.fullIron_2_price = (double)(1000000f * LevelMechanics.steamSaleDiscount);
		SkillTree.cobaltSpawn_price = (double)(2350f * LevelMechanics.steamSaleDiscount);
		SkillTree.cobaltChunk_1_price = (double)(3000f * LevelMechanics.steamSaleDiscount);
		SkillTree.fullCobalt_1_price = (double)(3600f * LevelMechanics.steamSaleDiscount);
		SkillTree.uraniumSpawn_price = (double)(4000f * LevelMechanics.steamSaleDiscount);
		SkillTree.uraniumChunk_1_price = (double)(2600f * LevelMechanics.steamSaleDiscount);
		SkillTree.fullUranium_1_price = (double)(3300f * LevelMechanics.steamSaleDiscount);
		SkillTree.ismiumSpawn_price = (double)(140000f * LevelMechanics.steamSaleDiscount);
		SkillTree.ismiumChunk_1_price = (double)(19000f * LevelMechanics.steamSaleDiscount);
		SkillTree.fullIsmium_1_price = (double)(23000f * LevelMechanics.steamSaleDiscount);
		SkillTree.iridiumSpawn_price = (double)(75000f * LevelMechanics.steamSaleDiscount);
		SkillTree.iridiumChunk_1_price = (double)(25000f * LevelMechanics.steamSaleDiscount);
		SkillTree.fullIridium_1_price = (double)(33000f * LevelMechanics.steamSaleDiscount);
		SkillTree.painiteSpawn_price = (double)(1000000f * LevelMechanics.steamSaleDiscount);
		SkillTree.painiteChunk_1_price = (double)(160000f * LevelMechanics.steamSaleDiscount);
		SkillTree.fullPainite_1_price = (double)(240000f * LevelMechanics.steamSaleDiscount);
		SkillTree.improvedPickaxe_1_price = (double)(11f * LevelMechanics.steamSaleDiscount);
		SkillTree.improvedPickaxe_2_price = (double)(300f * LevelMechanics.steamSaleDiscount);
		SkillTree.improvedPickaxe_3_price = (double)(400f * LevelMechanics.steamSaleDiscount);
		SkillTree.improvedPickaxe_4_price = (double)(15000f * LevelMechanics.steamSaleDiscount);
		SkillTree.improvedPickaxe_5_price = (double)(50000f * LevelMechanics.steamSaleDiscount);
		SkillTree.improvedPickaxe_6_price = (double)(100000f * LevelMechanics.steamSaleDiscount);
		SkillTree.biggerMiningErea_1_price = (double)(8f * LevelMechanics.steamSaleDiscount);
		SkillTree.biggerMiningErea_2_price = (double)(1000f * LevelMechanics.steamSaleDiscount);
		SkillTree.biggerMiningErea_3_price = (double)(230f * LevelMechanics.steamSaleDiscount);
		SkillTree.biggerMiningErea_4_price = (double)(1000000f * LevelMechanics.steamSaleDiscount);
		SkillTree.shootCircleChance_price = (double)(125f * LevelMechanics.steamSaleDiscount);
		SkillTree.increaseAndDecreaseMinignErea_price = (double)(5000f * LevelMechanics.steamSaleDiscount);
		SkillTree.spawnRockEveryXrock_1_price = (double)(500f * LevelMechanics.steamSaleDiscount);
		SkillTree.spawnRockEveryXrock_2_price = (double)(3000f * LevelMechanics.steamSaleDiscount);
		SkillTree.spawnRockEveryXrock_3_price = (double)(340000f * LevelMechanics.steamSaleDiscount);
		SkillTree.spawnXRockEveryXSecond_1_price = (double)(75f * LevelMechanics.steamSaleDiscount);
		SkillTree.spawnXRockEveryXSecond_2_price = (double)(420f * LevelMechanics.steamSaleDiscount);
		SkillTree.spawnXRockEveryXSecond_3_price = (double)(500000f * LevelMechanics.steamSaleDiscount);
		SkillTree.chanceToSpawnRockWhenMined_1_price = (double)(18f * LevelMechanics.steamSaleDiscount);
		SkillTree.chanceToSpawnRockWhenMined_2_price = (double)(1000f * LevelMechanics.steamSaleDiscount);
		SkillTree.chanceToSpawnRockWhenMined_3_price = (double)(27000f * LevelMechanics.steamSaleDiscount);
		SkillTree.chanceToSpawnRockWhenMined_4_price = (double)(2600f * LevelMechanics.steamSaleDiscount);
		SkillTree.chanceToSpawnRockWhenMined_5_price = (double)(250f * LevelMechanics.steamSaleDiscount);
		SkillTree.chanceToSpawnRockWhenMined_6_price = (double)(13000f * LevelMechanics.steamSaleDiscount);
		SkillTree.chanceToMineRandomRock_1_price = (double)(50f * LevelMechanics.steamSaleDiscount);
		SkillTree.chanceToMineRandomRock_2_price = (double)(350f * LevelMechanics.steamSaleDiscount);
		SkillTree.chanceToMineRandomRock_3_price = (double)(1000f * LevelMechanics.steamSaleDiscount);
		SkillTree.chanceToMineRandomRock_4_price = (double)(33000f * LevelMechanics.steamSaleDiscount);
		SkillTree.spawnPickaxeEverySecond_1_price = (double)(4000f * LevelMechanics.steamSaleDiscount);
		SkillTree.spawnPickaxeEverySecond_2_price = (double)(8000f * LevelMechanics.steamSaleDiscount);
		SkillTree.spawnPickaxeEverySecond_3_price = (double)(6000f * LevelMechanics.steamSaleDiscount);
		SkillTree.moreTime_1_price = (double)(9f * LevelMechanics.steamSaleDiscount);
		SkillTree.moreTime_2_price = (double)(100f * LevelMechanics.steamSaleDiscount);
		SkillTree.moreTime_3_price = (double)(1250f * LevelMechanics.steamSaleDiscount);
		SkillTree.moreTime_4_price = (double)(70000f * LevelMechanics.steamSaleDiscount);
		SkillTree.chanceToAdd1SecondEverySecond_price = (double)(800f * LevelMechanics.steamSaleDiscount);
		SkillTree.chanceAdd1SecondEveryRockMined_price = (double)(9000f * LevelMechanics.steamSaleDiscount);
		SkillTree.doubleXpGoldChance_1_price = (double)(17f * LevelMechanics.steamSaleDiscount);
		SkillTree.doubleXpGoldChance_2_price = (double)(10000f * LevelMechanics.steamSaleDiscount);
		SkillTree.doubleXpGoldChance_3_price = (double)(2900f * LevelMechanics.steamSaleDiscount);
		SkillTree.doubleXpGoldChance_4_price = (double)(300000f * LevelMechanics.steamSaleDiscount);
		SkillTree.doubleXpGoldChance_5_price = (double)(1000000f * LevelMechanics.steamSaleDiscount);
		SkillTree.allProjectileDoubleDamageChance_price = (double)(1000000f * LevelMechanics.steamSaleDiscount);
		SkillTree.allProjectileTriggerChance_price = (double)(700000f * LevelMechanics.steamSaleDiscount);
		SkillTree.pickaxeDoubleDamageChance_1_price = (double)(56f * LevelMechanics.steamSaleDiscount);
		SkillTree.pickaxeDoubleDamageChance_2_price = (double)(2000000f * LevelMechanics.steamSaleDiscount);
		SkillTree.intaMineChance_1_price = (double)(80f * LevelMechanics.steamSaleDiscount);
		SkillTree.intaMineChance_2_price = (double)(15000f * LevelMechanics.steamSaleDiscount);
		SkillTree.increaseSpawnChanceAllRocks_price = (double)(400000f * LevelMechanics.steamSaleDiscount);
		SkillTree.craft2Material_price = (double)(24000000f * LevelMechanics.steamSaleDiscount);
		SkillTree.finalUpgrade_price = (double)(1000000f * LevelMechanics.steamSaleDiscount);
	}

	// Token: 0x060001C4 RID: 452 RVA: 0x00041D44 File Offset: 0x0003FF44
	private void Update()
	{
		if (MainMenu.isInUpgrades)
		{
			if (SkillTree.moreXP_1_purchaseCount >= 5)
			{
				this.moreXP_1_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalGoldBars >= SkillTree.moreXP_1_price)
			{
				this.moreXP_1_plus.SetActive(true);
			}
			else
			{
				this.moreXP_1_plus.SetActive(false);
			}
			if (SkillTree.moreXP_2_purchaseCount >= 5)
			{
				this.moreXP_2_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalGoldBars >= SkillTree.moreXP_2_price)
			{
				this.moreXP_2_plus.SetActive(true);
			}
			else
			{
				this.moreXP_2_plus.SetActive(false);
			}
			if (SkillTree.moreXP_3_purchaseCount >= 3)
			{
				this.moreXP_3_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalCopperBars >= SkillTree.moreXP_3_price)
			{
				if (SkillTree.spawnCopper_purchased)
				{
					this.moreXP_3_plus.SetActive(true);
				}
				else
				{
					this.moreXP_3_plus.SetActive(false);
				}
			}
			else
			{
				this.moreXP_3_plus.SetActive(false);
			}
			if (SkillTree.moreXP_4_purchaseCount >= 3)
			{
				this.moreXP_4_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalGoldBars >= SkillTree.moreXP_4_price)
			{
				this.moreXP_4_plus.SetActive(true);
			}
			else
			{
				this.moreXP_4_plus.SetActive(false);
			}
			if (SkillTree.moreXP_5_purchaseCount >= 4)
			{
				this.moreXP_5_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalCopperBars >= SkillTree.moreXP_5_price)
			{
				if (SkillTree.spawnCopper_purchased)
				{
					this.moreXP_5_plus.SetActive(true);
				}
				else
				{
					this.moreXP_5_plus.SetActive(false);
				}
			}
			else
			{
				this.moreXP_5_plus.SetActive(false);
			}
			if (SkillTree.moreXP_6_purchaseCount >= 3)
			{
				this.moreXP_6_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalIronBars >= SkillTree.moreXP_6_price)
			{
				if (SkillTree.spawnIron_purchased)
				{
					this.moreXP_6_plus.SetActive(true);
				}
				else
				{
					this.moreXP_6_plus.SetActive(false);
				}
			}
			else
			{
				this.moreXP_6_plus.SetActive(false);
			}
			if (SkillTree.moreXP_7_purchaseCount >= 3)
			{
				this.moreXP_7_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalCobaltBars >= SkillTree.moreXP_7_price)
			{
				if (SkillTree.cobaltSpawn_purchased)
				{
					this.moreXP_7_plus.SetActive(true);
				}
				else
				{
					this.moreXP_7_plus.SetActive(false);
				}
			}
			else
			{
				this.moreXP_7_plus.SetActive(false);
			}
			if (SkillTree.moreXP_8_purchaseCount >= 2)
			{
				this.moreXP_8_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalUraniumBars >= SkillTree.moreXP_8_price)
			{
				if (SkillTree.uraniumSpawn_purchased)
				{
					this.moreXP_8_plus.SetActive(true);
				}
				else
				{
					this.moreXP_8_plus.SetActive(false);
				}
			}
			else
			{
				this.moreXP_8_plus.SetActive(false);
			}
			if (SkillTree.talentPointsPerXlevel_1_purchaseCount >= 1)
			{
				this.talentPointsPerXlevel_1_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalCopperBars >= SkillTree.talentPointsPerXlevel_1_price)
			{
				if (SkillTree.spawnCopper_purchased)
				{
					this.talentPointsPerXlevel_1_plus.SetActive(true);
				}
				else
				{
					this.talentPointsPerXlevel_1_plus.SetActive(false);
				}
			}
			else
			{
				this.talentPointsPerXlevel_1_plus.SetActive(false);
			}
			if (SkillTree.talentPointsPerXlevel_2_purchaseCount >= 1)
			{
				this.talentPointsPerXlevel_2_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalIronBars >= SkillTree.talentPointsPerXlevel_2_price)
			{
				if (SkillTree.spawnIron_purchased)
				{
					this.talentPointsPerXlevel_2_plus.SetActive(true);
				}
				else
				{
					this.talentPointsPerXlevel_2_plus.SetActive(false);
				}
			}
			else
			{
				this.talentPointsPerXlevel_2_plus.SetActive(false);
			}
			if (SkillTree.talentPointsPerXlevel_3_purchaseCount >= 1)
			{
				this.talentPointsPerXlevel_3_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalCopperBars >= SkillTree.talentPointsPerXlevel_3_price)
			{
				if (SkillTree.spawnCopper_purchased)
				{
					this.talentPointsPerXlevel_3_plus.SetActive(true);
				}
				else
				{
					this.talentPointsPerXlevel_3_plus.SetActive(false);
				}
			}
			else
			{
				this.talentPointsPerXlevel_3_plus.SetActive(false);
			}
			if (SkillTree.lightningBeamChanceS_1_purchaseCount >= 5)
			{
				this.lightningBeamChanceS_1_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalIronBars >= SkillTree.lightningBeamChanceS_1_price)
			{
				if (SkillTree.spawnIron_purchased)
				{
					this.lightningBeamChanceS_1_plus.SetActive(true);
				}
				else
				{
					this.lightningBeamChanceS_1_plus.SetActive(false);
				}
			}
			else
			{
				this.lightningBeamChanceS_1_plus.SetActive(false);
			}
			if (SkillTree.lightningBeamChanceS_2_purchaseCount >= 5)
			{
				this.lightningBeamChanceS_2_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalCopperBars >= SkillTree.lightningBeamChanceS_2_price)
			{
				if (SkillTree.spawnCopper_purchased)
				{
					this.lightningBeamChanceS_2_plus.SetActive(true);
				}
				else
				{
					this.lightningBeamChanceS_2_plus.SetActive(false);
				}
			}
			else
			{
				this.lightningBeamChanceS_2_plus.SetActive(false);
			}
			if (SkillTree.lightningBeamChancePH_1_purchaseCount >= 3)
			{
				this.lightningBeamChancePH_1_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalCopperBars >= SkillTree.lightningBeamChancePH_1_price)
			{
				if (SkillTree.spawnCopper_purchased)
				{
					this.lightningBeamChancePH_1_plus.SetActive(true);
				}
				else
				{
					this.lightningBeamChancePH_1_plus.SetActive(false);
				}
			}
			else
			{
				this.lightningBeamChancePH_1_plus.SetActive(false);
			}
			if (SkillTree.lightningBeamChancePH_2_purchaseCount >= 3)
			{
				this.lightningBeamChancePH_2_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalIronBars >= SkillTree.lightningBeamChancePH_2_price)
			{
				if (SkillTree.spawnIron_purchased)
				{
					this.lightningBeamChancePH_2_plus.SetActive(true);
				}
				else
				{
					this.lightningBeamChancePH_2_plus.SetActive(false);
				}
			}
			else
			{
				this.lightningBeamChancePH_2_plus.SetActive(false);
			}
			if (SkillTree.lightningBeamSpawnAnotherOneChance_purchaseCount >= 1)
			{
				this.lightningBeamSpawnAnotherOneChance_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalIridiumBars >= SkillTree.lightningBeamSpawnAnotherOneChance_price)
			{
				if (SkillTree.iridiumSpawn_purchased)
				{
					this.lightningBeamSpawnAnotherOneChance_plus.SetActive(true);
				}
				else
				{
					this.lightningBeamSpawnAnotherOneChance_plus.SetActive(false);
				}
			}
			else
			{
				this.lightningBeamSpawnAnotherOneChance_plus.SetActive(false);
			}
			if (SkillTree.lightningBeamDamage_purchaseCount >= 3)
			{
				this.lightningBeamDamage_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalGoldBars >= SkillTree.lightningBeamDamage_price)
			{
				this.lightningBeamDamage_plus.SetActive(true);
			}
			else
			{
				this.lightningBeamDamage_plus.SetActive(false);
			}
			if (SkillTree.lightningBeamSize_purchaseCount >= 3)
			{
				this.lightningBeamSize_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalIronBars >= SkillTree.lightningBeamSize_price)
			{
				if (SkillTree.spawnIron_purchased)
				{
					this.lightningBeamSize_plus.SetActive(true);
				}
				else
				{
					this.lightningBeamSize_plus.SetActive(false);
				}
			}
			else
			{
				this.lightningBeamSize_plus.SetActive(false);
			}
			if (SkillTree.lightningSplashes_purchaseCount >= 1)
			{
				this.lightningSplashes_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalGoldBars >= SkillTree.lightningSplashes_price)
			{
				this.lightningSplashes_plus.SetActive(true);
			}
			else
			{
				this.lightningSplashes_plus.SetActive(false);
			}
			if (SkillTree.lightningBeamSpawnRock_purchaseCount >= 1)
			{
				this.lightningBeamSpawnRock_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalCobaltBars >= SkillTree.lightningBeamSpawnRock_price)
			{
				if (SkillTree.cobaltSpawn_purchased)
				{
					this.lightningBeamSpawnRock_plus.SetActive(true);
				}
				else
				{
					this.lightningBeamSpawnRock_plus.SetActive(false);
				}
			}
			else
			{
				this.lightningBeamSpawnRock_plus.SetActive(false);
			}
			if (SkillTree.lightningBeamExplosion_purchaseCount >= 1)
			{
				this.lightningBeamExplosion_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalCobaltBars >= SkillTree.lightningBeamExplosion_price)
			{
				if (SkillTree.cobaltSpawn_purchased)
				{
					this.lightningBeamExplosion_plus.SetActive(true);
				}
				else
				{
					this.lightningBeamExplosion_plus.SetActive(false);
				}
			}
			else
			{
				this.lightningBeamExplosion_plus.SetActive(false);
			}
			if (SkillTree.lightningBeamAddTime_purchaseCount >= 1)
			{
				this.lightningBeamAddTime_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalGoldBars >= SkillTree.lightningBeamAddTime_price)
			{
				this.lightningBeamAddTime_plus.SetActive(true);
			}
			else
			{
				this.lightningBeamAddTime_plus.SetActive(false);
			}
			if (SkillTree.dynamiteChance_1_purchaseCount >= 3)
			{
				this.dynamiteChance_1_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalIronBars >= SkillTree.dynamiteChance_1_price)
			{
				if (SkillTree.spawnIron_purchased)
				{
					this.dynamiteChance_1_plus.SetActive(true);
				}
				else
				{
					this.dynamiteChance_1_plus.SetActive(false);
				}
			}
			else
			{
				this.dynamiteChance_1_plus.SetActive(false);
			}
			if (SkillTree.dynamiteChance_2_purchaseCount >= 3)
			{
				this.dynamiteChance_2_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalCopperBars >= SkillTree.dynamiteChance_2_price)
			{
				if (SkillTree.spawnCopper_purchased)
				{
					this.dynamiteChance_2_plus.SetActive(true);
				}
				else
				{
					this.dynamiteChance_2_plus.SetActive(false);
				}
			}
			else
			{
				this.dynamiteChance_2_plus.SetActive(false);
			}
			if (SkillTree.dynamiteSpawn2SmallChance_purchaseCount >= 1)
			{
				this.dynamiteSpawn2SmallChance_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalUraniumBars >= SkillTree.dynamiteSpawn2SmallChance_price)
			{
				if (SkillTree.uraniumSpawn_purchased)
				{
					this.dynamiteSpawn2SmallChance_plus.SetActive(true);
				}
				else
				{
					this.dynamiteSpawn2SmallChance_plus.SetActive(false);
				}
			}
			else
			{
				this.dynamiteSpawn2SmallChance_plus.SetActive(false);
			}
			if (SkillTree.dynamiteExplosionSize_purchaseCount >= 3)
			{
				this.dynamiteExplosionSize_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalGoldBars >= SkillTree.dynamiteExplosionSize_price)
			{
				this.dynamiteExplosionSize_plus.SetActive(true);
			}
			else
			{
				this.dynamiteExplosionSize_plus.SetActive(false);
			}
			if (SkillTree.dynamiteDamage_purchaseCount >= 3)
			{
				this.dynamiteDamage_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalGoldBars >= SkillTree.dynamiteDamage_price)
			{
				this.dynamiteDamage_plus.SetActive(true);
			}
			else
			{
				this.dynamiteDamage_plus.SetActive(false);
			}
			if (SkillTree.dynamiteExplosionSpawnRock_purchaseCount >= 1)
			{
				this.dynamiteExplosionSpawnRock_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalCobaltBars >= SkillTree.dynamiteExplosionSpawnRock_price)
			{
				if (SkillTree.cobaltSpawn_purchased)
				{
					this.dynamiteExplosionSpawnRock_plus.SetActive(true);
				}
				else
				{
					this.dynamiteExplosionSpawnRock_plus.SetActive(false);
				}
			}
			else
			{
				this.dynamiteExplosionSpawnRock_plus.SetActive(false);
			}
			if (SkillTree.dynamiteExplosionAddTimeChance_purchaseCount >= 1)
			{
				this.dynamiteExplosionAddTimeChance_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalCopperBars >= SkillTree.dynamiteExplosionAddTimeChance_price)
			{
				if (SkillTree.spawnCopper_purchased)
				{
					this.dynamiteExplosionAddTimeChance_plus.SetActive(true);
				}
				else
				{
					this.dynamiteExplosionAddTimeChance_plus.SetActive(false);
				}
			}
			else
			{
				this.dynamiteExplosionAddTimeChance_plus.SetActive(false);
			}
			if (SkillTree.dynamiteExplosionSpawnLightning_purchaseCount >= 1)
			{
				this.dynamiteExplosionSpawnLightning_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalIsmiumBar >= SkillTree.dynamiteExplosionSpawnLightning_price)
			{
				if (SkillTree.ismiumSpawn_purchased)
				{
					this.dynamiteExplosionSpawnLightning_plus.SetActive(true);
				}
				else
				{
					this.dynamiteExplosionSpawnLightning_plus.SetActive(false);
				}
			}
			else
			{
				this.dynamiteExplosionSpawnLightning_plus.SetActive(false);
			}
			if (SkillTree.plazmaBallSpawn_1_purchaseCount >= 3)
			{
				this.plazmaBallSpawn_1_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalCobaltBars >= SkillTree.plazmaBallSpawn_1_price)
			{
				if (SkillTree.cobaltSpawn_purchased)
				{
					this.plazmaBallSpawn_1_plus.SetActive(true);
				}
				else
				{
					this.plazmaBallSpawn_1_plus.SetActive(false);
				}
			}
			else
			{
				this.plazmaBallSpawn_1_plus.SetActive(false);
			}
			if (SkillTree.plazmaBallSpawn_2_purchaseCount >= 3)
			{
				this.plazmaBallSpawn_2_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalIridiumBars >= SkillTree.plazmaBallSpawn_2_price)
			{
				if (SkillTree.iridiumSpawn_purchased)
				{
					this.plazmaBallSpawn_2_plus.SetActive(true);
				}
				else
				{
					this.plazmaBallSpawn_2_plus.SetActive(false);
				}
			}
			else
			{
				this.plazmaBallSpawn_2_plus.SetActive(false);
			}
			if (SkillTree.plazmaBallTime_purchaseCount >= 3)
			{
				this.plazmaBallTime_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalCopperBars >= SkillTree.plazmaBallTime_price)
			{
				if (SkillTree.spawnCopper_purchased)
				{
					this.plazmaBallTime_plus.SetActive(true);
				}
				else
				{
					this.plazmaBallTime_plus.SetActive(false);
				}
			}
			else
			{
				this.plazmaBallTime_plus.SetActive(false);
			}
			if (SkillTree.plazmaBallSize_purchaseCount >= 3)
			{
				this.plazmaBallSize_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalUraniumBars >= SkillTree.plazmaBallSize_price)
			{
				if (SkillTree.uraniumSpawn_purchased)
				{
					this.plazmaBallSize_plus.SetActive(true);
				}
				else
				{
					this.plazmaBallSize_plus.SetActive(false);
				}
			}
			else
			{
				this.plazmaBallSize_plus.SetActive(false);
			}
			if (SkillTree.plazmaBallExplosionChance_purchaseCount >= 1)
			{
				this.plazmaBallExplosionChance_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalIridiumBars >= SkillTree.plazmaBallExplosionChance_price)
			{
				if (SkillTree.iridiumSpawn_purchased)
				{
					this.plazmaBallExplosionChance_plus.SetActive(true);
				}
				else
				{
					this.plazmaBallExplosionChance_plus.SetActive(false);
				}
			}
			else
			{
				this.plazmaBallExplosionChance_plus.SetActive(false);
			}
			if (SkillTree.plazmaBallSpawnSmallChance_purchaseCount >= 1)
			{
				this.plazmaBallSpawnSmallChance_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalGoldBars >= SkillTree.plazmaBallSpawnSmallChance_price)
			{
				this.plazmaBallSpawnSmallChance_plus.SetActive(true);
			}
			else
			{
				this.plazmaBallSpawnSmallChance_plus.SetActive(false);
			}
			if (SkillTree.plazmaBallDamage_purchaseCount >= 5)
			{
				this.plazmaBallDamage_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalGoldBars >= SkillTree.plazmaBallDamage_price)
			{
				this.plazmaBallDamage_plus.SetActive(true);
			}
			else
			{
				this.plazmaBallDamage_plus.SetActive(false);
			}
			if (SkillTree.plazmaBallSpawnPickaxeChance_purchaseCount >= 1)
			{
				this.plazmaBallSpawnPickaxeChance_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalPainiteBars >= SkillTree.plazmaBallSpawnPickaxeChance_price)
			{
				if (SkillTree.painiteSpawn_purchased)
				{
					this.plazmaBallSpawnPickaxeChance_plus.SetActive(true);
				}
				else
				{
					this.plazmaBallSpawnPickaxeChance_plus.SetActive(false);
				}
			}
			else
			{
				this.plazmaBallSpawnPickaxeChance_plus.SetActive(false);
			}
			if (SkillTree.spawnMoreRocks_1_purchaseCount >= 5)
			{
				this.spawnMoreRocks_1_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalGoldBars >= SkillTree.spawnMoreRocks_1_price)
			{
				this.spawnMoreRocks_1_plus.SetActive(true);
			}
			else
			{
				this.spawnMoreRocks_1_plus.SetActive(false);
			}
			if (SkillTree.spawnMoreRocks_2_purchaseCount >= 4)
			{
				this.spawnMoreRocks_2_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalGoldBars >= SkillTree.spawnMoreRocks_2_price)
			{
				this.spawnMoreRocks_2_plus.SetActive(true);
			}
			else
			{
				this.spawnMoreRocks_2_plus.SetActive(false);
			}
			if (SkillTree.spawnMoreRocks_3_purchaseCount >= 4)
			{
				this.spawnMoreRocks_3_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalGoldBars >= SkillTree.spawnMoreRocks_3_price)
			{
				this.spawnMoreRocks_3_plus.SetActive(true);
			}
			else
			{
				this.spawnMoreRocks_3_plus.SetActive(false);
			}
			if (SkillTree.spawnMoreRocks_4_purchaseCount >= 5)
			{
				this.spawnMoreRocks_4_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalGoldBars >= SkillTree.spawnMoreRocks_4_price)
			{
				this.spawnMoreRocks_4_plus.SetActive(true);
			}
			else
			{
				this.spawnMoreRocks_4_plus.SetActive(false);
			}
			if (SkillTree.spawnMoreRocks_5_purchaseCount >= 5)
			{
				this.spawnMoreRocks_5_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalCopperBars >= SkillTree.spawnMoreRocks_5_price)
			{
				if (SkillTree.spawnCopper_purchased)
				{
					this.spawnMoreRocks_5_plus.SetActive(true);
				}
				else
				{
					this.spawnMoreRocks_5_plus.SetActive(false);
				}
			}
			else
			{
				this.spawnMoreRocks_5_plus.SetActive(false);
			}
			if (SkillTree.spawnMoreRocks_6_purchaseCount >= 3)
			{
				this.spawnMoreRocks_6_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalIronBars >= SkillTree.spawnMoreRocks_6_price)
			{
				if (SkillTree.spawnIron_purchased)
				{
					this.spawnMoreRocks_6_plus.SetActive(true);
				}
				else
				{
					this.spawnMoreRocks_6_plus.SetActive(false);
				}
			}
			else
			{
				this.spawnMoreRocks_6_plus.SetActive(false);
			}
			if (SkillTree.spawnMoreRocks_7_purchaseCount >= 3)
			{
				this.spawnMoreRocks_7_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalGoldBars >= SkillTree.spawnMoreRocks_7_price)
			{
				this.spawnMoreRocks_7_plus.SetActive(true);
			}
			else
			{
				this.spawnMoreRocks_7_plus.SetActive(false);
			}
			if (SkillTree.spawnMoreRocks_8_purchaseCount >= 3)
			{
				this.spawnMoreRocks_8_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalPainiteBars >= SkillTree.spawnMoreRocks_8_price)
			{
				if (SkillTree.painiteSpawn_purchased)
				{
					this.spawnMoreRocks_8_plus.SetActive(true);
				}
				else
				{
					this.spawnMoreRocks_8_plus.SetActive(false);
				}
			}
			else
			{
				this.spawnMoreRocks_8_plus.SetActive(false);
			}
			if (SkillTree.spawnMoreRocks_9_purchaseCount >= 3)
			{
				this.spawnMoreRocks_9_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalPainiteBars >= SkillTree.spawnMoreRocks_9_price)
			{
				if (SkillTree.painiteSpawn_purchased)
				{
					this.spawnMoreRocks_9_plus.SetActive(true);
				}
				else
				{
					this.spawnMoreRocks_9_plus.SetActive(false);
				}
			}
			else
			{
				this.spawnMoreRocks_9_plus.SetActive(false);
			}
			if (SkillTree.moreMeterialsFromRock_1_purchaseCount >= 2)
			{
				this.moreMeterialsFromRock_1_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalCopperBars >= SkillTree.moreMeterialsFromRock_1_price)
			{
				if (SkillTree.spawnCopper_purchased)
				{
					this.moreMeterialsFromRock_1_plus.SetActive(true);
				}
				else
				{
					this.moreMeterialsFromRock_1_plus.SetActive(false);
				}
			}
			else
			{
				this.moreMeterialsFromRock_1_plus.SetActive(false);
			}
			if (SkillTree.moreMeterialsFromRock_2_purchaseCount >= 2)
			{
				this.moreMeterialsFromRock_2_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalIsmiumBar >= SkillTree.moreMeterialsFromRock_2_price)
			{
				if (SkillTree.ismiumSpawn_purchased)
				{
					this.moreMeterialsFromRock_2_plus.SetActive(true);
				}
				else
				{
					this.moreMeterialsFromRock_2_plus.SetActive(false);
				}
			}
			else
			{
				this.moreMeterialsFromRock_2_plus.SetActive(false);
			}
			if (SkillTree.moreMeterialsFromRock_3_purchaseCount >= 2)
			{
				this.moreMeterialsFromRock_3_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalIridiumBars >= SkillTree.moreMeterialsFromRock_3_price)
			{
				if (SkillTree.iridiumSpawn_purchased)
				{
					this.moreMeterialsFromRock_3_plus.SetActive(true);
				}
				else
				{
					this.moreMeterialsFromRock_3_plus.SetActive(false);
				}
			}
			else
			{
				this.moreMeterialsFromRock_3_plus.SetActive(false);
			}
			if (SkillTree.moreMeterialsFromRock_4_purchaseCount >= 2)
			{
				this.moreMeterialsFromRock_4_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalCobaltBars >= SkillTree.moreMeterialsFromRock_4_price)
			{
				if (SkillTree.cobaltSpawn_purchased)
				{
					this.moreMeterialsFromRock_4_plus.SetActive(true);
				}
				else
				{
					this.moreMeterialsFromRock_4_plus.SetActive(false);
				}
			}
			else
			{
				this.moreMeterialsFromRock_4_plus.SetActive(false);
			}
			if (SkillTree.moreMeterialsFromRock_5_purchaseCount >= 2)
			{
				this.moreMeterialsFromRock_5_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalCopperBars >= SkillTree.moreMeterialsFromRock_5_price)
			{
				if (SkillTree.spawnCopper_purchased)
				{
					this.moreMeterialsFromRock_5_plus.SetActive(true);
				}
				else
				{
					this.moreMeterialsFromRock_5_plus.SetActive(false);
				}
			}
			else
			{
				this.moreMeterialsFromRock_5_plus.SetActive(false);
			}
			if (SkillTree.marterialsWorthMore_1_purchaseCount >= 4)
			{
				this.marterialsWorthMore_1_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalGoldBars >= SkillTree.marterialsWorthMore_1_price)
			{
				this.marterialsWorthMore_1_plus.SetActive(true);
			}
			else
			{
				this.marterialsWorthMore_1_plus.SetActive(false);
			}
			if (SkillTree.marterialsWorthMore_2_purchaseCount >= 5)
			{
				this.marterialsWorthMore_2_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalGoldBars >= SkillTree.marterialsWorthMore_2_price)
			{
				this.marterialsWorthMore_2_plus.SetActive(true);
			}
			else
			{
				this.marterialsWorthMore_2_plus.SetActive(false);
			}
			if (SkillTree.marterialsWorthMore_3_purchaseCount >= 5)
			{
				this.marterialsWorthMore_3_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalIronBars >= SkillTree.marterialsWorthMore_3_price)
			{
				if (SkillTree.spawnIron_purchased)
				{
					this.marterialsWorthMore_3_plus.SetActive(true);
				}
				else
				{
					this.marterialsWorthMore_3_plus.SetActive(false);
				}
			}
			else
			{
				this.marterialsWorthMore_3_plus.SetActive(false);
			}
			if (SkillTree.marterialsWorthMore_4_purchaseCount >= 5)
			{
				this.marterialsWorthMore_4_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalIsmiumBar >= SkillTree.marterialsWorthMore_4_price)
			{
				if (SkillTree.ismiumSpawn_purchased)
				{
					this.marterialsWorthMore_4_plus.SetActive(true);
				}
				else
				{
					this.marterialsWorthMore_4_plus.SetActive(false);
				}
			}
			else
			{
				this.marterialsWorthMore_4_plus.SetActive(false);
			}
			if (SkillTree.marterialsWorthMore_5_purchaseCount >= 5)
			{
				this.marterialsWorthMore_5_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalIridiumBars >= SkillTree.marterialsWorthMore_5_price)
			{
				if (SkillTree.iridiumSpawn_purchased)
				{
					this.marterialsWorthMore_5_plus.SetActive(true);
				}
				else
				{
					this.marterialsWorthMore_5_plus.SetActive(false);
				}
			}
			else
			{
				this.marterialsWorthMore_5_plus.SetActive(false);
			}
			if (SkillTree.marterialsWorthMore_6_purchaseCount >= 5)
			{
				this.marterialsWorthMore_6_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalCopperBars >= SkillTree.marterialsWorthMore_6_price)
			{
				if (SkillTree.spawnCopper_purchased)
				{
					this.marterialsWorthMore_6_plus.SetActive(true);
				}
				else
				{
					this.marterialsWorthMore_6_plus.SetActive(false);
				}
			}
			else
			{
				this.marterialsWorthMore_6_plus.SetActive(false);
			}
			if (SkillTree.marterialsWorthMore_7_purchaseCount >= 5)
			{
				this.marterialsWorthMore_7_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalGoldBars >= SkillTree.marterialsWorthMore_7_price)
			{
				this.marterialsWorthMore_7_plus.SetActive(true);
			}
			else
			{
				this.marterialsWorthMore_7_plus.SetActive(false);
			}
			if (SkillTree.marterialsWorthMore_8_purchaseCount >= 5)
			{
				this.marterialsWorthMore_8_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalGoldBars >= SkillTree.marterialsWorthMore_8_price)
			{
				this.marterialsWorthMore_8_plus.SetActive(true);
			}
			else
			{
				this.marterialsWorthMore_8_plus.SetActive(false);
			}
			if (SkillTree.goldChunk_1_purchaseCount >= 5)
			{
				this.goldChunk_1_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalGoldBars >= SkillTree.goldChunk_1_price)
			{
				this.goldChunk_1_plus.SetActive(true);
			}
			else
			{
				this.goldChunk_1_plus.SetActive(false);
			}
			if (SkillTree.goldChunk_2_purchaseCount >= 5)
			{
				this.goldChunk_2_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalCopperBars >= SkillTree.goldChunk_2_price)
			{
				if (SkillTree.spawnCopper_purchased)
				{
					this.goldChunk_2_plus.SetActive(true);
				}
				else
				{
					this.goldChunk_2_plus.SetActive(false);
				}
			}
			else
			{
				this.goldChunk_2_plus.SetActive(false);
			}
			if (SkillTree.goldChunk_3_purchaseCount >= 5)
			{
				this.goldChunk_3_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalGoldBars >= SkillTree.goldChunk_3_price)
			{
				this.goldChunk_3_plus.SetActive(true);
			}
			else
			{
				this.goldChunk_3_plus.SetActive(false);
			}
			if (SkillTree.goldChunk_4_purchaseCount >= 5)
			{
				this.goldChunk_4_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalUraniumBars >= SkillTree.goldChunk_4_price)
			{
				if (SkillTree.uraniumSpawn_purchased)
				{
					this.goldChunk_4_plus.SetActive(true);
				}
				else
				{
					this.goldChunk_4_plus.SetActive(false);
				}
			}
			else
			{
				this.goldChunk_4_plus.SetActive(false);
			}
			if (SkillTree.goldChunk_5_purchaseCount >= 5)
			{
				this.goldChunk_5__plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalIronBars >= SkillTree.goldChunk_5__price)
			{
				if (SkillTree.spawnIron_purchased)
				{
					this.goldChunk_5__plus.SetActive(true);
				}
				else
				{
					this.goldChunk_5__plus.SetActive(false);
				}
			}
			else
			{
				this.goldChunk_5__plus.SetActive(false);
			}
			if (SkillTree.fullGold_1_purchaseCount >= 3)
			{
				this.fullGold_1_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalGoldBars >= SkillTree.fullGold_1_price)
			{
				this.fullGold_1_plus.SetActive(true);
			}
			else
			{
				this.fullGold_1_plus.SetActive(false);
			}
			if (SkillTree.fullGold_2_purchaseCount >= 3)
			{
				this.fullGold_2_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalGoldBars >= SkillTree.fullGold_2_price)
			{
				this.fullGold_2_plus.SetActive(true);
			}
			else
			{
				this.fullGold_2_plus.SetActive(false);
			}
			if (SkillTree.fullGold_3_purchaseCount >= 3)
			{
				this.fullGold_3_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalIronBars >= SkillTree.fullGold_3_price)
			{
				if (SkillTree.spawnIron_purchased)
				{
					this.fullGold_3_plus.SetActive(true);
				}
				else
				{
					this.fullGold_3_plus.SetActive(false);
				}
			}
			else
			{
				this.fullGold_3_plus.SetActive(false);
			}
			if (SkillTree.spawnCopper_purchaseCount >= 1)
			{
				this.spawnCopper_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalGoldBars >= SkillTree.spawnCopper_price)
			{
				this.spawnCopper_plus.SetActive(true);
			}
			else
			{
				this.spawnCopper_plus.SetActive(false);
			}
			if (SkillTree.copperChunk_1_purchaseCount >= 3)
			{
				this.copperChunk_1_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalCopperBars >= SkillTree.copperChunk_1_price)
			{
				if (SkillTree.spawnCopper_purchased)
				{
					this.copperChunk_1_plus.SetActive(true);
				}
				else
				{
					this.copperChunk_1_plus.SetActive(false);
				}
			}
			else
			{
				this.copperChunk_1_plus.SetActive(false);
			}
			if (SkillTree.copperChunk_2_purchaseCount >= 3)
			{
				this.copperChunk_2_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalUraniumBars >= SkillTree.copperChunk_2_price)
			{
				if (SkillTree.uraniumSpawn_purchased)
				{
					this.copperChunk_2_plus.SetActive(true);
				}
				else
				{
					this.copperChunk_2_plus.SetActive(false);
				}
			}
			else
			{
				this.copperChunk_2_plus.SetActive(false);
			}
			if (SkillTree.copperChunk_3_purchaseCount >= 3)
			{
				this.copperChunk_3_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalIsmiumBar >= SkillTree.copperChunk_3_price)
			{
				if (SkillTree.ismiumSpawn_purchased)
				{
					this.copperChunk_3_plus.SetActive(true);
				}
				else
				{
					this.copperChunk_3_plus.SetActive(false);
				}
			}
			else
			{
				this.copperChunk_3_plus.SetActive(false);
			}
			if (SkillTree.fullCopper_1_purchaseCount >= 2)
			{
				this.fullCopper_1_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalCopperBars >= SkillTree.fullCopper_1_price)
			{
				if (SkillTree.spawnCopper_purchased)
				{
					this.fullCopper_1_plus.SetActive(true);
				}
				else
				{
					this.fullCopper_1_plus.SetActive(false);
				}
			}
			else
			{
				this.fullCopper_1_plus.SetActive(false);
			}
			if (SkillTree.fullCopper_2_purchaseCount >= 2)
			{
				this.fullCopper_2_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalCobaltBars >= SkillTree.fullCopper_2_price)
			{
				if (SkillTree.cobaltSpawn_purchased)
				{
					this.fullCopper_2_plus.SetActive(true);
				}
				else
				{
					this.fullCopper_2_plus.SetActive(false);
				}
			}
			else
			{
				this.fullCopper_2_plus.SetActive(false);
			}
			if (SkillTree.fullCopper_3_purchaseCount >= 2)
			{
				this.fullCopper_3_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalIronBars >= SkillTree.fullCopper_3_price)
			{
				if (SkillTree.spawnIron_purchased)
				{
					this.fullCopper_3_plus.SetActive(true);
				}
				else
				{
					this.fullCopper_3_plus.SetActive(false);
				}
			}
			else
			{
				this.fullCopper_3_plus.SetActive(false);
			}
			if (SkillTree.spawnIron_purchaseCount >= 1)
			{
				this.spawnIron_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalCopperBars >= SkillTree.spawnIron_price)
			{
				if (SkillTree.spawnCopper_purchased)
				{
					this.spawnIron_plus.SetActive(true);
				}
				else
				{
					this.spawnIron_plus.SetActive(false);
				}
			}
			else
			{
				this.spawnIron_plus.SetActive(false);
			}
			if (SkillTree.ironChunk_1_purchaseCount >= 3)
			{
				this.ironChunk_1_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalIronBars >= SkillTree.ironChunk_1_price)
			{
				if (SkillTree.spawnIron_purchased)
				{
					this.ironChunk_1_plus.SetActive(true);
				}
				else
				{
					this.ironChunk_1_plus.SetActive(false);
				}
			}
			else
			{
				this.ironChunk_1_plus.SetActive(false);
			}
			if (SkillTree.ironChunk_2_purchaseCount >= 3)
			{
				this.ironChunk_2_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalGoldBars >= SkillTree.ironChunk_2_price)
			{
				this.ironChunk_2_plus.SetActive(true);
			}
			else
			{
				this.ironChunk_2_plus.SetActive(false);
			}
			if (SkillTree.fullIron_1_purchaseCount >= 2)
			{
				this.fullIron_1_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalIronBars >= SkillTree.fullIron_1_price)
			{
				if (SkillTree.spawnIron_purchased)
				{
					this.fullIron_1_plus.SetActive(true);
				}
				else
				{
					this.fullIron_1_plus.SetActive(false);
				}
			}
			else
			{
				this.fullIron_1_plus.SetActive(false);
			}
			if (SkillTree.fullIron_2_purchaseCount >= 2)
			{
				this.fullIron_2_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalCopperBars >= SkillTree.fullIron_2_price)
			{
				if (SkillTree.spawnCopper_purchased)
				{
					this.fullIron_2_plus.SetActive(true);
				}
				else
				{
					this.fullIron_2_plus.SetActive(false);
				}
			}
			else
			{
				this.fullIron_2_plus.SetActive(false);
			}
			if (SkillTree.cobaltSpawn_purchaseCount >= 1)
			{
				this.cobaltSpawn_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalIronBars >= SkillTree.cobaltSpawn_price)
			{
				if (SkillTree.spawnIron_purchased)
				{
					this.cobaltSpawn_plus.SetActive(true);
				}
				else
				{
					this.cobaltSpawn_plus.SetActive(false);
				}
			}
			else
			{
				this.cobaltSpawn_plus.SetActive(false);
			}
			if (SkillTree.cobaltChunk_1_purchaseCount >= 3)
			{
				this.cobaltChunk_1_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalCobaltBars >= SkillTree.cobaltChunk_1_price)
			{
				if (SkillTree.cobaltSpawn_purchased)
				{
					this.cobaltChunk_1_plus.SetActive(true);
				}
				else
				{
					this.cobaltChunk_1_plus.SetActive(false);
				}
			}
			else
			{
				this.cobaltChunk_1_plus.SetActive(false);
			}
			if (SkillTree.fullCobalt_1_purchaseCount >= 2)
			{
				this.fullCobalt_1_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalCobaltBars >= SkillTree.fullCobalt_1_price)
			{
				if (SkillTree.cobaltSpawn_purchased)
				{
					this.fullCobalt_1_plus.SetActive(true);
				}
				else
				{
					this.fullCobalt_1_plus.SetActive(false);
				}
			}
			else
			{
				this.fullCobalt_1_plus.SetActive(false);
			}
			if (SkillTree.uraniumSpawn_purchaseCount >= 1)
			{
				this.uraniumSpawn_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalCobaltBars >= SkillTree.uraniumSpawn_price)
			{
				if (SkillTree.cobaltSpawn_purchased)
				{
					this.uraniumSpawn_plus.SetActive(true);
				}
				else
				{
					this.uraniumSpawn_plus.SetActive(false);
				}
			}
			else
			{
				this.uraniumSpawn_plus.SetActive(false);
			}
			if (SkillTree.uraniumChunk_1_purchaseCount >= 3)
			{
				this.uraniumChunk_1_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalUraniumBars >= SkillTree.uraniumChunk_1_price)
			{
				if (SkillTree.uraniumSpawn_purchased)
				{
					this.uraniumChunk_1_plus.SetActive(true);
				}
				else
				{
					this.uraniumChunk_1_plus.SetActive(false);
				}
			}
			else
			{
				this.uraniumChunk_1_plus.SetActive(false);
			}
			if (SkillTree.fullUranium_1_purchaseCount >= 2)
			{
				this.fullUranium_1_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalUraniumBars >= SkillTree.fullUranium_1_price)
			{
				if (SkillTree.uraniumSpawn_purchased)
				{
					this.fullUranium_1_plus.SetActive(true);
				}
				else
				{
					this.fullUranium_1_plus.SetActive(false);
				}
			}
			else
			{
				this.fullUranium_1_plus.SetActive(false);
			}
			if (SkillTree.ismiumSpawn_purchaseCount >= 1)
			{
				this.ismiumSpawn_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalUraniumBars >= SkillTree.ismiumSpawn_price)
			{
				if (SkillTree.uraniumSpawn_purchased)
				{
					this.ismiumSpawn_plus.SetActive(true);
				}
				else
				{
					this.ismiumSpawn_plus.SetActive(false);
				}
			}
			else
			{
				this.ismiumSpawn_plus.SetActive(false);
			}
			if (SkillTree.ismiumChunk_1_purchaseCount >= 3)
			{
				this.ismiumChunk_1_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalIsmiumBar >= SkillTree.ismiumChunk_1_price)
			{
				if (SkillTree.ismiumSpawn_purchased)
				{
					this.ismiumChunk_1_plus.SetActive(true);
				}
				else
				{
					this.ismiumChunk_1_plus.SetActive(false);
				}
			}
			else
			{
				this.ismiumChunk_1_plus.SetActive(false);
			}
			if (SkillTree.fullIsmium_1_purchaseCount >= 2)
			{
				this.fullIsmium_1_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalIsmiumBar >= SkillTree.fullIsmium_1_price)
			{
				if (SkillTree.ismiumSpawn_purchased)
				{
					this.fullIsmium_1_plus.SetActive(true);
				}
				else
				{
					this.fullIsmium_1_plus.SetActive(false);
				}
			}
			else
			{
				this.fullIsmium_1_plus.SetActive(false);
			}
			if (SkillTree.iridiumSpawn_purchaseCount >= 1)
			{
				this.iridiumSpawn_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalIsmiumBar >= SkillTree.iridiumSpawn_price)
			{
				if (SkillTree.ismiumSpawn_purchased)
				{
					this.iridiumSpawn_plus.SetActive(true);
				}
				else
				{
					this.iridiumSpawn_plus.SetActive(false);
				}
			}
			else
			{
				this.iridiumSpawn_plus.SetActive(false);
			}
			if (SkillTree.iridiumChunk_1_purchaseCount >= 3)
			{
				this.iridiumChunk_1_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalIridiumBars >= SkillTree.iridiumChunk_1_price)
			{
				if (SkillTree.iridiumSpawn_purchased)
				{
					this.iridiumChunk_1_plus.SetActive(true);
				}
				else
				{
					this.iridiumChunk_1_plus.SetActive(false);
				}
			}
			else
			{
				this.iridiumChunk_1_plus.SetActive(false);
			}
			if (SkillTree.fullIridium_1_purchaseCount >= 2)
			{
				this.fullIridium_1_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalIridiumBars >= SkillTree.fullIridium_1_price)
			{
				if (SkillTree.iridiumSpawn_purchased)
				{
					this.fullIridium_1_plus.SetActive(true);
				}
				else
				{
					this.fullIridium_1_plus.SetActive(false);
				}
			}
			else
			{
				this.fullIridium_1_plus.SetActive(false);
			}
			if (SkillTree.painiteSpawn_purchaseCount >= 1)
			{
				this.painiteSpawn_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalIridiumBars >= SkillTree.painiteSpawn_price)
			{
				if (SkillTree.iridiumSpawn_purchased)
				{
					this.painiteSpawn_plus.SetActive(true);
				}
				else
				{
					this.painiteSpawn_plus.SetActive(false);
				}
			}
			else
			{
				this.painiteSpawn_plus.SetActive(false);
			}
			if (SkillTree.painiteChunk_1_purchaseCount >= 3)
			{
				this.painiteChunk_1_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalPainiteBars >= SkillTree.painiteChunk_1_price)
			{
				if (SkillTree.painiteSpawn_purchased)
				{
					this.painiteChunk_1_plus.SetActive(true);
				}
				else
				{
					this.painiteChunk_1_plus.SetActive(false);
				}
			}
			else
			{
				this.painiteChunk_1_plus.SetActive(false);
			}
			if (SkillTree.fullPainite_1_purchaseCount >= 2)
			{
				this.fullPainite_1_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalPainiteBars >= SkillTree.fullPainite_1_price)
			{
				if (SkillTree.painiteSpawn_purchased)
				{
					this.fullPainite_1_plus.SetActive(true);
				}
				else
				{
					this.fullPainite_1_plus.SetActive(false);
				}
			}
			else
			{
				this.fullPainite_1_plus.SetActive(false);
			}
			if (SkillTree.improvedPickaxe_1_purchaseCount >= 3)
			{
				this.improvedPickaxe_1_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalGoldBars >= SkillTree.improvedPickaxe_1_price)
			{
				this.improvedPickaxe_1_plus.SetActive(true);
			}
			else
			{
				this.improvedPickaxe_1_plus.SetActive(false);
			}
			if (SkillTree.improvedPickaxe_2_purchaseCount >= 3)
			{
				this.improvedPickaxe_2_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalGoldBars >= SkillTree.improvedPickaxe_2_price)
			{
				this.improvedPickaxe_2_plus.SetActive(true);
			}
			else
			{
				this.improvedPickaxe_2_plus.SetActive(false);
			}
			if (SkillTree.improvedPickaxe_3_purchaseCount >= 3)
			{
				this.improvedPickaxe_3_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalCopperBars >= SkillTree.improvedPickaxe_3_price)
			{
				if (SkillTree.spawnCopper_purchased)
				{
					this.improvedPickaxe_3_plus.SetActive(true);
				}
				else
				{
					this.improvedPickaxe_3_plus.SetActive(false);
				}
			}
			else
			{
				this.improvedPickaxe_3_plus.SetActive(false);
			}
			if (SkillTree.improvedPickaxe_4_purchaseCount >= 3)
			{
				this.improvedPickaxe_4_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalIronBars >= SkillTree.improvedPickaxe_4_price)
			{
				if (SkillTree.spawnIron_purchased)
				{
					this.improvedPickaxe_4_plus.SetActive(true);
				}
				else
				{
					this.improvedPickaxe_4_plus.SetActive(false);
				}
			}
			else
			{
				this.improvedPickaxe_4_plus.SetActive(false);
			}
			if (SkillTree.improvedPickaxe_5_purchaseCount >= 3)
			{
				this.improvedPickaxe_5_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalCobaltBars >= SkillTree.improvedPickaxe_5_price)
			{
				if (SkillTree.cobaltSpawn_purchased)
				{
					this.improvedPickaxe_5_plus.SetActive(true);
				}
				else
				{
					this.improvedPickaxe_5_plus.SetActive(false);
				}
			}
			else
			{
				this.improvedPickaxe_5_plus.SetActive(false);
			}
			if (SkillTree.improvedPickaxe_6_purchaseCount >= 3)
			{
				this.improvedPickaxe_6_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalPainiteBars >= SkillTree.improvedPickaxe_6_price)
			{
				if (SkillTree.painiteSpawn_purchased)
				{
					this.improvedPickaxe_6_plus.SetActive(true);
				}
				else
				{
					this.improvedPickaxe_6_plus.SetActive(false);
				}
			}
			else
			{
				this.improvedPickaxe_6_plus.SetActive(false);
			}
			if (SkillTree.biggerMiningErea_1_purchaseCount >= 5)
			{
				this.biggerMiningErea_1_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalGoldBars >= SkillTree.biggerMiningErea_1_price)
			{
				this.biggerMiningErea_1_plus.SetActive(true);
			}
			else
			{
				this.biggerMiningErea_1_plus.SetActive(false);
			}
			if (SkillTree.biggerMiningErea_2_purchaseCount >= 5)
			{
				this.biggerMiningErea_2_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalCobaltBars >= SkillTree.biggerMiningErea_2_price)
			{
				if (SkillTree.cobaltSpawn_purchased)
				{
					this.biggerMiningErea_2_plus.SetActive(true);
				}
				else
				{
					this.biggerMiningErea_2_plus.SetActive(false);
				}
			}
			else
			{
				this.biggerMiningErea_2_plus.SetActive(false);
			}
			if (SkillTree.biggerMiningErea_3_purchaseCount >= 5)
			{
				this.biggerMiningErea_3_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalCopperBars >= SkillTree.biggerMiningErea_3_price)
			{
				if (SkillTree.spawnCopper_purchased)
				{
					this.biggerMiningErea_3_plus.SetActive(true);
				}
				else
				{
					this.biggerMiningErea_3_plus.SetActive(false);
				}
			}
			else
			{
				this.biggerMiningErea_3_plus.SetActive(false);
			}
			if (SkillTree.biggerMiningErea_4_purchaseCount >= 5)
			{
				this.biggerMiningErea_4_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalIsmiumBar >= SkillTree.biggerMiningErea_4_price)
			{
				if (SkillTree.ismiumSpawn_purchased)
				{
					this.biggerMiningErea_4_plus.SetActive(true);
				}
				else
				{
					this.biggerMiningErea_4_plus.SetActive(false);
				}
			}
			else
			{
				this.biggerMiningErea_4_plus.SetActive(false);
			}
			if (SkillTree.shootCircleChance_purchaseCount >= 1)
			{
				this.shootCircleChance_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalCopperBars >= SkillTree.shootCircleChance_price)
			{
				if (SkillTree.spawnCopper_purchased)
				{
					this.shootCircleChance_plus.SetActive(true);
				}
				else
				{
					this.shootCircleChance_plus.SetActive(false);
				}
			}
			else
			{
				this.shootCircleChance_plus.SetActive(false);
			}
			if (SkillTree.increaseAndDecreaseMinignErea_purchaseCount >= 1)
			{
				this.increaseAndDecreaseMinignErea_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalIronBars >= SkillTree.increaseAndDecreaseMinignErea_price)
			{
				if (SkillTree.spawnIron_purchased)
				{
					this.increaseAndDecreaseMinignErea_plus.SetActive(true);
				}
				else
				{
					this.increaseAndDecreaseMinignErea_plus.SetActive(false);
				}
			}
			else
			{
				this.increaseAndDecreaseMinignErea_plus.SetActive(false);
			}
			if (SkillTree.spawnRockEveryXrock_1_purchaseCount >= 1)
			{
				this.spawnRockEveryXrock_1_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalGoldBars >= SkillTree.spawnRockEveryXrock_1_price)
			{
				this.spawnRockEveryXrock_1_plus.SetActive(true);
			}
			else
			{
				this.spawnRockEveryXrock_1_plus.SetActive(false);
			}
			if (SkillTree.spawnRockEveryXrock_2_purchaseCount >= 1)
			{
				this.spawnRockEveryXrock_2_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalCopperBars >= SkillTree.spawnRockEveryXrock_2_price)
			{
				if (SkillTree.spawnCopper_purchased)
				{
					this.spawnRockEveryXrock_2_plus.SetActive(true);
				}
				else
				{
					this.spawnRockEveryXrock_2_plus.SetActive(false);
				}
			}
			else
			{
				this.spawnRockEveryXrock_2_plus.SetActive(false);
			}
			if (SkillTree.spawnRockEveryXrock_3_purchaseCount >= 1)
			{
				this.spawnRockEveryXrock_3_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalGoldBars >= SkillTree.spawnRockEveryXrock_3_price)
			{
				this.spawnRockEveryXrock_3_plus.SetActive(true);
			}
			else
			{
				this.spawnRockEveryXrock_3_plus.SetActive(false);
			}
			if (SkillTree.spawnXRockEveryXSecond_1_purchaseCount >= 1)
			{
				this.spawnXRockEveryXSecond_1_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalGoldBars >= SkillTree.spawnXRockEveryXSecond_1_price)
			{
				this.spawnXRockEveryXSecond_1_plus.SetActive(true);
			}
			else
			{
				this.spawnXRockEveryXSecond_1_plus.SetActive(false);
			}
			if (SkillTree.spawnXRockEveryXSecond_2_purchaseCount >= 1)
			{
				this.spawnXRockEveryXSecond_2_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalGoldBars >= SkillTree.spawnXRockEveryXSecond_2_price)
			{
				this.spawnXRockEveryXSecond_2_plus.SetActive(true);
			}
			else
			{
				this.spawnXRockEveryXSecond_2_plus.SetActive(false);
			}
			if (SkillTree.spawnXRockEveryXSecond_3_purchaseCount >= 1)
			{
				this.spawnXRockEveryXSecond_3_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalIridiumBars >= SkillTree.spawnXRockEveryXSecond_3_price)
			{
				if (SkillTree.iridiumSpawn_purchased)
				{
					this.spawnXRockEveryXSecond_3_plus.SetActive(true);
				}
				else
				{
					this.spawnXRockEveryXSecond_3_plus.SetActive(false);
				}
			}
			else
			{
				this.spawnXRockEveryXSecond_3_plus.SetActive(false);
			}
			if (SkillTree.chanceToSpawnRockWhenMined_1_purchaseCount >= 6)
			{
				this.chanceToSpawnRockWhenMined_1_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalGoldBars >= SkillTree.chanceToSpawnRockWhenMined_1_price)
			{
				this.chanceToSpawnRockWhenMined_1_plus.SetActive(true);
			}
			else
			{
				this.chanceToSpawnRockWhenMined_1_plus.SetActive(false);
			}
			if (SkillTree.chanceToSpawnRockWhenMined_2_purchaseCount >= 3)
			{
				this.chanceToSpawnRockWhenMined_2_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalCobaltBars >= SkillTree.chanceToSpawnRockWhenMined_2_price)
			{
				if (SkillTree.cobaltSpawn_purchased)
				{
					this.chanceToSpawnRockWhenMined_2_plus.SetActive(true);
				}
				else
				{
					this.chanceToSpawnRockWhenMined_2_plus.SetActive(false);
				}
			}
			else
			{
				this.chanceToSpawnRockWhenMined_2_plus.SetActive(false);
			}
			if (SkillTree.chanceToSpawnRockWhenMined_3_purchaseCount >= 3)
			{
				this.chanceToSpawnRockWhenMined_3_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalIsmiumBar >= SkillTree.chanceToSpawnRockWhenMined_3_price)
			{
				if (SkillTree.ismiumSpawn_purchased)
				{
					this.chanceToSpawnRockWhenMined_3_plus.SetActive(true);
				}
				else
				{
					this.chanceToSpawnRockWhenMined_3_plus.SetActive(false);
				}
			}
			else
			{
				this.chanceToSpawnRockWhenMined_3_plus.SetActive(false);
			}
			if (SkillTree.chanceToSpawnRockWhenMined_4_purchaseCount >= 3)
			{
				this.chanceToSpawnRockWhenMined_4_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalGoldBars >= SkillTree.chanceToSpawnRockWhenMined_4_price)
			{
				this.chanceToSpawnRockWhenMined_4_plus.SetActive(true);
			}
			else
			{
				this.chanceToSpawnRockWhenMined_4_plus.SetActive(false);
			}
			if (SkillTree.chanceToSpawnRockWhenMined_5_purchaseCount >= 3)
			{
				this.chanceToSpawnRockWhenMined_5_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalIronBars >= SkillTree.chanceToSpawnRockWhenMined_5_price)
			{
				if (SkillTree.spawnIron_purchased)
				{
					this.chanceToSpawnRockWhenMined_5_plus.SetActive(true);
				}
				else
				{
					this.chanceToSpawnRockWhenMined_5_plus.SetActive(false);
				}
			}
			else
			{
				this.chanceToSpawnRockWhenMined_5_plus.SetActive(false);
			}
			if (SkillTree.chanceToSpawnRockWhenMined_6_purchaseCount >= 1)
			{
				this.chanceToSpawnRockWhenMined_6_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalCopperBars >= SkillTree.chanceToSpawnRockWhenMined_6_price)
			{
				if (SkillTree.spawnCopper_purchased)
				{
					this.chanceToSpawnRockWhenMined_6_plus.SetActive(true);
				}
				else
				{
					this.chanceToSpawnRockWhenMined_6_plus.SetActive(false);
				}
			}
			else
			{
				this.chanceToSpawnRockWhenMined_6_plus.SetActive(false);
			}
			if (SkillTree.chanceToMineRandomRock_1_purchaseCount >= 4)
			{
				this.chanceToMineRandomRock_1_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalCopperBars >= SkillTree.chanceToMineRandomRock_1_price)
			{
				if (SkillTree.spawnCopper_purchased)
				{
					this.chanceToMineRandomRock_1_plus.SetActive(true);
				}
				else
				{
					this.chanceToMineRandomRock_1_plus.SetActive(false);
				}
			}
			else
			{
				this.chanceToMineRandomRock_1_plus.SetActive(false);
			}
			if (SkillTree.chanceToMineRandomRock_2_purchaseCount >= 3)
			{
				this.chanceToMineRandomRock_2_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalCobaltBars >= SkillTree.chanceToMineRandomRock_2_price)
			{
				if (SkillTree.cobaltSpawn_purchased)
				{
					this.chanceToMineRandomRock_2_plus.SetActive(true);
				}
				else
				{
					this.chanceToMineRandomRock_2_plus.SetActive(false);
				}
			}
			else
			{
				this.chanceToMineRandomRock_2_plus.SetActive(false);
			}
			if (SkillTree.chanceToMineRandomRock_3_purchaseCount >= 3)
			{
				this.chanceToMineRandomRock_3_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalIronBars >= SkillTree.chanceToMineRandomRock_3_price)
			{
				if (SkillTree.spawnIron_purchased)
				{
					this.chanceToMineRandomRock_3_plus.SetActive(true);
				}
				else
				{
					this.chanceToMineRandomRock_3_plus.SetActive(false);
				}
			}
			else
			{
				this.chanceToMineRandomRock_3_plus.SetActive(false);
			}
			if (SkillTree.chanceToMineRandomRock_4_purchaseCount >= 3)
			{
				this.chanceToMineRandomRock_4_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalIsmiumBar >= SkillTree.chanceToMineRandomRock_4_price)
			{
				if (SkillTree.ismiumSpawn_purchased)
				{
					this.chanceToMineRandomRock_4_plus.SetActive(true);
				}
				else
				{
					this.chanceToMineRandomRock_4_plus.SetActive(false);
				}
			}
			else
			{
				this.chanceToMineRandomRock_4_plus.SetActive(false);
			}
			if (SkillTree.spawnPickaxeEverySecond_1_purchaseCount >= 1)
			{
				this.spawnPickaxeEverySecond_1_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalGoldBars >= SkillTree.spawnPickaxeEverySecond_1_price)
			{
				this.spawnPickaxeEverySecond_1_plus.SetActive(true);
			}
			else
			{
				this.spawnPickaxeEverySecond_1_plus.SetActive(false);
			}
			if (SkillTree.spawnPickaxeEverySecond_2_purchaseCount >= 1)
			{
				this.spawnPickaxeEverySecond_2_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalGoldBars >= SkillTree.spawnPickaxeEverySecond_2_price)
			{
				this.spawnPickaxeEverySecond_2_plus.SetActive(true);
			}
			else
			{
				this.spawnPickaxeEverySecond_2_plus.SetActive(false);
			}
			if (SkillTree.spawnPickaxeEverySecond_3_purchaseCount >= 1)
			{
				this.spawnPickaxeEverySecond_3_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalGoldBars >= SkillTree.spawnPickaxeEverySecond_3_price)
			{
				this.spawnPickaxeEverySecond_3_plus.SetActive(true);
			}
			else
			{
				this.spawnPickaxeEverySecond_3_plus.SetActive(false);
			}
			if (SkillTree.moreTime_1_purchaseCount >= 5)
			{
				this.moreTime_1_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalGoldBars >= SkillTree.moreTime_1_price)
			{
				this.moreTime_1_plus.SetActive(true);
			}
			else
			{
				this.moreTime_1_plus.SetActive(false);
			}
			if (SkillTree.moreTime_2_purchaseCount >= 4)
			{
				this.moreTime_2_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalCopperBars >= SkillTree.moreTime_2_price)
			{
				if (SkillTree.spawnCopper_purchased)
				{
					this.moreTime_2_plus.SetActive(true);
				}
				else
				{
					this.moreTime_2_plus.SetActive(false);
				}
			}
			else
			{
				this.moreTime_2_plus.SetActive(false);
			}
			if (SkillTree.moreTime_3_purchaseCount >= 3)
			{
				this.moreTime_3_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalCobaltBars >= SkillTree.moreTime_3_price)
			{
				if (SkillTree.cobaltSpawn_purchased)
				{
					this.moreTime_3_plus.SetActive(true);
				}
				else
				{
					this.moreTime_3_plus.SetActive(false);
				}
			}
			else
			{
				this.moreTime_3_plus.SetActive(false);
			}
			if (SkillTree.moreTime_4_purchaseCount >= 3)
			{
				this.moreTime_4_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalUraniumBars >= SkillTree.moreTime_4_price)
			{
				if (SkillTree.uraniumSpawn_purchased)
				{
					this.moreTime_4_plus.SetActive(true);
				}
				else
				{
					this.moreTime_4_plus.SetActive(false);
				}
			}
			else
			{
				this.moreTime_4_plus.SetActive(false);
			}
			if (SkillTree.chanceToAdd1SecondEverySecond_purchaseCount >= 1)
			{
				this.chanceToAdd1SecondEverySecond_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalIronBars >= SkillTree.chanceToAdd1SecondEverySecond_price)
			{
				if (SkillTree.spawnIron_purchased)
				{
					this.chanceToAdd1SecondEverySecond_plus.SetActive(true);
				}
				else
				{
					this.chanceToAdd1SecondEverySecond_plus.SetActive(false);
				}
			}
			else
			{
				this.chanceToAdd1SecondEverySecond_plus.SetActive(false);
			}
			if (SkillTree.chanceAdd1SecondEveryRockMined_purchaseCount >= 1)
			{
				this.chanceAdd1SecondEveryRockMined_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalGoldBars >= SkillTree.chanceAdd1SecondEveryRockMined_price)
			{
				this.chanceAdd1SecondEveryRockMined_plus.SetActive(true);
			}
			else
			{
				this.chanceAdd1SecondEveryRockMined_plus.SetActive(false);
			}
			if (SkillTree.doubleXpGoldChance_1_purchaseCount >= 3)
			{
				this.doubleXpGoldChance_1_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalGoldBars >= SkillTree.doubleXpGoldChance_1_price)
			{
				this.doubleXpGoldChance_1_plus.SetActive(true);
			}
			else
			{
				this.doubleXpGoldChance_1_plus.SetActive(false);
			}
			if (SkillTree.doubleXpGoldChance_2_purchaseCount >= 3)
			{
				this.doubleXpGoldChance_2_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalCobaltBars >= SkillTree.doubleXpGoldChance_2_price)
			{
				if (SkillTree.cobaltSpawn_purchased)
				{
					this.doubleXpGoldChance_2_plus.SetActive(true);
				}
				else
				{
					this.doubleXpGoldChance_2_plus.SetActive(false);
				}
			}
			else
			{
				this.doubleXpGoldChance_2_plus.SetActive(false);
			}
			if (SkillTree.doubleXpGoldChance_3_purchaseCount >= 3)
			{
				this.doubleXpGoldChance_3_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalGoldBars >= SkillTree.doubleXpGoldChance_3_price)
			{
				this.doubleXpGoldChance_3_plus.SetActive(true);
			}
			else
			{
				this.doubleXpGoldChance_3_plus.SetActive(false);
			}
			if (SkillTree.doubleXpGoldChance_4_purchaseCount >= 3)
			{
				this.doubleXpGoldChance_4_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalPainiteBars >= SkillTree.doubleXpGoldChance_4_price)
			{
				if (SkillTree.painiteSpawn_purchased)
				{
					this.doubleXpGoldChance_4_plus.SetActive(true);
				}
				else
				{
					this.doubleXpGoldChance_4_plus.SetActive(false);
				}
			}
			else
			{
				this.doubleXpGoldChance_4_plus.SetActive(false);
			}
			if (SkillTree.doubleXpGoldChance_5_purchaseCount >= 3)
			{
				this.doubleXpGoldChance_5_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalIridiumBars >= SkillTree.doubleXpGoldChance_5_price)
			{
				if (SkillTree.iridiumSpawn_purchased)
				{
					this.doubleXpGoldChance_5_plus.SetActive(true);
				}
				else
				{
					this.doubleXpGoldChance_5_plus.SetActive(false);
				}
			}
			else
			{
				this.doubleXpGoldChance_5_plus.SetActive(false);
			}
			if (SkillTree.allProjectileDoubleDamageChance_purchaseCount >= 1)
			{
				this.allProjectileDoubleDamageChance_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalIridiumBars >= SkillTree.allProjectileDoubleDamageChance_price)
			{
				if (SkillTree.iridiumSpawn_purchased)
				{
					this.allProjectileDoubleDamageChance_plus.SetActive(true);
				}
				else
				{
					this.allProjectileDoubleDamageChance_plus.SetActive(false);
				}
			}
			else
			{
				this.allProjectileDoubleDamageChance_plus.SetActive(false);
			}
			if (SkillTree.allProjectileTriggerChance_purchaseCount >= 1)
			{
				this.allProjectileTriggerChance_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalPainiteBars >= SkillTree.allProjectileTriggerChance_price)
			{
				if (SkillTree.painiteSpawn_purchased)
				{
					this.allProjectileTriggerChance_plus.SetActive(true);
				}
				else
				{
					this.allProjectileTriggerChance_plus.SetActive(false);
				}
			}
			else
			{
				this.allProjectileTriggerChance_plus.SetActive(false);
			}
			if (SkillTree.pickaxeDoubleDamageChance_1_purchaseCount >= 3)
			{
				this.pickaxeDoubleDamageChance_1_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalGoldBars >= SkillTree.pickaxeDoubleDamageChance_1_price)
			{
				this.pickaxeDoubleDamageChance_1_plus.SetActive(true);
			}
			else
			{
				this.pickaxeDoubleDamageChance_1_plus.SetActive(false);
			}
			if (SkillTree.pickaxeDoubleDamageChance_2_purchaseCount >= 3)
			{
				this.pickaxeDoubleDamageChance_2_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalCobaltBars >= SkillTree.pickaxeDoubleDamageChance_2_price)
			{
				if (SkillTree.cobaltSpawn_purchased)
				{
					this.pickaxeDoubleDamageChance_2_plus.SetActive(true);
				}
				else
				{
					this.pickaxeDoubleDamageChance_2_plus.SetActive(false);
				}
			}
			else
			{
				this.pickaxeDoubleDamageChance_2_plus.SetActive(false);
			}
			if (SkillTree.intaMineChance_1_purchaseCount >= 3)
			{
				this.intaMineChance_1_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalCopperBars >= SkillTree.intaMineChance_1_price)
			{
				if (SkillTree.spawnCopper_purchased)
				{
					this.intaMineChance_1_plus.SetActive(true);
				}
				else
				{
					this.intaMineChance_1_plus.SetActive(false);
				}
			}
			else
			{
				this.intaMineChance_1_plus.SetActive(false);
			}
			if (SkillTree.intaMineChance_2_purchaseCount >= 3)
			{
				this.intaMineChance_2_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalIronBars >= SkillTree.intaMineChance_2_price)
			{
				if (SkillTree.spawnIron_purchased)
				{
					this.intaMineChance_2_plus.SetActive(true);
				}
				else
				{
					this.intaMineChance_2_plus.SetActive(false);
				}
			}
			else
			{
				this.intaMineChance_2_plus.SetActive(false);
			}
			if (SkillTree.increaseSpawnChanceAllRocks_purchaseCount >= 1)
			{
				this.increaseSpawnChanceAllRocks_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalGoldBars >= SkillTree.increaseSpawnChanceAllRocks_price)
			{
				this.increaseSpawnChanceAllRocks_plus.SetActive(true);
			}
			else
			{
				this.increaseSpawnChanceAllRocks_plus.SetActive(false);
			}
			if (SkillTree.craft2Material_purchaseCount >= 1)
			{
				this.craft2Material_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalGoldBars >= SkillTree.craft2Material_price)
			{
				this.craft2Material_plus.SetActive(true);
			}
			else
			{
				this.craft2Material_plus.SetActive(false);
			}
			if (SkillTree.finalUpgrade_purchaseCount >= 1)
			{
				this.finalUpgrade_plus.SetActive(false);
			}
			else if (GoldAndOreMechanics.totalPainiteBars >= SkillTree.finalUpgrade_price)
			{
				if (SkillTree.painiteSpawn_purchased)
				{
					this.finalUpgrade_plus.SetActive(true);
				}
				else
				{
					this.finalUpgrade_plus.SetActive(false);
				}
			}
			else
			{
				this.finalUpgrade_plus.SetActive(false);
			}
			if (GoldAndOreMechanics.totalGoldBars >= SkillTree.endlessGold_price)
			{
				this.endlessGold_pluss.SetActive(true);
			}
			else
			{
				this.endlessGold_pluss.SetActive(false);
			}
			if (GoldAndOreMechanics.totalCopperBars >= SkillTree.endlessCopper_price)
			{
				this.endlessCopper_pluss.SetActive(true);
			}
			else
			{
				this.endlessCopper_pluss.SetActive(false);
			}
			if (GoldAndOreMechanics.totalIronBars >= SkillTree.endlessIron_price)
			{
				this.endlessIron_pluss.SetActive(true);
			}
			else
			{
				this.endlessIron_pluss.SetActive(false);
			}
			if (GoldAndOreMechanics.totalCobaltBars >= SkillTree.endlessCobalt_price)
			{
				this.endlessCobalt_pluss.SetActive(true);
			}
			else
			{
				this.endlessCobalt_pluss.SetActive(false);
			}
			if (GoldAndOreMechanics.totalUraniumBars >= SkillTree.endlessUranium_price)
			{
				this.endlessUranium_pluss.SetActive(true);
			}
			else
			{
				this.endlessUranium_pluss.SetActive(false);
			}
			if (GoldAndOreMechanics.totalIsmiumBar >= SkillTree.endlessIsmium_price)
			{
				this.endlessIsmium_pluss.SetActive(true);
			}
			else
			{
				this.endlessIsmium_pluss.SetActive(false);
			}
			if (GoldAndOreMechanics.totalIridiumBars >= SkillTree.endlessIridium_price)
			{
				this.endlessIridium_pluss.SetActive(true);
			}
			else
			{
				this.endlessIridium_pluss.SetActive(false);
			}
			if (GoldAndOreMechanics.totalPainiteBars >= SkillTree.endlessPainite_price)
			{
				this.endlessPainite_pluss.SetActive(true);
			}
			else
			{
				this.endlessPainite_pluss.SetActive(false);
			}
			string str = "yo";
			if (Tooltip.goldPriceST)
			{
				if (GoldAndOreMechanics.totalGoldBars >= LocalizationScript.currentSkillTreePrice)
				{
					str = "<color=green>";
				}
				else
				{
					str = "<color=red>";
				}
			}
			if (Tooltip.copperPriceST)
			{
				if (GoldAndOreMechanics.totalCopperBars >= LocalizationScript.currentSkillTreePrice)
				{
					str = "<color=green>";
				}
				else
				{
					str = "<color=red>";
				}
			}
			if (Tooltip.ironPriceST)
			{
				if (GoldAndOreMechanics.totalIronBars >= LocalizationScript.currentSkillTreePrice)
				{
					str = "<color=green>";
				}
				else
				{
					str = "<color=red>";
				}
			}
			if (Tooltip.cobaltPriceST)
			{
				if (GoldAndOreMechanics.totalCobaltBars >= LocalizationScript.currentSkillTreePrice)
				{
					str = "<color=green>";
				}
				else
				{
					str = "<color=red>";
				}
			}
			if (Tooltip.uraniumPriceST)
			{
				if (GoldAndOreMechanics.totalUraniumBars >= LocalizationScript.currentSkillTreePrice)
				{
					str = "<color=green>";
				}
				else
				{
					str = "<color=red>";
				}
			}
			if (Tooltip.ismiumPriceST)
			{
				if (GoldAndOreMechanics.totalIsmiumBar >= LocalizationScript.currentSkillTreePrice)
				{
					str = "<color=green>";
				}
				else
				{
					str = "<color=red>";
				}
			}
			if (Tooltip.iridiumPriceST)
			{
				if (GoldAndOreMechanics.totalIridiumBars >= LocalizationScript.currentSkillTreePrice)
				{
					str = "<color=green>";
				}
				else
				{
					str = "<color=red>";
				}
			}
			if (Tooltip.painitePriceST)
			{
				if (GoldAndOreMechanics.totalPainiteBars >= LocalizationScript.currentSkillTreePrice)
				{
					str = "<color=green>";
				}
				else
				{
					str = "<color=red>";
				}
			}
			if (Tooltip.hoveringEndless == 0)
			{
				this.skillTreePrice_text.text = LocalizationScript.price + " " + str + FormatNumbers.FormatPoints(LocalizationScript.currentSkillTreePrice);
				return;
			}
			if (Tooltip.hoveringEndless == 1)
			{
				if (GoldAndOreMechanics.totalGoldBars >= SkillTree.endlessGold_price)
				{
					str = "<color=green>";
				}
				else
				{
					str = "<color=red>";
				}
				this.skillTreePrice_text.text = LocalizationScript.price + " " + str + FormatNumbers.FormatPoints(SkillTree.endlessGold_price);
			}
			if (Tooltip.hoveringEndless == 8)
			{
				if (GoldAndOreMechanics.totalPainiteBars >= SkillTree.endlessPainite_price)
				{
					str = "<color=green>";
				}
				else
				{
					str = "<color=red>";
				}
				this.skillTreePrice_text.text = LocalizationScript.price + " " + str + FormatNumbers.FormatPoints(SkillTree.endlessPainite_price);
			}
			if (Tooltip.hoveringEndless == 2)
			{
				if (GoldAndOreMechanics.totalCopperBars >= SkillTree.endlessCopper_price)
				{
					str = "<color=green>";
				}
				else
				{
					str = "<color=red>";
				}
				this.skillTreePrice_text.text = LocalizationScript.price + " " + str + FormatNumbers.FormatPoints(SkillTree.endlessCopper_price);
			}
			if (Tooltip.hoveringEndless == 7)
			{
				if (GoldAndOreMechanics.totalIridiumBars >= SkillTree.endlessIridium_price)
				{
					str = "<color=green>";
				}
				else
				{
					str = "<color=red>";
				}
				this.skillTreePrice_text.text = LocalizationScript.price + " " + str + FormatNumbers.FormatPoints(SkillTree.endlessIridium_price);
			}
			if (Tooltip.hoveringEndless == 3)
			{
				if (GoldAndOreMechanics.totalIronBars >= SkillTree.endlessIron_price)
				{
					str = "<color=green>";
				}
				else
				{
					str = "<color=red>";
				}
				this.skillTreePrice_text.text = LocalizationScript.price + " " + str + FormatNumbers.FormatPoints(SkillTree.endlessIron_price);
			}
			if (Tooltip.hoveringEndless == 6)
			{
				if (GoldAndOreMechanics.totalIsmiumBar >= SkillTree.endlessIsmium_price)
				{
					str = "<color=green>";
				}
				else
				{
					str = "<color=red>";
				}
				this.skillTreePrice_text.text = LocalizationScript.price + " " + str + FormatNumbers.FormatPoints(SkillTree.endlessIsmium_price);
			}
			if (Tooltip.hoveringEndless == 4)
			{
				if (GoldAndOreMechanics.totalCobaltBars >= SkillTree.endlessCobalt_price)
				{
					str = "<color=green>";
				}
				else
				{
					str = "<color=red>";
				}
				this.skillTreePrice_text.text = LocalizationScript.price + " " + str + FormatNumbers.FormatPoints(SkillTree.endlessCobalt_price);
			}
			if (Tooltip.hoveringEndless == 5)
			{
				if (GoldAndOreMechanics.totalUraniumBars >= SkillTree.endlessUranium_price)
				{
					str = "<color=green>";
				}
				else
				{
					str = "<color=red>";
				}
				this.skillTreePrice_text.text = LocalizationScript.price + " " + str + FormatNumbers.FormatPoints(SkillTree.endlessUranium_price);
			}
		}
	}

	// Token: 0x060001C5 RID: 453 RVA: 0x00044C94 File Offset: 0x00042E94
	public void ReduceBars()
	{
		if (Tooltip.goldPriceST)
		{
			GoldAndOreMechanics.totalGoldBars -= LocalizationScript.currentHoverPrice;
		}
		if (Tooltip.copperPriceST)
		{
			GoldAndOreMechanics.totalCopperBars -= LocalizationScript.currentHoverPrice;
		}
		if (Tooltip.ironPriceST)
		{
			GoldAndOreMechanics.totalIronBars -= LocalizationScript.currentHoverPrice;
		}
		if (Tooltip.cobaltPriceST)
		{
			GoldAndOreMechanics.totalCobaltBars -= LocalizationScript.currentHoverPrice;
		}
		if (Tooltip.uraniumPriceST)
		{
			GoldAndOreMechanics.totalUraniumBars -= LocalizationScript.currentHoverPrice;
		}
		if (Tooltip.ismiumPriceST)
		{
			GoldAndOreMechanics.totalIsmiumBar -= LocalizationScript.currentHoverPrice;
		}
		if (Tooltip.iridiumPriceST)
		{
			GoldAndOreMechanics.totalIridiumBars -= LocalizationScript.currentHoverPrice;
		}
		if (Tooltip.painitePriceST)
		{
			GoldAndOreMechanics.totalPainiteBars -= LocalizationScript.currentHoverPrice;
		}
	}

	// Token: 0x060001C6 RID: 454 RVA: 0x00044D5C File Offset: 0x00042F5C
	public void CloseTooltip()
	{
		this.audioManager.Play("UI_Click1");
		this.skillTreeDark.SetActive(false);
		this.skillTreeTooltip.SetActive(false);
		this.tooltipPurchase.SetActive(false);
		this.tooltipClose.SetActive(false);
	}

	// Token: 0x060001C7 RID: 455 RVA: 0x00044DA9 File Offset: 0x00042FA9
	public void PurchaseMobileBTN()
	{
		SkillTree.pressedPurchaseMobile = true;
		this.PurchaseUpgrade(SkillTree.upgradeNameMobile);
		this.CheckPosOfBnts();
	}

	// Token: 0x060001C8 RID: 456 RVA: 0x00044DC4 File Offset: 0x00042FC4
	public void CheckPosOfBnts()
	{
		if (LocalizationScript.currentPurchaseCount < LocalizationScript.currentTotalPurchaseCount)
		{
			this.tooltipPurchase.SetActive(true);
			this.tooltipPurchase.transform.localPosition = new Vector2(-100f, -120f);
			this.tooltipClose.SetActive(true);
			this.tooltipClose.transform.localPosition = new Vector2(100f, -120f);
			return;
		}
		this.tooltipPurchase.SetActive(false);
		this.tooltipClose.SetActive(true);
		this.tooltipClose.transform.localPosition = new Vector2(0f, -120f);
	}

	// Token: 0x060001C9 RID: 457 RVA: 0x00044E7C File Offset: 0x0004307C
	public void PurchaseUpgrade(string upgradeName)
	{
		if (MobileAndTesting.isMobile)
		{
			this.audioManager.Play("UI_Click1");
			SkillTree.upgradeNameMobile = upgradeName;
			this.skillTreeDark.SetActive(true);
			this.skillTreeTooltip.SetActive(true);
			this.skillTreeTooltip.transform.localPosition = new Vector2(0f, 50f);
			this.skillTreeTooltip.transform.localScale = new Vector2(1.69f, 1.69f);
			this.CheckPosOfBnts();
			if (!SkillTree.pressedPurchaseMobile)
			{
				return;
			}
		}
		double num = 0.0;
		if (Tooltip.goldPriceST)
		{
			num = GoldAndOreMechanics.totalGoldBars;
		}
		if (Tooltip.copperPriceST)
		{
			num = GoldAndOreMechanics.totalCopperBars;
		}
		if (Tooltip.ironPriceST)
		{
			num = GoldAndOreMechanics.totalIronBars;
		}
		if (Tooltip.cobaltPriceST)
		{
			num = GoldAndOreMechanics.totalCobaltBars;
		}
		if (Tooltip.uraniumPriceST)
		{
			num = GoldAndOreMechanics.totalUraniumBars;
		}
		if (Tooltip.ismiumPriceST)
		{
			num = GoldAndOreMechanics.totalIsmiumBar;
		}
		if (Tooltip.iridiumPriceST)
		{
			num = GoldAndOreMechanics.totalIridiumBars;
		}
		if (Tooltip.painitePriceST)
		{
			num = GoldAndOreMechanics.totalPainiteBars;
		}
		if (upgradeName == "MoreRocks1")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.totalRocksToSpawn += LocalizationScript.rockSpawnIncrease;
			SkillTree.spawnMoreRocks_1_purchased = true;
			SkillTree.spawnMoreRocks_1_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.spawnMoreRocks_1_purchaseCount;
			this.ReduceBars();
		}
		else if (upgradeName == "MoreRocks2")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.totalRocksToSpawn += LocalizationScript.rockSpawnIncrease;
			SkillTree.spawnMoreRocks_2_purchased = true;
			SkillTree.spawnMoreRocks_2_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.spawnMoreRocks_2_purchaseCount;
			this.ReduceBars();
		}
		else if (upgradeName == "MoreRocks3")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			if (!Tutorial.pressedOkAnvil)
			{
				this.tutorialScript.SetTutorial(3);
			}
			SkillTree.totalRocksToSpawn += LocalizationScript.rockSpawnIncrease;
			this.ReduceBars();
			SkillTree.spawnMoreRocks_3_purchased = true;
			SkillTree.spawnMoreRocks_3_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.spawnMoreRocks_3_purchaseCount;
		}
		else if (upgradeName == "MoreRocks4")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.totalRocksToSpawn += LocalizationScript.rockSpawnIncrease;
			this.ReduceBars();
			SkillTree.spawnMoreRocks_4_purchased = true;
			SkillTree.spawnMoreRocks_4_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.spawnMoreRocks_4_purchaseCount;
		}
		else if (upgradeName == "MoreRocks5")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.totalRocksToSpawn += LocalizationScript.rockSpawnIncrease;
			this.ReduceBars();
			SkillTree.spawnMoreRocks_5_purchased = true;
			SkillTree.spawnMoreRocks_5_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.spawnMoreRocks_5_purchaseCount;
		}
		else if (upgradeName == "MoreRocks6")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.totalRocksToSpawn += LocalizationScript.rockSpawnIncrease;
			this.ReduceBars();
			SkillTree.spawnMoreRocks_6_purchased = true;
			SkillTree.spawnMoreRocks_6_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.spawnMoreRocks_6_purchaseCount;
		}
		else if (upgradeName == "MoreRocks7")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.totalRocksToSpawn += LocalizationScript.rockSpawnIncrease;
			this.ReduceBars();
			SkillTree.spawnMoreRocks_7_purchased = true;
			SkillTree.spawnMoreRocks_7_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.spawnMoreRocks_7_purchaseCount;
		}
		else if (upgradeName == "MoreRocks8")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.totalRocksToSpawn += LocalizationScript.rockSpawnIncrease;
			this.ReduceBars();
			SkillTree.spawnMoreRocks_8_purchased = true;
			SkillTree.spawnMoreRocks_8_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.spawnMoreRocks_8_purchaseCount;
		}
		else if (upgradeName == "MoreRocks9")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.totalRocksToSpawn += LocalizationScript.rockSpawnIncrease;
			this.ReduceBars();
			SkillTree.spawnMoreRocks_9_purchased = true;
			SkillTree.spawnMoreRocks_9_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.spawnMoreRocks_9_purchaseCount;
		}
		else if (upgradeName == "moreMeterialsFromRock_1")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.materialsFromChunkRocks += LocalizationScript.materialsFromChunkRocksIncrease;
			SkillTree.materialsFromFullRocks += LocalizationScript.materialsFromFullRocksIncrease;
			this.ReduceBars();
			SkillTree.moreMeterialsFromRock_1_purchased = true;
			SkillTree.moreMeterialsFromRock_1_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.moreMeterialsFromRock_1_purchaseCount;
		}
		else if (upgradeName == "moreMeterialsFromRock_2")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.materialsFromChunkRocks += LocalizationScript.materialsFromChunkRocksIncrease;
			SkillTree.materialsFromFullRocks += LocalizationScript.materialsFromFullRocksIncrease;
			this.ReduceBars();
			SkillTree.moreMeterialsFromRock_2_purchased = true;
			SkillTree.moreMeterialsFromRock_2_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.moreMeterialsFromRock_2_purchaseCount;
		}
		else if (upgradeName == "moreMeterialsFromRock_3")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.materialsFromChunkRocks += LocalizationScript.materialsFromChunkRocksIncrease;
			SkillTree.materialsFromFullRocks += LocalizationScript.materialsFromFullRocksIncrease;
			this.ReduceBars();
			SkillTree.moreMeterialsFromRock_3_purchased = true;
			SkillTree.moreMeterialsFromRock_3_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.moreMeterialsFromRock_3_purchaseCount;
		}
		else if (upgradeName == "moreMeterialsFromRock_4")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.materialsFromChunkRocks += LocalizationScript.materialsFromChunkRocksIncrease;
			SkillTree.materialsFromFullRocks += LocalizationScript.materialsFromFullRocksIncrease;
			this.ReduceBars();
			SkillTree.moreMeterialsFromRock_4_purchased = true;
			SkillTree.moreMeterialsFromRock_4_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.moreMeterialsFromRock_4_purchaseCount;
		}
		else if (upgradeName == "moreMeterialsFromRock_5")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.materialsFromChunkRocks += LocalizationScript.materialsFromChunkRocksIncrease;
			SkillTree.materialsFromFullRocks += LocalizationScript.materialsFromFullRocksIncrease;
			this.ReduceBars();
			SkillTree.moreMeterialsFromRock_5_purchased = true;
			SkillTree.moreMeterialsFromRock_5_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.moreMeterialsFromRock_5_purchaseCount;
		}
		else if (upgradeName == "marterialsWorthMore_1")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.materialsTotalWorth += LocalizationScript.materialsWorthIncrease;
			this.ReduceBars();
			SkillTree.marterialsWorthMore_1_purchased = true;
			SkillTree.marterialsWorthMore_1_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.marterialsWorthMore_1_purchaseCount;
		}
		else if (upgradeName == "marterialsWorthMore_2")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.materialsTotalWorth += LocalizationScript.materialsWorthIncrease;
			this.ReduceBars();
			SkillTree.marterialsWorthMore_2_purchased = true;
			SkillTree.marterialsWorthMore_2_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.marterialsWorthMore_2_purchaseCount;
		}
		else if (upgradeName == "marterialsWorthMore_3")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.materialsTotalWorth += LocalizationScript.materialsWorthIncrease;
			this.ReduceBars();
			SkillTree.marterialsWorthMore_3_purchased = true;
			SkillTree.marterialsWorthMore_3_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.marterialsWorthMore_3_purchaseCount;
		}
		else if (upgradeName == "marterialsWorthMore_4")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.materialsTotalWorth += LocalizationScript.materialsWorthIncrease;
			this.ReduceBars();
			SkillTree.marterialsWorthMore_4_purchased = true;
			SkillTree.marterialsWorthMore_4_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.marterialsWorthMore_4_purchaseCount;
		}
		else if (upgradeName == "marterialsWorthMore_5")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.materialsTotalWorth += LocalizationScript.materialsWorthIncrease;
			this.ReduceBars();
			SkillTree.marterialsWorthMore_5_purchased = true;
			SkillTree.marterialsWorthMore_5_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.marterialsWorthMore_5_purchaseCount;
		}
		else if (upgradeName == "marterialsWorthMore_6")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.materialsTotalWorth += LocalizationScript.materialsWorthIncrease;
			this.ReduceBars();
			SkillTree.marterialsWorthMore_6_purchased = true;
			SkillTree.marterialsWorthMore_6_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.marterialsWorthMore_6_purchaseCount;
		}
		else if (upgradeName == "marterialsWorthMore_7")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.materialsTotalWorth += LocalizationScript.materialsWorthIncrease;
			this.ReduceBars();
			SkillTree.marterialsWorthMore_7_purchased = true;
			SkillTree.marterialsWorthMore_7_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.marterialsWorthMore_7_purchaseCount;
		}
		else if (upgradeName == "marterialsWorthMore_8")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.materialsTotalWorth += LocalizationScript.materialsWorthIncrease;
			this.ReduceBars();
			SkillTree.marterialsWorthMore_8_purchased = true;
			SkillTree.marterialsWorthMore_8_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.marterialsWorthMore_8_purchaseCount;
		}
		else if (upgradeName == "goldChunk_1")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.goldRockChance += LocalizationScript.goldRockChanceIncrease;
			this.ReduceBars();
			SkillTree.goldChunk_1_purchased = true;
			SkillTree.goldChunk_1_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.goldChunk_1_purchaseCount;
		}
		else if (upgradeName == "goldChunk_2")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.goldRockChance += LocalizationScript.goldRockChanceIncrease;
			this.ReduceBars();
			SkillTree.goldChunk_2_purchased = true;
			SkillTree.goldChunk_2_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.goldChunk_2_purchaseCount;
		}
		else if (upgradeName == "goldChunk_3")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.goldRockChance += LocalizationScript.goldRockChanceIncrease;
			this.ReduceBars();
			SkillTree.goldChunk_3_purchased = true;
			SkillTree.goldChunk_3_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.goldChunk_3_purchaseCount;
		}
		else if (upgradeName == "goldChunk_4")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.goldRockChance += LocalizationScript.goldRockChanceIncrease;
			this.ReduceBars();
			SkillTree.goldChunk_4_purchased = true;
			SkillTree.goldChunk_4_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.goldChunk_4_purchaseCount;
		}
		else if (upgradeName == "goldChunk_5_")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.goldRockChance += LocalizationScript.goldRockChanceIncrease;
			this.ReduceBars();
			SkillTree.goldChunk_5_purchased = true;
			SkillTree.goldChunk_5_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.goldChunk_5_purchaseCount;
		}
		else if (upgradeName == "fullGold_1")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			if (!Tutorial.pressedOkAnvil)
			{
				this.tutorialScript.SetTutorial(3);
			}
			SkillTree.fullGoldRockChance += LocalizationScript.fullGoldRockChanceIncrease;
			this.ReduceBars();
			SkillTree.fullGold_1_purchased = true;
			SkillTree.fullGold_1_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.fullGold_1_purchaseCount;
		}
		else if (upgradeName == "fullGold_2")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.fullGoldRockChance += LocalizationScript.fullGoldRockChanceIncrease;
			this.ReduceBars();
			SkillTree.fullGold_2_purchased = true;
			SkillTree.fullGold_2_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.fullGold_2_purchaseCount;
		}
		else if (upgradeName == "fullGold_3")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.fullGoldRockChance += LocalizationScript.fullGoldRockChanceIncrease;
			this.ReduceBars();
			SkillTree.fullGold_3_purchased = true;
			SkillTree.fullGold_3_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.fullGold_3_purchaseCount;
		}
		else if (upgradeName == "spawnCopper")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			if (!Tutorial.pressedOkMine)
			{
				this.tutorialScript.SetTutorial(4);
			}
			this.ReduceBars();
			SkillTree.spawnCopper_purchased = true;
			SkillTree.spawnCopper_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.spawnCopper_purchaseCount;
			SkillTree.totalMaterialRocksSpawning++;
			this.fallingCopper_skillTree.SetActive(true);
			this.fallingCopper_MainMenu.SetActive(true);
		}
		else if (upgradeName == "copperChunk_1")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.copperRockChance += LocalizationScript.copperRockChanceIncrease;
			this.ReduceBars();
			SkillTree.copperChunk_1_purchased = true;
			SkillTree.copperChunk_1_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.copperChunk_1_purchaseCount;
		}
		else if (upgradeName == "copperChunk_2")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.copperRockChance += LocalizationScript.copperRockChanceIncrease;
			this.ReduceBars();
			SkillTree.copperChunk_2_purchased = true;
			SkillTree.copperChunk_2_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.copperChunk_2_purchaseCount;
		}
		else if (upgradeName == "copperChunk_3")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.copperRockChance += LocalizationScript.copperRockChanceIncrease;
			this.ReduceBars();
			SkillTree.copperChunk_3_purchased = true;
			SkillTree.copperChunk_3_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.copperChunk_3_purchaseCount;
		}
		else if (upgradeName == "fullCopper_1")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.fullCopperRockChance += LocalizationScript.fullCopperRockChanceIncrease;
			this.ReduceBars();
			SkillTree.fullCopper_1_purchased = true;
			SkillTree.fullCopper_1_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.fullCopper_1_purchaseCount;
		}
		else if (upgradeName == "fullCopper_2")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.fullCopperRockChance += LocalizationScript.fullCopperRockChanceIncrease;
			this.ReduceBars();
			SkillTree.fullCopper_2_purchased = true;
			SkillTree.fullCopper_2_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.fullCopper_2_purchaseCount;
		}
		else if (upgradeName == "fullCopper_3")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.fullCopperRockChance += LocalizationScript.fullCopperRockChanceIncrease;
			this.ReduceBars();
			SkillTree.fullCopper_3_purchased = true;
			SkillTree.fullCopper_3_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.fullCopper_3_purchaseCount;
		}
		else if (upgradeName == "spawnIron")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			this.ReduceBars();
			SkillTree.spawnIron_purchased = true;
			SkillTree.spawnIron_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.spawnIron_purchaseCount;
			SkillTree.totalMaterialRocksSpawning++;
			if (SkillTree.spawnIron_purchased)
			{
				this.fallingIron_skillTree.SetActive(true);
				this.fallingIron_MainMenu.SetActive(true);
			}
		}
		else if (upgradeName == "ironChunk_1")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.ironRockChance += LocalizationScript.ironRockChanceIncrease;
			this.ReduceBars();
			SkillTree.ironChunk_1_purchased = true;
			SkillTree.ironChunk_1_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.ironChunk_1_purchaseCount;
		}
		else if (upgradeName == "ironChunk_2")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.ironRockChance += LocalizationScript.ironRockChanceIncrease;
			this.ReduceBars();
			SkillTree.ironChunk_2_purchased = true;
			SkillTree.ironChunk_2_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.ironChunk_2_purchaseCount;
		}
		else if (upgradeName == "fullIron_1")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.fullIronRockChance += LocalizationScript.fullIronRockChanceIncrease;
			this.ReduceBars();
			SkillTree.fullIron_1_purchased = true;
			SkillTree.fullIron_1_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.fullIron_1_purchaseCount;
		}
		else if (upgradeName == "fullIron_2")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.fullIronRockChance += LocalizationScript.fullIronRockChanceIncrease;
			this.ReduceBars();
			SkillTree.fullIron_2_purchased = true;
			SkillTree.fullIron_2_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.fullIron_2_purchaseCount;
		}
		else if (upgradeName == "cobaltSpawn")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			this.ReduceBars();
			SkillTree.cobaltSpawn_purchased = true;
			SkillTree.cobaltSpawn_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.cobaltSpawn_purchaseCount;
			SkillTree.totalMaterialRocksSpawning++;
			if (SkillTree.cobaltSpawn_purchased)
			{
				this.fallingCobalt_skillTree.SetActive(true);
				this.fallingCobalt_MainMenu.SetActive(true);
			}
		}
		else if (upgradeName == "cobaltChunk_1")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.cobaltRockChance += LocalizationScript.cobaltRockChanceIncrease;
			this.ReduceBars();
			SkillTree.cobaltChunk_1_purchased = true;
			SkillTree.cobaltChunk_1_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.cobaltChunk_1_purchaseCount;
		}
		else if (upgradeName == "fullCobalt_1")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.fullCobaltRockChance += LocalizationScript.fullCobaltRockChanceIncrease;
			this.ReduceBars();
			SkillTree.fullCobalt_1_purchased = true;
			SkillTree.fullCobalt_1_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.fullCobalt_1_purchaseCount;
		}
		else if (upgradeName == "uraniumSpawn")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			this.ReduceBars();
			SkillTree.uraniumSpawn_purchased = true;
			SkillTree.uraniumSpawn_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.uraniumSpawn_purchaseCount;
			SkillTree.totalMaterialRocksSpawning++;
			if (SkillTree.uraniumSpawn_purchased)
			{
				this.fallingUranium_skillTree.SetActive(true);
				this.fallingUranium_MainMenu.SetActive(true);
			}
		}
		else if (upgradeName == "uraniumChunk_1")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.uraniumRockChance += LocalizationScript.uraniumRockChanceIncrease;
			this.ReduceBars();
			SkillTree.uraniumChunk_1_purchased = true;
			SkillTree.uraniumChunk_1_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.uraniumChunk_1_purchaseCount;
		}
		else if (upgradeName == "fullUranium_1")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.fullUraniumRockChance += LocalizationScript.fullUraniumRockChanceIncrease;
			this.ReduceBars();
			SkillTree.fullUranium_1_purchased = true;
			SkillTree.fullUranium_1_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.fullUranium_1_purchaseCount;
		}
		else if (upgradeName == "ismiumSpawn")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			this.ReduceBars();
			SkillTree.ismiumSpawn_purchased = true;
			SkillTree.ismiumSpawn_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.ismiumSpawn_purchaseCount;
			SkillTree.totalMaterialRocksSpawning++;
			if (SkillTree.ismiumSpawn_purchased)
			{
				this.fallingIsmium_skillTree.SetActive(true);
				this.fallingIsmium_MainMenu.SetActive(true);
			}
		}
		else if (upgradeName == "ismiumChunk_1")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.ismiumRockChance += LocalizationScript.ismiumRockChanceIncrease;
			this.ReduceBars();
			SkillTree.ismiumChunk_1_purchased = true;
			SkillTree.ismiumChunk_1_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.ismiumChunk_1_purchaseCount;
		}
		else if (upgradeName == "fullIsmium_1")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.fullIsmiumRockChance += LocalizationScript.fullIsmiumRockChanceIncrease;
			this.ReduceBars();
			SkillTree.fullIsmium_1_purchased = true;
			SkillTree.fullIsmium_1_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.fullIsmium_1_purchaseCount;
		}
		else if (upgradeName == "iridiumSpawn")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			this.ReduceBars();
			SkillTree.iridiumSpawn_purchased = true;
			SkillTree.iridiumSpawn_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.iridiumSpawn_purchaseCount;
			SkillTree.totalMaterialRocksSpawning++;
			if (SkillTree.iridiumSpawn_purchased)
			{
				this.fallingIridium_skillTree.SetActive(true);
				this.fallingIridium_MainMenu.SetActive(true);
			}
		}
		else if (upgradeName == "iridiumChunk_1")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.iridiumRockChance += LocalizationScript.iridiumRockChanceIncrease;
			this.ReduceBars();
			SkillTree.iridiumChunk_1_purchased = true;
			SkillTree.iridiumChunk_1_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.iridiumChunk_1_purchaseCount;
		}
		else if (upgradeName == "fullIridium_1")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.fullIridiumRockChance += LocalizationScript.fullIridiumRockChanceIncrease;
			this.ReduceBars();
			SkillTree.fullIridium_1_purchased = true;
			SkillTree.fullIridium_1_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.fullIridium_1_purchaseCount;
		}
		else if (upgradeName == "painiteSpawn")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			this.ReduceBars();
			SkillTree.painiteSpawn_purchased = true;
			SkillTree.painiteSpawn_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.painiteSpawn_purchaseCount;
			SkillTree.totalMaterialRocksSpawning++;
			if (SkillTree.painiteSpawn_purchased)
			{
				this.fallingPainite_skillTree.SetActive(true);
				this.fallingPainite_MainMenu.SetActive(true);
			}
		}
		else if (upgradeName == "painiteChunk_1")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.painiteRockChance += LocalizationScript.painiteRockChanceIncrease;
			this.ReduceBars();
			SkillTree.painiteChunk_1_purchased = true;
			SkillTree.painiteChunk_1_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.painiteChunk_1_purchaseCount;
		}
		else if (upgradeName == "fullPainite_1")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.fullPainiteRockChance += LocalizationScript.fullPainiteRockChanceIncrease;
			this.ReduceBars();
			SkillTree.fullPainite_1_purchased = true;
			SkillTree.fullPainite_1_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.fullPainite_1_purchaseCount;
		}
		else if (upgradeName == "MoreXP1")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			LevelMechanics.xpFromRock += LocalizationScript.xpIncrease;
			this.ReduceBars();
			SkillTree.moreXP_1_purchased = true;
			SkillTree.moreXP_1_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.moreXP_1_purchaseCount;
		}
		else if (upgradeName == "MoreXP2")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			LevelMechanics.xpFromRock += LocalizationScript.xpIncrease;
			this.ReduceBars();
			SkillTree.moreXP_2_purchased = true;
			SkillTree.moreXP_2_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.moreXP_2_purchaseCount;
		}
		else if (upgradeName == "MoreXP3")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			LevelMechanics.xpFromRock += LocalizationScript.xpIncrease;
			this.ReduceBars();
			SkillTree.moreXP_3_purchased = true;
			SkillTree.moreXP_3_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.moreXP_3_purchaseCount;
		}
		else if (upgradeName == "MoreXP4")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			LevelMechanics.xpFromRock += LocalizationScript.xpIncrease;
			this.ReduceBars();
			SkillTree.moreXP_4_purchased = true;
			SkillTree.moreXP_4_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.moreXP_4_purchaseCount;
		}
		else if (upgradeName == "MoreXP5")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			LevelMechanics.xpFromRock += LocalizationScript.xpIncrease;
			this.ReduceBars();
			SkillTree.moreXP_5_purchased = true;
			SkillTree.moreXP_5_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.moreXP_5_purchaseCount;
		}
		else if (upgradeName == "MoreXP6")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			LevelMechanics.xpFromRock += LocalizationScript.xpIncrease;
			this.ReduceBars();
			SkillTree.moreXP_6_purchased = true;
			SkillTree.moreXP_6_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.moreXP_6_purchaseCount;
		}
		else if (upgradeName == "MoreXP7")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			LevelMechanics.xpFromRock += LocalizationScript.xpIncrease;
			this.ReduceBars();
			SkillTree.moreXP_7_purchased = true;
			SkillTree.moreXP_7_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.moreXP_7_purchaseCount;
		}
		else if (upgradeName == "MoreXP8")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			LevelMechanics.xpFromRock += LocalizationScript.xpIncrease;
			this.ReduceBars();
			SkillTree.moreXP_8_purchased = true;
			SkillTree.moreXP_8_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.moreXP_8_purchaseCount;
		}
		else if (upgradeName == "TalentPointsPerXLevel1")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.extraTalentPointPerLevel -= LocalizationScript.moreTalentPointsReduce;
			this.ReduceBars();
			SkillTree.talentPointsPerXlevel_1_purchased = true;
			SkillTree.talentPointsPerXlevel_1_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.talentPointsPerXlevel_1_purchaseCount;
		}
		else if (upgradeName == "TalentPointsPerXLevel2")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.extraTalentPointPerLevel -= LocalizationScript.moreTalentPointsReduce;
			this.ReduceBars();
			SkillTree.talentPointsPerXlevel_2_purchased = true;
			SkillTree.talentPointsPerXlevel_2_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.talentPointsPerXlevel_2_purchaseCount;
		}
		else if (upgradeName == "TalentPointsPerXLevel3")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.extraTalentPointPerLevel -= LocalizationScript.moreTalentPointsReduce;
			this.ReduceBars();
			SkillTree.talentPointsPerXlevel_3_purchased = true;
			SkillTree.talentPointsPerXlevel_3_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.talentPointsPerXlevel_3_purchaseCount;
		}
		else if (upgradeName == "improvedPickaxe_1")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			if (!Tutorial.pressedOkAnvil)
			{
				this.tutorialScript.SetTutorial(3);
			}
			SkillTree.improvedPickaxeStrength += LocalizationScript.improvedPickaxeIncrease;
			SkillTree.reducePickaxeMineTime += LocalizationScript.improvedPickaxeIncrease;
			this.ReduceBars();
			SkillTree.improvedPickaxe_1_purchased = true;
			SkillTree.improvedPickaxe_1_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.improvedPickaxe_1_purchaseCount;
		}
		else if (upgradeName == "improvedPickaxe_2")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.improvedPickaxeStrength += LocalizationScript.improvedPickaxeIncrease;
			SkillTree.reducePickaxeMineTime += LocalizationScript.improvedPickaxeIncrease;
			this.ReduceBars();
			SkillTree.improvedPickaxe_2_purchased = true;
			SkillTree.improvedPickaxe_2_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.improvedPickaxe_2_purchaseCount;
		}
		else if (upgradeName == "improvedPickaxe_3")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.improvedPickaxeStrength += LocalizationScript.improvedPickaxeIncrease;
			SkillTree.reducePickaxeMineTime += LocalizationScript.improvedPickaxeIncrease;
			this.ReduceBars();
			SkillTree.improvedPickaxe_3_purchased = true;
			SkillTree.improvedPickaxe_3_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.improvedPickaxe_3_purchaseCount;
		}
		else if (upgradeName == "improvedPickaxe_4")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.improvedPickaxeStrength += LocalizationScript.improvedPickaxeIncrease;
			SkillTree.reducePickaxeMineTime += LocalizationScript.improvedPickaxeIncrease;
			this.ReduceBars();
			SkillTree.improvedPickaxe_4_purchased = true;
			SkillTree.improvedPickaxe_4_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.improvedPickaxe_4_purchaseCount;
		}
		else if (upgradeName == "improvedPickaxe_5")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.improvedPickaxeStrength += LocalizationScript.improvedPickaxeIncrease;
			SkillTree.reducePickaxeMineTime += LocalizationScript.improvedPickaxeIncrease;
			this.ReduceBars();
			SkillTree.improvedPickaxe_5_purchased = true;
			SkillTree.improvedPickaxe_5_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.improvedPickaxe_5_purchaseCount;
		}
		else if (upgradeName == "improvedPickaxe_6")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.improvedPickaxeStrength += LocalizationScript.improvedPickaxeIncrease;
			SkillTree.reducePickaxeMineTime += LocalizationScript.improvedPickaxeIncrease;
			this.ReduceBars();
			SkillTree.improvedPickaxe_6_purchased = true;
			SkillTree.improvedPickaxe_6_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.improvedPickaxe_6_purchaseCount;
		}
		else if (upgradeName == "biggerMiningErea_1")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.miningAreaSize += LocalizationScript.miningAreaIncrease;
			this.ReduceBars();
			SkillTree.biggerMiningErea_1_purchased = true;
			SkillTree.biggerMiningErea_1_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.biggerMiningErea_1_purchaseCount;
		}
		else if (upgradeName == "biggerMiningErea_2")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.miningAreaSize += LocalizationScript.miningAreaIncrease;
			this.ReduceBars();
			SkillTree.biggerMiningErea_2_purchased = true;
			SkillTree.biggerMiningErea_2_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.biggerMiningErea_2_purchaseCount;
		}
		else if (upgradeName == "biggerMiningErea_3")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.miningAreaSize += LocalizationScript.miningAreaIncrease;
			this.ReduceBars();
			SkillTree.biggerMiningErea_3_purchased = true;
			SkillTree.biggerMiningErea_3_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.biggerMiningErea_3_purchaseCount;
		}
		else if (upgradeName == "biggerMiningErea_4")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.miningAreaSize += LocalizationScript.miningAreaIncrease;
			this.ReduceBars();
			SkillTree.biggerMiningErea_4_purchased = true;
			SkillTree.biggerMiningErea_4_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.biggerMiningErea_4_purchaseCount;
		}
		else if (upgradeName == "shootCircleChance")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			this.ReduceBars();
			SkillTree.shootCircleChance_purchased = true;
			SkillTree.shootCircleChance_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.shootCircleChance_purchaseCount;
		}
		else if (upgradeName == "increaseAndDecreaseMinignErea")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			this.ReduceBars();
			SkillTree.increaseAndDecreaseMinignErea_purchased = true;
			SkillTree.increaseAndDecreaseMinignErea_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.increaseAndDecreaseMinignErea_purchaseCount;
		}
		else if (upgradeName == "spawnRockEveryXrock_1")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.spawnRockEveryXRock -= LocalizationScript.spawnEveryRockIncrease;
			this.ReduceBars();
			SkillTree.spawnRockEveryXrock_1_purchased = true;
			SkillTree.spawnRockEveryXrock_1_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.spawnRockEveryXrock_1_purchaseCount;
		}
		else if (upgradeName == "spawnRockEveryXrock_2")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.spawnRockEveryXRock -= LocalizationScript.spawnEveryRockIncrease;
			this.ReduceBars();
			SkillTree.spawnRockEveryXrock_2_purchased = true;
			SkillTree.spawnRockEveryXrock_2_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.spawnRockEveryXrock_2_purchaseCount;
		}
		else if (upgradeName == "spawnRockEveryXrock_3")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.spawnRockEveryXRock -= LocalizationScript.spawnEveryRockIncrease;
			this.ReduceBars();
			SkillTree.spawnRockEveryXrock_3_purchased = true;
			SkillTree.spawnRockEveryXrock_3_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.spawnRockEveryXrock_3_purchaseCount;
		}
		else if (upgradeName == "spawnXRockEveryXSecond_1")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.spawnXRockEveryXSecond -= LocalizationScript.spawnEverySecondIncrease;
			this.ReduceBars();
			SkillTree.spawnXRockEveryXSecond_1_purchased = true;
			SkillTree.spawnXRockEveryXSecond_1_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.spawnXRockEveryXSecond_1_purchaseCount;
		}
		else if (upgradeName == "spawnXRockEveryXSecond_2")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.spawnXRockEveryXSecond -= LocalizationScript.spawnEverySecondIncrease;
			this.ReduceBars();
			SkillTree.spawnXRockEveryXSecond_2_purchased = true;
			SkillTree.spawnXRockEveryXSecond_2_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.spawnXRockEveryXSecond_2_purchaseCount;
		}
		else if (upgradeName == "spawnXRockEveryXSecond_3")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.spawnXRockEveryXSecond -= LocalizationScript.spawnEverySecondIncrease;
			this.ReduceBars();
			SkillTree.spawnXRockEveryXSecond_3_purchased = true;
			SkillTree.spawnXRockEveryXSecond_3_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.spawnXRockEveryXSecond_3_purchaseCount;
		}
		else if (upgradeName == "chanceToSpawnRockWhenMined_1")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.chanceToSpawnRockWhenMined += LocalizationScript.spawnWhenMinedIncrease;
			this.ReduceBars();
			SkillTree.chanceToSpawnRockWhenMined_1_purchased = true;
			SkillTree.chanceToSpawnRockWhenMined_1_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.chanceToSpawnRockWhenMined_1_purchaseCount;
		}
		else if (upgradeName == "chanceToSpawnRockWhenMined_2")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.chanceToSpawnRockWhenMined += LocalizationScript.spawnWhenMinedIncrease;
			this.ReduceBars();
			SkillTree.chanceToSpawnRockWhenMined_2_purchased = true;
			SkillTree.chanceToSpawnRockWhenMined_2_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.chanceToSpawnRockWhenMined_2_purchaseCount;
		}
		else if (upgradeName == "chanceToSpawnRockWhenMined_3")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.chanceToSpawnRockWhenMined += LocalizationScript.spawnWhenMinedIncrease;
			this.ReduceBars();
			SkillTree.chanceToSpawnRockWhenMined_3_purchased = true;
			SkillTree.chanceToSpawnRockWhenMined_3_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.chanceToSpawnRockWhenMined_3_purchaseCount;
		}
		else if (upgradeName == "chanceToSpawnRockWhenMined_4")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.chanceToSpawnRockWhenMined += LocalizationScript.spawnWhenMinedIncrease;
			this.ReduceBars();
			SkillTree.chanceToSpawnRockWhenMined_4_purchased = true;
			SkillTree.chanceToSpawnRockWhenMined_4_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.chanceToSpawnRockWhenMined_4_purchaseCount;
		}
		else if (upgradeName == "chanceToSpawnRockWhenMined_5")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.chanceToSpawnRockWhenMined += LocalizationScript.spawnWhenMinedIncrease;
			this.ReduceBars();
			SkillTree.chanceToSpawnRockWhenMined_5_purchased = true;
			SkillTree.chanceToSpawnRockWhenMined_5_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.chanceToSpawnRockWhenMined_5_purchaseCount;
		}
		else if (upgradeName == "chanceToSpawnRockWhenMined_6")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.chanceToSpawnRockWhenMined += LocalizationScript.spawnWhenMinedIncrease;
			this.ReduceBars();
			SkillTree.chanceToSpawnRockWhenMined_6_purchased = true;
			SkillTree.chanceToSpawnRockWhenMined_6_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.chanceToSpawnRockWhenMined_6_purchaseCount;
		}
		else if (upgradeName == "chanceToMineRandomRock_1")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.chanceToMineRandomRock += LocalizationScript.chanceToMineRandomRockIncrease;
			this.ReduceBars();
			SkillTree.chanceToMineRandomRock_1_purchased = true;
			SkillTree.chanceToMineRandomRock_1_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.chanceToMineRandomRock_1_purchaseCount;
		}
		else if (upgradeName == "chanceToMineRandomRock_2")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.chanceToMineRandomRock += LocalizationScript.chanceToMineRandomRockIncrease;
			this.ReduceBars();
			SkillTree.chanceToMineRandomRock_2_purchased = true;
			SkillTree.chanceToMineRandomRock_2_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.chanceToMineRandomRock_2_purchaseCount;
		}
		else if (upgradeName == "chanceToMineRandomRock_3")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.chanceToMineRandomRock += LocalizationScript.chanceToMineRandomRockIncrease;
			this.ReduceBars();
			SkillTree.chanceToMineRandomRock_3_purchased = true;
			SkillTree.chanceToMineRandomRock_3_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.chanceToMineRandomRock_3_purchaseCount;
		}
		else if (upgradeName == "chanceToMineRandomRock_4")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.chanceToMineRandomRock += LocalizationScript.chanceToMineRandomRockIncrease;
			this.ReduceBars();
			SkillTree.chanceToMineRandomRock_4_purchased = true;
			SkillTree.chanceToMineRandomRock_4_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.chanceToMineRandomRock_4_purchaseCount;
		}
		else if (upgradeName == "spawnPickaxeEverySecond_1")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.spawnPickaxeEverySecond -= LocalizationScript.spawnPickaxeEverySecondIncrease;
			this.ReduceBars();
			SkillTree.spawnPickaxeEverySecond_1_purchased = true;
			SkillTree.spawnPickaxeEverySecond_1_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.spawnPickaxeEverySecond_1_purchaseCount;
		}
		else if (upgradeName == "spawnPickaxeEverySecond_2")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.spawnPickaxeEverySecond -= LocalizationScript.spawnPickaxeEverySecondIncrease;
			this.ReduceBars();
			SkillTree.spawnPickaxeEverySecond_2_purchased = true;
			SkillTree.spawnPickaxeEverySecond_2_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.spawnPickaxeEverySecond_2_purchaseCount;
		}
		else if (upgradeName == "spawnPickaxeEverySecond_3")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.spawnPickaxeEverySecond -= LocalizationScript.spawnPickaxeEverySecondIncrease;
			this.ReduceBars();
			SkillTree.spawnPickaxeEverySecond_3_purchased = true;
			SkillTree.spawnPickaxeEverySecond_3_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.spawnPickaxeEverySecond_3_purchaseCount;
		}
		else if (upgradeName == "moreTime_1")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.mineSessionTime += LocalizationScript.moreTimeIncrease;
			this.ReduceBars();
			SkillTree.moreTime_1_purchased = true;
			SkillTree.moreTime_1_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.moreTime_1_purchaseCount;
		}
		else if (upgradeName == "moreTime_2")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.mineSessionTime += LocalizationScript.moreTimeIncrease;
			this.ReduceBars();
			SkillTree.moreTime_2_purchased = true;
			SkillTree.moreTime_2_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.moreTime_2_purchaseCount;
		}
		else if (upgradeName == "moreTime_3")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.mineSessionTime += LocalizationScript.moreTimeIncrease;
			this.ReduceBars();
			SkillTree.moreTime_3_purchased = true;
			SkillTree.moreTime_3_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.moreTime_3_purchaseCount;
		}
		else if (upgradeName == "moreTime_4")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.mineSessionTime += LocalizationScript.moreTimeIncrease;
			this.ReduceBars();
			SkillTree.moreTime_4_purchased = true;
			SkillTree.moreTime_4_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.moreTime_4_purchaseCount;
		}
		else if (upgradeName == "chanceToAdd1SecondEverySecond")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			this.ReduceBars();
			SkillTree.chanceToAdd1SecondEverySecond_purchased = true;
			SkillTree.chanceToAdd1SecondEverySecond_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.chanceToAdd1SecondEverySecond_purchaseCount;
		}
		else if (upgradeName == "chanceAdd1SecondEveryRockMined")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			this.ReduceBars();
			SkillTree.chanceAdd1SecondEveryRockMined_purchased = true;
			SkillTree.chanceAdd1SecondEveryRockMined_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.chanceAdd1SecondEveryRockMined_purchaseCount;
		}
		else if (upgradeName == "doubleXpGoldChance_1")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.doubleXpAndGoldChance += LocalizationScript.doubleXpAndGoldChanceIncrease;
			this.ReduceBars();
			SkillTree.doubleXpGoldChance_1_purchased = true;
			SkillTree.doubleXpGoldChance_1_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.doubleXpGoldChance_1_purchaseCount;
		}
		else if (upgradeName == "doubleXpGoldChance_2")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.doubleXpAndGoldChance += LocalizationScript.doubleXpAndGoldChanceIncrease;
			this.ReduceBars();
			SkillTree.doubleXpGoldChance_2_purchased = true;
			SkillTree.doubleXpGoldChance_2_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.doubleXpGoldChance_2_purchaseCount;
		}
		else if (upgradeName == "doubleXpGoldChance_3")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.doubleXpAndGoldChance += LocalizationScript.doubleXpAndGoldChanceIncrease;
			this.ReduceBars();
			SkillTree.doubleXpGoldChance_3_purchased = true;
			SkillTree.doubleXpGoldChance_3_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.doubleXpGoldChance_3_purchaseCount;
		}
		else if (upgradeName == "doubleXpGoldChance_4")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.doubleXpAndGoldChance += LocalizationScript.doubleXpAndGoldChanceIncrease;
			this.ReduceBars();
			SkillTree.doubleXpGoldChance_4_purchased = true;
			SkillTree.doubleXpGoldChance_4_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.doubleXpGoldChance_4_purchaseCount;
		}
		else if (upgradeName == "doubleXpGoldChance_5")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.doubleXpAndGoldChance += LocalizationScript.doubleXpAndGoldChanceIncrease;
			this.ReduceBars();
			SkillTree.doubleXpGoldChance_5_purchased = true;
			SkillTree.doubleXpGoldChance_5_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.doubleXpGoldChance_5_purchaseCount;
		}
		else if (upgradeName == "lightningBeamChanceS_1")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.lightningTriggerChanceS += LocalizationScript.lightningTriggerChanceS_Increase;
			this.ReduceBars();
			SkillTree.lightningBeamChanceS_1_purchased = true;
			SkillTree.lightningBeamChanceS_1_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.lightningBeamChanceS_1_purchaseCount;
		}
		else if (upgradeName == "lightningBeamChanceS_2")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.lightningTriggerChanceS += LocalizationScript.lightningTriggerChanceS_Increase;
			this.ReduceBars();
			SkillTree.lightningBeamChanceS_2_purchased = true;
			SkillTree.lightningBeamChanceS_2_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.lightningBeamChanceS_2_purchaseCount;
		}
		else if (upgradeName == "lightningBeamChancePH_1")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.lightningTriggerChancePH += LocalizationScript.lightningTriggerChancePH_Increase;
			this.ReduceBars();
			SkillTree.lightningBeamChancePH_1_purchased = true;
			SkillTree.lightningBeamChancePH_1_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.lightningBeamChancePH_1_purchaseCount;
		}
		else if (upgradeName == "lightningBeamChancePH_2")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.lightningTriggerChancePH += LocalizationScript.lightningTriggerChancePH_Increase;
			this.ReduceBars();
			SkillTree.lightningBeamChancePH_2_purchased = true;
			SkillTree.lightningBeamChancePH_2_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.lightningBeamChancePH_2_purchaseCount;
		}
		else if (upgradeName == "lightningBeamSpawnAnotherOneChance")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			this.ReduceBars();
			SkillTree.lightningBeamSpawnAnotherOneChance_purchased = true;
			SkillTree.lightningBeamSpawnAnotherOneChance_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.lightningBeamSpawnAnotherOneChance_purchaseCount;
		}
		else if (upgradeName == "lightningBeamDamage")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.lightningDamage += LocalizationScript.lightningDamageIncrease;
			this.ReduceBars();
			SkillTree.lightningBeamDamage_purchased = true;
			SkillTree.lightningBeamDamage_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.lightningBeamDamage_purchaseCount;
		}
		else if (upgradeName == "lightningBeamSize")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.lightningSize += LocalizationScript.lightningSizeIncrease;
			this.ReduceBars();
			SkillTree.lightningBeamSize_purchased = true;
			SkillTree.lightningBeamSize_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.lightningBeamSize_purchaseCount;
		}
		else if (upgradeName == "lightningSplashes")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			this.ReduceBars();
			SkillTree.lightningSplashes_purchased = true;
			SkillTree.lightningSplashes_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.lightningSplashes_purchaseCount;
		}
		else if (upgradeName == "lightningBeamSpawnRock")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			this.ReduceBars();
			SkillTree.lightningBeamSpawnRock_purchased = true;
			SkillTree.lightningBeamSpawnRock_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.lightningBeamSpawnRock_purchaseCount;
		}
		else if (upgradeName == "lightningBeamExplosion")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			this.ReduceBars();
			SkillTree.lightningBeamExplosion_purchased = true;
			SkillTree.lightningBeamExplosion_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.lightningBeamExplosion_purchaseCount;
		}
		else if (upgradeName == "lightningBeamAddTime")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			this.ReduceBars();
			SkillTree.lightningBeamAddTime_purchased = true;
			SkillTree.lightningBeamAddTime_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.lightningBeamAddTime_purchaseCount;
		}
		else if (upgradeName == "dynamiteChance_1")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.dynamiteStickChance += LocalizationScript.dynamiteStickChanceIncrease;
			this.ReduceBars();
			SkillTree.dynamiteChance_1_purchased = true;
			SkillTree.dynamiteChance_1_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.dynamiteChance_1_purchaseCount;
		}
		else if (upgradeName == "dynamiteChance_2")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.dynamiteStickChance += LocalizationScript.dynamiteStickChanceIncrease;
			this.ReduceBars();
			SkillTree.dynamiteChance_2_purchased = true;
			SkillTree.dynamiteChance_2_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.dynamiteChance_2_purchaseCount;
		}
		else if (upgradeName == "dynamiteSpawn2SmallChance")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			this.ReduceBars();
			SkillTree.dynamiteSpawn2SmallChance_purchased = true;
			SkillTree.dynamiteSpawn2SmallChance_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.dynamiteSpawn2SmallChance_purchaseCount;
		}
		else if (upgradeName == "dynamiteExplosionSize")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.explosionSize += LocalizationScript.explosionSizeIncrease;
			this.ReduceBars();
			SkillTree.dynamiteExplosionSize_purchased = true;
			SkillTree.dynamiteExplosionSize_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.dynamiteExplosionSize_purchaseCount;
		}
		else if (upgradeName == "dynamiteDamage")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.explosionDamagage += LocalizationScript.explosionDamagageIncrease;
			this.ReduceBars();
			SkillTree.dynamiteDamage_purchased = true;
			SkillTree.dynamiteDamage_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.dynamiteDamage_purchaseCount;
		}
		else if (upgradeName == "dynamiteExplosionSpawnRock")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			this.ReduceBars();
			SkillTree.dynamiteExplosionSpawnRock_purchased = true;
			SkillTree.dynamiteExplosionSpawnRock_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.dynamiteExplosionSpawnRock_purchaseCount;
		}
		else if (upgradeName == "dynamiteExplosionAddTimeChance")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			this.ReduceBars();
			SkillTree.dynamiteExplosionAddTimeChance_purchased = true;
			SkillTree.dynamiteExplosionAddTimeChance_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.dynamiteExplosionAddTimeChance_purchaseCount;
		}
		else if (upgradeName == "dynamiteExplosionSpawnLightning")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			this.ReduceBars();
			SkillTree.dynamiteExplosionSpawnLightning_purchased = true;
			SkillTree.dynamiteExplosionSpawnLightning_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.dynamiteExplosionSpawnLightning_purchaseCount;
		}
		else if (upgradeName == "plazmaBallSpawn_1")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.plazmaBallChance += LocalizationScript.plazmaBallChanceIncrease;
			this.ReduceBars();
			SkillTree.plazmaBallSpawn_1_purchased = true;
			SkillTree.plazmaBallSpawn_1_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.plazmaBallSpawn_1_purchaseCount;
		}
		else if (upgradeName == "plazmaBallSpawn_2")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.plazmaBallChance += LocalizationScript.plazmaBallChanceIncrease;
			this.ReduceBars();
			SkillTree.plazmaBallSpawn_2_purchased = true;
			SkillTree.plazmaBallSpawn_2_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.plazmaBallSpawn_2_purchaseCount;
		}
		else if (upgradeName == "plazmaBallTime")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.plazmaBallTimer += LocalizationScript.plazmaBallTimerIncrease;
			this.ReduceBars();
			SkillTree.plazmaBallTime_purchased = true;
			SkillTree.plazmaBallTime_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.plazmaBallTime_purchaseCount;
		}
		else if (upgradeName == "plazmaBallSize")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.plazmaBallTotalSize += LocalizationScript.plazmaBallTotalSizeIncrease;
			this.ReduceBars();
			SkillTree.plazmaBallSize_purchased = true;
			SkillTree.plazmaBallSize_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.plazmaBallSize_purchaseCount;
		}
		else if (upgradeName == "plazmaBallExplosionChance")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			this.ReduceBars();
			SkillTree.plazmaBallExplosionChance_purchased = true;
			SkillTree.plazmaBallExplosionChance_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.plazmaBallExplosionChance_purchaseCount;
		}
		else if (upgradeName == "plazmaBallSpawnSmallChance")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			this.ReduceBars();
			SkillTree.plazmaBallSpawnSmallChance_purchased = true;
			SkillTree.plazmaBallSpawnSmallChance_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.plazmaBallSpawnSmallChance_purchaseCount;
		}
		else if (upgradeName == "plazmaBallDamage")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.plazmaBallTotalDamage += LocalizationScript.plazmaBallTotalDamageIncrease;
			this.ReduceBars();
			SkillTree.plazmaBallDamage_purchased = true;
			SkillTree.plazmaBallDamage_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.plazmaBallDamage_purchaseCount;
		}
		else if (upgradeName == "plazmaBallSpawnPickaxeChance")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			this.ReduceBars();
			SkillTree.plazmaBallSpawnPickaxeChance_purchased = true;
			SkillTree.plazmaBallSpawnPickaxeChance_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.plazmaBallSpawnPickaxeChance_purchaseCount;
		}
		else if (upgradeName == "allProjectileDoubleDamageChance")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			this.ReduceBars();
			SkillTree.allProjectileDoubleDamageChance_purchased = true;
			SkillTree.allProjectileDoubleDamageChance_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.allProjectileDoubleDamageChance_purchaseCount;
		}
		else if (upgradeName == "allProjectileTriggerChance")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			this.ReduceBars();
			SkillTree.allProjectileTriggerChance_purchased = true;
			SkillTree.allProjectileTriggerChance_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.allProjectileTriggerChance_purchaseCount;
		}
		else if (upgradeName == "pickaxeDoubleDamageChance_1")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.doubleDamageChance += LocalizationScript.doubleDamageChanceIncrease;
			this.ReduceBars();
			SkillTree.pickaxeDoubleDamageChance_1_purchased = true;
			SkillTree.pickaxeDoubleDamageChance_1_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.pickaxeDoubleDamageChance_1_purchaseCount;
		}
		else if (upgradeName == "pickaxeDoubleDamageChance_2")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.doubleDamageChance += LocalizationScript.doubleDamageChanceIncrease;
			this.ReduceBars();
			SkillTree.pickaxeDoubleDamageChance_2_purchased = true;
			SkillTree.pickaxeDoubleDamageChance_2_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.pickaxeDoubleDamageChance_2_purchaseCount;
		}
		else if (upgradeName == "intaMineChance_1")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.instaMineChance += LocalizationScript.instaMineChanceIncrease;
			this.ReduceBars();
			SkillTree.intaMineChance_1_purchased = true;
			SkillTree.intaMineChance_1_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.intaMineChance_1_purchaseCount;
		}
		else if (upgradeName == "intaMineChance_2")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.instaMineChance += LocalizationScript.instaMineChanceIncrease;
			this.ReduceBars();
			SkillTree.intaMineChance_2_purchased = true;
			SkillTree.intaMineChance_2_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.intaMineChance_2_purchaseCount;
		}
		else if (upgradeName == "increaseSpawnChanceAllRocks")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			this.ReduceBars();
			float num2 = 1f + SkillTree.allRockSpawnChanceIncrease / 100f;
			SkillTree.goldRockChance *= num2;
			SkillTree.fullGoldRockChance *= num2;
			SkillTree.copperRockChance *= num2;
			SkillTree.fullCopperRockChance *= num2;
			SkillTree.ironRockChance *= num2;
			SkillTree.fullIronRockChance *= num2;
			SkillTree.cobaltRockChance *= num2;
			SkillTree.fullCobaltRockChance *= num2;
			SkillTree.uraniumRockChance *= num2;
			SkillTree.fullUraniumRockChance *= num2;
			SkillTree.ismiumRockChance *= num2;
			SkillTree.fullIsmiumRockChance *= num2;
			SkillTree.iridiumRockChance *= num2;
			SkillTree.fullIridiumRockChance *= num2;
			SkillTree.painiteRockChance *= num2;
			SkillTree.fullPainiteRockChance *= num2;
			SkillTree.increaseSpawnChanceAllRocks_purchased = true;
			SkillTree.increaseSpawnChanceAllRocks_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.increaseSpawnChanceAllRocks_purchaseCount;
		}
		else if (upgradeName == "craft2Material")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			this.ReduceBars();
			SkillTree.craft2Material_purchased = true;
			SkillTree.craft2Material_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.craft2Material_purchaseCount;
		}
		else if (upgradeName == "finalUpgrade")
		{
			if (num < LocalizationScript.currentHoverPrice)
			{
				this.ErrorSound();
				return;
			}
			this.ReduceBars();
			SkillTree.finalUpgrade_purchased = true;
			SkillTree.finalUpgrade_purchaseCount++;
			LocalizationScript.currentPurchaseCount = SkillTree.finalUpgrade_purchaseCount;
		}
		else if (upgradeName == "endlessGold")
		{
			if (GoldAndOreMechanics.totalGoldBars < SkillTree.endlessGold_price)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.materialsTotalWorth += LocalizationScript.materialsWorthIncrease;
			GoldAndOreMechanics.totalGoldBars -= SkillTree.endlessGold_price;
			SkillTree.endlessGold_purchaseCount++;
			SkillTree.endlessGold_price *= 1.0800000429153442;
			LocalizationScript.currentPurchaseCount = SkillTree.endlessGold_purchaseCount;
		}
		else if (upgradeName == "endlessCopper")
		{
			if (GoldAndOreMechanics.totalCopperBars < SkillTree.endlessCopper_price)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.doubleXpAndGoldChance += LocalizationScript.doubleXpAndGoldChanceIncrease;
			GoldAndOreMechanics.totalCopperBars -= SkillTree.endlessCopper_price;
			SkillTree.endlessCopper_purchaseCount++;
			SkillTree.endlessCopper_price *= 1.100000023841858;
			LocalizationScript.currentPurchaseCount = SkillTree.endlessCopper_purchaseCount;
		}
		else if (upgradeName == "endlessIron")
		{
			if (GoldAndOreMechanics.totalIronBars < SkillTree.endlessIron_price)
			{
				this.ErrorSound();
				return;
			}
			LevelMechanics.xpFromRock += LocalizationScript.xpIncrease;
			GoldAndOreMechanics.totalIronBars -= SkillTree.endlessIron_price;
			SkillTree.endlessIron_purchaseCount++;
			SkillTree.endlessIron_price *= 1.100000023841858;
			LocalizationScript.currentPurchaseCount = SkillTree.endlessIron_purchaseCount;
		}
		else if (upgradeName == "endlessCobalt")
		{
			if (GoldAndOreMechanics.totalCobaltBars < SkillTree.endlessCobalt_price)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.improvedPickaxeStrength += LocalizationScript.improvedPickaxeIncrease;
			SkillTree.reducePickaxeMineTime += LocalizationScript.improvedPickaxeIncrease;
			GoldAndOreMechanics.totalCobaltBars -= SkillTree.endlessCobalt_price;
			SkillTree.endlessCobalt_purchaseCount++;
			SkillTree.endlessCobalt_price *= 1.350000023841858;
			LocalizationScript.currentPurchaseCount = SkillTree.endlessCobalt_purchaseCount;
		}
		else if (upgradeName == "endlessUranium")
		{
			if (GoldAndOreMechanics.totalUraniumBars < SkillTree.endlessUranium_price)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.improvedPickaxeStrength += LocalizationScript.improvedPickaxeIncrease;
			SkillTree.reducePickaxeMineTime += LocalizationScript.improvedPickaxeIncrease;
			GoldAndOreMechanics.totalUraniumBars -= SkillTree.endlessUranium_price;
			SkillTree.endlessUranium_purchaseCount++;
			SkillTree.endlessUranium_price *= 1.350000023841858;
			LocalizationScript.currentPurchaseCount = SkillTree.endlessUranium_purchaseCount;
		}
		else if (upgradeName == "endlessIsmium")
		{
			if (GoldAndOreMechanics.totalIsmiumBar < SkillTree.endlessIsmium_price)
			{
				this.ErrorSound();
				return;
			}
			LevelMechanics.xpFromRock += LocalizationScript.xpIncrease;
			GoldAndOreMechanics.totalIsmiumBar -= SkillTree.endlessIsmium_price;
			SkillTree.endlessIsmium_purchaseCount++;
			SkillTree.endlessIsmium_price *= 1.100000023841858;
			LocalizationScript.currentPurchaseCount = SkillTree.endlessIsmium_purchaseCount;
		}
		else if (upgradeName == "endlessIridium")
		{
			if (GoldAndOreMechanics.totalIridiumBars < SkillTree.endlessIridium_price)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.doubleXpAndGoldChance += LocalizationScript.doubleXpAndGoldChanceIncrease;
			GoldAndOreMechanics.totalIridiumBars -= SkillTree.endlessIridium_price;
			SkillTree.endlessIridium_purchaseCount++;
			SkillTree.endlessIridium_price *= 1.100000023841858;
			LocalizationScript.currentPurchaseCount = SkillTree.endlessIridium_purchaseCount;
		}
		else if (upgradeName == "endlessPainite")
		{
			if (GoldAndOreMechanics.totalPainiteBars < SkillTree.endlessPainite_price)
			{
				this.ErrorSound();
				return;
			}
			SkillTree.materialsTotalWorth += LocalizationScript.materialsWorthIncrease;
			GoldAndOreMechanics.totalPainiteBars -= SkillTree.endlessPainite_price;
			SkillTree.endlessPainite_purchaseCount++;
			SkillTree.endlessPainite_price *= 1.0800000429153442;
			LocalizationScript.currentPurchaseCount = SkillTree.endlessPainite_purchaseCount;
		}
		this.audioManager.Play("Click_1");
		this.theAnvilScript.DisplayEquippedAndSetStats(TheAnvil.equippedMineTime, TheAnvil.equippedMinePower, TheAnvil.equipped2XChance, TheAnvil.equippedMiningArea);
		this.CheckUpgrades();
		this.UpdateTooltipText();
		this.theMineScript.UpdateChances();
		this.goldAndOreScript.SetTotalResourcesText();
		SkillTree.totalSkillTreeUpgradesPurchased++;
		this.achScript.CheckAch();
		if (SkillTree.totalSkillTreeUpgradesPurchased >= 399 && !SkillTree.hasPressedEndlessOK)
		{
			SkillTree.isInEndlessPopUp = true;
			this.endlessUpgradesPopUp.SetActive(true);
			this.endlessUpgradesParent.SetActive(true);
		}
	}

	// Token: 0x060001CA RID: 458 RVA: 0x00048456 File Offset: 0x00046656
	public void PressOkEndless()
	{
		this.audioManager.Play("UI_Click1");
		SkillTree.isInEndlessPopUp = false;
		SkillTree.hasPressedEndlessOK = true;
		this.endlessUpgradesPopUp.SetActive(false);
	}

	// Token: 0x060001CB RID: 459 RVA: 0x00048480 File Offset: 0x00046680
	public void ErrorSound()
	{
		this.audioManager.Play("CantAfford");
	}

	// Token: 0x060001CC RID: 460 RVA: 0x00048492 File Offset: 0x00046692
	public void UpdateTooltipText()
	{
		this.locScript.SetSkillTreeTexts(Tooltip.upgradeName, Tooltip.upgradeType, LocalizationScript.currentHoverPrice, LocalizationScript.currentPurchaseCount, LocalizationScript.currentTotalPurchaseCount);
	}

	// Token: 0x060001CD RID: 461 RVA: 0x000484B8 File Offset: 0x000466B8
	public void CheckUpgrades()
	{
		if (SkillTree.spawnMoreRocks_1_purchased)
		{
			this.lines[0].SetActive(true);
			this.lines[1].SetActive(true);
			this.lines[2].SetActive(true);
			this.lines[3].SetActive(true);
			this.spawnMoreRocks_2.SetActive(true);
			this.improvedPickaxe_1.SetActive(true);
			this.goldChunk_1.SetActive(true);
			this.biggerMiningErea_1.SetActive(true);
			if (SkillTree.spawnMoreRocks_1_purchaseCount >= 5)
			{
				this.spawnMoreRocks_1_LOCKED.SetActive(false);
				this.spawnMoreRocks_1.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.spawnMoreRocks_2_purchased)
		{
			this.lines[10].SetActive(true);
			this.lines[11].SetActive(true);
			this.lines[15].SetActive(true);
			this.lines[2].SetActive(true);
			this.lines[5].SetActive(true);
			this.lines[6].SetActive(true);
			this.spawnMoreRocks_3.SetActive(true);
			this.moreXP_1.SetActive(true);
			this.chanceToSpawnRockWhenMined_1.SetActive(true);
			if (SkillTree.spawnMoreRocks_2_purchaseCount >= 4)
			{
				this.spawnMoreRocks_2_LOCKED.SetActive(false);
				this.spawnMoreRocks_2.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.spawnMoreRocks_3_purchased)
		{
			this.lines[12].SetActive(true);
			this.lines[13].SetActive(true);
			this.lines[15].SetActive(true);
			this.lines[18].SetActive(true);
			if (SkillTree.marterialsWorthMore_2_purchased)
			{
				this.lines[37].SetActive(true);
			}
			if (SkillTree.spawnMoreRocks_2_purchased)
			{
				this.lines[14].SetActive(true);
				this.lines[16].SetActive(true);
			}
			if (SkillTree.moreXP_2_purchased)
			{
				this.lines[23].SetActive(true);
			}
			if (SkillTree.goldChunk_1_purchased)
			{
				this.lines[14].SetActive(true);
			}
			this.spawnMoreRocks_4.SetActive(true);
			this.spawnMoreRocks_2.SetActive(true);
			this.moreXP_2.SetActive(true);
			this.doubleXpGoldChance_1.SetActive(true);
			if (SkillTree.spawnMoreRocks_3_purchaseCount >= 4)
			{
				this.spawnMoreRocks_3_LOCKED.SetActive(false);
				this.spawnMoreRocks_3.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.spawnMoreRocks_4_purchased)
		{
			this.lines[13].SetActive(true);
			this.lines[14].SetActive(true);
			this.lines[19].SetActive(true);
			this.lines[37].SetActive(true);
			if (SkillTree.marterialsWorthMore_1_purchased)
			{
				this.lines[39].SetActive(true);
			}
			if (SkillTree.moreXP_1_purchased)
			{
				this.lines[12].SetActive(true);
			}
			if (SkillTree.spawnMoreRocks_3_purchased)
			{
				this.lines[24].SetActive(true);
			}
			if (SkillTree.chanceToSpawnRockWhenMined_1_purchased)
			{
				this.lines[15].SetActive(true);
				this.lines[39].SetActive(true);
			}
			this.spawnMoreRocks_3.SetActive(true);
			this.chanceToSpawnRockWhenMined_1.SetActive(true);
			this.spawnCopper.SetActive(true);
			this.spawnXRockEveryXSecond_1.SetActive(true);
			if (SkillTree.spawnMoreRocks_4_purchaseCount >= 5)
			{
				this.spawnMoreRocks_4_LOCKED.SetActive(false);
				this.spawnMoreRocks_4.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.spawnMoreRocks_5_purchased)
		{
			this.lines[132].SetActive(true);
			this.lines[131].SetActive(true);
			this.lines[128].SetActive(true);
			if (SkillTree.spawnXRockEveryXSecond_2_purchased)
			{
				this.lines[139].SetActive(true);
			}
			this.marterialsWorthMore_6.SetActive(true);
			this.spawnRockEveryXrock_1.SetActive(true);
			this.spawnXRockEveryXSecond_2.SetActive(true);
			if (SkillTree.spawnMoreRocks_5_purchaseCount >= 5)
			{
				this.spawnMoreRocks_5_LOCKED.SetActive(false);
				this.spawnMoreRocks_5.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.spawnMoreRocks_6_purchased)
		{
			this.lines[150].SetActive(true);
			this.lines[146].SetActive(true);
			this.lines[145].SetActive(true);
			if (SkillTree.fullIron_1_purchased)
			{
				this.lines[151].SetActive(true);
			}
			if (SkillTree.moreXP_5_purchased)
			{
				this.lines[144].SetActive(true);
			}
			this.moreXP_5.SetActive(true);
			this.fullIron_1.SetActive(true);
			this.cobaltSpawn.SetActive(true);
			if (SkillTree.spawnMoreRocks_6_purchaseCount >= 3)
			{
				this.spawnMoreRocks_6_LOCKED.SetActive(false);
				this.spawnMoreRocks_6.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.spawnMoreRocks_7_purchased)
		{
			this.lines[165].SetActive(true);
			this.lines[159].SetActive(true);
			if (SkillTree.fullIron_1_purchased)
			{
				this.lines[160].SetActive(true);
				this.lines[155].SetActive(true);
			}
			if (SkillTree.cobaltSpawn_purchased)
			{
				this.lines[155].SetActive(true);
			}
			if (SkillTree.chanceAdd1SecondEveryRockMined_purchased)
			{
				this.lines[148].SetActive(true);
			}
			this.uraniumSpawn.SetActive(true);
			this.copperChunk_2.SetActive(true);
			if (SkillTree.spawnMoreRocks_7_purchaseCount >= 3)
			{
				this.spawnMoreRocks_7_LOCKED.SetActive(false);
				this.spawnMoreRocks_7.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.spawnMoreRocks_8_purchased)
		{
			this.lines[182].SetActive(true);
			this.lines[180].SetActive(true);
			this.painiteSpawn.SetActive(true);
			this.ismiumSpawn.SetActive(true);
			if (SkillTree.spawnMoreRocks_8_purchaseCount >= 3)
			{
				this.spawnMoreRocks_8_LOCKED.SetActive(false);
				this.spawnMoreRocks_8.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.spawnMoreRocks_9_purchased)
		{
			this.lines[183].SetActive(true);
			this.lines[178].SetActive(true);
			this.lines[179].SetActive(true);
			this.painiteSpawn.SetActive(true);
			this.iridiumSpawn.SetActive(true);
			if (SkillTree.spawnMoreRocks_9_purchaseCount >= 3)
			{
				this.spawnMoreRocks_9_LOCKED.SetActive(false);
				this.spawnMoreRocks_9.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.moreMeterialsFromRock_1_purchased)
		{
			this.lines[42].SetActive(true);
			this.lines[46].SetActive(true);
			if (SkillTree.marterialsWorthMore_1_purchased)
			{
				this.lines[48].SetActive(true);
			}
			this.marterialsWorthMore_1.SetActive(true);
			this.doubleXpGoldChance_3.SetActive(true);
			if (SkillTree.moreMeterialsFromRock_1_purchaseCount >= 2)
			{
				this.moreMeterialsFromRock_1_LOCKED.SetActive(false);
				this.moreMeterialsFromRock_1.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.moreMeterialsFromRock_2_purchased)
		{
			this.lines[29].SetActive(true);
			this.lines[33].SetActive(true);
			if (SkillTree.moreTime_4_purchased)
			{
				this.lines[28].SetActive(true);
				this.lines[25].SetActive(true);
			}
			if (SkillTree.intaMineChance_2_purchased)
			{
				this.lines[31].SetActive(true);
			}
			if (SkillTree.doubleXpGoldChance_1_purchased)
			{
				this.lines[20].SetActive(true);
				this.lines[25].SetActive(true);
			}
			this.intaMineChance_2.SetActive(true);
			this.chanceToSpawnRockWhenMined_2.SetActive(true);
			if (SkillTree.moreMeterialsFromRock_2_purchaseCount >= 2)
			{
				this.moreMeterialsFromRock_2_LOCKED.SetActive(false);
				this.moreMeterialsFromRock_2.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.moreMeterialsFromRock_3_purchased)
		{
			this.lines[65].SetActive(true);
			this.lines[72].SetActive(true);
			if (SkillTree.increaseAndDecreaseMinignErea_purchased)
			{
				this.lines[66].SetActive(true);
			}
			if (SkillTree.moreXP_3_purchased)
			{
				this.lines[66].SetActive(true);
			}
			this.moreXP_3.SetActive(true);
			this.chanceToSpawnRockWhenMined_3.SetActive(true);
			if (SkillTree.moreMeterialsFromRock_3_purchaseCount >= 2)
			{
				this.moreMeterialsFromRock_3_LOCKED.SetActive(false);
				this.moreMeterialsFromRock_3.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.moreMeterialsFromRock_4_purchased)
		{
			this.lines[164].SetActive(true);
			this.lines[162].SetActive(true);
			this.lines[161].SetActive(true);
			if (SkillTree.fullIron_1_purchased)
			{
				this.lines[160].SetActive(true);
			}
			if (SkillTree.cobaltSpawn_purchased)
			{
				this.lines[160].SetActive(true);
			}
			this.cobaltSpawn.SetActive(true);
			this.chanceToSpawnRockWhenMined_6.SetActive(true);
			this.copperChunk_2.SetActive(true);
			if (SkillTree.moreMeterialsFromRock_4_purchaseCount >= 2)
			{
				this.moreMeterialsFromRock_4_LOCKED.SetActive(false);
				this.moreMeterialsFromRock_4.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.moreMeterialsFromRock_5_purchased)
		{
			this.lines[189].SetActive(true);
			this.lines[187].SetActive(true);
			this.lines[190].SetActive(true);
			this.goldChunk_5_.SetActive(true);
			if (SkillTree.moreMeterialsFromRock_5_purchaseCount >= 2)
			{
				this.moreMeterialsFromRock_5_LOCKED.SetActive(false);
				this.moreMeterialsFromRock_5.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.marterialsWorthMore_1_purchased)
		{
			this.lines[46].SetActive(true);
			this.lines[45].SetActive(true);
			this.lines[41].SetActive(true);
			this.lines[40].SetActive(true);
			if (SkillTree.goldChunk_1_purchased)
			{
				this.lines[44].SetActive(true);
				this.lines[47].SetActive(true);
			}
			this.marterialsWorthMore_2.SetActive(true);
			this.marterialsWorthMore_3.SetActive(true);
			this.moreMeterialsFromRock_1.SetActive(true);
			this.goldChunk_1.SetActive(true);
			if (SkillTree.marterialsWorthMore_1_purchaseCount >= 4)
			{
				this.marterialsWorthMore_1_LOCKED.SetActive(false);
				this.marterialsWorthMore_1.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.marterialsWorthMore_2_purchased)
		{
			this.lines[44].SetActive(true);
			this.lines[40].SetActive(true);
			this.lines[39].SetActive(true);
			this.lines[45].SetActive(true);
			this.spawnCopper.SetActive(true);
			this.marterialsWorthMore_1.SetActive(true);
			this.chanceToSpawnRockWhenMined_1.SetActive(true);
			if (SkillTree.marterialsWorthMore_2_purchaseCount >= 5)
			{
				this.marterialsWorthMore_2_LOCKED.SetActive(false);
				this.marterialsWorthMore_2.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.marterialsWorthMore_3_purchased)
		{
			this.lines[48].SetActive(true);
			this.lines[47].SetActive(true);
			this.lines[41].SetActive(true);
			if (SkillTree.spawnRockEveryXrock_1_purchased)
			{
				this.lines[40].SetActive(true);
			}
			if (SkillTree.spawnMoreRocks_1_purchased)
			{
				this.lines[45].SetActive(true);
			}
			if (SkillTree.goldChunk_1_purchased)
			{
				this.lines[45].SetActive(true);
			}
			if (SkillTree.marterialsWorthMore_1_purchased)
			{
				this.lines[42].SetActive(true);
			}
			this.fullGold_1.SetActive(true);
			this.marterialsWorthMore_1.SetActive(true);
			this.doubleXpGoldChance_3.SetActive(true);
			if (SkillTree.marterialsWorthMore_3_purchaseCount >= 5)
			{
				this.marterialsWorthMore_3_LOCKED.SetActive(false);
				this.marterialsWorthMore_3.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.marterialsWorthMore_4_purchased)
		{
			this.lines[28].SetActive(true);
			this.lines[32].SetActive(true);
			if (SkillTree.intaMineChance_2_purchased)
			{
				this.lines[27].SetActive(true);
			}
			if (SkillTree.moreTime_4_purchased)
			{
				this.lines[31].SetActive(true);
			}
			this.moreTime_4.SetActive(true);
			this.chanceToSpawnRockWhenMined_2.SetActive(true);
			if (SkillTree.marterialsWorthMore_4_purchaseCount >= 5)
			{
				this.marterialsWorthMore_4_LOCKED.SetActive(false);
				this.marterialsWorthMore_4.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.marterialsWorthMore_5_purchased)
		{
			this.lines[71].SetActive(true);
			this.lines[64].SetActive(true);
			this.doubleXpGoldChance_2.SetActive(true);
			this.chanceToSpawnRockWhenMined_3.SetActive(true);
			if (SkillTree.increaseAndDecreaseMinignErea_purchased)
			{
				this.lines[66].SetActive(true);
			}
			if (SkillTree.doubleXpGoldChance_2_purchased)
			{
				this.lines[66].SetActive(true);
			}
			if (SkillTree.marterialsWorthMore_5_purchaseCount >= 5)
			{
				this.marterialsWorthMore_5_LOCKED.SetActive(false);
				this.marterialsWorthMore_5.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.marterialsWorthMore_6_purchased)
		{
			this.lines[131].SetActive(true);
			this.lines[128].SetActive(true);
			this.spawnMoreRocks_5.SetActive(true);
			if (SkillTree.marterialsWorthMore_6_purchaseCount >= 5)
			{
				this.marterialsWorthMore_6_LOCKED.SetActive(false);
				this.marterialsWorthMore_6.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.marterialsWorthMore_7_purchased)
		{
			this.lines[148].SetActive(true);
			this.lines[143].SetActive(true);
			this.lines[149].SetActive(true);
			if (SkillTree.cobaltSpawn_purchased)
			{
				this.lines[155].SetActive(true);
			}
			if (SkillTree.fullIron_1_purchased)
			{
				this.lines[155].SetActive(true);
			}
			this.fullIron_1.SetActive(true);
			this.uraniumSpawn.SetActive(true);
			this.chanceAdd1SecondEveryRockMined.SetActive(true);
			if (SkillTree.marterialsWorthMore_7_purchaseCount >= 5)
			{
				this.marterialsWorthMore_7_LOCKED.SetActive(false);
				this.marterialsWorthMore_7.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.marterialsWorthMore_8_purchased)
		{
			this.lines[188].SetActive(true);
			this.lines[191].SetActive(true);
			this.copperChunk_3.SetActive(true);
			if (SkillTree.marterialsWorthMore_8_purchaseCount >= 5)
			{
				this.marterialsWorthMore_8_LOCKED.SetActive(false);
				this.marterialsWorthMore_8.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.goldChunk_1_purchased)
		{
			this.lines[0].SetActive(true);
			this.lines[7].SetActive(true);
			this.lines[6].SetActive(true);
			this.lines[45].SetActive(true);
			this.lines[10].SetActive(true);
			this.lines[8].SetActive(true);
			if (SkillTree.spawnCopper_purchased)
			{
				this.lines[40].SetActive(true);
			}
			if (SkillTree.chanceToSpawnRockWhenMined_1_purchased)
			{
				this.lines[40].SetActive(true);
			}
			if (SkillTree.fullGold_1_purchased)
			{
				this.lines[41].SetActive(true);
			}
			this.marterialsWorthMore_1.SetActive(true);
			this.chanceToSpawnRockWhenMined_1.SetActive(true);
			this.fullGold_1.SetActive(true);
			if (SkillTree.goldChunk_1_purchaseCount >= 5)
			{
				this.goldChunk_1_LOCKED.SetActive(false);
				this.goldChunk_1.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.goldChunk_2_purchased)
		{
			this.lines[43].SetActive(true);
			this.lines[49].SetActive(true);
			this.lines[50].SetActive(true);
			this.chanceToMineRandomRock_4.SetActive(true);
			this.improvedPickaxe_4.SetActive(true);
			if (SkillTree.goldChunk_2_purchaseCount >= 5)
			{
				this.goldChunk_2_LOCKED.SetActive(false);
				this.goldChunk_2.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.goldChunk_3_purchased)
		{
			this.lines[130].SetActive(true);
			this.lines[129].SetActive(true);
			if (SkillTree.goldChunk_3_purchaseCount >= 5)
			{
				this.goldChunk_3_LOCKED.SetActive(false);
				this.goldChunk_3.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.goldChunk_4_purchased)
		{
			this.lines[170].SetActive(true);
			this.lines[168].SetActive(true);
			this.lines[167].SetActive(true);
			this.spawnRockEveryXrock_3.SetActive(true);
			this.increaseSpawnChanceAllRocks.SetActive(true);
			if (SkillTree.goldChunk_4_purchaseCount >= 5)
			{
				this.goldChunk_4_LOCKED.SetActive(false);
				this.goldChunk_4.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.goldChunk_5_purchased)
		{
			this.lines[187].SetActive(true);
			this.lines[188].SetActive(true);
			this.lines[190].SetActive(true);
			this.marterialsWorthMore_8.SetActive(true);
			if (SkillTree.goldChunk_5_purchaseCount >= 5)
			{
				this.goldChunk_5_LOCKED.SetActive(false);
				this.goldChunk_5_.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.fullGold_1_purchased)
		{
			this.lines[7].SetActive(true);
			this.lines[8].SetActive(true);
			this.lines[47].SetActive(true);
			this.lines[57].SetActive(true);
			this.marterialsWorthMore_3.SetActive(true);
			this.chanceToMineRandomRock_3.SetActive(true);
			if (SkillTree.fullGold_1_purchaseCount >= 3)
			{
				this.fullGold_1_LOCKED.SetActive(false);
				this.fullGold_1.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.fullGold_2_purchased)
		{
			this.lines[160].SetActive(true);
			this.lines[155].SetActive(true);
			this.lines[151].SetActive(true);
			this.lines[147].SetActive(true);
			if (SkillTree.fullIron_1_purchased)
			{
				this.lines[148].SetActive(true);
				this.lines[146].SetActive(true);
			}
			if (SkillTree.copperChunk_2_purchased)
			{
				this.lines[159].SetActive(true);
			}
			this.copperChunk_2.SetActive(true);
			this.cobaltSpawn.SetActive(true);
			this.uraniumSpawn.SetActive(true);
			if (SkillTree.fullGold_2_purchaseCount >= 3)
			{
				this.fullGold_2_LOCKED.SetActive(false);
				this.fullGold_2.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.fullGold_3_purchased)
		{
			this.lines[177].SetActive(true);
			this.lines[176].SetActive(true);
			this.talentPointsPerXlevel_3.SetActive(true);
			if (SkillTree.fullGold_3_purchaseCount >= 3)
			{
				this.fullGold_3_LOCKED.SetActive(false);
				this.fullGold_3.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.spawnCopper_purchased)
		{
			this.copperBarFrame.SetActive(true);
			this.lines[37].SetActive(true);
			this.lines[38].SetActive(true);
			this.lines[39].SetActive(true);
			this.lines[123].SetActive(true);
			if (SkillTree.doubleXpGoldChance_1_purchased)
			{
				this.lines[19].SetActive(true);
			}
			if (SkillTree.doubleXpGoldChance_1_purchased)
			{
				this.lines[35].SetActive(true);
			}
			if (SkillTree.spawnMoreRocks_4_purchased)
			{
				this.lines[35].SetActive(true);
				this.lines[44].SetActive(true);
			}
			if (SkillTree.spawnMoreRocks_2_purchased)
			{
				this.lines[13].SetActive(true);
				this.lines[14].SetActive(true);
			}
			if (SkillTree.moreXP_2_purchased)
			{
				this.lines[13].SetActive(true);
			}
			if (SkillTree.goldChunk_1_purchased)
			{
				this.lines[14].SetActive(true);
			}
			this.marterialsWorthMore_2.SetActive(true);
			this.spawnMoreRocks_4.SetActive(true);
			this.copperChunk_1.SetActive(true);
			this.biggerMiningErea_3.SetActive(true);
			if (SkillTree.spawnCopper_purchaseCount >= 1)
			{
				this.spawnCopper_LOCKED.SetActive(false);
				this.spawnCopper.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.copperChunk_1_purchased)
		{
			this.lines[124].SetActive(true);
			this.fullCopper_1.SetActive(true);
			if (SkillTree.copperChunk_1_purchaseCount >= 3)
			{
				this.copperChunk_1_LOCKED.SetActive(false);
				this.copperChunk_1.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.copperChunk_2_purchased)
		{
			this.lines[163].SetActive(true);
			this.lines[160].SetActive(true);
			this.lines[164].SetActive(true);
			this.lines[165].SetActive(true);
			if (SkillTree.spawnMoreRocks_6_purchased)
			{
				this.lines[161].SetActive(true);
			}
			if (SkillTree.moreMeterialsFromRock_4_purchased)
			{
				this.lines[166].SetActive(true);
			}
			if (SkillTree.fullGold_2_purchased)
			{
				this.lines[159].SetActive(true);
				this.lines[161].SetActive(true);
			}
			if (SkillTree.marterialsWorthMore_7_purchased)
			{
				this.lines[159].SetActive(true);
			}
			this.fullCopper_2.SetActive(true);
			this.spawnMoreRocks_7.SetActive(true);
			this.moreMeterialsFromRock_4.SetActive(true);
			if (SkillTree.copperChunk_2_purchaseCount >= 3)
			{
				this.copperChunk_2_LOCKED.SetActive(false);
				this.copperChunk_2.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.copperChunk_3_purchased)
		{
			this.lines[186].SetActive(true);
			this.lines[191].SetActive(true);
			if (SkillTree.fullIsmium_1_purchased)
			{
				this.lines[188].SetActive(true);
			}
			this.marterialsWorthMore_8.SetActive(true);
			if (SkillTree.copperChunk_3_purchaseCount >= 3)
			{
				this.copperChunk_3_LOCKED.SetActive(false);
				this.copperChunk_3.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.fullCopper_1_purchased)
		{
			this.lines[127].SetActive(true);
			this.lines[126].SetActive(true);
			this.lines[125].SetActive(true);
			this.lines[124].SetActive(true);
			this.marterialsWorthMore_6.SetActive(true);
			this.moreXP_4.SetActive(true);
			this.spawnXRockEveryXSecond_2.SetActive(true);
			if (SkillTree.fullCopper_1_purchaseCount >= 2)
			{
				this.fullCopper_1_LOCKED.SetActive(false);
				this.fullCopper_1.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.fullCopper_2_purchased)
		{
			this.lines[167].SetActive(true);
			this.lines[166].SetActive(true);
			this.lines[163].SetActive(true);
			if (SkillTree.cobaltSpawn_purchased)
			{
				this.lines[162].SetActive(true);
			}
			if (SkillTree.copperChunk_2_purchased)
			{
				this.lines[162].SetActive(true);
			}
			this.goldChunk_4.SetActive(true);
			this.chanceToSpawnRockWhenMined_6.SetActive(true);
			if (SkillTree.fullCopper_2_purchaseCount >= 2)
			{
				this.fullCopper_2_LOCKED.SetActive(false);
				this.fullCopper_2.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.fullCopper_3_purchased && SkillTree.fullCopper_3_purchaseCount >= 2)
		{
			this.fullCopper_3_LOCKED.SetActive(false);
			this.fullCopper_3.GetComponent<Button>().enabled = false;
		}
		if (SkillTree.spawnIron_purchased)
		{
			this.ironBarFrame.SetActive(true);
			this.lines[133].SetActive(true);
			this.lines[134].SetActive(true);
			this.lines[139].SetActive(true);
			this.lines[132].SetActive(true);
			if (SkillTree.marterialsWorthMore_6_purchased)
			{
				this.lines[132].SetActive(true);
			}
			this.ironChunk_1.SetActive(true);
			this.spawnRockEveryXrock_1.SetActive(true);
			if (SkillTree.spawnIron_purchaseCount >= 1)
			{
				this.spawnIron_LOCKED.SetActive(false);
				this.spawnIron.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.ironChunk_1_purchased)
		{
			this.lines[144].SetActive(true);
			this.lines[141].SetActive(true);
			this.lines[140].SetActive(true);
			this.lines[134].SetActive(true);
			if (SkillTree.spawnIron_purchased)
			{
				this.lines[135].SetActive(true);
			}
			if (SkillTree.moreXP_5_purchased)
			{
				this.lines[135].SetActive(true);
				this.lines[150].SetActive(true);
			}
			if (SkillTree.spawnMoreRocks_5_purchased)
			{
				this.lines[135].SetActive(true);
			}
			this.fullIron_1.SetActive(true);
			this.moreXP_5.SetActive(true);
			this.chanceAdd1SecondEveryRockMined.SetActive(true);
			if (SkillTree.ironChunk_1_purchaseCount >= 3)
			{
				this.ironChunk_1_LOCKED.SetActive(false);
				this.ironChunk_1.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.ironChunk_2_purchased)
		{
			this.lines[192].SetActive(true);
			this.lines[193].SetActive(true);
			this.moreXP_8.SetActive(true);
			if (SkillTree.ironChunk_2_purchaseCount >= 3)
			{
				this.ironChunk_2_LOCKED.SetActive(false);
				this.ironChunk_2.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.fullIron_1_purchased)
		{
			this.lines[149].SetActive(true);
			this.lines[147].SetActive(true);
			this.lines[144].SetActive(true);
			this.lines[150].SetActive(true);
			if (SkillTree.ironChunk_1_purchased)
			{
				this.lines[143].SetActive(true);
				this.lines[145].SetActive(true);
			}
			this.fullGold_2.SetActive(true);
			this.spawnMoreRocks_6.SetActive(true);
			this.marterialsWorthMore_7.SetActive(true);
			if (SkillTree.fullIron_1_purchaseCount >= 2)
			{
				this.fullIron_1_LOCKED.SetActive(false);
				this.fullIron_1.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.fullIron_2_purchased && SkillTree.fullIron_2_purchaseCount >= 2)
		{
			this.fullIron_2_LOCKED.SetActive(false);
			this.fullIron_2.GetComponent<Button>().enabled = false;
		}
		if (SkillTree.cobaltSpawn_purchased)
		{
			this.cobaltBarFrame.SetActive(true);
			this.lines[161].SetActive(true);
			this.lines[152].SetActive(true);
			this.lines[151].SetActive(true);
			this.lines[146].SetActive(true);
			if (SkillTree.spawnMoreRocks_6_purchased)
			{
				this.lines[147].SetActive(true);
			}
			if (SkillTree.fullGold_2_purchased)
			{
				this.lines[164].SetActive(true);
			}
			this.spawnMoreRocks_6.SetActive(true);
			this.cobaltChunk_1.SetActive(true);
			this.moreMeterialsFromRock_4.SetActive(true);
			this.fullGold_2.SetActive(true);
			if (SkillTree.cobaltSpawn_purchaseCount >= 1)
			{
				this.cobaltSpawn_LOCKED.SetActive(false);
				this.cobaltSpawn.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.cobaltChunk_1_purchased)
		{
			this.lines[152].SetActive(true);
			this.lines[153].SetActive(true);
			this.fullCobalt_1.SetActive(true);
			if (SkillTree.cobaltChunk_1_purchaseCount >= 3)
			{
				this.cobaltChunk_1_LOCKED.SetActive(false);
				this.cobaltChunk_1.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.fullCobalt_1_purchased)
		{
			this.lines[154].SetActive(true);
			this.moreXP_6.SetActive(true);
			if (SkillTree.fullCobalt_1_purchaseCount >= 2)
			{
				this.fullCobalt_1_LOCKED.SetActive(false);
				this.fullCobalt_1.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.uraniumSpawn_purchased)
		{
			this.uraniumiumBarFrame.SetActive(true);
			this.lines[159].SetActive(true);
			this.lines[156].SetActive(true);
			this.lines[155].SetActive(true);
			this.lines[148].SetActive(true);
			if (SkillTree.moreMeterialsFromRock_4_purchased)
			{
				this.lines[165].SetActive(true);
			}
			if (SkillTree.fullGold_2_purchased)
			{
				this.lines[165].SetActive(true);
			}
			if (SkillTree.ironChunk_1_purchased)
			{
				this.lines[143].SetActive(true);
				this.lines[149].SetActive(true);
			}
			this.uraniumChunk_1.SetActive(true);
			this.spawnMoreRocks_7.SetActive(true);
			this.fullGold_2.SetActive(true);
			this.marterialsWorthMore_7.SetActive(true);
			if (SkillTree.uraniumSpawn_purchaseCount >= 1)
			{
				this.uraniumSpawn_LOCKED.SetActive(false);
				this.uraniumSpawn.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.uraniumChunk_1_purchased)
		{
			this.lines[156].SetActive(true);
			this.lines[157].SetActive(true);
			this.fullUranium_1.SetActive(true);
			if (SkillTree.uraniumChunk_1_purchaseCount >= 3)
			{
				this.uraniumChunk_1_LOCKED.SetActive(false);
				this.uraniumChunk_1.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.fullUranium_1_purchased)
		{
			this.lines[158].SetActive(true);
			this.moreXP_7.SetActive(true);
			if (SkillTree.fullUranium_1_purchaseCount >= 2)
			{
				this.fullUranium_1_LOCKED.SetActive(false);
				this.fullUranium_1.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.ismiumSpawn_purchased)
		{
			this.ismiumBarFrame.SetActive(true);
			this.lines[184].SetActive(true);
			this.lines[181].SetActive(true);
			this.lines[180].SetActive(true);
			if (SkillTree.spawnMoreRocks_9_purchased)
			{
				this.lines[182].SetActive(true);
			}
			if (SkillTree.increaseSpawnChanceAllRocks_purchased)
			{
				this.lines[182].SetActive(true);
			}
			this.ismiumChunk_1.SetActive(true);
			this.spawnMoreRocks_8.SetActive(true);
			if (SkillTree.ismiumSpawn_purchaseCount >= 1)
			{
				this.ismiumSpawn_LOCKED.SetActive(false);
				this.ismiumSpawn.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.ismiumChunk_1_purchased)
		{
			this.lines[189].SetActive(true);
			this.lines[185].SetActive(true);
			this.lines[184].SetActive(true);
			this.fullIsmium_1.SetActive(true);
			this.moreMeterialsFromRock_5.SetActive(true);
			if (SkillTree.ismiumChunk_1_purchaseCount >= 3)
			{
				this.ismiumChunk_1_LOCKED.SetActive(false);
				this.ismiumChunk_1.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.fullIsmium_1_purchased)
		{
			this.lines[185].SetActive(true);
			this.lines[186].SetActive(true);
			this.lines[190].SetActive(true);
			this.lines[192].SetActive(true);
			this.lines[187].SetActive(true);
			if (SkillTree.goldChunk_5_purchased)
			{
				this.lines[191].SetActive(true);
			}
			this.goldChunk_5_.SetActive(true);
			this.copperChunk_3.SetActive(true);
			this.ironChunk_2.SetActive(true);
			if (SkillTree.fullIsmium_1_purchaseCount >= 2)
			{
				this.fullIsmium_1_LOCKED.SetActive(false);
				this.fullIsmium_1.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.iridiumSpawn_purchased)
		{
			this.iridiumBarFRame.SetActive(true);
			this.lines[178].SetActive(true);
			this.lines[172].SetActive(true);
			this.lines[171].SetActive(true);
			this.lines[169].SetActive(true);
			if (SkillTree.increaseSpawnChanceAllRocks_purchased)
			{
				this.lines[183].SetActive(true);
			}
			this.iridiumChunk_1.SetActive(true);
			this.spawnMoreRocks_9.SetActive(true);
			this.spawnRockEveryXrock_3.SetActive(true);
			if (SkillTree.iridiumSpawn_purchaseCount >= 1)
			{
				this.iridiumSpawn_LOCKED.SetActive(false);
				this.iridiumSpawn.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.iridiumChunk_1_purchased)
		{
			this.lines[173].SetActive(true);
			this.fullIridium_1.SetActive(true);
			if (SkillTree.iridiumChunk_1_purchaseCount >= 3)
			{
				this.iridiumChunk_1_LOCKED.SetActive(false);
				this.iridiumChunk_1.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.fullIridium_1_purchased)
		{
			this.lines[176].SetActive(true);
			this.lines[175].SetActive(true);
			this.lines[174].SetActive(true);
			this.lines[173].SetActive(true);
			this.fullGold_3.SetActive(true);
			this.fullIron_2.SetActive(true);
			this.fullCopper_3.SetActive(true);
			if (SkillTree.fullIridium_1_purchaseCount >= 2)
			{
				this.fullIridium_1_LOCKED.SetActive(false);
				this.fullIridium_1.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.painiteSpawn_purchased)
		{
			this.painiteBarFrame.SetActive(true);
			this.lines[194].SetActive(true);
			this.lines[183].SetActive(true);
			this.lines[182].SetActive(true);
			this.lines[179].SetActive(true);
			if (SkillTree.iridiumSpawn_purchased)
			{
				this.lines[181].SetActive(true);
			}
			if (SkillTree.goldChunk_4_purchased)
			{
				this.lines[181].SetActive(true);
			}
			if (SkillTree.increaseSpawnChanceAllRocks_purchased)
			{
				this.lines[178].SetActive(true);
				this.lines[180].SetActive(true);
			}
			this.painiteChunk_1.SetActive(true);
			this.spawnMoreRocks_8.SetActive(true);
			this.spawnMoreRocks_9.SetActive(true);
			if (SkillTree.painiteSpawn_purchaseCount >= 1)
			{
				this.painiteSpawn_LOCKED.SetActive(false);
				this.painiteSpawn.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.painiteChunk_1_purchased)
		{
			this.lines[194].SetActive(true);
			this.lines[195].SetActive(true);
			this.fullPainite_1.SetActive(true);
			if (SkillTree.painiteChunk_1_purchaseCount >= 3)
			{
				this.painiteChunk_1_LOCKED.SetActive(false);
				this.painiteChunk_1.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.fullPainite_1_purchased)
		{
			this.lines[196].SetActive(true);
			this.lines[197].SetActive(true);
			this.finaLine.SetActive(true);
			this.craft2Material.SetActive(true);
			this.spawnXRockEveryXSecond_3.SetActive(true);
			this.finalUpgrade.SetActive(true);
			if (SkillTree.fullPainite_1_purchaseCount >= 2)
			{
				this.fullPainite_1_LOCKED.SetActive(false);
				this.fullPainite_1.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.improvedPickaxe_1_purchased)
		{
			this.lines[1].SetActive(true);
			this.lines[4].SetActive(true);
			this.lines[5].SetActive(true);
			this.lines[73].SetActive(true);
			this.lines[9].SetActive(true);
			this.lines[11].SetActive(true);
			this.moreXP_1.SetActive(true);
			this.pickaxeDoubleDamageChance_1.SetActive(true);
			this.chanceToMineRandomRock_1.SetActive(true);
			if (SkillTree.improvedPickaxe_1_purchaseCount >= 3)
			{
				this.improvedPickaxe_1_LOCKED.SetActive(false);
				this.improvedPickaxe_1.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.improvedPickaxe_2_purchased)
		{
			this.lines[77].SetActive(true);
			this.lines[78].SetActive(true);
			this.lines[80].SetActive(true);
			this.lines[83].SetActive(true);
			if (SkillTree.moreTime_2_purchased)
			{
				this.lines[81].SetActive(true);
			}
			if (SkillTree.chanceToMineRandomRock_1_purchased)
			{
				this.lines[75].SetActive(true);
			}
			this.moreTime_2.SetActive(true);
			this.lightningBeamChanceS_1.SetActive(true);
			this.lightningBeamChancePH_1.SetActive(true);
			if (SkillTree.improvedPickaxe_2_purchaseCount >= 3)
			{
				this.improvedPickaxe_2_LOCKED.SetActive(false);
				this.improvedPickaxe_2.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.improvedPickaxe_3_purchased)
		{
			this.lines[98].SetActive(true);
			this.lines[85].SetActive(true);
			this.lines[81].SetActive(true);
			this.lines[76].SetActive(true);
			if (SkillTree.moreTime_2_purchased)
			{
				this.lines[78].SetActive(true);
			}
			this.moreTime_2.SetActive(true);
			this.lightningBeamChanceS_1.SetActive(true);
			this.spawnPickaxeEverySecond_1.SetActive(true);
			this.chanceToSpawnRockWhenMined_4.SetActive(true);
			if (SkillTree.moreTime_2_purchased)
			{
				this.lines[88].SetActive(true);
			}
			if (SkillTree.improvedPickaxe_3_purchaseCount >= 3)
			{
				this.improvedPickaxe_3_LOCKED.SetActive(false);
				this.improvedPickaxe_3.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.improvedPickaxe_4_purchased && SkillTree.improvedPickaxe_4_purchaseCount >= 3)
		{
			this.improvedPickaxe_4_LOCKED.SetActive(false);
			this.improvedPickaxe_4.GetComponent<Button>().enabled = false;
		}
		if (SkillTree.improvedPickaxe_5_purchased && SkillTree.improvedPickaxe_5_purchaseCount >= 3)
		{
			this.improvedPickaxe_5_LOCKED.SetActive(false);
			this.improvedPickaxe_5.GetComponent<Button>().enabled = false;
		}
		if (SkillTree.improvedPickaxe_6_purchased)
		{
			this.lines[34].SetActive(true);
			this.lines[26].SetActive(true);
			if (SkillTree.spawnMoreRocks_4_purchased)
			{
				this.lines[20].SetActive(true);
			}
			if (SkillTree.biggerMiningErea_3_purchased)
			{
				this.lines[20].SetActive(true);
			}
			if (SkillTree.moreTime_4_purchased)
			{
				this.lines[25].SetActive(true);
			}
			this.biggerMiningErea_3.SetActive(true);
			this.intaMineChance_2.SetActive(true);
			if (SkillTree.improvedPickaxe_6_purchaseCount >= 3)
			{
				this.improvedPickaxe_6_LOCKED.SetActive(false);
				this.improvedPickaxe_6.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.moreXP_1_purchased)
		{
			this.lines[5].SetActive(true);
			this.lines[11].SetActive(true);
			this.lines[16].SetActive(true);
			this.lines[74].SetActive(true);
			if (SkillTree.spawnMoreRocks_2_purchased)
			{
				this.lines[12].SetActive(true);
			}
			if (SkillTree.improvedPickaxe_1_purchased)
			{
				this.lines[79].SetActive(true);
			}
			this.moreXP_2.SetActive(true);
			this.moreTime_1.SetActive(true);
			this.improvedPickaxe_1.SetActive(true);
			if (SkillTree.moreXP_1_purchaseCount >= 5)
			{
				this.moreXP_1_LOCKED.SetActive(false);
				this.moreXP_1.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.moreXP_2_purchased)
		{
			this.lines[16].SetActive(true);
			this.lines[17].SetActive(true);
			this.lines[12].SetActive(true);
			if (SkillTree.spawnPickaxeEverySecond_3_purchased)
			{
				this.lines[22].SetActive(true);
			}
			if (SkillTree.moreXP_1_purchased)
			{
				this.lines[15].SetActive(true);
			}
			if (SkillTree.spawnRockEveryXrock_1_purchased)
			{
				this.lines[23].SetActive(true);
			}
			if (SkillTree.chanceToSpawnRockWhenMined_1_purchased)
			{
				this.lines[13].SetActive(true);
			}
			this.spawnMoreRocks_3.SetActive(true);
			this.moreXP_1.SetActive(true);
			this.talentPointsPerXlevel_1.SetActive(true);
			if (SkillTree.moreXP_2_purchaseCount >= 5)
			{
				this.moreXP_2_LOCKED.SetActive(false);
				this.moreXP_2.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.moreXP_3_purchased)
		{
			this.lines[61].SetActive(true);
			this.lines[65].SetActive(true);
			this.lines[68].SetActive(true);
			this.lines[69].SetActive(true);
			if (SkillTree.spawnPickaxeEverySecond_2_purchased)
			{
				this.lines[62].SetActive(true);
				this.lines[70].SetActive(true);
			}
			if (SkillTree.shootCircleChance_purchased)
			{
				this.lines[62].SetActive(true);
			}
			if (SkillTree.biggerMiningErea_2_purchased)
			{
				this.lines[72].SetActive(true);
			}
			if (SkillTree.marterialsWorthMore_5_purchased)
			{
				this.lines[72].SetActive(true);
			}
			this.moreTime_3.SetActive(true);
			this.biggerMiningErea_2.SetActive(true);
			this.improvedPickaxe_5.SetActive(true);
			this.moreMeterialsFromRock_3.SetActive(true);
			if (SkillTree.moreXP_3_purchaseCount >= 3)
			{
				this.moreXP_3_LOCKED.SetActive(false);
				this.moreXP_3.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.moreXP_4_purchased)
		{
			this.lines[130].SetActive(true);
			this.lines[126].SetActive(true);
			this.lines[129].SetActive(true);
			if (SkillTree.spawnXRockEveryXSecond_2_purchased)
			{
				this.lines[129].SetActive(true);
			}
			this.fullCopper_1.SetActive(true);
			this.goldChunk_3.SetActive(true);
			if (SkillTree.moreXP_4_purchaseCount >= 3)
			{
				this.moreXP_4_LOCKED.SetActive(false);
				this.moreXP_4.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.moreXP_5_purchased)
		{
			this.lines[145].SetActive(true);
			this.lines[140].SetActive(true);
			this.lines[138].SetActive(true);
			this.lines[135].SetActive(true);
			if (SkillTree.spawnRockEveryXrock_1_purchased)
			{
				this.lines[136].SetActive(true);
				this.lines[134].SetActive(true);
			}
			this.ironChunk_1.SetActive(true);
			this.talentPointsPerXlevel_2.SetActive(true);
			this.spawnMoreRocks_6.SetActive(true);
			this.spawnRockEveryXrock_1.SetActive(true);
			if (SkillTree.moreXP_5_purchaseCount >= 4)
			{
				this.moreXP_5_LOCKED.SetActive(false);
				this.moreXP_5.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.moreXP_6_purchased && SkillTree.moreXP_6_purchaseCount >= 3)
		{
			this.moreXP_6_LOCKED.SetActive(false);
			this.moreXP_6.GetComponent<Button>().enabled = false;
		}
		if (SkillTree.moreXP_7_purchased && SkillTree.moreXP_7_purchaseCount >= 3)
		{
			this.moreXP_7_LOCKED.SetActive(false);
			this.moreXP_7.GetComponent<Button>().enabled = false;
		}
		if (SkillTree.moreXP_8_purchased && SkillTree.moreXP_8_purchaseCount >= 2)
		{
			this.moreXP_8_LOCKED.SetActive(false);
			this.moreXP_8.GetComponent<Button>().enabled = false;
		}
		if (SkillTree.talentPointsPerXlevel_1_purchased)
		{
			this.lines[17].SetActive(true);
			this.lines[22].SetActive(true);
			this.lines[23].SetActive(true);
			this.lines[36].SetActive(true);
			if (SkillTree.spawnMoreRocks_4_purchased)
			{
				this.lines[24].SetActive(true);
			}
			if (SkillTree.moreXP_2_purchased)
			{
				this.lines[18].SetActive(true);
			}
			if (SkillTree.doubleXpGoldChance_1_purchased)
			{
				this.lines[27].SetActive(true);
			}
			this.moreXP_2.SetActive(true);
			this.chanceToMineRandomRock_2.SetActive(true);
			this.moreTime_4.SetActive(true);
			this.doubleXpGoldChance_1.SetActive(true);
			if (SkillTree.talentPointsPerXlevel_1_purchaseCount >= 1)
			{
				this.talentPointsPerXlevel_1_LOCKED.SetActive(false);
				this.talentPointsPerXlevel_1.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.talentPointsPerXlevel_2_purchased)
		{
			this.lines[138].SetActive(true);
			this.lines[136].SetActive(true);
			this.moreXP_5.SetActive(true);
			this.chanceToSpawnRockWhenMined_5.SetActive(true);
			if (SkillTree.spawnIron_purchased)
			{
				this.lines[137].SetActive(true);
			}
			if (SkillTree.talentPointsPerXlevel_2_purchaseCount >= 1)
			{
				this.talentPointsPerXlevel_2_LOCKED.SetActive(false);
				this.talentPointsPerXlevel_2.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.talentPointsPerXlevel_3_purchased && SkillTree.talentPointsPerXlevel_3_purchaseCount >= 1)
		{
			this.talentPointsPerXlevel_3_LOCKED.SetActive(false);
			this.talentPointsPerXlevel_3.GetComponent<Button>().enabled = false;
		}
		if (SkillTree.biggerMiningErea_1_purchased)
		{
			this.lines[3].SetActive(true);
			this.lines[8].SetActive(true);
			this.lines[9].SetActive(true);
			this.lines[55].SetActive(true);
			this.lines[4].SetActive(true);
			this.lines[7].SetActive(true);
			if (SkillTree.fullGold_1_purchased)
			{
				this.lines[52].SetActive(true);
			}
			this.fullGold_1.SetActive(true);
			this.shootCircleChance.SetActive(true);
			this.pickaxeDoubleDamageChance_1.SetActive(true);
			if (SkillTree.biggerMiningErea_1_purchaseCount >= 5)
			{
				this.biggerMiningErea_1_LOCKED.SetActive(false);
				this.biggerMiningErea_1.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.biggerMiningErea_2_purchased)
		{
			this.lines[62].SetActive(true);
			this.lines[66].SetActive(true);
			this.lines[68].SetActive(true);
			this.lines[70].SetActive(true);
			if (SkillTree.chanceToSpawnRockWhenMined_3_purchased)
			{
				this.lines[64].SetActive(true);
			}
			if (SkillTree.doubleXpGoldChance_2_purchased)
			{
				this.lines[71].SetActive(true);
			}
			if (SkillTree.increaseAndDecreaseMinignErea_purchased)
			{
				this.lines[61].SetActive(true);
				this.lines[63].SetActive(true);
			}
			this.increaseAndDecreaseMinignErea.SetActive(true);
			this.doubleXpGoldChance_2.SetActive(true);
			this.moreXP_3.SetActive(true);
			this.chanceToSpawnRockWhenMined_3.SetActive(true);
			if (SkillTree.biggerMiningErea_2_purchaseCount >= 5)
			{
				this.biggerMiningErea_2_LOCKED.SetActive(false);
				this.biggerMiningErea_2.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.biggerMiningErea_3_purchased)
		{
			this.lines[34].SetActive(true);
			this.lines[35].SetActive(true);
			this.lines[38].SetActive(true);
			if (SkillTree.spawnMoreRocks_3_purchased)
			{
				this.lines[24].SetActive(true);
				this.lines[19].SetActive(true);
			}
			if (SkillTree.marterialsWorthMore_2_purchased)
			{
				this.lines[39].SetActive(true);
			}
			if (SkillTree.spawnMoreRocks_3_purchased)
			{
				this.lines[37].SetActive(true);
			}
			if (SkillTree.spawnPickaxeEverySecond_3_purchased)
			{
				this.lines[26].SetActive(true);
			}
			if (SkillTree.spawnXRockEveryXSecond_1_purchased)
			{
				this.lines[26].SetActive(true);
			}
			this.spawnCopper.SetActive(true);
			this.improvedPickaxe_6.SetActive(true);
			this.spawnXRockEveryXSecond_1.SetActive(true);
			if (SkillTree.biggerMiningErea_3_purchaseCount >= 5)
			{
				this.biggerMiningErea_3_LOCKED.SetActive(false);
				this.biggerMiningErea_3.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.biggerMiningErea_4_purchased)
		{
			this.lines[86].SetActive(true);
			this.lines[87].SetActive(true);
			this.pickaxeDoubleDamageChance_2.SetActive(true);
			if (SkillTree.biggerMiningErea_4_purchaseCount >= 5)
			{
				this.biggerMiningErea_4_LOCKED.SetActive(false);
				this.biggerMiningErea_4.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.shootCircleChance_purchased)
		{
			this.lines[51].SetActive(true);
			this.lines[52].SetActive(true);
			this.lines[55].SetActive(true);
			this.lines[59].SetActive(true);
			if (SkillTree.improvedPickaxe_1_purchased)
			{
				this.lines[56].SetActive(true);
			}
			if (SkillTree.goldChunk_1_purchased)
			{
				this.lines[57].SetActive(true);
			}
			if (SkillTree.biggerMiningErea_1_purchased)
			{
				this.lines[56].SetActive(true);
				this.lines[57].SetActive(true);
			}
			this.increaseAndDecreaseMinignErea.SetActive(true);
			this.intaMineChance_1.SetActive(true);
			this.chanceToMineRandomRock_3.SetActive(true);
			if (SkillTree.shootCircleChance_purchaseCount >= 1)
			{
				this.shootCircleChance_LOCKED.SetActive(false);
				this.shootCircleChance.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.increaseAndDecreaseMinignErea_purchased)
		{
			this.lines[62].SetActive(true);
			this.lines[59].SetActive(true);
			this.lines[54].SetActive(true);
			this.lines[53].SetActive(true);
			if (SkillTree.fullGold_1_purchased)
			{
				this.lines[58].SetActive(true);
			}
			if (SkillTree.shootCircleChance_purchased)
			{
				this.lines[58].SetActive(true);
				this.lines[60].SetActive(true);
			}
			this.shootCircleChance.SetActive(true);
			this.moreTime_3.SetActive(true);
			this.biggerMiningErea_2.SetActive(true);
			this.spawnPickaxeEverySecond_2.SetActive(true);
			if (SkillTree.increaseAndDecreaseMinignErea_purchaseCount >= 1)
			{
				this.increaseAndDecreaseMinignErea_LOCKED.SetActive(false);
				this.increaseAndDecreaseMinignErea.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.spawnRockEveryXrock_1_purchased)
		{
			this.lines[132].SetActive(true);
			this.lines[135].SetActive(true);
			this.lines[137].SetActive(true);
			this.lines[139].SetActive(true);
			if (SkillTree.spawnIron_purchased)
			{
				this.lines[140].SetActive(true);
			}
			if (SkillTree.fullCopper_1_purchased)
			{
				this.lines[133].SetActive(true);
			}
			this.moreXP_5.SetActive(true);
			this.spawnIron.SetActive(true);
			this.spawnMoreRocks_5.SetActive(true);
			this.chanceToSpawnRockWhenMined_5.SetActive(true);
			if (SkillTree.spawnRockEveryXrock_1_purchaseCount >= 1)
			{
				this.spawnRockEveryXrock_1_LOCKED.SetActive(false);
				this.spawnRockEveryXrock_1.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.spawnRockEveryXrock_2_purchased && SkillTree.spawnRockEveryXrock_2_purchaseCount >= 1)
		{
			this.spawnRockEveryXrock_2_LOCKED.SetActive(false);
			this.spawnRockEveryXrock_2.GetComponent<Button>().enabled = false;
		}
		if (SkillTree.spawnRockEveryXrock_3_purchased)
		{
			this.lines[170].SetActive(true);
			this.lines[169].SetActive(true);
			this.lines[171].SetActive(true);
			this.iridiumSpawn.SetActive(true);
			if (SkillTree.spawnRockEveryXrock_3_purchaseCount >= 1)
			{
				this.spawnRockEveryXrock_3_LOCKED.SetActive(false);
				this.spawnRockEveryXrock_3.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.spawnXRockEveryXSecond_1_purchased)
		{
			this.lines[19].SetActive(true);
			this.lines[20].SetActive(true);
			this.lines[24].SetActive(true);
			this.lines[35].SetActive(true);
			if (SkillTree.marterialsWorthMore_2_purchased)
			{
				this.lines[38].SetActive(true);
			}
			if (SkillTree.moreXP_2_purchased)
			{
				this.lines[23].SetActive(true);
			}
			if (SkillTree.chanceToSpawnRockWhenMined_2_purchased)
			{
				this.lines[33].SetActive(true);
			}
			if (SkillTree.doubleXpGoldChance_1_purchased)
			{
				this.lines[25].SetActive(true);
			}
			if (SkillTree.spawnMoreRocks_3_purchased)
			{
				this.lines[18].SetActive(true);
			}
			if (SkillTree.spawnMoreRocks_4_purchased)
			{
				this.lines[38].SetActive(true);
				this.lines[18].SetActive(true);
			}
			this.intaMineChance_2.SetActive(true);
			this.doubleXpGoldChance_1.SetActive(true);
			this.spawnMoreRocks_4.SetActive(true);
			this.biggerMiningErea_3.SetActive(true);
			if (SkillTree.spawnXRockEveryXSecond_1_purchaseCount >= 1)
			{
				this.spawnXRockEveryXSecond_1_LOCKED.SetActive(false);
				this.spawnXRockEveryXSecond_1.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.spawnXRockEveryXSecond_2_purchased)
		{
			this.lines[133].SetActive(true);
			this.lines[129].SetActive(true);
			this.lines[128].SetActive(true);
			this.lines[125].SetActive(true);
			this.lines[131].SetActive(true);
			this.lines[130].SetActive(true);
			this.spawnIron.SetActive(true);
			this.spawnMoreRocks_5.SetActive(true);
			this.goldChunk_3.SetActive(true);
			if (SkillTree.spawnXRockEveryXSecond_2_purchaseCount >= 1)
			{
				this.spawnXRockEveryXSecond_2_LOCKED.SetActive(false);
				this.spawnXRockEveryXSecond_2.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.spawnXRockEveryXSecond_3_purchased && SkillTree.spawnXRockEveryXSecond_3_purchaseCount >= 1)
		{
			this.spawnXRockEveryXSecond_3_LOCKED.SetActive(false);
			this.spawnXRockEveryXSecond_3.GetComponent<Button>().enabled = false;
		}
		if (SkillTree.chanceToSpawnRockWhenMined_1_purchased)
		{
			this.lines[6].SetActive(true);
			this.lines[10].SetActive(true);
			this.lines[14].SetActive(true);
			this.lines[44].SetActive(true);
			if (SkillTree.spawnMoreRocks_2_purchased)
			{
				this.lines[13].SetActive(true);
			}
			if (SkillTree.marterialsWorthMore_2_purchased)
			{
				this.lines[37].SetActive(true);
			}
			this.spawnMoreRocks_4.SetActive(true);
			this.marterialsWorthMore_2.SetActive(true);
			if (SkillTree.chanceToSpawnRockWhenMined_1_purchaseCount >= 6)
			{
				this.chanceToSpawnRockWhenMined_1_LOCKED.SetActive(false);
				this.chanceToSpawnRockWhenMined_1.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.chanceToSpawnRockWhenMined_2_purchased)
		{
			this.lines[31].SetActive(true);
			this.lines[30].SetActive(true);
			this.lines[29].SetActive(true);
			this.lines[28].SetActive(true);
			if (SkillTree.talentPointsPerXlevel_1_purchased)
			{
				this.lines[32].SetActive(true);
			}
			if (SkillTree.spawnPickaxeEverySecond_3_purchased)
			{
				this.lines[32].SetActive(true);
				this.lines[33].SetActive(true);
			}
			this.doubleXpGoldChance_5.SetActive(true);
			this.marterialsWorthMore_4.SetActive(true);
			this.moreMeterialsFromRock_2.SetActive(true);
			if (SkillTree.chanceToSpawnRockWhenMined_2_purchaseCount >= 3)
			{
				this.chanceToSpawnRockWhenMined_2_LOCKED.SetActive(false);
				this.chanceToSpawnRockWhenMined_2.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.chanceToSpawnRockWhenMined_3_purchased)
		{
			this.lines[67].SetActive(true);
			this.lines[71].SetActive(true);
			this.lines[72].SetActive(true);
			if (SkillTree.biggerMiningErea_2_purchased)
			{
				this.lines[65].SetActive(true);
				this.lines[67].SetActive(true);
			}
			if (SkillTree.spawnPickaxeEverySecond_2_purchased)
			{
				this.lines[64].SetActive(true);
			}
			if (SkillTree.increaseAndDecreaseMinignErea_purchased)
			{
				this.lines[66].SetActive(true);
			}
			this.doubleXpGoldChance_4.SetActive(true);
			this.marterialsWorthMore_5.SetActive(true);
			this.moreMeterialsFromRock_3.SetActive(true);
			if (SkillTree.chanceToSpawnRockWhenMined_3_purchaseCount >= 3)
			{
				this.chanceToSpawnRockWhenMined_3_LOCKED.SetActive(false);
				this.chanceToSpawnRockWhenMined_3.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.chanceToSpawnRockWhenMined_4_purchased)
		{
			this.lines[99].SetActive(true);
			this.dynamiteChance_1.SetActive(true);
			if (SkillTree.chanceToSpawnRockWhenMined_4_purchaseCount >= 3)
			{
				this.chanceToSpawnRockWhenMined_4_LOCKED.SetActive(false);
				this.chanceToSpawnRockWhenMined_4.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.chanceToSpawnRockWhenMined_5_purchased)
		{
			this.lines[137].SetActive(true);
			this.lines[136].SetActive(true);
			if (SkillTree.spawnRockEveryXrock_1_purchased)
			{
				this.lines[138].SetActive(true);
			}
			this.talentPointsPerXlevel_2.SetActive(true);
			if (SkillTree.chanceToSpawnRockWhenMined_5_purchaseCount >= 3)
			{
				this.chanceToSpawnRockWhenMined_5_LOCKED.SetActive(false);
				this.chanceToSpawnRockWhenMined_5.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.chanceToSpawnRockWhenMined_6_purchased)
		{
			this.lines[166].SetActive(true);
			this.lines[162].SetActive(true);
			if (SkillTree.moreMeterialsFromRock_4_purchased)
			{
				this.lines[163].SetActive(true);
			}
			this.fullCopper_2.SetActive(true);
			if (SkillTree.chanceToSpawnRockWhenMined_6_purchaseCount >= 1)
			{
				this.chanceToSpawnRockWhenMined_6_LOCKED.SetActive(false);
				this.chanceToSpawnRockWhenMined_6.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.chanceToMineRandomRock_1_purchased)
		{
			this.lines[73].SetActive(true);
			this.lines[77].SetActive(true);
			this.lines[79].SetActive(true);
			if (SkillTree.spawnMoreRocks_2_purchased)
			{
				this.lines[74].SetActive(true);
			}
			if (SkillTree.improvedPickaxe_1_purchased)
			{
				this.lines[74].SetActive(true);
			}
			this.improvedPickaxe_1.SetActive(true);
			this.improvedPickaxe_2.SetActive(true);
			this.moreTime_1.SetActive(true);
			if (SkillTree.chanceToMineRandomRock_1_purchaseCount >= 4)
			{
				this.chanceToMineRandomRock_1_LOCKED.SetActive(false);
				this.chanceToMineRandomRock_1.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.chanceToMineRandomRock_2_purchased && SkillTree.chanceToMineRandomRock_2_purchaseCount >= 3)
		{
			this.chanceToMineRandomRock_2_LOCKED.SetActive(false);
			this.chanceToMineRandomRock_2.GetComponent<Button>().enabled = false;
		}
		if (SkillTree.chanceToMineRandomRock_3_purchased)
		{
			this.lines[52].SetActive(true);
			this.lines[57].SetActive(true);
			this.lines[58].SetActive(true);
			if (SkillTree.shootCircleChance_purchased)
			{
				this.lines[53].SetActive(true);
			}
			if (SkillTree.fullGold_1_purchased)
			{
				this.lines[55].SetActive(true);
			}
			if (SkillTree.moreTime_3_purchased)
			{
				this.lines[53].SetActive(true);
			}
			this.fullGold_1.SetActive(true);
			this.shootCircleChance.SetActive(true);
			this.spawnPickaxeEverySecond_2.SetActive(true);
			if (SkillTree.chanceToMineRandomRock_3_purchaseCount >= 3)
			{
				this.chanceToMineRandomRock_3_LOCKED.SetActive(false);
				this.chanceToMineRandomRock_3.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.chanceToMineRandomRock_4_purchased && SkillTree.chanceToMineRandomRock_4_purchaseCount >= 3)
		{
			this.chanceToMineRandomRock_4_LOCKED.SetActive(false);
			this.chanceToMineRandomRock_4.GetComponent<Button>().enabled = false;
		}
		if (SkillTree.spawnPickaxeEverySecond_1_purchased)
		{
			this.lines[88].SetActive(true);
			this.lines[86].SetActive(true);
			this.lines[85].SetActive(true);
			this.biggerMiningErea_4.SetActive(true);
			this.chanceToAdd1SecondEverySecond.SetActive(true);
			if (SkillTree.spawnPickaxeEverySecond_1_purchaseCount >= 1)
			{
				this.spawnPickaxeEverySecond_1_LOCKED.SetActive(false);
				this.spawnPickaxeEverySecond_1.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.spawnPickaxeEverySecond_2_purchased)
		{
			this.lines[63].SetActive(true);
			this.lines[58].SetActive(true);
			this.lines[53].SetActive(true);
			if (SkillTree.goldChunk_1_purchased)
			{
				this.lines[57].SetActive(true);
			}
			if (SkillTree.intaMineChance_1_purchased)
			{
				this.lines[52].SetActive(true);
			}
			if (SkillTree.chanceToMineRandomRock_3_purchased)
			{
				this.lines[59].SetActive(true);
			}
			if (SkillTree.increaseAndDecreaseMinignErea_purchased)
			{
				this.lines[70].SetActive(true);
			}
			this.increaseAndDecreaseMinignErea.SetActive(true);
			this.doubleXpGoldChance_2.SetActive(true);
			this.chanceToMineRandomRock_3.SetActive(true);
			if (SkillTree.spawnPickaxeEverySecond_2_purchaseCount >= 1)
			{
				this.spawnPickaxeEverySecond_2_LOCKED.SetActive(false);
				this.spawnPickaxeEverySecond_2.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.spawnPickaxeEverySecond_3_purchased)
		{
			this.lines[31].SetActive(true);
			this.lines[27].SetActive(true);
			this.lines[25].SetActive(true);
			this.lines[21].SetActive(true);
			if (SkillTree.spawnMoreRocks_4_purchased)
			{
				this.lines[20].SetActive(true);
			}
			if (SkillTree.doubleXpGoldChance_1_purchased)
			{
				this.lines[20].SetActive(true);
				this.lines[22].SetActive(true);
			}
			if (SkillTree.moreTime_4_purchased)
			{
				this.lines[28].SetActive(true);
			}
			this.moreTime_4.SetActive(true);
			this.doubleXpGoldChance_1.SetActive(true);
			this.intaMineChance_2.SetActive(true);
			this.chanceToSpawnRockWhenMined_2.SetActive(true);
			if (SkillTree.spawnPickaxeEverySecond_3_purchaseCount >= 1)
			{
				this.spawnPickaxeEverySecond_3_LOCKED.SetActive(false);
				this.spawnPickaxeEverySecond_3.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.moreTime_1_purchased)
		{
			this.lines[74].SetActive(true);
			this.lines[75].SetActive(true);
			this.lines[79].SetActive(true);
			if (SkillTree.moreXP_1_purchased)
			{
				this.lines[73].SetActive(true);
			}
			if (SkillTree.chanceToMineRandomRock_1_purchased)
			{
				this.lines[80].SetActive(true);
			}
			this.moreTime_2.SetActive(true);
			this.moreXP_1.SetActive(true);
			this.chanceToMineRandomRock_1.SetActive(true);
			if (SkillTree.moreTime_1_purchaseCount >= 5)
			{
				this.moreTime_1_LOCKED.SetActive(false);
				this.moreTime_1.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.moreTime_2_purchased)
		{
			this.lines[80].SetActive(true);
			this.lines[82].SetActive(true);
			this.lines[75].SetActive(true);
			this.lines[76].SetActive(true);
			if (SkillTree.moreTime_1_purchased)
			{
				this.lines[77].SetActive(true);
			}
			if (SkillTree.improvedPickaxe_1_purchased)
			{
				this.lines[77].SetActive(true);
			}
			this.moreTime_1.SetActive(true);
			this.improvedPickaxe_2.SetActive(true);
			this.improvedPickaxe_3.SetActive(true);
			this.chanceToAdd1SecondEverySecond.SetActive(true);
			if (SkillTree.moreTime_2_purchaseCount >= 4)
			{
				this.moreTime_2_LOCKED.SetActive(false);
				this.moreTime_2.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.moreTime_3_purchased)
		{
			this.lines[61].SetActive(true);
			this.lines[60].SetActive(true);
			this.lines[54].SetActive(true);
			if (SkillTree.chanceToSpawnRockWhenMined_3_purchased)
			{
				this.lines[65].SetActive(true);
			}
			if (SkillTree.intaMineChance_1_purchased)
			{
				this.lines[59].SetActive(true);
			}
			if (SkillTree.increaseAndDecreaseMinignErea_purchased)
			{
				this.lines[68].SetActive(true);
			}
			this.intaMineChance_1.SetActive(true);
			this.increaseAndDecreaseMinignErea.SetActive(true);
			this.moreXP_3.SetActive(true);
			if (SkillTree.moreTime_3_purchaseCount >= 3)
			{
				this.moreTime_3_LOCKED.SetActive(false);
				this.moreTime_3.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.moreTime_4_purchased)
		{
			this.lines[32].SetActive(true);
			this.lines[27].SetActive(true);
			this.lines[22].SetActive(true);
			if (SkillTree.spawnXRockEveryXSecond_1_purchased)
			{
				this.lines[25].SetActive(true);
			}
			if (SkillTree.talentPointsPerXlevel_1_purchased)
			{
				this.lines[21].SetActive(true);
			}
			this.marterialsWorthMore_4.SetActive(true);
			this.spawnPickaxeEverySecond_3.SetActive(true);
			this.talentPointsPerXlevel_1.SetActive(true);
			if (SkillTree.moreTime_4_purchaseCount >= 3)
			{
				this.moreTime_4_LOCKED.SetActive(false);
				this.moreTime_4.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.chanceToAdd1SecondEverySecond_purchased)
		{
			this.lines[88].SetActive(true);
			this.lines[82].SetActive(true);
			if (SkillTree.moreTime_2_purchased)
			{
				this.lines[85].SetActive(true);
			}
			this.spawnPickaxeEverySecond_1.SetActive(true);
			if (SkillTree.chanceToAdd1SecondEverySecond_purchaseCount >= 1)
			{
				this.chanceToAdd1SecondEverySecond_LOCKED.SetActive(false);
				this.chanceToAdd1SecondEverySecond.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.chanceAdd1SecondEveryRockMined_purchased)
		{
			this.lines[143].SetActive(true);
			this.lines[142].SetActive(true);
			if (SkillTree.ironChunk_1_purchased)
			{
				this.lines[149].SetActive(true);
			}
			this.marterialsWorthMore_7.SetActive(true);
			this.spawnRockEveryXrock_2.SetActive(true);
			if (SkillTree.chanceAdd1SecondEveryRockMined_purchaseCount >= 1)
			{
				this.chanceAdd1SecondEveryRockMined_LOCKED.SetActive(false);
				this.chanceAdd1SecondEveryRockMined.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.doubleXpGoldChance_1_purchased)
		{
			this.lines[24].SetActive(true);
			this.lines[23].SetActive(true);
			this.lines[21].SetActive(true);
			this.lines[18].SetActive(true);
			if (SkillTree.spawnMoreRocks_3_purchased)
			{
				this.lines[17].SetActive(true);
				this.lines[19].SetActive(true);
			}
			if (SkillTree.spawnXRockEveryXSecond_1_purchased)
			{
				this.lines[25].SetActive(true);
			}
			if (SkillTree.moreTime_4_purchased)
			{
				this.lines[27].SetActive(true);
			}
			this.talentPointsPerXlevel_1.SetActive(true);
			this.spawnMoreRocks_3.SetActive(true);
			this.spawnXRockEveryXSecond_1.SetActive(true);
			this.spawnPickaxeEverySecond_3.SetActive(true);
			if (SkillTree.doubleXpGoldChance_1_purchaseCount >= 3)
			{
				this.doubleXpGoldChance_1_LOCKED.SetActive(false);
				this.doubleXpGoldChance_1.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.doubleXpGoldChance_2_purchased)
		{
			this.lines[70].SetActive(true);
			this.lines[64].SetActive(true);
			this.lines[63].SetActive(true);
			if (SkillTree.moreTime_3_purchased)
			{
				this.lines[62].SetActive(true);
				this.lines[68].SetActive(true);
			}
			if (SkillTree.spawnPickaxeEverySecond_2_purchased)
			{
				this.lines[62].SetActive(true);
			}
			if (SkillTree.increaseAndDecreaseMinignErea_purchased)
			{
				this.lines[70].SetActive(true);
			}
			this.biggerMiningErea_2.SetActive(true);
			this.marterialsWorthMore_5.SetActive(true);
			this.spawnPickaxeEverySecond_2.SetActive(true);
			if (SkillTree.doubleXpGoldChance_2_purchaseCount >= 3)
			{
				this.doubleXpGoldChance_2_LOCKED.SetActive(false);
				this.doubleXpGoldChance_2.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.doubleXpGoldChance_3_purchased)
		{
			this.lines[49].SetActive(true);
			this.lines[48].SetActive(true);
			this.lines[42].SetActive(true);
			if (SkillTree.marterialsWorthMore_1_purchased)
			{
				this.lines[46].SetActive(true);
			}
			if (SkillTree.goldChunk_1_purchased)
			{
				this.lines[46].SetActive(true);
			}
			this.goldChunk_2.SetActive(true);
			this.marterialsWorthMore_3.SetActive(true);
			this.moreMeterialsFromRock_1.SetActive(true);
			if (SkillTree.doubleXpGoldChance_3_purchaseCount >= 3)
			{
				this.doubleXpGoldChance_3_LOCKED.SetActive(false);
				this.doubleXpGoldChance_3.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.doubleXpGoldChance_4_purchased && SkillTree.doubleXpGoldChance_4_purchaseCount >= 3)
		{
			this.doubleXpGoldChance_4_LOCKED.SetActive(false);
			this.doubleXpGoldChance_4.GetComponent<Button>().enabled = false;
		}
		if (SkillTree.doubleXpGoldChance_5_purchased && SkillTree.doubleXpGoldChance_5_purchaseCount >= 3)
		{
			this.doubleXpGoldChance_5_LOCKED.SetActive(false);
			this.doubleXpGoldChance_5.GetComponent<Button>().enabled = false;
		}
		if (SkillTree.lightningBeamChanceS_1_purchased)
		{
			this.lines[84].SetActive(true);
			this.lines[81].SetActive(true);
			this.lines[78].SetActive(true);
			if (SkillTree.moreTime_1_purchased)
			{
				this.lines[76].SetActive(true);
			}
			if (SkillTree.improvedPickaxe_2_purchased)
			{
				this.lines[89].SetActive(true);
				this.lines[76].SetActive(true);
			}
			this.improvedPickaxe_2.SetActive(true);
			this.improvedPickaxe_3.SetActive(true);
			this.lightningBeamDamage.SetActive(true);
			if (SkillTree.lightningBeamChanceS_1_purchaseCount >= 5)
			{
				this.lightningBeamChanceS_1_LOCKED.SetActive(false);
				this.lightningBeamChanceS_1.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.lightningBeamChanceS_2_purchased)
		{
			this.lines[95].SetActive(true);
			this.lines[92].SetActive(true);
			this.lines[91].SetActive(true);
			this.lightningBeamChancePH_2.SetActive(true);
			this.lightningSplashes.SetActive(true);
			if (SkillTree.lightningBeamChanceS_2_purchaseCount >= 5)
			{
				this.lightningBeamChanceS_2_LOCKED.SetActive(false);
				this.lightningBeamChanceS_2.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.lightningBeamChancePH_1_purchased)
		{
			this.lines[89].SetActive(true);
			this.lines[83].SetActive(true);
			if (SkillTree.improvedPickaxe_2_purchased)
			{
				this.lines[84].SetActive(true);
			}
			this.lightningBeamDamage.SetActive(true);
			if (SkillTree.lightningBeamChancePH_1_purchaseCount >= 3)
			{
				this.lightningBeamChancePH_1_LOCKED.SetActive(false);
				this.lightningBeamChancePH_1.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.lightningBeamChancePH_2_purchased)
		{
			this.lines[96].SetActive(true);
			this.lightningBeamAddTime.SetActive(true);
			if (SkillTree.lightningBeamChancePH_2_purchaseCount >= 3)
			{
				this.lightningBeamChancePH_2_LOCKED.SetActive(false);
				this.lightningBeamChancePH_2.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.lightningBeamSpawnAnotherOneChance_purchased && SkillTree.lightningBeamSpawnAnotherOneChance_purchaseCount >= 1)
		{
			this.lightningBeamSpawnAnotherOneChance_LOCKED.SetActive(false);
			this.lightningBeamSpawnAnotherOneChance.GetComponent<Button>().enabled = false;
		}
		if (SkillTree.lightningBeamDamage_purchased)
		{
			this.lines[90].SetActive(true);
			this.lines[89].SetActive(true);
			this.lines[84].SetActive(true);
			if (SkillTree.moreTime_2_purchased)
			{
				this.lines[83].SetActive(true);
			}
			if (SkillTree.lightningBeamChanceS_1_purchased)
			{
				this.lines[83].SetActive(true);
			}
			this.lightningBeamSize.SetActive(true);
			this.lightningBeamChancePH_1.SetActive(true);
			if (SkillTree.lightningBeamDamage_purchaseCount >= 3)
			{
				this.lightningBeamDamage_LOCKED.SetActive(false);
				this.lightningBeamDamage.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.lightningBeamSize_purchased)
		{
			this.lines[91].SetActive(true);
			this.lightningBeamChanceS_2.SetActive(true);
			if (SkillTree.lightningBeamSize_purchaseCount >= 3)
			{
				this.lightningBeamSize_LOCKED.SetActive(false);
				this.lightningBeamSize.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.lightningSplashes_purchased)
		{
			this.lines[92].SetActive(true);
			this.lines[93].SetActive(true);
			this.lines[94].SetActive(true);
			this.lightningBeamSpawnRock.SetActive(true);
			this.lightningBeamSpawnAnotherOneChance.SetActive(true);
			if (SkillTree.lightningSplashes_purchaseCount >= 1)
			{
				this.lightningSplashes_LOCKED.SetActive(false);
				this.lightningSplashes.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.lightningBeamSpawnRock_purchased && SkillTree.lightningBeamSpawnRock_purchaseCount >= 1)
		{
			this.lightningBeamSpawnRock_LOCKED.SetActive(false);
			this.lightningBeamSpawnRock.GetComponent<Button>().enabled = false;
		}
		if (SkillTree.lightningBeamExplosion_purchased && SkillTree.lightningBeamExplosion_purchaseCount >= 1)
		{
			this.lightningBeamExplosion_LOCKED.SetActive(false);
			this.lightningBeamExplosion.GetComponent<Button>().enabled = false;
		}
		if (SkillTree.lightningBeamAddTime_purchased)
		{
			this.lines[97].SetActive(true);
			this.lightningBeamExplosion.SetActive(true);
			if (SkillTree.lightningBeamAddTime_purchaseCount >= 1)
			{
				this.lightningBeamAddTime_LOCKED.SetActive(false);
				this.lightningBeamAddTime.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.dynamiteChance_1_purchased)
		{
			this.lines[99].SetActive(true);
			this.lines[100].SetActive(true);
			this.lines[101].SetActive(true);
			this.lines[102].SetActive(true);
			this.dynamiteExplosionSize.SetActive(true);
			this.dynamiteSpawn2SmallChance.SetActive(true);
			this.dynamiteDamage.SetActive(true);
			if (SkillTree.dynamiteChance_1_purchaseCount >= 3)
			{
				this.dynamiteChance_1_LOCKED.SetActive(false);
				this.dynamiteChance_1.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.dynamiteChance_2_purchased)
		{
			this.lines[103].SetActive(true);
			this.lines[104].SetActive(true);
			this.lines[113].SetActive(true);
			if (SkillTree.dynamiteSpawn2SmallChance_purchased)
			{
				this.lines[107].SetActive(true);
			}
			this.dynamiteExplosionAddTimeChance.SetActive(true);
			this.plazmaBallSpawn_1.SetActive(true);
			if (SkillTree.dynamiteChance_2_purchaseCount >= 3)
			{
				this.dynamiteChance_2_LOCKED.SetActive(false);
				this.dynamiteChance_2.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.dynamiteSpawn2SmallChance_purchased)
		{
			this.lines[102].SetActive(true);
			this.lines[103].SetActive(true);
			this.lines[112].SetActive(true);
			this.lines[106].SetActive(true);
			this.dynamiteChance_2.SetActive(true);
			this.dynamiteExplosionSpawnRock.SetActive(true);
			if (SkillTree.dynamiteSpawn2SmallChance_purchaseCount >= 1)
			{
				this.dynamiteSpawn2SmallChance_LOCKED.SetActive(false);
				this.dynamiteSpawn2SmallChance.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.dynamiteExplosionSize_purchased && SkillTree.dynamiteExplosionSize_purchaseCount >= 3)
		{
			this.dynamiteExplosionSize_LOCKED.SetActive(false);
			this.dynamiteExplosionSize.GetComponent<Button>().enabled = false;
		}
		if (SkillTree.dynamiteDamage_purchased)
		{
			this.lines[101].SetActive(true);
			this.lines[106].SetActive(true);
			this.lines[112].SetActive(true);
			this.dynamiteExplosionSpawnRock.SetActive(true);
			if (SkillTree.dynamiteDamage_purchaseCount >= 3)
			{
				this.dynamiteDamage_LOCKED.SetActive(false);
				this.dynamiteDamage.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.dynamiteExplosionSpawnRock_purchased)
		{
			this.lines[106].SetActive(true);
			this.lines[107].SetActive(true);
			this.lines[112].SetActive(true);
			if (SkillTree.dynamiteSpawn2SmallChance_purchased)
			{
				this.lines[113].SetActive(true);
			}
			this.dynamiteExplosionAddTimeChance.SetActive(true);
			if (SkillTree.dynamiteExplosionSpawnRock_purchaseCount >= 1)
			{
				this.dynamiteExplosionSpawnRock_LOCKED.SetActive(false);
				this.dynamiteExplosionSpawnRock.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.dynamiteExplosionAddTimeChance_purchased)
		{
			this.lines[107].SetActive(true);
			this.lines[113].SetActive(true);
			this.lines[120].SetActive(true);
			this.lines[103].SetActive(true);
			this.dynamiteExplosionSpawnLightning.SetActive(true);
			this.dynamiteChance_2.SetActive(true);
			if (SkillTree.dynamiteExplosionAddTimeChance_purchaseCount >= 1)
			{
				this.dynamiteExplosionAddTimeChance_LOCKED.SetActive(false);
				this.dynamiteExplosionAddTimeChance.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.dynamiteExplosionSpawnLightning_purchased)
		{
			this.lines[119].SetActive(true);
			this.lines[120].SetActive(true);
			this.allProjectileDoubleDamageChance.SetActive(true);
			if (SkillTree.dynamiteExplosionSpawnLightning_purchaseCount >= 1)
			{
				this.dynamiteExplosionSpawnLightning_LOCKED.SetActive(false);
				this.dynamiteExplosionSpawnLightning.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.plazmaBallSpawn_1_purchased)
		{
			this.lines[104].SetActive(true);
			this.lines[105].SetActive(true);
			this.lines[116].SetActive(true);
			this.plazmaBallSize.SetActive(true);
			this.plazmaBallTime.SetActive(true);
			if (SkillTree.plazmaBallSpawn_1_purchaseCount >= 3)
			{
				this.plazmaBallSpawn_1_LOCKED.SetActive(false);
				this.plazmaBallSpawn_1.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.plazmaBallSpawn_2_purchased)
		{
			this.lines[110].SetActive(true);
			this.plazmaBallExplosionChance.SetActive(true);
			if (SkillTree.plazmaBallSpawn_2_purchaseCount >= 3)
			{
				this.plazmaBallSpawn_2_LOCKED.SetActive(false);
				this.plazmaBallSpawn_2.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.plazmaBallTime_purchased)
		{
			this.lines[114].SetActive(true);
			this.lines[116].SetActive(true);
			this.lines[118].SetActive(true);
			if (SkillTree.plazmaBallSpawn_1_purchased)
			{
				this.lines[117].SetActive(true);
			}
			this.plazmaBallDamage.SetActive(true);
			this.plazmaBallSpawnSmallChance.SetActive(true);
			if (SkillTree.plazmaBallTime_purchaseCount >= 3)
			{
				this.plazmaBallTime_LOCKED.SetActive(false);
				this.plazmaBallTime.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.plazmaBallSize_purchased)
		{
			this.lines[117].SetActive(true);
			this.lines[115].SetActive(true);
			this.lines[105].SetActive(true);
			if (SkillTree.plazmaBallSpawn_1_purchased)
			{
				this.lines[118].SetActive(true);
			}
			this.plazmaBallSpawnSmallChance.SetActive(true);
			this.plazmaBallSpawn_2.SetActive(true);
			if (SkillTree.plazmaBallSize_purchaseCount >= 3)
			{
				this.plazmaBallSize_LOCKED.SetActive(false);
				this.plazmaBallSize.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.plazmaBallExplosionChance_purchased)
		{
			this.lines[111].SetActive(true);
			this.plazmaBallSpawnPickaxeChance.SetActive(true);
			if (SkillTree.plazmaBallExplosionChance_purchaseCount >= 1)
			{
				this.plazmaBallExplosionChance_LOCKED.SetActive(false);
				this.plazmaBallExplosionChance.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.plazmaBallSpawnSmallChance_purchased)
		{
			this.lines[117].SetActive(true);
			this.lines[118].SetActive(true);
			this.plazmaBallTime.SetActive(true);
			this.plazmaBallSize.SetActive(true);
			if (SkillTree.plazmaBallSpawnSmallChance_purchaseCount >= 1)
			{
				this.plazmaBallSpawnSmallChance_LOCKED.SetActive(false);
				this.plazmaBallSpawnSmallChance.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.plazmaBallDamage_purchased && SkillTree.plazmaBallDamage_purchaseCount >= 5)
		{
			this.plazmaBallDamage_LOCKED.SetActive(false);
			this.plazmaBallDamage.GetComponent<Button>().enabled = false;
		}
		if (SkillTree.plazmaBallSpawnPickaxeChance_purchased && SkillTree.plazmaBallSpawnPickaxeChance_purchaseCount >= 1)
		{
			this.plazmaBallSpawnPickaxeChance_LOCKED.SetActive(false);
			this.plazmaBallSpawnPickaxeChance.GetComponent<Button>().enabled = false;
		}
		if (SkillTree.allProjectileDoubleDamageChance_purchased)
		{
			this.lines[122].SetActive(true);
			this.allProjectileTriggerChance.SetActive(true);
			if (SkillTree.allProjectileDoubleDamageChance_purchaseCount >= 1)
			{
				this.allProjectileDoubleDamageChance_LOCKED.SetActive(false);
				this.allProjectileDoubleDamageChance.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.allProjectileTriggerChance_purchased && SkillTree.allProjectileTriggerChance_purchaseCount >= 1)
		{
			this.allProjectileTriggerChance_LOCKED.SetActive(false);
			this.allProjectileTriggerChance.GetComponent<Button>().enabled = false;
		}
		if (SkillTree.pickaxeDoubleDamageChance_1_purchased)
		{
			this.lines[4].SetActive(true);
			this.lines[9].SetActive(true);
			this.lines[56].SetActive(true);
			if (SkillTree.biggerMiningErea_1_purchased)
			{
				this.lines[51].SetActive(true);
			}
			if (SkillTree.chanceToMineRandomRock_3_purchased)
			{
				this.lines[51].SetActive(true);
			}
			this.improvedPickaxe_1.SetActive(true);
			this.biggerMiningErea_1.SetActive(true);
			this.intaMineChance_1.SetActive(true);
			if (SkillTree.pickaxeDoubleDamageChance_1_purchaseCount >= 3)
			{
				this.pickaxeDoubleDamageChance_1_LOCKED.SetActive(false);
				this.pickaxeDoubleDamageChance_1.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.pickaxeDoubleDamageChance_2_purchased && SkillTree.pickaxeDoubleDamageChance_2_purchaseCount >= 3)
		{
			this.pickaxeDoubleDamageChance_2_LOCKED.SetActive(false);
			this.pickaxeDoubleDamageChance_2.GetComponent<Button>().enabled = false;
		}
		if (SkillTree.intaMineChance_1_purchased)
		{
			this.lines[51].SetActive(true);
			this.lines[56].SetActive(true);
			this.lines[60].SetActive(true);
			this.lines[55].SetActive(true);
			if (SkillTree.biggerMiningErea_2_purchased)
			{
				this.lines[54].SetActive(true);
				this.lines[61].SetActive(true);
			}
			if (SkillTree.spawnPickaxeEverySecond_2_purchased)
			{
				this.lines[54].SetActive(true);
			}
			if (SkillTree.fullGold_1_purchased)
			{
				this.lines[52].SetActive(true);
			}
			if (SkillTree.shootCircleChance_purchased)
			{
				this.lines[54].SetActive(true);
			}
			this.pickaxeDoubleDamageChance_1.SetActive(true);
			this.shootCircleChance.SetActive(true);
			this.moreTime_3.SetActive(true);
			if (SkillTree.intaMineChance_1_purchaseCount >= 3)
			{
				this.intaMineChance_1_LOCKED.SetActive(false);
				this.intaMineChance_1.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.intaMineChance_2_purchased)
		{
			this.lines[20].SetActive(true);
			this.lines[25].SetActive(true);
			this.lines[26].SetActive(true);
			this.lines[33].SetActive(true);
			if (SkillTree.spawnCopper_purchased)
			{
				this.lines[34].SetActive(true);
			}
			if (SkillTree.spawnXRockEveryXSecond_1_purchased)
			{
				this.lines[34].SetActive(true);
			}
			if (SkillTree.spawnPickaxeEverySecond_3_purchased)
			{
				this.lines[29].SetActive(true);
			}
			if (SkillTree.spawnMoreRocks_3_purchased)
			{
				this.lines[21].SetActive(true);
			}
			if (SkillTree.talentPointsPerXlevel_1_purchased)
			{
				this.lines[27].SetActive(true);
			}
			this.moreMeterialsFromRock_2.SetActive(true);
			this.improvedPickaxe_6.SetActive(true);
			this.spawnXRockEveryXSecond_1.SetActive(true);
			this.spawnPickaxeEverySecond_3.SetActive(true);
			if (SkillTree.intaMineChance_2_purchaseCount >= 3)
			{
				this.intaMineChance_2_LOCKED.SetActive(false);
				this.intaMineChance_2.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.increaseSpawnChanceAllRocks_purchased)
		{
			this.lines[168].SetActive(true);
			this.lines[171].SetActive(true);
			this.lines[179].SetActive(true);
			this.lines[181].SetActive(true);
			this.lines[169].SetActive(true);
			this.ismiumSpawn.SetActive(true);
			this.iridiumSpawn.SetActive(true);
			this.painiteSpawn.SetActive(true);
			if (SkillTree.increaseSpawnChanceAllRocks_purchaseCount >= 1)
			{
				this.increaseSpawnChanceAllRocks_LOCKED.SetActive(false);
				this.increaseSpawnChanceAllRocks.GetComponent<Button>().enabled = false;
			}
		}
		if (SkillTree.craft2Material_purchased && SkillTree.craft2Material_purchaseCount >= 1)
		{
			this.craft2Material_LOCKED.SetActive(false);
			this.craft2Material.GetComponent<Button>().enabled = false;
		}
		if (SkillTree.finalUpgrade_purchased && SkillTree.finalUpgrade_purchaseCount >= 1)
		{
			this.finalUpgrade_LOCKED.SetActive(false);
			this.finalUpgrade.GetComponent<Button>().enabled = false;
			if (!TheEnding.isEndingCompleted)
			{
				this.endingButton.SetActive(true);
			}
		}
		if (MobileAndTesting.isMobile)
		{
			this.SetButtonsActive();
		}
	}

	// Token: 0x060001CE RID: 462 RVA: 0x0004D578 File Offset: 0x0004B778
	public void LoadData(GameData data)
	{
		SkillTree.hasPressedEndlessOK = data.hasPressedEndlessOK;
		SkillTree.endlessGold_price = data.endlessGold_price;
		SkillTree.endlessCopper_price = data.endlessCopper_price;
		SkillTree.endlessIron_price = data.endlessIron_price;
		SkillTree.endlessCobalt_price = data.endlessCobalt_price;
		SkillTree.endlessUranium_price = data.endlessUranium_price;
		SkillTree.endlessIsmium_price = data.endlessIsmium_price;
		SkillTree.endlessIridium_price = data.endlessIridium_price;
		SkillTree.endlessPainite_price = data.endlessPainite_price;
		SkillTree.endlessGold_purchaseCount = data.endlessGold_purchaseCount;
		SkillTree.endlessCopper_purchaseCount = data.endlessCopper_purchaseCount;
		SkillTree.endlessIron_purchaseCount = data.endlessIron_purchaseCount;
		SkillTree.endlessCobalt_purchaseCount = data.endlessCobalt_purchaseCount;
		SkillTree.endlessUranium_purchaseCount = data.endlessUranium_purchaseCount;
		SkillTree.endlessIsmium_purchaseCount = data.endlessIsmium_purchaseCount;
		SkillTree.endlessIridium_purchaseCount = data.endlessIridium_purchaseCount;
		SkillTree.endlessPainite_purchaseCount = data.endlessPainite_purchaseCount;
		SkillTree.moreTime_1_purchased = data.moreTime_1_purchased;
		SkillTree.moreTime_2_purchased = data.moreTime_2_purchased;
		SkillTree.moreTime_3_purchased = data.moreTime_3_purchased;
		SkillTree.moreTime_4_purchased = data.moreTime_4_purchased;
		SkillTree.chanceToAdd1SecondEverySecond_purchased = data.chanceToAdd1SecondEverySecond_purchased;
		SkillTree.chanceAdd1SecondEveryRockMined_purchased = data.chanceAdd1SecondEveryRockMined_purchased;
		SkillTree.totalMaterialRocksSpawning = data.totalMaterialRocksSpawning;
		SkillTree.moreXP_1_purchased = data.moreXP_1_purchased;
		SkillTree.moreXP_2_purchased = data.moreXP_2_purchased;
		SkillTree.moreXP_3_purchased = data.moreXP_3_purchased;
		SkillTree.moreXP_4_purchased = data.moreXP_4_purchased;
		SkillTree.moreXP_5_purchased = data.moreXP_5_purchased;
		SkillTree.moreXP_6_purchased = data.moreXP_6_purchased;
		SkillTree.moreXP_7_purchased = data.moreXP_7_purchased;
		SkillTree.moreXP_8_purchased = data.moreXP_8_purchased;
		SkillTree.talentPointsPerXlevel_1_purchased = data.talentPointsPerXlevel_1_purchased;
		SkillTree.talentPointsPerXlevel_2_purchased = data.talentPointsPerXlevel_2_purchased;
		SkillTree.talentPointsPerXlevel_3_purchased = data.talentPointsPerXlevel_3_purchased;
		SkillTree.spawnMoreRocks_1_purchased = data.spawnMoreRocks_1_purchased;
		SkillTree.spawnMoreRocks_2_purchased = data.spawnMoreRocks_2_purchased;
		SkillTree.spawnMoreRocks_3_purchased = data.spawnMoreRocks_3_purchased;
		SkillTree.spawnMoreRocks_4_purchased = data.spawnMoreRocks_4_purchased;
		SkillTree.spawnMoreRocks_5_purchased = data.spawnMoreRocks_5_purchased;
		SkillTree.spawnMoreRocks_6_purchased = data.spawnMoreRocks_6_purchased;
		SkillTree.spawnMoreRocks_7_purchased = data.spawnMoreRocks_7_purchased;
		SkillTree.spawnMoreRocks_8_purchased = data.spawnMoreRocks_8_purchased;
		SkillTree.spawnMoreRocks_9_purchased = data.spawnMoreRocks_9_purchased;
		SkillTree.moreMeterialsFromRock_1_purchased = data.moreMeterialsFromRock_1_purchased;
		SkillTree.moreMeterialsFromRock_2_purchased = data.moreMeterialsFromRock_2_purchased;
		SkillTree.moreMeterialsFromRock_3_purchased = data.moreMeterialsFromRock_3_purchased;
		SkillTree.moreMeterialsFromRock_4_purchased = data.moreMeterialsFromRock_4_purchased;
		SkillTree.moreMeterialsFromRock_5_purchased = data.moreMeterialsFromRock_5_purchased;
		SkillTree.marterialsWorthMore_1_purchased = data.marterialsWorthMore_1_purchased;
		SkillTree.marterialsWorthMore_2_purchased = data.marterialsWorthMore_2_purchased;
		SkillTree.marterialsWorthMore_3_purchased = data.marterialsWorthMore_3_purchased;
		SkillTree.marterialsWorthMore_4_purchased = data.marterialsWorthMore_4_purchased;
		SkillTree.marterialsWorthMore_5_purchased = data.marterialsWorthMore_5_purchased;
		SkillTree.marterialsWorthMore_6_purchased = data.marterialsWorthMore_6_purchased;
		SkillTree.marterialsWorthMore_7_purchased = data.marterialsWorthMore_7_purchased;
		SkillTree.marterialsWorthMore_8_purchased = data.marterialsWorthMore_8_purchased;
		SkillTree.goldChunk_1_purchased = data.goldChunk_1_purchased;
		SkillTree.goldChunk_2_purchased = data.goldChunk_2_purchased;
		SkillTree.goldChunk_3_purchased = data.goldChunk_3_purchased;
		SkillTree.goldChunk_4_purchased = data.goldChunk_4_purchased;
		SkillTree.goldChunk_5_purchased = data.goldChunk_5_purchased;
		SkillTree.fullGold_1_purchased = data.fullGold_1_purchased;
		SkillTree.fullGold_2_purchased = data.fullGold_2_purchased;
		SkillTree.fullGold_3_purchased = data.fullGold_3_purchased;
		SkillTree.spawnCopper_purchased = data.spawnCopper_purchased;
		SkillTree.copperChunk_1_purchased = data.copperChunk_1_purchased;
		SkillTree.copperChunk_2_purchased = data.copperChunk_2_purchased;
		SkillTree.copperChunk_3_purchased = data.copperChunk_3_purchased;
		SkillTree.fullCopper_1_purchased = data.fullCopper_1_purchased;
		SkillTree.fullCopper_2_purchased = data.fullCopper_2_purchased;
		SkillTree.fullCopper_3_purchased = data.fullCopper_3_purchased;
		SkillTree.spawnIron_purchased = data.spawnIron_purchased;
		SkillTree.ironChunk_1_purchased = data.ironChunk_1_purchased;
		SkillTree.ironChunk_2_purchased = data.ironChunk_2_purchased;
		SkillTree.fullIron_1_purchased = data.fullIron_1_purchased;
		SkillTree.fullIron_2_purchased = data.fullIron_2_purchased;
		SkillTree.cobaltSpawn_purchased = data.cobaltSpawn_purchased;
		SkillTree.cobaltChunk_1_purchased = data.cobaltChunk_1_purchased;
		SkillTree.fullCobalt_1_purchased = data.fullCobalt_1_purchased;
		SkillTree.uraniumSpawn_purchased = data.uraniumSpawn_purchased;
		SkillTree.uraniumChunk_1_purchased = data.uraniumChunk_1_purchased;
		SkillTree.fullUranium_1_purchased = data.fullUranium_1_purchased;
		SkillTree.ismiumSpawn_purchased = data.ismiumSpawn_purchased;
		SkillTree.ismiumChunk_1_purchased = data.ismiumChunk_1_purchased;
		SkillTree.fullIsmium_1_purchased = data.fullIsmium_1_purchased;
		SkillTree.iridiumSpawn_purchased = data.iridiumSpawn_purchased;
		SkillTree.iridiumChunk_1_purchased = data.iridiumChunk_1_purchased;
		SkillTree.fullIridium_1_purchased = data.fullIridium_1_purchased;
		SkillTree.painiteSpawn_purchased = data.painiteSpawn_purchased;
		SkillTree.painiteChunk_1_purchased = data.painiteChunk_1_purchased;
		SkillTree.fullPainite_1_purchased = data.fullPainite_1_purchased;
		SkillTree.improvedPickaxe_1_purchased = data.improvedPickaxe_1_purchased;
		SkillTree.improvedPickaxe_2_purchased = data.improvedPickaxe_2_purchased;
		SkillTree.improvedPickaxe_3_purchased = data.improvedPickaxe_3_purchased;
		SkillTree.improvedPickaxe_4_purchased = data.improvedPickaxe_4_purchased;
		SkillTree.improvedPickaxe_5_purchased = data.improvedPickaxe_5_purchased;
		SkillTree.improvedPickaxe_6_purchased = data.improvedPickaxe_6_purchased;
		SkillTree.biggerMiningErea_1_purchased = data.biggerMiningErea_1_purchased;
		SkillTree.biggerMiningErea_2_purchased = data.biggerMiningErea_2_purchased;
		SkillTree.biggerMiningErea_3_purchased = data.biggerMiningErea_3_purchased;
		SkillTree.biggerMiningErea_4_purchased = data.biggerMiningErea_4_purchased;
		SkillTree.shootCircleChance_purchased = data.shootCircleChance_purchased;
		SkillTree.increaseAndDecreaseMinignErea_purchased = data.increaseAndDecreaseMinignErea_purchased;
		SkillTree.spawnRockEveryXrock_1_purchased = data.spawnRockEveryXrock_1_purchased;
		SkillTree.spawnRockEveryXrock_2_purchased = data.spawnRockEveryXrock_2_purchased;
		SkillTree.spawnRockEveryXrock_3_purchased = data.spawnRockEveryXrock_3_purchased;
		SkillTree.spawnXRockEveryXSecond_1_purchased = data.spawnXRockEveryXSecond_1_purchased;
		SkillTree.spawnXRockEveryXSecond_2_purchased = data.spawnXRockEveryXSecond_2_purchased;
		SkillTree.spawnXRockEveryXSecond_3_purchased = data.spawnXRockEveryXSecond_3_purchased;
		SkillTree.chanceToSpawnRockWhenMined_1_purchased = data.chanceToSpawnRockWhenMined_1_purchased;
		SkillTree.chanceToSpawnRockWhenMined_2_purchased = data.chanceToSpawnRockWhenMined_2_purchased;
		SkillTree.chanceToSpawnRockWhenMined_3_purchased = data.chanceToSpawnRockWhenMined_3_purchased;
		SkillTree.chanceToSpawnRockWhenMined_4_purchased = data.chanceToSpawnRockWhenMined_4_purchased;
		SkillTree.chanceToSpawnRockWhenMined_5_purchased = data.chanceToSpawnRockWhenMined_5_purchased;
		SkillTree.chanceToSpawnRockWhenMined_6_purchased = data.chanceToSpawnRockWhenMined_6_purchased;
		SkillTree.chanceToMineRandomRock_1_purchased = data.chanceToMineRandomRock_1_purchased;
		SkillTree.chanceToMineRandomRock_2_purchased = data.chanceToMineRandomRock_2_purchased;
		SkillTree.chanceToMineRandomRock_3_purchased = data.chanceToMineRandomRock_3_purchased;
		SkillTree.chanceToMineRandomRock_4_purchased = data.chanceToMineRandomRock_4_purchased;
		SkillTree.spawnPickaxeEverySecond_1_purchased = data.spawnPickaxeEverySecond_1_purchased;
		SkillTree.spawnPickaxeEverySecond_2_purchased = data.spawnPickaxeEverySecond_2_purchased;
		SkillTree.spawnPickaxeEverySecond_3_purchased = data.spawnPickaxeEverySecond_3_purchased;
		SkillTree.doubleXpGoldChance_1_purchased = data.doubleXpGoldChance_1_purchased;
		SkillTree.doubleXpGoldChance_2_purchased = data.doubleXpGoldChance_2_purchased;
		SkillTree.doubleXpGoldChance_3_purchased = data.doubleXpGoldChance_3_purchased;
		SkillTree.doubleXpGoldChance_4_purchased = data.doubleXpGoldChance_4_purchased;
		SkillTree.doubleXpGoldChance_5_purchased = data.doubleXpGoldChance_5_purchased;
		SkillTree.lightningBeamChanceS_1_purchased = data.lightningBeamChanceS_1_purchased;
		SkillTree.lightningBeamChanceS_2_purchased = data.lightningBeamChanceS_2_purchased;
		SkillTree.lightningBeamChancePH_1_purchased = data.lightningBeamChancePH_1_purchased;
		SkillTree.lightningBeamChancePH_2_purchased = data.lightningBeamChancePH_2_purchased;
		SkillTree.lightningBeamSpawnAnotherOneChance_purchased = data.lightningBeamSpawnAnotherOneChance_purchased;
		SkillTree.lightningBeamDamage_purchased = data.lightningBeamDamage_purchased;
		SkillTree.lightningBeamSize_purchased = data.lightningBeamSize_purchased;
		SkillTree.lightningSplashes_purchased = data.lightningSplashes_purchased;
		SkillTree.lightningBeamSpawnRock_purchased = data.lightningBeamSpawnRock_purchased;
		SkillTree.lightningBeamExplosion_purchased = data.lightningBeamExplosion_purchased;
		SkillTree.lightningBeamAddTime_purchased = data.lightningBeamAddTime_purchased;
		SkillTree.dynamiteChance_1_purchased = data.dynamiteChance_1_purchased;
		SkillTree.dynamiteChance_2_purchased = data.dynamiteChance_2_purchased;
		SkillTree.dynamiteSpawn2SmallChance_purchased = data.dynamiteSpawn2SmallChance_purchased;
		SkillTree.dynamiteExplosionSize_purchased = data.dynamiteExplosionSize_purchased;
		SkillTree.dynamiteDamage_purchased = data.dynamiteDamage_purchased;
		SkillTree.dynamiteExplosionSpawnRock_purchased = data.dynamiteExplosionSpawnRock_purchased;
		SkillTree.dynamiteExplosionAddTimeChance_purchased = data.dynamiteExplosionAddTimeChance_purchased;
		SkillTree.dynamiteExplosionSpawnLightning_purchased = data.dynamiteExplosionSpawnLightning_purchased;
		SkillTree.plazmaBallSpawn_1_purchased = data.plazmaBallSpawn_1_purchased;
		SkillTree.plazmaBallSpawn_2_purchased = data.plazmaBallSpawn_2_purchased;
		SkillTree.plazmaBallTime_purchased = data.plazmaBallTime_purchased;
		SkillTree.plazmaBallSize_purchased = data.plazmaBallSize_purchased;
		SkillTree.plazmaBallExplosionChance_purchased = data.plazmaBallExplosionChance_purchased;
		SkillTree.plazmaBallSpawnSmallChance_purchased = data.plazmaBallSpawnSmallChance_purchased;
		SkillTree.plazmaBallDamage_purchased = data.plazmaBallDamage_purchased;
		SkillTree.plazmaBallSpawnPickaxeChance_purchased = data.plazmaBallSpawnPickaxeChance_purchased;
		SkillTree.allProjectileDoubleDamageChance_purchased = data.allProjectileDoubleDamageChance_purchased;
		SkillTree.allProjectileTriggerChance_purchased = data.allProjectileTriggerChance_purchased;
		SkillTree.pickaxeDoubleDamageChance_1_purchased = data.pickaxeDoubleDamageChance_1_purchased;
		SkillTree.pickaxeDoubleDamageChance_2_purchased = data.pickaxeDoubleDamageChance_2_purchased;
		SkillTree.intaMineChance_1_purchased = data.intaMineChance_1_purchased;
		SkillTree.intaMineChance_2_purchased = data.intaMineChance_2_purchased;
		SkillTree.increaseSpawnChanceAllRocks_purchased = data.increaseSpawnChanceAllRocks_purchased;
		SkillTree.craft2Material_purchased = data.craft2Material_purchased;
		SkillTree.finalUpgrade_purchased = data.finalUpgrade_purchased;
		SkillTree.moreXP_1_purchaseCount = data.moreXP_1_purchaseCount;
		SkillTree.moreXP_2_purchaseCount = data.moreXP_2_purchaseCount;
		SkillTree.moreXP_3_purchaseCount = data.moreXP_3_purchaseCount;
		SkillTree.moreXP_4_purchaseCount = data.moreXP_4_purchaseCount;
		SkillTree.moreXP_5_purchaseCount = data.moreXP_5_purchaseCount;
		SkillTree.moreXP_6_purchaseCount = data.moreXP_6_purchaseCount;
		SkillTree.moreXP_7_purchaseCount = data.moreXP_7_purchaseCount;
		SkillTree.moreXP_8_purchaseCount = data.moreXP_8_purchaseCount;
		SkillTree.talentPointsPerXlevel_1_purchaseCount = data.talentPointsPerXlevel_1_purchaseCount;
		SkillTree.talentPointsPerXlevel_2_purchaseCount = data.talentPointsPerXlevel_2_purchaseCount;
		SkillTree.talentPointsPerXlevel_3_purchaseCount = data.talentPointsPerXlevel_3_purchaseCount;
		SkillTree.spawnMoreRocks_1_purchaseCount = data.spawnMoreRocks_1_purchaseCount;
		SkillTree.spawnMoreRocks_2_purchaseCount = data.spawnMoreRocks_2_purchaseCount;
		SkillTree.spawnMoreRocks_3_purchaseCount = data.spawnMoreRocks_3_purchaseCount;
		SkillTree.spawnMoreRocks_4_purchaseCount = data.spawnMoreRocks_4_purchaseCount;
		SkillTree.spawnMoreRocks_5_purchaseCount = data.spawnMoreRocks_5_purchaseCount;
		SkillTree.spawnMoreRocks_6_purchaseCount = data.spawnMoreRocks_6_purchaseCount;
		SkillTree.spawnMoreRocks_7_purchaseCount = data.spawnMoreRocks_7_purchaseCount;
		SkillTree.spawnMoreRocks_8_purchaseCount = data.spawnMoreRocks_8_purchaseCount;
		SkillTree.spawnMoreRocks_9_purchaseCount = data.spawnMoreRocks_9_purchaseCount;
		SkillTree.moreMeterialsFromRock_1_purchaseCount = data.moreMeterialsFromRock_1_purchaseCount;
		SkillTree.moreMeterialsFromRock_2_purchaseCount = data.moreMeterialsFromRock_2_purchaseCount;
		SkillTree.moreMeterialsFromRock_3_purchaseCount = data.moreMeterialsFromRock_3_purchaseCount;
		SkillTree.moreMeterialsFromRock_4_purchaseCount = data.moreMeterialsFromRock_4_purchaseCount;
		SkillTree.moreMeterialsFromRock_5_purchaseCount = data.moreMeterialsFromRock_5_purchaseCount;
		SkillTree.marterialsWorthMore_1_purchaseCount = data.marterialsWorthMore_1_purchaseCount;
		SkillTree.marterialsWorthMore_2_purchaseCount = data.marterialsWorthMore_2_purchaseCount;
		SkillTree.marterialsWorthMore_3_purchaseCount = data.marterialsWorthMore_3_purchaseCount;
		SkillTree.marterialsWorthMore_4_purchaseCount = data.marterialsWorthMore_4_purchaseCount;
		SkillTree.marterialsWorthMore_5_purchaseCount = data.marterialsWorthMore_5_purchaseCount;
		SkillTree.marterialsWorthMore_6_purchaseCount = data.marterialsWorthMore_6_purchaseCount;
		SkillTree.marterialsWorthMore_7_purchaseCount = data.marterialsWorthMore_7_purchaseCount;
		SkillTree.marterialsWorthMore_8_purchaseCount = data.marterialsWorthMore_8_purchaseCount;
		SkillTree.goldChunk_1_purchaseCount = data.goldChunk_1_purchaseCount;
		SkillTree.goldChunk_2_purchaseCount = data.goldChunk_2_purchaseCount;
		SkillTree.goldChunk_3_purchaseCount = data.goldChunk_3_purchaseCount;
		SkillTree.goldChunk_4_purchaseCount = data.goldChunk_4_purchaseCount;
		SkillTree.goldChunk_5_purchaseCount = data.goldChunk_5_purchaseCount;
		SkillTree.fullGold_1_purchaseCount = data.fullGold_1_purchaseCount;
		SkillTree.fullGold_2_purchaseCount = data.fullGold_2_purchaseCount;
		SkillTree.fullGold_3_purchaseCount = data.fullGold_3_purchaseCount;
		SkillTree.spawnCopper_purchaseCount = data.spawnCopper_purchaseCount;
		SkillTree.copperChunk_1_purchaseCount = data.copperChunk_1_purchaseCount;
		SkillTree.copperChunk_2_purchaseCount = data.copperChunk_2_purchaseCount;
		SkillTree.copperChunk_3_purchaseCount = data.copperChunk_3_purchaseCount;
		SkillTree.fullCopper_1_purchaseCount = data.fullCopper_1_purchaseCount;
		SkillTree.fullCopper_2_purchaseCount = data.fullCopper_2_purchaseCount;
		SkillTree.fullCopper_3_purchaseCount = data.fullCopper_3_purchaseCount;
		SkillTree.spawnIron_purchaseCount = data.spawnIron_purchaseCount;
		SkillTree.ironChunk_1_purchaseCount = data.ironChunk_1_purchaseCount;
		SkillTree.ironChunk_2_purchaseCount = data.ironChunk_2_purchaseCount;
		SkillTree.fullIron_1_purchaseCount = data.fullIron_1_purchaseCount;
		SkillTree.fullIron_2_purchaseCount = data.fullIron_2_purchaseCount;
		SkillTree.cobaltSpawn_purchaseCount = data.cobaltSpawn_purchaseCount;
		SkillTree.cobaltChunk_1_purchaseCount = data.cobaltChunk_1_purchaseCount;
		SkillTree.fullCobalt_1_purchaseCount = data.fullCobalt_1_purchaseCount;
		SkillTree.uraniumSpawn_purchaseCount = data.uraniumSpawn_purchaseCount;
		SkillTree.uraniumChunk_1_purchaseCount = data.uraniumChunk_1_purchaseCount;
		SkillTree.fullUranium_1_purchaseCount = data.fullUranium_1_purchaseCount;
		SkillTree.ismiumSpawn_purchaseCount = data.ismiumSpawn_purchaseCount;
		SkillTree.ismiumChunk_1_purchaseCount = data.ismiumChunk_1_purchaseCount;
		SkillTree.fullIsmium_1_purchaseCount = data.fullIsmium_1_purchaseCount;
		SkillTree.iridiumSpawn_purchaseCount = data.iridiumSpawn_purchaseCount;
		SkillTree.iridiumChunk_1_purchaseCount = data.iridiumChunk_1_purchaseCount;
		SkillTree.fullIridium_1_purchaseCount = data.fullIridium_1_purchaseCount;
		SkillTree.painiteSpawn_purchaseCount = data.painiteSpawn_purchaseCount;
		SkillTree.painiteChunk_1_purchaseCount = data.painiteChunk_1_purchaseCount;
		SkillTree.fullPainite_1_purchaseCount = data.fullPainite_1_purchaseCount;
		SkillTree.improvedPickaxe_1_purchaseCount = data.improvedPickaxe_1_purchaseCount;
		SkillTree.improvedPickaxe_2_purchaseCount = data.improvedPickaxe_2_purchaseCount;
		SkillTree.improvedPickaxe_3_purchaseCount = data.improvedPickaxe_3_purchaseCount;
		SkillTree.improvedPickaxe_4_purchaseCount = data.improvedPickaxe_4_purchaseCount;
		SkillTree.improvedPickaxe_5_purchaseCount = data.improvedPickaxe_5_purchaseCount;
		SkillTree.improvedPickaxe_6_purchaseCount = data.improvedPickaxe_6_purchaseCount;
		SkillTree.biggerMiningErea_1_purchaseCount = data.biggerMiningErea_1_purchaseCount;
		SkillTree.biggerMiningErea_2_purchaseCount = data.biggerMiningErea_2_purchaseCount;
		SkillTree.biggerMiningErea_3_purchaseCount = data.biggerMiningErea_3_purchaseCount;
		SkillTree.biggerMiningErea_4_purchaseCount = data.biggerMiningErea_4_purchaseCount;
		SkillTree.shootCircleChance_purchaseCount = data.shootCircleChance_purchaseCount;
		SkillTree.increaseAndDecreaseMinignErea_purchaseCount = data.increaseAndDecreaseMinignErea_purchaseCount;
		SkillTree.spawnRockEveryXrock_1_purchaseCount = data.spawnRockEveryXrock_1_purchaseCount;
		SkillTree.spawnRockEveryXrock_2_purchaseCount = data.spawnRockEveryXrock_2_purchaseCount;
		SkillTree.spawnRockEveryXrock_3_purchaseCount = data.spawnRockEveryXrock_3_purchaseCount;
		SkillTree.spawnXRockEveryXSecond_1_purchaseCount = data.spawnXRockEveryXSecond_1_purchaseCount;
		SkillTree.spawnXRockEveryXSecond_2_purchaseCount = data.spawnXRockEveryXSecond_2_purchaseCount;
		SkillTree.spawnXRockEveryXSecond_3_purchaseCount = data.spawnXRockEveryXSecond_3_purchaseCount;
		SkillTree.chanceToSpawnRockWhenMined_1_purchaseCount = data.chanceToSpawnRockWhenMined_1_purchaseCount;
		SkillTree.chanceToSpawnRockWhenMined_2_purchaseCount = data.chanceToSpawnRockWhenMined_2_purchaseCount;
		SkillTree.chanceToSpawnRockWhenMined_3_purchaseCount = data.chanceToSpawnRockWhenMined_3_purchaseCount;
		SkillTree.chanceToSpawnRockWhenMined_4_purchaseCount = data.chanceToSpawnRockWhenMined_4_purchaseCount;
		SkillTree.chanceToSpawnRockWhenMined_5_purchaseCount = data.chanceToSpawnRockWhenMined_5_purchaseCount;
		SkillTree.chanceToSpawnRockWhenMined_6_purchaseCount = data.chanceToSpawnRockWhenMined_6_purchaseCount;
		SkillTree.chanceToMineRandomRock_1_purchaseCount = data.chanceToMineRandomRock_1_purchaseCount;
		SkillTree.chanceToMineRandomRock_2_purchaseCount = data.chanceToMineRandomRock_2_purchaseCount;
		SkillTree.chanceToMineRandomRock_3_purchaseCount = data.chanceToMineRandomRock_3_purchaseCount;
		SkillTree.chanceToMineRandomRock_4_purchaseCount = data.chanceToMineRandomRock_4_purchaseCount;
		SkillTree.spawnPickaxeEverySecond_1_purchaseCount = data.spawnPickaxeEverySecond_1_purchaseCount;
		SkillTree.spawnPickaxeEverySecond_2_purchaseCount = data.spawnPickaxeEverySecond_2_purchaseCount;
		SkillTree.spawnPickaxeEverySecond_3_purchaseCount = data.spawnPickaxeEverySecond_3_purchaseCount;
		SkillTree.moreTime_1_purchaseCount = data.moreTime_1_purchaseCount;
		SkillTree.moreTime_2_purchaseCount = data.moreTime_2_purchaseCount;
		SkillTree.moreTime_3_purchaseCount = data.moreTime_3_purchaseCount;
		SkillTree.moreTime_4_purchaseCount = data.moreTime_4_purchaseCount;
		SkillTree.chanceToAdd1SecondEverySecond_purchaseCount = data.chanceToAdd1SecondEverySecond_purchaseCount;
		SkillTree.chanceAdd1SecondEveryRockMined_purchaseCount = data.chanceAdd1SecondEveryRockMined_purchaseCount;
		SkillTree.doubleXpGoldChance_1_purchaseCount = data.doubleXpGoldChance_1_purchaseCount;
		SkillTree.doubleXpGoldChance_2_purchaseCount = data.doubleXpGoldChance_2_purchaseCount;
		SkillTree.doubleXpGoldChance_3_purchaseCount = data.doubleXpGoldChance_3_purchaseCount;
		SkillTree.doubleXpGoldChance_4_purchaseCount = data.doubleXpGoldChance_4_purchaseCount;
		SkillTree.doubleXpGoldChance_5_purchaseCount = data.doubleXpGoldChance_5_purchaseCount;
		SkillTree.lightningBeamChanceS_1_purchaseCount = data.lightningBeamChanceS_1_purchaseCount;
		SkillTree.lightningBeamChanceS_2_purchaseCount = data.lightningBeamChanceS_2_purchaseCount;
		SkillTree.lightningBeamChancePH_1_purchaseCount = data.lightningBeamChancePH_1_purchaseCount;
		SkillTree.lightningBeamChancePH_2_purchaseCount = data.lightningBeamChancePH_2_purchaseCount;
		SkillTree.lightningBeamSpawnAnotherOneChance_purchaseCount = data.lightningBeamSpawnAnotherOneChance_purchaseCount;
		SkillTree.lightningBeamDamage_purchaseCount = data.lightningBeamDamage_purchaseCount;
		SkillTree.lightningBeamSize_purchaseCount = data.lightningBeamSize_purchaseCount;
		SkillTree.lightningSplashes_purchaseCount = data.lightningSplashes_purchaseCount;
		SkillTree.lightningBeamSpawnRock_purchaseCount = data.lightningBeamSpawnRock_purchaseCount;
		SkillTree.lightningBeamExplosion_purchaseCount = data.lightningBeamExplosion_purchaseCount;
		SkillTree.lightningBeamAddTime_purchaseCount = data.lightningBeamAddTime_purchaseCount;
		SkillTree.dynamiteChance_1_purchaseCount = data.dynamiteChance_1_purchaseCount;
		SkillTree.dynamiteChance_2_purchaseCount = data.dynamiteChance_2_purchaseCount;
		SkillTree.dynamiteSpawn2SmallChance_purchaseCount = data.dynamiteSpawn2SmallChance_purchaseCount;
		SkillTree.dynamiteExplosionSize_purchaseCount = data.dynamiteExplosionSize_purchaseCount;
		SkillTree.dynamiteDamage_purchaseCount = data.dynamiteDamage_purchaseCount;
		SkillTree.dynamiteExplosionSpawnRock_purchaseCount = data.dynamiteExplosionSpawnRock_purchaseCount;
		SkillTree.dynamiteExplosionAddTimeChance_purchaseCount = data.dynamiteExplosionAddTimeChance_purchaseCount;
		SkillTree.dynamiteExplosionSpawnLightning_purchaseCount = data.dynamiteExplosionSpawnLightning_purchaseCount;
		SkillTree.plazmaBallSpawn_1_purchaseCount = data.plazmaBallSpawn_1_purchaseCount;
		SkillTree.plazmaBallSpawn_2_purchaseCount = data.plazmaBallSpawn_2_purchaseCount;
		SkillTree.plazmaBallTime_purchaseCount = data.plazmaBallTime_purchaseCount;
		SkillTree.plazmaBallSize_purchaseCount = data.plazmaBallSize_purchaseCount;
		SkillTree.plazmaBallExplosionChance_purchaseCount = data.plazmaBallExplosionChance_purchaseCount;
		SkillTree.plazmaBallSpawnSmallChance_purchaseCount = data.plazmaBallSpawnSmallChance_purchaseCount;
		SkillTree.plazmaBallDamage_purchaseCount = data.plazmaBallDamage_purchaseCount;
		SkillTree.plazmaBallSpawnPickaxeChance_purchaseCount = data.plazmaBallSpawnPickaxeChance_purchaseCount;
		SkillTree.allProjectileDoubleDamageChance_purchaseCount = data.allProjectileDoubleDamageChance_purchaseCount;
		SkillTree.allProjectileTriggerChance_purchaseCount = data.allProjectileTriggerChance_purchaseCount;
		SkillTree.pickaxeDoubleDamageChance_1_purchaseCount = data.pickaxeDoubleDamageChance_1_purchaseCount;
		SkillTree.pickaxeDoubleDamageChance_2_purchaseCount = data.pickaxeDoubleDamageChance_2_purchaseCount;
		SkillTree.intaMineChance_1_purchaseCount = data.intaMineChance_1_purchaseCount;
		SkillTree.intaMineChance_2_purchaseCount = data.intaMineChance_2_purchaseCount;
		SkillTree.increaseSpawnChanceAllRocks_purchaseCount = data.increaseSpawnChanceAllRocks_purchaseCount;
		SkillTree.craft2Material_purchaseCount = data.craft2Material_purchaseCount;
		SkillTree.finalUpgrade_purchaseCount = data.finalUpgrade_purchaseCount;
		SkillTree.totalSkillTreeUpgradesPurchased = data.totalSkillTreeUpgradesPurchased;
		SkillTree.totalUpgradesFullyPurchased = data.totalUpgradesFullyPurchased;
		SkillTree.mineSessionTime = data.mineSessionTime;
		SkillTree.totalRocksToSpawn = data.totalRocksToSpawn;
		SkillTree.extraTalentPointPerLevel = data.extraTalentPointPerLevel;
		SkillTree.goldRockChance = data.goldRockChance;
		SkillTree.fullGoldRockChance = data.fullGoldRockChance;
		SkillTree.copperRockChance = data.copperRockChance;
		SkillTree.fullCopperRockChance = data.fullCopperRockChance;
		SkillTree.ironRockChance = data.ironRockChance;
		SkillTree.fullIronRockChance = data.fullIronRockChance;
		SkillTree.cobaltRockChance = data.cobaltRockChance;
		SkillTree.fullCobaltRockChance = data.fullCobaltRockChance;
		SkillTree.uraniumRockChance = data.uraniumRockChance;
		SkillTree.fullUraniumRockChance = data.fullUraniumRockChance;
		SkillTree.ismiumRockChance = data.ismiumRockChance;
		SkillTree.fullIsmiumRockChance = data.fullIsmiumRockChance;
		SkillTree.iridiumRockChance = data.iridiumRockChance;
		SkillTree.fullIridiumRockChance = data.fullIridiumRockChance;
		SkillTree.painiteRockChance = data.painiteRockChance;
		SkillTree.fullPainiteRockChance = data.fullPainiteRockChance;
		SkillTree.improvedPickaxeStrength = data.improvedPickaxeStrength;
		SkillTree.reducePickaxeMineTime = data.reducePickaxeMineTime;
		SkillTree.miningAreaSize = data.miningAreaSize;
		SkillTree.spawnRockEveryXRock = data.spawnRockEveryXRock;
		SkillTree.spawnXRockEveryXSecond = data.spawnXRockEveryXSecond;
		SkillTree.chanceToSpawnRockWhenMined = data.chanceToSpawnRockWhenMined;
		SkillTree.materialsFromChunkRocks = data.materialsFromChunkRocks;
		SkillTree.materialsFromFullRocks = data.materialsFromFullRocks;
		SkillTree.materialsTotalWorth = data.materialsTotalWorth;
		SkillTree.chanceToMineRandomRock = data.chanceToMineRandomRock;
		SkillTree.spawnPickaxeEverySecond = data.spawnPickaxeEverySecond;
		SkillTree.doubleXpAndGoldChance = data.doubleXpAndGoldChance;
		SkillTree.lightningTriggerChanceS = data.lightningTriggerChanceS;
		SkillTree.lightningTriggerChancePH = data.lightningTriggerChancePH;
		SkillTree.lightningDamage = data.lightningDamage;
		SkillTree.lightningSize = data.lightningSize;
		SkillTree.dynamiteStickChance = data.dynamiteStickChance;
		SkillTree.explosionSize = data.explosionSize;
		SkillTree.explosionDamagage = data.explosionDamagage;
		SkillTree.plazmaBallChance = data.plazmaBallChance;
		SkillTree.plazmaBallTimer = data.plazmaBallTimer;
		SkillTree.plazmaBallTotalSize = data.plazmaBallTotalSize;
		SkillTree.plazmaBallTotalDamage = data.plazmaBallTotalDamage;
		SkillTree.doubleDamageChance = data.doubleDamageChance;
		SkillTree.instaMineChance = data.instaMineChance;
	}

	// Token: 0x060001CF RID: 463 RVA: 0x0004E4D4 File Offset: 0x0004C6D4
	public void SaveData(ref GameData data)
	{
		data.hasPressedEndlessOK = SkillTree.hasPressedEndlessOK;
		data.endlessGold_price = SkillTree.endlessGold_price;
		data.endlessCopper_price = SkillTree.endlessCopper_price;
		data.endlessIron_price = SkillTree.endlessIron_price;
		data.endlessCobalt_price = SkillTree.endlessCobalt_price;
		data.endlessUranium_price = SkillTree.endlessUranium_price;
		data.endlessIsmium_price = SkillTree.endlessIsmium_price;
		data.endlessIridium_price = SkillTree.endlessIridium_price;
		data.endlessPainite_price = SkillTree.endlessPainite_price;
		data.endlessGold_purchaseCount = SkillTree.endlessGold_purchaseCount;
		data.endlessCopper_purchaseCount = SkillTree.endlessCopper_purchaseCount;
		data.endlessIron_purchaseCount = SkillTree.endlessIron_purchaseCount;
		data.endlessCobalt_purchaseCount = SkillTree.endlessCobalt_purchaseCount;
		data.endlessUranium_purchaseCount = SkillTree.endlessUranium_purchaseCount;
		data.endlessIsmium_purchaseCount = SkillTree.endlessIsmium_purchaseCount;
		data.endlessIridium_purchaseCount = SkillTree.endlessIridium_purchaseCount;
		data.endlessPainite_purchaseCount = SkillTree.endlessPainite_purchaseCount;
		data.moreTime_1_purchased = SkillTree.moreTime_1_purchased;
		data.moreTime_2_purchased = SkillTree.moreTime_2_purchased;
		data.moreTime_3_purchased = SkillTree.moreTime_3_purchased;
		data.moreTime_4_purchased = SkillTree.moreTime_4_purchased;
		data.chanceToAdd1SecondEverySecond_purchased = SkillTree.chanceToAdd1SecondEverySecond_purchased;
		data.chanceAdd1SecondEveryRockMined_purchased = SkillTree.chanceAdd1SecondEveryRockMined_purchased;
		data.totalMaterialRocksSpawning = SkillTree.totalMaterialRocksSpawning;
		data.moreXP_1_purchased = SkillTree.moreXP_1_purchased;
		data.moreXP_2_purchased = SkillTree.moreXP_2_purchased;
		data.moreXP_3_purchased = SkillTree.moreXP_3_purchased;
		data.moreXP_4_purchased = SkillTree.moreXP_4_purchased;
		data.moreXP_5_purchased = SkillTree.moreXP_5_purchased;
		data.moreXP_6_purchased = SkillTree.moreXP_6_purchased;
		data.moreXP_7_purchased = SkillTree.moreXP_7_purchased;
		data.moreXP_8_purchased = SkillTree.moreXP_8_purchased;
		data.talentPointsPerXlevel_1_purchased = SkillTree.talentPointsPerXlevel_1_purchased;
		data.talentPointsPerXlevel_2_purchased = SkillTree.talentPointsPerXlevel_2_purchased;
		data.talentPointsPerXlevel_3_purchased = SkillTree.talentPointsPerXlevel_3_purchased;
		data.spawnMoreRocks_1_purchased = SkillTree.spawnMoreRocks_1_purchased;
		data.spawnMoreRocks_2_purchased = SkillTree.spawnMoreRocks_2_purchased;
		data.spawnMoreRocks_3_purchased = SkillTree.spawnMoreRocks_3_purchased;
		data.spawnMoreRocks_4_purchased = SkillTree.spawnMoreRocks_4_purchased;
		data.spawnMoreRocks_5_purchased = SkillTree.spawnMoreRocks_5_purchased;
		data.spawnMoreRocks_6_purchased = SkillTree.spawnMoreRocks_6_purchased;
		data.spawnMoreRocks_7_purchased = SkillTree.spawnMoreRocks_7_purchased;
		data.spawnMoreRocks_8_purchased = SkillTree.spawnMoreRocks_8_purchased;
		data.spawnMoreRocks_9_purchased = SkillTree.spawnMoreRocks_9_purchased;
		data.moreMeterialsFromRock_1_purchased = SkillTree.moreMeterialsFromRock_1_purchased;
		data.moreMeterialsFromRock_2_purchased = SkillTree.moreMeterialsFromRock_2_purchased;
		data.moreMeterialsFromRock_3_purchased = SkillTree.moreMeterialsFromRock_3_purchased;
		data.moreMeterialsFromRock_4_purchased = SkillTree.moreMeterialsFromRock_4_purchased;
		data.moreMeterialsFromRock_5_purchased = SkillTree.moreMeterialsFromRock_5_purchased;
		data.marterialsWorthMore_1_purchased = SkillTree.marterialsWorthMore_1_purchased;
		data.marterialsWorthMore_2_purchased = SkillTree.marterialsWorthMore_2_purchased;
		data.marterialsWorthMore_3_purchased = SkillTree.marterialsWorthMore_3_purchased;
		data.marterialsWorthMore_4_purchased = SkillTree.marterialsWorthMore_4_purchased;
		data.marterialsWorthMore_5_purchased = SkillTree.marterialsWorthMore_5_purchased;
		data.marterialsWorthMore_6_purchased = SkillTree.marterialsWorthMore_6_purchased;
		data.marterialsWorthMore_7_purchased = SkillTree.marterialsWorthMore_7_purchased;
		data.marterialsWorthMore_8_purchased = SkillTree.marterialsWorthMore_8_purchased;
		data.goldChunk_1_purchased = SkillTree.goldChunk_1_purchased;
		data.goldChunk_2_purchased = SkillTree.goldChunk_2_purchased;
		data.goldChunk_3_purchased = SkillTree.goldChunk_3_purchased;
		data.goldChunk_4_purchased = SkillTree.goldChunk_4_purchased;
		data.goldChunk_5_purchased = SkillTree.goldChunk_5_purchased;
		data.fullGold_1_purchased = SkillTree.fullGold_1_purchased;
		data.fullGold_2_purchased = SkillTree.fullGold_2_purchased;
		data.fullGold_3_purchased = SkillTree.fullGold_3_purchased;
		data.spawnCopper_purchased = SkillTree.spawnCopper_purchased;
		data.copperChunk_1_purchased = SkillTree.copperChunk_1_purchased;
		data.copperChunk_2_purchased = SkillTree.copperChunk_2_purchased;
		data.copperChunk_3_purchased = SkillTree.copperChunk_3_purchased;
		data.fullCopper_1_purchased = SkillTree.fullCopper_1_purchased;
		data.fullCopper_2_purchased = SkillTree.fullCopper_2_purchased;
		data.fullCopper_3_purchased = SkillTree.fullCopper_3_purchased;
		data.spawnIron_purchased = SkillTree.spawnIron_purchased;
		data.ironChunk_1_purchased = SkillTree.ironChunk_1_purchased;
		data.ironChunk_2_purchased = SkillTree.ironChunk_2_purchased;
		data.fullIron_1_purchased = SkillTree.fullIron_1_purchased;
		data.fullIron_2_purchased = SkillTree.fullIron_2_purchased;
		data.cobaltSpawn_purchased = SkillTree.cobaltSpawn_purchased;
		data.cobaltChunk_1_purchased = SkillTree.cobaltChunk_1_purchased;
		data.fullCobalt_1_purchased = SkillTree.fullCobalt_1_purchased;
		data.uraniumSpawn_purchased = SkillTree.uraniumSpawn_purchased;
		data.uraniumChunk_1_purchased = SkillTree.uraniumChunk_1_purchased;
		data.fullUranium_1_purchased = SkillTree.fullUranium_1_purchased;
		data.ismiumSpawn_purchased = SkillTree.ismiumSpawn_purchased;
		data.ismiumChunk_1_purchased = SkillTree.ismiumChunk_1_purchased;
		data.fullIsmium_1_purchased = SkillTree.fullIsmium_1_purchased;
		data.iridiumSpawn_purchased = SkillTree.iridiumSpawn_purchased;
		data.iridiumChunk_1_purchased = SkillTree.iridiumChunk_1_purchased;
		data.fullIridium_1_purchased = SkillTree.fullIridium_1_purchased;
		data.painiteSpawn_purchased = SkillTree.painiteSpawn_purchased;
		data.painiteChunk_1_purchased = SkillTree.painiteChunk_1_purchased;
		data.fullPainite_1_purchased = SkillTree.fullPainite_1_purchased;
		data.improvedPickaxe_1_purchased = SkillTree.improvedPickaxe_1_purchased;
		data.improvedPickaxe_2_purchased = SkillTree.improvedPickaxe_2_purchased;
		data.improvedPickaxe_3_purchased = SkillTree.improvedPickaxe_3_purchased;
		data.improvedPickaxe_4_purchased = SkillTree.improvedPickaxe_4_purchased;
		data.improvedPickaxe_5_purchased = SkillTree.improvedPickaxe_5_purchased;
		data.improvedPickaxe_6_purchased = SkillTree.improvedPickaxe_6_purchased;
		data.biggerMiningErea_1_purchased = SkillTree.biggerMiningErea_1_purchased;
		data.biggerMiningErea_2_purchased = SkillTree.biggerMiningErea_2_purchased;
		data.biggerMiningErea_3_purchased = SkillTree.biggerMiningErea_3_purchased;
		data.biggerMiningErea_4_purchased = SkillTree.biggerMiningErea_4_purchased;
		data.shootCircleChance_purchased = SkillTree.shootCircleChance_purchased;
		data.increaseAndDecreaseMinignErea_purchased = SkillTree.increaseAndDecreaseMinignErea_purchased;
		data.spawnRockEveryXrock_1_purchased = SkillTree.spawnRockEveryXrock_1_purchased;
		data.spawnRockEveryXrock_2_purchased = SkillTree.spawnRockEveryXrock_2_purchased;
		data.spawnRockEveryXrock_3_purchased = SkillTree.spawnRockEveryXrock_3_purchased;
		data.spawnXRockEveryXSecond_1_purchased = SkillTree.spawnXRockEveryXSecond_1_purchased;
		data.spawnXRockEveryXSecond_2_purchased = SkillTree.spawnXRockEveryXSecond_2_purchased;
		data.spawnXRockEveryXSecond_3_purchased = SkillTree.spawnXRockEveryXSecond_3_purchased;
		data.chanceToSpawnRockWhenMined_1_purchased = SkillTree.chanceToSpawnRockWhenMined_1_purchased;
		data.chanceToSpawnRockWhenMined_2_purchased = SkillTree.chanceToSpawnRockWhenMined_2_purchased;
		data.chanceToSpawnRockWhenMined_3_purchased = SkillTree.chanceToSpawnRockWhenMined_3_purchased;
		data.chanceToSpawnRockWhenMined_4_purchased = SkillTree.chanceToSpawnRockWhenMined_4_purchased;
		data.chanceToSpawnRockWhenMined_5_purchased = SkillTree.chanceToSpawnRockWhenMined_5_purchased;
		data.chanceToSpawnRockWhenMined_6_purchased = SkillTree.chanceToSpawnRockWhenMined_6_purchased;
		data.chanceToMineRandomRock_1_purchased = SkillTree.chanceToMineRandomRock_1_purchased;
		data.chanceToMineRandomRock_2_purchased = SkillTree.chanceToMineRandomRock_2_purchased;
		data.chanceToMineRandomRock_3_purchased = SkillTree.chanceToMineRandomRock_3_purchased;
		data.chanceToMineRandomRock_4_purchased = SkillTree.chanceToMineRandomRock_4_purchased;
		data.spawnPickaxeEverySecond_1_purchased = SkillTree.spawnPickaxeEverySecond_1_purchased;
		data.spawnPickaxeEverySecond_2_purchased = SkillTree.spawnPickaxeEverySecond_2_purchased;
		data.spawnPickaxeEverySecond_3_purchased = SkillTree.spawnPickaxeEverySecond_3_purchased;
		data.doubleXpGoldChance_1_purchased = SkillTree.doubleXpGoldChance_1_purchased;
		data.doubleXpGoldChance_2_purchased = SkillTree.doubleXpGoldChance_2_purchased;
		data.doubleXpGoldChance_3_purchased = SkillTree.doubleXpGoldChance_3_purchased;
		data.doubleXpGoldChance_4_purchased = SkillTree.doubleXpGoldChance_4_purchased;
		data.doubleXpGoldChance_5_purchased = SkillTree.doubleXpGoldChance_5_purchased;
		data.lightningBeamChanceS_1_purchased = SkillTree.lightningBeamChanceS_1_purchased;
		data.lightningBeamChanceS_2_purchased = SkillTree.lightningBeamChanceS_2_purchased;
		data.lightningBeamChancePH_1_purchased = SkillTree.lightningBeamChancePH_1_purchased;
		data.lightningBeamChancePH_2_purchased = SkillTree.lightningBeamChancePH_2_purchased;
		data.lightningBeamSpawnAnotherOneChance_purchased = SkillTree.lightningBeamSpawnAnotherOneChance_purchased;
		data.lightningBeamDamage_purchased = SkillTree.lightningBeamDamage_purchased;
		data.lightningBeamSize_purchased = SkillTree.lightningBeamSize_purchased;
		data.lightningSplashes_purchased = SkillTree.lightningSplashes_purchased;
		data.lightningBeamSpawnRock_purchased = SkillTree.lightningBeamSpawnRock_purchased;
		data.lightningBeamExplosion_purchased = SkillTree.lightningBeamExplosion_purchased;
		data.lightningBeamAddTime_purchased = SkillTree.lightningBeamAddTime_purchased;
		data.dynamiteChance_1_purchased = SkillTree.dynamiteChance_1_purchased;
		data.dynamiteChance_2_purchased = SkillTree.dynamiteChance_2_purchased;
		data.dynamiteSpawn2SmallChance_purchased = SkillTree.dynamiteSpawn2SmallChance_purchased;
		data.dynamiteExplosionSize_purchased = SkillTree.dynamiteExplosionSize_purchased;
		data.dynamiteDamage_purchased = SkillTree.dynamiteDamage_purchased;
		data.dynamiteExplosionSpawnRock_purchased = SkillTree.dynamiteExplosionSpawnRock_purchased;
		data.dynamiteExplosionAddTimeChance_purchased = SkillTree.dynamiteExplosionAddTimeChance_purchased;
		data.dynamiteExplosionSpawnLightning_purchased = SkillTree.dynamiteExplosionSpawnLightning_purchased;
		data.plazmaBallSpawn_1_purchased = SkillTree.plazmaBallSpawn_1_purchased;
		data.plazmaBallSpawn_2_purchased = SkillTree.plazmaBallSpawn_2_purchased;
		data.plazmaBallTime_purchased = SkillTree.plazmaBallTime_purchased;
		data.plazmaBallSize_purchased = SkillTree.plazmaBallSize_purchased;
		data.plazmaBallExplosionChance_purchased = SkillTree.plazmaBallExplosionChance_purchased;
		data.plazmaBallSpawnSmallChance_purchased = SkillTree.plazmaBallSpawnSmallChance_purchased;
		data.plazmaBallDamage_purchased = SkillTree.plazmaBallDamage_purchased;
		data.plazmaBallSpawnPickaxeChance_purchased = SkillTree.plazmaBallSpawnPickaxeChance_purchased;
		data.allProjectileDoubleDamageChance_purchased = SkillTree.allProjectileDoubleDamageChance_purchased;
		data.allProjectileTriggerChance_purchased = SkillTree.allProjectileTriggerChance_purchased;
		data.pickaxeDoubleDamageChance_1_purchased = SkillTree.pickaxeDoubleDamageChance_1_purchased;
		data.pickaxeDoubleDamageChance_2_purchased = SkillTree.pickaxeDoubleDamageChance_2_purchased;
		data.intaMineChance_1_purchased = SkillTree.intaMineChance_1_purchased;
		data.intaMineChance_2_purchased = SkillTree.intaMineChance_2_purchased;
		data.increaseSpawnChanceAllRocks_purchased = SkillTree.increaseSpawnChanceAllRocks_purchased;
		data.craft2Material_purchased = SkillTree.craft2Material_purchased;
		data.finalUpgrade_purchased = SkillTree.finalUpgrade_purchased;
		data.moreXP_1_purchaseCount = SkillTree.moreXP_1_purchaseCount;
		data.moreXP_2_purchaseCount = SkillTree.moreXP_2_purchaseCount;
		data.moreXP_3_purchaseCount = SkillTree.moreXP_3_purchaseCount;
		data.moreXP_4_purchaseCount = SkillTree.moreXP_4_purchaseCount;
		data.moreXP_5_purchaseCount = SkillTree.moreXP_5_purchaseCount;
		data.moreXP_6_purchaseCount = SkillTree.moreXP_6_purchaseCount;
		data.moreXP_7_purchaseCount = SkillTree.moreXP_7_purchaseCount;
		data.moreXP_8_purchaseCount = SkillTree.moreXP_8_purchaseCount;
		data.talentPointsPerXlevel_1_purchaseCount = SkillTree.talentPointsPerXlevel_1_purchaseCount;
		data.talentPointsPerXlevel_2_purchaseCount = SkillTree.talentPointsPerXlevel_2_purchaseCount;
		data.talentPointsPerXlevel_3_purchaseCount = SkillTree.talentPointsPerXlevel_3_purchaseCount;
		data.spawnMoreRocks_1_purchaseCount = SkillTree.spawnMoreRocks_1_purchaseCount;
		data.spawnMoreRocks_2_purchaseCount = SkillTree.spawnMoreRocks_2_purchaseCount;
		data.spawnMoreRocks_3_purchaseCount = SkillTree.spawnMoreRocks_3_purchaseCount;
		data.spawnMoreRocks_4_purchaseCount = SkillTree.spawnMoreRocks_4_purchaseCount;
		data.spawnMoreRocks_5_purchaseCount = SkillTree.spawnMoreRocks_5_purchaseCount;
		data.spawnMoreRocks_6_purchaseCount = SkillTree.spawnMoreRocks_6_purchaseCount;
		data.spawnMoreRocks_7_purchaseCount = SkillTree.spawnMoreRocks_7_purchaseCount;
		data.spawnMoreRocks_8_purchaseCount = SkillTree.spawnMoreRocks_8_purchaseCount;
		data.spawnMoreRocks_9_purchaseCount = SkillTree.spawnMoreRocks_9_purchaseCount;
		data.moreMeterialsFromRock_1_purchaseCount = SkillTree.moreMeterialsFromRock_1_purchaseCount;
		data.moreMeterialsFromRock_2_purchaseCount = SkillTree.moreMeterialsFromRock_2_purchaseCount;
		data.moreMeterialsFromRock_3_purchaseCount = SkillTree.moreMeterialsFromRock_3_purchaseCount;
		data.moreMeterialsFromRock_4_purchaseCount = SkillTree.moreMeterialsFromRock_4_purchaseCount;
		data.moreMeterialsFromRock_5_purchaseCount = SkillTree.moreMeterialsFromRock_5_purchaseCount;
		data.marterialsWorthMore_1_purchaseCount = SkillTree.marterialsWorthMore_1_purchaseCount;
		data.marterialsWorthMore_2_purchaseCount = SkillTree.marterialsWorthMore_2_purchaseCount;
		data.marterialsWorthMore_3_purchaseCount = SkillTree.marterialsWorthMore_3_purchaseCount;
		data.marterialsWorthMore_4_purchaseCount = SkillTree.marterialsWorthMore_4_purchaseCount;
		data.marterialsWorthMore_5_purchaseCount = SkillTree.marterialsWorthMore_5_purchaseCount;
		data.marterialsWorthMore_6_purchaseCount = SkillTree.marterialsWorthMore_6_purchaseCount;
		data.marterialsWorthMore_7_purchaseCount = SkillTree.marterialsWorthMore_7_purchaseCount;
		data.marterialsWorthMore_8_purchaseCount = SkillTree.marterialsWorthMore_8_purchaseCount;
		data.goldChunk_1_purchaseCount = SkillTree.goldChunk_1_purchaseCount;
		data.goldChunk_2_purchaseCount = SkillTree.goldChunk_2_purchaseCount;
		data.goldChunk_3_purchaseCount = SkillTree.goldChunk_3_purchaseCount;
		data.goldChunk_4_purchaseCount = SkillTree.goldChunk_4_purchaseCount;
		data.goldChunk_5_purchaseCount = SkillTree.goldChunk_5_purchaseCount;
		data.fullGold_1_purchaseCount = SkillTree.fullGold_1_purchaseCount;
		data.fullGold_2_purchaseCount = SkillTree.fullGold_2_purchaseCount;
		data.fullGold_3_purchaseCount = SkillTree.fullGold_3_purchaseCount;
		data.spawnCopper_purchaseCount = SkillTree.spawnCopper_purchaseCount;
		data.copperChunk_1_purchaseCount = SkillTree.copperChunk_1_purchaseCount;
		data.copperChunk_2_purchaseCount = SkillTree.copperChunk_2_purchaseCount;
		data.copperChunk_3_purchaseCount = SkillTree.copperChunk_3_purchaseCount;
		data.fullCopper_1_purchaseCount = SkillTree.fullCopper_1_purchaseCount;
		data.fullCopper_2_purchaseCount = SkillTree.fullCopper_2_purchaseCount;
		data.fullCopper_3_purchaseCount = SkillTree.fullCopper_3_purchaseCount;
		data.spawnIron_purchaseCount = SkillTree.spawnIron_purchaseCount;
		data.ironChunk_1_purchaseCount = SkillTree.ironChunk_1_purchaseCount;
		data.ironChunk_2_purchaseCount = SkillTree.ironChunk_2_purchaseCount;
		data.fullIron_1_purchaseCount = SkillTree.fullIron_1_purchaseCount;
		data.fullIron_2_purchaseCount = SkillTree.fullIron_2_purchaseCount;
		data.cobaltSpawn_purchaseCount = SkillTree.cobaltSpawn_purchaseCount;
		data.cobaltChunk_1_purchaseCount = SkillTree.cobaltChunk_1_purchaseCount;
		data.fullCobalt_1_purchaseCount = SkillTree.fullCobalt_1_purchaseCount;
		data.uraniumSpawn_purchaseCount = SkillTree.uraniumSpawn_purchaseCount;
		data.uraniumChunk_1_purchaseCount = SkillTree.uraniumChunk_1_purchaseCount;
		data.fullUranium_1_purchaseCount = SkillTree.fullUranium_1_purchaseCount;
		data.ismiumSpawn_purchaseCount = SkillTree.ismiumSpawn_purchaseCount;
		data.ismiumChunk_1_purchaseCount = SkillTree.ismiumChunk_1_purchaseCount;
		data.fullIsmium_1_purchaseCount = SkillTree.fullIsmium_1_purchaseCount;
		data.iridiumSpawn_purchaseCount = SkillTree.iridiumSpawn_purchaseCount;
		data.iridiumChunk_1_purchaseCount = SkillTree.iridiumChunk_1_purchaseCount;
		data.fullIridium_1_purchaseCount = SkillTree.fullIridium_1_purchaseCount;
		data.painiteSpawn_purchaseCount = SkillTree.painiteSpawn_purchaseCount;
		data.painiteChunk_1_purchaseCount = SkillTree.painiteChunk_1_purchaseCount;
		data.fullPainite_1_purchaseCount = SkillTree.fullPainite_1_purchaseCount;
		data.improvedPickaxe_1_purchaseCount = SkillTree.improvedPickaxe_1_purchaseCount;
		data.improvedPickaxe_2_purchaseCount = SkillTree.improvedPickaxe_2_purchaseCount;
		data.improvedPickaxe_3_purchaseCount = SkillTree.improvedPickaxe_3_purchaseCount;
		data.improvedPickaxe_4_purchaseCount = SkillTree.improvedPickaxe_4_purchaseCount;
		data.improvedPickaxe_5_purchaseCount = SkillTree.improvedPickaxe_5_purchaseCount;
		data.improvedPickaxe_6_purchaseCount = SkillTree.improvedPickaxe_6_purchaseCount;
		data.biggerMiningErea_1_purchaseCount = SkillTree.biggerMiningErea_1_purchaseCount;
		data.biggerMiningErea_2_purchaseCount = SkillTree.biggerMiningErea_2_purchaseCount;
		data.biggerMiningErea_3_purchaseCount = SkillTree.biggerMiningErea_3_purchaseCount;
		data.biggerMiningErea_4_purchaseCount = SkillTree.biggerMiningErea_4_purchaseCount;
		data.shootCircleChance_purchaseCount = SkillTree.shootCircleChance_purchaseCount;
		data.increaseAndDecreaseMinignErea_purchaseCount = SkillTree.increaseAndDecreaseMinignErea_purchaseCount;
		data.spawnRockEveryXrock_1_purchaseCount = SkillTree.spawnRockEveryXrock_1_purchaseCount;
		data.spawnRockEveryXrock_2_purchaseCount = SkillTree.spawnRockEveryXrock_2_purchaseCount;
		data.spawnRockEveryXrock_3_purchaseCount = SkillTree.spawnRockEveryXrock_3_purchaseCount;
		data.spawnXRockEveryXSecond_1_purchaseCount = SkillTree.spawnXRockEveryXSecond_1_purchaseCount;
		data.spawnXRockEveryXSecond_2_purchaseCount = SkillTree.spawnXRockEveryXSecond_2_purchaseCount;
		data.spawnXRockEveryXSecond_3_purchaseCount = SkillTree.spawnXRockEveryXSecond_3_purchaseCount;
		data.chanceToSpawnRockWhenMined_1_purchaseCount = SkillTree.chanceToSpawnRockWhenMined_1_purchaseCount;
		data.chanceToSpawnRockWhenMined_2_purchaseCount = SkillTree.chanceToSpawnRockWhenMined_2_purchaseCount;
		data.chanceToSpawnRockWhenMined_3_purchaseCount = SkillTree.chanceToSpawnRockWhenMined_3_purchaseCount;
		data.chanceToSpawnRockWhenMined_4_purchaseCount = SkillTree.chanceToSpawnRockWhenMined_4_purchaseCount;
		data.chanceToSpawnRockWhenMined_5_purchaseCount = SkillTree.chanceToSpawnRockWhenMined_5_purchaseCount;
		data.chanceToSpawnRockWhenMined_6_purchaseCount = SkillTree.chanceToSpawnRockWhenMined_6_purchaseCount;
		data.chanceToMineRandomRock_1_purchaseCount = SkillTree.chanceToMineRandomRock_1_purchaseCount;
		data.chanceToMineRandomRock_2_purchaseCount = SkillTree.chanceToMineRandomRock_2_purchaseCount;
		data.chanceToMineRandomRock_3_purchaseCount = SkillTree.chanceToMineRandomRock_3_purchaseCount;
		data.chanceToMineRandomRock_4_purchaseCount = SkillTree.chanceToMineRandomRock_4_purchaseCount;
		data.spawnPickaxeEverySecond_1_purchaseCount = SkillTree.spawnPickaxeEverySecond_1_purchaseCount;
		data.spawnPickaxeEverySecond_2_purchaseCount = SkillTree.spawnPickaxeEverySecond_2_purchaseCount;
		data.spawnPickaxeEverySecond_3_purchaseCount = SkillTree.spawnPickaxeEverySecond_3_purchaseCount;
		data.moreTime_1_purchaseCount = SkillTree.moreTime_1_purchaseCount;
		data.moreTime_2_purchaseCount = SkillTree.moreTime_2_purchaseCount;
		data.moreTime_3_purchaseCount = SkillTree.moreTime_3_purchaseCount;
		data.moreTime_4_purchaseCount = SkillTree.moreTime_4_purchaseCount;
		data.chanceToAdd1SecondEverySecond_purchaseCount = SkillTree.chanceToAdd1SecondEverySecond_purchaseCount;
		data.chanceAdd1SecondEveryRockMined_purchaseCount = SkillTree.chanceAdd1SecondEveryRockMined_purchaseCount;
		data.doubleXpGoldChance_1_purchaseCount = SkillTree.doubleXpGoldChance_1_purchaseCount;
		data.doubleXpGoldChance_2_purchaseCount = SkillTree.doubleXpGoldChance_2_purchaseCount;
		data.doubleXpGoldChance_3_purchaseCount = SkillTree.doubleXpGoldChance_3_purchaseCount;
		data.doubleXpGoldChance_4_purchaseCount = SkillTree.doubleXpGoldChance_4_purchaseCount;
		data.doubleXpGoldChance_5_purchaseCount = SkillTree.doubleXpGoldChance_5_purchaseCount;
		data.lightningBeamChanceS_1_purchaseCount = SkillTree.lightningBeamChanceS_1_purchaseCount;
		data.lightningBeamChanceS_2_purchaseCount = SkillTree.lightningBeamChanceS_2_purchaseCount;
		data.lightningBeamChancePH_1_purchaseCount = SkillTree.lightningBeamChancePH_1_purchaseCount;
		data.lightningBeamChancePH_2_purchaseCount = SkillTree.lightningBeamChancePH_2_purchaseCount;
		data.lightningBeamSpawnAnotherOneChance_purchaseCount = SkillTree.lightningBeamSpawnAnotherOneChance_purchaseCount;
		data.lightningBeamDamage_purchaseCount = SkillTree.lightningBeamDamage_purchaseCount;
		data.lightningBeamSize_purchaseCount = SkillTree.lightningBeamSize_purchaseCount;
		data.lightningSplashes_purchaseCount = SkillTree.lightningSplashes_purchaseCount;
		data.lightningBeamSpawnRock_purchaseCount = SkillTree.lightningBeamSpawnRock_purchaseCount;
		data.lightningBeamExplosion_purchaseCount = SkillTree.lightningBeamExplosion_purchaseCount;
		data.lightningBeamAddTime_purchaseCount = SkillTree.lightningBeamAddTime_purchaseCount;
		data.dynamiteChance_1_purchaseCount = SkillTree.dynamiteChance_1_purchaseCount;
		data.dynamiteChance_2_purchaseCount = SkillTree.dynamiteChance_2_purchaseCount;
		data.dynamiteSpawn2SmallChance_purchaseCount = SkillTree.dynamiteSpawn2SmallChance_purchaseCount;
		data.dynamiteExplosionSize_purchaseCount = SkillTree.dynamiteExplosionSize_purchaseCount;
		data.dynamiteDamage_purchaseCount = SkillTree.dynamiteDamage_purchaseCount;
		data.dynamiteExplosionSpawnRock_purchaseCount = SkillTree.dynamiteExplosionSpawnRock_purchaseCount;
		data.dynamiteExplosionAddTimeChance_purchaseCount = SkillTree.dynamiteExplosionAddTimeChance_purchaseCount;
		data.dynamiteExplosionSpawnLightning_purchaseCount = SkillTree.dynamiteExplosionSpawnLightning_purchaseCount;
		data.plazmaBallSpawn_1_purchaseCount = SkillTree.plazmaBallSpawn_1_purchaseCount;
		data.plazmaBallSpawn_2_purchaseCount = SkillTree.plazmaBallSpawn_2_purchaseCount;
		data.plazmaBallTime_purchaseCount = SkillTree.plazmaBallTime_purchaseCount;
		data.plazmaBallSize_purchaseCount = SkillTree.plazmaBallSize_purchaseCount;
		data.plazmaBallExplosionChance_purchaseCount = SkillTree.plazmaBallExplosionChance_purchaseCount;
		data.plazmaBallSpawnSmallChance_purchaseCount = SkillTree.plazmaBallSpawnSmallChance_purchaseCount;
		data.plazmaBallDamage_purchaseCount = SkillTree.plazmaBallDamage_purchaseCount;
		data.plazmaBallSpawnPickaxeChance_purchaseCount = SkillTree.plazmaBallSpawnPickaxeChance_purchaseCount;
		data.allProjectileDoubleDamageChance_purchaseCount = SkillTree.allProjectileDoubleDamageChance_purchaseCount;
		data.allProjectileTriggerChance_purchaseCount = SkillTree.allProjectileTriggerChance_purchaseCount;
		data.pickaxeDoubleDamageChance_1_purchaseCount = SkillTree.pickaxeDoubleDamageChance_1_purchaseCount;
		data.pickaxeDoubleDamageChance_2_purchaseCount = SkillTree.pickaxeDoubleDamageChance_2_purchaseCount;
		data.intaMineChance_1_purchaseCount = SkillTree.intaMineChance_1_purchaseCount;
		data.intaMineChance_2_purchaseCount = SkillTree.intaMineChance_2_purchaseCount;
		data.increaseSpawnChanceAllRocks_purchaseCount = SkillTree.increaseSpawnChanceAllRocks_purchaseCount;
		data.craft2Material_purchaseCount = SkillTree.craft2Material_purchaseCount;
		data.finalUpgrade_purchaseCount = SkillTree.finalUpgrade_purchaseCount;
		data.totalSkillTreeUpgradesPurchased = SkillTree.totalSkillTreeUpgradesPurchased;
		data.totalUpgradesFullyPurchased = SkillTree.totalUpgradesFullyPurchased;
		data.mineSessionTime = SkillTree.mineSessionTime;
		data.totalRocksToSpawn = SkillTree.totalRocksToSpawn;
		data.extraTalentPointPerLevel = SkillTree.extraTalentPointPerLevel;
		data.goldRockChance = SkillTree.goldRockChance;
		data.fullGoldRockChance = SkillTree.fullGoldRockChance;
		data.copperRockChance = SkillTree.copperRockChance;
		data.fullCopperRockChance = SkillTree.fullCopperRockChance;
		data.ironRockChance = SkillTree.ironRockChance;
		data.fullIronRockChance = SkillTree.fullIronRockChance;
		data.cobaltRockChance = SkillTree.cobaltRockChance;
		data.fullCobaltRockChance = SkillTree.fullCobaltRockChance;
		data.uraniumRockChance = SkillTree.uraniumRockChance;
		data.fullUraniumRockChance = SkillTree.fullUraniumRockChance;
		data.ismiumRockChance = SkillTree.ismiumRockChance;
		data.fullIsmiumRockChance = SkillTree.fullIsmiumRockChance;
		data.iridiumRockChance = SkillTree.iridiumRockChance;
		data.fullIridiumRockChance = SkillTree.fullIridiumRockChance;
		data.painiteRockChance = SkillTree.painiteRockChance;
		data.fullPainiteRockChance = SkillTree.fullPainiteRockChance;
		data.improvedPickaxeStrength = SkillTree.improvedPickaxeStrength;
		data.reducePickaxeMineTime = SkillTree.reducePickaxeMineTime;
		data.miningAreaSize = SkillTree.miningAreaSize;
		data.spawnRockEveryXRock = SkillTree.spawnRockEveryXRock;
		data.spawnXRockEveryXSecond = SkillTree.spawnXRockEveryXSecond;
		data.chanceToSpawnRockWhenMined = SkillTree.chanceToSpawnRockWhenMined;
		data.materialsFromChunkRocks = SkillTree.materialsFromChunkRocks;
		data.materialsFromFullRocks = SkillTree.materialsFromFullRocks;
		data.materialsTotalWorth = SkillTree.materialsTotalWorth;
		data.chanceToMineRandomRock = SkillTree.chanceToMineRandomRock;
		data.spawnPickaxeEverySecond = SkillTree.spawnPickaxeEverySecond;
		data.doubleXpAndGoldChance = SkillTree.doubleXpAndGoldChance;
		data.lightningTriggerChanceS = SkillTree.lightningTriggerChanceS;
		data.lightningTriggerChancePH = SkillTree.lightningTriggerChancePH;
		data.lightningDamage = SkillTree.lightningDamage;
		data.lightningSize = SkillTree.lightningSize;
		data.dynamiteStickChance = SkillTree.dynamiteStickChance;
		data.explosionSize = SkillTree.explosionSize;
		data.explosionDamagage = SkillTree.explosionDamagage;
		data.plazmaBallChance = SkillTree.plazmaBallChance;
		data.plazmaBallTimer = SkillTree.plazmaBallTimer;
		data.plazmaBallTotalSize = SkillTree.plazmaBallTotalSize;
		data.plazmaBallTotalDamage = SkillTree.plazmaBallTotalDamage;
		data.doubleDamageChance = SkillTree.doubleDamageChance;
		data.instaMineChance = SkillTree.instaMineChance;
	}

	// Token: 0x060001D0 RID: 464 RVA: 0x0004F594 File Offset: 0x0004D794
	public void SetButtonsActive()
	{
		this.moreXP_1.GetComponent<Button>().enabled = true;
		this.moreXP_2.GetComponent<Button>().enabled = true;
		this.moreXP_3.GetComponent<Button>().enabled = true;
		this.moreXP_4.GetComponent<Button>().enabled = true;
		this.moreXP_5.GetComponent<Button>().enabled = true;
		this.moreXP_6.GetComponent<Button>().enabled = true;
		this.moreXP_7.GetComponent<Button>().enabled = true;
		this.moreXP_8.GetComponent<Button>().enabled = true;
		this.talentPointsPerXlevel_1.GetComponent<Button>().enabled = true;
		this.talentPointsPerXlevel_2.GetComponent<Button>().enabled = true;
		this.talentPointsPerXlevel_3.GetComponent<Button>().enabled = true;
		this.lightningBeamChanceS_1.GetComponent<Button>().enabled = true;
		this.lightningBeamChanceS_2.GetComponent<Button>().enabled = true;
		this.lightningBeamChancePH_1.GetComponent<Button>().enabled = true;
		this.lightningBeamChancePH_2.GetComponent<Button>().enabled = true;
		this.lightningBeamSpawnAnotherOneChance.GetComponent<Button>().enabled = true;
		this.lightningBeamDamage.GetComponent<Button>().enabled = true;
		this.lightningBeamSize.GetComponent<Button>().enabled = true;
		this.lightningSplashes.GetComponent<Button>().enabled = true;
		this.lightningBeamSpawnRock.GetComponent<Button>().enabled = true;
		this.lightningBeamExplosion.GetComponent<Button>().enabled = true;
		this.lightningBeamAddTime.GetComponent<Button>().enabled = true;
		this.dynamiteChance_1.GetComponent<Button>().enabled = true;
		this.dynamiteChance_2.GetComponent<Button>().enabled = true;
		this.dynamiteSpawn2SmallChance.GetComponent<Button>().enabled = true;
		this.dynamiteExplosionSize.GetComponent<Button>().enabled = true;
		this.dynamiteDamage.GetComponent<Button>().enabled = true;
		this.dynamiteExplosionSpawnRock.GetComponent<Button>().enabled = true;
		this.dynamiteExplosionAddTimeChance.GetComponent<Button>().enabled = true;
		this.dynamiteExplosionSpawnLightning.GetComponent<Button>().enabled = true;
		this.plazmaBallSpawn_1.GetComponent<Button>().enabled = true;
		this.plazmaBallSpawn_2.GetComponent<Button>().enabled = true;
		this.plazmaBallTime.GetComponent<Button>().enabled = true;
		this.plazmaBallSize.GetComponent<Button>().enabled = true;
		this.plazmaBallExplosionChance.GetComponent<Button>().enabled = true;
		this.plazmaBallSpawnSmallChance.GetComponent<Button>().enabled = true;
		this.plazmaBallDamage.GetComponent<Button>().enabled = true;
		this.plazmaBallSpawnPickaxeChance.GetComponent<Button>().enabled = true;
		this.spawnMoreRocks_1.GetComponent<Button>().enabled = true;
		this.spawnMoreRocks_2.GetComponent<Button>().enabled = true;
		this.spawnMoreRocks_3.GetComponent<Button>().enabled = true;
		this.spawnMoreRocks_4.GetComponent<Button>().enabled = true;
		this.spawnMoreRocks_5.GetComponent<Button>().enabled = true;
		this.spawnMoreRocks_6.GetComponent<Button>().enabled = true;
		this.spawnMoreRocks_7.GetComponent<Button>().enabled = true;
		this.spawnMoreRocks_8.GetComponent<Button>().enabled = true;
		this.spawnMoreRocks_9.GetComponent<Button>().enabled = true;
		this.moreMeterialsFromRock_1.GetComponent<Button>().enabled = true;
		this.moreMeterialsFromRock_2.GetComponent<Button>().enabled = true;
		this.moreMeterialsFromRock_3.GetComponent<Button>().enabled = true;
		this.moreMeterialsFromRock_4.GetComponent<Button>().enabled = true;
		this.moreMeterialsFromRock_5.GetComponent<Button>().enabled = true;
		this.marterialsWorthMore_1.GetComponent<Button>().enabled = true;
		this.marterialsWorthMore_2.GetComponent<Button>().enabled = true;
		this.marterialsWorthMore_3.GetComponent<Button>().enabled = true;
		this.marterialsWorthMore_4.GetComponent<Button>().enabled = true;
		this.marterialsWorthMore_5.GetComponent<Button>().enabled = true;
		this.marterialsWorthMore_6.GetComponent<Button>().enabled = true;
		this.marterialsWorthMore_7.GetComponent<Button>().enabled = true;
		this.marterialsWorthMore_8.GetComponent<Button>().enabled = true;
		this.goldChunk_1.GetComponent<Button>().enabled = true;
		this.goldChunk_2.GetComponent<Button>().enabled = true;
		this.goldChunk_3.GetComponent<Button>().enabled = true;
		this.goldChunk_4.GetComponent<Button>().enabled = true;
		this.goldChunk_5_.GetComponent<Button>().enabled = true;
		this.fullGold_1.GetComponent<Button>().enabled = true;
		this.fullGold_2.GetComponent<Button>().enabled = true;
		this.fullGold_3.GetComponent<Button>().enabled = true;
		this.spawnCopper.GetComponent<Button>().enabled = true;
		this.copperChunk_1.GetComponent<Button>().enabled = true;
		this.copperChunk_2.GetComponent<Button>().enabled = true;
		this.copperChunk_3.GetComponent<Button>().enabled = true;
		this.fullCopper_1.GetComponent<Button>().enabled = true;
		this.fullCopper_2.GetComponent<Button>().enabled = true;
		this.fullCopper_3.GetComponent<Button>().enabled = true;
		this.spawnIron.GetComponent<Button>().enabled = true;
		this.ironChunk_1.GetComponent<Button>().enabled = true;
		this.ironChunk_2.GetComponent<Button>().enabled = true;
		this.fullIron_1.GetComponent<Button>().enabled = true;
		this.fullIron_2.GetComponent<Button>().enabled = true;
		this.cobaltSpawn.GetComponent<Button>().enabled = true;
		this.cobaltChunk_1.GetComponent<Button>().enabled = true;
		this.fullCobalt_1.GetComponent<Button>().enabled = true;
		this.uraniumSpawn.GetComponent<Button>().enabled = true;
		this.uraniumChunk_1.GetComponent<Button>().enabled = true;
		this.fullUranium_1.GetComponent<Button>().enabled = true;
		this.ismiumSpawn.GetComponent<Button>().enabled = true;
		this.ismiumChunk_1.GetComponent<Button>().enabled = true;
		this.fullIsmium_1.GetComponent<Button>().enabled = true;
		this.iridiumSpawn.GetComponent<Button>().enabled = true;
		this.iridiumChunk_1.GetComponent<Button>().enabled = true;
		this.fullIridium_1.GetComponent<Button>().enabled = true;
		this.painiteSpawn.GetComponent<Button>().enabled = true;
		this.painiteChunk_1.GetComponent<Button>().enabled = true;
		this.fullPainite_1.GetComponent<Button>().enabled = true;
		this.improvedPickaxe_1.GetComponent<Button>().enabled = true;
		this.improvedPickaxe_2.GetComponent<Button>().enabled = true;
		this.improvedPickaxe_3.GetComponent<Button>().enabled = true;
		this.improvedPickaxe_4.GetComponent<Button>().enabled = true;
		this.improvedPickaxe_5.GetComponent<Button>().enabled = true;
		this.improvedPickaxe_6.GetComponent<Button>().enabled = true;
		this.biggerMiningErea_1.GetComponent<Button>().enabled = true;
		this.biggerMiningErea_2.GetComponent<Button>().enabled = true;
		this.biggerMiningErea_3.GetComponent<Button>().enabled = true;
		this.biggerMiningErea_4.GetComponent<Button>().enabled = true;
		this.shootCircleChance.GetComponent<Button>().enabled = true;
		this.increaseAndDecreaseMinignErea.GetComponent<Button>().enabled = true;
		this.spawnRockEveryXrock_1.GetComponent<Button>().enabled = true;
		this.spawnRockEveryXrock_2.GetComponent<Button>().enabled = true;
		this.spawnRockEveryXrock_3.GetComponent<Button>().enabled = true;
		this.spawnXRockEveryXSecond_1.GetComponent<Button>().enabled = true;
		this.spawnXRockEveryXSecond_2.GetComponent<Button>().enabled = true;
		this.spawnXRockEveryXSecond_3.GetComponent<Button>().enabled = true;
		this.chanceToSpawnRockWhenMined_1.GetComponent<Button>().enabled = true;
		this.chanceToSpawnRockWhenMined_2.GetComponent<Button>().enabled = true;
		this.chanceToSpawnRockWhenMined_3.GetComponent<Button>().enabled = true;
		this.chanceToSpawnRockWhenMined_4.GetComponent<Button>().enabled = true;
		this.chanceToSpawnRockWhenMined_5.GetComponent<Button>().enabled = true;
		this.chanceToSpawnRockWhenMined_6.GetComponent<Button>().enabled = true;
		this.chanceToMineRandomRock_1.GetComponent<Button>().enabled = true;
		this.chanceToMineRandomRock_2.GetComponent<Button>().enabled = true;
		this.chanceToMineRandomRock_3.GetComponent<Button>().enabled = true;
		this.chanceToMineRandomRock_4.GetComponent<Button>().enabled = true;
		this.spawnPickaxeEverySecond_1.GetComponent<Button>().enabled = true;
		this.spawnPickaxeEverySecond_2.GetComponent<Button>().enabled = true;
		this.spawnPickaxeEverySecond_3.GetComponent<Button>().enabled = true;
		this.moreTime_1.GetComponent<Button>().enabled = true;
		this.moreTime_2.GetComponent<Button>().enabled = true;
		this.moreTime_3.GetComponent<Button>().enabled = true;
		this.moreTime_4.GetComponent<Button>().enabled = true;
		this.chanceToAdd1SecondEverySecond.GetComponent<Button>().enabled = true;
		this.chanceAdd1SecondEveryRockMined.GetComponent<Button>().enabled = true;
		this.doubleXpGoldChance_1.GetComponent<Button>().enabled = true;
		this.doubleXpGoldChance_2.GetComponent<Button>().enabled = true;
		this.doubleXpGoldChance_3.GetComponent<Button>().enabled = true;
		this.doubleXpGoldChance_4.GetComponent<Button>().enabled = true;
		this.doubleXpGoldChance_5.GetComponent<Button>().enabled = true;
		this.allProjectileDoubleDamageChance.GetComponent<Button>().enabled = true;
		this.allProjectileTriggerChance.GetComponent<Button>().enabled = true;
		this.pickaxeDoubleDamageChance_1.GetComponent<Button>().enabled = true;
		this.pickaxeDoubleDamageChance_2.GetComponent<Button>().enabled = true;
		this.intaMineChance_1.GetComponent<Button>().enabled = true;
		this.intaMineChance_2.GetComponent<Button>().enabled = true;
		this.increaseSpawnChanceAllRocks.GetComponent<Button>().enabled = true;
		this.craft2Material.GetComponent<Button>().enabled = true;
		this.finalUpgrade.GetComponent<Button>().enabled = true;
	}

	// Token: 0x060001D1 RID: 465 RVA: 0x0004FF54 File Offset: 0x0004E154
	public void ResetSkillTree()
	{
		SkillTree.moreXP_1_purchased = false;
		SkillTree.moreXP_2_purchased = false;
		SkillTree.moreXP_3_purchased = false;
		SkillTree.moreXP_4_purchased = false;
		SkillTree.moreXP_5_purchased = false;
		SkillTree.moreXP_6_purchased = false;
		SkillTree.moreXP_7_purchased = false;
		SkillTree.moreXP_8_purchased = false;
		SkillTree.talentPointsPerXlevel_1_purchased = false;
		SkillTree.talentPointsPerXlevel_2_purchased = false;
		SkillTree.talentPointsPerXlevel_3_purchased = false;
		SkillTree.spawnMoreRocks_1_purchased = false;
		SkillTree.spawnMoreRocks_2_purchased = false;
		SkillTree.spawnMoreRocks_3_purchased = false;
		SkillTree.spawnMoreRocks_4_purchased = false;
		SkillTree.spawnMoreRocks_5_purchased = false;
		SkillTree.spawnMoreRocks_6_purchased = false;
		SkillTree.spawnMoreRocks_7_purchased = false;
		SkillTree.spawnMoreRocks_8_purchased = false;
		SkillTree.spawnMoreRocks_9_purchased = false;
		SkillTree.moreMeterialsFromRock_1_purchased = false;
		SkillTree.moreMeterialsFromRock_2_purchased = false;
		SkillTree.moreMeterialsFromRock_3_purchased = false;
		SkillTree.moreMeterialsFromRock_4_purchased = false;
		SkillTree.moreMeterialsFromRock_5_purchased = false;
		SkillTree.marterialsWorthMore_1_purchased = false;
		SkillTree.marterialsWorthMore_2_purchased = false;
		SkillTree.marterialsWorthMore_3_purchased = false;
		SkillTree.marterialsWorthMore_4_purchased = false;
		SkillTree.marterialsWorthMore_5_purchased = false;
		SkillTree.marterialsWorthMore_6_purchased = false;
		SkillTree.marterialsWorthMore_7_purchased = false;
		SkillTree.marterialsWorthMore_8_purchased = false;
		SkillTree.goldChunk_1_purchased = false;
		SkillTree.goldChunk_2_purchased = false;
		SkillTree.goldChunk_3_purchased = false;
		SkillTree.goldChunk_4_purchased = false;
		SkillTree.goldChunk_5_purchased = false;
		SkillTree.fullGold_1_purchased = false;
		SkillTree.fullGold_2_purchased = false;
		SkillTree.fullGold_3_purchased = false;
		SkillTree.spawnCopper_purchased = false;
		SkillTree.copperChunk_1_purchased = false;
		SkillTree.copperChunk_2_purchased = false;
		SkillTree.copperChunk_3_purchased = false;
		SkillTree.fullCopper_1_purchased = false;
		SkillTree.fullCopper_2_purchased = false;
		SkillTree.fullCopper_3_purchased = false;
		SkillTree.spawnIron_purchased = false;
		SkillTree.ironChunk_1_purchased = false;
		SkillTree.ironChunk_2_purchased = false;
		SkillTree.fullIron_1_purchased = false;
		SkillTree.fullIron_2_purchased = false;
		SkillTree.cobaltSpawn_purchased = false;
		SkillTree.cobaltChunk_1_purchased = false;
		SkillTree.fullCobalt_1_purchased = false;
		SkillTree.uraniumSpawn_purchased = false;
		SkillTree.uraniumChunk_1_purchased = false;
		SkillTree.fullUranium_1_purchased = false;
		SkillTree.ismiumSpawn_purchased = false;
		SkillTree.ismiumChunk_1_purchased = false;
		SkillTree.fullIsmium_1_purchased = false;
		SkillTree.iridiumSpawn_purchased = false;
		SkillTree.iridiumChunk_1_purchased = false;
		SkillTree.fullIridium_1_purchased = false;
		SkillTree.painiteSpawn_purchased = false;
		SkillTree.painiteChunk_1_purchased = false;
		SkillTree.fullPainite_1_purchased = false;
		SkillTree.improvedPickaxe_1_purchased = false;
		SkillTree.improvedPickaxe_2_purchased = false;
		SkillTree.improvedPickaxe_3_purchased = false;
		SkillTree.improvedPickaxe_4_purchased = false;
		SkillTree.improvedPickaxe_5_purchased = false;
		SkillTree.improvedPickaxe_6_purchased = false;
		SkillTree.biggerMiningErea_1_purchased = false;
		SkillTree.biggerMiningErea_2_purchased = false;
		SkillTree.biggerMiningErea_3_purchased = false;
		SkillTree.biggerMiningErea_4_purchased = false;
		SkillTree.shootCircleChance_purchased = false;
		SkillTree.increaseAndDecreaseMinignErea_purchased = false;
		SkillTree.spawnRockEveryXrock_1_purchased = false;
		SkillTree.spawnRockEveryXrock_2_purchased = false;
		SkillTree.spawnRockEveryXrock_3_purchased = false;
		SkillTree.spawnXRockEveryXSecond_1_purchased = false;
		SkillTree.spawnXRockEveryXSecond_2_purchased = false;
		SkillTree.spawnXRockEveryXSecond_3_purchased = false;
		SkillTree.chanceToSpawnRockWhenMined_1_purchased = false;
		SkillTree.chanceToSpawnRockWhenMined_2_purchased = false;
		SkillTree.chanceToSpawnRockWhenMined_3_purchased = false;
		SkillTree.chanceToSpawnRockWhenMined_4_purchased = false;
		SkillTree.chanceToSpawnRockWhenMined_5_purchased = false;
		SkillTree.chanceToSpawnRockWhenMined_6_purchased = false;
		SkillTree.chanceToMineRandomRock_1_purchased = false;
		SkillTree.chanceToMineRandomRock_2_purchased = false;
		SkillTree.chanceToMineRandomRock_3_purchased = false;
		SkillTree.chanceToMineRandomRock_4_purchased = false;
		SkillTree.spawnPickaxeEverySecond_1_purchased = false;
		SkillTree.spawnPickaxeEverySecond_2_purchased = false;
		SkillTree.spawnPickaxeEverySecond_3_purchased = false;
		SkillTree.moreTime_1_purchased = false;
		SkillTree.moreTime_2_purchased = false;
		SkillTree.moreTime_3_purchased = false;
		SkillTree.moreTime_4_purchased = false;
		SkillTree.chanceToAdd1SecondEverySecond_purchased = false;
		SkillTree.chanceAdd1SecondEveryRockMined_purchased = false;
		SkillTree.doubleXpGoldChance_1_purchased = false;
		SkillTree.doubleXpGoldChance_2_purchased = false;
		SkillTree.doubleXpGoldChance_3_purchased = false;
		SkillTree.doubleXpGoldChance_4_purchased = false;
		SkillTree.doubleXpGoldChance_5_purchased = false;
		SkillTree.lightningBeamChanceS_1_purchased = false;
		SkillTree.lightningBeamChanceS_2_purchased = false;
		SkillTree.lightningBeamChancePH_1_purchased = false;
		SkillTree.lightningBeamChancePH_2_purchased = false;
		SkillTree.lightningBeamSpawnAnotherOneChance_purchased = false;
		SkillTree.lightningBeamDamage_purchased = false;
		SkillTree.lightningBeamSize_purchased = false;
		SkillTree.lightningSplashes_purchased = false;
		SkillTree.lightningBeamSpawnRock_purchased = false;
		SkillTree.lightningBeamExplosion_purchased = false;
		SkillTree.lightningBeamAddTime_purchased = false;
		SkillTree.dynamiteChance_1_purchased = false;
		SkillTree.dynamiteChance_2_purchased = false;
		SkillTree.dynamiteSpawn2SmallChance_purchased = false;
		SkillTree.dynamiteExplosionSize_purchased = false;
		SkillTree.dynamiteDamage_purchased = false;
		SkillTree.dynamiteExplosionSpawnRock_purchased = false;
		SkillTree.dynamiteExplosionAddTimeChance_purchased = false;
		SkillTree.dynamiteExplosionSpawnLightning_purchased = false;
		SkillTree.plazmaBallSpawn_1_purchased = false;
		SkillTree.plazmaBallSpawn_2_purchased = false;
		SkillTree.plazmaBallTime_purchased = false;
		SkillTree.plazmaBallSize_purchased = false;
		SkillTree.plazmaBallExplosionChance_purchased = false;
		SkillTree.plazmaBallSpawnSmallChance_purchased = false;
		SkillTree.plazmaBallDamage_purchased = false;
		SkillTree.plazmaBallSpawnPickaxeChance_purchased = false;
		SkillTree.allProjectileDoubleDamageChance_purchased = false;
		SkillTree.allProjectileTriggerChance_purchased = false;
		SkillTree.pickaxeDoubleDamageChance_1_purchased = false;
		SkillTree.pickaxeDoubleDamageChance_2_purchased = false;
		SkillTree.intaMineChance_1_purchased = false;
		SkillTree.intaMineChance_2_purchased = false;
		SkillTree.increaseSpawnChanceAllRocks_purchased = false;
		SkillTree.craft2Material_purchased = false;
		SkillTree.finalUpgrade_purchased = false;
		SkillTree.moreXP_1_purchaseCount = 0;
		SkillTree.moreXP_2_purchaseCount = 0;
		SkillTree.moreXP_3_purchaseCount = 0;
		SkillTree.moreXP_4_purchaseCount = 0;
		SkillTree.moreXP_5_purchaseCount = 0;
		SkillTree.moreXP_6_purchaseCount = 0;
		SkillTree.moreXP_7_purchaseCount = 0;
		SkillTree.moreXP_8_purchaseCount = 0;
		SkillTree.talentPointsPerXlevel_1_purchaseCount = 0;
		SkillTree.talentPointsPerXlevel_2_purchaseCount = 0;
		SkillTree.talentPointsPerXlevel_3_purchaseCount = 0;
		SkillTree.spawnMoreRocks_1_purchaseCount = 0;
		SkillTree.spawnMoreRocks_2_purchaseCount = 0;
		SkillTree.spawnMoreRocks_3_purchaseCount = 0;
		SkillTree.spawnMoreRocks_4_purchaseCount = 0;
		SkillTree.spawnMoreRocks_5_purchaseCount = 0;
		SkillTree.spawnMoreRocks_6_purchaseCount = 0;
		SkillTree.spawnMoreRocks_7_purchaseCount = 0;
		SkillTree.spawnMoreRocks_8_purchaseCount = 0;
		SkillTree.spawnMoreRocks_9_purchaseCount = 0;
		SkillTree.moreMeterialsFromRock_1_purchaseCount = 0;
		SkillTree.moreMeterialsFromRock_2_purchaseCount = 0;
		SkillTree.moreMeterialsFromRock_3_purchaseCount = 0;
		SkillTree.moreMeterialsFromRock_4_purchaseCount = 0;
		SkillTree.moreMeterialsFromRock_5_purchaseCount = 0;
		SkillTree.marterialsWorthMore_1_purchaseCount = 0;
		SkillTree.marterialsWorthMore_2_purchaseCount = 0;
		SkillTree.marterialsWorthMore_3_purchaseCount = 0;
		SkillTree.marterialsWorthMore_4_purchaseCount = 0;
		SkillTree.marterialsWorthMore_5_purchaseCount = 0;
		SkillTree.marterialsWorthMore_6_purchaseCount = 0;
		SkillTree.marterialsWorthMore_7_purchaseCount = 0;
		SkillTree.marterialsWorthMore_8_purchaseCount = 0;
		SkillTree.goldChunk_1_purchaseCount = 0;
		SkillTree.goldChunk_2_purchaseCount = 0;
		SkillTree.goldChunk_3_purchaseCount = 0;
		SkillTree.goldChunk_4_purchaseCount = 0;
		SkillTree.goldChunk_5_purchaseCount = 0;
		SkillTree.fullGold_1_purchaseCount = 0;
		SkillTree.fullGold_2_purchaseCount = 0;
		SkillTree.fullGold_3_purchaseCount = 0;
		SkillTree.spawnCopper_purchaseCount = 0;
		SkillTree.copperChunk_1_purchaseCount = 0;
		SkillTree.copperChunk_2_purchaseCount = 0;
		SkillTree.copperChunk_3_purchaseCount = 0;
		SkillTree.fullCopper_1_purchaseCount = 0;
		SkillTree.fullCopper_2_purchaseCount = 0;
		SkillTree.fullCopper_3_purchaseCount = 0;
		SkillTree.spawnIron_purchaseCount = 0;
		SkillTree.ironChunk_1_purchaseCount = 0;
		SkillTree.ironChunk_2_purchaseCount = 0;
		SkillTree.fullIron_1_purchaseCount = 0;
		SkillTree.fullIron_2_purchaseCount = 0;
		SkillTree.cobaltSpawn_purchaseCount = 0;
		SkillTree.cobaltChunk_1_purchaseCount = 0;
		SkillTree.fullCobalt_1_purchaseCount = 0;
		SkillTree.uraniumSpawn_purchaseCount = 0;
		SkillTree.uraniumChunk_1_purchaseCount = 0;
		SkillTree.fullUranium_1_purchaseCount = 0;
		SkillTree.ismiumSpawn_purchaseCount = 0;
		SkillTree.ismiumChunk_1_purchaseCount = 0;
		SkillTree.fullIsmium_1_purchaseCount = 0;
		SkillTree.iridiumSpawn_purchaseCount = 0;
		SkillTree.iridiumChunk_1_purchaseCount = 0;
		SkillTree.fullIridium_1_purchaseCount = 0;
		SkillTree.painiteSpawn_purchaseCount = 0;
		SkillTree.painiteChunk_1_purchaseCount = 0;
		SkillTree.fullPainite_1_purchaseCount = 0;
		SkillTree.improvedPickaxe_1_purchaseCount = 0;
		SkillTree.improvedPickaxe_2_purchaseCount = 0;
		SkillTree.improvedPickaxe_3_purchaseCount = 0;
		SkillTree.improvedPickaxe_4_purchaseCount = 0;
		SkillTree.improvedPickaxe_5_purchaseCount = 0;
		SkillTree.improvedPickaxe_6_purchaseCount = 0;
		SkillTree.biggerMiningErea_1_purchaseCount = 0;
		SkillTree.biggerMiningErea_2_purchaseCount = 0;
		SkillTree.biggerMiningErea_3_purchaseCount = 0;
		SkillTree.biggerMiningErea_4_purchaseCount = 0;
		SkillTree.shootCircleChance_purchaseCount = 0;
		SkillTree.increaseAndDecreaseMinignErea_purchaseCount = 0;
		SkillTree.spawnRockEveryXrock_1_purchaseCount = 0;
		SkillTree.spawnRockEveryXrock_2_purchaseCount = 0;
		SkillTree.spawnRockEveryXrock_3_purchaseCount = 0;
		SkillTree.spawnXRockEveryXSecond_1_purchaseCount = 0;
		SkillTree.spawnXRockEveryXSecond_2_purchaseCount = 0;
		SkillTree.spawnXRockEveryXSecond_3_purchaseCount = 0;
		SkillTree.chanceToSpawnRockWhenMined_1_purchaseCount = 0;
		SkillTree.chanceToSpawnRockWhenMined_2_purchaseCount = 0;
		SkillTree.chanceToSpawnRockWhenMined_3_purchaseCount = 0;
		SkillTree.chanceToSpawnRockWhenMined_4_purchaseCount = 0;
		SkillTree.chanceToSpawnRockWhenMined_5_purchaseCount = 0;
		SkillTree.chanceToSpawnRockWhenMined_6_purchaseCount = 0;
		SkillTree.chanceToMineRandomRock_1_purchaseCount = 0;
		SkillTree.chanceToMineRandomRock_2_purchaseCount = 0;
		SkillTree.chanceToMineRandomRock_3_purchaseCount = 0;
		SkillTree.chanceToMineRandomRock_4_purchaseCount = 0;
		SkillTree.spawnPickaxeEverySecond_1_purchaseCount = 0;
		SkillTree.spawnPickaxeEverySecond_2_purchaseCount = 0;
		SkillTree.spawnPickaxeEverySecond_3_purchaseCount = 0;
		SkillTree.moreTime_1_purchaseCount = 0;
		SkillTree.moreTime_2_purchaseCount = 0;
		SkillTree.moreTime_3_purchaseCount = 0;
		SkillTree.moreTime_4_purchaseCount = 0;
		SkillTree.chanceToAdd1SecondEverySecond_purchaseCount = 0;
		SkillTree.chanceAdd1SecondEveryRockMined_purchaseCount = 0;
		SkillTree.doubleXpGoldChance_1_purchaseCount = 0;
		SkillTree.doubleXpGoldChance_2_purchaseCount = 0;
		SkillTree.doubleXpGoldChance_3_purchaseCount = 0;
		SkillTree.doubleXpGoldChance_4_purchaseCount = 0;
		SkillTree.doubleXpGoldChance_5_purchaseCount = 0;
		SkillTree.lightningBeamChanceS_1_purchaseCount = 0;
		SkillTree.lightningBeamChanceS_2_purchaseCount = 0;
		SkillTree.lightningBeamChancePH_1_purchaseCount = 0;
		SkillTree.lightningBeamChancePH_2_purchaseCount = 0;
		SkillTree.lightningBeamSpawnAnotherOneChance_purchaseCount = 0;
		SkillTree.lightningBeamDamage_purchaseCount = 0;
		SkillTree.lightningBeamSize_purchaseCount = 0;
		SkillTree.lightningSplashes_purchaseCount = 0;
		SkillTree.lightningBeamSpawnRock_purchaseCount = 0;
		SkillTree.lightningBeamExplosion_purchaseCount = 0;
		SkillTree.lightningBeamAddTime_purchaseCount = 0;
		SkillTree.dynamiteChance_1_purchaseCount = 0;
		SkillTree.dynamiteChance_2_purchaseCount = 0;
		SkillTree.dynamiteSpawn2SmallChance_purchaseCount = 0;
		SkillTree.dynamiteExplosionSize_purchaseCount = 0;
		SkillTree.dynamiteDamage_purchaseCount = 0;
		SkillTree.dynamiteExplosionSpawnRock_purchaseCount = 0;
		SkillTree.dynamiteExplosionAddTimeChance_purchaseCount = 0;
		SkillTree.dynamiteExplosionSpawnLightning_purchaseCount = 0;
		SkillTree.plazmaBallSpawn_1_purchaseCount = 0;
		SkillTree.plazmaBallSpawn_2_purchaseCount = 0;
		SkillTree.plazmaBallTime_purchaseCount = 0;
		SkillTree.plazmaBallSize_purchaseCount = 0;
		SkillTree.plazmaBallExplosionChance_purchaseCount = 0;
		SkillTree.plazmaBallSpawnSmallChance_purchaseCount = 0;
		SkillTree.plazmaBallDamage_purchaseCount = 0;
		SkillTree.plazmaBallSpawnPickaxeChance_purchaseCount = 0;
		SkillTree.allProjectileDoubleDamageChance_purchaseCount = 0;
		SkillTree.allProjectileTriggerChance_purchaseCount = 0;
		SkillTree.pickaxeDoubleDamageChance_1_purchaseCount = 0;
		SkillTree.pickaxeDoubleDamageChance_2_purchaseCount = 0;
		SkillTree.intaMineChance_1_purchaseCount = 0;
		SkillTree.intaMineChance_2_purchaseCount = 0;
		SkillTree.increaseSpawnChanceAllRocks_purchaseCount = 0;
		SkillTree.craft2Material_purchaseCount = 0;
		SkillTree.finalUpgrade_purchaseCount = 0;
		for (int i = 0; i < this.lines.Length; i++)
		{
			this.lines[i].SetActive(false);
			this.finaLine.SetActive(false);
		}
		this.moreXP_1.SetActive(false);
		this.moreXP_2.SetActive(false);
		this.moreXP_3.SetActive(false);
		this.moreXP_4.SetActive(false);
		this.moreXP_5.SetActive(false);
		this.moreXP_6.SetActive(false);
		this.moreXP_7.SetActive(false);
		this.moreXP_8.SetActive(false);
		this.talentPointsPerXlevel_1.SetActive(false);
		this.talentPointsPerXlevel_2.SetActive(false);
		this.talentPointsPerXlevel_3.SetActive(false);
		this.lightningBeamChanceS_1.SetActive(false);
		this.lightningBeamChanceS_2.SetActive(false);
		this.lightningBeamChancePH_1.SetActive(false);
		this.lightningBeamChancePH_2.SetActive(false);
		this.lightningBeamSpawnAnotherOneChance.SetActive(false);
		this.lightningBeamDamage.SetActive(false);
		this.lightningBeamSize.SetActive(false);
		this.lightningSplashes.SetActive(false);
		this.lightningBeamSpawnRock.SetActive(false);
		this.lightningBeamExplosion.SetActive(false);
		this.lightningBeamAddTime.SetActive(false);
		this.dynamiteChance_1.SetActive(false);
		this.dynamiteChance_2.SetActive(false);
		this.dynamiteSpawn2SmallChance.SetActive(false);
		this.dynamiteExplosionSize.SetActive(false);
		this.dynamiteDamage.SetActive(false);
		this.dynamiteExplosionSpawnRock.SetActive(false);
		this.dynamiteExplosionAddTimeChance.SetActive(false);
		this.dynamiteExplosionSpawnLightning.SetActive(false);
		this.plazmaBallSpawn_1.SetActive(false);
		this.plazmaBallSpawn_2.SetActive(false);
		this.plazmaBallTime.SetActive(false);
		this.plazmaBallSize.SetActive(false);
		this.plazmaBallExplosionChance.SetActive(false);
		this.plazmaBallSpawnSmallChance.SetActive(false);
		this.plazmaBallDamage.SetActive(false);
		this.plazmaBallSpawnPickaxeChance.SetActive(false);
		this.spawnMoreRocks_1.SetActive(true);
		this.spawnMoreRocks_2.SetActive(false);
		this.spawnMoreRocks_3.SetActive(false);
		this.spawnMoreRocks_4.SetActive(false);
		this.spawnMoreRocks_5.SetActive(false);
		this.spawnMoreRocks_6.SetActive(false);
		this.spawnMoreRocks_7.SetActive(false);
		this.spawnMoreRocks_8.SetActive(false);
		this.spawnMoreRocks_9.SetActive(false);
		this.moreMeterialsFromRock_1.SetActive(false);
		this.moreMeterialsFromRock_2.SetActive(false);
		this.moreMeterialsFromRock_3.SetActive(false);
		this.moreMeterialsFromRock_4.SetActive(false);
		this.moreMeterialsFromRock_5.SetActive(false);
		this.marterialsWorthMore_1.SetActive(false);
		this.marterialsWorthMore_2.SetActive(false);
		this.marterialsWorthMore_3.SetActive(false);
		this.marterialsWorthMore_4.SetActive(false);
		this.marterialsWorthMore_5.SetActive(false);
		this.marterialsWorthMore_6.SetActive(false);
		this.marterialsWorthMore_7.SetActive(false);
		this.marterialsWorthMore_8.SetActive(false);
		this.goldChunk_1.SetActive(false);
		this.goldChunk_2.SetActive(false);
		this.goldChunk_3.SetActive(false);
		this.goldChunk_4.SetActive(false);
		this.goldChunk_5_.SetActive(false);
		this.fullGold_1.SetActive(false);
		this.fullGold_2.SetActive(false);
		this.fullGold_3.SetActive(false);
		this.spawnCopper.SetActive(false);
		this.copperChunk_1.SetActive(false);
		this.copperChunk_2.SetActive(false);
		this.copperChunk_3.SetActive(false);
		this.fullCopper_1.SetActive(false);
		this.fullCopper_2.SetActive(false);
		this.fullCopper_3.SetActive(false);
		this.spawnIron.SetActive(false);
		this.ironChunk_1.SetActive(false);
		this.ironChunk_2.SetActive(false);
		this.fullIron_1.SetActive(false);
		this.fullIron_2.SetActive(false);
		this.cobaltSpawn.SetActive(false);
		this.cobaltChunk_1.SetActive(false);
		this.fullCobalt_1.SetActive(false);
		this.uraniumSpawn.SetActive(false);
		this.uraniumChunk_1.SetActive(false);
		this.fullUranium_1.SetActive(false);
		this.ismiumSpawn.SetActive(false);
		this.ismiumChunk_1.SetActive(false);
		this.fullIsmium_1.SetActive(false);
		this.iridiumSpawn.SetActive(false);
		this.iridiumChunk_1.SetActive(false);
		this.fullIridium_1.SetActive(false);
		this.painiteSpawn.SetActive(false);
		this.painiteChunk_1.SetActive(false);
		this.fullPainite_1.SetActive(false);
		this.improvedPickaxe_1.SetActive(false);
		this.improvedPickaxe_2.SetActive(false);
		this.improvedPickaxe_3.SetActive(false);
		this.improvedPickaxe_4.SetActive(false);
		this.improvedPickaxe_5.SetActive(false);
		this.improvedPickaxe_6.SetActive(false);
		this.biggerMiningErea_1.SetActive(false);
		this.biggerMiningErea_2.SetActive(false);
		this.biggerMiningErea_3.SetActive(false);
		this.biggerMiningErea_4.SetActive(false);
		this.shootCircleChance.SetActive(false);
		this.increaseAndDecreaseMinignErea.SetActive(false);
		this.spawnRockEveryXrock_1.SetActive(false);
		this.spawnRockEveryXrock_2.SetActive(false);
		this.spawnRockEveryXrock_3.SetActive(false);
		this.spawnXRockEveryXSecond_1.SetActive(false);
		this.spawnXRockEveryXSecond_2.SetActive(false);
		this.spawnXRockEveryXSecond_3.SetActive(false);
		this.chanceToSpawnRockWhenMined_1.SetActive(false);
		this.chanceToSpawnRockWhenMined_2.SetActive(false);
		this.chanceToSpawnRockWhenMined_3.SetActive(false);
		this.chanceToSpawnRockWhenMined_4.SetActive(false);
		this.chanceToSpawnRockWhenMined_5.SetActive(false);
		this.chanceToSpawnRockWhenMined_6.SetActive(false);
		this.chanceToMineRandomRock_1.SetActive(false);
		this.chanceToMineRandomRock_2.SetActive(false);
		this.chanceToMineRandomRock_3.SetActive(false);
		this.chanceToMineRandomRock_4.SetActive(false);
		this.spawnPickaxeEverySecond_1.SetActive(false);
		this.spawnPickaxeEverySecond_2.SetActive(false);
		this.spawnPickaxeEverySecond_3.SetActive(false);
		this.moreTime_1.SetActive(false);
		this.moreTime_2.SetActive(false);
		this.moreTime_3.SetActive(false);
		this.moreTime_4.SetActive(false);
		this.chanceToAdd1SecondEverySecond.SetActive(false);
		this.chanceAdd1SecondEveryRockMined.SetActive(false);
		this.doubleXpGoldChance_1.SetActive(false);
		this.doubleXpGoldChance_2.SetActive(false);
		this.doubleXpGoldChance_3.SetActive(false);
		this.doubleXpGoldChance_4.SetActive(false);
		this.doubleXpGoldChance_5.SetActive(false);
		this.allProjectileDoubleDamageChance.SetActive(false);
		this.allProjectileTriggerChance.SetActive(false);
		this.pickaxeDoubleDamageChance_1.SetActive(false);
		this.pickaxeDoubleDamageChance_2.SetActive(false);
		this.intaMineChance_1.SetActive(false);
		this.intaMineChance_2.SetActive(false);
		this.increaseSpawnChanceAllRocks.SetActive(false);
		this.craft2Material.SetActive(false);
		this.finalUpgrade.SetActive(false);
		this.moreXP_1_LOCKED.SetActive(true);
		this.moreXP_2_LOCKED.SetActive(true);
		this.moreXP_3_LOCKED.SetActive(true);
		this.moreXP_4_LOCKED.SetActive(true);
		this.moreXP_5_LOCKED.SetActive(true);
		this.moreXP_6_LOCKED.SetActive(true);
		this.moreXP_7_LOCKED.SetActive(true);
		this.moreXP_8_LOCKED.SetActive(true);
		this.talentPointsPerXlevel_1_LOCKED.SetActive(true);
		this.talentPointsPerXlevel_2_LOCKED.SetActive(true);
		this.talentPointsPerXlevel_3_LOCKED.SetActive(true);
		this.spawnMoreRocks_1_LOCKED.SetActive(true);
		this.spawnMoreRocks_2_LOCKED.SetActive(true);
		this.spawnMoreRocks_3_LOCKED.SetActive(true);
		this.spawnMoreRocks_4_LOCKED.SetActive(true);
		this.spawnMoreRocks_5_LOCKED.SetActive(true);
		this.spawnMoreRocks_6_LOCKED.SetActive(true);
		this.spawnMoreRocks_7_LOCKED.SetActive(true);
		this.spawnMoreRocks_8_LOCKED.SetActive(true);
		this.spawnMoreRocks_9_LOCKED.SetActive(true);
		this.moreMeterialsFromRock_1_LOCKED.SetActive(true);
		this.moreMeterialsFromRock_2_LOCKED.SetActive(true);
		this.moreMeterialsFromRock_3_LOCKED.SetActive(true);
		this.moreMeterialsFromRock_4_LOCKED.SetActive(true);
		this.moreMeterialsFromRock_5_LOCKED.SetActive(true);
		this.marterialsWorthMore_1_LOCKED.SetActive(true);
		this.marterialsWorthMore_2_LOCKED.SetActive(true);
		this.marterialsWorthMore_3_LOCKED.SetActive(true);
		this.marterialsWorthMore_4_LOCKED.SetActive(true);
		this.marterialsWorthMore_5_LOCKED.SetActive(true);
		this.marterialsWorthMore_6_LOCKED.SetActive(true);
		this.marterialsWorthMore_7_LOCKED.SetActive(true);
		this.marterialsWorthMore_8_LOCKED.SetActive(true);
		this.goldChunk_1_LOCKED.SetActive(true);
		this.goldChunk_2_LOCKED.SetActive(true);
		this.goldChunk_3_LOCKED.SetActive(true);
		this.goldChunk_4_LOCKED.SetActive(true);
		this.goldChunk_5_LOCKED.SetActive(true);
		this.fullGold_1_LOCKED.SetActive(true);
		this.fullGold_2_LOCKED.SetActive(true);
		this.fullGold_3_LOCKED.SetActive(true);
		this.spawnCopper_LOCKED.SetActive(true);
		this.copperChunk_1_LOCKED.SetActive(true);
		this.copperChunk_2_LOCKED.SetActive(true);
		this.copperChunk_3_LOCKED.SetActive(true);
		this.fullCopper_1_LOCKED.SetActive(true);
		this.fullCopper_2_LOCKED.SetActive(true);
		this.fullCopper_3_LOCKED.SetActive(true);
		this.spawnIron_LOCKED.SetActive(true);
		this.ironChunk_1_LOCKED.SetActive(true);
		this.ironChunk_2_LOCKED.SetActive(true);
		this.fullIron_1_LOCKED.SetActive(true);
		this.fullIron_2_LOCKED.SetActive(true);
		this.cobaltSpawn_LOCKED.SetActive(true);
		this.cobaltChunk_1_LOCKED.SetActive(true);
		this.fullCobalt_1_LOCKED.SetActive(true);
		this.uraniumSpawn_LOCKED.SetActive(true);
		this.uraniumChunk_1_LOCKED.SetActive(true);
		this.fullUranium_1_LOCKED.SetActive(true);
		this.ismiumSpawn_LOCKED.SetActive(true);
		this.ismiumChunk_1_LOCKED.SetActive(true);
		this.fullIsmium_1_LOCKED.SetActive(true);
		this.iridiumSpawn_LOCKED.SetActive(true);
		this.iridiumChunk_1_LOCKED.SetActive(true);
		this.fullIridium_1_LOCKED.SetActive(true);
		this.painiteSpawn_LOCKED.SetActive(true);
		this.painiteChunk_1_LOCKED.SetActive(true);
		this.fullPainite_1_LOCKED.SetActive(true);
		this.improvedPickaxe_1_LOCKED.SetActive(true);
		this.improvedPickaxe_2_LOCKED.SetActive(true);
		this.improvedPickaxe_3_LOCKED.SetActive(true);
		this.improvedPickaxe_4_LOCKED.SetActive(true);
		this.improvedPickaxe_5_LOCKED.SetActive(true);
		this.improvedPickaxe_6_LOCKED.SetActive(true);
		this.biggerMiningErea_1_LOCKED.SetActive(true);
		this.biggerMiningErea_2_LOCKED.SetActive(true);
		this.biggerMiningErea_3_LOCKED.SetActive(true);
		this.biggerMiningErea_4_LOCKED.SetActive(true);
		this.shootCircleChance_LOCKED.SetActive(true);
		this.increaseAndDecreaseMinignErea_LOCKED.SetActive(true);
		this.spawnRockEveryXrock_1_LOCKED.SetActive(true);
		this.spawnRockEveryXrock_2_LOCKED.SetActive(true);
		this.spawnRockEveryXrock_3_LOCKED.SetActive(true);
		this.spawnXRockEveryXSecond_1_LOCKED.SetActive(true);
		this.spawnXRockEveryXSecond_2_LOCKED.SetActive(true);
		this.spawnXRockEveryXSecond_3_LOCKED.SetActive(true);
		this.chanceToSpawnRockWhenMined_1_LOCKED.SetActive(true);
		this.chanceToSpawnRockWhenMined_2_LOCKED.SetActive(true);
		this.chanceToSpawnRockWhenMined_3_LOCKED.SetActive(true);
		this.chanceToSpawnRockWhenMined_4_LOCKED.SetActive(true);
		this.chanceToSpawnRockWhenMined_5_LOCKED.SetActive(true);
		this.chanceToSpawnRockWhenMined_6_LOCKED.SetActive(true);
		this.chanceToMineRandomRock_1_LOCKED.SetActive(true);
		this.chanceToMineRandomRock_2_LOCKED.SetActive(true);
		this.chanceToMineRandomRock_3_LOCKED.SetActive(true);
		this.chanceToMineRandomRock_4_LOCKED.SetActive(true);
		this.spawnPickaxeEverySecond_1_LOCKED.SetActive(true);
		this.spawnPickaxeEverySecond_2_LOCKED.SetActive(true);
		this.spawnPickaxeEverySecond_3_LOCKED.SetActive(true);
		this.moreTime_1_LOCKED.SetActive(true);
		this.moreTime_2_LOCKED.SetActive(true);
		this.moreTime_3_LOCKED.SetActive(true);
		this.moreTime_4_LOCKED.SetActive(true);
		this.chanceToAdd1SecondEverySecond_LOCKED.SetActive(true);
		this.chanceAdd1SecondEveryRockMined_LOCKED.SetActive(true);
		this.doubleXpGoldChance_1_LOCKED.SetActive(true);
		this.doubleXpGoldChance_2_LOCKED.SetActive(true);
		this.doubleXpGoldChance_3_LOCKED.SetActive(true);
		this.doubleXpGoldChance_4_LOCKED.SetActive(true);
		this.doubleXpGoldChance_5_LOCKED.SetActive(true);
		this.lightningBeamChanceS_1_LOCKED.SetActive(true);
		this.lightningBeamChanceS_2_LOCKED.SetActive(true);
		this.lightningBeamChancePH_1_LOCKED.SetActive(true);
		this.lightningBeamChancePH_2_LOCKED.SetActive(true);
		this.lightningBeamSpawnAnotherOneChance_LOCKED.SetActive(true);
		this.lightningBeamDamage_LOCKED.SetActive(true);
		this.lightningBeamSize_LOCKED.SetActive(true);
		this.lightningSplashes_LOCKED.SetActive(true);
		this.lightningBeamSpawnRock_LOCKED.SetActive(true);
		this.lightningBeamExplosion_LOCKED.SetActive(true);
		this.lightningBeamAddTime_LOCKED.SetActive(true);
		this.dynamiteChance_1_LOCKED.SetActive(true);
		this.dynamiteChance_2_LOCKED.SetActive(true);
		this.dynamiteSpawn2SmallChance_LOCKED.SetActive(true);
		this.dynamiteExplosionSize_LOCKED.SetActive(true);
		this.dynamiteDamage_LOCKED.SetActive(true);
		this.dynamiteExplosionSpawnRock_LOCKED.SetActive(true);
		this.dynamiteExplosionAddTimeChance_LOCKED.SetActive(true);
		this.dynamiteExplosionSpawnLightning_LOCKED.SetActive(true);
		this.plazmaBallSpawn_1_LOCKED.SetActive(true);
		this.plazmaBallSpawn_2_LOCKED.SetActive(true);
		this.plazmaBallTime_LOCKED.SetActive(true);
		this.plazmaBallSize_LOCKED.SetActive(true);
		this.plazmaBallExplosionChance_LOCKED.SetActive(true);
		this.plazmaBallSpawnSmallChance_LOCKED.SetActive(true);
		this.plazmaBallDamage_LOCKED.SetActive(true);
		this.plazmaBallSpawnPickaxeChance_LOCKED.SetActive(true);
		this.allProjectileDoubleDamageChance_LOCKED.SetActive(true);
		this.allProjectileTriggerChance_LOCKED.SetActive(true);
		this.pickaxeDoubleDamageChance_1_LOCKED.SetActive(true);
		this.pickaxeDoubleDamageChance_2_LOCKED.SetActive(true);
		this.intaMineChance_1_LOCKED.SetActive(true);
		this.intaMineChance_2_LOCKED.SetActive(true);
		this.increaseSpawnChanceAllRocks_LOCKED.SetActive(true);
		this.craft2Material_LOCKED.SetActive(true);
		this.finalUpgrade_LOCKED.SetActive(true);
		this.spawnMoreRocks_1.GetComponent<Button>().enabled = true;
		this.spawnMoreRocks_2.GetComponent<Button>().enabled = true;
		this.spawnMoreRocks_3.GetComponent<Button>().enabled = true;
		this.spawnMoreRocks_4.GetComponent<Button>().enabled = true;
		this.spawnMoreRocks_5.GetComponent<Button>().enabled = true;
		this.spawnMoreRocks_6.GetComponent<Button>().enabled = true;
		this.spawnMoreRocks_7.GetComponent<Button>().enabled = true;
		this.spawnMoreRocks_8.GetComponent<Button>().enabled = true;
		this.spawnMoreRocks_9.GetComponent<Button>().enabled = true;
		this.moreMeterialsFromRock_1.GetComponent<Button>().enabled = true;
		this.moreMeterialsFromRock_2.GetComponent<Button>().enabled = true;
		this.moreMeterialsFromRock_3.GetComponent<Button>().enabled = true;
		this.moreMeterialsFromRock_4.GetComponent<Button>().enabled = true;
		this.moreMeterialsFromRock_5.GetComponent<Button>().enabled = true;
		this.marterialsWorthMore_1.GetComponent<Button>().enabled = true;
		this.marterialsWorthMore_2.GetComponent<Button>().enabled = true;
		this.marterialsWorthMore_3.GetComponent<Button>().enabled = true;
		this.marterialsWorthMore_4.GetComponent<Button>().enabled = true;
		this.marterialsWorthMore_5.GetComponent<Button>().enabled = true;
		this.marterialsWorthMore_6.GetComponent<Button>().enabled = true;
		this.marterialsWorthMore_7.GetComponent<Button>().enabled = true;
		this.marterialsWorthMore_8.GetComponent<Button>().enabled = true;
		this.goldChunk_1.GetComponent<Button>().enabled = true;
		this.goldChunk_2.GetComponent<Button>().enabled = true;
		this.goldChunk_3.GetComponent<Button>().enabled = true;
		this.goldChunk_4.GetComponent<Button>().enabled = true;
		this.goldChunk_5_.GetComponent<Button>().enabled = true;
		this.fullGold_1.GetComponent<Button>().enabled = true;
		this.fullGold_2.GetComponent<Button>().enabled = true;
		this.fullGold_3.GetComponent<Button>().enabled = true;
		this.spawnCopper.GetComponent<Button>().enabled = true;
		this.copperChunk_1.GetComponent<Button>().enabled = true;
		this.copperChunk_2.GetComponent<Button>().enabled = true;
		this.copperChunk_3.GetComponent<Button>().enabled = true;
		this.fullCopper_1.GetComponent<Button>().enabled = true;
		this.fullCopper_2.GetComponent<Button>().enabled = true;
		this.fullCopper_3.GetComponent<Button>().enabled = true;
		this.spawnIron.GetComponent<Button>().enabled = true;
		this.ironChunk_1.GetComponent<Button>().enabled = true;
		this.ironChunk_2.GetComponent<Button>().enabled = true;
		this.fullIron_1.GetComponent<Button>().enabled = true;
		this.fullIron_2.GetComponent<Button>().enabled = true;
		this.cobaltSpawn.GetComponent<Button>().enabled = true;
		this.cobaltChunk_1.GetComponent<Button>().enabled = true;
		this.fullCobalt_1.GetComponent<Button>().enabled = true;
		this.uraniumSpawn.GetComponent<Button>().enabled = true;
		this.uraniumChunk_1.GetComponent<Button>().enabled = true;
		this.fullUranium_1.GetComponent<Button>().enabled = true;
		this.ismiumSpawn.GetComponent<Button>().enabled = true;
		this.ismiumChunk_1.GetComponent<Button>().enabled = true;
		this.fullIsmium_1.GetComponent<Button>().enabled = true;
		this.iridiumSpawn.GetComponent<Button>().enabled = true;
		this.iridiumChunk_1.GetComponent<Button>().enabled = true;
		this.fullIridium_1.GetComponent<Button>().enabled = true;
		this.painiteSpawn.GetComponent<Button>().enabled = true;
		this.painiteChunk_1.GetComponent<Button>().enabled = true;
		this.fullPainite_1.GetComponent<Button>().enabled = true;
		this.moreXP_1.GetComponent<Button>().enabled = true;
		this.moreXP_2.GetComponent<Button>().enabled = true;
		this.moreXP_3.GetComponent<Button>().enabled = true;
		this.moreXP_4.GetComponent<Button>().enabled = true;
		this.moreXP_5.GetComponent<Button>().enabled = true;
		this.moreXP_6.GetComponent<Button>().enabled = true;
		this.moreXP_7.GetComponent<Button>().enabled = true;
		this.moreXP_8.GetComponent<Button>().enabled = true;
		this.talentPointsPerXlevel_1.GetComponent<Button>().enabled = true;
		this.talentPointsPerXlevel_2.GetComponent<Button>().enabled = true;
		this.talentPointsPerXlevel_3.GetComponent<Button>().enabled = true;
		this.lightningBeamChanceS_1.GetComponent<Button>().enabled = true;
		this.lightningBeamChanceS_2.GetComponent<Button>().enabled = true;
		this.lightningBeamChancePH_1.GetComponent<Button>().enabled = true;
		this.lightningBeamChancePH_2.GetComponent<Button>().enabled = true;
		this.lightningBeamSpawnAnotherOneChance.GetComponent<Button>().enabled = true;
		this.lightningBeamDamage.GetComponent<Button>().enabled = true;
		this.lightningBeamSize.GetComponent<Button>().enabled = true;
		this.lightningSplashes.GetComponent<Button>().enabled = true;
		this.lightningBeamSpawnRock.GetComponent<Button>().enabled = true;
		this.lightningBeamExplosion.GetComponent<Button>().enabled = true;
		this.lightningBeamAddTime.GetComponent<Button>().enabled = true;
		this.dynamiteChance_1.GetComponent<Button>().enabled = true;
		this.dynamiteChance_2.GetComponent<Button>().enabled = true;
		this.dynamiteSpawn2SmallChance.GetComponent<Button>().enabled = true;
		this.dynamiteExplosionSize.GetComponent<Button>().enabled = true;
		this.dynamiteDamage.GetComponent<Button>().enabled = true;
		this.dynamiteExplosionSpawnRock.GetComponent<Button>().enabled = true;
		this.dynamiteExplosionAddTimeChance.GetComponent<Button>().enabled = true;
		this.dynamiteExplosionSpawnLightning.GetComponent<Button>().enabled = true;
		this.plazmaBallSpawn_1.GetComponent<Button>().enabled = true;
		this.plazmaBallSpawn_2.GetComponent<Button>().enabled = true;
		this.plazmaBallTime.GetComponent<Button>().enabled = true;
		this.plazmaBallSize.GetComponent<Button>().enabled = true;
		this.plazmaBallExplosionChance.GetComponent<Button>().enabled = true;
		this.plazmaBallSpawnSmallChance.GetComponent<Button>().enabled = true;
		this.plazmaBallDamage.GetComponent<Button>().enabled = true;
		this.plazmaBallSpawnPickaxeChance.GetComponent<Button>().enabled = true;
		this.improvedPickaxe_1.GetComponent<Button>().enabled = true;
		this.improvedPickaxe_2.GetComponent<Button>().enabled = true;
		this.improvedPickaxe_3.GetComponent<Button>().enabled = true;
		this.improvedPickaxe_4.GetComponent<Button>().enabled = true;
		this.improvedPickaxe_5.GetComponent<Button>().enabled = true;
		this.improvedPickaxe_6.GetComponent<Button>().enabled = true;
		this.biggerMiningErea_1.GetComponent<Button>().enabled = true;
		this.biggerMiningErea_2.GetComponent<Button>().enabled = true;
		this.biggerMiningErea_3.GetComponent<Button>().enabled = true;
		this.biggerMiningErea_4.GetComponent<Button>().enabled = true;
		this.shootCircleChance.GetComponent<Button>().enabled = true;
		this.increaseAndDecreaseMinignErea.GetComponent<Button>().enabled = true;
		this.spawnRockEveryXrock_1.GetComponent<Button>().enabled = true;
		this.spawnRockEveryXrock_2.GetComponent<Button>().enabled = true;
		this.spawnRockEveryXrock_3.GetComponent<Button>().enabled = true;
		this.spawnXRockEveryXSecond_1.GetComponent<Button>().enabled = true;
		this.spawnXRockEveryXSecond_2.GetComponent<Button>().enabled = true;
		this.spawnXRockEveryXSecond_3.GetComponent<Button>().enabled = true;
		this.chanceToSpawnRockWhenMined_1.GetComponent<Button>().enabled = true;
		this.chanceToSpawnRockWhenMined_2.GetComponent<Button>().enabled = true;
		this.chanceToSpawnRockWhenMined_3.GetComponent<Button>().enabled = true;
		this.chanceToSpawnRockWhenMined_4.GetComponent<Button>().enabled = true;
		this.chanceToSpawnRockWhenMined_5.GetComponent<Button>().enabled = true;
		this.chanceToSpawnRockWhenMined_6.GetComponent<Button>().enabled = true;
		this.chanceToMineRandomRock_1.GetComponent<Button>().enabled = true;
		this.chanceToMineRandomRock_2.GetComponent<Button>().enabled = true;
		this.chanceToMineRandomRock_3.GetComponent<Button>().enabled = true;
		this.chanceToMineRandomRock_4.GetComponent<Button>().enabled = true;
		this.spawnPickaxeEverySecond_1.GetComponent<Button>().enabled = true;
		this.spawnPickaxeEverySecond_2.GetComponent<Button>().enabled = true;
		this.spawnPickaxeEverySecond_3.GetComponent<Button>().enabled = true;
		this.moreTime_1.GetComponent<Button>().enabled = true;
		this.moreTime_2.GetComponent<Button>().enabled = true;
		this.moreTime_3.GetComponent<Button>().enabled = true;
		this.moreTime_4.GetComponent<Button>().enabled = true;
		this.chanceToAdd1SecondEverySecond.GetComponent<Button>().enabled = true;
		this.chanceAdd1SecondEveryRockMined.GetComponent<Button>().enabled = true;
		this.doubleXpGoldChance_1.GetComponent<Button>().enabled = true;
		this.doubleXpGoldChance_2.GetComponent<Button>().enabled = true;
		this.doubleXpGoldChance_3.GetComponent<Button>().enabled = true;
		this.doubleXpGoldChance_4.GetComponent<Button>().enabled = true;
		this.doubleXpGoldChance_5.GetComponent<Button>().enabled = true;
		this.allProjectileDoubleDamageChance.GetComponent<Button>().enabled = true;
		this.allProjectileTriggerChance.GetComponent<Button>().enabled = true;
		this.pickaxeDoubleDamageChance_1.GetComponent<Button>().enabled = true;
		this.pickaxeDoubleDamageChance_2.GetComponent<Button>().enabled = true;
		this.intaMineChance_1.GetComponent<Button>().enabled = true;
		this.intaMineChance_2.GetComponent<Button>().enabled = true;
		this.increaseSpawnChanceAllRocks.GetComponent<Button>().enabled = true;
		this.craft2Material.GetComponent<Button>().enabled = true;
		this.finalUpgrade.GetComponent<Button>().enabled = true;
		SkillTree.totalMaterialRocksSpawning = 1;
		SkillTree.totalSkillTreeUpgradesPurchased = 0;
		SkillTree.totalUpgradesFullyPurchased = 0;
		SkillTree.mineSessionTime = 15;
		SkillTree.totalRocksToSpawn = 25;
		SkillTree.extraTalentPointPerLevel = 7;
		SkillTree.goldRockChance = 11f;
		SkillTree.fullGoldRockChance = 4.2f;
		SkillTree.copperRockChance = 3.1f;
		SkillTree.fullCopperRockChance = 2.2f;
		SkillTree.ironRockChance = 2.4f;
		SkillTree.fullIronRockChance = 1.7f;
		SkillTree.cobaltRockChance = 1.5f;
		SkillTree.fullCobaltRockChance = 1.3f;
		SkillTree.uraniumRockChance = 1.1f;
		SkillTree.fullUraniumRockChance = 1f;
		SkillTree.ismiumRockChance = 0.9f;
		SkillTree.fullIsmiumRockChance = 0.8f;
		SkillTree.iridiumRockChance = 0.7f;
		SkillTree.fullIridiumRockChance = 0.6f;
		SkillTree.painiteRockChance = 0.5f;
		SkillTree.fullPainiteRockChance = 0.4f;
		SkillTree.improvedPickaxeStrength = 1f;
		SkillTree.reducePickaxeMineTime = 0f;
		SkillTree.miningAreaSize = 1f;
		SkillTree.spawnRockEveryXRock = 6f;
		SkillTree.spawnXRockEveryXSecond = 2f;
		SkillTree.chanceToSpawnRockWhenMined = 0f;
		SkillTree.materialsFromChunkRocks = 3;
		SkillTree.materialsFromFullRocks = 7;
		SkillTree.materialsTotalWorth = 1f;
		SkillTree.chanceToMineRandomRock = 0f;
		SkillTree.spawnPickaxeEverySecond = 1.2f;
		SkillTree.doubleXpAndGoldChance = 0f;
		SkillTree.lightningTriggerChanceS = 0f;
		SkillTree.lightningTriggerChancePH = 0f;
		SkillTree.lightningDamage = 0f;
		SkillTree.lightningSize = 1f;
		SkillTree.dynamiteStickChance = 0f;
		SkillTree.explosionSize = 1f;
		SkillTree.explosionDamagage = 0f;
		SkillTree.plazmaBallChance = 0f;
		SkillTree.plazmaBallTimer = 5f;
		SkillTree.plazmaBallTotalSize = 1f;
		SkillTree.plazmaBallTotalDamage = 1f;
		SkillTree.doubleDamageChance = 0f;
		SkillTree.instaMineChance = 0f;
		this.fallingCopper_skillTree.SetActive(false);
		this.fallingCopper_MainMenu.SetActive(false);
		this.fallingIron_skillTree.SetActive(false);
		this.fallingIron_MainMenu.SetActive(false);
		this.fallingCobalt_skillTree.SetActive(false);
		this.fallingCobalt_MainMenu.SetActive(false);
		this.fallingUranium_skillTree.SetActive(false);
		this.fallingUranium_MainMenu.SetActive(false);
		this.fallingIsmium_skillTree.SetActive(false);
		this.fallingIsmium_MainMenu.SetActive(false);
		this.fallingIridium_skillTree.SetActive(false);
		this.fallingIridium_MainMenu.SetActive(false);
		this.fallingPainite_skillTree.SetActive(false);
		this.fallingPainite_MainMenu.SetActive(false);
		this.endingButton.SetActive(false);
		this.copperBarFrame.SetActive(false);
		this.ironBarFrame.SetActive(false);
		this.cobaltBarFrame.SetActive(false);
		this.uraniumiumBarFrame.SetActive(false);
		this.ismiumBarFrame.SetActive(false);
		this.iridiumBarFRame.SetActive(false);
		this.painiteBarFrame.SetActive(false);
		this.endlessUpgradesParent.SetActive(false);
		this.endlessUpgradesPopUp.SetActive(false);
		SkillTree.hasPressedEndlessOK = false;
		SkillTree.endlessGold_price = 6500000.0;
		SkillTree.endlessCopper_price = 3500000.0;
		SkillTree.endlessIron_price = 2500000.0;
		SkillTree.endlessCobalt_price = 1700000.0;
		SkillTree.endlessUranium_price = 1200000.0;
		SkillTree.endlessIsmium_price = 700000.0;
		SkillTree.endlessIridium_price = 500000.0;
		SkillTree.endlessPainite_price = 300000.0;
		SkillTree.endlessGold_purchaseCount = 0;
		SkillTree.endlessCopper_purchaseCount = 0;
		SkillTree.endlessIron_purchaseCount = 0;
		SkillTree.endlessCobalt_purchaseCount = 0;
		SkillTree.endlessUranium_purchaseCount = 0;
		SkillTree.endlessIsmium_purchaseCount = 0;
		SkillTree.endlessIridium_purchaseCount = 0;
		SkillTree.endlessPainite_purchaseCount = 0;
	}

	// Token: 0x040009F6 RID: 2550
	public TheAnvil theAnvilScript;

	// Token: 0x040009F7 RID: 2551
	public TheMine theMineScript;

	// Token: 0x040009F8 RID: 2552
	public GoldAndOreMechanics goldAndOreScript;

	// Token: 0x040009F9 RID: 2553
	public Tutorial tutorialScript;

	// Token: 0x040009FA RID: 2554
	public Achievements achScript;

	// Token: 0x040009FB RID: 2555
	public GameObject copperBarFrame;

	// Token: 0x040009FC RID: 2556
	public GameObject ironBarFrame;

	// Token: 0x040009FD RID: 2557
	public GameObject cobaltBarFrame;

	// Token: 0x040009FE RID: 2558
	public GameObject uraniumiumBarFrame;

	// Token: 0x040009FF RID: 2559
	public GameObject ismiumBarFrame;

	// Token: 0x04000A00 RID: 2560
	public GameObject iridiumBarFRame;

	// Token: 0x04000A01 RID: 2561
	public GameObject painiteBarFrame;

	// Token: 0x04000A02 RID: 2562
	public GameObject[] lines;

	// Token: 0x04000A03 RID: 2563
	public GameObject finaLine;

	// Token: 0x04000A04 RID: 2564
	public static int rocksMinedBeforeSpawn;

	// Token: 0x04000A05 RID: 2565
	public AudioManager audioManager;

	// Token: 0x04000A06 RID: 2566
	public GameObject endingButton;

	// Token: 0x04000A07 RID: 2567
	public GameObject fallingCopper_skillTree;

	// Token: 0x04000A08 RID: 2568
	public GameObject fallingCopper_MainMenu;

	// Token: 0x04000A09 RID: 2569
	public GameObject fallingIron_skillTree;

	// Token: 0x04000A0A RID: 2570
	public GameObject fallingIron_MainMenu;

	// Token: 0x04000A0B RID: 2571
	public GameObject fallingCobalt_skillTree;

	// Token: 0x04000A0C RID: 2572
	public GameObject fallingCobalt_MainMenu;

	// Token: 0x04000A0D RID: 2573
	public GameObject fallingUranium_skillTree;

	// Token: 0x04000A0E RID: 2574
	public GameObject fallingUranium_MainMenu;

	// Token: 0x04000A0F RID: 2575
	public GameObject fallingIsmium_skillTree;

	// Token: 0x04000A10 RID: 2576
	public GameObject fallingIsmium_MainMenu;

	// Token: 0x04000A11 RID: 2577
	public GameObject fallingIridium_skillTree;

	// Token: 0x04000A12 RID: 2578
	public GameObject fallingIridium_MainMenu;

	// Token: 0x04000A13 RID: 2579
	public GameObject fallingPainite_skillTree;

	// Token: 0x04000A14 RID: 2580
	public GameObject fallingPainite_MainMenu;

	// Token: 0x04000A15 RID: 2581
	public GameObject particleSkillTree;

	// Token: 0x04000A16 RID: 2582
	public GameObject endlessUpgradesParent;

	// Token: 0x04000A17 RID: 2583
	public GameObject endlessUpgradesPopUp;

	// Token: 0x04000A18 RID: 2584
	public static bool hasPressedEndlessOK;

	// Token: 0x04000A19 RID: 2585
	public GameObject moreXP_1;

	// Token: 0x04000A1A RID: 2586
	public GameObject moreXP_2;

	// Token: 0x04000A1B RID: 2587
	public GameObject moreXP_3;

	// Token: 0x04000A1C RID: 2588
	public GameObject moreXP_4;

	// Token: 0x04000A1D RID: 2589
	public GameObject moreXP_5;

	// Token: 0x04000A1E RID: 2590
	public GameObject moreXP_6;

	// Token: 0x04000A1F RID: 2591
	public GameObject moreXP_7;

	// Token: 0x04000A20 RID: 2592
	public GameObject moreXP_8;

	// Token: 0x04000A21 RID: 2593
	public GameObject talentPointsPerXlevel_1;

	// Token: 0x04000A22 RID: 2594
	public GameObject talentPointsPerXlevel_2;

	// Token: 0x04000A23 RID: 2595
	public GameObject talentPointsPerXlevel_3;

	// Token: 0x04000A24 RID: 2596
	public GameObject lightningBeamChanceS_1;

	// Token: 0x04000A25 RID: 2597
	public GameObject lightningBeamChanceS_2;

	// Token: 0x04000A26 RID: 2598
	public GameObject lightningBeamChancePH_1;

	// Token: 0x04000A27 RID: 2599
	public GameObject lightningBeamChancePH_2;

	// Token: 0x04000A28 RID: 2600
	public GameObject lightningBeamSpawnAnotherOneChance;

	// Token: 0x04000A29 RID: 2601
	public GameObject lightningBeamDamage;

	// Token: 0x04000A2A RID: 2602
	public GameObject lightningBeamSize;

	// Token: 0x04000A2B RID: 2603
	public GameObject lightningSplashes;

	// Token: 0x04000A2C RID: 2604
	public GameObject lightningBeamSpawnRock;

	// Token: 0x04000A2D RID: 2605
	public GameObject lightningBeamExplosion;

	// Token: 0x04000A2E RID: 2606
	public GameObject lightningBeamAddTime;

	// Token: 0x04000A2F RID: 2607
	public GameObject dynamiteChance_1;

	// Token: 0x04000A30 RID: 2608
	public GameObject dynamiteChance_2;

	// Token: 0x04000A31 RID: 2609
	public GameObject dynamiteSpawn2SmallChance;

	// Token: 0x04000A32 RID: 2610
	public GameObject dynamiteExplosionSize;

	// Token: 0x04000A33 RID: 2611
	public GameObject dynamiteDamage;

	// Token: 0x04000A34 RID: 2612
	public GameObject dynamiteExplosionSpawnRock;

	// Token: 0x04000A35 RID: 2613
	public GameObject dynamiteExplosionAddTimeChance;

	// Token: 0x04000A36 RID: 2614
	public GameObject dynamiteExplosionSpawnLightning;

	// Token: 0x04000A37 RID: 2615
	public GameObject plazmaBallSpawn_1;

	// Token: 0x04000A38 RID: 2616
	public GameObject plazmaBallSpawn_2;

	// Token: 0x04000A39 RID: 2617
	public GameObject plazmaBallTime;

	// Token: 0x04000A3A RID: 2618
	public GameObject plazmaBallSize;

	// Token: 0x04000A3B RID: 2619
	public GameObject plazmaBallExplosionChance;

	// Token: 0x04000A3C RID: 2620
	public GameObject plazmaBallSpawnSmallChance;

	// Token: 0x04000A3D RID: 2621
	public GameObject plazmaBallDamage;

	// Token: 0x04000A3E RID: 2622
	public GameObject plazmaBallSpawnPickaxeChance;

	// Token: 0x04000A3F RID: 2623
	public GameObject spawnMoreRocks_1;

	// Token: 0x04000A40 RID: 2624
	public GameObject spawnMoreRocks_2;

	// Token: 0x04000A41 RID: 2625
	public GameObject spawnMoreRocks_3;

	// Token: 0x04000A42 RID: 2626
	public GameObject spawnMoreRocks_4;

	// Token: 0x04000A43 RID: 2627
	public GameObject spawnMoreRocks_5;

	// Token: 0x04000A44 RID: 2628
	public GameObject spawnMoreRocks_6;

	// Token: 0x04000A45 RID: 2629
	public GameObject spawnMoreRocks_7;

	// Token: 0x04000A46 RID: 2630
	public GameObject spawnMoreRocks_8;

	// Token: 0x04000A47 RID: 2631
	public GameObject spawnMoreRocks_9;

	// Token: 0x04000A48 RID: 2632
	public GameObject moreMeterialsFromRock_1;

	// Token: 0x04000A49 RID: 2633
	public GameObject moreMeterialsFromRock_2;

	// Token: 0x04000A4A RID: 2634
	public GameObject moreMeterialsFromRock_3;

	// Token: 0x04000A4B RID: 2635
	public GameObject moreMeterialsFromRock_4;

	// Token: 0x04000A4C RID: 2636
	public GameObject moreMeterialsFromRock_5;

	// Token: 0x04000A4D RID: 2637
	public GameObject marterialsWorthMore_1;

	// Token: 0x04000A4E RID: 2638
	public GameObject marterialsWorthMore_2;

	// Token: 0x04000A4F RID: 2639
	public GameObject marterialsWorthMore_3;

	// Token: 0x04000A50 RID: 2640
	public GameObject marterialsWorthMore_4;

	// Token: 0x04000A51 RID: 2641
	public GameObject marterialsWorthMore_5;

	// Token: 0x04000A52 RID: 2642
	public GameObject marterialsWorthMore_6;

	// Token: 0x04000A53 RID: 2643
	public GameObject marterialsWorthMore_7;

	// Token: 0x04000A54 RID: 2644
	public GameObject marterialsWorthMore_8;

	// Token: 0x04000A55 RID: 2645
	public GameObject goldChunk_1;

	// Token: 0x04000A56 RID: 2646
	public GameObject goldChunk_2;

	// Token: 0x04000A57 RID: 2647
	public GameObject goldChunk_3;

	// Token: 0x04000A58 RID: 2648
	public GameObject goldChunk_4;

	// Token: 0x04000A59 RID: 2649
	public GameObject goldChunk_5_;

	// Token: 0x04000A5A RID: 2650
	public GameObject fullGold_1;

	// Token: 0x04000A5B RID: 2651
	public GameObject fullGold_2;

	// Token: 0x04000A5C RID: 2652
	public GameObject fullGold_3;

	// Token: 0x04000A5D RID: 2653
	public GameObject spawnCopper;

	// Token: 0x04000A5E RID: 2654
	public GameObject copperChunk_1;

	// Token: 0x04000A5F RID: 2655
	public GameObject copperChunk_2;

	// Token: 0x04000A60 RID: 2656
	public GameObject copperChunk_3;

	// Token: 0x04000A61 RID: 2657
	public GameObject fullCopper_1;

	// Token: 0x04000A62 RID: 2658
	public GameObject fullCopper_2;

	// Token: 0x04000A63 RID: 2659
	public GameObject fullCopper_3;

	// Token: 0x04000A64 RID: 2660
	public GameObject spawnIron;

	// Token: 0x04000A65 RID: 2661
	public GameObject ironChunk_1;

	// Token: 0x04000A66 RID: 2662
	public GameObject ironChunk_2;

	// Token: 0x04000A67 RID: 2663
	public GameObject fullIron_1;

	// Token: 0x04000A68 RID: 2664
	public GameObject fullIron_2;

	// Token: 0x04000A69 RID: 2665
	public GameObject cobaltSpawn;

	// Token: 0x04000A6A RID: 2666
	public GameObject cobaltChunk_1;

	// Token: 0x04000A6B RID: 2667
	public GameObject fullCobalt_1;

	// Token: 0x04000A6C RID: 2668
	public GameObject uraniumSpawn;

	// Token: 0x04000A6D RID: 2669
	public GameObject uraniumChunk_1;

	// Token: 0x04000A6E RID: 2670
	public GameObject fullUranium_1;

	// Token: 0x04000A6F RID: 2671
	public GameObject ismiumSpawn;

	// Token: 0x04000A70 RID: 2672
	public GameObject ismiumChunk_1;

	// Token: 0x04000A71 RID: 2673
	public GameObject fullIsmium_1;

	// Token: 0x04000A72 RID: 2674
	public GameObject iridiumSpawn;

	// Token: 0x04000A73 RID: 2675
	public GameObject iridiumChunk_1;

	// Token: 0x04000A74 RID: 2676
	public GameObject fullIridium_1;

	// Token: 0x04000A75 RID: 2677
	public GameObject painiteSpawn;

	// Token: 0x04000A76 RID: 2678
	public GameObject painiteChunk_1;

	// Token: 0x04000A77 RID: 2679
	public GameObject fullPainite_1;

	// Token: 0x04000A78 RID: 2680
	public GameObject improvedPickaxe_1;

	// Token: 0x04000A79 RID: 2681
	public GameObject improvedPickaxe_2;

	// Token: 0x04000A7A RID: 2682
	public GameObject improvedPickaxe_3;

	// Token: 0x04000A7B RID: 2683
	public GameObject improvedPickaxe_4;

	// Token: 0x04000A7C RID: 2684
	public GameObject improvedPickaxe_5;

	// Token: 0x04000A7D RID: 2685
	public GameObject improvedPickaxe_6;

	// Token: 0x04000A7E RID: 2686
	public GameObject biggerMiningErea_1;

	// Token: 0x04000A7F RID: 2687
	public GameObject biggerMiningErea_2;

	// Token: 0x04000A80 RID: 2688
	public GameObject biggerMiningErea_3;

	// Token: 0x04000A81 RID: 2689
	public GameObject biggerMiningErea_4;

	// Token: 0x04000A82 RID: 2690
	public GameObject shootCircleChance;

	// Token: 0x04000A83 RID: 2691
	public GameObject increaseAndDecreaseMinignErea;

	// Token: 0x04000A84 RID: 2692
	public GameObject spawnRockEveryXrock_1;

	// Token: 0x04000A85 RID: 2693
	public GameObject spawnRockEveryXrock_2;

	// Token: 0x04000A86 RID: 2694
	public GameObject spawnRockEveryXrock_3;

	// Token: 0x04000A87 RID: 2695
	public GameObject spawnXRockEveryXSecond_1;

	// Token: 0x04000A88 RID: 2696
	public GameObject spawnXRockEveryXSecond_2;

	// Token: 0x04000A89 RID: 2697
	public GameObject spawnXRockEveryXSecond_3;

	// Token: 0x04000A8A RID: 2698
	public GameObject chanceToSpawnRockWhenMined_1;

	// Token: 0x04000A8B RID: 2699
	public GameObject chanceToSpawnRockWhenMined_2;

	// Token: 0x04000A8C RID: 2700
	public GameObject chanceToSpawnRockWhenMined_3;

	// Token: 0x04000A8D RID: 2701
	public GameObject chanceToSpawnRockWhenMined_4;

	// Token: 0x04000A8E RID: 2702
	public GameObject chanceToSpawnRockWhenMined_5;

	// Token: 0x04000A8F RID: 2703
	public GameObject chanceToSpawnRockWhenMined_6;

	// Token: 0x04000A90 RID: 2704
	public GameObject chanceToMineRandomRock_1;

	// Token: 0x04000A91 RID: 2705
	public GameObject chanceToMineRandomRock_2;

	// Token: 0x04000A92 RID: 2706
	public GameObject chanceToMineRandomRock_3;

	// Token: 0x04000A93 RID: 2707
	public GameObject chanceToMineRandomRock_4;

	// Token: 0x04000A94 RID: 2708
	public GameObject spawnPickaxeEverySecond_1;

	// Token: 0x04000A95 RID: 2709
	public GameObject spawnPickaxeEverySecond_2;

	// Token: 0x04000A96 RID: 2710
	public GameObject spawnPickaxeEverySecond_3;

	// Token: 0x04000A97 RID: 2711
	public GameObject moreTime_1;

	// Token: 0x04000A98 RID: 2712
	public GameObject moreTime_2;

	// Token: 0x04000A99 RID: 2713
	public GameObject moreTime_3;

	// Token: 0x04000A9A RID: 2714
	public GameObject moreTime_4;

	// Token: 0x04000A9B RID: 2715
	public GameObject chanceToAdd1SecondEverySecond;

	// Token: 0x04000A9C RID: 2716
	public GameObject chanceAdd1SecondEveryRockMined;

	// Token: 0x04000A9D RID: 2717
	public GameObject doubleXpGoldChance_1;

	// Token: 0x04000A9E RID: 2718
	public GameObject doubleXpGoldChance_2;

	// Token: 0x04000A9F RID: 2719
	public GameObject doubleXpGoldChance_3;

	// Token: 0x04000AA0 RID: 2720
	public GameObject doubleXpGoldChance_4;

	// Token: 0x04000AA1 RID: 2721
	public GameObject doubleXpGoldChance_5;

	// Token: 0x04000AA2 RID: 2722
	public GameObject allProjectileDoubleDamageChance;

	// Token: 0x04000AA3 RID: 2723
	public GameObject allProjectileTriggerChance;

	// Token: 0x04000AA4 RID: 2724
	public GameObject pickaxeDoubleDamageChance_1;

	// Token: 0x04000AA5 RID: 2725
	public GameObject pickaxeDoubleDamageChance_2;

	// Token: 0x04000AA6 RID: 2726
	public GameObject intaMineChance_1;

	// Token: 0x04000AA7 RID: 2727
	public GameObject intaMineChance_2;

	// Token: 0x04000AA8 RID: 2728
	public GameObject increaseSpawnChanceAllRocks;

	// Token: 0x04000AA9 RID: 2729
	public GameObject craft2Material;

	// Token: 0x04000AAA RID: 2730
	public GameObject finalUpgrade;

	// Token: 0x04000AAB RID: 2731
	public GameObject moreXP_1_LOCKED;

	// Token: 0x04000AAC RID: 2732
	public GameObject moreXP_2_LOCKED;

	// Token: 0x04000AAD RID: 2733
	public GameObject moreXP_3_LOCKED;

	// Token: 0x04000AAE RID: 2734
	public GameObject moreXP_4_LOCKED;

	// Token: 0x04000AAF RID: 2735
	public GameObject moreXP_5_LOCKED;

	// Token: 0x04000AB0 RID: 2736
	public GameObject moreXP_6_LOCKED;

	// Token: 0x04000AB1 RID: 2737
	public GameObject moreXP_7_LOCKED;

	// Token: 0x04000AB2 RID: 2738
	public GameObject moreXP_8_LOCKED;

	// Token: 0x04000AB3 RID: 2739
	public GameObject talentPointsPerXlevel_1_LOCKED;

	// Token: 0x04000AB4 RID: 2740
	public GameObject talentPointsPerXlevel_2_LOCKED;

	// Token: 0x04000AB5 RID: 2741
	public GameObject talentPointsPerXlevel_3_LOCKED;

	// Token: 0x04000AB6 RID: 2742
	public GameObject spawnMoreRocks_1_LOCKED;

	// Token: 0x04000AB7 RID: 2743
	public GameObject spawnMoreRocks_2_LOCKED;

	// Token: 0x04000AB8 RID: 2744
	public GameObject spawnMoreRocks_3_LOCKED;

	// Token: 0x04000AB9 RID: 2745
	public GameObject spawnMoreRocks_4_LOCKED;

	// Token: 0x04000ABA RID: 2746
	public GameObject spawnMoreRocks_5_LOCKED;

	// Token: 0x04000ABB RID: 2747
	public GameObject spawnMoreRocks_6_LOCKED;

	// Token: 0x04000ABC RID: 2748
	public GameObject spawnMoreRocks_7_LOCKED;

	// Token: 0x04000ABD RID: 2749
	public GameObject spawnMoreRocks_8_LOCKED;

	// Token: 0x04000ABE RID: 2750
	public GameObject spawnMoreRocks_9_LOCKED;

	// Token: 0x04000ABF RID: 2751
	public GameObject moreMeterialsFromRock_1_LOCKED;

	// Token: 0x04000AC0 RID: 2752
	public GameObject moreMeterialsFromRock_2_LOCKED;

	// Token: 0x04000AC1 RID: 2753
	public GameObject moreMeterialsFromRock_3_LOCKED;

	// Token: 0x04000AC2 RID: 2754
	public GameObject moreMeterialsFromRock_4_LOCKED;

	// Token: 0x04000AC3 RID: 2755
	public GameObject moreMeterialsFromRock_5_LOCKED;

	// Token: 0x04000AC4 RID: 2756
	public GameObject marterialsWorthMore_1_LOCKED;

	// Token: 0x04000AC5 RID: 2757
	public GameObject marterialsWorthMore_2_LOCKED;

	// Token: 0x04000AC6 RID: 2758
	public GameObject marterialsWorthMore_3_LOCKED;

	// Token: 0x04000AC7 RID: 2759
	public GameObject marterialsWorthMore_4_LOCKED;

	// Token: 0x04000AC8 RID: 2760
	public GameObject marterialsWorthMore_5_LOCKED;

	// Token: 0x04000AC9 RID: 2761
	public GameObject marterialsWorthMore_6_LOCKED;

	// Token: 0x04000ACA RID: 2762
	public GameObject marterialsWorthMore_7_LOCKED;

	// Token: 0x04000ACB RID: 2763
	public GameObject marterialsWorthMore_8_LOCKED;

	// Token: 0x04000ACC RID: 2764
	public GameObject goldChunk_1_LOCKED;

	// Token: 0x04000ACD RID: 2765
	public GameObject goldChunk_2_LOCKED;

	// Token: 0x04000ACE RID: 2766
	public GameObject goldChunk_3_LOCKED;

	// Token: 0x04000ACF RID: 2767
	public GameObject goldChunk_4_LOCKED;

	// Token: 0x04000AD0 RID: 2768
	public GameObject goldChunk_5_LOCKED;

	// Token: 0x04000AD1 RID: 2769
	public GameObject fullGold_1_LOCKED;

	// Token: 0x04000AD2 RID: 2770
	public GameObject fullGold_2_LOCKED;

	// Token: 0x04000AD3 RID: 2771
	public GameObject fullGold_3_LOCKED;

	// Token: 0x04000AD4 RID: 2772
	public GameObject spawnCopper_LOCKED;

	// Token: 0x04000AD5 RID: 2773
	public GameObject copperChunk_1_LOCKED;

	// Token: 0x04000AD6 RID: 2774
	public GameObject copperChunk_2_LOCKED;

	// Token: 0x04000AD7 RID: 2775
	public GameObject copperChunk_3_LOCKED;

	// Token: 0x04000AD8 RID: 2776
	public GameObject fullCopper_1_LOCKED;

	// Token: 0x04000AD9 RID: 2777
	public GameObject fullCopper_2_LOCKED;

	// Token: 0x04000ADA RID: 2778
	public GameObject fullCopper_3_LOCKED;

	// Token: 0x04000ADB RID: 2779
	public GameObject spawnIron_LOCKED;

	// Token: 0x04000ADC RID: 2780
	public GameObject ironChunk_1_LOCKED;

	// Token: 0x04000ADD RID: 2781
	public GameObject ironChunk_2_LOCKED;

	// Token: 0x04000ADE RID: 2782
	public GameObject fullIron_1_LOCKED;

	// Token: 0x04000ADF RID: 2783
	public GameObject fullIron_2_LOCKED;

	// Token: 0x04000AE0 RID: 2784
	public GameObject cobaltSpawn_LOCKED;

	// Token: 0x04000AE1 RID: 2785
	public GameObject cobaltChunk_1_LOCKED;

	// Token: 0x04000AE2 RID: 2786
	public GameObject fullCobalt_1_LOCKED;

	// Token: 0x04000AE3 RID: 2787
	public GameObject uraniumSpawn_LOCKED;

	// Token: 0x04000AE4 RID: 2788
	public GameObject uraniumChunk_1_LOCKED;

	// Token: 0x04000AE5 RID: 2789
	public GameObject fullUranium_1_LOCKED;

	// Token: 0x04000AE6 RID: 2790
	public GameObject ismiumSpawn_LOCKED;

	// Token: 0x04000AE7 RID: 2791
	public GameObject ismiumChunk_1_LOCKED;

	// Token: 0x04000AE8 RID: 2792
	public GameObject fullIsmium_1_LOCKED;

	// Token: 0x04000AE9 RID: 2793
	public GameObject iridiumSpawn_LOCKED;

	// Token: 0x04000AEA RID: 2794
	public GameObject iridiumChunk_1_LOCKED;

	// Token: 0x04000AEB RID: 2795
	public GameObject fullIridium_1_LOCKED;

	// Token: 0x04000AEC RID: 2796
	public GameObject painiteSpawn_LOCKED;

	// Token: 0x04000AED RID: 2797
	public GameObject painiteChunk_1_LOCKED;

	// Token: 0x04000AEE RID: 2798
	public GameObject fullPainite_1_LOCKED;

	// Token: 0x04000AEF RID: 2799
	public GameObject improvedPickaxe_1_LOCKED;

	// Token: 0x04000AF0 RID: 2800
	public GameObject improvedPickaxe_2_LOCKED;

	// Token: 0x04000AF1 RID: 2801
	public GameObject improvedPickaxe_3_LOCKED;

	// Token: 0x04000AF2 RID: 2802
	public GameObject improvedPickaxe_4_LOCKED;

	// Token: 0x04000AF3 RID: 2803
	public GameObject improvedPickaxe_5_LOCKED;

	// Token: 0x04000AF4 RID: 2804
	public GameObject improvedPickaxe_6_LOCKED;

	// Token: 0x04000AF5 RID: 2805
	public GameObject biggerMiningErea_1_LOCKED;

	// Token: 0x04000AF6 RID: 2806
	public GameObject biggerMiningErea_2_LOCKED;

	// Token: 0x04000AF7 RID: 2807
	public GameObject biggerMiningErea_3_LOCKED;

	// Token: 0x04000AF8 RID: 2808
	public GameObject biggerMiningErea_4_LOCKED;

	// Token: 0x04000AF9 RID: 2809
	public GameObject shootCircleChance_LOCKED;

	// Token: 0x04000AFA RID: 2810
	public GameObject increaseAndDecreaseMinignErea_LOCKED;

	// Token: 0x04000AFB RID: 2811
	public GameObject spawnRockEveryXrock_1_LOCKED;

	// Token: 0x04000AFC RID: 2812
	public GameObject spawnRockEveryXrock_2_LOCKED;

	// Token: 0x04000AFD RID: 2813
	public GameObject spawnRockEveryXrock_3_LOCKED;

	// Token: 0x04000AFE RID: 2814
	public GameObject spawnXRockEveryXSecond_1_LOCKED;

	// Token: 0x04000AFF RID: 2815
	public GameObject spawnXRockEveryXSecond_2_LOCKED;

	// Token: 0x04000B00 RID: 2816
	public GameObject spawnXRockEveryXSecond_3_LOCKED;

	// Token: 0x04000B01 RID: 2817
	public GameObject chanceToSpawnRockWhenMined_1_LOCKED;

	// Token: 0x04000B02 RID: 2818
	public GameObject chanceToSpawnRockWhenMined_2_LOCKED;

	// Token: 0x04000B03 RID: 2819
	public GameObject chanceToSpawnRockWhenMined_3_LOCKED;

	// Token: 0x04000B04 RID: 2820
	public GameObject chanceToSpawnRockWhenMined_4_LOCKED;

	// Token: 0x04000B05 RID: 2821
	public GameObject chanceToSpawnRockWhenMined_5_LOCKED;

	// Token: 0x04000B06 RID: 2822
	public GameObject chanceToSpawnRockWhenMined_6_LOCKED;

	// Token: 0x04000B07 RID: 2823
	public GameObject chanceToMineRandomRock_1_LOCKED;

	// Token: 0x04000B08 RID: 2824
	public GameObject chanceToMineRandomRock_2_LOCKED;

	// Token: 0x04000B09 RID: 2825
	public GameObject chanceToMineRandomRock_3_LOCKED;

	// Token: 0x04000B0A RID: 2826
	public GameObject chanceToMineRandomRock_4_LOCKED;

	// Token: 0x04000B0B RID: 2827
	public GameObject spawnPickaxeEverySecond_1_LOCKED;

	// Token: 0x04000B0C RID: 2828
	public GameObject spawnPickaxeEverySecond_2_LOCKED;

	// Token: 0x04000B0D RID: 2829
	public GameObject spawnPickaxeEverySecond_3_LOCKED;

	// Token: 0x04000B0E RID: 2830
	public GameObject moreTime_1_LOCKED;

	// Token: 0x04000B0F RID: 2831
	public GameObject moreTime_2_LOCKED;

	// Token: 0x04000B10 RID: 2832
	public GameObject moreTime_3_LOCKED;

	// Token: 0x04000B11 RID: 2833
	public GameObject moreTime_4_LOCKED;

	// Token: 0x04000B12 RID: 2834
	public GameObject chanceToAdd1SecondEverySecond_LOCKED;

	// Token: 0x04000B13 RID: 2835
	public GameObject chanceAdd1SecondEveryRockMined_LOCKED;

	// Token: 0x04000B14 RID: 2836
	public GameObject doubleXpGoldChance_1_LOCKED;

	// Token: 0x04000B15 RID: 2837
	public GameObject doubleXpGoldChance_2_LOCKED;

	// Token: 0x04000B16 RID: 2838
	public GameObject doubleXpGoldChance_3_LOCKED;

	// Token: 0x04000B17 RID: 2839
	public GameObject doubleXpGoldChance_4_LOCKED;

	// Token: 0x04000B18 RID: 2840
	public GameObject doubleXpGoldChance_5_LOCKED;

	// Token: 0x04000B19 RID: 2841
	public GameObject lightningBeamChanceS_1_LOCKED;

	// Token: 0x04000B1A RID: 2842
	public GameObject lightningBeamChanceS_2_LOCKED;

	// Token: 0x04000B1B RID: 2843
	public GameObject lightningBeamChancePH_1_LOCKED;

	// Token: 0x04000B1C RID: 2844
	public GameObject lightningBeamChancePH_2_LOCKED;

	// Token: 0x04000B1D RID: 2845
	public GameObject lightningBeamSpawnAnotherOneChance_LOCKED;

	// Token: 0x04000B1E RID: 2846
	public GameObject lightningBeamDamage_LOCKED;

	// Token: 0x04000B1F RID: 2847
	public GameObject lightningBeamSize_LOCKED;

	// Token: 0x04000B20 RID: 2848
	public GameObject lightningSplashes_LOCKED;

	// Token: 0x04000B21 RID: 2849
	public GameObject lightningBeamSpawnRock_LOCKED;

	// Token: 0x04000B22 RID: 2850
	public GameObject lightningBeamExplosion_LOCKED;

	// Token: 0x04000B23 RID: 2851
	public GameObject lightningBeamAddTime_LOCKED;

	// Token: 0x04000B24 RID: 2852
	public GameObject dynamiteChance_1_LOCKED;

	// Token: 0x04000B25 RID: 2853
	public GameObject dynamiteChance_2_LOCKED;

	// Token: 0x04000B26 RID: 2854
	public GameObject dynamiteSpawn2SmallChance_LOCKED;

	// Token: 0x04000B27 RID: 2855
	public GameObject dynamiteExplosionSize_LOCKED;

	// Token: 0x04000B28 RID: 2856
	public GameObject dynamiteDamage_LOCKED;

	// Token: 0x04000B29 RID: 2857
	public GameObject dynamiteExplosionSpawnRock_LOCKED;

	// Token: 0x04000B2A RID: 2858
	public GameObject dynamiteExplosionAddTimeChance_LOCKED;

	// Token: 0x04000B2B RID: 2859
	public GameObject dynamiteExplosionSpawnLightning_LOCKED;

	// Token: 0x04000B2C RID: 2860
	public GameObject plazmaBallSpawn_1_LOCKED;

	// Token: 0x04000B2D RID: 2861
	public GameObject plazmaBallSpawn_2_LOCKED;

	// Token: 0x04000B2E RID: 2862
	public GameObject plazmaBallTime_LOCKED;

	// Token: 0x04000B2F RID: 2863
	public GameObject plazmaBallSize_LOCKED;

	// Token: 0x04000B30 RID: 2864
	public GameObject plazmaBallExplosionChance_LOCKED;

	// Token: 0x04000B31 RID: 2865
	public GameObject plazmaBallSpawnSmallChance_LOCKED;

	// Token: 0x04000B32 RID: 2866
	public GameObject plazmaBallDamage_LOCKED;

	// Token: 0x04000B33 RID: 2867
	public GameObject plazmaBallSpawnPickaxeChance_LOCKED;

	// Token: 0x04000B34 RID: 2868
	public GameObject allProjectileDoubleDamageChance_LOCKED;

	// Token: 0x04000B35 RID: 2869
	public GameObject allProjectileTriggerChance_LOCKED;

	// Token: 0x04000B36 RID: 2870
	public GameObject pickaxeDoubleDamageChance_1_LOCKED;

	// Token: 0x04000B37 RID: 2871
	public GameObject pickaxeDoubleDamageChance_2_LOCKED;

	// Token: 0x04000B38 RID: 2872
	public GameObject intaMineChance_1_LOCKED;

	// Token: 0x04000B39 RID: 2873
	public GameObject intaMineChance_2_LOCKED;

	// Token: 0x04000B3A RID: 2874
	public GameObject increaseSpawnChanceAllRocks_LOCKED;

	// Token: 0x04000B3B RID: 2875
	public GameObject craft2Material_LOCKED;

	// Token: 0x04000B3C RID: 2876
	public GameObject finalUpgrade_LOCKED;

	// Token: 0x04000B3D RID: 2877
	public static double moreXP_1_price;

	// Token: 0x04000B3E RID: 2878
	public static double moreXP_2_price;

	// Token: 0x04000B3F RID: 2879
	public static double moreXP_3_price;

	// Token: 0x04000B40 RID: 2880
	public static double moreXP_4_price;

	// Token: 0x04000B41 RID: 2881
	public static double moreXP_5_price;

	// Token: 0x04000B42 RID: 2882
	public static double moreXP_6_price;

	// Token: 0x04000B43 RID: 2883
	public static double moreXP_7_price;

	// Token: 0x04000B44 RID: 2884
	public static double moreXP_8_price;

	// Token: 0x04000B45 RID: 2885
	public static double talentPointsPerXlevel_1_price;

	// Token: 0x04000B46 RID: 2886
	public static double talentPointsPerXlevel_2_price;

	// Token: 0x04000B47 RID: 2887
	public static double talentPointsPerXlevel_3_price;

	// Token: 0x04000B48 RID: 2888
	public static double lightningBeamChanceS_1_price;

	// Token: 0x04000B49 RID: 2889
	public static double lightningBeamChanceS_2_price;

	// Token: 0x04000B4A RID: 2890
	public static double lightningBeamChancePH_1_price;

	// Token: 0x04000B4B RID: 2891
	public static double lightningBeamChancePH_2_price;

	// Token: 0x04000B4C RID: 2892
	public static double lightningBeamSpawnAnotherOneChance_price;

	// Token: 0x04000B4D RID: 2893
	public static double lightningBeamDamage_price;

	// Token: 0x04000B4E RID: 2894
	public static double lightningBeamSize_price;

	// Token: 0x04000B4F RID: 2895
	public static double lightningSplashes_price;

	// Token: 0x04000B50 RID: 2896
	public static double lightningBeamSpawnRock_price;

	// Token: 0x04000B51 RID: 2897
	public static double lightningBeamExplosion_price;

	// Token: 0x04000B52 RID: 2898
	public static double lightningBeamAddTime_price;

	// Token: 0x04000B53 RID: 2899
	public static double dynamiteChance_1_price;

	// Token: 0x04000B54 RID: 2900
	public static double dynamiteChance_2_price;

	// Token: 0x04000B55 RID: 2901
	public static double dynamiteSpawn2SmallChance_price;

	// Token: 0x04000B56 RID: 2902
	public static double dynamiteExplosionSize_price;

	// Token: 0x04000B57 RID: 2903
	public static double dynamiteDamage_price;

	// Token: 0x04000B58 RID: 2904
	public static double dynamiteExplosionSpawnRock_price;

	// Token: 0x04000B59 RID: 2905
	public static double dynamiteExplosionAddTimeChance_price;

	// Token: 0x04000B5A RID: 2906
	public static double dynamiteExplosionSpawnLightning_price;

	// Token: 0x04000B5B RID: 2907
	public static double plazmaBallSpawn_1_price;

	// Token: 0x04000B5C RID: 2908
	public static double plazmaBallSpawn_2_price;

	// Token: 0x04000B5D RID: 2909
	public static double plazmaBallTime_price;

	// Token: 0x04000B5E RID: 2910
	public static double plazmaBallSize_price;

	// Token: 0x04000B5F RID: 2911
	public static double plazmaBallExplosionChance_price;

	// Token: 0x04000B60 RID: 2912
	public static double plazmaBallSpawnSmallChance_price;

	// Token: 0x04000B61 RID: 2913
	public static double plazmaBallDamage_price;

	// Token: 0x04000B62 RID: 2914
	public static double plazmaBallSpawnPickaxeChance_price;

	// Token: 0x04000B63 RID: 2915
	public static double spawnMoreRocks_1_price;

	// Token: 0x04000B64 RID: 2916
	public static double spawnMoreRocks_2_price;

	// Token: 0x04000B65 RID: 2917
	public static double spawnMoreRocks_3_price;

	// Token: 0x04000B66 RID: 2918
	public static double spawnMoreRocks_4_price;

	// Token: 0x04000B67 RID: 2919
	public static double spawnMoreRocks_5_price;

	// Token: 0x04000B68 RID: 2920
	public static double spawnMoreRocks_6_price;

	// Token: 0x04000B69 RID: 2921
	public static double spawnMoreRocks_7_price;

	// Token: 0x04000B6A RID: 2922
	public static double spawnMoreRocks_8_price;

	// Token: 0x04000B6B RID: 2923
	public static double spawnMoreRocks_9_price;

	// Token: 0x04000B6C RID: 2924
	public static double moreMeterialsFromRock_1_price;

	// Token: 0x04000B6D RID: 2925
	public static double moreMeterialsFromRock_2_price;

	// Token: 0x04000B6E RID: 2926
	public static double moreMeterialsFromRock_3_price;

	// Token: 0x04000B6F RID: 2927
	public static double moreMeterialsFromRock_4_price;

	// Token: 0x04000B70 RID: 2928
	public static double moreMeterialsFromRock_5_price;

	// Token: 0x04000B71 RID: 2929
	public static double marterialsWorthMore_1_price;

	// Token: 0x04000B72 RID: 2930
	public static double marterialsWorthMore_2_price;

	// Token: 0x04000B73 RID: 2931
	public static double marterialsWorthMore_3_price;

	// Token: 0x04000B74 RID: 2932
	public static double marterialsWorthMore_4_price;

	// Token: 0x04000B75 RID: 2933
	public static double marterialsWorthMore_5_price;

	// Token: 0x04000B76 RID: 2934
	public static double marterialsWorthMore_6_price;

	// Token: 0x04000B77 RID: 2935
	public static double marterialsWorthMore_7_price;

	// Token: 0x04000B78 RID: 2936
	public static double marterialsWorthMore_8_price;

	// Token: 0x04000B79 RID: 2937
	public static double goldChunk_1_price;

	// Token: 0x04000B7A RID: 2938
	public static double goldChunk_2_price;

	// Token: 0x04000B7B RID: 2939
	public static double goldChunk_3_price;

	// Token: 0x04000B7C RID: 2940
	public static double goldChunk_4_price;

	// Token: 0x04000B7D RID: 2941
	public static double goldChunk_5__price;

	// Token: 0x04000B7E RID: 2942
	public static double fullGold_1_price;

	// Token: 0x04000B7F RID: 2943
	public static double fullGold_2_price;

	// Token: 0x04000B80 RID: 2944
	public static double fullGold_3_price;

	// Token: 0x04000B81 RID: 2945
	public static double spawnCopper_price;

	// Token: 0x04000B82 RID: 2946
	public static double copperChunk_1_price;

	// Token: 0x04000B83 RID: 2947
	public static double copperChunk_2_price;

	// Token: 0x04000B84 RID: 2948
	public static double copperChunk_3_price;

	// Token: 0x04000B85 RID: 2949
	public static double fullCopper_1_price;

	// Token: 0x04000B86 RID: 2950
	public static double fullCopper_2_price;

	// Token: 0x04000B87 RID: 2951
	public static double fullCopper_3_price;

	// Token: 0x04000B88 RID: 2952
	public static double spawnIron_price;

	// Token: 0x04000B89 RID: 2953
	public static double ironChunk_1_price;

	// Token: 0x04000B8A RID: 2954
	public static double ironChunk_2_price;

	// Token: 0x04000B8B RID: 2955
	public static double fullIron_1_price;

	// Token: 0x04000B8C RID: 2956
	public static double fullIron_2_price;

	// Token: 0x04000B8D RID: 2957
	public static double cobaltSpawn_price;

	// Token: 0x04000B8E RID: 2958
	public static double cobaltChunk_1_price;

	// Token: 0x04000B8F RID: 2959
	public static double fullCobalt_1_price;

	// Token: 0x04000B90 RID: 2960
	public static double uraniumSpawn_price;

	// Token: 0x04000B91 RID: 2961
	public static double uraniumChunk_1_price;

	// Token: 0x04000B92 RID: 2962
	public static double fullUranium_1_price;

	// Token: 0x04000B93 RID: 2963
	public static double ismiumSpawn_price;

	// Token: 0x04000B94 RID: 2964
	public static double ismiumChunk_1_price;

	// Token: 0x04000B95 RID: 2965
	public static double fullIsmium_1_price;

	// Token: 0x04000B96 RID: 2966
	public static double iridiumSpawn_price;

	// Token: 0x04000B97 RID: 2967
	public static double iridiumChunk_1_price;

	// Token: 0x04000B98 RID: 2968
	public static double fullIridium_1_price;

	// Token: 0x04000B99 RID: 2969
	public static double painiteSpawn_price;

	// Token: 0x04000B9A RID: 2970
	public static double painiteChunk_1_price;

	// Token: 0x04000B9B RID: 2971
	public static double fullPainite_1_price;

	// Token: 0x04000B9C RID: 2972
	public static double improvedPickaxe_1_price;

	// Token: 0x04000B9D RID: 2973
	public static double improvedPickaxe_2_price;

	// Token: 0x04000B9E RID: 2974
	public static double improvedPickaxe_3_price;

	// Token: 0x04000B9F RID: 2975
	public static double improvedPickaxe_4_price;

	// Token: 0x04000BA0 RID: 2976
	public static double improvedPickaxe_5_price;

	// Token: 0x04000BA1 RID: 2977
	public static double improvedPickaxe_6_price;

	// Token: 0x04000BA2 RID: 2978
	public static double biggerMiningErea_1_price;

	// Token: 0x04000BA3 RID: 2979
	public static double biggerMiningErea_2_price;

	// Token: 0x04000BA4 RID: 2980
	public static double biggerMiningErea_3_price;

	// Token: 0x04000BA5 RID: 2981
	public static double biggerMiningErea_4_price;

	// Token: 0x04000BA6 RID: 2982
	public static double shootCircleChance_price;

	// Token: 0x04000BA7 RID: 2983
	public static double increaseAndDecreaseMinignErea_price;

	// Token: 0x04000BA8 RID: 2984
	public static double spawnRockEveryXrock_1_price;

	// Token: 0x04000BA9 RID: 2985
	public static double spawnRockEveryXrock_2_price;

	// Token: 0x04000BAA RID: 2986
	public static double spawnRockEveryXrock_3_price;

	// Token: 0x04000BAB RID: 2987
	public static double spawnXRockEveryXSecond_1_price;

	// Token: 0x04000BAC RID: 2988
	public static double spawnXRockEveryXSecond_2_price;

	// Token: 0x04000BAD RID: 2989
	public static double spawnXRockEveryXSecond_3_price;

	// Token: 0x04000BAE RID: 2990
	public static double chanceToSpawnRockWhenMined_1_price;

	// Token: 0x04000BAF RID: 2991
	public static double chanceToSpawnRockWhenMined_2_price;

	// Token: 0x04000BB0 RID: 2992
	public static double chanceToSpawnRockWhenMined_3_price;

	// Token: 0x04000BB1 RID: 2993
	public static double chanceToSpawnRockWhenMined_4_price;

	// Token: 0x04000BB2 RID: 2994
	public static double chanceToSpawnRockWhenMined_5_price;

	// Token: 0x04000BB3 RID: 2995
	public static double chanceToSpawnRockWhenMined_6_price;

	// Token: 0x04000BB4 RID: 2996
	public static double chanceToMineRandomRock_1_price;

	// Token: 0x04000BB5 RID: 2997
	public static double chanceToMineRandomRock_2_price;

	// Token: 0x04000BB6 RID: 2998
	public static double chanceToMineRandomRock_3_price;

	// Token: 0x04000BB7 RID: 2999
	public static double chanceToMineRandomRock_4_price;

	// Token: 0x04000BB8 RID: 3000
	public static double spawnPickaxeEverySecond_1_price;

	// Token: 0x04000BB9 RID: 3001
	public static double spawnPickaxeEverySecond_2_price;

	// Token: 0x04000BBA RID: 3002
	public static double spawnPickaxeEverySecond_3_price;

	// Token: 0x04000BBB RID: 3003
	public static double moreTime_1_price;

	// Token: 0x04000BBC RID: 3004
	public static double moreTime_2_price;

	// Token: 0x04000BBD RID: 3005
	public static double moreTime_3_price;

	// Token: 0x04000BBE RID: 3006
	public static double moreTime_4_price;

	// Token: 0x04000BBF RID: 3007
	public static double chanceToAdd1SecondEverySecond_price;

	// Token: 0x04000BC0 RID: 3008
	public static double chanceAdd1SecondEveryRockMined_price;

	// Token: 0x04000BC1 RID: 3009
	public static double doubleXpGoldChance_1_price;

	// Token: 0x04000BC2 RID: 3010
	public static double doubleXpGoldChance_2_price;

	// Token: 0x04000BC3 RID: 3011
	public static double doubleXpGoldChance_3_price;

	// Token: 0x04000BC4 RID: 3012
	public static double doubleXpGoldChance_4_price;

	// Token: 0x04000BC5 RID: 3013
	public static double doubleXpGoldChance_5_price;

	// Token: 0x04000BC6 RID: 3014
	public static double allProjectileDoubleDamageChance_price;

	// Token: 0x04000BC7 RID: 3015
	public static double allProjectileTriggerChance_price;

	// Token: 0x04000BC8 RID: 3016
	public static double pickaxeDoubleDamageChance_1_price;

	// Token: 0x04000BC9 RID: 3017
	public static double pickaxeDoubleDamageChance_2_price;

	// Token: 0x04000BCA RID: 3018
	public static double intaMineChance_1_price;

	// Token: 0x04000BCB RID: 3019
	public static double intaMineChance_2_price;

	// Token: 0x04000BCC RID: 3020
	public static double increaseSpawnChanceAllRocks_price;

	// Token: 0x04000BCD RID: 3021
	public static double craft2Material_price;

	// Token: 0x04000BCE RID: 3022
	public static double finalUpgrade_price;

	// Token: 0x04000BCF RID: 3023
	public static bool moreXP_1_purchased;

	// Token: 0x04000BD0 RID: 3024
	public static bool moreXP_2_purchased;

	// Token: 0x04000BD1 RID: 3025
	public static bool moreXP_3_purchased;

	// Token: 0x04000BD2 RID: 3026
	public static bool moreXP_4_purchased;

	// Token: 0x04000BD3 RID: 3027
	public static bool moreXP_5_purchased;

	// Token: 0x04000BD4 RID: 3028
	public static bool moreXP_6_purchased;

	// Token: 0x04000BD5 RID: 3029
	public static bool moreXP_7_purchased;

	// Token: 0x04000BD6 RID: 3030
	public static bool moreXP_8_purchased;

	// Token: 0x04000BD7 RID: 3031
	public static bool talentPointsPerXlevel_1_purchased;

	// Token: 0x04000BD8 RID: 3032
	public static bool talentPointsPerXlevel_2_purchased;

	// Token: 0x04000BD9 RID: 3033
	public static bool talentPointsPerXlevel_3_purchased;

	// Token: 0x04000BDA RID: 3034
	public static bool spawnMoreRocks_1_purchased;

	// Token: 0x04000BDB RID: 3035
	public static bool spawnMoreRocks_2_purchased;

	// Token: 0x04000BDC RID: 3036
	public static bool spawnMoreRocks_3_purchased;

	// Token: 0x04000BDD RID: 3037
	public static bool spawnMoreRocks_4_purchased;

	// Token: 0x04000BDE RID: 3038
	public static bool spawnMoreRocks_5_purchased;

	// Token: 0x04000BDF RID: 3039
	public static bool spawnMoreRocks_6_purchased;

	// Token: 0x04000BE0 RID: 3040
	public static bool spawnMoreRocks_7_purchased;

	// Token: 0x04000BE1 RID: 3041
	public static bool spawnMoreRocks_8_purchased;

	// Token: 0x04000BE2 RID: 3042
	public static bool spawnMoreRocks_9_purchased;

	// Token: 0x04000BE3 RID: 3043
	public static bool moreMeterialsFromRock_1_purchased;

	// Token: 0x04000BE4 RID: 3044
	public static bool moreMeterialsFromRock_2_purchased;

	// Token: 0x04000BE5 RID: 3045
	public static bool moreMeterialsFromRock_3_purchased;

	// Token: 0x04000BE6 RID: 3046
	public static bool moreMeterialsFromRock_4_purchased;

	// Token: 0x04000BE7 RID: 3047
	public static bool moreMeterialsFromRock_5_purchased;

	// Token: 0x04000BE8 RID: 3048
	public static bool marterialsWorthMore_1_purchased;

	// Token: 0x04000BE9 RID: 3049
	public static bool marterialsWorthMore_2_purchased;

	// Token: 0x04000BEA RID: 3050
	public static bool marterialsWorthMore_3_purchased;

	// Token: 0x04000BEB RID: 3051
	public static bool marterialsWorthMore_4_purchased;

	// Token: 0x04000BEC RID: 3052
	public static bool marterialsWorthMore_5_purchased;

	// Token: 0x04000BED RID: 3053
	public static bool marterialsWorthMore_6_purchased;

	// Token: 0x04000BEE RID: 3054
	public static bool marterialsWorthMore_7_purchased;

	// Token: 0x04000BEF RID: 3055
	public static bool marterialsWorthMore_8_purchased;

	// Token: 0x04000BF0 RID: 3056
	public static bool goldChunk_1_purchased;

	// Token: 0x04000BF1 RID: 3057
	public static bool goldChunk_2_purchased;

	// Token: 0x04000BF2 RID: 3058
	public static bool goldChunk_3_purchased;

	// Token: 0x04000BF3 RID: 3059
	public static bool goldChunk_4_purchased;

	// Token: 0x04000BF4 RID: 3060
	public static bool goldChunk_5_purchased;

	// Token: 0x04000BF5 RID: 3061
	public static bool fullGold_1_purchased;

	// Token: 0x04000BF6 RID: 3062
	public static bool fullGold_2_purchased;

	// Token: 0x04000BF7 RID: 3063
	public static bool fullGold_3_purchased;

	// Token: 0x04000BF8 RID: 3064
	public static bool spawnCopper_purchased;

	// Token: 0x04000BF9 RID: 3065
	public static bool copperChunk_1_purchased;

	// Token: 0x04000BFA RID: 3066
	public static bool copperChunk_2_purchased;

	// Token: 0x04000BFB RID: 3067
	public static bool copperChunk_3_purchased;

	// Token: 0x04000BFC RID: 3068
	public static bool fullCopper_1_purchased;

	// Token: 0x04000BFD RID: 3069
	public static bool fullCopper_2_purchased;

	// Token: 0x04000BFE RID: 3070
	public static bool fullCopper_3_purchased;

	// Token: 0x04000BFF RID: 3071
	public static bool spawnIron_purchased;

	// Token: 0x04000C00 RID: 3072
	public static bool ironChunk_1_purchased;

	// Token: 0x04000C01 RID: 3073
	public static bool ironChunk_2_purchased;

	// Token: 0x04000C02 RID: 3074
	public static bool fullIron_1_purchased;

	// Token: 0x04000C03 RID: 3075
	public static bool fullIron_2_purchased;

	// Token: 0x04000C04 RID: 3076
	public static bool cobaltSpawn_purchased;

	// Token: 0x04000C05 RID: 3077
	public static bool cobaltChunk_1_purchased;

	// Token: 0x04000C06 RID: 3078
	public static bool fullCobalt_1_purchased;

	// Token: 0x04000C07 RID: 3079
	public static bool uraniumSpawn_purchased;

	// Token: 0x04000C08 RID: 3080
	public static bool uraniumChunk_1_purchased;

	// Token: 0x04000C09 RID: 3081
	public static bool fullUranium_1_purchased;

	// Token: 0x04000C0A RID: 3082
	public static bool ismiumSpawn_purchased;

	// Token: 0x04000C0B RID: 3083
	public static bool ismiumChunk_1_purchased;

	// Token: 0x04000C0C RID: 3084
	public static bool fullIsmium_1_purchased;

	// Token: 0x04000C0D RID: 3085
	public static bool iridiumSpawn_purchased;

	// Token: 0x04000C0E RID: 3086
	public static bool iridiumChunk_1_purchased;

	// Token: 0x04000C0F RID: 3087
	public static bool fullIridium_1_purchased;

	// Token: 0x04000C10 RID: 3088
	public static bool painiteSpawn_purchased;

	// Token: 0x04000C11 RID: 3089
	public static bool painiteChunk_1_purchased;

	// Token: 0x04000C12 RID: 3090
	public static bool fullPainite_1_purchased;

	// Token: 0x04000C13 RID: 3091
	public static bool improvedPickaxe_1_purchased;

	// Token: 0x04000C14 RID: 3092
	public static bool improvedPickaxe_2_purchased;

	// Token: 0x04000C15 RID: 3093
	public static bool improvedPickaxe_3_purchased;

	// Token: 0x04000C16 RID: 3094
	public static bool improvedPickaxe_4_purchased;

	// Token: 0x04000C17 RID: 3095
	public static bool improvedPickaxe_5_purchased;

	// Token: 0x04000C18 RID: 3096
	public static bool improvedPickaxe_6_purchased;

	// Token: 0x04000C19 RID: 3097
	public static bool biggerMiningErea_1_purchased;

	// Token: 0x04000C1A RID: 3098
	public static bool biggerMiningErea_2_purchased;

	// Token: 0x04000C1B RID: 3099
	public static bool biggerMiningErea_3_purchased;

	// Token: 0x04000C1C RID: 3100
	public static bool biggerMiningErea_4_purchased;

	// Token: 0x04000C1D RID: 3101
	public static bool shootCircleChance_purchased;

	// Token: 0x04000C1E RID: 3102
	public static bool increaseAndDecreaseMinignErea_purchased;

	// Token: 0x04000C1F RID: 3103
	public static bool spawnRockEveryXrock_1_purchased;

	// Token: 0x04000C20 RID: 3104
	public static bool spawnRockEveryXrock_2_purchased;

	// Token: 0x04000C21 RID: 3105
	public static bool spawnRockEveryXrock_3_purchased;

	// Token: 0x04000C22 RID: 3106
	public static bool spawnXRockEveryXSecond_1_purchased;

	// Token: 0x04000C23 RID: 3107
	public static bool spawnXRockEveryXSecond_2_purchased;

	// Token: 0x04000C24 RID: 3108
	public static bool spawnXRockEveryXSecond_3_purchased;

	// Token: 0x04000C25 RID: 3109
	public static bool chanceToSpawnRockWhenMined_1_purchased;

	// Token: 0x04000C26 RID: 3110
	public static bool chanceToSpawnRockWhenMined_2_purchased;

	// Token: 0x04000C27 RID: 3111
	public static bool chanceToSpawnRockWhenMined_3_purchased;

	// Token: 0x04000C28 RID: 3112
	public static bool chanceToSpawnRockWhenMined_4_purchased;

	// Token: 0x04000C29 RID: 3113
	public static bool chanceToSpawnRockWhenMined_5_purchased;

	// Token: 0x04000C2A RID: 3114
	public static bool chanceToSpawnRockWhenMined_6_purchased;

	// Token: 0x04000C2B RID: 3115
	public static bool chanceToMineRandomRock_1_purchased;

	// Token: 0x04000C2C RID: 3116
	public static bool chanceToMineRandomRock_2_purchased;

	// Token: 0x04000C2D RID: 3117
	public static bool chanceToMineRandomRock_3_purchased;

	// Token: 0x04000C2E RID: 3118
	public static bool chanceToMineRandomRock_4_purchased;

	// Token: 0x04000C2F RID: 3119
	public static bool spawnPickaxeEverySecond_1_purchased;

	// Token: 0x04000C30 RID: 3120
	public static bool spawnPickaxeEverySecond_2_purchased;

	// Token: 0x04000C31 RID: 3121
	public static bool spawnPickaxeEverySecond_3_purchased;

	// Token: 0x04000C32 RID: 3122
	public static bool moreTime_1_purchased;

	// Token: 0x04000C33 RID: 3123
	public static bool moreTime_2_purchased;

	// Token: 0x04000C34 RID: 3124
	public static bool moreTime_3_purchased;

	// Token: 0x04000C35 RID: 3125
	public static bool moreTime_4_purchased;

	// Token: 0x04000C36 RID: 3126
	public static bool chanceToAdd1SecondEverySecond_purchased;

	// Token: 0x04000C37 RID: 3127
	public static bool chanceAdd1SecondEveryRockMined_purchased;

	// Token: 0x04000C38 RID: 3128
	public static bool doubleXpGoldChance_1_purchased;

	// Token: 0x04000C39 RID: 3129
	public static bool doubleXpGoldChance_2_purchased;

	// Token: 0x04000C3A RID: 3130
	public static bool doubleXpGoldChance_3_purchased;

	// Token: 0x04000C3B RID: 3131
	public static bool doubleXpGoldChance_4_purchased;

	// Token: 0x04000C3C RID: 3132
	public static bool doubleXpGoldChance_5_purchased;

	// Token: 0x04000C3D RID: 3133
	public static bool lightningBeamChanceS_1_purchased;

	// Token: 0x04000C3E RID: 3134
	public static bool lightningBeamChanceS_2_purchased;

	// Token: 0x04000C3F RID: 3135
	public static bool lightningBeamChancePH_1_purchased;

	// Token: 0x04000C40 RID: 3136
	public static bool lightningBeamChancePH_2_purchased;

	// Token: 0x04000C41 RID: 3137
	public static bool lightningBeamSpawnAnotherOneChance_purchased;

	// Token: 0x04000C42 RID: 3138
	public static bool lightningBeamDamage_purchased;

	// Token: 0x04000C43 RID: 3139
	public static bool lightningBeamSize_purchased;

	// Token: 0x04000C44 RID: 3140
	public static bool lightningSplashes_purchased;

	// Token: 0x04000C45 RID: 3141
	public static bool lightningBeamSpawnRock_purchased;

	// Token: 0x04000C46 RID: 3142
	public static bool lightningBeamExplosion_purchased;

	// Token: 0x04000C47 RID: 3143
	public static bool lightningBeamAddTime_purchased;

	// Token: 0x04000C48 RID: 3144
	public static bool dynamiteChance_1_purchased;

	// Token: 0x04000C49 RID: 3145
	public static bool dynamiteChance_2_purchased;

	// Token: 0x04000C4A RID: 3146
	public static bool dynamiteSpawn2SmallChance_purchased;

	// Token: 0x04000C4B RID: 3147
	public static bool dynamiteExplosionSize_purchased;

	// Token: 0x04000C4C RID: 3148
	public static bool dynamiteDamage_purchased;

	// Token: 0x04000C4D RID: 3149
	public static bool dynamiteExplosionSpawnRock_purchased;

	// Token: 0x04000C4E RID: 3150
	public static bool dynamiteExplosionAddTimeChance_purchased;

	// Token: 0x04000C4F RID: 3151
	public static bool dynamiteExplosionSpawnLightning_purchased;

	// Token: 0x04000C50 RID: 3152
	public static bool plazmaBallSpawn_1_purchased;

	// Token: 0x04000C51 RID: 3153
	public static bool plazmaBallSpawn_2_purchased;

	// Token: 0x04000C52 RID: 3154
	public static bool plazmaBallTime_purchased;

	// Token: 0x04000C53 RID: 3155
	public static bool plazmaBallSize_purchased;

	// Token: 0x04000C54 RID: 3156
	public static bool plazmaBallExplosionChance_purchased;

	// Token: 0x04000C55 RID: 3157
	public static bool plazmaBallSpawnSmallChance_purchased;

	// Token: 0x04000C56 RID: 3158
	public static bool plazmaBallDamage_purchased;

	// Token: 0x04000C57 RID: 3159
	public static bool plazmaBallSpawnPickaxeChance_purchased;

	// Token: 0x04000C58 RID: 3160
	public static bool allProjectileDoubleDamageChance_purchased;

	// Token: 0x04000C59 RID: 3161
	public static bool allProjectileTriggerChance_purchased;

	// Token: 0x04000C5A RID: 3162
	public static bool pickaxeDoubleDamageChance_1_purchased;

	// Token: 0x04000C5B RID: 3163
	public static bool pickaxeDoubleDamageChance_2_purchased;

	// Token: 0x04000C5C RID: 3164
	public static bool intaMineChance_1_purchased;

	// Token: 0x04000C5D RID: 3165
	public static bool intaMineChance_2_purchased;

	// Token: 0x04000C5E RID: 3166
	public static bool increaseSpawnChanceAllRocks_purchased;

	// Token: 0x04000C5F RID: 3167
	public static bool craft2Material_purchased;

	// Token: 0x04000C60 RID: 3168
	public static bool finalUpgrade_purchased;

	// Token: 0x04000C61 RID: 3169
	public static int moreXP_1_purchaseCount;

	// Token: 0x04000C62 RID: 3170
	public static int moreXP_2_purchaseCount;

	// Token: 0x04000C63 RID: 3171
	public static int moreXP_3_purchaseCount;

	// Token: 0x04000C64 RID: 3172
	public static int moreXP_4_purchaseCount;

	// Token: 0x04000C65 RID: 3173
	public static int moreXP_5_purchaseCount;

	// Token: 0x04000C66 RID: 3174
	public static int moreXP_6_purchaseCount;

	// Token: 0x04000C67 RID: 3175
	public static int moreXP_7_purchaseCount;

	// Token: 0x04000C68 RID: 3176
	public static int moreXP_8_purchaseCount;

	// Token: 0x04000C69 RID: 3177
	public static int talentPointsPerXlevel_1_purchaseCount;

	// Token: 0x04000C6A RID: 3178
	public static int talentPointsPerXlevel_2_purchaseCount;

	// Token: 0x04000C6B RID: 3179
	public static int talentPointsPerXlevel_3_purchaseCount;

	// Token: 0x04000C6C RID: 3180
	public static int spawnMoreRocks_1_purchaseCount;

	// Token: 0x04000C6D RID: 3181
	public static int spawnMoreRocks_2_purchaseCount;

	// Token: 0x04000C6E RID: 3182
	public static int spawnMoreRocks_3_purchaseCount;

	// Token: 0x04000C6F RID: 3183
	public static int spawnMoreRocks_4_purchaseCount;

	// Token: 0x04000C70 RID: 3184
	public static int spawnMoreRocks_5_purchaseCount;

	// Token: 0x04000C71 RID: 3185
	public static int spawnMoreRocks_6_purchaseCount;

	// Token: 0x04000C72 RID: 3186
	public static int spawnMoreRocks_7_purchaseCount;

	// Token: 0x04000C73 RID: 3187
	public static int spawnMoreRocks_8_purchaseCount;

	// Token: 0x04000C74 RID: 3188
	public static int spawnMoreRocks_9_purchaseCount;

	// Token: 0x04000C75 RID: 3189
	public static int moreMeterialsFromRock_1_purchaseCount;

	// Token: 0x04000C76 RID: 3190
	public static int moreMeterialsFromRock_2_purchaseCount;

	// Token: 0x04000C77 RID: 3191
	public static int moreMeterialsFromRock_3_purchaseCount;

	// Token: 0x04000C78 RID: 3192
	public static int moreMeterialsFromRock_4_purchaseCount;

	// Token: 0x04000C79 RID: 3193
	public static int moreMeterialsFromRock_5_purchaseCount;

	// Token: 0x04000C7A RID: 3194
	public static int marterialsWorthMore_1_purchaseCount;

	// Token: 0x04000C7B RID: 3195
	public static int marterialsWorthMore_2_purchaseCount;

	// Token: 0x04000C7C RID: 3196
	public static int marterialsWorthMore_3_purchaseCount;

	// Token: 0x04000C7D RID: 3197
	public static int marterialsWorthMore_4_purchaseCount;

	// Token: 0x04000C7E RID: 3198
	public static int marterialsWorthMore_5_purchaseCount;

	// Token: 0x04000C7F RID: 3199
	public static int marterialsWorthMore_6_purchaseCount;

	// Token: 0x04000C80 RID: 3200
	public static int marterialsWorthMore_7_purchaseCount;

	// Token: 0x04000C81 RID: 3201
	public static int marterialsWorthMore_8_purchaseCount;

	// Token: 0x04000C82 RID: 3202
	public static int goldChunk_1_purchaseCount;

	// Token: 0x04000C83 RID: 3203
	public static int goldChunk_2_purchaseCount;

	// Token: 0x04000C84 RID: 3204
	public static int goldChunk_3_purchaseCount;

	// Token: 0x04000C85 RID: 3205
	public static int goldChunk_4_purchaseCount;

	// Token: 0x04000C86 RID: 3206
	public static int goldChunk_5_purchaseCount;

	// Token: 0x04000C87 RID: 3207
	public static int fullGold_1_purchaseCount;

	// Token: 0x04000C88 RID: 3208
	public static int fullGold_2_purchaseCount;

	// Token: 0x04000C89 RID: 3209
	public static int fullGold_3_purchaseCount;

	// Token: 0x04000C8A RID: 3210
	public static int spawnCopper_purchaseCount;

	// Token: 0x04000C8B RID: 3211
	public static int copperChunk_1_purchaseCount;

	// Token: 0x04000C8C RID: 3212
	public static int copperChunk_2_purchaseCount;

	// Token: 0x04000C8D RID: 3213
	public static int copperChunk_3_purchaseCount;

	// Token: 0x04000C8E RID: 3214
	public static int fullCopper_1_purchaseCount;

	// Token: 0x04000C8F RID: 3215
	public static int fullCopper_2_purchaseCount;

	// Token: 0x04000C90 RID: 3216
	public static int fullCopper_3_purchaseCount;

	// Token: 0x04000C91 RID: 3217
	public static int spawnIron_purchaseCount;

	// Token: 0x04000C92 RID: 3218
	public static int ironChunk_1_purchaseCount;

	// Token: 0x04000C93 RID: 3219
	public static int ironChunk_2_purchaseCount;

	// Token: 0x04000C94 RID: 3220
	public static int fullIron_1_purchaseCount;

	// Token: 0x04000C95 RID: 3221
	public static int fullIron_2_purchaseCount;

	// Token: 0x04000C96 RID: 3222
	public static int cobaltSpawn_purchaseCount;

	// Token: 0x04000C97 RID: 3223
	public static int cobaltChunk_1_purchaseCount;

	// Token: 0x04000C98 RID: 3224
	public static int fullCobalt_1_purchaseCount;

	// Token: 0x04000C99 RID: 3225
	public static int uraniumSpawn_purchaseCount;

	// Token: 0x04000C9A RID: 3226
	public static int uraniumChunk_1_purchaseCount;

	// Token: 0x04000C9B RID: 3227
	public static int fullUranium_1_purchaseCount;

	// Token: 0x04000C9C RID: 3228
	public static int ismiumSpawn_purchaseCount;

	// Token: 0x04000C9D RID: 3229
	public static int ismiumChunk_1_purchaseCount;

	// Token: 0x04000C9E RID: 3230
	public static int fullIsmium_1_purchaseCount;

	// Token: 0x04000C9F RID: 3231
	public static int iridiumSpawn_purchaseCount;

	// Token: 0x04000CA0 RID: 3232
	public static int iridiumChunk_1_purchaseCount;

	// Token: 0x04000CA1 RID: 3233
	public static int fullIridium_1_purchaseCount;

	// Token: 0x04000CA2 RID: 3234
	public static int painiteSpawn_purchaseCount;

	// Token: 0x04000CA3 RID: 3235
	public static int painiteChunk_1_purchaseCount;

	// Token: 0x04000CA4 RID: 3236
	public static int fullPainite_1_purchaseCount;

	// Token: 0x04000CA5 RID: 3237
	public static int improvedPickaxe_1_purchaseCount;

	// Token: 0x04000CA6 RID: 3238
	public static int improvedPickaxe_2_purchaseCount;

	// Token: 0x04000CA7 RID: 3239
	public static int improvedPickaxe_3_purchaseCount;

	// Token: 0x04000CA8 RID: 3240
	public static int improvedPickaxe_4_purchaseCount;

	// Token: 0x04000CA9 RID: 3241
	public static int improvedPickaxe_5_purchaseCount;

	// Token: 0x04000CAA RID: 3242
	public static int improvedPickaxe_6_purchaseCount;

	// Token: 0x04000CAB RID: 3243
	public static int biggerMiningErea_1_purchaseCount;

	// Token: 0x04000CAC RID: 3244
	public static int biggerMiningErea_2_purchaseCount;

	// Token: 0x04000CAD RID: 3245
	public static int biggerMiningErea_3_purchaseCount;

	// Token: 0x04000CAE RID: 3246
	public static int biggerMiningErea_4_purchaseCount;

	// Token: 0x04000CAF RID: 3247
	public static int shootCircleChance_purchaseCount;

	// Token: 0x04000CB0 RID: 3248
	public static int increaseAndDecreaseMinignErea_purchaseCount;

	// Token: 0x04000CB1 RID: 3249
	public static int spawnRockEveryXrock_1_purchaseCount;

	// Token: 0x04000CB2 RID: 3250
	public static int spawnRockEveryXrock_2_purchaseCount;

	// Token: 0x04000CB3 RID: 3251
	public static int spawnRockEveryXrock_3_purchaseCount;

	// Token: 0x04000CB4 RID: 3252
	public static int spawnXRockEveryXSecond_1_purchaseCount;

	// Token: 0x04000CB5 RID: 3253
	public static int spawnXRockEveryXSecond_2_purchaseCount;

	// Token: 0x04000CB6 RID: 3254
	public static int spawnXRockEveryXSecond_3_purchaseCount;

	// Token: 0x04000CB7 RID: 3255
	public static int chanceToSpawnRockWhenMined_1_purchaseCount;

	// Token: 0x04000CB8 RID: 3256
	public static int chanceToSpawnRockWhenMined_2_purchaseCount;

	// Token: 0x04000CB9 RID: 3257
	public static int chanceToSpawnRockWhenMined_3_purchaseCount;

	// Token: 0x04000CBA RID: 3258
	public static int chanceToSpawnRockWhenMined_4_purchaseCount;

	// Token: 0x04000CBB RID: 3259
	public static int chanceToSpawnRockWhenMined_5_purchaseCount;

	// Token: 0x04000CBC RID: 3260
	public static int chanceToSpawnRockWhenMined_6_purchaseCount;

	// Token: 0x04000CBD RID: 3261
	public static int chanceToMineRandomRock_1_purchaseCount;

	// Token: 0x04000CBE RID: 3262
	public static int chanceToMineRandomRock_2_purchaseCount;

	// Token: 0x04000CBF RID: 3263
	public static int chanceToMineRandomRock_3_purchaseCount;

	// Token: 0x04000CC0 RID: 3264
	public static int chanceToMineRandomRock_4_purchaseCount;

	// Token: 0x04000CC1 RID: 3265
	public static int spawnPickaxeEverySecond_1_purchaseCount;

	// Token: 0x04000CC2 RID: 3266
	public static int spawnPickaxeEverySecond_2_purchaseCount;

	// Token: 0x04000CC3 RID: 3267
	public static int spawnPickaxeEverySecond_3_purchaseCount;

	// Token: 0x04000CC4 RID: 3268
	public static int moreTime_1_purchaseCount;

	// Token: 0x04000CC5 RID: 3269
	public static int moreTime_2_purchaseCount;

	// Token: 0x04000CC6 RID: 3270
	public static int moreTime_3_purchaseCount;

	// Token: 0x04000CC7 RID: 3271
	public static int moreTime_4_purchaseCount;

	// Token: 0x04000CC8 RID: 3272
	public static int chanceToAdd1SecondEverySecond_purchaseCount;

	// Token: 0x04000CC9 RID: 3273
	public static int chanceAdd1SecondEveryRockMined_purchaseCount;

	// Token: 0x04000CCA RID: 3274
	public static int doubleXpGoldChance_1_purchaseCount;

	// Token: 0x04000CCB RID: 3275
	public static int doubleXpGoldChance_2_purchaseCount;

	// Token: 0x04000CCC RID: 3276
	public static int doubleXpGoldChance_3_purchaseCount;

	// Token: 0x04000CCD RID: 3277
	public static int doubleXpGoldChance_4_purchaseCount;

	// Token: 0x04000CCE RID: 3278
	public static int doubleXpGoldChance_5_purchaseCount;

	// Token: 0x04000CCF RID: 3279
	public static int lightningBeamChanceS_1_purchaseCount;

	// Token: 0x04000CD0 RID: 3280
	public static int lightningBeamChanceS_2_purchaseCount;

	// Token: 0x04000CD1 RID: 3281
	public static int lightningBeamChancePH_1_purchaseCount;

	// Token: 0x04000CD2 RID: 3282
	public static int lightningBeamChancePH_2_purchaseCount;

	// Token: 0x04000CD3 RID: 3283
	public static int lightningBeamSpawnAnotherOneChance_purchaseCount;

	// Token: 0x04000CD4 RID: 3284
	public static int lightningBeamDamage_purchaseCount;

	// Token: 0x04000CD5 RID: 3285
	public static int lightningBeamSize_purchaseCount;

	// Token: 0x04000CD6 RID: 3286
	public static int lightningSplashes_purchaseCount;

	// Token: 0x04000CD7 RID: 3287
	public static int lightningBeamSpawnRock_purchaseCount;

	// Token: 0x04000CD8 RID: 3288
	public static int lightningBeamExplosion_purchaseCount;

	// Token: 0x04000CD9 RID: 3289
	public static int lightningBeamAddTime_purchaseCount;

	// Token: 0x04000CDA RID: 3290
	public static int dynamiteChance_1_purchaseCount;

	// Token: 0x04000CDB RID: 3291
	public static int dynamiteChance_2_purchaseCount;

	// Token: 0x04000CDC RID: 3292
	public static int dynamiteSpawn2SmallChance_purchaseCount;

	// Token: 0x04000CDD RID: 3293
	public static int dynamiteExplosionSize_purchaseCount;

	// Token: 0x04000CDE RID: 3294
	public static int dynamiteDamage_purchaseCount;

	// Token: 0x04000CDF RID: 3295
	public static int dynamiteExplosionSpawnRock_purchaseCount;

	// Token: 0x04000CE0 RID: 3296
	public static int dynamiteExplosionAddTimeChance_purchaseCount;

	// Token: 0x04000CE1 RID: 3297
	public static int dynamiteExplosionSpawnLightning_purchaseCount;

	// Token: 0x04000CE2 RID: 3298
	public static int plazmaBallSpawn_1_purchaseCount;

	// Token: 0x04000CE3 RID: 3299
	public static int plazmaBallSpawn_2_purchaseCount;

	// Token: 0x04000CE4 RID: 3300
	public static int plazmaBallTime_purchaseCount;

	// Token: 0x04000CE5 RID: 3301
	public static int plazmaBallSize_purchaseCount;

	// Token: 0x04000CE6 RID: 3302
	public static int plazmaBallExplosionChance_purchaseCount;

	// Token: 0x04000CE7 RID: 3303
	public static int plazmaBallSpawnSmallChance_purchaseCount;

	// Token: 0x04000CE8 RID: 3304
	public static int plazmaBallDamage_purchaseCount;

	// Token: 0x04000CE9 RID: 3305
	public static int plazmaBallSpawnPickaxeChance_purchaseCount;

	// Token: 0x04000CEA RID: 3306
	public static int allProjectileDoubleDamageChance_purchaseCount;

	// Token: 0x04000CEB RID: 3307
	public static int allProjectileTriggerChance_purchaseCount;

	// Token: 0x04000CEC RID: 3308
	public static int pickaxeDoubleDamageChance_1_purchaseCount;

	// Token: 0x04000CED RID: 3309
	public static int pickaxeDoubleDamageChance_2_purchaseCount;

	// Token: 0x04000CEE RID: 3310
	public static int intaMineChance_1_purchaseCount;

	// Token: 0x04000CEF RID: 3311
	public static int intaMineChance_2_purchaseCount;

	// Token: 0x04000CF0 RID: 3312
	public static int increaseSpawnChanceAllRocks_purchaseCount;

	// Token: 0x04000CF1 RID: 3313
	public static int craft2Material_purchaseCount;

	// Token: 0x04000CF2 RID: 3314
	public static int finalUpgrade_purchaseCount;

	// Token: 0x04000CF3 RID: 3315
	public GameObject moreXP_1_plus;

	// Token: 0x04000CF4 RID: 3316
	public GameObject moreXP_2_plus;

	// Token: 0x04000CF5 RID: 3317
	public GameObject moreXP_3_plus;

	// Token: 0x04000CF6 RID: 3318
	public GameObject moreXP_4_plus;

	// Token: 0x04000CF7 RID: 3319
	public GameObject moreXP_5_plus;

	// Token: 0x04000CF8 RID: 3320
	public GameObject moreXP_6_plus;

	// Token: 0x04000CF9 RID: 3321
	public GameObject moreXP_7_plus;

	// Token: 0x04000CFA RID: 3322
	public GameObject moreXP_8_plus;

	// Token: 0x04000CFB RID: 3323
	public GameObject talentPointsPerXlevel_1_plus;

	// Token: 0x04000CFC RID: 3324
	public GameObject talentPointsPerXlevel_2_plus;

	// Token: 0x04000CFD RID: 3325
	public GameObject talentPointsPerXlevel_3_plus;

	// Token: 0x04000CFE RID: 3326
	public GameObject lightningBeamChanceS_1_plus;

	// Token: 0x04000CFF RID: 3327
	public GameObject lightningBeamChanceS_2_plus;

	// Token: 0x04000D00 RID: 3328
	public GameObject lightningBeamChancePH_1_plus;

	// Token: 0x04000D01 RID: 3329
	public GameObject lightningBeamChancePH_2_plus;

	// Token: 0x04000D02 RID: 3330
	public GameObject lightningBeamSpawnAnotherOneChance_plus;

	// Token: 0x04000D03 RID: 3331
	public GameObject lightningBeamDamage_plus;

	// Token: 0x04000D04 RID: 3332
	public GameObject lightningBeamSize_plus;

	// Token: 0x04000D05 RID: 3333
	public GameObject lightningSplashes_plus;

	// Token: 0x04000D06 RID: 3334
	public GameObject lightningBeamSpawnRock_plus;

	// Token: 0x04000D07 RID: 3335
	public GameObject lightningBeamExplosion_plus;

	// Token: 0x04000D08 RID: 3336
	public GameObject lightningBeamAddTime_plus;

	// Token: 0x04000D09 RID: 3337
	public GameObject dynamiteChance_1_plus;

	// Token: 0x04000D0A RID: 3338
	public GameObject dynamiteChance_2_plus;

	// Token: 0x04000D0B RID: 3339
	public GameObject dynamiteSpawn2SmallChance_plus;

	// Token: 0x04000D0C RID: 3340
	public GameObject dynamiteExplosionSize_plus;

	// Token: 0x04000D0D RID: 3341
	public GameObject dynamiteDamage_plus;

	// Token: 0x04000D0E RID: 3342
	public GameObject dynamiteExplosionSpawnRock_plus;

	// Token: 0x04000D0F RID: 3343
	public GameObject dynamiteExplosionAddTimeChance_plus;

	// Token: 0x04000D10 RID: 3344
	public GameObject dynamiteExplosionSpawnLightning_plus;

	// Token: 0x04000D11 RID: 3345
	public GameObject plazmaBallSpawn_1_plus;

	// Token: 0x04000D12 RID: 3346
	public GameObject plazmaBallSpawn_2_plus;

	// Token: 0x04000D13 RID: 3347
	public GameObject plazmaBallTime_plus;

	// Token: 0x04000D14 RID: 3348
	public GameObject plazmaBallSize_plus;

	// Token: 0x04000D15 RID: 3349
	public GameObject plazmaBallExplosionChance_plus;

	// Token: 0x04000D16 RID: 3350
	public GameObject plazmaBallSpawnSmallChance_plus;

	// Token: 0x04000D17 RID: 3351
	public GameObject plazmaBallDamage_plus;

	// Token: 0x04000D18 RID: 3352
	public GameObject plazmaBallSpawnPickaxeChance_plus;

	// Token: 0x04000D19 RID: 3353
	public GameObject spawnMoreRocks_1_plus;

	// Token: 0x04000D1A RID: 3354
	public GameObject spawnMoreRocks_2_plus;

	// Token: 0x04000D1B RID: 3355
	public GameObject spawnMoreRocks_3_plus;

	// Token: 0x04000D1C RID: 3356
	public GameObject spawnMoreRocks_4_plus;

	// Token: 0x04000D1D RID: 3357
	public GameObject spawnMoreRocks_5_plus;

	// Token: 0x04000D1E RID: 3358
	public GameObject spawnMoreRocks_6_plus;

	// Token: 0x04000D1F RID: 3359
	public GameObject spawnMoreRocks_7_plus;

	// Token: 0x04000D20 RID: 3360
	public GameObject spawnMoreRocks_8_plus;

	// Token: 0x04000D21 RID: 3361
	public GameObject spawnMoreRocks_9_plus;

	// Token: 0x04000D22 RID: 3362
	public GameObject moreMeterialsFromRock_1_plus;

	// Token: 0x04000D23 RID: 3363
	public GameObject moreMeterialsFromRock_2_plus;

	// Token: 0x04000D24 RID: 3364
	public GameObject moreMeterialsFromRock_3_plus;

	// Token: 0x04000D25 RID: 3365
	public GameObject moreMeterialsFromRock_4_plus;

	// Token: 0x04000D26 RID: 3366
	public GameObject moreMeterialsFromRock_5_plus;

	// Token: 0x04000D27 RID: 3367
	public GameObject marterialsWorthMore_1_plus;

	// Token: 0x04000D28 RID: 3368
	public GameObject marterialsWorthMore_2_plus;

	// Token: 0x04000D29 RID: 3369
	public GameObject marterialsWorthMore_3_plus;

	// Token: 0x04000D2A RID: 3370
	public GameObject marterialsWorthMore_4_plus;

	// Token: 0x04000D2B RID: 3371
	public GameObject marterialsWorthMore_5_plus;

	// Token: 0x04000D2C RID: 3372
	public GameObject marterialsWorthMore_6_plus;

	// Token: 0x04000D2D RID: 3373
	public GameObject marterialsWorthMore_7_plus;

	// Token: 0x04000D2E RID: 3374
	public GameObject marterialsWorthMore_8_plus;

	// Token: 0x04000D2F RID: 3375
	public GameObject goldChunk_1_plus;

	// Token: 0x04000D30 RID: 3376
	public GameObject goldChunk_2_plus;

	// Token: 0x04000D31 RID: 3377
	public GameObject goldChunk_3_plus;

	// Token: 0x04000D32 RID: 3378
	public GameObject goldChunk_4_plus;

	// Token: 0x04000D33 RID: 3379
	public GameObject goldChunk_5__plus;

	// Token: 0x04000D34 RID: 3380
	public GameObject fullGold_1_plus;

	// Token: 0x04000D35 RID: 3381
	public GameObject fullGold_2_plus;

	// Token: 0x04000D36 RID: 3382
	public GameObject fullGold_3_plus;

	// Token: 0x04000D37 RID: 3383
	public GameObject spawnCopper_plus;

	// Token: 0x04000D38 RID: 3384
	public GameObject copperChunk_1_plus;

	// Token: 0x04000D39 RID: 3385
	public GameObject copperChunk_2_plus;

	// Token: 0x04000D3A RID: 3386
	public GameObject copperChunk_3_plus;

	// Token: 0x04000D3B RID: 3387
	public GameObject fullCopper_1_plus;

	// Token: 0x04000D3C RID: 3388
	public GameObject fullCopper_2_plus;

	// Token: 0x04000D3D RID: 3389
	public GameObject fullCopper_3_plus;

	// Token: 0x04000D3E RID: 3390
	public GameObject spawnIron_plus;

	// Token: 0x04000D3F RID: 3391
	public GameObject ironChunk_1_plus;

	// Token: 0x04000D40 RID: 3392
	public GameObject ironChunk_2_plus;

	// Token: 0x04000D41 RID: 3393
	public GameObject fullIron_1_plus;

	// Token: 0x04000D42 RID: 3394
	public GameObject fullIron_2_plus;

	// Token: 0x04000D43 RID: 3395
	public GameObject cobaltSpawn_plus;

	// Token: 0x04000D44 RID: 3396
	public GameObject cobaltChunk_1_plus;

	// Token: 0x04000D45 RID: 3397
	public GameObject fullCobalt_1_plus;

	// Token: 0x04000D46 RID: 3398
	public GameObject uraniumSpawn_plus;

	// Token: 0x04000D47 RID: 3399
	public GameObject uraniumChunk_1_plus;

	// Token: 0x04000D48 RID: 3400
	public GameObject fullUranium_1_plus;

	// Token: 0x04000D49 RID: 3401
	public GameObject ismiumSpawn_plus;

	// Token: 0x04000D4A RID: 3402
	public GameObject ismiumChunk_1_plus;

	// Token: 0x04000D4B RID: 3403
	public GameObject fullIsmium_1_plus;

	// Token: 0x04000D4C RID: 3404
	public GameObject iridiumSpawn_plus;

	// Token: 0x04000D4D RID: 3405
	public GameObject iridiumChunk_1_plus;

	// Token: 0x04000D4E RID: 3406
	public GameObject fullIridium_1_plus;

	// Token: 0x04000D4F RID: 3407
	public GameObject painiteSpawn_plus;

	// Token: 0x04000D50 RID: 3408
	public GameObject painiteChunk_1_plus;

	// Token: 0x04000D51 RID: 3409
	public GameObject fullPainite_1_plus;

	// Token: 0x04000D52 RID: 3410
	public GameObject improvedPickaxe_1_plus;

	// Token: 0x04000D53 RID: 3411
	public GameObject improvedPickaxe_2_plus;

	// Token: 0x04000D54 RID: 3412
	public GameObject improvedPickaxe_3_plus;

	// Token: 0x04000D55 RID: 3413
	public GameObject improvedPickaxe_4_plus;

	// Token: 0x04000D56 RID: 3414
	public GameObject improvedPickaxe_5_plus;

	// Token: 0x04000D57 RID: 3415
	public GameObject improvedPickaxe_6_plus;

	// Token: 0x04000D58 RID: 3416
	public GameObject biggerMiningErea_1_plus;

	// Token: 0x04000D59 RID: 3417
	public GameObject biggerMiningErea_2_plus;

	// Token: 0x04000D5A RID: 3418
	public GameObject biggerMiningErea_3_plus;

	// Token: 0x04000D5B RID: 3419
	public GameObject biggerMiningErea_4_plus;

	// Token: 0x04000D5C RID: 3420
	public GameObject shootCircleChance_plus;

	// Token: 0x04000D5D RID: 3421
	public GameObject increaseAndDecreaseMinignErea_plus;

	// Token: 0x04000D5E RID: 3422
	public GameObject spawnRockEveryXrock_1_plus;

	// Token: 0x04000D5F RID: 3423
	public GameObject spawnRockEveryXrock_2_plus;

	// Token: 0x04000D60 RID: 3424
	public GameObject spawnRockEveryXrock_3_plus;

	// Token: 0x04000D61 RID: 3425
	public GameObject spawnXRockEveryXSecond_1_plus;

	// Token: 0x04000D62 RID: 3426
	public GameObject spawnXRockEveryXSecond_2_plus;

	// Token: 0x04000D63 RID: 3427
	public GameObject spawnXRockEveryXSecond_3_plus;

	// Token: 0x04000D64 RID: 3428
	public GameObject chanceToSpawnRockWhenMined_1_plus;

	// Token: 0x04000D65 RID: 3429
	public GameObject chanceToSpawnRockWhenMined_2_plus;

	// Token: 0x04000D66 RID: 3430
	public GameObject chanceToSpawnRockWhenMined_3_plus;

	// Token: 0x04000D67 RID: 3431
	public GameObject chanceToSpawnRockWhenMined_4_plus;

	// Token: 0x04000D68 RID: 3432
	public GameObject chanceToSpawnRockWhenMined_5_plus;

	// Token: 0x04000D69 RID: 3433
	public GameObject chanceToSpawnRockWhenMined_6_plus;

	// Token: 0x04000D6A RID: 3434
	public GameObject chanceToMineRandomRock_1_plus;

	// Token: 0x04000D6B RID: 3435
	public GameObject chanceToMineRandomRock_2_plus;

	// Token: 0x04000D6C RID: 3436
	public GameObject chanceToMineRandomRock_3_plus;

	// Token: 0x04000D6D RID: 3437
	public GameObject chanceToMineRandomRock_4_plus;

	// Token: 0x04000D6E RID: 3438
	public GameObject spawnPickaxeEverySecond_1_plus;

	// Token: 0x04000D6F RID: 3439
	public GameObject spawnPickaxeEverySecond_2_plus;

	// Token: 0x04000D70 RID: 3440
	public GameObject spawnPickaxeEverySecond_3_plus;

	// Token: 0x04000D71 RID: 3441
	public GameObject moreTime_1_plus;

	// Token: 0x04000D72 RID: 3442
	public GameObject moreTime_2_plus;

	// Token: 0x04000D73 RID: 3443
	public GameObject moreTime_3_plus;

	// Token: 0x04000D74 RID: 3444
	public GameObject moreTime_4_plus;

	// Token: 0x04000D75 RID: 3445
	public GameObject chanceToAdd1SecondEverySecond_plus;

	// Token: 0x04000D76 RID: 3446
	public GameObject chanceAdd1SecondEveryRockMined_plus;

	// Token: 0x04000D77 RID: 3447
	public GameObject doubleXpGoldChance_1_plus;

	// Token: 0x04000D78 RID: 3448
	public GameObject doubleXpGoldChance_2_plus;

	// Token: 0x04000D79 RID: 3449
	public GameObject doubleXpGoldChance_3_plus;

	// Token: 0x04000D7A RID: 3450
	public GameObject doubleXpGoldChance_4_plus;

	// Token: 0x04000D7B RID: 3451
	public GameObject doubleXpGoldChance_5_plus;

	// Token: 0x04000D7C RID: 3452
	public GameObject allProjectileDoubleDamageChance_plus;

	// Token: 0x04000D7D RID: 3453
	public GameObject allProjectileTriggerChance_plus;

	// Token: 0x04000D7E RID: 3454
	public GameObject pickaxeDoubleDamageChance_1_plus;

	// Token: 0x04000D7F RID: 3455
	public GameObject pickaxeDoubleDamageChance_2_plus;

	// Token: 0x04000D80 RID: 3456
	public GameObject intaMineChance_1_plus;

	// Token: 0x04000D81 RID: 3457
	public GameObject intaMineChance_2_plus;

	// Token: 0x04000D82 RID: 3458
	public GameObject increaseSpawnChanceAllRocks_plus;

	// Token: 0x04000D83 RID: 3459
	public GameObject craft2Material_plus;

	// Token: 0x04000D84 RID: 3460
	public GameObject finalUpgrade_plus;

	// Token: 0x04000D85 RID: 3461
	public static int totalMaterialRocksSpawning;

	// Token: 0x04000D86 RID: 3462
	public static float circleShootChance;

	// Token: 0x04000D87 RID: 3463
	public static float chanceToAdd1SecEverySec;

	// Token: 0x04000D88 RID: 3464
	public static float chanceToAdd1SecEveryRockMined;

	// Token: 0x04000D89 RID: 3465
	public static float triggerAnotherLighntingChance;

	// Token: 0x04000D8A RID: 3466
	public static float lightningSplashChance;

	// Token: 0x04000D8B RID: 3467
	public static float lightningSparkDamage;

	// Token: 0x04000D8C RID: 3468
	public static float lightningSpawnRockChance;

	// Token: 0x04000D8D RID: 3469
	public static float lightningSpawnExplosionChance;

	// Token: 0x04000D8E RID: 3470
	public static float lightningAddTimeChance;

	// Token: 0x04000D8F RID: 3471
	public static float spawn2DynamiteChance;

	// Token: 0x04000D90 RID: 3472
	public static float chanceToSpawnRockFromExplosion;

	// Token: 0x04000D91 RID: 3473
	public static float explosionAdd1SecondChance;

	// Token: 0x04000D92 RID: 3474
	public static float explosionChanceToSpawnLightning;

	// Token: 0x04000D93 RID: 3475
	public static float plazmaballExplosionChance;

	// Token: 0x04000D94 RID: 3476
	public static float plazmaBallSpawnSmallBallChance;

	// Token: 0x04000D95 RID: 3477
	public static float plazmaBallChanceToSpawnPickaxe;

	// Token: 0x04000D96 RID: 3478
	public static float allRockSpawnChanceIncrease;

	// Token: 0x04000D97 RID: 3479
	public static float allProjectileDoubleDamageIncrease;

	// Token: 0x04000D98 RID: 3480
	public static float allProjcetileTriggerChance;

	// Token: 0x04000D99 RID: 3481
	public static int totalSkillTreeUpgradesPurchased;

	// Token: 0x04000D9A RID: 3482
	public static int totalUpgradesFullyPurchased;

	// Token: 0x04000D9B RID: 3483
	public static int mineSessionTime;

	// Token: 0x04000D9C RID: 3484
	public static int totalRocksToSpawn;

	// Token: 0x04000D9D RID: 3485
	public static int extraTalentPointPerLevel;

	// Token: 0x04000D9E RID: 3486
	public static float goldRockChance;

	// Token: 0x04000D9F RID: 3487
	public static float fullGoldRockChance;

	// Token: 0x04000DA0 RID: 3488
	public static float copperRockChance;

	// Token: 0x04000DA1 RID: 3489
	public static float fullCopperRockChance;

	// Token: 0x04000DA2 RID: 3490
	public static float ironRockChance;

	// Token: 0x04000DA3 RID: 3491
	public static float fullIronRockChance;

	// Token: 0x04000DA4 RID: 3492
	public static float cobaltRockChance;

	// Token: 0x04000DA5 RID: 3493
	public static float fullCobaltRockChance;

	// Token: 0x04000DA6 RID: 3494
	public static float uraniumRockChance;

	// Token: 0x04000DA7 RID: 3495
	public static float fullUraniumRockChance;

	// Token: 0x04000DA8 RID: 3496
	public static float ismiumRockChance;

	// Token: 0x04000DA9 RID: 3497
	public static float fullIsmiumRockChance;

	// Token: 0x04000DAA RID: 3498
	public static float iridiumRockChance;

	// Token: 0x04000DAB RID: 3499
	public static float fullIridiumRockChance;

	// Token: 0x04000DAC RID: 3500
	public static float painiteRockChance;

	// Token: 0x04000DAD RID: 3501
	public static float fullPainiteRockChance;

	// Token: 0x04000DAE RID: 3502
	public static float improvedPickaxeStrength;

	// Token: 0x04000DAF RID: 3503
	public static float reducePickaxeMineTime;

	// Token: 0x04000DB0 RID: 3504
	public static float miningAreaSize;

	// Token: 0x04000DB1 RID: 3505
	public static float spawnRockEveryXRock;

	// Token: 0x04000DB2 RID: 3506
	public static float spawnXRockEveryXSecond;

	// Token: 0x04000DB3 RID: 3507
	public static float chanceToSpawnRockWhenMined;

	// Token: 0x04000DB4 RID: 3508
	public static int materialsFromChunkRocks;

	// Token: 0x04000DB5 RID: 3509
	public static int materialsFromFullRocks;

	// Token: 0x04000DB6 RID: 3510
	public static float materialsTotalWorth;

	// Token: 0x04000DB7 RID: 3511
	public static float chanceToMineRandomRock;

	// Token: 0x04000DB8 RID: 3512
	public static float spawnPickaxeEverySecond;

	// Token: 0x04000DB9 RID: 3513
	public static float doubleXpAndGoldChance;

	// Token: 0x04000DBA RID: 3514
	public static float lightningTriggerChanceS;

	// Token: 0x04000DBB RID: 3515
	public static float lightningTriggerChancePH;

	// Token: 0x04000DBC RID: 3516
	public static float lightningDamage;

	// Token: 0x04000DBD RID: 3517
	public static float lightningSize;

	// Token: 0x04000DBE RID: 3518
	public static float dynamiteStickChance;

	// Token: 0x04000DBF RID: 3519
	public static float explosionSize;

	// Token: 0x04000DC0 RID: 3520
	public static float explosionDamagage;

	// Token: 0x04000DC1 RID: 3521
	public static float plazmaBallChance;

	// Token: 0x04000DC2 RID: 3522
	public static float plazmaBallTimer;

	// Token: 0x04000DC3 RID: 3523
	public static float plazmaBallTotalSize;

	// Token: 0x04000DC4 RID: 3524
	public static float plazmaBallTotalDamage;

	// Token: 0x04000DC5 RID: 3525
	public static float doubleDamageChance;

	// Token: 0x04000DC6 RID: 3526
	public static float instaMineChance;

	// Token: 0x04000DC7 RID: 3527
	public static double endlessGold_price;

	// Token: 0x04000DC8 RID: 3528
	public static double endlessCopper_price;

	// Token: 0x04000DC9 RID: 3529
	public static double endlessIron_price;

	// Token: 0x04000DCA RID: 3530
	public static double endlessCobalt_price;

	// Token: 0x04000DCB RID: 3531
	public static double endlessUranium_price;

	// Token: 0x04000DCC RID: 3532
	public static double endlessIsmium_price;

	// Token: 0x04000DCD RID: 3533
	public static double endlessIridium_price;

	// Token: 0x04000DCE RID: 3534
	public static double endlessPainite_price;

	// Token: 0x04000DCF RID: 3535
	public static int endlessGold_purchaseCount;

	// Token: 0x04000DD0 RID: 3536
	public static int endlessCopper_purchaseCount;

	// Token: 0x04000DD1 RID: 3537
	public static int endlessIron_purchaseCount;

	// Token: 0x04000DD2 RID: 3538
	public static int endlessCobalt_purchaseCount;

	// Token: 0x04000DD3 RID: 3539
	public static int endlessUranium_purchaseCount;

	// Token: 0x04000DD4 RID: 3540
	public static int endlessIsmium_purchaseCount;

	// Token: 0x04000DD5 RID: 3541
	public static int endlessIridium_purchaseCount;

	// Token: 0x04000DD6 RID: 3542
	public static int endlessPainite_purchaseCount;

	// Token: 0x04000DD7 RID: 3543
	public GameObject endlessGold_pluss;

	// Token: 0x04000DD8 RID: 3544
	public GameObject endlessCopper_pluss;

	// Token: 0x04000DD9 RID: 3545
	public GameObject endlessIron_pluss;

	// Token: 0x04000DDA RID: 3546
	public GameObject endlessCobalt_pluss;

	// Token: 0x04000DDB RID: 3547
	public GameObject endlessUranium_pluss;

	// Token: 0x04000DDC RID: 3548
	public GameObject endlessIsmium_pluss;

	// Token: 0x04000DDD RID: 3549
	public GameObject endlessIridium_pluss;

	// Token: 0x04000DDE RID: 3550
	public GameObject endlessPainite_pluss;

	// Token: 0x04000DDF RID: 3551
	public TextMeshProUGUI skillTreePrice_text;

	// Token: 0x04000DE0 RID: 3552
	public static bool pressedPurchaseMobile;

	// Token: 0x04000DE1 RID: 3553
	public GameObject skillTreeDark;

	// Token: 0x04000DE2 RID: 3554
	public GameObject skillTreeTooltip;

	// Token: 0x04000DE3 RID: 3555
	public GameObject tooltipPurchase;

	// Token: 0x04000DE4 RID: 3556
	public GameObject tooltipClose;

	// Token: 0x04000DE5 RID: 3557
	public Animation skillTreeTooltipAnim;

	// Token: 0x04000DE6 RID: 3558
	public static string upgradeNameMobile;

	// Token: 0x04000DE7 RID: 3559
	public static bool isInEndlessPopUp;

	// Token: 0x04000DE8 RID: 3560
	public LocalizationScript locScript;
}
