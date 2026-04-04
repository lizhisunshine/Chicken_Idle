using System;
using System.Collections;
using Steamworks.Data;
using UnityEngine;

// Token: 0x02000007 RID: 7
public class Achievements : MonoBehaviour
{
	// Token: 0x06000016 RID: 22 RVA: 0x00002491 File Offset: 0x00000691
	private void Awake()
	{
		base.StartCoroutine(this.Wait());
	}

	// Token: 0x06000017 RID: 23 RVA: 0x000024A0 File Offset: 0x000006A0
	private IEnumerator Wait()
	{
		yield return new WaitForSeconds(0.5f);
		this.CheckAch();
		yield break;
	}

	// Token: 0x06000018 RID: 24 RVA: 0x000024B0 File Offset: 0x000006B0
	public void ClearAchievements()
	{
		this.AchClear("mine_rock");
		this.AchClear("mineRock200K");
		this.AchClear("copper");
		this.AchClear("allMaterial");
		this.AchClear("beamDynamitePlazma");
		this.AchClear("allSkillTree");
		this.AchClear("talentCard");
		this.AchClear("talentCard10");
		this.AchClear("pickaxe");
		this.AchClear("pickaxeALL");
		this.AchClear("artifact");
		this.AchClear("artifact7");
		this.AchClear("artifactALL");
		this.AchClear("bars100");
		this.AchClear("bars100M");
		this.AchClear("ores1000");
		this.AchClear("ores500M");
		this.AchClear("levelUp");
		this.AchClear("levelUp80");
		this.AchClear("beatGame");
		this.AchClear("equipDiamondPickaxe");
		this.AchClear("theMine");
	}

	// Token: 0x06000019 RID: 25 RVA: 0x000025AF File Offset: 0x000007AF
	private void Update()
	{
		if (MobileAndTesting.isMobile && Achievements.checkAch)
		{
			Achievements.checkAch = false;
			this.CheckAch();
		}
	}

	// Token: 0x0600001A RID: 26 RVA: 0x000025CC File Offset: 0x000007CC
	public void CheckAch()
	{
		if (MobileAndTesting.isMobile)
		{
			return;
		}
		if (!Achievements.ach_minedRock && AllStats.totalRockMined > 0)
		{
			Achievements.ach_minedRock = true;
			this.TriggerACH("mine_rock");
		}
		if (!Achievements.ach_mine200Krocks && AllStats.totalRockMined >= 200000)
		{
			Achievements.ach_mine200Krocks = true;
			this.TriggerACH("mineRock200K");
		}
		if (!Achievements.ach_copper && SkillTree.spawnCopper_purchased)
		{
			Achievements.ach_copper = true;
			this.TriggerACH("copper");
		}
		if (!Achievements.ach_allMaterials && SkillTree.totalMaterialRocksSpawning >= 8)
		{
			Achievements.ach_allMaterials = true;
			this.TriggerACH("allMaterial");
		}
		if (!Achievements.ach_beamDynamiteBalls && SkillTree.dynamiteChance_1_purchased && SkillTree.plazmaBallSpawn_1_purchased && SkillTree.lightningBeamChancePH_1_purchased && SkillTree.lightningBeamChanceS_1_purchased)
		{
			Achievements.ach_beamDynamiteBalls = true;
			this.TriggerACH("beamDynamitePlazma");
		}
		if (!Achievements.ach_allSkillTree && SkillTree.totalSkillTreeUpgradesPurchased >= 399)
		{
			Achievements.ach_allSkillTree = true;
			this.TriggerACH("allSkillTree");
		}
		if (!Achievements.ach_1talent && LevelMechanics.cardsLeft <= 19)
		{
			Achievements.ach_1talent = true;
			this.TriggerACH("talentCard");
		}
		if (!Achievements.ach_10talent && LevelMechanics.cardsLeft <= 10)
		{
			Achievements.ach_10talent = true;
			this.TriggerACH("talentCard10");
		}
		if (!Achievements.ach_pickaxe && TheAnvil.totalPickaxesCrafted >= 1)
		{
			Achievements.ach_pickaxe = true;
			this.TriggerACH("pickaxe");
		}
		if (!Achievements.ach_allPickaxe && TheAnvil.totalPickaxesCrafted >= 12)
		{
			Achievements.ach_allPickaxe = true;
			this.TriggerACH("pickaxeALL");
		}
		if (!Achievements.ach_artifact && Artifacts.artifactsFound >= 1)
		{
			Achievements.ach_artifact = true;
			this.TriggerACH("artifact");
		}
		if (!Achievements.ach_7artifact && Artifacts.artifactsFound >= 7)
		{
			Achievements.ach_7artifact = true;
			this.TriggerACH("artifact7");
		}
		if (!Achievements.ach_allArtifact && Artifacts.artifactsFound >= 14)
		{
			Achievements.ach_allArtifact = true;
			this.TriggerACH("artifactALL");
		}
		if (!Achievements.ach_100Bars && AllStats.barsCrafted + AllStats.bardMinedTHEMINE >= 100.0)
		{
			Achievements.ach_100Bars = true;
			this.TriggerACH("bars100");
		}
		if (!Achievements.ach_100Mbars && AllStats.barsCrafted + AllStats.bardMinedTHEMINE >= 100000000.0)
		{
			Achievements.ach_100Mbars = true;
			this.TriggerACH("bars100M");
		}
		if (!Achievements.ach_1000Ores && AllStats.oresMined >= 1000.0)
		{
			Achievements.ach_1000Ores = true;
			this.TriggerACH("ores1000");
		}
		if (!Achievements.ach_500Mores && AllStats.oresMined >= 500000000.0)
		{
			Achievements.ach_500Mores = true;
			this.TriggerACH("ores500M");
		}
		if (!Achievements.ach_LevelUp && LevelMechanics.level >= 2)
		{
			Achievements.ach_LevelUp = true;
			this.TriggerACH("levelUp");
		}
		if (!Achievements.ach_level80 && LevelMechanics.level >= 80)
		{
			Achievements.ach_level80 = true;
			this.TriggerACH("levelUp80");
		}
		if (!Achievements.ach_beatGame && TheEnding.isEndingCompleted)
		{
			Achievements.ach_beatGame = true;
			this.TriggerACH("beatGame");
		}
		if (!Achievements.ach_equipDiamondPickaxe && TheAnvil.pickaxe14_equipped)
		{
			Achievements.ach_equipDiamondPickaxe = true;
			this.TriggerACH("equipDiamondPickaxe");
		}
		if (!Achievements.ach_TheMine && TheMine.isTheMineUnlocked)
		{
			Achievements.ach_TheMine = true;
			this.TriggerACH("theMine");
		}
	}

