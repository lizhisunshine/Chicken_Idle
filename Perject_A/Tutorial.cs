using System;
using System.Collections;
using UnityEngine;

// Token: 0x0200003D RID: 61
public class Tutorial : MonoBehaviour, IDataPersistence
{
	// Token: 0x06000206 RID: 518 RVA: 0x00052F5E File Offset: 0x0005115E
	private void Awake()
	{
		this.startScreen.SetActive(true);
		this.startScreenBackground.SetActive(true);
	}

	// Token: 0x06000207 RID: 519 RVA: 0x00052F78 File Offset: 0x00051178
	private void Start()
	{
		base.StartCoroutine(this.Wait());
	}

	// Token: 0x06000208 RID: 520 RVA: 0x00052F87 File Offset: 0x00051187
	private IEnumerator Wait()
	{
		yield return new WaitForSeconds(0.1f);
		this.talentButton.SetActive(false);
		this.theAnvilButton.SetActive(false);
		this.theMineButton.SetActive(false);
		this.arifactButton.SetActive(false);
		if (!MobileAndTesting.isTesting)
		{
			if (!Tutorial.pressedOkMiningSession)
			{
				this.miningSessionTutorialFrame.SetActive(true);
				this.mainMenu.SetActive(false);
				this.mainMenuDark.SetActive(false);
			}
			else
			{
				this.miningSessionTutorialFrame.SetActive(false);
				this.mainMenu.SetActive(true);
				this.mainMenuDark.SetActive(true);
			}
		}
		else
		{
			this.talentButton.SetActive(true);
			this.theAnvilButton.SetActive(true);
			this.theMineButton.SetActive(true);
			this.arifactButton.SetActive(true);
		}
		if (Tutorial.pressedOkTalent)
		{
			this.talentButton.SetActive(true);
		}
		if (Tutorial.pressedOkAnvil)
		{
			this.theAnvilButton.SetActive(true);
		}
		if (Tutorial.pressedOkMine)
		{
			this.theMineButton.SetActive(true);
		}
		if (Tutorial.pressedOkArtifact)
		{
			this.arifactButton.SetActive(true);
		}
		if (LevelMechanics.level > 1)
		{
			this.talentButton.SetActive(true);
		}
		if (SkillTree.spawnMoreRocks_3_purchased)
		{
			this.theAnvilButton.SetActive(true);
		}
		if (SkillTree.fullGold_1_purchased)
		{
			this.theAnvilButton.SetActive(true);
		}
		if (SkillTree.improvedPickaxe_1_purchased)
		{
			this.theAnvilButton.SetActive(true);
		}
		if (SkillTree.spawnCopper_purchased)
		{
			this.theMineButton.SetActive(true);
		}
		yield break;
	}

	// Token: 0x06000209 RID: 521 RVA: 0x00052F98 File Offset: 0x00051198
	public void SetTutorial(int tutorialNumber)
	{
		if (MobileAndTesting.isTesting)
		{
			return;
		}
		if (tutorialNumber == 1)
		{
			this.oreAndCraftingTurotialFrame.SetActive(true);
		}
		if (tutorialNumber == 2)
		{
			this.talentExcl.SetActive(true);
			this.talentButton.SetActive(true);
		}
		if (tutorialNumber == 3)
		{
			this.anvilExcl.SetActive(true);
			this.theAnvilButton.SetActive(true);
		}
		if (tutorialNumber == 4)
		{
			this.mineExcl.SetActive(true);
			this.theMineButton.SetActive(true);
		}
		if (tutorialNumber == 5)
		{
			this.arifactExcl.SetActive(true);
			this.arifactButton.SetActive(true);
		}
	}

