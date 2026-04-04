using System;
using TMPro;
using UnityEngine;

// Token: 0x02000008 RID: 8
public class AllStats : MonoBehaviour, IDataPersistence
{
	// Token: 0x0600001E RID: 30 RVA: 0x0000294C File Offset: 0x00000B4C
	public void CheckQuestionMarkText()
	{
		if (LevelMechanics.potionDrinker_chosen)
		{
			this.potionsDrank_leftText.gameObject.SetActive(true);
			this.potionsDrank_questionmark.gameObject.SetActive(false);
		}
		else
		{
			this.potionsDrank_leftText.gameObject.SetActive(false);
			this.potionsDrank_questionmark.gameObject.SetActive(true);
		}
		if (LevelMechanics.chests_chosen)
		{
			this.chestsOpened_leftText.gameObject.SetActive(true);
			this.chestsOpened_questionmark.gameObject.SetActive(false);
		}
		else
		{
			this.chestsOpened_leftText.gameObject.SetActive(false);
			this.chestsOpened_questionmark.gameObject.SetActive(true);
		}
		if (LevelMechanics.goldenChests_chosen)
		{
			this.goldenChestsOpened_leftText.gameObject.SetActive(true);
			this.goldenChestsOpened_questionmark.gameObject.SetActive(false);
		}
		else
		{
			this.goldenChestsOpened_leftText.gameObject.SetActive(false);
			this.goldenChestsOpened_questionmark.gameObject.SetActive(true);
		}
		if (LevelMechanics.skilledMiners_chosen)
		{
			this.theMine2XTriggered_leftText.gameObject.SetActive(true);
			this.theMine2XTriggered_questionmark.gameObject.SetActive(false);
			this.theMineDoubleTriggered_leftText.gameObject.SetActive(true);
			this.theMineDoubleTriggered_questionmark.gameObject.SetActive(false);
		}
		else
		{
			this.theMine2XTriggered_leftText.gameObject.SetActive(false);
			this.theMine2XTriggered_questionmark.gameObject.SetActive(true);
			this.theMineDoubleTriggered_leftText.gameObject.SetActive(false);
			this.theMineDoubleTriggered_questionmark.gameObject.SetActive(true);
		}
		if (LevelMechanics.bigMiningArea_chosen)
		{
			this.inflateBurstTriggered_leftText.gameObject.SetActive(true);
			this.inflateBurstTriggered_questionmark.gameObject.SetActive(false);
		}
		else
		{
			this.inflateBurstTriggered_leftText.gameObject.SetActive(false);
			this.inflateBurstTriggered_questionmark.gameObject.SetActive(true);
		}
		if (LevelMechanics.itsHammerTime_chosen)
		{
			this.hammersSpawned_leftText.gameObject.SetActive(true);
			this.hammersSpawned_questionmark.gameObject.SetActive(false);
		}
		else
		{
			this.hammersSpawned_leftText.gameObject.SetActive(false);
			this.hammersSpawned_questionmark.gameObject.SetActive(true);
		}
		if (LevelMechanics.goldenTouch_chosen)
		{
			this.midasTouchSessions_leftText.gameObject.SetActive(true);
			this.midasTouchSessions_questionmark.gameObject.SetActive(false);
		}
		else
		{
			this.midasTouchSessions_leftText.gameObject.SetActive(false);
			this.midasTouchSessions_questionmark.gameObject.SetActive(true);
		}
		if (LevelMechanics.zeus_chosen)
		{
			this.zeusTriggers_leftText.gameObject.SetActive(true);
			this.zeusTriggers_questionmark.gameObject.SetActive(false);
		}
		else
		{
			this.zeusTriggers_leftText.gameObject.SetActive(false);
			this.zeusTriggers_questionmark.gameObject.SetActive(true);
		}
		if (LevelMechanics.energiDrinker_chosen)
		{
			this.energiDrinksDrank_leftText.gameObject.SetActive(true);
			this.energiDrinksDrank_questionmark.gameObject.SetActive(false);
		}
		else
		{
			this.energiDrinksDrank_leftText.gameObject.SetActive(false);
			this.energiDrinksDrank_questionmark.gameObject.SetActive(true);
		}
		if (LevelMechanics.springSeason_chosen)
		{
			this.flowersSpawned_leftText.gameObject.SetActive(true);
			this.flowersSpawned_questionmark.gameObject.SetActive(false);
		}
		else
		{
			this.flowersSpawned_leftText.gameObject.SetActive(false);
			this.flowersSpawned_questionmark.gameObject.SetActive(true);
		}
		if (LevelMechanics.camper_chosen)
		{
			this.campfiresSpawned_leftText.gameObject.SetActive(true);
			this.campfiresSpawned_questionmark.gameObject.SetActive(false);
		}
		else
		{
			this.campfiresSpawned_leftText.gameObject.SetActive(false);
			this.campfiresSpawned_questionmark.gameObject.SetActive(true);
		}
		if (LevelMechanics.d100_chosen)
		{
			this.d100Rolls_leftText.gameObject.SetActive(true);
			this.d100Rolls_questionmark.gameObject.SetActive(false);
		}
		else
		{
			this.d100Rolls_leftText.gameObject.SetActive(false);
			this.d100Rolls_questionmark.gameObject.SetActive(true);
		}
		if (!SkillTree.lightningBeamChancePH_1_purchased && !SkillTree.lightningBeamChanceS_1_purchased)
		{
			this.lightningStrikes_leftText.gameObject.SetActive(false);
			this.lightningStrikes_questionmark.gameObject.SetActive(true);
		}
		else
		{
			this.lightningStrikes_leftText.gameObject.SetActive(true);
			this.lightningStrikes_questionmark.gameObject.SetActive(false);
		}
		if (SkillTree.dynamiteChance_1_purchased)
		{
			this.dynamiteExplosions_leftText.gameObject.SetActive(true);
			this.dynamiteExplosions_questionmark.gameObject.SetActive(false);
		}
		else
		{
			this.dynamiteExplosions_leftText.gameObject.SetActive(false);
			this.dynamiteExplosions_questionmark.gameObject.SetActive(true);
		}
		if (SkillTree.plazmaBallSpawn_1_purchased)
		{
			this.plazmaBallsSpawned_leftText.gameObject.SetActive(true);
			this.plazmaBallsSpawned_questionmark.gameObject.SetActive(false);
		}
		else
		{
			this.plazmaBallsSpawned_leftText.gameObject.SetActive(false);
			this.plazmaBallsSpawned_questionmark.gameObject.SetActive(true);
		}
		if (SkillTree.spawnCopper_purchased)
		{
			this.copperChunkMined_leftText.gameObject.SetActive(true);
			this.copperChunkMined_questionmark.gameObject.SetActive(false);
			this.fullCopperMined_leftText.gameObject.SetActive(true);
			this.fullCopperMined_questionmark.gameObject.SetActive(false);
		}
		else
		{
			this.copperChunkMined_leftText.gameObject.SetActive(false);
			this.copperChunkMined_questionmark.gameObject.SetActive(true);
			this.fullCopperMined_leftText.gameObject.SetActive(false);
			this.fullCopperMined_questionmark.gameObject.SetActive(true);
		}
		if (SkillTree.spawnIron_purchased)
		{
			this.ironChunkMined_leftText.gameObject.SetActive(true);
			this.ironChunkMined_questionmark.gameObject.SetActive(false);
			this.fullIronMined_leftText.gameObject.SetActive(true);
			this.fullIronMined_questionmark.gameObject.SetActive(false);
		}
		else
		{
			this.ironChunkMined_leftText.gameObject.SetActive(false);
			this.ironChunkMined_questionmark.gameObject.SetActive(true);
			this.fullIronMined_leftText.gameObject.SetActive(false);
			this.fullIronMined_questionmark.gameObject.SetActive(true);
		}
		if (SkillTree.cobaltSpawn_purchased)
		{
			this.cobaltChunkMined_leftText.gameObject.SetActive(true);
			this.cobaltChunkMined_questionmark.gameObject.SetActive(false);
			this.fullCobaltMined_leftText.gameObject.SetActive(true);
			this.fullCobaltMined_questionmark.gameObject.SetActive(false);
		}
		else
		{
			this.cobaltChunkMined_leftText.gameObject.SetActive(false);
			this.cobaltChunkMined_questionmark.gameObject.SetActive(true);
			this.fullCobaltMined_leftText.gameObject.SetActive(false);
			this.fullCobaltMined_questionmark.gameObject.SetActive(true);
		}
		if (SkillTree.uraniumSpawn_purchased)
		{
			this.uraniumChunkMined_leftText.gameObject.SetActive(true);
			this.uraniumChunkMined_questionmark.gameObject.SetActive(false);
			this.fullUraniumMined_leftText.gameObject.SetActive(true);
			this.fullUraniumMined_questionmark.gameObject.SetActive(false);
		}
		else
		{
			this.uraniumChunkMined_leftText.gameObject.SetActive(false);
			this.uraniumChunkMined_questionmark.gameObject.SetActive(true);
			this.fullUraniumMined_leftText.gameObject.SetActive(false);
			this.fullUraniumMined_questionmark.gameObject.SetActive(true);
		}
		if (SkillTree.ismiumSpawn_purchased)
		{
			this.ismiumChunkMined_leftText.gameObject.SetActive(true);
			this.ismiumChunkMined_questionmark.gameObject.SetActive(false);
			this.fullIsmiumMined_leftText.gameObject.SetActive(true);
			this.fullIsmiumMined_questionmark.gameObject.SetActive(false);
		}
		else
		{
			this.ismiumChunkMined_leftText.gameObject.SetActive(false);
			this.ismiumChunkMined_questionmark.gameObject.SetActive(true);
			this.fullIsmiumMined_leftText.gameObject.SetActive(false);
			this.fullIsmiumMined_questionmark.gameObject.SetActive(true);
		}
		if (SkillTree.iridiumSpawn_purchased)
		{
			this.iridiumChunkMined_leftText.gameObject.SetActive(true);
			this.iridiumChunkMined_questionmark.gameObject.SetActive(false);
			this.fullIridiumMined_leftText.gameObject.SetActive(true);
			this.fullIridiumMined_questionmark.gameObject.SetActive(false);
		}
		else
		{
			this.iridiumChunkMined_leftText.gameObject.SetActive(false);
			this.iridiumChunkMined_questionmark.gameObject.SetActive(true);
			this.fullIridiumMined_leftText.gameObject.SetActive(false);
			this.fullIridiumMined_questionmark.gameObject.SetActive(true);
		}
		if (SkillTree.painiteSpawn_purchased)
		{
			this.painiteChunkMined_leftText.gameObject.SetActive(true);
			this.painiteChunkMined_questionmark.gameObject.SetActive(false);
			this.fullPainiteMined_leftText.gameObject.SetActive(true);
			this.fullPainiteMined_questionmark.gameObject.SetActive(false);
			return;
		}
		this.painiteChunkMined_leftText.gameObject.SetActive(false);
		this.painiteChunkMined_questionmark.gameObject.SetActive(true);
		this.fullPainiteMined_leftText.gameObject.SetActive(false);
		this.fullPainiteMined_questionmark.gameObject.SetActive(true);
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00003220 File Offset: 0x00001420
	private void Update()
	{
		if (AllStats.isInStats)
		{
			this.potionsDrankTMP.text = AllStats.potionsDrank.ToString();
			this.chestsOpenedTMP.text = AllStats.chestsOpened.ToString();
			this.goldenChestsOpenedTMP.text = AllStats.goldenChestsOpened.ToString();
			this.theMine2XTriggeredTMP.text = AllStats.theMine2XTriggers.ToString();
			this.theMineDoubleTriggeredTMP.text = AllStats.theMineDoubleTriggers.ToString();
			this.inflateBurstTriggeredTMP.text = AllStats.inflateBurstTriggers.ToString();
			this.hammersSpawnedTMP.text = AllStats.hammersSpawned.ToString();
			this.midasTouchSessionsTMP.text = AllStats.midasTouchSessions.ToString();
			this.zeusTriggersTMP.text = AllStats.zeusTriggers.ToString();
			this.energiDrinksDrankTMP.text = AllStats.energiDrinksDrank.ToString();
			this.flowersSpawnedTMP.text = AllStats.flowersSpawned.ToString();
			this.campfiresSpawnedTMP.text = AllStats.campfiresSpawned.ToString();
			this.d100RollsTMP.text = AllStats.d100Rolls.ToString();
			this.miningSessionsTMP.text = AllStats.miningSessions.ToString();
			this.timeSpentMiningTMP.text = AllStats.timeSpentMining.ToString();
			this.totalRocksSpawnedTMP.text = AllStats.totalRocksSpawned.ToString();
			this.totalRockMinedTMP.text = AllStats.totalRockMined.ToString();
			this.pickaxesSpawnedTMP.text = AllStats.pickaxesSpawned.ToString();
			this.pickaxeHitsTMP.text = AllStats.pickaxeHits.ToString();
			this.totalLevelUpsTMP.text = AllStats.totalLevelUps.ToString();
			this.doubleXPGainedTMP.text = AllStats.doubleXPGained.ToString();
			this.doubleOreGainedTMP.text = AllStats.doubleOreGained.ToString();
			this.doublePickaxePowerHitsTMP.text = AllStats.doublePickaxePowerHits.ToString();
			this.instaMinePickaxeHitsTMP.text = AllStats.instaMinePickaxeHits.ToString();
			this.lightningStrikesTMP.text = AllStats.lightningStrikes.ToString();
			this.dynamiteExplosionsTMP.text = AllStats.dynamiteExplosions.ToString();
			this.plazmaBallsSpawnedTMP.text = AllStats.plazmaBallsSpawned.ToString();
			this.oresMinedTMP.text = FormatNumbers.FormatPoints(AllStats.oresMined);
			this.barsCraftedTMP.text = FormatNumbers.FormatPoints(AllStats.barsCrafted);
			this.bardMinedTHEMINETMP.text = FormatNumbers.FormatPoints(AllStats.bardMinedTHEMINE);
			this.experienceGainedTMP.text = FormatNumbers.FormatPoints((double)(AllStats.experienceGained * 100f));
			this.goldChunkMinedTMP.text = AllStats.goldChunkMined.ToString();
			this.fullGoldMinedTMP.text = AllStats.fullGoldMined.ToString();
			this.copperChunkMinedTMP.text = AllStats.copperChunkMined.ToString();
			this.fullCopperMinedTMP.text = AllStats.fullCopperMined.ToString();
			this.ironChunkMinedTMP.text = AllStats.ironChunkMined.ToString();
			this.fullIronMinedTMP.text = AllStats.fullIronMined.ToString();
			this.cobaltChunkMinedTMP.text = AllStats.cobaltChunkMined.ToString();
			this.fullCobaltMinedTMP.text = AllStats.fullCobaltMined.ToString();
			this.uraniumChunkMinedTMP.text = AllStats.uraniumChunkMined.ToString();
			this.fullUraniumMinedTMP.text = AllStats.fullUraniumMined.ToString();
			this.ismiumChunkMinedTMP.text = AllStats.ismiumChunkMined.ToString();
			this.fullIsmiumMinedTMP.text = AllStats.fullIsmiumMined.ToString();
			this.iridiumChunkMinedTMP.text = AllStats.iridiumChunkMined.ToString();
			this.fullIridiumMinedTMP.text = AllStats.fullIridiumMined.ToString();
			this.painiteChunkMinedTMP.text = AllStats.painiteChunkMined.ToString();
			this.fullPainiteMinedTMP.text = AllStats.fullPainiteMined.ToString();
		}
	}

	// Token: 0x06000020 RID: 32 RVA: 0x0000361C File Offset: 0x0000181C
	public void LoadData(GameData data)
	{
		AllStats.potionsDrank = data.potionsDrank;
		AllStats.chestsOpened = data.chestsOpened;
		AllStats.goldenChestsOpened = data.goldenChestsOpened;
		AllStats.theMine2XTriggers = data.theMine2XTriggers;
		AllStats.theMineDoubleTriggers = data.theMineDoubleTriggers;
		AllStats.inflateBurstTriggers = data.inflateBurstTriggers;
		AllStats.hammersSpawned = data.hammersSpawned;
		AllStats.midasTouchSessions = data.midasTouchSessions;
		AllStats.zeusTriggers = data.zeusTriggers;
		AllStats.energiDrinksDrank = data.energiDrinksDrank;
		AllStats.flowersSpawned = data.flowersSpawned;
		AllStats.campfiresSpawned = data.campfiresSpawned;
		AllStats.d100Rolls = data.d100Rolls;
		AllStats.miningSessions = data.miningSessions;
		AllStats.timeSpentMining = data.timeSpentMining;
		AllStats.totalRocksSpawned = data.totalRocksSpawned;
		AllStats.totalRockMined = data.totalRockMined;
		AllStats.pickaxesSpawned = data.pickaxesSpawned;
		AllStats.pickaxeHits = data.pickaxeHits;
		AllStats.totalLevelUps = data.totalLevelUps;
		AllStats.doubleXPGained = data.doubleXPGained;
		AllStats.doubleOreGained = data.doubleOreGained;
		AllStats.doublePickaxePowerHits = data.doublePickaxePowerHits;
		AllStats.instaMinePickaxeHits = data.instaMinePickaxeHits;
		AllStats.lightningStrikes = data.lightningStrikes;
		AllStats.dynamiteExplosions = data.dynamiteExplosions;
		AllStats.plazmaBallsSpawned = data.plazmaBallsSpawned;
		AllStats.oresMined = data.oresMined;
		AllStats.barsCrafted = data.barsCrafted;
		AllStats.bardMinedTHEMINE = data.bardMinedTHEMINE;
		AllStats.experienceGained = data.experienceGained;
		AllStats.goldChunkMined = data.goldChunkMined;
		AllStats.fullGoldMined = data.fullGoldMined;
		AllStats.copperChunkMined = data.copperChunkMined;
		AllStats.fullCopperMined = data.fullCopperMined;
		AllStats.ironChunkMined = data.ironChunkMined;
		AllStats.fullIronMined = data.fullIronMined;
		AllStats.cobaltChunkMined = data.cobaltChunkMined;
		AllStats.fullCobaltMined = data.fullCobaltMined;
		AllStats.uraniumChunkMined = data.uraniumChunkMined;
		AllStats.fullUraniumMined = data.fullUraniumMined;
		AllStats.ismiumChunkMined = data.ismiumChunkMined;
		AllStats.fullIsmiumMined = data.fullIsmiumMined;
		AllStats.iridiumChunkMined = data.iridiumChunkMined;
		AllStats.fullIridiumMined = data.fullIridiumMined;
		AllStats.painiteChunkMined = data.painiteChunkMined;
		AllStats.fullPainiteMined = data.fullPainiteMined;
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00003830 File Offset: 0x00001A30
	public void SaveData(ref GameData data)
	{
		data.potionsDrank = AllStats.potionsDrank;
		data.chestsOpened = AllStats.chestsOpened;
		data.goldenChestsOpened = AllStats.goldenChestsOpened;
		data.theMine2XTriggers = AllStats.theMine2XTriggers;
		data.theMineDoubleTriggers = AllStats.theMineDoubleTriggers;
		data.inflateBurstTriggers = AllStats.inflateBurstTriggers;
		data.hammersSpawned = AllStats.hammersSpawned;
		data.midasTouchSessions = AllStats.midasTouchSessions;
		data.zeusTriggers = AllStats.zeusTriggers;
		data.energiDrinksDrank = AllStats.energiDrinksDrank;
		data.flowersSpawned = AllStats.flowersSpawned;
		data.campfiresSpawned = AllStats.campfiresSpawned;
		data.d100Rolls = AllStats.d100Rolls;
		data.miningSessions = AllStats.miningSessions;
		data.timeSpentMining = AllStats.timeSpentMining;
		data.totalRocksSpawned = AllStats.totalRocksSpawned;
		data.totalRockMined = AllStats.totalRockMined;
		data.pickaxesSpawned = AllStats.pickaxesSpawned;
		data.pickaxeHits = AllStats.pickaxeHits;
		data.totalLevelUps = AllStats.totalLevelUps;
		data.doubleXPGained = AllStats.doubleXPGained;
		data.doubleOreGained = AllStats.doubleOreGained;
		data.doublePickaxePowerHits = AllStats.doublePickaxePowerHits;
		data.instaMinePickaxeHits = AllStats.instaMinePickaxeHits;
		data.lightningStrikes = AllStats.lightningStrikes;
		data.dynamiteExplosions = AllStats.dynamiteExplosions;
		data.plazmaBallsSpawned = AllStats.plazmaBallsSpawned;
		data.oresMined = AllStats.oresMined;
		data.barsCrafted = AllStats.barsCrafted;
		data.bardMinedTHEMINE = AllStats.bardMinedTHEMINE;
		data.experienceGained = AllStats.experienceGained;
		data.goldChunkMined = AllStats.goldChunkMined;
		data.fullGoldMined = AllStats.fullGoldMined;
		data.copperChunkMined = AllStats.copperChunkMined;
		data.fullCopperMined = AllStats.fullCopperMined;
		data.ironChunkMined = AllStats.ironChunkMined;
		data.fullIronMined = AllStats.fullIronMined;
		data.cobaltChunkMined = AllStats.cobaltChunkMined;
		data.fullCobaltMined = AllStats.fullCobaltMined;
		data.uraniumChunkMined = AllStats.uraniumChunkMined;
		data.fullUraniumMined = AllStats.fullUraniumMined;
		data.ismiumChunkMined = AllStats.ismiumChunkMined;
		data.fullIsmiumMined = AllStats.fullIsmiumMined;
		data.iridiumChunkMined = AllStats.iridiumChunkMined;
		data.fullIridiumMined = AllStats.fullIridiumMined;
		data.painiteChunkMined = AllStats.painiteChunkMined;
		data.fullPainiteMined = AllStats.fullPainiteMined;
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00003A74 File Offset: 0x00001C74
	public void ResetStats()
	{
		AllStats.potionsDrank = 0;
		AllStats.chestsOpened = 0;
		AllStats.goldenChestsOpened = 0;
		AllStats.theMine2XTriggers = 0;
		AllStats.theMineDoubleTriggers = 0;
		AllStats.inflateBurstTriggers = 0;
		AllStats.hammersSpawned = 0;
		AllStats.midasTouchSessions = 0;
		AllStats.zeusTriggers = 0;
		AllStats.energiDrinksDrank = 0;
		AllStats.flowersSpawned = 0;
		AllStats.campfiresSpawned = 0;
		AllStats.d100Rolls = 0;
		AllStats.miningSessions = 0;
		AllStats.timeSpentMining = 0;
		AllStats.totalRocksSpawned = 0;
		AllStats.totalRockMined = 0;
		AllStats.pickaxesSpawned = 0;
		AllStats.pickaxeHits = 0;
		AllStats.totalLevelUps = 0;
		AllStats.doubleXPGained = 0;
		AllStats.doubleOreGained = 0;
		AllStats.doublePickaxePowerHits = 0;
		AllStats.instaMinePickaxeHits = 0;
		AllStats.lightningStrikes = 0;
		AllStats.dynamiteExplosions = 0;
		AllStats.plazmaBallsSpawned = 0;
		AllStats.oresMined = 0.0;
		AllStats.barsCrafted = 0.0;
		AllStats.bardMinedTHEMINE = 0.0;
		AllStats.experienceGained = 0f;
		AllStats.goldChunkMined = 0;
		AllStats.fullGoldMined = 0;
		AllStats.copperChunkMined = 0;
		AllStats.fullCopperMined = 0;
		AllStats.ironChunkMined = 0;
		AllStats.fullIronMined = 0;
		AllStats.cobaltChunkMined = 0;
		AllStats.fullCobaltMined = 0;
		AllStats.uraniumChunkMined = 0;
		AllStats.fullUraniumMined = 0;
		AllStats.ismiumChunkMined = 0;
		AllStats.fullIsmiumMined = 0;
		AllStats.iridiumChunkMined = 0;
		AllStats.fullIridiumMined = 0;
		AllStats.painiteChunkMined = 0;
		AllStats.fullPainiteMined = 0;
	}

	// Token: 0x0400003C RID: 60
	public static int potionsDrank;

	// Token: 0x0400003D RID: 61
	public static int chestsOpened;

	// Token: 0x0400003E RID: 62
	public static int goldenChestsOpened;

	// Token: 0x0400003F RID: 63
	public static int theMine2XTriggers;

	// Token: 0x04000040 RID: 64
	public static int theMineDoubleTriggers;

	// Token: 0x04000041 RID: 65
	public static int inflateBurstTriggers;

	// Token: 0x04000042 RID: 66
	public static int hammersSpawned;

	// Token: 0x04000043 RID: 67
	public static int midasTouchSessions;

	// Token: 0x04000044 RID: 68
	public static int zeusTriggers;

	// Token: 0x04000045 RID: 69
	public static int energiDrinksDrank;

	// Token: 0x04000046 RID: 70
	public static int flowersSpawned;

	// Token: 0x04000047 RID: 71
	public static int campfiresSpawned;

	// Token: 0x04000048 RID: 72
	public static int d100Rolls;

	// Token: 0x04000049 RID: 73
	public static int miningSessions;

	// Token: 0x0400004A RID: 74
	public static int timeSpentMining;

	// Token: 0x0400004B RID: 75
	public static int totalRocksSpawned;

	// Token: 0x0400004C RID: 76
	public static int totalRockMined;

	// Token: 0x0400004D RID: 77
	public static int pickaxesSpawned;

	// Token: 0x0400004E RID: 78
	public static int pickaxeHits;

	// Token: 0x0400004F RID: 79
	public static int totalLevelUps;

	// Token: 0x04000050 RID: 80
	public static int doubleXPGained;

	// Token: 0x04000051 RID: 81
	public static int doubleOreGained;

	// Token: 0x04000052 RID: 82
	public static int doublePickaxePowerHits;

	// Token: 0x04000053 RID: 83
	public static int instaMinePickaxeHits;

	// Token: 0x04000054 RID: 84
	public static int lightningStrikes;

	// Token: 0x04000055 RID: 85
	public static int dynamiteExplosions;

	// Token: 0x04000056 RID: 86
	public static int plazmaBallsSpawned;

	// Token: 0x04000057 RID: 87
	public static double oresMined;

	// Token: 0x04000058 RID: 88
	public static double barsCrafted;

	// Token: 0x04000059 RID: 89
	public static double bardMinedTHEMINE;

	// Token: 0x0400005A RID: 90
	public static float experienceGained;

	// Token: 0x0400005B RID: 91
	public static int goldChunkMined;

	// Token: 0x0400005C RID: 92
	public static int fullGoldMined;

	// Token: 0x0400005D RID: 93
	public static int copperChunkMined;

	// Token: 0x0400005E RID: 94
	public static int fullCopperMined;

	// Token: 0x0400005F RID: 95
	public static int ironChunkMined;

	// Token: 0x04000060 RID: 96
	public static int fullIronMined;

	// Token: 0x04000061 RID: 97
	public static int cobaltChunkMined;

	// Token: 0x04000062 RID: 98
	public static int fullCobaltMined;

	// Token: 0x04000063 RID: 99
	public static int uraniumChunkMined;

	// Token: 0x04000064 RID: 100
	public static int fullUraniumMined;

	// Token: 0x04000065 RID: 101
	public static int ismiumChunkMined;

	// Token: 0x04000066 RID: 102
	public static int fullIsmiumMined;

	// Token: 0x04000067 RID: 103
	public static int iridiumChunkMined;

	// Token: 0x04000068 RID: 104
	public static int fullIridiumMined;

	// Token: 0x04000069 RID: 105
	public static int painiteChunkMined;

	// Token: 0x0400006A RID: 106
	public static int fullPainiteMined;

	// Token: 0x0400006B RID: 107
	public static bool isInStats;

	// Token: 0x0400006C RID: 108
	[Header("General Stats")]
	public TextMeshProUGUI potionsDrankTMP;

	// Token: 0x0400006D RID: 109
	public TextMeshProUGUI chestsOpenedTMP;

	// Token: 0x0400006E RID: 110
	public TextMeshProUGUI goldenChestsOpenedTMP;

	// Token: 0x0400006F RID: 111
	public TextMeshProUGUI theMine2XTriggeredTMP;

	// Token: 0x04000070 RID: 112
	public TextMeshProUGUI theMineDoubleTriggeredTMP;

	// Token: 0x04000071 RID: 113
	public TextMeshProUGUI inflateBurstTriggeredTMP;

	// Token: 0x04000072 RID: 114
	public TextMeshProUGUI hammersSpawnedTMP;

	// Token: 0x04000073 RID: 115
	public TextMeshProUGUI midasTouchSessionsTMP;

	// Token: 0x04000074 RID: 116
	public TextMeshProUGUI zeusTriggersTMP;

	// Token: 0x04000075 RID: 117
	public TextMeshProUGUI energiDrinksDrankTMP;

	// Token: 0x04000076 RID: 118
	public TextMeshProUGUI flowersSpawnedTMP;

	// Token: 0x04000077 RID: 119
	public TextMeshProUGUI campfiresSpawnedTMP;

	// Token: 0x04000078 RID: 120
	public TextMeshProUGUI d100RollsTMP;

	// Token: 0x04000079 RID: 121
	[Header("Mining Stats")]
	public TextMeshProUGUI miningSessionsTMP;

	// Token: 0x0400007A RID: 122
	public TextMeshProUGUI timeSpentMiningTMP;

	// Token: 0x0400007B RID: 123
	public TextMeshProUGUI totalRocksSpawnedTMP;

	// Token: 0x0400007C RID: 124
	public TextMeshProUGUI totalRockMinedTMP;

	// Token: 0x0400007D RID: 125
	public TextMeshProUGUI pickaxesSpawnedTMP;

	// Token: 0x0400007E RID: 126
	public TextMeshProUGUI pickaxeHitsTMP;

	// Token: 0x0400007F RID: 127
	public TextMeshProUGUI totalLevelUpsTMP;

	// Token: 0x04000080 RID: 128
	public TextMeshProUGUI doubleXPGainedTMP;

	// Token: 0x04000081 RID: 129
	public TextMeshProUGUI doubleOreGainedTMP;

	// Token: 0x04000082 RID: 130
	public TextMeshProUGUI doublePickaxePowerHitsTMP;

	// Token: 0x04000083 RID: 131
	public TextMeshProUGUI instaMinePickaxeHitsTMP;

	// Token: 0x04000084 RID: 132
	public TextMeshProUGUI lightningStrikesTMP;

	// Token: 0x04000085 RID: 133
	public TextMeshProUGUI dynamiteExplosionsTMP;

	// Token: 0x04000086 RID: 134
	public TextMeshProUGUI plazmaBallsSpawnedTMP;

	// Token: 0x04000087 RID: 135
	[Header("Resources Stats")]
	public TextMeshProUGUI oresMinedTMP;

	// Token: 0x04000088 RID: 136
	public TextMeshProUGUI barsCraftedTMP;

	// Token: 0x04000089 RID: 137
	public TextMeshProUGUI bardMinedTHEMINETMP;

	// Token: 0x0400008A RID: 138
	public TextMeshProUGUI experienceGainedTMP;

	// Token: 0x0400008B RID: 139
	[Header("Ore Breakdown")]
	public TextMeshProUGUI goldChunkMinedTMP;

	// Token: 0x0400008C RID: 140
	public TextMeshProUGUI fullGoldMinedTMP;

	// Token: 0x0400008D RID: 141
	public TextMeshProUGUI copperChunkMinedTMP;

	// Token: 0x0400008E RID: 142
	public TextMeshProUGUI fullCopperMinedTMP;

	// Token: 0x0400008F RID: 143
	public TextMeshProUGUI ironChunkMinedTMP;

	// Token: 0x04000090 RID: 144
	public TextMeshProUGUI fullIronMinedTMP;

	// Token: 0x04000091 RID: 145
	public TextMeshProUGUI cobaltChunkMinedTMP;

	// Token: 0x04000092 RID: 146
	public TextMeshProUGUI fullCobaltMinedTMP;

	// Token: 0x04000093 RID: 147
	public TextMeshProUGUI uraniumChunkMinedTMP;

	// Token: 0x04000094 RID: 148
	public TextMeshProUGUI fullUraniumMinedTMP;

	// Token: 0x04000095 RID: 149
	public TextMeshProUGUI ismiumChunkMinedTMP;

	// Token: 0x04000096 RID: 150
	public TextMeshProUGUI fullIsmiumMinedTMP;

	// Token: 0x04000097 RID: 151
	public TextMeshProUGUI iridiumChunkMinedTMP;

	// Token: 0x04000098 RID: 152
	public TextMeshProUGUI fullIridiumMinedTMP;

	// Token: 0x04000099 RID: 153
	public TextMeshProUGUI painiteChunkMinedTMP;

	// Token: 0x0400009A RID: 154
	public TextMeshProUGUI fullPainiteMinedTMP;

	// Token: 0x0400009B RID: 155
	[Header("General Stats - Questionmarks")]
	public TextMeshProUGUI potionsDrank_questionmark;

	// Token: 0x0400009C RID: 156
	public TextMeshProUGUI chestsOpened_questionmark;

	// Token: 0x0400009D RID: 157
	public TextMeshProUGUI goldenChestsOpened_questionmark;

	// Token: 0x0400009E RID: 158
	public TextMeshProUGUI theMine2XTriggered_questionmark;

	// Token: 0x0400009F RID: 159
	public TextMeshProUGUI theMineDoubleTriggered_questionmark;

	// Token: 0x040000A0 RID: 160
	public TextMeshProUGUI inflateBurstTriggered_questionmark;

	// Token: 0x040000A1 RID: 161
	public TextMeshProUGUI hammersSpawned_questionmark;

	// Token: 0x040000A2 RID: 162
	public TextMeshProUGUI midasTouchSessions_questionmark;

	// Token: 0x040000A3 RID: 163
	public TextMeshProUGUI zeusTriggers_questionmark;

	// Token: 0x040000A4 RID: 164
	public TextMeshProUGUI energiDrinksDrank_questionmark;

	// Token: 0x040000A5 RID: 165
	public TextMeshProUGUI flowersSpawned_questionmark;

	// Token: 0x040000A6 RID: 166
	public TextMeshProUGUI campfiresSpawned_questionmark;

	// Token: 0x040000A7 RID: 167
	public TextMeshProUGUI d100Rolls_questionmark;

	// Token: 0x040000A8 RID: 168
	[Header("Mining Stats - Questionmarks")]
	public TextMeshProUGUI lightningStrikes_questionmark;

	// Token: 0x040000A9 RID: 169
	public TextMeshProUGUI dynamiteExplosions_questionmark;

	// Token: 0x040000AA RID: 170
	public TextMeshProUGUI plazmaBallsSpawned_questionmark;

	// Token: 0x040000AB RID: 171
	[Header("Ore Breakdown - Questionmarks (except Gold)")]
	public TextMeshProUGUI copperChunkMined_questionmark;

	// Token: 0x040000AC RID: 172
	public TextMeshProUGUI fullCopperMined_questionmark;

	// Token: 0x040000AD RID: 173
	public TextMeshProUGUI ironChunkMined_questionmark;

	// Token: 0x040000AE RID: 174
	public TextMeshProUGUI fullIronMined_questionmark;

	// Token: 0x040000AF RID: 175
	public TextMeshProUGUI cobaltChunkMined_questionmark;

	// Token: 0x040000B0 RID: 176
	public TextMeshProUGUI fullCobaltMined_questionmark;

	// Token: 0x040000B1 RID: 177
	public TextMeshProUGUI uraniumChunkMined_questionmark;

	// Token: 0x040000B2 RID: 178
	public TextMeshProUGUI fullUraniumMined_questionmark;

	// Token: 0x040000B3 RID: 179
	public TextMeshProUGUI ismiumChunkMined_questionmark;

	// Token: 0x040000B4 RID: 180
	public TextMeshProUGUI fullIsmiumMined_questionmark;

	// Token: 0x040000B5 RID: 181
	public TextMeshProUGUI iridiumChunkMined_questionmark;

	// Token: 0x040000B6 RID: 182
	public TextMeshProUGUI fullIridiumMined_questionmark;

	// Token: 0x040000B7 RID: 183
	public TextMeshProUGUI painiteChunkMined_questionmark;

	// Token: 0x040000B8 RID: 184
	public TextMeshProUGUI fullPainiteMined_questionmark;

	// Token: 0x040000B9 RID: 185
	[Header("General Stats - Left Text")]
	public TextMeshProUGUI potionsDrank_leftText;

	// Token: 0x040000BA RID: 186
	public TextMeshProUGUI chestsOpened_leftText;

	// Token: 0x040000BB RID: 187
	public TextMeshProUGUI goldenChestsOpened_leftText;

	// Token: 0x040000BC RID: 188
	public TextMeshProUGUI theMine2XTriggered_leftText;

	// Token: 0x040000BD RID: 189
	public TextMeshProUGUI theMineDoubleTriggered_leftText;

	// Token: 0x040000BE RID: 190
	public TextMeshProUGUI inflateBurstTriggered_leftText;

	// Token: 0x040000BF RID: 191
	public TextMeshProUGUI hammersSpawned_leftText;

	// Token: 0x040000C0 RID: 192
	public TextMeshProUGUI midasTouchSessions_leftText;

	// Token: 0x040000C1 RID: 193
	public TextMeshProUGUI zeusTriggers_leftText;

	// Token: 0x040000C2 RID: 194
	public TextMeshProUGUI energiDrinksDrank_leftText;

	// Token: 0x040000C3 RID: 195
	public TextMeshProUGUI flowersSpawned_leftText;

	// Token: 0x040000C4 RID: 196
	public TextMeshProUGUI campfiresSpawned_leftText;

	// Token: 0x040000C5 RID: 197
	public TextMeshProUGUI d100Rolls_leftText;

	// Token: 0x040000C6 RID: 198
	[Header("Mining Stats - Left Text")]
	public TextMeshProUGUI lightningStrikes_leftText;

	// Token: 0x040000C7 RID: 199
	public TextMeshProUGUI dynamiteExplosions_leftText;

	// Token: 0x040000C8 RID: 200
	public TextMeshProUGUI plazmaBallsSpawned_leftText;

	// Token: 0x040000C9 RID: 201
	[Header("Ore Breakdown - Left Text (except Gold)")]
	public TextMeshProUGUI copperChunkMined_leftText;

	// Token: 0x040000CA RID: 202
	public TextMeshProUGUI fullCopperMined_leftText;

	// Token: 0x040000CB RID: 203
	public TextMeshProUGUI ironChunkMined_leftText;

	// Token: 0x040000CC RID: 204
	public TextMeshProUGUI fullIronMined_leftText;

	// Token: 0x040000CD RID: 205
	public TextMeshProUGUI cobaltChunkMined_leftText;

	// Token: 0x040000CE RID: 206
	public TextMeshProUGUI fullCobaltMined_leftText;

	// Token: 0x040000CF RID: 207
	public TextMeshProUGUI uraniumChunkMined_leftText;

	// Token: 0x040000D0 RID: 208
	public TextMeshProUGUI fullUraniumMined_leftText;

	// Token: 0x040000D1 RID: 209
	public TextMeshProUGUI ismiumChunkMined_leftText;

	// Token: 0x040000D2 RID: 210
	public TextMeshProUGUI fullIsmiumMined_leftText;

	// Token: 0x040000D3 RID: 211
	public TextMeshProUGUI iridiumChunkMined_leftText;

	// Token: 0x040000D4 RID: 212
	public TextMeshProUGUI fullIridiumMined_leftText;

	// Token: 0x040000D5 RID: 213
	public TextMeshProUGUI painiteChunkMined_leftText;

	// Token: 0x040000D6 RID: 214
	public TextMeshProUGUI fullPainiteMined_leftText;
}
