using System;

// Token: 0x02000032 RID: 50
[Serializable]
public class GameData
{
	// Token: 0x06000181 RID: 385 RVA: 0x0003E56C File Offset: 0x0003C76C
	public GameData()
	{
		this.SetTutorialSaves();
		this.TalenSaves();
		this.StatsSaves();
		this.ArtifactSaves();
		this.GoldBarsSaves();
		this.PickaxeSaves();
		this.TheMineSaves();
		this.SkillTreeSaves();
		this.SetEndingSaves();
		this.SettigsSaves();
	}

	// Token: 0x06000182 RID: 386 RVA: 0x0003E5BB File Offset: 0x0003C7BB
	public void SetTutorialSaves()
	{
		this.pressedOkMiningSession = false;
		this.pressedOkCraftingTurotialFrame = false;
		this.pressedOkTalent = false;
		this.pressedOkAnvil = false;
		this.pressedOkMine = false;
		this.pressedOkArtifact = false;
	}

	// Token: 0x06000183 RID: 387 RVA: 0x0003E5E7 File Offset: 0x0003C7E7
	public void SetEndingSaves()
	{
		this.isEndingCompleted = false;
	}

	// Token: 0x06000184 RID: 388 RVA: 0x0003E5F0 File Offset: 0x0003C7F0
	public void TalenSaves()
	{
		this.talentCard1Picked = 0;
		this.talentCard2Picked = 0;
		this.talentCard3Picked = 0;
		this.cardsLeft = 20;
		this.currentXP = 0f;
		this.level = 1;
		this.totalTalentPoints = 0;
		this.extraTalentPointPerLevelCOUNT = 0;
		this.extraTalentPointBOOK = 0;
		this.talentLevel = 1;
		this.newTalentsPrice = 1;
		this.xpFromRock = 0.03f;
		this.xpNeedForNextLvl = 1f;
		this.isInChoose1 = false;
		this.isBlockFrameActive = false;
		this.potionDrinker_chosen = false;
		this.potionChugger_chosen = false;
		this.chests_chosen = false;
		this.goldenChests_chosen = false;
		this.skilledMiners_chosen = false;
		this.efficientBlacksmith_chosen = false;
		this.itsASign_chosen = false;
		this.steamSale_chosen = false;
		this.bigMiningArea_chosen = false;
		this.itsHammerTime_chosen = false;
		this.goldenTouch_chosen = false;
		this.zeus_chosen = false;
		this.shapeShifter_chosen = false;
		this.xMarksTheSpor_chosen = false;
		this.explorer_chosen = false;
		this.archaeologist_chosen = false;
		this.energiDrinker_chosen = false;
		this.springSeason_chosen = false;
		this.camper_chosen = false;
		this.d100_chosen = false;
	}

	// Token: 0x06000185 RID: 389 RVA: 0x0003E700 File Offset: 0x0003C900
	public void StatsSaves()
	{
		this.potionsDrank = 0;
		this.chestsOpened = 0;
		this.goldenChestsOpened = 0;
		this.theMine2XTriggers = 0;
		this.theMineDoubleTriggers = 0;
		this.inflateBurstTriggers = 0;
		this.hammersSpawned = 0;
		this.midasTouchSessions = 0;
		this.zeusTriggers = 0;
		this.energiDrinksDrank = 0;
		this.flowersSpawned = 0;
		this.campfiresSpawned = 0;
		this.d100Rolls = 0;
		this.miningSessions = 0;
		this.timeSpentMining = 0;
		this.totalRocksSpawned = 0;
		this.totalRockMined = 0;
		this.pickaxesSpawned = 0;
		this.pickaxeHits = 0;
		this.totalLevelUps = 0;
		this.doubleXPGained = 0;
		this.doubleOreGained = 0;
		this.doublePickaxePowerHits = 0;
		this.instaMinePickaxeHits = 0;
		this.lightningStrikes = 0;
		this.dynamiteExplosions = 0;
		this.plazmaBallsSpawned = 0;
		this.oresMined = 0.0;
		this.barsCrafted = 0.0;
		this.bardMinedTHEMINE = 0.0;
		this.experienceGained = 0f;
		this.goldChunkMined = 0;
		this.fullGoldMined = 0;
		this.copperChunkMined = 0;
		this.fullCopperMined = 0;
		this.ironChunkMined = 0;
		this.fullIronMined = 0;
		this.cobaltChunkMined = 0;
		this.fullCobaltMined = 0;
		this.uraniumChunkMined = 0;
		this.fullUraniumMined = 0;
		this.ismiumChunkMined = 0;
		this.fullIsmiumMined = 0;
		this.iridiumChunkMined = 0;
		this.fullIridiumMined = 0;
		this.painiteChunkMined = 0;
		this.fullPainiteMined = 0;
	}

	// Token: 0x06000186 RID: 390 RVA: 0x0003E874 File Offset: 0x0003CA74
	public void ArtifactSaves()
	{
		this.artifactsFound = 0;
		this.horn_found = false;
		this.ancientDevice_found = false;
		this.bone_found = false;
		this.meteorieOre_found = false;
		this.book_found = false;
		this.goldStack_found = false;
		this.goldRing_found = false;
		this.purpleRing_found = false;
		this.ancientDice_found = false;
		this.cheese_found = false;
		this.wolfClaw_found = false;
		this.axe_found = false;
		this.rune_found = false;
		this.skull_found = false;
	}

	// Token: 0x06000187 RID: 391 RVA: 0x0003E8EC File Offset: 0x0003CAEC
	public void GoldBarsSaves()
	{
		this.totalGoldBars = 0.49399998784065247;
		this.totalCopperBars = 0.49399998784065247;
		this.totalIronBars = 0.49399998784065247;
		this.totalCobaltBars = 0.49399998784065247;
		this.totalUraniumBars = 0.49399998784065247;
		this.totalIsmiumBar = 0.49399998784065247;
		this.totalIridiumBars = 0.49399998784065247;
		this.totalPainiteBars = 0.49399998784065247;
	}

	// Token: 0x06000188 RID: 392 RVA: 0x0003E974 File Offset: 0x0003CB74
	public void PickaxeSaves()
	{
		this.totalPickaxesCrafted = 0;
		this.isTheAnvilUnlocked = false;
		this.pickaxe1_crafted = true;
		this.pickaxe2_crafted = false;
		this.pickaxe3_crafted = false;
		this.pickaxe4_crafted = false;
		this.pickaxe5_crafted = false;
		this.pickaxe6_crafted = false;
		this.pickaxe7_crafted = false;
		this.pickaxe8_crafted = false;
		this.pickaxe9_crafted = false;
		this.pickaxe10_crafted = false;
		this.pickaxe11_crafted = false;
		this.pickaxe12_crafted = false;
		this.pickaxe13_crafted = false;
		this.pickaxe14_crafted = false;
		this.pickaxe1_equipped = true;
		this.pickaxe2_equipped = false;
		this.pickaxe3_equipped = false;
		this.pickaxe4_equipped = false;
		this.pickaxe5_equipped = false;
		this.pickaxe6_equipped = false;
		this.pickaxe7_equipped = false;
		this.pickaxe8_equipped = false;
		this.pickaxe9_equipped = false;
		this.pickaxe10_equipped = false;
		this.pickaxe11_equipped = false;
		this.pickaxe12_equipped = false;
		this.pickaxe13_equipped = false;
		this.pickaxe14_equipped = false;
		this.pickaxe1_skinsChosen = 0;
		this.pickaxe2_skinsChosen = 0;
		this.pickaxe3_skinsChosen = 0;
		this.pickaxe4_skinsChosen = 0;
		this.pickaxe5_skinsChosen = 0;
		this.pickaxe6_skinsChosen = 0;
		this.pickaxe7_skinsChosen = 0;
		this.pickaxe8_skinsChosen = 0;
		this.pickaxe9_skinsChosen = 0;
		this.pickaxe10_skinsChosen = 0;
		this.pickaxe11_skinsChosen = 0;
		this.pickaxe12_skinsChosen = 0;
		this.pickaxe13_skinsChosen = 0;
	}

	// Token: 0x06000189 RID: 393 RVA: 0x0003EAB0 File Offset: 0x0003CCB0
	public void TheMineSaves()
	{
		this.isTheMineUnlocked = false;
		this.theMinePrice = 500.0;
		this.miningTime = 15f;
		this.mineTimeDecrase = this.miningTime / 19f;
		this.mineTimePrice = 300.0;
		this.mineMaterialsPrice = 750.0;
		this.barsMined = 2;
		this.bersMinedIncrease = 2;
	}