	// Token: 0x0600001B RID: 27 RVA: 0x000028EC File Offset: 0x00000AEC
	public void TriggerACH(string achNAME)
	{
		if (MobileAndTesting.isMobile)
		{
			return;
		}
		if (SteamIntgr.noSteamInt)
		{
			return;
		}
		Achievement achievement = new Achievement(achNAME);
		if (!achievement.State)
		{
			achievement.Trigger(true);
		}
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00002924 File Offset: 0x00000B24
	public void AchClear(string achNAME)
	{
		Achievement achievement = new Achievement(achNAME);
		achievement.Clear();
	}

	// Token: 0x04000025 RID: 37
	public static bool ach_minedRock;

	// Token: 0x04000026 RID: 38
	public static bool ach_mine200Krocks;

	// Token: 0x04000027 RID: 39
	public static bool ach_copper;

	// Token: 0x04000028 RID: 40
	public static bool ach_allMaterials;

	// Token: 0x04000029 RID: 41
	public static bool ach_beamDynamiteBalls;

	// Token: 0x0400002A RID: 42
	public static bool ach_allSkillTree;

	// Token: 0x0400002B RID: 43
	public static bool ach_1talent;

	// Token: 0x0400002C RID: 44
	public static bool ach_10talent;

	// Token: 0x0400002D RID: 45
	public static bool ach_pickaxe;

	// Token: 0x0400002E RID: 46
	public static bool ach_allPickaxe;

	// Token: 0x0400002F RID: 47
	public static bool ach_artifact;

	// Token: 0x04000030 RID: 48
	public static bool ach_7artifact;

	// Token: 0x04000031 RID: 49
	public static bool ach_allArtifact;

	// Token: 0x04000032 RID: 50
	public static bool ach_100Bars;

	// Token: 0x04000033 RID: 51
	public static bool ach_100Mbars;

	// Token: 0x04000034 RID: 52
	public static bool ach_1000Ores;

	// Token: 0x04000035 RID: 53
	public static bool ach_500Mores;

	// Token: 0x04000036 RID: 54
	public static bool ach_LevelUp;

	// Token: 0x04000037 RID: 55
	public static bool ach_level80;

	// Token: 0x04000038 RID: 56
	public static bool ach_beatGame;

	// Token: 0x04000039 RID: 57
	public static bool ach_equipDiamondPickaxe;

	// Token: 0x0400003A RID: 58
	public static bool ach_TheMine;

	// Token: 0x0400003B RID: 59
	public static bool checkAch;
}
