using System;
using System.Collections;
using TMPro;
using UnityEngine;

// Token: 0x02000009 RID: 9
public class Artifacts : MonoBehaviour, IDataPersistence
{
	// Token: 0x06000024 RID: 36 RVA: 0x00003BC0 File Offset: 0x00001DC0
	private void Start()
	{
		Artifacts.runeImproveAll = 0f;
		Artifacts.wolfClawPickaxePowerIncrease = 0f;
		Artifacts.goldRingCraftChance = 1.1f;
		Artifacts.hornRockDecrease = 0.03f;
		Artifacts.ancientDeviceTimeReduction = 0.05f;
		Artifacts.bonePickaxeIncrease = 0.04f;
		Artifacts.meteoriteRockSpawnIncrease = 0.03f;
		Artifacts.purpleRingChance = 4f;
		Artifacts.cheeseChance = 0.2f;
		Artifacts.clawChance = 0.06f;
		Artifacts.runeIncrease_forDisplay = 5f;
		Artifacts.diceTime = 0.7f;
		base.StartCoroutine(this.Wait());
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00003C52 File Offset: 0x00001E52
	private IEnumerator Wait()
	{
		yield return new WaitForSeconds(0.1f);
		if (MobileAndTesting.isMobile)
		{
			this.artifactTooltipAnim.enabled = false;
		}
		if (Artifacts.horn_found)
		{
			this.horn_StageIcon.SetActive(true);
			this.horn_shadow.SetActive(true);
		}
		if (Artifacts.ancientDevice_found)
		{
			this.ancientDevice_stageIcon.SetActive(true);
			this.ancientDevice_shadow.SetActive(true);
		}
		if (Artifacts.bone_found)
		{
			this.bone_stageIcon.SetActive(true);
			this.bone_shadow.SetActive(true);
		}
		if (Artifacts.meteorieOre_found)
		{
			this.meteorieOre_stageIcon.SetActive(true);
			this.meteorieOre_shadow.SetActive(true);
		}
		if (Artifacts.book_found)
		{
			this.book_stageIcon.SetActive(true);
			this.book_shadow.SetActive(true);
		}
		if (Artifacts.goldStack_found)
		{
			this.goldStack_stageIcon.SetActive(true);
			this.goldStack_shadow.SetActive(true);
		}
		if (Artifacts.goldRing_found)
		{
			this.goldRing_stageIcon.SetActive(true);
			this.goldRing_shadow.SetActive(true);
		}
		if (Artifacts.purpleRing_found)
		{
			this.purpleRing_stageIcon.SetActive(true);
			this.purpleRing_shadow.SetActive(true);
		}
		if (Artifacts.ancientDice_found)
		{
			this.ancientDice_stageIcon.SetActive(true);
			this.ancientDice_shadow.SetActive(true);
		}
		if (Artifacts.cheese_found)
		{
			this.cheese_stageIcon.SetActive(true);
			this.cheese_shadow.SetActive(true);
		}
		if (Artifacts.wolfClaw_found)
		{
			this.wolfClaw_stageIcon.SetActive(true);
			this.wolfClaw_shadow.SetActive(true);
		}
		if (Artifacts.axe_found)
		{
			this.axe_stageIcon.SetActive(true);
			this.axe_shadow.SetActive(true);
		}
		if (Artifacts.rune_found)
		{
			this.rune_stageIcon.SetActive(true);
			this.rune_shadow.SetActive(true);
			Artifacts.runeImproveAll = 0.05f;
		}
		if (Artifacts.skull_found)
		{
			this.skullStageIcon.SetActive(true);
			this.skull_shadow.SetActive(true);
		}
		this.SetArtifactChances();
		yield break;
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00003C64 File Offset: 0x00001E64
	public void SetArtifactChances()
	{
		Artifacts.skull_spawnChance = 0.0015f;
		Artifacts.bone_spawnChance = 0.0008f;
		Artifacts.goldStack_spawnChance = 0.0037f;
		Artifacts.book_spawnChance = 0.00016f;
		Artifacts.ancientDice_spawnChance = 0.00011f;
		Artifacts.purpleRing_spawnChance = 8.8E-05f;
		Artifacts.axe_spawnChance = 6.9E-05f;
		Artifacts.wolfClaw_spawnChance = 3.5E-05f;
		Artifacts.ancientDevice_spawnChance = 2.6E-05f;
		Artifacts.horn_spawnChance = 2.3E-05f;
		Artifacts.meteorieOre_spawnChance = 1.4E-05f;
		Artifacts.goldRing_spawnChance = 1.2E-05f;
		Artifacts.cheese_spawnChance = 1.1E-05f;
		Artifacts.rune_spawnChance = 1E-05f;
		if (LevelMechanics.xMarksTheSpor_chosen)
		{
			float num = 1.4f;
			Artifacts.horn_spawnChance *= num;
			Artifacts.ancientDevice_spawnChance *= num;
			Artifacts.bone_spawnChance *= num;
			Artifacts.meteorieOre_spawnChance *= num;
			Artifacts.book_spawnChance *= num;
			Artifacts.goldStack_spawnChance *= num;
			Artifacts.goldRing_spawnChance *= num;
			Artifacts.purpleRing_spawnChance *= num;
			Artifacts.ancientDice_spawnChance *= num;
			Artifacts.cheese_spawnChance *= num;
			Artifacts.wolfClaw_spawnChance *= num;
			Artifacts.axe_spawnChance *= num;
			Artifacts.rune_spawnChance *= num;
			Artifacts.skull_spawnChance *= num;
		}
		if (LevelMechanics.explorer_chosen)
		{
			float num2 = 1.5f;
			Artifacts.horn_spawnChance *= num2;
			Artifacts.ancientDevice_spawnChance *= num2;
			Artifacts.bone_spawnChance *= num2;
			Artifacts.meteorieOre_spawnChance *= num2;
			Artifacts.book_spawnChance *= num2;
			Artifacts.goldStack_spawnChance *= num2;
			Artifacts.goldRing_spawnChance *= num2;
			Artifacts.purpleRing_spawnChance *= num2;
			Artifacts.ancientDice_spawnChance *= num2;
			Artifacts.cheese_spawnChance *= num2;
			Artifacts.wolfClaw_spawnChance *= num2;
			Artifacts.axe_spawnChance *= num2;
			Artifacts.rune_spawnChance *= num2;
			Artifacts.skull_spawnChance *= num2;
		}
		if (SkillTree.finalUpgrade_purchased)
		{
			float num3 = 10000f;
			Artifacts.horn_spawnChance *= num3;
			Artifacts.ancientDevice_spawnChance *= num3;
			Artifacts.bone_spawnChance *= num3;
			Artifacts.meteorieOre_spawnChance *= num3;
			Artifacts.book_spawnChance *= num3;
			Artifacts.goldStack_spawnChance *= num3;
			Artifacts.goldRing_spawnChance *= num3;
			Artifacts.purpleRing_spawnChance *= num3;
			Artifacts.ancientDice_spawnChance *= num3;
			Artifacts.cheese_spawnChance *= num3;
			Artifacts.wolfClaw_spawnChance *= num3;
			Artifacts.axe_spawnChance *= num3;
			Artifacts.rune_spawnChance *= num3;
			Artifacts.skull_spawnChance *= num3;
		}
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00003F28 File Offset: 0x00002128
	public void ArtifactDropChances()
	{
		if (!Tutorial.pressedOkCraftingTurotialFrame)
		{
			return;
		}
		if (!Artifacts.horn_found && !Artifacts.oneArtifactSpawned && Random.Range(0f, 1f) < Artifacts.horn_spawnChance)
		{
			Artifacts.oneArtifactSpawned = true;
			Artifacts.horn_spawned = true;
		}
		if (!Artifacts.ancientDevice_found && !Artifacts.oneArtifactSpawned && Random.Range(0f, 1f) < Artifacts.ancientDevice_spawnChance)
		{
			Artifacts.oneArtifactSpawned = true;
			Artifacts.ancientDevice_spawned = true;
		}
		if (!Artifacts.bone_found && !Artifacts.oneArtifactSpawned && Random.Range(0f, 1f) < Artifacts.bone_spawnChance)
		{
			Artifacts.oneArtifactSpawned = true;
			Artifacts.bone_spawned = true;
		}
		if (!Artifacts.meteorieOre_found && !Artifacts.oneArtifactSpawned && Random.Range(0f, 1f) < Artifacts.meteorieOre_spawnChance)
		{
			Artifacts.oneArtifactSpawned = true;
			Artifacts.meteorieOre_spawned = true;
		}
		if (!Artifacts.book_found && !Artifacts.oneArtifactSpawned && Random.Range(0f, 1f) < Artifacts.book_spawnChance)
		{
			Artifacts.oneArtifactSpawned = true;
			Artifacts.book_spawned = true;
		}
		if (!Artifacts.goldStack_found && !Artifacts.oneArtifactSpawned && Random.Range(0f, 1f) < Artifacts.goldStack_spawnChance)
		{
			Artifacts.oneArtifactSpawned = true;
			Artifacts.goldStack_spawned = true;
		}
		if (!Artifacts.goldRing_found && !Artifacts.oneArtifactSpawned && Random.Range(0f, 1f) < Artifacts.goldRing_spawnChance)
		{
			Artifacts.oneArtifactSpawned = true;
			Artifacts.goldRing_spawned = true;
		}
		if (!Artifacts.purpleRing_found && !Artifacts.oneArtifactSpawned && Random.Range(0f, 1f) < Artifacts.purpleRing_spawnChance)
		{
			Artifacts.oneArtifactSpawned = true;
			Artifacts.purpleRing_spawned = true;
		}
		if (!Artifacts.ancientDice_found && !Artifacts.oneArtifactSpawned && Random.Range(0f, 1f) < Artifacts.ancientDice_spawnChance)
		{
			Artifacts.oneArtifactSpawned = true;
			Artifacts.ancientDice_spawned = true;
		}
		if (!Artifacts.cheese_found && !Artifacts.oneArtifactSpawned && Random.Range(0f, 1f) < Artifacts.cheese_spawnChance)
		{
			Artifacts.oneArtifactSpawned = true;
			Artifacts.cheese_spawned = true;
		}
		if (!Artifacts.wolfClaw_found && !Artifacts.oneArtifactSpawned && Random.Range(0f, 1f) < Artifacts.wolfClaw_spawnChance)
		{
			Artifacts.oneArtifactSpawned = true;
			Artifacts.wolfClaw_spawned = true;
		}
		if (!Artifacts.axe_found && !Artifacts.oneArtifactSpawned && Random.Range(0f, 1f) < Artifacts.axe_spawnChance)
		{
			Artifacts.oneArtifactSpawned = true;
			Artifacts.axe_spawned = true;
		}
		if (!Artifacts.rune_found && !Artifacts.oneArtifactSpawned && Random.Range(0f, 1f) < Artifacts.rune_spawnChance)
		{
			Artifacts.oneArtifactSpawned = true;
			Artifacts.rune_spawned = true;
		}
		if (!Artifacts.skull_found && !Artifacts.oneArtifactSpawned && Random.Range(0f, 1f) < Artifacts.skull_spawnChance)
		{
			Artifacts.oneArtifactSpawned = true;
			Artifacts.skull_spawned = true;
		}
		if (Artifacts.oneArtifactSpawned)
		{
			this.spawnProjectilesScript.SelectRandomActiveRock(7);
		}
	}

	// Token: 0x06000028 RID: 40 RVA: 0x000041F0 File Offset: 0x000023F0
	public void CheckFoundArtifacts()
	{
		if (Artifacts.horn_found)
		{
			this.horn_StageIcon.SetActive(true);
		}
		if (Artifacts.ancientDevice_found)
		{
			this.ancientDevice_stageIcon.SetActive(true);
		}
		if (Artifacts.bone_found)
		{
			this.bone_stageIcon.SetActive(true);
		}
		if (Artifacts.meteorieOre_found)
		{
			this.meteorieOre_stageIcon.SetActive(true);
		}
		if (Artifacts.book_found)
		{
			this.book_stageIcon.SetActive(true);
		}
		if (Artifacts.goldStack_found)
		{
			this.goldStack_stageIcon.SetActive(true);
		}
		if (Artifacts.goldRing_found)
		{
			this.goldRing_stageIcon.SetActive(true);
		}
		if (Artifacts.purpleRing_found)
		{
			this.purpleRing_stageIcon.SetActive(true);
		}
		if (Artifacts.ancientDice_found)
		{
			this.ancientDice_stageIcon.SetActive(true);
		}
		if (Artifacts.cheese_found)
		{
			this.cheese_stageIcon.SetActive(true);
		}
		if (Artifacts.wolfClaw_found)
		{
			this.wolfClaw_stageIcon.SetActive(true);
			Artifacts.wolfClawPickaxePowerIncrease = 0.06f;
		}
		if (Artifacts.axe_found)
		{
			this.axe_stageIcon.SetActive(true);
		}
		if (Artifacts.rune_found)
		{
			this.rune_stageIcon.SetActive(true);
		}
		if (Artifacts.skull_found)
		{
			this.skullStageIcon.SetActive(true);
		}
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00004314 File Offset: 0x00002514
	public void SetArtifactFrame(int artifactNumber)
	{
		if (!Tutorial.pressedOkArtifact)
		{
			this.tutorialScript.SetTutorial(5);
		}
		this.artifactBtnExcl.SetActive(true);
		this.horn_frameIcon.SetActive(false);
		this.ancientDevice_frameIcon.SetActive(false);
		this.bone_frameIcon.SetActive(false);
		this.meteorieOre_frameIcon.SetActive(false);
		this.book_frameIcon.SetActive(false);
		this.goldStack_frameIcon.SetActive(false);
		this.goldRing_frameIcon.SetActive(false);
		this.purpleRing_frameIcon.SetActive(false);
		this.ancientDice_frameIcon.SetActive(false);
		this.cheese_frameIcon.SetActive(false);
		this.wolfClaw_frameIcon.SetActive(false);
		this.axe_frameIcon.SetActive(false);
		this.rune_frameIcon.SetActive(false);
		this.skull_frameIcon.SetActive(false);
		this.artifactFound = "<wave>" + LocalizationScript.artifactFound + "\n";
		this.artifactOkBtn.SetActive(true);
		this.artifactFoundFrame.SetActive(true);
		this.artifactParticle.Play();
		if (artifactNumber == 1)
		{
			this.horn_frameIcon.SetActive(true);
			this.artifactName = LocalizationScript.horn + "</wave>";
			this.horn_shadow.SetActive(true);
			this.horn_Excl.SetActive(true);
		}
		if (artifactNumber == 2)
		{
			this.ancientDevice_frameIcon.SetActive(true);
			this.artifactName = LocalizationScript.device + "</wave>";
			this.ancientDevice_shadow.SetActive(true);
			this.ancientDevice_Excl.SetActive(true);
		}
		if (artifactNumber == 3)
		{
			this.bone_frameIcon.SetActive(true);
			this.artifactName = LocalizationScript.bone + "</wave>";
			this.bone_shadow.SetActive(true);
			this.bone_Excl.SetActive(true);
		}
		if (artifactNumber == 4)
		{
			this.meteorieOre_frameIcon.SetActive(true);
			this.artifactName = LocalizationScript.meteorite + "</wave>";
			this.meteorieOre_shadow.SetActive(true);
			this.meteorieOre_Excl.SetActive(true);
		}
		if (artifactNumber == 5)
		{
			this.book_frameIcon.SetActive(true);
			this.artifactName = LocalizationScript.book + "</wave>";
			this.book_shadow.SetActive(true);
			this.book_Excl.SetActive(true);
		}
		if (artifactNumber == 6)
		{
			this.goldStack_frameIcon.SetActive(true);
			this.artifactName = LocalizationScript.sack + "</wave>";
			this.goldStack_shadow.SetActive(true);
			this.goldStack_Excl.SetActive(true);
		}
		if (artifactNumber == 7)
		{
			this.goldRing_frameIcon.SetActive(true);
			this.artifactName = LocalizationScript.goldRing + "</wave>";
			this.goldRing_shadow.SetActive(true);
			this.goldRing_Excl.SetActive(true);
		}
		if (artifactNumber == 8)
		{
			this.purpleRing_frameIcon.SetActive(true);
			this.artifactName = LocalizationScript.royalRing + "</wave>";
			this.purpleRing_shadow.SetActive(true);
			this.purpleRing_Excl.SetActive(true);
		}
		if (artifactNumber == 9)
		{
			this.ancientDice_frameIcon.SetActive(true);
			this.artifactName = LocalizationScript.dice + "</wave>";
			this.ancientDice_shadow.SetActive(true);
			this.ancientDice_Excl.SetActive(true);
		}
		if (artifactNumber == 10)
		{
			this.cheese_frameIcon.SetActive(true);
			this.artifactName = LocalizationScript.cheese + "</wave>";
			this.cheese_shadow.SetActive(true);
			this.cheese_Excl.SetActive(true);
		}
		if (artifactNumber == 11)
		{
			this.wolfClaw_frameIcon.SetActive(true);
			this.artifactName = LocalizationScript.wolf + "</wave>";
			this.wolfClaw_shadow.SetActive(true);
			this.wolfClaw_Excl.SetActive(true);
		}
		if (artifactNumber == 12)
		{
			this.axe_frameIcon.SetActive(true);
			this.artifactName = LocalizationScript.axe + "</wave>";
			this.axe_shadow.SetActive(true);
			this.axe_Excl.SetActive(true);
		}
		if (artifactNumber == 13)
		{
			this.rune_frameIcon.SetActive(true);
			this.artifactName = LocalizationScript.runestone + "</wave>";
			this.rune_shadow.SetActive(true);
			this.rune_Excl.SetActive(true);
			Artifacts.runeImproveAll = 0.05f;
		}
		if (artifactNumber == 14)
		{
			this.skull_frameIcon.SetActive(true);
			this.artifactName = LocalizationScript.skull + "</wave>";
			this.skull_shadow.SetActive(true);
			this.skull_Excl.SetActive(true);
		}
		this.artifactFoundText.text = this.artifactFound + this.artifactName;
	}

	// Token: 0x0600002A RID: 42 RVA: 0x000047A7 File Offset: 0x000029A7
	private IEnumerator ArtiFactOkButton()
	{
		yield return new WaitForSeconds(0.5f);
		this.artifactOkBtn.SetActive(true);
		yield break;
	}

	// Token: 0x0600002B RID: 43 RVA: 0x000047B6 File Offset: 0x000029B6
	public void PressOkArtifact()
	{
		this.audioManager.Play("UI_Click1");
		Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
		this.artifactOkBtn.SetActive(false);
		this.artifactFoundFrame.SetActive(false);
	}

	// Token: 0x0600002C RID: 44 RVA: 0x000047EC File Offset: 0x000029EC
	public void OpenArtifactTooltip()
	{
		if (MobileAndTesting.isMobile)
		{
			this.audioManager.Play("UI_Click1");
			this.artifactTooltip.transform.localScale = new Vector2(2.1f, 2.1f);
			this.artifactTooltip.transform.localPosition = new Vector2(0f, 45f);
			this.artifactDARK.SetActive(true);
			this.artifactTooltip.SetActive(true);
			this.closeArtifactBtn.SetActive(true);
		}
	}

	// Token: 0x0600002D RID: 45 RVA: 0x0000487C File Offset: 0x00002A7C
	public void CloseArtifactTooltip()
	{
		this.audioManager.Play("UI_Click1");
		this.artifactTooltip.SetActive(false);
		this.closeArtifactBtn.SetActive(false);
	}

	// Token: 0x0600002E RID: 46 RVA: 0x000048A8 File Offset: 0x00002AA8
	public void LoadData(GameData data)
	{
		Artifacts.artifactsFound = data.artifactsFound;
		Artifacts.horn_found = data.horn_found;
		Artifacts.ancientDevice_found = data.ancientDevice_found;
		Artifacts.bone_found = data.bone_found;
		Artifacts.meteorieOre_found = data.meteorieOre_found;
		Artifacts.book_found = data.book_found;
		Artifacts.goldStack_found = data.goldStack_found;
		Artifacts.goldRing_found = data.goldRing_found;
		Artifacts.purpleRing_found = data.purpleRing_found;
		Artifacts.ancientDice_found = data.ancientDice_found;
		Artifacts.cheese_found = data.cheese_found;
		Artifacts.wolfClaw_found = data.wolfClaw_found;
		Artifacts.axe_found = data.axe_found;
		Artifacts.rune_found = data.rune_found;
		Artifacts.skull_found = data.skull_found;
	}

	// Token: 0x0600002F RID: 47 RVA: 0x0000495C File Offset: 0x00002B5C
	public void SaveData(ref GameData data)
	{
		data.artifactsFound = Artifacts.artifactsFound;
		data.horn_found = Artifacts.horn_found;
		data.ancientDevice_found = Artifacts.ancientDevice_found;
		data.bone_found = Artifacts.bone_found;
		data.meteorieOre_found = Artifacts.meteorieOre_found;
		data.book_found = Artifacts.book_found;
		data.goldStack_found = Artifacts.goldStack_found;
		data.goldRing_found = Artifacts.goldRing_found;
		data.purpleRing_found = Artifacts.purpleRing_found;
		data.ancientDice_found = Artifacts.ancientDice_found;
		data.cheese_found = Artifacts.cheese_found;
		data.wolfClaw_found = Artifacts.wolfClaw_found;
		data.axe_found = Artifacts.axe_found;
		data.rune_found = Artifacts.rune_found;
		data.skull_found = Artifacts.skull_found;
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00004A20 File Offset: 0x00002C20
	public void ResetArtifacts()
	{
		Artifacts.artifactsFound = 0;
		Artifacts.horn_found = false;
		Artifacts.ancientDevice_found = false;
		Artifacts.bone_found = false;
		Artifacts.meteorieOre_found = false;
		Artifacts.book_found = false;
		Artifacts.goldStack_found = false;
		Artifacts.goldRing_found = false;
		Artifacts.purpleRing_found = false;
		Artifacts.ancientDice_found = false;
		Artifacts.cheese_found = false;
		Artifacts.wolfClaw_found = false;
		Artifacts.axe_found = false;
		Artifacts.rune_found = false;
		Artifacts.skull_found = false;
		this.horn_StageIcon.SetActive(false);
		this.horn_shadow.SetActive(false);
		this.ancientDevice_stageIcon.SetActive(false);
		this.ancientDevice_shadow.SetActive(false);
		this.bone_stageIcon.SetActive(false);
		this.bone_shadow.SetActive(false);
		this.meteorieOre_stageIcon.SetActive(false);
		this.meteorieOre_shadow.SetActive(false);
		this.book_stageIcon.SetActive(false);
		this.book_shadow.SetActive(false);
		this.goldStack_stageIcon.SetActive(false);
		this.goldStack_shadow.SetActive(false);
		this.goldRing_stageIcon.SetActive(false);
		this.goldRing_shadow.SetActive(false);
		this.purpleRing_stageIcon.SetActive(false);
		this.purpleRing_shadow.SetActive(false);
		this.ancientDice_stageIcon.SetActive(false);
		this.ancientDice_shadow.SetActive(false);
		this.cheese_stageIcon.SetActive(false);
		this.cheese_shadow.SetActive(false);
		this.wolfClaw_stageIcon.SetActive(false);
		this.wolfClaw_shadow.SetActive(false);
		this.axe_stageIcon.SetActive(false);
		this.axe_shadow.SetActive(false);
		this.rune_stageIcon.SetActive(false);
		this.rune_shadow.SetActive(false);
		this.skullStageIcon.SetActive(false);
		this.skull_shadow.SetActive(false);
		this.SetArtifactChances();
	}

	// Token: 0x040000D7 RID: 215
	public AudioManager audioManager;

	// Token: 0x040000D8 RID: 216
	public Tutorial tutorialScript;

	// Token: 0x040000D9 RID: 217
	public GameObject horn_StageIcon;

	// Token: 0x040000DA RID: 218
	public GameObject ancientDevice_stageIcon;

	// Token: 0x040000DB RID: 219
	public GameObject bone_stageIcon;

	// Token: 0x040000DC RID: 220
	public GameObject meteorieOre_stageIcon;

	// Token: 0x040000DD RID: 221
	public GameObject book_stageIcon;

	// Token: 0x040000DE RID: 222
	public GameObject goldStack_stageIcon;

	// Token: 0x040000DF RID: 223
	public GameObject goldRing_stageIcon;

	// Token: 0x040000E0 RID: 224
	public GameObject purpleRing_stageIcon;

	// Token: 0x040000E1 RID: 225
	public GameObject ancientDice_stageIcon;

	// Token: 0x040000E2 RID: 226
	public GameObject cheese_stageIcon;

	// Token: 0x040000E3 RID: 227
	public GameObject wolfClaw_stageIcon;

	// Token: 0x040000E4 RID: 228
	public GameObject axe_stageIcon;

	// Token: 0x040000E5 RID: 229
	public GameObject rune_stageIcon;

	// Token: 0x040000E6 RID: 230
	public GameObject skullStageIcon;

	// Token: 0x040000E7 RID: 231
	public GameObject horn_frameIcon;

	// Token: 0x040000E8 RID: 232
	public GameObject ancientDevice_frameIcon;

	// Token: 0x040000E9 RID: 233
	public GameObject bone_frameIcon;

	// Token: 0x040000EA RID: 234
	public GameObject meteorieOre_frameIcon;

	// Token: 0x040000EB RID: 235
	public GameObject book_frameIcon;

	// Token: 0x040000EC RID: 236
	public GameObject goldStack_frameIcon;

	// Token: 0x040000ED RID: 237
	public GameObject goldRing_frameIcon;

	// Token: 0x040000EE RID: 238
	public GameObject purpleRing_frameIcon;

	// Token: 0x040000EF RID: 239
	public GameObject ancientDice_frameIcon;

	// Token: 0x040000F0 RID: 240
	public GameObject cheese_frameIcon;

	// Token: 0x040000F1 RID: 241
	public GameObject wolfClaw_frameIcon;

	// Token: 0x040000F2 RID: 242
	public GameObject axe_frameIcon;

	// Token: 0x040000F3 RID: 243
	public GameObject rune_frameIcon;

	// Token: 0x040000F4 RID: 244
	public GameObject skull_frameIcon;

	// Token: 0x040000F5 RID: 245
	public GameObject horn_shadow;

	// Token: 0x040000F6 RID: 246
	public GameObject ancientDevice_shadow;

	// Token: 0x040000F7 RID: 247
	public GameObject bone_shadow;

	// Token: 0x040000F8 RID: 248
	public GameObject meteorieOre_shadow;

	// Token: 0x040000F9 RID: 249
	public GameObject book_shadow;

	// Token: 0x040000FA RID: 250
	public GameObject goldStack_shadow;

	// Token: 0x040000FB RID: 251
	public GameObject goldRing_shadow;

	// Token: 0x040000FC RID: 252
	public GameObject purpleRing_shadow;

	// Token: 0x040000FD RID: 253
	public GameObject ancientDice_shadow;

	// Token: 0x040000FE RID: 254
	public GameObject cheese_shadow;

	// Token: 0x040000FF RID: 255
	public GameObject wolfClaw_shadow;

	// Token: 0x04000100 RID: 256
	public GameObject axe_shadow;

	// Token: 0x04000101 RID: 257
	public GameObject rune_shadow;

	// Token: 0x04000102 RID: 258
	public GameObject skull_shadow;

	// Token: 0x04000103 RID: 259
	public GameObject horn_Excl;

	// Token: 0x04000104 RID: 260
	public GameObject ancientDevice_Excl;

	// Token: 0x04000105 RID: 261
	public GameObject bone_Excl;

	// Token: 0x04000106 RID: 262
	public GameObject meteorieOre_Excl;

	// Token: 0x04000107 RID: 263
	public GameObject book_Excl;

	// Token: 0x04000108 RID: 264
	public GameObject goldStack_Excl;

	// Token: 0x04000109 RID: 265
	public GameObject goldRing_Excl;

	// Token: 0x0400010A RID: 266
	public GameObject purpleRing_Excl;

	// Token: 0x0400010B RID: 267
	public GameObject ancientDice_Excl;

	// Token: 0x0400010C RID: 268
	public GameObject cheese_Excl;

	// Token: 0x0400010D RID: 269
	public GameObject wolfClaw_Excl;

	// Token: 0x0400010E RID: 270
	public GameObject axe_Excl;

	// Token: 0x0400010F RID: 271
	public GameObject rune_Excl;

	// Token: 0x04000110 RID: 272
	public GameObject skull_Excl;

	// Token: 0x04000111 RID: 273
	public static int artifactsFound;

	// Token: 0x04000112 RID: 274
	public static bool horn_found;

	// Token: 0x04000113 RID: 275
	public static bool ancientDevice_found;

	// Token: 0x04000114 RID: 276
	public static bool bone_found;

	// Token: 0x04000115 RID: 277
	public static bool meteorieOre_found;

	// Token: 0x04000116 RID: 278
	public static bool book_found;

	// Token: 0x04000117 RID: 279
	public static bool goldStack_found;

	// Token: 0x04000118 RID: 280
	public static bool goldRing_found;

	// Token: 0x04000119 RID: 281
	public static bool purpleRing_found;

	// Token: 0x0400011A RID: 282
	public static bool ancientDice_found;

	// Token: 0x0400011B RID: 283
	public static bool cheese_found;

	// Token: 0x0400011C RID: 284
	public static bool wolfClaw_found;

	// Token: 0x0400011D RID: 285
	public static bool axe_found;

	// Token: 0x0400011E RID: 286
	public static bool rune_found;

	// Token: 0x0400011F RID: 287
	public static bool skull_found;

	// Token: 0x04000120 RID: 288
	public static bool horn_spawned;

	// Token: 0x04000121 RID: 289
	public static bool ancientDevice_spawned;

	// Token: 0x04000122 RID: 290
	public static bool bone_spawned;

	// Token: 0x04000123 RID: 291
	public static bool meteorieOre_spawned;

	// Token: 0x04000124 RID: 292
	public static bool book_spawned;

	// Token: 0x04000125 RID: 293
	public static bool goldStack_spawned;

	// Token: 0x04000126 RID: 294
	public static bool goldRing_spawned;

	// Token: 0x04000127 RID: 295
	public static bool purpleRing_spawned;

	// Token: 0x04000128 RID: 296
	public static bool ancientDice_spawned;

	// Token: 0x04000129 RID: 297
	public static bool cheese_spawned;

	// Token: 0x0400012A RID: 298
	public static bool wolfClaw_spawned;

	// Token: 0x0400012B RID: 299
	public static bool axe_spawned;

	// Token: 0x0400012C RID: 300
	public static bool rune_spawned;

	// Token: 0x0400012D RID: 301
	public static bool skull_spawned;

	// Token: 0x0400012E RID: 302
	public static bool oneArtifactSpawned;

	// Token: 0x0400012F RID: 303
	public static bool oneArtifactMined;

	// Token: 0x04000130 RID: 304
	public SpawnProjectiles spawnProjectilesScript;

	// Token: 0x04000131 RID: 305
	public static float horn_spawnChance;

	// Token: 0x04000132 RID: 306
	public static float ancientDevice_spawnChance;

	// Token: 0x04000133 RID: 307
	public static float bone_spawnChance;

	// Token: 0x04000134 RID: 308
	public static float meteorieOre_spawnChance;

	// Token: 0x04000135 RID: 309
	public static float book_spawnChance;

	// Token: 0x04000136 RID: 310
	public static float goldStack_spawnChance;

	// Token: 0x04000137 RID: 311
	public static float goldRing_spawnChance;

	// Token: 0x04000138 RID: 312
	public static float purpleRing_spawnChance;

	// Token: 0x04000139 RID: 313
	public static float ancientDice_spawnChance;

	// Token: 0x0400013A RID: 314
	public static float cheese_spawnChance;

	// Token: 0x0400013B RID: 315
	public static float wolfClaw_spawnChance;

	// Token: 0x0400013C RID: 316
	public static float axe_spawnChance;

	// Token: 0x0400013D RID: 317
	public static float rune_spawnChance;

	// Token: 0x0400013E RID: 318
	public static float skull_spawnChance;

	// Token: 0x0400013F RID: 319
	public static bool minedRockWithArtifact;

	// Token: 0x04000140 RID: 320
	public static float wolfClawPickaxePowerIncrease;

	// Token: 0x04000141 RID: 321
	public static float runeImproveAll;

	// Token: 0x04000142 RID: 322
	public static float goldRingCraftChance;

	// Token: 0x04000143 RID: 323
	public static float hornRockDecrease;

	// Token: 0x04000144 RID: 324
	public static float ancientDeviceTimeReduction;

	// Token: 0x04000145 RID: 325
	public static float bonePickaxeIncrease;

	// Token: 0x04000146 RID: 326
	public static float meteoriteRockSpawnIncrease;

	// Token: 0x04000147 RID: 327
	public static float purpleRingChance;

	// Token: 0x04000148 RID: 328
	public static float cheeseChance;

	// Token: 0x04000149 RID: 329
	public static float clawChance;

	// Token: 0x0400014A RID: 330
	public static float runeIncrease_forDisplay;

	// Token: 0x0400014B RID: 331
	public static float diceTime;

	// Token: 0x0400014C RID: 332
	public GameObject artifactFoundFrame;

	// Token: 0x0400014D RID: 333
	public GameObject artifactOkBtn;

	// Token: 0x0400014E RID: 334
	public ParticleSystem artifactParticle;

	// Token: 0x0400014F RID: 335
	public string artifactFound;

	// Token: 0x04000150 RID: 336
	public string artifactName;

	// Token: 0x04000151 RID: 337
	public TextMeshProUGUI artifactFoundText;

	// Token: 0x04000152 RID: 338
	public GameObject artifactBtnExcl;

	// Token: 0x04000153 RID: 339
	public GameObject artifactTooltip;

	// Token: 0x04000154 RID: 340
	public GameObject closeArtifactBtn;

	// Token: 0x04000155 RID: 341
	public GameObject artifactDARK;

	// Token: 0x04000156 RID: 342
	public Animation artifactTooltipAnim;
}