	// Token: 0x0600018A RID: 394 RVA: 0x0003EB1C File Offset: 0x0003CD1C
	public void SkillTreeSaves()
	{
		this.hasPressedEndlessOK = false;
		this.endlessGold_price = 6500000.0;
		this.endlessCopper_price = 3500000.0;
		this.endlessIron_price = 2500000.0;
		this.endlessCobalt_price = 1700000.0;
		this.endlessUranium_price = 1200000.0;
		this.endlessIsmium_price = 700000.0;
		this.endlessIridium_price = 500000.0;
		this.endlessPainite_price = 300000.0;
		this.endlessGold_purchaseCount = 0;
		this.endlessCopper_purchaseCount = 0;
		this.endlessIron_purchaseCount = 0;
		this.endlessCobalt_purchaseCount = 0;
		this.endlessUranium_purchaseCount = 0;
		this.endlessIsmium_purchaseCount = 0;
		this.endlessIridium_purchaseCount = 0;
		this.endlessPainite_purchaseCount = 0;
		this.moreTime_1_purchased = false;
		this.moreTime_2_purchased = false;
		this.moreTime_3_purchased = false;
		this.moreTime_4_purchased = false;
		this.chanceToAdd1SecondEverySecond_purchased = false;
		this.chanceAdd1SecondEveryRockMined_purchased = false;
		this.moreXP_1_purchased = false;
		this.moreXP_2_purchased = false;
		this.moreXP_3_purchased = false;
		this.moreXP_4_purchased = false;
		this.moreXP_5_purchased = false;
		this.moreXP_6_purchased = false;
		this.moreXP_7_purchased = false;
		this.moreXP_8_purchased = false;
		this.talentPointsPerXlevel_1_purchased = false;
		this.talentPointsPerXlevel_2_purchased = false;
		this.talentPointsPerXlevel_3_purchased = false;
		this.spawnMoreRocks_1_purchased = false;
		this.spawnMoreRocks_2_purchased = false;
		this.spawnMoreRocks_3_purchased = false;
		this.spawnMoreRocks_4_purchased = false;
		this.spawnMoreRocks_5_purchased = false;
		this.spawnMoreRocks_6_purchased = false;
		this.spawnMoreRocks_7_purchased = false;
		this.spawnMoreRocks_8_purchased = false;
		this.spawnMoreRocks_9_purchased = false;
		this.moreMeterialsFromRock_1_purchased = false;
		this.moreMeterialsFromRock_2_purchased = false;
		this.moreMeterialsFromRock_3_purchased = false;
		this.moreMeterialsFromRock_4_purchased = false;
		this.moreMeterialsFromRock_5_purchased = false;
		this.marterialsWorthMore_1_purchased = false;
		this.marterialsWorthMore_2_purchased = false;
		this.marterialsWorthMore_3_purchased = false;
		this.marterialsWorthMore_4_purchased = false;
		this.marterialsWorthMore_5_purchased = false;
		this.marterialsWorthMore_6_purchased = false;
		this.marterialsWorthMore_7_purchased = false;
		this.marterialsWorthMore_8_purchased = false;
		this.goldChunk_1_purchased = false;
		this.goldChunk_2_purchased = false;
		this.goldChunk_3_purchased = false;
		this.goldChunk_4_purchased = false;
		this.goldChunk_5_purchased = false;
		this.fullGold_1_purchased = false;
		this.fullGold_2_purchased = false;
		this.fullGold_3_purchased = false;
		this.spawnCopper_purchased = false;
		this.copperChunk_1_purchased = false;
		this.copperChunk_2_purchased = false;
		this.copperChunk_3_purchased = false;
		this.fullCopper_1_purchased = false;
		this.fullCopper_2_purchased = false;
		this.fullCopper_3_purchased = false;
		this.spawnIron_purchased = false;
		this.ironChunk_1_purchased = false;
		this.ironChunk_2_purchased = false;
		this.fullIron_1_purchased = false;
		this.fullIron_2_purchased = false;
		this.cobaltSpawn_purchased = false;
		this.cobaltChunk_1_purchased = false;
		this.fullCobalt_1_purchased = false;
		this.uraniumSpawn_purchased = false;
		this.uraniumChunk_1_purchased = false;
		this.fullUranium_1_purchased = false;
		this.ismiumSpawn_purchased = false;
		this.ismiumChunk_1_purchased = false;
		this.fullIsmium_1_purchased = false;
		this.iridiumSpawn_purchased = false;
		this.iridiumChunk_1_purchased = false;
		this.fullIridium_1_purchased = false;
		this.painiteSpawn_purchased = false;
		this.painiteChunk_1_purchased = false;
		this.fullPainite_1_purchased = false;
		this.improvedPickaxe_1_purchased = false;
		this.improvedPickaxe_2_purchased = false;
		this.improvedPickaxe_3_purchased = false;
		this.improvedPickaxe_4_purchased = false;
		this.improvedPickaxe_5_purchased = false;
		this.improvedPickaxe_6_purchased = false;
		this.biggerMiningErea_1_purchased = false;
		this.biggerMiningErea_2_purchased = false;
		this.biggerMiningErea_3_purchased = false;
		this.biggerMiningErea_4_purchased = false;
		this.shootCircleChance_purchased = false;
		this.increaseAndDecreaseMinignErea_purchased = false;
		this.spawnRockEveryXrock_1_purchased = false;
		this.spawnRockEveryXrock_2_purchased = false;
		this.spawnRockEveryXrock_3_purchased = false;
		this.spawnXRockEveryXSecond_1_purchased = false;
		this.spawnXRockEveryXSecond_2_purchased = false;
		this.spawnXRockEveryXSecond_3_purchased = false;
		this.chanceToSpawnRockWhenMined_1_purchased = false;
		this.chanceToSpawnRockWhenMined_2_purchased = false;
		this.chanceToSpawnRockWhenMined_3_purchased = false;
		this.chanceToSpawnRockWhenMined_4_purchased = false;
		this.chanceToSpawnRockWhenMined_5_purchased = false;
		this.chanceToSpawnRockWhenMined_6_purchased = false;
		this.chanceToMineRandomRock_1_purchased = false;
		this.chanceToMineRandomRock_2_purchased = false;
		this.chanceToMineRandomRock_3_purchased = false;
		this.chanceToMineRandomRock_4_purchased = false;
		this.spawnPickaxeEverySecond_1_purchased = false;
		this.spawnPickaxeEverySecond_2_purchased = false;
		this.spawnPickaxeEverySecond_3_purchased = false;
		this.doubleXpGoldChance_1_purchased = false;
		this.doubleXpGoldChance_2_purchased = false;
		this.doubleXpGoldChance_3_purchased = false;
		this.doubleXpGoldChance_4_purchased = false;
		this.doubleXpGoldChance_5_purchased = false;
		this.lightningBeamChanceS_1_purchased = false;
		this.lightningBeamChanceS_2_purchased = false;
		this.lightningBeamChancePH_1_purchased = false;
		this.lightningBeamChancePH_2_purchased = false;
		this.lightningBeamSpawnAnotherOneChance_purchased = false;
		this.lightningBeamDamage_purchased = false;
		this.lightningBeamSize_purchased = false;
		this.lightningSplashes_purchased = false;
		this.lightningBeamSpawnRock_purchased = false;
		this.lightningBeamExplosion_purchased = false;
		this.lightningBeamAddTime_purchased = false;
		this.dynamiteChance_1_purchased = false;
		this.dynamiteChance_2_purchased = false;
		this.dynamiteSpawn2SmallChance_purchased = false;
		this.dynamiteExplosionSize_purchased = false;
		this.dynamiteDamage_purchased = false;
		this.dynamiteExplosionSpawnRock_purchased = false;
		this.dynamiteExplosionAddTimeChance_purchased = false;
		this.dynamiteExplosionSpawnLightning_purchased = false;
		this.plazmaBallSpawn_1_purchased = false;
		this.plazmaBallSpawn_2_purchased = false;
		this.plazmaBallTime_purchased = false;
		this.plazmaBallSize_purchased = false;
		this.plazmaBallExplosionChance_purchased = false;
		this.plazmaBallSpawnSmallChance_purchased = false;
		this.plazmaBallDamage_purchased = false;
		this.plazmaBallSpawnPickaxeChance_purchased = false;
		this.allProjectileDoubleDamageChance_purchased = false;
		this.allProjectileTriggerChance_purchased = false;
		this.pickaxeDoubleDamageChance_1_purchased = false;
		this.pickaxeDoubleDamageChance_2_purchased = false;
		this.intaMineChance_1_purchased = false;
		this.intaMineChance_2_purchased = false;
		this.increaseSpawnChanceAllRocks_purchased = false;
		this.craft2Material_purchased = false;
		this.finalUpgrade_purchased = false;
		this.moreXP_1_purchaseCount = 0;
		this.moreXP_2_purchaseCount = 0;
		this.moreXP_3_purchaseCount = 0;
		this.moreXP_4_purchaseCount = 0;
		this.moreXP_5_purchaseCount = 0;
		this.moreXP_6_purchaseCount = 0;
		this.moreXP_7_purchaseCount = 0;
		this.moreXP_8_purchaseCount = 0;
		this.talentPointsPerXlevel_1_purchaseCount = 0;
		this.talentPointsPerXlevel_2_purchaseCount = 0;
		this.talentPointsPerXlevel_3_purchaseCount = 0;
		this.spawnMoreRocks_1_purchaseCount = 0;
		this.spawnMoreRocks_2_purchaseCount = 0;
		this.spawnMoreRocks_3_purchaseCount = 0;
		this.spawnMoreRocks_4_purchaseCount = 0;
		this.spawnMoreRocks_5_purchaseCount = 0;
		this.spawnMoreRocks_6_purchaseCount = 0;
		this.spawnMoreRocks_7_purchaseCount = 0;
		this.spawnMoreRocks_8_purchaseCount = 0;
		this.spawnMoreRocks_9_purchaseCount = 0;
		this.moreMeterialsFromRock_1_purchaseCount = 0;
		this.moreMeterialsFromRock_2_purchaseCount = 0;
		this.moreMeterialsFromRock_3_purchaseCount = 0;
		this.moreMeterialsFromRock_4_purchaseCount = 0;
		this.moreMeterialsFromRock_5_purchaseCount = 0;
		this.marterialsWorthMore_1_purchaseCount = 0;
		this.marterialsWorthMore_2_purchaseCount = 0;
		this.marterialsWorthMore_3_purchaseCount = 0;
		this.marterialsWorthMore_4_purchaseCount = 0;
		this.marterialsWorthMore_5_purchaseCount = 0;
		this.marterialsWorthMore_6_purchaseCount = 0;
		this.marterialsWorthMore_7_purchaseCount = 0;
		this.marterialsWorthMore_8_purchaseCount = 0;
		this.goldChunk_1_purchaseCount = 0;
		this.goldChunk_2_purchaseCount = 0;
		this.goldChunk_3_purchaseCount = 0;
		this.goldChunk_4_purchaseCount = 0;
		this.goldChunk_5_purchaseCount = 0;
		this.fullGold_1_purchaseCount = 0;
		this.fullGold_2_purchaseCount = 0;
		this.fullGold_3_purchaseCount = 0;
		this.spawnCopper_purchaseCount = 0;
		this.copperChunk_1_purchaseCount = 0;
		this.copperChunk_2_purchaseCount = 0;
		this.copperChunk_3_purchaseCount = 0;
		this.fullCopper_1_purchaseCount = 0;
		this.fullCopper_2_purchaseCount = 0;
		this.fullCopper_3_purchaseCount = 0;
		this.spawnIron_purchaseCount = 0;
		this.ironChunk_1_purchaseCount = 0;
		this.ironChunk_2_purchaseCount = 0;
		this.fullIron_1_purchaseCount = 0;
		this.fullIron_2_purchaseCount = 0;
		this.cobaltSpawn_purchaseCount = 0;
		this.cobaltChunk_1_purchaseCount = 0;
		this.fullCobalt_1_purchaseCount = 0;
		this.uraniumSpawn_purchaseCount = 0;
		this.uraniumChunk_1_purchaseCount = 0;
		this.fullUranium_1_purchaseCount = 0;
		this.ismiumSpawn_purchaseCount = 0;
		this.ismiumChunk_1_purchaseCount = 0;
		this.fullIsmium_1_purchaseCount = 0;
		this.iridiumSpawn_purchaseCount = 0;
		this.iridiumChunk_1_purchaseCount = 0;
		this.fullIridium_1_purchaseCount = 0;
		this.painiteSpawn_purchaseCount = 0;
		this.painiteChunk_1_purchaseCount = 0;
		this.fullPainite_1_purchaseCount = 0;
		this.improvedPickaxe_1_purchaseCount = 0;
		this.improvedPickaxe_2_purchaseCount = 0;
		this.improvedPickaxe_3_purchaseCount = 0;
		this.improvedPickaxe_4_purchaseCount = 0;
		this.improvedPickaxe_5_purchaseCount = 0;
		this.improvedPickaxe_6_purchaseCount = 0;
		this.biggerMiningErea_1_purchaseCount = 0;
		this.biggerMiningErea_2_purchaseCount = 0;
		this.biggerMiningErea_3_purchaseCount = 0;
		this.biggerMiningErea_4_purchaseCount = 0;
		this.shootCircleChance_purchaseCount = 0;
		this.increaseAndDecreaseMinignErea_purchaseCount = 0;
		this.spawnRockEveryXrock_1_purchaseCount = 0;
		this.spawnRockEveryXrock_2_purchaseCount = 0;
		this.spawnRockEveryXrock_3_purchaseCount = 0;
		this.spawnXRockEveryXSecond_1_purchaseCount = 0;
		this.spawnXRockEveryXSecond_2_purchaseCount = 0;
		this.spawnXRockEveryXSecond_3_purchaseCount = 0;
		this.chanceToSpawnRockWhenMined_1_purchaseCount = 0;
		this.chanceToSpawnRockWhenMined_2_purchaseCount = 0;
		this.chanceToSpawnRockWhenMined_3_purchaseCount = 0;
		this.chanceToSpawnRockWhenMined_4_purchaseCount = 0;
		this.chanceToSpawnRockWhenMined_5_purchaseCount = 0;
		this.chanceToSpawnRockWhenMined_6_purchaseCount = 0;
		this.chanceToMineRandomRock_1_purchaseCount = 0;
		this.chanceToMineRandomRock_2_purchaseCount = 0;
		this.chanceToMineRandomRock_3_purchaseCount = 0;
		this.chanceToMineRandomRock_4_purchaseCount = 0;
		this.spawnPickaxeEverySecond_1_purchaseCount = 0;
		this.spawnPickaxeEverySecond_2_purchaseCount = 0;
		this.spawnPickaxeEverySecond_3_purchaseCount = 0;
		this.moreTime_1_purchaseCount = 0;
		this.moreTime_2_purchaseCount = 0;
		this.moreTime_3_purchaseCount = 0;
		this.moreTime_4_purchaseCount = 0;
		this.chanceToAdd1SecondEverySecond_purchaseCount = 0;
		this.chanceAdd1SecondEveryRockMined_purchaseCount = 0;
		this.doubleXpGoldChance_1_purchaseCount = 0;
		this.doubleXpGoldChance_2_purchaseCount = 0;
		this.doubleXpGoldChance_3_purchaseCount = 0;
		this.doubleXpGoldChance_4_purchaseCount = 0;
		this.doubleXpGoldChance_5_purchaseCount = 0;
		this.lightningBeamChanceS_1_purchaseCount = 0;
		this.lightningBeamChanceS_2_purchaseCount = 0;
		this.lightningBeamChancePH_1_purchaseCount = 0;
		this.lightningBeamChancePH_2_purchaseCount = 0;
		this.lightningBeamSpawnAnotherOneChance_purchaseCount = 0;
		this.lightningBeamDamage_purchaseCount = 0;
		this.lightningBeamSize_purchaseCount = 0;
		this.lightningSplashes_purchaseCount = 0;
		this.lightningBeamSpawnRock_purchaseCount = 0;
		this.lightningBeamExplosion_purchaseCount = 0;
		this.lightningBeamAddTime_purchaseCount = 0;
		this.dynamiteChance_1_purchaseCount = 0;
		this.dynamiteChance_2_purchaseCount = 0;
		this.dynamiteSpawn2SmallChance_purchaseCount = 0;
		this.dynamiteExplosionSize_purchaseCount = 0;
		this.dynamiteDamage_purchaseCount = 0;
		this.dynamiteExplosionSpawnRock_purchaseCount = 0;
		this.dynamiteExplosionAddTimeChance_purchaseCount = 0;
		this.dynamiteExplosionSpawnLightning_purchaseCount = 0;
		this.plazmaBallSpawn_1_purchaseCount = 0;
		this.plazmaBallSpawn_2_purchaseCount = 0;
		this.plazmaBallTime_purchaseCount = 0;
		this.plazmaBallSize_purchaseCount = 0;
		this.plazmaBallExplosionChance_purchaseCount = 0;
		this.plazmaBallSpawnSmallChance_purchaseCount = 0;
		this.plazmaBallDamage_purchaseCount = 0;
		this.plazmaBallSpawnPickaxeChance_purchaseCount = 0;
		this.allProjectileDoubleDamageChance_purchaseCount = 0;
		this.allProjectileTriggerChance_purchaseCount = 0;
		this.pickaxeDoubleDamageChance_1_purchaseCount = 0;
		this.pickaxeDoubleDamageChance_2_purchaseCount = 0;
		this.intaMineChance_1_purchaseCount = 0;
		this.intaMineChance_2_purchaseCount = 0;
		this.increaseSpawnChanceAllRocks_purchaseCount = 0;
		this.craft2Material_purchaseCount = 0;
		this.finalUpgrade_purchaseCount = 0;
		this.totalMaterialRocksSpawning = 1;
		this.totalSkillTreeUpgradesPurchased = 0;
		this.totalUpgradesFullyPurchased = 0;
		this.mineSessionTime = 15;
		this.totalRocksToSpawn = 25;
		this.extraTalentPointPerLevel = 7;
		this.goldRockChance = 11f;
		this.fullGoldRockChance = 4.2f;
		this.copperRockChance = 3.1f;
		this.fullCopperRockChance = 2.2f;
		this.ironRockChance = 2.4f;
		this.fullIronRockChance = 1.7f;
		this.cobaltRockChance = 1.5f;
		this.fullCobaltRockChance = 1.3f;
		this.uraniumRockChance = 1.1f;
		this.fullUraniumRockChance = 1f;
		this.ismiumRockChance = 0.9f;
		this.fullIsmiumRockChance = 0.8f;
		this.iridiumRockChance = 0.7f;
		this.fullIridiumRockChance = 0.6f;
		this.painiteRockChance = 0.5f;
		this.fullPainiteRockChance = 0.4f;
		this.improvedPickaxeStrength = 1f;
		this.reducePickaxeMineTime = 0f;
		this.miningAreaSize = 1f;
		this.spawnRockEveryXRock = 6f;
		this.spawnXRockEveryXSecond = 2f;
		this.chanceToSpawnRockWhenMined = 0f;
		this.materialsFromChunkRocks = 3;
		this.materialsFromFullRocks = 7;
		this.materialsTotalWorth = 1f;
		this.chanceToMineRandomRock = 0f;
		this.spawnPickaxeEverySecond = 1.2f;
		this.doubleXpAndGoldChance = 0f;
		this.lightningTriggerChanceS = 0f;
		this.lightningTriggerChancePH = 0f;
		this.lightningDamage = 0f;
		this.lightningSize = 1f;
		this.dynamiteStickChance = 0f;
		this.explosionSize = 1f;
		this.explosionDamagage = 0f;
		this.plazmaBallChance = 0f;
		this.plazmaBallTimer = 5f;
		this.plazmaBallTotalSize = 1f;
		this.plazmaBallTotalDamage = 1f;
		this.doubleDamageChance = 0f;
		this.instaMineChance = 0f;
	}