	// Token: 0x0600020A RID: 522 RVA: 0x00053030 File Offset: 0x00051230
	public void TurotialOkBtn(int tutorialNumber)
	{
		this.audioManager.Play("UI_Click1");
		Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
		if (tutorialNumber == 0)
		{
			this.miningSessionTutorialFrame.SetActive(false);
			Tutorial.pressedOkMiningSession = true;
			this.setRockScreenScript.StartWaveTutorialBtn();
		}
		if (tutorialNumber == 1)
		{
			this.oreAndCraftingTurotialFrame.SetActive(false);
			Tutorial.pressedOkCraftingTurotialFrame = true;
		}
		if (tutorialNumber == 2)
		{
			this.talentTurotialFrame.SetActive(false);
			Tutorial.pressedOkTalent = true;
		}
		if (tutorialNumber == 3)
		{
			this.theAnvilTutorialFrame.SetActive(false);
			Tutorial.pressedOkAnvil = true;
		}
		if (tutorialNumber == 4)
		{
			this.theMineTutorialFrame.SetActive(false);
			Tutorial.pressedOkMine = true;
		}
		if (tutorialNumber == 5)
		{
			this.artifactTutorialFrame.SetActive(false);
			Tutorial.pressedOkArtifact = true;
		}
	}

	// Token: 0x0600020B RID: 523 RVA: 0x000530E8 File Offset: 0x000512E8
	public void LoadData(GameData data)
	{
		Tutorial.pressedOkMiningSession = data.pressedOkMiningSession;
		Tutorial.pressedOkCraftingTurotialFrame = data.pressedOkCraftingTurotialFrame;
		Tutorial.pressedOkTalent = data.pressedOkTalent;
		Tutorial.pressedOkAnvil = data.pressedOkAnvil;
		Tutorial.pressedOkMine = data.pressedOkMine;
		Tutorial.pressedOkArtifact = data.pressedOkArtifact;
	}

	// Token: 0x0600020C RID: 524 RVA: 0x00053138 File Offset: 0x00051338
	public void SaveData(ref GameData data)
	{
		data.pressedOkMiningSession = Tutorial.pressedOkMiningSession;
		data.pressedOkCraftingTurotialFrame = Tutorial.pressedOkCraftingTurotialFrame;
		data.pressedOkTalent = Tutorial.pressedOkTalent;
		data.pressedOkAnvil = Tutorial.pressedOkAnvil;
		data.pressedOkMine = Tutorial.pressedOkMine;
		data.pressedOkArtifact = Tutorial.pressedOkArtifact;
	}

	// Token: 0x04000E44 RID: 3652
	public SetRockScreen setRockScreenScript;

	// Token: 0x04000E45 RID: 3653
	public AudioManager audioManager;

	// Token: 0x04000E46 RID: 3654
	public GameObject talentButton;

	// Token: 0x04000E47 RID: 3655
	public GameObject theAnvilButton;

	// Token: 0x04000E48 RID: 3656
	public GameObject theMineButton;

	// Token: 0x04000E49 RID: 3657
	public GameObject arifactButton;

	// Token: 0x04000E4A RID: 3658
	public GameObject talentExcl;

	// Token: 0x04000E4B RID: 3659
	public GameObject anvilExcl;

	// Token: 0x04000E4C RID: 3660
	public GameObject mineExcl;

	// Token: 0x04000E4D RID: 3661
	public GameObject arifactExcl;

	// Token: 0x04000E4E RID: 3662
	public GameObject miningSessionTutorialFrame;

	// Token: 0x04000E4F RID: 3663
	public GameObject oreAndCraftingTurotialFrame;

	// Token: 0x04000E50 RID: 3664
	public GameObject talentTurotialFrame;

	// Token: 0x04000E51 RID: 3665
	public GameObject theAnvilTutorialFrame;

	// Token: 0x04000E52 RID: 3666
	public GameObject theMineTutorialFrame;

	// Token: 0x04000E53 RID: 3667
	public GameObject artifactTutorialFrame;

	// Token: 0x04000E54 RID: 3668
	public static bool pressedOkMiningSession;

	// Token: 0x04000E55 RID: 3669
	public static bool pressedOkCraftingTurotialFrame;

	// Token: 0x04000E56 RID: 3670
	public static bool pressedOkTalent;

	// Token: 0x04000E57 RID: 3671
	public static bool pressedOkAnvil;

	// Token: 0x04000E58 RID: 3672
	public static bool pressedOkMine;

	// Token: 0x04000E59 RID: 3673
	public static bool pressedOkArtifact;

	// Token: 0x04000E5A RID: 3674
	public GameObject mainMenu;

	// Token: 0x04000E5B RID: 3675
	public GameObject startScreen;

	// Token: 0x04000E5C RID: 3676
	public GameObject startScreenBackground;

	// Token: 0x04000E5D RID: 3677
	public GameObject mainMenuDark;
}