	// Token: 0x0600018B RID: 395 RVA: 0x0003F5C3 File Offset: 0x0003D7C3
	public void SettigsSaves()
	{
		this.isTooltipAnimOn = true;
	}

	// Token: 0x04000739 RID: 1849
	public bool pressedOkMiningSession;

	// Token: 0x0400073A RID: 1850
	public bool pressedOkCraftingTurotialFrame;

	// Token: 0x0400073B RID: 1851
	public bool pressedOkTalent;

	// Token: 0x0400073C RID: 1852
	public bool pressedOkAnvil;

	// Token: 0x0400073D RID: 1853
	public bool pressedOkMine;

	// Token: 0x0400073E RID: 1854
	public bool pressedOkArtifact;

	// Token: 0x0400073F RID: 1855
	public bool isEndingCompleted;

	// Token: 0x04000740 RID: 1856
	public int level;

	// Token: 0x04000741 RID: 1857
	public int totalTalentPoints;

	// Token: 0x04000742 RID: 1858
	public int extraTalentPointPerLevelCOUNT;

	// Token: 0x04000743 RID: 1859
	public int extraTalentPointBOOK;

	// Token: 0x04000744 RID: 1860
	public int talentLevel;

	// Token: 0x04000745 RID: 1861
	public int newTalentsPrice;

	// Token: 0x04000746 RID: 1862
	public float xpFromRock;

	// Token: 0x04000747 RID: 1863
	public float xpNeedForNextLvl;

	// Token: 0x04000748 RID: 1864
	public bool isInChoose1;

	// Token: 0x04000749 RID: 1865
	public bool isBlockFrameActive;

	// Token: 0x0400074A RID: 1866
	public bool potionDrinker_chosen;

	// Token: 0x0400074B RID: 1867
	public bool potionChugger_chosen;

	// Token: 0x0400074C RID: 1868
	public bool chests_chosen;

	// Token: 0x0400074D RID: 1869
	public bool goldenChests_chosen;

	// Token: 0x0400074E RID: 1870
	public bool skilledMiners_chosen;

	// Token: 0x0400074F RID: 1871
	public bool efficientBlacksmith_chosen;

	// Token: 0x04000750 RID: 1872
	public bool itsASign_chosen;

	// Token: 0x04000751 RID: 1873
	public bool steamSale_chosen;

	// Token: 0x04000752 RID: 1874
	public bool bigMiningArea_chosen;

	// Token: 0x04000753 RID: 1875
	public bool itsHammerTime_chosen;

	// Token: 0x04000754 RID: 1876
	public bool goldenTouch_chosen;

	// Token: 0x04000755 RID: 1877
	public bool zeus_chosen;

	// Token: 0x04000756 RID: 1878
	public bool shapeShifter_chosen;

	// Token: 0x04000757 RID: 1879
	public bool xMarksTheSpor_chosen;

	// Token: 0x04000758 RID: 1880
	public bool explorer_chosen;

	// Token: 0x04000759 RID: 1881
	public bool archaeologist_chosen;

	// Token: 0x0400075A RID: 1882
	public bool energiDrinker_chosen;

	// Token: 0x0400075B RID: 1883
	public bool springSeason_chosen;

	// Token: 0x0400075C RID: 1884
	public bool camper_chosen;

	// Token: 0x0400075D RID: 1885
	public bool d100_chosen;

	// Token: 0x0400075E RID: 1886
	public float currentXP;

	// Token: 0x0400075F RID: 1887
	public int cardsLeft;

	// Token: 0x04000760 RID: 1888
	public int talentCard1Picked;

	// Token: 0x04000761 RID: 1889
	public int talentCard2Picked;

	// Token: 0x04000762 RID: 1890
	public int talentCard3Picked;

	// Token: 0x04000763 RID: 1891
	public int potionsDrank;

	// Token: 0x04000764 RID: 1892
	public int chestsOpened;

	// Token: 0x04000765 RID: 1893
	public int goldenChestsOpened;

	// Token: 0x04000766 RID: 1894
	public int theMine2XTriggers;

	// Token: 0x04000767 RID: 1895
	public int theMineDoubleTriggers;

	// Token: 0x04000768 RID: 1896
	public int inflateBurstTriggers;

	// Token: 0x04000769 RID: 1897
	public int hammersSpawned;

	// Token: 0x0400076A RID: 1898
	public int midasTouchSessions;

	// Token: 0x0400076B RID: 1899
	public int zeusTriggers;

	// Token: 0x0400076C RID: 1900
	public int energiDrinksDrank;

	// Token: 0x0400076D RID: 1901
	public int flowersSpawned;

	// Token: 0x0400076E RID: 1902
	public int campfiresSpawned;

	// Token: 0x0400076F RID: 1903
	public int d100Rolls;

	// Token: 0x04000770 RID: 1904
	public int miningSessions;

	// Token: 0x04000771 RID: 1905
	public int timeSpentMining;

	// Token: 0x04000772 RID: 1906
	public int totalRocksSpawned;

	// Token: 0x04000773 RID: 1907
	public int totalRockMined;

	// Token: 0x04000774 RID: 1908
	public int pickaxesSpawned;

	// Token: 0x04000775 RID: 1909
	public int pickaxeHits;

	// Token: 0x04000776 RID: 1910
	public int totalLevelUps;

	// Token: 0x04000777 RID: 1911
	public int doubleXPGained;

	// Token: 0x04000778 RID: 1912
	public int doubleOreGained;

	// Token: 0x04000779 RID: 1913
	public int doublePickaxePowerHits;

	// Token: 0x0400077A RID: 1914
	public int instaMinePickaxeHits;

	// Token: 0x0400077B RID: 1915
	public int lightningStrikes;

	// Token: 0x0400077C RID: 1916
	public int dynamiteExplosions;

	// Token: 0x0400077D RID: 1917
	public int plazmaBallsSpawned;

	// Token: 0x0400077E RID: 1918
	public int goldChunkMined;

	// Token: 0x0400077F RID: 1919
	public int fullGoldMined;

	// Token: 0x04000780 RID: 1920
	public int copperChunkMined;

	// Token: 0x04000781 RID: 1921
	public int fullCopperMined;

	// Token: 0x04000782 RID: 1922
	public int ironChunkMined;

	// Token: 0x04000783 RID: 1923
	public int fullIronMined;

	// Token: 0x04000784 RID: 1924
	public int cobaltChunkMined;

	// Token: 0x04000785 RID: 1925
	public int fullCobaltMined;

	// Token: 0x04000786 RID: 1926
	public int uraniumChunkMined;

	// Token: 0x04000787 RID: 1927
	public int fullUraniumMined;

	// Token: 0x04000788 RID: 1928
	public int ismiumChunkMined;

	// Token: 0x04000789 RID: 1929
	public int fullIsmiumMined;

	// Token: 0x0400078A RID: 1930
	public int iridiumChunkMined;

	// Token: 0x0400078B RID: 1931
	public int fullIridiumMined;

	// Token: 0x0400078C RID: 1932
	public int painiteChunkMined;

	// Token: 0x0400078D RID: 1933
	public int fullPainiteMined;

	// Token: 0x0400078E RID: 1934
	public double oresMined;

	// Token: 0x0400078F RID: 1935
	public double barsCrafted;

	// Token: 0x04000790 RID: 1936
	public double bardMinedTHEMINE;

	// Token: 0x04000791 RID: 1937
	public float experienceGained;

	// Token: 0x04000792 RID: 1938
	public int artifactsFound;

	// Token: 0x04000793 RID: 1939
	public bool horn_found;

	// Token: 0x04000794 RID: 1940
	public bool ancientDevice_found;

	// Token: 0x04000795 RID: 1941
	public bool bone_found;

	// Token: 0x04000796 RID: 1942
	public bool meteorieOre_found;

	// Token: 0x04000797 RID: 1943
	public bool book_found;

	// Token: 0x04000798 RID: 1944
	public bool goldStack_found;

	// Token: 0x04000799 RID: 1945
	public bool goldRing_found;

	// Token: 0x0400079A RID: 1946
	public bool purpleRing_found;

	// Token: 0x0400079B RID: 1947
	public bool ancientDice_found;

	// Token: 0x0400079C RID: 1948
	public bool cheese_found;

	// Token: 0x0400079D RID: 1949
	public bool wolfClaw_found;

	// Token: 0x0400079E RID: 1950
	public bool axe_found;

	// Token: 0x0400079F RID: 1951
	public bool rune_found;

	// Token: 0x040007A0 RID: 1952
	public bool skull_found;

	// Token: 0x040007A1 RID: 1953
	public double totalGoldBars;

	// Token: 0x040007A2 RID: 1954
	public double totalCopperBars;

	// Token: 0x040007A3 RID: 1955
	public double totalIronBars;

	// Token: 0x040007A4 RID: 1956
	public double totalCobaltBars;

	// Token: 0x040007A5 RID: 1957
	public double totalUraniumBars;

	// Token: 0x040007A6 RID: 1958
	public double totalIsmiumBar;

	// Token: 0x040007A7 RID: 1959
	public double totalIridiumBars;

	// Token: 0x040007A8 RID: 1960
	public double totalPainiteBars;

	// Token: 0x040007A9 RID: 1961
	public bool pickaxe1_crafted;

	// Token: 0x040007AA RID: 1962
	public bool pickaxe2_crafted;

	// Token: 0x040007AB RID: 1963
	public bool pickaxe3_crafted;

	// Token: 0x040007AC RID: 1964
	public bool pickaxe4_crafted;

	// Token: 0x040007AD RID: 1965
	public bool pickaxe5_crafted;

	// Token: 0x040007AE RID: 1966
	public bool pickaxe6_crafted;

	// Token: 0x040007AF RID: 1967
	public bool pickaxe7_crafted;

	// Token: 0x040007B0 RID: 1968
	public bool pickaxe8_crafted;

	// Token: 0x040007B1 RID: 1969
	public bool pickaxe9_crafted;

	// Token: 0x040007B2 RID: 1970
	public bool pickaxe10_crafted;

	// Token: 0x040007B3 RID: 1971
	public bool pickaxe11_crafted;

	// Token: 0x040007B4 RID: 1972
	public bool pickaxe12_crafted;

	// Token: 0x040007B5 RID: 1973
	public bool pickaxe13_crafted;

	// Token: 0x040007B6 RID: 1974
	public bool pickaxe14_crafted;

	// Token: 0x040007B7 RID: 1975
	public bool pickaxe1_equipped;

	// Token: 0x040007B8 RID: 1976
	public bool pickaxe2_equipped;

	// Token: 0x040007B9 RID: 1977
	public bool pickaxe3_equipped;

	// Token: 0x040007BA RID: 1978
	public bool pickaxe4_equipped;

	// Token: 0x040007BB RID: 1979
	public bool pickaxe5_equipped;

	// Token: 0x040007BC RID: 1980
	public bool pickaxe6_equipped;

	// Token: 0x040007BD RID: 1981
	public bool pickaxe7_equipped;

	// Token: 0x040007BE RID: 1982
	public bool pickaxe8_equipped;

	// Token: 0x040007BF RID: 1983
	public bool pickaxe9_equipped;

	// Token: 0x040007C0 RID: 1984
	public bool pickaxe10_equipped;

	// Token: 0x040007C1 RID: 1985
	public bool pickaxe11_equipped;

	// Token: 0x040007C2 RID: 1986
	public bool pickaxe12_equipped;

	// Token: 0x040007C3 RID: 1987
	public bool pickaxe13_equipped;

	// Token: 0x040007C4 RID: 1988
	public bool pickaxe14_equipped;

	// Token: 0x040007C5 RID: 1989
	public bool isTheAnvilUnlocked;

	// Token: 0x040007C6 RID: 1990
	public int pickaxe1_skinsChosen;

	// Token: 0x040007C7 RID: 1991
	public int pickaxe2_skinsChosen;

	// Token: 0x040007C8 RID: 1992
	public int pickaxe3_skinsChosen;

	// Token: 0x040007C9 RID: 1993
	public int pickaxe4_skinsChosen;

	// Token: 0x040007CA RID: 1994
	public int pickaxe5_skinsChosen;

	// Token: 0x040007CB RID: 1995
	public int pickaxe6_skinsChosen;

	// Token: 0x040007CC RID: 1996
	public int pickaxe7_skinsChosen;

	// Token: 0x040007CD RID: 1997
	public int pickaxe8_skinsChosen;

	// Token: 0x040007CE RID: 1998
	public int pickaxe9_skinsChosen;

	// Token: 0x040007CF RID: 1999
	public int pickaxe10_skinsChosen;

	// Token: 0x040007D0 RID: 2000
	public int pickaxe11_skinsChosen;

	// Token: 0x040007D1 RID: 2001
	public int pickaxe12_skinsChosen;

	// Token: 0x040007D2 RID: 2002
	public int pickaxe13_skinsChosen;

	// Token: 0x040007D3 RID: 2003
	public int totalPickaxesCrafted;

	// Token: 0x040007D4 RID: 2004
	public bool isTheMineUnlocked;

	// Token: 0x040007D5 RID: 2005
	public double theMinePrice;

	// Token: 0x040007D6 RID: 2006
	public float mineTimeDecrase;

	// Token: 0x040007D7 RID: 2007
	public double mineTimePrice;

	// Token: 0x040007D8 RID: 2008
	public double mineMaterialsPrice;

	// Token: 0x040007D9 RID: 2009
	public float miningTime;

	// Token: 0x040007DA RID: 2010
	public int barsMined;

	// Token: 0x040007DB RID: 2011
	public int bersMinedIncrease;

	// Token: 0x040007DC RID: 2012
	public bool moreXP_1_purchased;

	// Token: 0x040007DD RID: 2013
	public bool moreXP_2_purchased;

	// Token: 0x040007DE RID: 2014
	public bool moreXP_3_purchased;

	// Token: 0x040007DF RID: 2015
	public bool moreXP_4_purchased;

	// Token: 0x040007E0 RID: 2016
	public bool moreXP_5_purchased;

	// Token: 0x040007E1 RID: 2017
	public bool moreXP_6_purchased;

	// Token: 0x040007E2 RID: 2018
	public bool moreXP_7_purchased;

	// Token: 0x040007E3 RID: 2019
	public bool moreXP_8_purchased;

	// Token: 0x040007E4 RID: 2020
	public bool talentPointsPerXlevel_1_purchased;

	// Token: 0x040007E5 RID: 2021
	public bool talentPointsPerXlevel_2_purchased;

	// Token: 0x040007E6 RID: 2022
	public bool talentPointsPerXlevel_3_purchased;

	// Token: 0x040007E7 RID: 2023
	public bool spawnMoreRocks_1_purchased;

	// Token: 0x040007E8 RID: 2024
	public bool spawnMoreRocks_2_purchased;

	// Token: 0x040007E9 RID: 2025
	public bool spawnMoreRocks_3_purchased;

	// Token: 0x040007EA RID: 2026
	public bool spawnMoreRocks_4_purchased;

	// Token: 0x040007EB RID: 2027
	public bool spawnMoreRocks_5_purchased;

	// Token: 0x040007EC RID: 2028
	public bool spawnMoreRocks_6_purchased;

	// Token: 0x040007ED RID: 2029
	public bool spawnMoreRocks_7_purchased;

	// Token: 0x040007EE RID: 2030
	public bool spawnMoreRocks_8_purchased;

	// Token: 0x040007EF RID: 2031
	public bool spawnMoreRocks_9_purchased;

	// Token: 0x040007F0 RID: 2032
	public bool moreMeterialsFromRock_1_purchased;

	// Token: 0x040007F1 RID: 2033
	public bool moreMeterialsFromRock_2_purchased;

	// Token: 0x040007F2 RID: 2034
	public bool moreMeterialsFromRock_3_purchased;

	// Token: 0x040007F3 RID: 2035
	public bool moreMeterialsFromRock_4_purchased;

	// Token: 0x040007F4 RID: 2036
	public bool moreMeterialsFromRock_5_purchased;

	// Token: 0x040007F5 RID: 2037
	public bool marterialsWorthMore_1_purchased;

	// Token: 0x040007F6 RID: 2038
	public bool marterialsWorthMore_2_purchased;

	// Token: 0x040007F7 RID: 2039
	public bool marterialsWorthMore_3_purchased;

	// Token: 0x040007F8 RID: 2040
	public bool marterialsWorthMore_4_purchased;

	// Token: 0x040007F9 RID: 2041
	public bool marterialsWorthMore_5_purchased;

	// Token: 0x040007FA RID: 2042
	public bool marterialsWorthMore_6_purchased;

	// Token: 0x040007FB RID: 2043
	public bool marterialsWorthMore_7_purchased;

	// Token: 0x040007FC RID: 2044
	public bool marterialsWorthMore_8_purchased;

	// Token: 0x040007FD RID: 2045
	public bool goldChunk_1_purchased;

	// Token: 0x040007FE RID: 2046
	public bool goldChunk_2_purchased;

	// Token: 0x040007FF RID: 2047
	public bool goldChunk_3_purchased;

	// Token: 0x04000800 RID: 2048
	public bool goldChunk_4_purchased;

	// Token: 0x04000801 RID: 2049
	public bool goldChunk_5_purchased;

	// Token: 0x04000802 RID: 2050
	public bool fullGold_1_purchased;

	// Token: 0x04000803 RID: 2051
	public bool fullGold_2_purchased;

	// Token: 0x04000804 RID: 2052
	public bool fullGold_3_purchased;

	// Token: 0x04000805 RID: 2053
	public bool spawnCopper_purchased;

	// Token: 0x04000806 RID: 2054
	public bool copperChunk_1_purchased;

	// Token: 0x04000807 RID: 2055
	public bool copperChunk_2_purchased;

	// Token: 0x04000808 RID: 2056
	public bool copperChunk_3_purchased;

	// Token: 0x04000809 RID: 2057
	public bool fullCopper_1_purchased;

	// Token: 0x0400080A RID: 2058
	public bool fullCopper_2_purchased;

	// Token: 0x0400080B RID: 2059
	public bool fullCopper_3_purchased;

	// Token: 0x0400080C RID: 2060
	public bool spawnIron_purchased;

	// Token: 0x0400080D RID: 2061
	public bool ironChunk_1_purchased;

	// Token: 0x0400080E RID: 2062
	public bool ironChunk_2_purchased;

	// Token: 0x0400080F RID: 2063
	public bool fullIron_1_purchased;

	// Token: 0x04000810 RID: 2064
	public bool fullIron_2_purchased;

	// Token: 0x04000811 RID: 2065
	public bool cobaltSpawn_purchased;

	// Token: 0x04000812 RID: 2066
	public bool cobaltChunk_1_purchased;

	// Token: 0x04000813 RID: 2067
	public bool fullCobalt_1_purchased;

	// Token: 0x04000814 RID: 2068
	public bool uraniumSpawn_purchased;

	// Token: 0x04000815 RID: 2069
	public bool uraniumChunk_1_purchased;

	// Token: 0x04000816 RID: 2070
	public bool fullUranium_1_purchased;

	// Token: 0x04000817 RID: 2071
	public bool ismiumSpawn_purchased;

	// Token: 0x04000818 RID: 2072
	public bool ismiumChunk_1_purchased;

	// Token: 0x04000819 RID: 2073
	public bool fullIsmium_1_purchased;

	// Token: 0x0400081A RID: 2074
	public bool iridiumSpawn_purchased;

	// Token: 0x0400081B RID: 2075
	public bool iridiumChunk_1_purchased;

	// Token: 0x0400081C RID: 2076
	public bool fullIridium_1_purchased;

	// Token: 0x0400081D RID: 2077
	public bool painiteSpawn_purchased;

	// Token: 0x0400081E RID: 2078
	public bool painiteChunk_1_purchased;

	// Token: 0x0400081F RID: 2079
	public bool fullPainite_1_purchased;

	// Token: 0x04000820 RID: 2080
	public bool improvedPickaxe_1_purchased;

	// Token: 0x04000821 RID: 2081
	public bool improvedPickaxe_2_purchased;

	// Token: 0x04000822 RID: 2082
	public bool improvedPickaxe_3_purchased;

	// Token: 0x04000823 RID: 2083
	public bool improvedPickaxe_4_purchased;

	// Token: 0x04000824 RID: 2084
	public bool improvedPickaxe_5_purchased;

	// Token: 0x04000825 RID: 2085
	public bool improvedPickaxe_6_purchased;

	// Token: 0x04000826 RID: 2086
	public bool biggerMiningErea_1_purchased;

	// Token: 0x04000827 RID: 2087
	public bool biggerMiningErea_2_purchased;

	// Token: 0x04000828 RID: 2088
	public bool biggerMiningErea_3_purchased;

	// Token: 0x04000829 RID: 2089
	public bool biggerMiningErea_4_purchased;

	// Token: 0x0400082A RID: 2090
	public bool shootCircleChance_purchased;

	// Token: 0x0400082B RID: 2091
	public bool increaseAndDecreaseMinignErea_purchased;

	// Token: 0x0400082C RID: 2092
	public bool spawnRockEveryXrock_1_purchased;

	// Token: 0x0400082D RID: 2093
	public bool spawnRockEveryXrock_2_purchased;

	// Token: 0x0400082E RID: 2094
	public bool spawnRockEveryXrock_3_purchased;

	// Token: 0x0400082F RID: 2095
	public bool spawnXRockEveryXSecond_1_purchased;

	// Token: 0x04000830 RID: 2096
	public bool spawnXRockEveryXSecond_2_purchased;

	// Token: 0x04000831 RID: 2097
	public bool spawnXRockEveryXSecond_3_purchased;

	// Token: 0x04000832 RID: 2098
	public bool chanceToSpawnRockWhenMined_1_purchased;

	// Token: 0x04000833 RID: 2099
	public bool chanceToSpawnRockWhenMined_2_purchased;

	// Token: 0x04000834 RID: 2100
	public bool chanceToSpawnRockWhenMined_3_purchased;

	// Token: 0x04000835 RID: 2101
	public bool chanceToSpawnRockWhenMined_4_purchased;

	// Token: 0x04000836 RID: 2102
	public bool chanceToSpawnRockWhenMined_5_purchased;

	// Token: 0x04000837 RID: 2103
	public bool chanceToSpawnRockWhenMined_6_purchased;

	// Token: 0x04000838 RID: 2104
	public bool chanceToMineRandomRock_1_purchased;

	// Token: 0x04000839 RID: 2105
	public bool chanceToMineRandomRock_2_purchased;

	// Token: 0x0400083A RID: 2106
	public bool chanceToMineRandomRock_3_purchased;

	// Token: 0x0400083B RID: 2107
	public bool chanceToMineRandomRock_4_purchased;

	// Token: 0x0400083C RID: 2108
	public bool spawnPickaxeEverySecond_1_purchased;

	// Token: 0x0400083D RID: 2109
	public bool spawnPickaxeEverySecond_2_purchased;

	// Token: 0x0400083E RID: 2110
	public bool spawnPickaxeEverySecond_3_purchased;

	// Token: 0x0400083F RID: 2111
	public bool doubleXpGoldChance_1_purchased;

	// Token: 0x04000840 RID: 2112
	public bool doubleXpGoldChance_2_purchased;

	// Token: 0x04000841 RID: 2113
	public bool doubleXpGoldChance_3_purchased;

	// Token: 0x04000842 RID: 2114
	public bool doubleXpGoldChance_4_purchased;

	// Token: 0x04000843 RID: 2115
	public bool doubleXpGoldChance_5_purchased;

	// Token: 0x04000844 RID: 2116
	public bool lightningBeamChanceS_1_purchased;

	// Token: 0x04000845 RID: 2117
	public bool lightningBeamChanceS_2_purchased;

	// Token: 0x04000846 RID: 2118
	public bool lightningBeamChancePH_1_purchased;

	// Token: 0x04000847 RID: 2119
	public bool lightningBeamChancePH_2_purchased;

	// Token: 0x04000848 RID: 2120
	public bool lightningBeamSpawnAnotherOneChance_purchased;

	// Token: 0x04000849 RID: 2121
	public bool lightningBeamDamage_purchased;

	// Token: 0x0400084A RID: 2122
	public bool lightningBeamSize_purchased;

	// Token: 0x0400084B RID: 2123
	public bool lightningSplashes_purchased;

	// Token: 0x0400084C RID: 2124
	public bool lightningBeamSpawnRock_purchased;

	// Token: 0x0400084D RID: 2125
	public bool lightningBeamExplosion_purchased;

	// Token: 0x0400084E RID: 2126
	public bool lightningBeamAddTime_purchased;

	// Token: 0x0400084F RID: 2127
	public bool dynamiteChance_1_purchased;

	// Token: 0x04000850 RID: 2128
	public bool dynamiteChance_2_purchased;

	// Token: 0x04000851 RID: 2129
	public bool dynamiteSpawn2SmallChance_purchased;

	// Token: 0x04000852 RID: 2130
	public bool dynamiteExplosionSize_purchased;

	// Token: 0x04000853 RID: 2131
	public bool dynamiteDamage_purchased;

	// Token: 0x04000854 RID: 2132
	public bool dynamiteExplosionSpawnRock_purchased;

	// Token: 0x04000855 RID: 2133
	public bool dynamiteExplosionAddTimeChance_purchased;

	// Token: 0x04000856 RID: 2134
	public bool dynamiteExplosionSpawnLightning_purchased;

	// Token: 0x04000857 RID: 2135
	public bool plazmaBallSpawn_1_purchased;

	// Token: 0x04000858 RID: 2136
	public bool plazmaBallSpawn_2_purchased;

	// Token: 0x04000859 RID: 2137
	public bool plazmaBallTime_purchased;

	// Token: 0x0400085A RID: 2138
	public bool plazmaBallSize_purchased;

	// Token: 0x0400085B RID: 2139
	public bool plazmaBallExplosionChance_purchased;

	// Token: 0x0400085C RID: 2140
	public bool plazmaBallSpawnSmallChance_purchased;

	// Token: 0x0400085D RID: 2141
	public bool plazmaBallDamage_purchased;

	// Token: 0x0400085E RID: 2142
	public bool plazmaBallSpawnPickaxeChance_purchased;

	// Token: 0x0400085F RID: 2143
	public bool allProjectileDoubleDamageChance_purchased;

	// Token: 0x04000860 RID: 2144
	public bool allProjectileTriggerChance_purchased;

	// Token: 0x04000861 RID: 2145
	public bool pickaxeDoubleDamageChance_1_purchased;

	// Token: 0x04000862 RID: 2146
	public bool pickaxeDoubleDamageChance_2_purchased;

	// Token: 0x04000863 RID: 2147
	public bool intaMineChance_1_purchased;

	// Token: 0x04000864 RID: 2148
	public bool intaMineChance_2_purchased;

	// Token: 0x04000865 RID: 2149
	public bool increaseSpawnChanceAllRocks_purchased;

	// Token: 0x04000866 RID: 2150
	public bool craft2Material_purchased;

	// Token: 0x04000867 RID: 2151
	public bool finalUpgrade_purchased;

	// Token: 0x04000868 RID: 2152
	public int moreXP_1_purchaseCount;

	// Token: 0x04000869 RID: 2153
	public int moreXP_2_purchaseCount;

	// Token: 0x0400086A RID: 2154
	public int moreXP_3_purchaseCount;

	// Token: 0x0400086B RID: 2155
	public int moreXP_4_purchaseCount;

	// Token: 0x0400086C RID: 2156
	public int moreXP_5_purchaseCount;

	// Token: 0x0400086D RID: 2157
	public int moreXP_6_purchaseCount;

	// Token: 0x0400086E RID: 2158
	public int moreXP_7_purchaseCount;

	// Token: 0x0400086F RID: 2159
	public int moreXP_8_purchaseCount;

	// Token: 0x04000870 RID: 2160
	public int talentPointsPerXlevel_1_purchaseCount;

	// Token: 0x04000871 RID: 2161
	public int talentPointsPerXlevel_2_purchaseCount;

	// Token: 0x04000872 RID: 2162
	public int talentPointsPerXlevel_3_purchaseCount;

	// Token: 0x04000873 RID: 2163
	public int spawnMoreRocks_1_purchaseCount;

	// Token: 0x04000874 RID: 2164
	public int spawnMoreRocks_2_purchaseCount;

	// Token: 0x04000875 RID: 2165
	public int spawnMoreRocks_3_purchaseCount;

	// Token: 0x04000876 RID: 2166
	public int spawnMoreRocks_4_purchaseCount;

	// Token: 0x04000877 RID: 2167
	public int spawnMoreRocks_5_purchaseCount;

	// Token: 0x04000878 RID: 2168
	public int spawnMoreRocks_6_purchaseCount;

	// Token: 0x04000879 RID: 2169
	public int spawnMoreRocks_7_purchaseCount;

	// Token: 0x0400087A RID: 2170
	public int spawnMoreRocks_8_purchaseCount;

	// Token: 0x0400087B RID: 2171
	public int spawnMoreRocks_9_purchaseCount;

	// Token: 0x0400087C RID: 2172
	public int moreMeterialsFromRock_1_purchaseCount;

	// Token: 0x0400087D RID: 2173
	public int moreMeterialsFromRock_2_purchaseCount;

	// Token: 0x0400087E RID: 2174
	public int moreMeterialsFromRock_3_purchaseCount;

	// Token: 0x0400087F RID: 2175
	public int moreMeterialsFromRock_4_purchaseCount;

	// Token: 0x04000880 RID: 2176
	public int moreMeterialsFromRock_5_purchaseCount;

	// Token: 0x04000881 RID: 2177
	public int marterialsWorthMore_1_purchaseCount;

	// Token: 0x04000882 RID: 2178
	public int marterialsWorthMore_2_purchaseCount;

	// Token: 0x04000883 RID: 2179
	public int marterialsWorthMore_3_purchaseCount;

	// Token: 0x04000884 RID: 2180
	public int marterialsWorthMore_4_purchaseCount;

	// Token: 0x04000885 RID: 2181
	public int marterialsWorthMore_5_purchaseCount;

	// Token: 0x04000886 RID: 2182
	public int marterialsWorthMore_6_purchaseCount;

	// Token: 0x04000887 RID: 2183
	public int marterialsWorthMore_7_purchaseCount;

	// Token: 0x04000888 RID: 2184
	public int marterialsWorthMore_8_purchaseCount;

	// Token: 0x04000889 RID: 2185
	public int goldChunk_1_purchaseCount;

	// Token: 0x0400088A RID: 2186
	public int goldChunk_2_purchaseCount;

	// Token: 0x0400088B RID: 2187
	public int goldChunk_3_purchaseCount;

	// Token: 0x0400088C RID: 2188
	public int goldChunk_4_purchaseCount;

	// Token: 0x0400088D RID: 2189
	public int goldChunk_5_purchaseCount;

	// Token: 0x0400088E RID: 2190
	public int fullGold_1_purchaseCount;

	// Token: 0x0400088F RID: 2191
	public int fullGold_2_purchaseCount;

	// Token: 0x04000890 RID: 2192
	public int fullGold_3_purchaseCount;

	// Token: 0x04000891 RID: 2193
	public int spawnCopper_purchaseCount;

	// Token: 0x04000892 RID: 2194
	public int copperChunk_1_purchaseCount;

	// Token: 0x04000893 RID: 2195
	public int copperChunk_2_purchaseCount;

	// Token: 0x04000894 RID: 2196
	public int copperChunk_3_purchaseCount;

	// Token: 0x04000895 RID: 2197
	public int fullCopper_1_purchaseCount;

	// Token: 0x04000896 RID: 2198
	public int fullCopper_2_purchaseCount;

	// Token: 0x04000897 RID: 2199
	public int fullCopper_3_purchaseCount;

	// Token: 0x04000898 RID: 2200
	public int spawnIron_purchaseCount;

	// Token: 0x04000899 RID: 2201
	public int ironChunk_1_purchaseCount;

	// Token: 0x0400089A RID: 2202
	public int ironChunk_2_purchaseCount;

	// Token: 0x0400089B RID: 2203
	public int fullIron_1_purchaseCount;

	// Token: 0x0400089C RID: 2204
	public int fullIron_2_purchaseCount;

	// Token: 0x0400089D RID: 2205
	public int cobaltSpawn_purchaseCount;

	// Token: 0x0400089E RID: 2206
	public int cobaltChunk_1_purchaseCount;

	// Token: 0x0400089F RID: 2207
	public int fullCobalt_1_purchaseCount;

	// Token: 0x040008A0 RID: 2208
	public int uraniumSpawn_purchaseCount;

	// Token: 0x040008A1 RID: 2209
	public int uraniumChunk_1_purchaseCount;

	// Token: 0x040008A2 RID: 2210
	public int fullUranium_1_purchaseCount;

	// Token: 0x040008A3 RID: 2211
	public int ismiumSpawn_purchaseCount;

	// Token: 0x040008A4 RID: 2212
	public int ismiumChunk_1_purchaseCount;

	// Token: 0x040008A5 RID: 2213
	public int fullIsmium_1_purchaseCount;

	// Token: 0x040008A6 RID: 2214
	public int iridiumSpawn_purchaseCount;

	// Token: 0x040008A7 RID: 2215
	public int iridiumChunk_1_purchaseCount;

	// Token: 0x040008A8 RID: 2216
	public int fullIridium_1_purchaseCount;

	// Token: 0x040008A9 RID: 2217
	public int painiteSpawn_purchaseCount;

	// Token: 0x040008AA RID: 2218
	public int painiteChunk_1_purchaseCount;

	// Token: 0x040008AB RID: 2219
	public int fullPainite_1_purchaseCount;

	// Token: 0x040008AC RID: 2220
	public int improvedPickaxe_1_purchaseCount;

	// Token: 0x040008AD RID: 2221
	public int improvedPickaxe_2_purchaseCount;

	// Token: 0x040008AE RID: 2222
	public int improvedPickaxe_3_purchaseCount;

	// Token: 0x040008AF RID: 2223
	public int improvedPickaxe_4_purchaseCount;

	// Token: 0x040008B0 RID: 2224
	public int improvedPickaxe_5_purchaseCount;

	// Token: 0x040008B1 RID: 2225
	public int improvedPickaxe_6_purchaseCount;

	// Token: 0x040008B2 RID: 2226
	public int biggerMiningErea_1_purchaseCount;

	// Token: 0x040008B3 RID: 2227
	public int biggerMiningErea_2_purchaseCount;

	// Token: 0x040008B4 RID: 2228
	public int biggerMiningErea_3_purchaseCount;

	// Token: 0x040008B5 RID: 2229
	public int biggerMiningErea_4_purchaseCount;

	// Token: 0x040008B6 RID: 2230
	public int shootCircleChance_purchaseCount;

	// Token: 0x040008B7 RID: 2231
	public int increaseAndDecreaseMinignErea_purchaseCount;

	// Token: 0x040008B8 RID: 2232
	public int spawnRockEveryXrock_1_purchaseCount;

	// Token: 0x040008B9 RID: 2233
	public int spawnRockEveryXrock_2_purchaseCount;

	// Token: 0x040008BA RID: 2234
	public int spawnRockEveryXrock_3_purchaseCount;

	// Token: 0x040008BB RID: 2235
	public int spawnXRockEveryXSecond_1_purchaseCount;

	// Token: 0x040008BC RID: 2236
	public int spawnXRockEveryXSecond_2_purchaseCount;

	// Token: 0x040008BD RID: 2237
	public int spawnXRockEveryXSecond_3_purchaseCount;

	// Token: 0x040008BE RID: 2238
	public int chanceToSpawnRockWhenMined_1_purchaseCount;

	// Token: 0x040008BF RID: 2239
	public int chanceToSpawnRockWhenMined_2_purchaseCount;

	// Token: 0x040008C0 RID: 2240
	public int chanceToSpawnRockWhenMined_3_purchaseCount;

	// Token: 0x040008C1 RID: 2241
	public int chanceToSpawnRockWhenMined_4_purchaseCount;

	// Token: 0x040008C2 RID: 2242
	public int chanceToSpawnRockWhenMined_5_purchaseCount;

	// Token: 0x040008C3 RID: 2243
	public int chanceToSpawnRockWhenMined_6_purchaseCount;

	// Token: 0x040008C4 RID: 2244
	public int chanceToMineRandomRock_1_purchaseCount;

	// Token: 0x040008C5 RID: 2245
	public int chanceToMineRandomRock_2_purchaseCount;

	// Token: 0x040008C6 RID: 2246
	public int chanceToMineRandomRock_3_purchaseCount;

	// Token: 0x040008C7 RID: 2247
	public int chanceToMineRandomRock_4_purchaseCount;

	// Token: 0x040008C8 RID: 2248
	public int spawnPickaxeEverySecond_1_purchaseCount;

	// Token: 0x040008C9 RID: 2249
	public int spawnPickaxeEverySecond_2_purchaseCount;

	// Token: 0x040008CA RID: 2250
	public int spawnPickaxeEverySecond_3_purchaseCount;

	// Token: 0x040008CB RID: 2251
	public int moreTime_1_purchaseCount;

	// Token: 0x040008CC RID: 2252
	public int moreTime_2_purchaseCount;

	// Token: 0x040008CD RID: 2253
	public int moreTime_3_purchaseCount;

	// Token: 0x040008CE RID: 2254
	public int moreTime_4_purchaseCount;

	// Token: 0x040008CF RID: 2255
	public int chanceToAdd1SecondEverySecond_purchaseCount;

	// Token: 0x040008D0 RID: 2256
	public int chanceAdd1SecondEveryRockMined_purchaseCount;

	// Token: 0x040008D1 RID: 2257
	public int doubleXpGoldChance_1_purchaseCount;

	// Token: 0x040008D2 RID: 2258
	public int doubleXpGoldChance_2_purchaseCount;

	// Token: 0x040008D3 RID: 2259
	public int doubleXpGoldChance_3_purchaseCount;

	// Token: 0x040008D4 RID: 2260
	public int doubleXpGoldChance_4_purchaseCount;

	// Token: 0x040008D5 RID: 2261
	public int doubleXpGoldChance_5_purchaseCount;

	// Token: 0x040008D6 RID: 2262
	public int lightningBeamChanceS_1_purchaseCount;

	// Token: 0x040008D7 RID: 2263
	public int lightningBeamChanceS_2_purchaseCount;

	// Token: 0x040008D8 RID: 2264
	public int lightningBeamChancePH_1_purchaseCount;

	// Token: 0x040008D9 RID: 2265
	public int lightningBeamChancePH_2_purchaseCount;

	// Token: 0x040008DA RID: 2266
	public int lightningBeamSpawnAnotherOneChance_purchaseCount;

	// Token: 0x040008DB RID: 2267
	public int lightningBeamDamage_purchaseCount;

	// Token: 0x040008DC RID: 2268
	public int lightningBeamSize_purchaseCount;

	// Token: 0x040008DD RID: 2269
	public int lightningSplashes_purchaseCount;

	// Token: 0x040008DE RID: 2270
	public int lightningBeamSpawnRock_purchaseCount;

	// Token: 0x040008DF RID: 2271
	public int lightningBeamExplosion_purchaseCount;

	// Token: 0x040008E0 RID: 2272
	public int lightningBeamAddTime_purchaseCount;

	// Token: 0x040008E1 RID: 2273
	public int dynamiteChance_1_purchaseCount;

	// Token: 0x040008E2 RID: 2274
	public int dynamiteChance_2_purchaseCount;

	// Token: 0x040008E3 RID: 2275
	public int dynamiteSpawn2SmallChance_purchaseCount;

	// Token: 0x040008E4 RID: 2276
	public int dynamiteExplosionSize_purchaseCount;

	// Token: 0x040008E5 RID: 2277
	public int dynamiteDamage_purchaseCount;

	// Token: 0x040008E6 RID: 2278
	public int dynamiteExplosionSpawnRock_purchaseCount;

	// Token: 0x040008E7 RID: 2279
	public int dynamiteExplosionAddTimeChance_purchaseCount;

	// Token: 0x040008E8 RID: 2280
	public int dynamiteExplosionSpawnLightning_purchaseCount;

	// Token: 0x040008E9 RID: 2281
	public int plazmaBallSpawn_1_purchaseCount;

	// Token: 0x040008EA RID: 2282
	public int plazmaBallSpawn_2_purchaseCount;

	// Token: 0x040008EB RID: 2283
	public int plazmaBallTime_purchaseCount;

	// Token: 0x040008EC RID: 2284
	public int plazmaBallSize_purchaseCount;

	// Token: 0x040008ED RID: 2285
	public int plazmaBallExplosionChance_purchaseCount;

	// Token: 0x040008EE RID: 2286
	public int plazmaBallSpawnSmallChance_purchaseCount;

	// Token: 0x040008EF RID: 2287
	public int plazmaBallDamage_purchaseCount;

	// Token: 0x040008F0 RID: 2288
	public int plazmaBallSpawnPickaxeChance_purchaseCount;

	// Token: 0x040008F1 RID: 2289
	public int allProjectileDoubleDamageChance_purchaseCount;

	// Token: 0x040008F2 RID: 2290
	public int allProjectileTriggerChance_purchaseCount;

	// Token: 0x040008F3 RID: 2291
	public int pickaxeDoubleDamageChance_1_purchaseCount;

	// Token: 0x040008F4 RID: 2292
	public int pickaxeDoubleDamageChance_2_purchaseCount;

	// Token: 0x040008F5 RID: 2293
	public int intaMineChance_1_purchaseCount;

	// Token: 0x040008F6 RID: 2294
	public int intaMineChance_2_purchaseCount;

	// Token: 0x040008F7 RID: 2295
	public int increaseSpawnChanceAllRocks_purchaseCount;

	// Token: 0x040008F8 RID: 2296
	public int craft2Material_purchaseCount;

	// Token: 0x040008F9 RID: 2297
	public int finalUpgrade_purchaseCount;

	// Token: 0x040008FA RID: 2298
	public int totalSkillTreeUpgradesPurchased;

	// Token: 0x040008FB RID: 2299
	public int totalUpgradesFullyPurchased;

	// Token: 0x040008FC RID: 2300
	public int mineSessionTime;

	// Token: 0x040008FD RID: 2301
	public int totalRocksToSpawn;

	// Token: 0x040008FE RID: 2302
	public int extraTalentPointPerLevel;

	// Token: 0x040008FF RID: 2303
	public float goldRockChance;

	// Token: 0x04000900 RID: 2304
	public float fullGoldRockChance;

	// Token: 0x04000901 RID: 2305
	public float copperRockChance;

	// Token: 0x04000902 RID: 2306
	public float fullCopperRockChance;

	// Token: 0x04000903 RID: 2307
	public float ironRockChance;

	// Token: 0x04000904 RID: 2308
	public float fullIronRockChance;

	// Token: 0x04000905 RID: 2309
	public float cobaltRockChance;

	// Token: 0x04000906 RID: 2310
	public float fullCobaltRockChance;

	// Token: 0x04000907 RID: 2311
	public float uraniumRockChance;

	// Token: 0x04000908 RID: 2312
	public float fullUraniumRockChance;

	// Token: 0x04000909 RID: 2313
	public float ismiumRockChance;

	// Token: 0x0400090A RID: 2314
	public float fullIsmiumRockChance;

	// Token: 0x0400090B RID: 2315
	public float iridiumRockChance;

	// Token: 0x0400090C RID: 2316
	public float fullIridiumRockChance;

	// Token: 0x0400090D RID: 2317
	public float painiteRockChance;

	// Token: 0x0400090E RID: 2318
	public float fullPainiteRockChance;

	// Token: 0x0400090F RID: 2319
	public float improvedPickaxeStrength;

	// Token: 0x04000910 RID: 2320
	public float reducePickaxeMineTime;

	// Token: 0x04000911 RID: 2321
	public float miningAreaSize;

	// Token: 0x04000912 RID: 2322
	public float spawnRockEveryXRock;

	// Token: 0x04000913 RID: 2323
	public float spawnXRockEveryXSecond;

	// Token: 0x04000914 RID: 2324
	public float chanceToSpawnRockWhenMined;

	// Token: 0x04000915 RID: 2325
	public int materialsFromChunkRocks;

	// Token: 0x04000916 RID: 2326
	public int materialsFromFullRocks;

	// Token: 0x04000917 RID: 2327
	public float materialsTotalWorth;

	// Token: 0x04000918 RID: 2328
	public float chanceToMineRandomRock;

	// Token: 0x04000919 RID: 2329
	public float spawnPickaxeEverySecond;

	// Token: 0x0400091A RID: 2330
	public float doubleXpAndGoldChance;

	// Token: 0x0400091B RID: 2331
	public float lightningTriggerChanceS;

	// Token: 0x0400091C RID: 2332
	public float lightningTriggerChancePH;

	// Token: 0x0400091D RID: 2333
	public float lightningDamage;

	// Token: 0x0400091E RID: 2334
	public float lightningSize;

	// Token: 0x0400091F RID: 2335
	public float dynamiteStickChance;

	// Token: 0x04000920 RID: 2336
	public float explosionSize;

	// Token: 0x04000921 RID: 2337
	public float explosionDamagage;

	// Token: 0x04000922 RID: 2338
	public float plazmaBallChance;

	// Token: 0x04000923 RID: 2339
	public float plazmaBallTimer;

	// Token: 0x04000924 RID: 2340
	public float plazmaBallTotalSize;

	// Token: 0x04000925 RID: 2341
	public float plazmaBallTotalDamage;

	// Token: 0x04000926 RID: 2342
	public float doubleDamageChance;

	// Token: 0x04000927 RID: 2343
	public float instaMineChance;

	// Token: 0x04000928 RID: 2344
	public int totalMaterialRocksSpawning;

	// Token: 0x04000929 RID: 2345
	public bool moreTime_1_purchased;

	// Token: 0x0400092A RID: 2346
	public bool moreTime_2_purchased;

	// Token: 0x0400092B RID: 2347
	public bool moreTime_3_purchased;

	// Token: 0x0400092C RID: 2348
	public bool moreTime_4_purchased;

	// Token: 0x0400092D RID: 2349
	public bool chanceToAdd1SecondEverySecond_purchased;

	// Token: 0x0400092E RID: 2350
	public bool chanceAdd1SecondEveryRockMined_purchased;

	// Token: 0x0400092F RID: 2351
	public double endlessGold_price;

	// Token: 0x04000930 RID: 2352
	public double endlessCopper_price;

	// Token: 0x04000931 RID: 2353
	public double endlessIron_price;

	// Token: 0x04000932 RID: 2354
	public double endlessCobalt_price;

	// Token: 0x04000933 RID: 2355
	public double endlessUranium_price;

	// Token: 0x04000934 RID: 2356
	public double endlessIsmium_price;

	// Token: 0x04000935 RID: 2357
	public double endlessIridium_price;

	// Token: 0x04000936 RID: 2358
	public double endlessPainite_price;

	// Token: 0x04000937 RID: 2359
	public int endlessGold_purchaseCount;

	// Token: 0x04000938 RID: 2360
	public int endlessCopper_purchaseCount;

	// Token: 0x04000939 RID: 2361
	public int endlessIron_purchaseCount;

	// Token: 0x0400093A RID: 2362
	public int endlessCobalt_purchaseCount;

	// Token: 0x0400093B RID: 2363
	public int endlessUranium_purchaseCount;

	// Token: 0x0400093C RID: 2364
	public int endlessIsmium_purchaseCount;

	// Token: 0x0400093D RID: 2365
	public int endlessIridium_purchaseCount;

	// Token: 0x0400093E RID: 2366
	public int endlessPainite_purchaseCount;

	// Token: 0x0400093F RID: 2367
	public bool hasPressedEndlessOK;

	// Token: 0x04000940 RID: 2368
	public bool isTooltipAnimOn;
}
