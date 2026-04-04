using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200002D RID: 45
public class MainMenu : MonoBehaviour
{
	// Token: 0x0600013B RID: 315 RVA: 0x0003CA37 File Offset: 0x0003AC37
	private void Awake()
	{
		this.fadeTime = 0f;
	}

	// Token: 0x0600013C RID: 316 RVA: 0x0003CA44 File Offset: 0x0003AC44
	public void PlayGame()
	{
		this.SetSkillTree();
		base.StartCoroutine(this.ScaleCircleCoroutine(true, true));
	}

	// Token: 0x0600013D RID: 317 RVA: 0x0003CA5C File Offset: 0x0003AC5C
	public void SetSkillTree()
	{
		if (SkillTree.totalSkillTreeUpgradesPurchased < 10)
		{
			SkillTreeDrag.defaultZoom = 2.1f;
		}
		else if (SkillTree.totalSkillTreeUpgradesPurchased < 25)
		{
			SkillTreeDrag.defaultZoom = 2.1f;
		}
		else if (SkillTree.totalSkillTreeUpgradesPurchased < 50)
		{
			SkillTreeDrag.defaultZoom = 2f;
		}
		else if (SkillTree.totalSkillTreeUpgradesPurchased < 75)
		{
			SkillTreeDrag.defaultZoom = 1.95f;
		}
		else if (SkillTree.totalSkillTreeUpgradesPurchased < 100)
		{
			SkillTreeDrag.defaultZoom = 1.9f;
		}
		else if (SkillTree.totalSkillTreeUpgradesPurchased < 125)
		{
			SkillTreeDrag.defaultZoom = 1.85f;
		}
		else if (SkillTree.totalSkillTreeUpgradesPurchased < 150)
		{
			SkillTreeDrag.defaultZoom = 1.8f;
		}
		else if (SkillTree.totalSkillTreeUpgradesPurchased < 175)
		{
			SkillTreeDrag.defaultZoom = 1.75f;
		}
		else if (SkillTree.totalSkillTreeUpgradesPurchased < 200)
		{
			SkillTreeDrag.defaultZoom = 1.7f;
		}
		else
		{
			SkillTreeDrag.defaultZoom = 1.2f;
		}
		if (MobileAndTesting.isMobile)
		{
			this.zoomSliderMobile.value = SkillTreeDrag.defaultZoom;
		}
		this.skillTreeDrag.transform.localPosition = new Vector2(0f, -53f);
		this.skillTreeContent.transform.localPosition = new Vector2(0f, 0f);
		SkillTreeDrag.targetScale = Vector3.one * SkillTreeDrag.defaultZoom;
		this.skillTreeDrag.transform.localScale = SkillTreeDrag.targetScale;
	}

	// Token: 0x0600013E RID: 318 RVA: 0x0003CBCA File Offset: 0x0003ADCA
	public void BackToTheMainMenu()
	{
		base.StartCoroutine(this.ScaleCircleCoroutine(true, false));
	}

	// Token: 0x0600013F RID: 319 RVA: 0x0003CBDC File Offset: 0x0003ADDC
	public void SelectScreen(string screenName)
	{
		if (screenName == "Upgrades")
		{
			if (MainMenu.currentScreen == 1)
			{
				return;
			}
		}
		else if (screenName == "TalentsBtn")
		{
			if (MainMenu.currentScreen == 2)
			{
				return;
			}
		}
		else if (screenName == "TheAnvilBtn")
		{
			if (MainMenu.currentScreen == 3)
			{
				return;
			}
		}
		else if (screenName == "TheMineBtn")
		{
			if (MainMenu.currentScreen == 4)
			{
				return;
			}
		}
		else if (screenName == "Artifacts_Btn" && MainMenu.currentScreen == 5)
		{
			return;
		}
		this.theMineInfoHover.SetActive(false);
		this.UIClickSound();
		this.CheckMinePopUps();
		this.unlockTalentsBtn.SetActive(false);
		this.totalTalentPointsFrame.SetActive(false);
		this.totalMaterialFramesParent.SetActive(false);
		this.unlockedTalentsParet.SetActive(false);
		this.unlockTheMineBtn.SetActive(false);
		this.theMineProgressBar.SetActive(false);
		this.theMineMiningSpeedUpgrade.SetActive(false);
		this.theMineOreUpgrade.SetActive(false);
		this.allTalentCardsChosenBlockBtn.SetActive(false);
		MainMenu.isInMainMenu = true;
		this.skillTreeScreen.SetActive(false);
		MainMenu.isInUpgrades = false;
		this.levelUpScreen.SetActive(false);
		MainMenu.isInTalents = false;
		this.anvilScreen.SetActive(false);
		MainMenu.isInTheAnvil = false;
		this.mineScreen.SetActive(false);
		MainMenu.isInTheMine = false;
		this.artifactScreen.SetActive(false);
		MainMenu.isInArtifacts = false;
		this.upgradesBtn.sprite = this.notSelectedSprite;
		this.talentsBtn.sprite = this.notSelectedSprite;
		this.theAnvilBtn.sprite = this.notSelectedSprite;
		this.theMineBtn.sprite = this.notSelectedSprite;
		this.artifactsBtn.sprite = this.notSelectedSprite;
		this.zoomSliderMobile.gameObject.SetActive(false);
		if (MobileAndTesting.isMobile)
		{
			this.theMineTooltip1.SetActive(false);
			this.theMineTooltip2.SetActive(false);
		}
		if (screenName == "Upgrades")
		{
			if (MobileAndTesting.isMobile)
			{
				this.zoomSliderMobile.gameObject.SetActive(true);
			}
			MainMenu.setTreeMiddle = false;
			this.blockRevealTalent.SetActive(false);
			this.dustParticleParent.SetActive(true);
			this.skillTreeBackground_tImage.SetActive(true);
			if (MainMenu.currentScreen == 1)
			{
				return;
			}
			this.CheckBackgroundsToFade(1);
			MainMenu.currentScreen = 1;
			this.totalMaterialFramesParent.SetActive(true);
			this.upgradesBtn.sprite = this.selectedYellowBtn;
			this.skillTreeScreen.SetActive(true);
			MainMenu.isInUpgrades = true;
		}
		else if (screenName == "TalentsBtn")
		{
			SetRockScreen.potionPickaxeStats_increase = 0f;
			this.levelScript.SetTalentTexts();
			if (!Tutorial.pressedOkTalent && LevelMechanics.level > 0)
			{
				this.talentTurotialFrame.SetActive(true);
			}
			this.talentBtnExcl.SetActive(false);
			if (LevelMechanics.isBlockFrameActive)
			{
				this.blockRevealTalent.SetActive(true);
			}
			else
			{
				this.blockRevealTalent.SetActive(false);
			}
			if (LevelMechanics.cardsLeft == 0)
			{
				this.allTalentCardsChosenBlockBtn.SetActive(true);
			}
			this.talentBackground_tImage.SetActive(true);
			if (MainMenu.currentScreen == 2)
			{
				return;
			}
			this.CheckBackgroundsToFade(2);
			MainMenu.currentScreen = 2;
			this.unlockTalentsBtn.SetActive(true);
			this.totalTalentPointsFrame.SetActive(true);
			this.unlockedTalentsParet.SetActive(true);
			this.talentsBtn.sprite = this.selectedYellowBtn;
			this.levelUpScreen.SetActive(true);
			MainMenu.isInTalents = true;
			this.levelScript.SetTalentTexts();
		}
		else if (screenName == "TheAnvilBtn")
		{
			if (!Tutorial.pressedOkAnvil && (SkillTree.improvedPickaxe_1_purchased || SkillTree.spawnMoreRocks_3_purchased))
			{
				this.theAnvilTutorialFrame.SetActive(true);
			}
			TheAnvil.isTheAnvilUnlocked = true;
			this.anvilBtnExcl.SetActive(false);
			this.blockRevealTalent.SetActive(false);
			this.anvilScript.DisplayEquippedAndSetStats(TheAnvil.equippedMineTime, TheAnvil.equippedMinePower, TheAnvil.equipped2XChance, TheAnvil.equippedMiningArea);
			SetRockScreen.potionPickaxeStats_increase = 0f;
			this.anvilScript.CheckPickaxes();
			this.theAnvilBackground_tImage.SetActive(true);
			if (MainMenu.currentScreen == 3)
			{
				return;
			}
			this.CheckBackgroundsToFade(3);
			MainMenu.currentScreen = 3;
			this.totalMaterialFramesParent.SetActive(true);
			this.theAnvilBtn.sprite = this.selectedYellowBtn;
			this.anvilScreen.SetActive(true);
			MainMenu.isInTheAnvil = true;
		}
		else if (screenName == "TheMineBtn")
		{
			if (!Tutorial.pressedOkMine && SkillTree.spawnCopper_purchased)
			{
				this.theMineTutorialFrame.SetActive(true);
			}
			this.theMineInfoHover.SetActive(true);
			this.mineBtnExcl.SetActive(false);
			this.blockRevealTalent.SetActive(false);
			this.theMineBackground.SetActive(true);
			if (MainMenu.currentScreen == 4)
			{
				return;
			}
			this.CheckBackgroundsToFade(4);
			MainMenu.currentScreen = 4;
			if (TheMine.isTheMineUnlocked)
			{
				if (MobileAndTesting.isMobile)
				{
					this.theMineTooltip1.SetActive(true);
					this.theMineTooltip2.SetActive(true);
				}
				this.unlockTheMineBtn.SetActive(false);
				this.theMineProgressBar.SetActive(true);
				this.theMineMiningSpeedUpgrade.SetActive(true);
				this.theMineOreUpgrade.SetActive(true);
			}
			else
			{
				this.unlockTheMineBtn.SetActive(true);
				this.theMineProgressBar.SetActive(false);
				this.theMineMiningSpeedUpgrade.SetActive(false);
				this.theMineOreUpgrade.SetActive(false);
			}
			this.totalMaterialFramesParent.SetActive(true);
			this.theMineBtn.sprite = this.selectedYellowBtn;
			this.mineScreen.SetActive(true);
			MainMenu.isInTheMine = true;
		}
		else if (screenName == "Artifacts_Btn")
		{
			if (!Tutorial.pressedOkArtifact && Artifacts.artifactsFound > 0)
			{
				this.artifactTutorialFrame.SetActive(true);
			}
			this.artifactBtnExcl.SetActive(false);
			this.blockRevealTalent.SetActive(false);
			this.artifactsBackground_tImage.SetActive(true);
			if (MainMenu.currentScreen == 5)
			{
				return;
			}
			this.CheckBackgroundsToFade(5);
			MainMenu.currentScreen = 5;
			this.artifactsBtn.sprite = this.selectedYellowBtn;
			this.artifactScreen.SetActive(true);
			MainMenu.isInArtifacts = true;
		}
		this.theMineScript.UpdateChances();
		if (!LevelMechanics.isInChoose1)
		{
			this.lockedTalent1.gameObject.SetActive(true);
			this.lockedTalent1.transform.localScale = new Vector3(1f, 1f, 1f);
			this.lockedTalent1.transform.localPosition = new Vector3(0f, 0f, 0f);
			this.lockedTalent2.gameObject.SetActive(true);
			this.lockedTalent2.transform.localScale = new Vector3(1f, 1f, 1f);
			this.lockedTalent2.transform.localPosition = new Vector3(0f, 0f, 0f);
			this.lockedTalent3.gameObject.SetActive(true);
			this.lockedTalent3.transform.localScale = new Vector3(1f, 1f, 1f);
			this.lockedTalent3.transform.localPosition = new Vector3(0f, 0f, 0f);
		}
	}

	// Token: 0x06000140 RID: 320 RVA: 0x0003D300 File Offset: 0x0003B500
	public void CheckMinePopUps()
	{
		foreach (GameObject gameObject in GameObject.FindGameObjectsWithTag("MinePopUp"))
		{
			if (gameObject.activeSelf)
			{
				ObjectPool.instance.ReturnTheMineMaterialFromPool(gameObject);
			}
		}
	}

	// Token: 0x06000141 RID: 321 RVA: 0x0003D340 File Offset: 0x0003B540
	public void CheckBackgroundsToFade(int backgroundToFadeIn)
	{
		this.skillTreeBackground.SetActive(false);
		this.talentBackground.SetActive(false);
		this.theAnvilBackground.SetActive(false);
		this.theMineBackground.SetActive(false);
		this.artifactsBackground.SetActive(false);
		this.skillTreeBackground_tImage.SetActive(false);
		this.talentBackground_tImage.SetActive(false);
		this.theAnvilBackground_tImage.SetActive(false);
		this.theMineBackground_tImage.SetActive(false);
		this.artifactsBackground_tImage.SetActive(false);
		if (backgroundToFadeIn == 1)
		{
			this.skillTreeBackground.SetActive(true);
			this.skillTreeBackground_tImage.SetActive(true);
		}
		if (backgroundToFadeIn == 2)
		{
			this.talentBackground.SetActive(true);
			this.talentBackground_tImage.SetActive(true);
		}
		if (backgroundToFadeIn == 3)
		{
			this.theAnvilBackground.SetActive(true);
			this.theAnvilBackground_tImage.SetActive(true);
		}
		if (backgroundToFadeIn == 4)
		{
			this.theMineBackground.SetActive(true);
			this.theMineBackground_tImage.SetActive(true);
		}
		if (backgroundToFadeIn == 5)
		{
			this.artifactsBackground.SetActive(true);
			this.artifactsBackground_tImage.SetActive(true);
		}
	}

	// Token: 0x06000142 RID: 322 RVA: 0x0003D451 File Offset: 0x0003B651
	public IEnumerator SetBackgroundsAlpha(GameObject objectToFade, bool fadeIn)
	{
		if (fadeIn)
		{
			objectToFade.SetActive(true);
		}
		float duration = this.fadeTime;
		float elapsedTime = 0f;
		Image[] images = objectToFade.GetComponentsInChildren<Image>(true);
		Color[] originalColors = new Color[images.Length];
		for (int i = 0; i < images.Length; i++)
		{
			originalColors[i] = images[i].color;
		}
		while (elapsedTime < duration)
		{
			float num = elapsedTime / duration;
			float a = fadeIn ? num : (1f - num);
			for (int j = 0; j < images.Length; j++)
			{
				Color color = originalColors[j];
				color.a = a;
				images[j].color = color;
			}
			elapsedTime += Time.unscaledDeltaTime;
			yield return null;
		}
		float a2 = fadeIn ? 1f : 0f;
		for (int k = 0; k < images.Length; k++)
		{
			Color color2 = originalColors[k];
			color2.a = a2;
			images[k].color = color2;
		}
		if (!fadeIn)
		{
			objectToFade.SetActive(false);
		}
		yield break;
	}

	// Token: 0x06000143 RID: 323 RVA: 0x0003D46E File Offset: 0x0003B66E
	public IEnumerator FadeSingleImage(GameObject target, bool fadeIn, float targetAlpha)
	{
		if (fadeIn)
		{
			target.SetActive(true);
		}
		float duration = this.fadeTime;
		float elapsedTime = 0f;
		Image image = target.GetComponent<Image>();
		Color originalColor = image.color;
		float startAlpha = fadeIn ? 0f : targetAlpha;
		float endAlpha = fadeIn ? targetAlpha : 0f;
		while (elapsedTime < duration)
		{
			float t = elapsedTime / duration;
			float a = Mathf.Lerp(startAlpha, endAlpha, t);
			Color color = originalColor;
			color.a = a;
			image.color = color;
			elapsedTime += Time.unscaledDeltaTime;
			yield return null;
		}
		Color color2 = originalColor;
		color2.a = endAlpha;
		image.color = color2;
		if (!fadeIn)
		{
			target.SetActive(false);
		}
		yield break;
	}

	// Token: 0x06000144 RID: 324 RVA: 0x0003D492 File Offset: 0x0003B692
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			this.OpenSettings();
		}
	}

	// Token: 0x06000145 RID: 325 RVA: 0x0003D4A4 File Offset: 0x0003B6A4
	public void KeepOnMiningBtn()
	{
		MainMenu.pressedKeepOnMining = true;
		this.rockScreenScript.SetUiStuff();
		MainMenu.isInUpgrades = false;
		MainMenu.isInTalents = false;
		MainMenu.isInTheAnvil = false;
		MainMenu.isInTheMine = false;
		MainMenu.isInArtifacts = false;
		this.rockScreenScript.KeepOnMining_MainMenu();
		MainMenu.isInMainMenu = false;
	}

	// Token: 0x06000146 RID: 326 RVA: 0x0003D4F4 File Offset: 0x0003B6F4
	public void OpenSettings()
	{
		if (SetRockScreen.isInMiningSession)
		{
			return;
		}
		if (SetRockScreen.isInEnding)
		{
			return;
		}
		if (AllStats.isInStats)
		{
			return;
		}
		if (this.creditsFrame.activeInHierarchy)
		{
			return;
		}
		if (MainMenu.isInTransition)
		{
			return;
		}
		if (MainMenu.pressedKeepOnMining)
		{
			return;
		}
		if (SkillTree.isInEndlessPopUp)
		{
			return;
		}
		if (!MobileAndTesting.isMobile)
		{
			this.flags.transform.localScale = new Vector2(0.84f, 0.84f);
			this.exitGameBtn.transform.localScale = new Vector2(1.55f, 1.55f);
			this.mainMenuBtn.transform.localScale = new Vector2(0.59f, 0.59f);
			this.resetGameBtn.transform.localScale = new Vector2(0.59f, 0.59f);
		}
		this.UIClickSound();
		if (this.settingsFrame.activeInHierarchy)
		{
			this.settingsFrame.SetActive(false);
			Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
			return;
		}
		this.settingsFrame.SetActive(true);
	}

	// Token: 0x06000147 RID: 327 RVA: 0x0003D611 File Offset: 0x0003B811
	private IEnumerator ScaleCircleCoroutine(bool scaleUp, bool startGame)
	{
		MainMenu.isInTransition = true;
		this.circleObject.SetActive(true);
		this.transitionBlock.SetActive(true);
		this.audioManager.Play("Transition");
		float scaleDuration = 0.4f;
		float num = scaleUp ? 0f : 26f;
		float num2 = scaleUp ? 26f : 0f;
		float elapsed = 0f;
		Vector3 initialScale = new Vector3(num, num, num);
		Vector3 targetScale = new Vector3(num2, num2, num2);
		this.circleObject.transform.localScale = initialScale;
		while (elapsed < scaleDuration)
		{
			elapsed += Time.deltaTime;
			float t = Mathf.Clamp01(elapsed / scaleDuration);
			this.circleObject.transform.localScale = Vector3.Lerp(initialScale, targetScale, t);
			yield return null;
		}
		if (!SetRockScreen.isInEnding)
		{
			if (!scaleUp)
			{
				this.endingScript.SoundVolumeSet("MainMenuMusic", true, TheEnding.gameMusicFullVolume - 0.3f, TheEnding.gameMusicFullVolume, 0.1f, false);
			}
			else
			{
				this.endingScript.SoundVolumeSet("MainMenuMusic", true, TheEnding.gameMusicFullVolume, TheEnding.gameMusicFullVolume - 0.3f, 0.1f, false);
			}
		}
		if (scaleUp && startGame)
		{
			if (!MobileAndTesting.isMobile)
			{
				this.flags.transform.localPosition = new Vector2(-414f, -339f);
			}
			this.backToMainMenuBtn.SetActive(true);
			this.startScreenCanvas.SetActive(false);
			this.startScreenBackground.SetActive(false);
			yield return new WaitForSeconds(0.5f);
			if (Tutorial.pressedOkMiningSession)
			{
				this.mainManuBackgrounds.SetActive(true);
				this.theMainMenu.SetActive(true);
				this.dustParticleParent.SetActive(true);
				this.skillTreeBackground_tImage.SetActive(true);
				this.CheckBackgroundsToFade(1);
				MainMenu.currentScreen = 0;
				this.SelectScreen("Upgrades");
				this.totalMaterialFramesParent.SetActive(true);
				this.upgradesBtn.sprite = this.selectedYellowBtn;
				this.skillTreeScreen.SetActive(true);
				MainMenu.isInUpgrades = true;
			}
			base.StartCoroutine(this.ScaleCircleCoroutine(false, true));
		}
		if (scaleUp && !startGame)
		{
			this.skillTreeScreen.SetActive(true);
			MainMenu.isInUpgrades = true;
			this.levelUpScreen.SetActive(false);
			MainMenu.isInTalents = false;
			this.anvilScreen.SetActive(false);
			MainMenu.isInTheAnvil = false;
			this.mineScreen.SetActive(false);
			MainMenu.isInTheMine = false;
			this.artifactScreen.SetActive(false);
			MainMenu.isInArtifacts = false;
			this.unlockTheMineBtn.SetActive(false);
			this.theMineProgressBar.SetActive(false);
			this.theMineMiningSpeedUpgrade.SetActive(false);
			this.theMineOreUpgrade.SetActive(false);
			this.unlockTalentsBtn.SetActive(false);
			this.totalTalentPointsFrame.SetActive(false);
			this.unlockedTalentsParet.SetActive(false);
			this.settingsFrame.SetActive(false);
			if (!MobileAndTesting.isMobile)
			{
				this.flags.transform.localPosition = new Vector2(-426f, -431f);
			}
			this.backToMainMenuBtn.SetActive(false);
			this.startScreenCanvas.SetActive(true);
			this.startScreenBackground.SetActive(true);
			yield return new WaitForSeconds(0.5f);
			base.StartCoroutine(this.ScaleCircleCoroutine(false, true));
		}
		this.circleObject.transform.localScale = targetScale;
		if (!scaleUp)
		{
			MainMenu.isInTransition = false;
			this.circleObject.SetActive(false);
			this.transitionBlock.SetActive(false);
		}
		yield break;
	}

	// Token: 0x06000148 RID: 328 RVA: 0x0003D62E File Offset: 0x0003B82E
	public void ExitGame()
	{
		Application.Quit();
	}

	// Token: 0x06000149 RID: 329 RVA: 0x0003D638 File Offset: 0x0003B838
	public void OpenStats()
	{
		this.UIClickSound();
		if (this.statsFrame.activeInHierarchy)
		{
			this.statsFrame.SetActive(false);
			AllStats.isInStats = false;
			Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
			return;
		}
		this.statsScript.CheckQuestionMarkText();
		this.statsFrame.SetActive(true);
		AllStats.isInStats = true;
	}

	// Token: 0x0600014A RID: 330 RVA: 0x0003D694 File Offset: 0x0003B894
	public void OpenCredits()
	{
		this.UIClickSound();
		if (this.creditsFrame.activeInHierarchy)
		{
			this.creditsFrame.SetActive(false);
			Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
			return;
		}
		this.creditsFrame.SetActive(true);
	}

	// Token: 0x0600014B RID: 331 RVA: 0x0003D6CE File Offset: 0x0003B8CE
	public void UIClickSound()
	{
		if (!MainMenu.isInTransition)
		{
			this.audioManager.Play("UI_Click1");
		}
	}

	// Token: 0x0600014C RID: 332 RVA: 0x0003D6E8 File Offset: 0x0003B8E8
	public void ResetBtn(bool open)
	{
		this.UIClickSound();
		this.resetYesBtn.transform.localScale = new Vector2(1f, 1f);
		this.resetNoBtn.transform.localScale = new Vector2(1f, 1f);
		if (open)
		{
			this.resetFrame.SetActive(true);
			return;
		}
		this.resetFrame.SetActive(false);
		Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
	}

	// Token: 0x0600014D RID: 333 RVA: 0x0003D76B File Offset: 0x0003B96B
	public void ResetTheEntireGame()
	{
		Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
		this.UIClickSound();
		base.StartCoroutine(this.ResetTransition(true));
	}

	// Token: 0x0600014E RID: 334 RVA: 0x0003D78D File Offset: 0x0003B98D
	private IEnumerator ResetTransition(bool scaleUp)
	{
		this.circleObject.SetActive(true);
		this.transitionBlock.SetActive(true);
		this.audioManager.Play("Transition");
		float scaleDuration = 0.4f;
		float num = scaleUp ? 0f : 26f;
		float num2 = scaleUp ? 26f : 0f;
		float elapsed = 0f;
		Vector3 initialScale = new Vector3(num, num, num);
		Vector3 targetScale = new Vector3(num2, num2, num2);
		this.circleObject.transform.localScale = initialScale;
		while (elapsed < scaleDuration)
		{
			elapsed += Time.deltaTime;
			float t = Mathf.Clamp01(elapsed / scaleDuration);
			this.circleObject.transform.localScale = Vector3.Lerp(initialScale, targetScale, t);
			yield return null;
		}
		if (scaleUp)
		{
			this.resetFrame.SetActive(false);
			this.theMineInfoHover.SetActive(false);
			this.skillTreeScript.ResetSkillTree();
			this.statsScript.ResetStats();
			this.artifactScript.ResetArtifacts();
			this.goldAndOreScript.ResetBars();
			this.levelScript.ResetLevel();
			this.theMineScript.ResetTheMine();
			this.anvilScript.ResetAnvil();
			this.spawnProjcetilesScript.ResetSpanwProjeciles();
			this.skillTreeScript.SkillTreePrices();
			this.hexagonColl.SetActive(false);
			this.squareColl.SetActive(false);
			this.totalFlowersObject.gameObject.SetActive(false);
			TheEnding.isEndingCompleted = false;
			this.levelUpScreen.SetActive(false);
			MainMenu.isInTalents = false;
			this.anvilScreen.SetActive(false);
			MainMenu.isInTheAnvil = false;
			this.mineScreen.SetActive(false);
			MainMenu.isInTheMine = false;
			this.artifactScreen.SetActive(false);
			MainMenu.isInArtifacts = false;
			this.settingsFrame.SetActive(false);
			this.skillTreeScreen.SetActive(true);
			this.skillTreeBackground.SetActive(true);
			this.skillTreeBackground_tImage.SetActive(true);
			this.startScreenBackground.SetActive(true);
			this.startScreenCanvas.SetActive(true);
			MainMenu.isInUpgrades = false;
			MainMenu.isInTalents = false;
			MainMenu.isInTheAnvil = false;
			MainMenu.isInTheMine = false;
			MainMenu.isInArtifacts = false;
			yield return new WaitForSeconds(0.7f);
			base.StartCoroutine(this.ResetTransition(false));
		}
		this.circleObject.transform.localScale = targetScale;
		if (!scaleUp)
		{
			this.circleObject.SetActive(false);
			this.transitionBlock.SetActive(false);
		}
		yield break;
	}

	// Token: 0x04000699 RID: 1689
	public SetRockScreen rockScreenScript;

	// Token: 0x0400069A RID: 1690
	public TheAnvil anvilScript;

	// Token: 0x0400069B RID: 1691
	public TheMine theMineScript;

	// Token: 0x0400069C RID: 1692
	public SkillTree skillTreeScript;

	// Token: 0x0400069D RID: 1693
	public GoldAndOreMechanics goldAndOreScript;

	// Token: 0x0400069E RID: 1694
	public Artifacts artifactScript;

	// Token: 0x0400069F RID: 1695
	public LevelMechanics levelScript;

	// Token: 0x040006A0 RID: 1696
	public TheEnding endingScript;

	// Token: 0x040006A1 RID: 1697
	public SpawnProjectiles spawnProjcetilesScript;

	// Token: 0x040006A2 RID: 1698
	public AudioManager audioManager;

	// Token: 0x040006A3 RID: 1699
	public GameObject theMainMenu;

	// Token: 0x040006A4 RID: 1700
	public GameObject mainManuBackgrounds;

	// Token: 0x040006A5 RID: 1701
	public Image upgradesBtn;

	// Token: 0x040006A6 RID: 1702
	public Image talentsBtn;

	// Token: 0x040006A7 RID: 1703
	public Image theAnvilBtn;

	// Token: 0x040006A8 RID: 1704
	public Image theMineBtn;

	// Token: 0x040006A9 RID: 1705
	public Image artifactsBtn;

	// Token: 0x040006AA RID: 1706
	public Sprite selectedYellowBtn;

	// Token: 0x040006AB RID: 1707
	public Sprite notSelectedSprite;

	// Token: 0x040006AC RID: 1708
	public GameObject skillTreeScreen;

	// Token: 0x040006AD RID: 1709
	public GameObject levelUpScreen;

	// Token: 0x040006AE RID: 1710
	public GameObject anvilScreen;

	// Token: 0x040006AF RID: 1711
	public GameObject mineScreen;

	// Token: 0x040006B0 RID: 1712
	public GameObject artifactScreen;

	// Token: 0x040006B1 RID: 1713
	public static bool isInMainMenu;

	// Token: 0x040006B2 RID: 1714
	public static bool isInUpgrades;

	// Token: 0x040006B3 RID: 1715
	public static bool isInTalents;

	// Token: 0x040006B4 RID: 1716
	public static bool isInTheAnvil;

	// Token: 0x040006B5 RID: 1717
	public static bool isInTheMine;

	// Token: 0x040006B6 RID: 1718
	public static bool isInArtifacts;

	// Token: 0x040006B7 RID: 1719
	public GameObject unlockTalentsBtn;

	// Token: 0x040006B8 RID: 1720
	public GameObject totalTalentPointsFrame;

	// Token: 0x040006B9 RID: 1721
	public GameObject totalMaterialFramesParent;

	// Token: 0x040006BA RID: 1722
	public GameObject unlockedTalentsParet;

	// Token: 0x040006BB RID: 1723
	public GameObject unlockTheMineBtn;

	// Token: 0x040006BC RID: 1724
	public GameObject theMineProgressBar;

	// Token: 0x040006BD RID: 1725
	public GameObject theMineMiningSpeedUpgrade;

	// Token: 0x040006BE RID: 1726
	public GameObject theMineOreUpgrade;

	// Token: 0x040006BF RID: 1727
	public GameObject skillTreeBackground;

	// Token: 0x040006C0 RID: 1728
	public GameObject talentBackground;

	// Token: 0x040006C1 RID: 1729
	public GameObject theAnvilBackground;

	// Token: 0x040006C2 RID: 1730
	public GameObject theMineBackground;

	// Token: 0x040006C3 RID: 1731
	public GameObject artifactsBackground;

	// Token: 0x040006C4 RID: 1732
	public GameObject dustParticleParent;

	// Token: 0x040006C5 RID: 1733
	public GameObject backgroundDark;

	// Token: 0x040006C6 RID: 1734
	public GameObject skillTreeBackground_tImage;

	// Token: 0x040006C7 RID: 1735
	public GameObject talentBackground_tImage;

	// Token: 0x040006C8 RID: 1736
	public GameObject theAnvilBackground_tImage;

	// Token: 0x040006C9 RID: 1737
	public GameObject theMineBackground_tImage;

	// Token: 0x040006CA RID: 1738
	public GameObject artifactsBackground_tImage;

	// Token: 0x040006CB RID: 1739
	public static int currentScreen;

	// Token: 0x040006CC RID: 1740
	public float fadeTime;

	// Token: 0x040006CD RID: 1741
	public GameObject startScreenCanvas;

	// Token: 0x040006CE RID: 1742
	public GameObject startScreenBackground;

	// Token: 0x040006CF RID: 1743
	public GameObject blockRevealTalent;

	// Token: 0x040006D0 RID: 1744
	public GameObject talentBtnExcl;

	// Token: 0x040006D1 RID: 1745
	public GameObject anvilBtnExcl;

	// Token: 0x040006D2 RID: 1746
	public GameObject mineBtnExcl;

	// Token: 0x040006D3 RID: 1747
	public GameObject artifactBtnExcl;

	// Token: 0x040006D4 RID: 1748
	public GameObject backToMainMenuBtn;

	// Token: 0x040006D5 RID: 1749
	public GameObject flags;

	// Token: 0x040006D6 RID: 1750
	public GameObject talentTurotialFrame;

	// Token: 0x040006D7 RID: 1751
	public GameObject theAnvilTutorialFrame;

	// Token: 0x040006D8 RID: 1752
	public GameObject theMineTutorialFrame;

	// Token: 0x040006D9 RID: 1753
	public GameObject artifactTutorialFrame;

	// Token: 0x040006DA RID: 1754
	public GameObject allTalentCardsChosenBlockBtn;

	// Token: 0x040006DB RID: 1755
	public GameObject exitGameBtn;

	// Token: 0x040006DC RID: 1756
	public GameObject resetGameBtn;

	// Token: 0x040006DD RID: 1757
	public GameObject mainMenuBtn;

	// Token: 0x040006DE RID: 1758
	public GameObject hexagonColl;

	// Token: 0x040006DF RID: 1759
	public GameObject squareColl;

	// Token: 0x040006E0 RID: 1760
	public GameObject totalFlowersObject;

	// Token: 0x040006E1 RID: 1761
	public GameObject theMineInfoHover;

	// Token: 0x040006E2 RID: 1762
	public static bool setTreeMiddle;

	// Token: 0x040006E3 RID: 1763
	public GameObject skillTreeDrag;

	// Token: 0x040006E4 RID: 1764
	public GameObject skillTreeContent;

	// Token: 0x040006E5 RID: 1765
	public GameObject lockedTalent1;

	// Token: 0x040006E6 RID: 1766
	public GameObject lockedTalent2;

	// Token: 0x040006E7 RID: 1767
	public GameObject lockedTalent3;

	// Token: 0x040006E8 RID: 1768
	public GameObject theMineTooltip1;

	// Token: 0x040006E9 RID: 1769
	public GameObject theMineTooltip2;

	// Token: 0x040006EA RID: 1770
	public Slider zoomSliderMobile;

	// Token: 0x040006EB RID: 1771
	public GameObject mainMenuScreen;

	// Token: 0x040006EC RID: 1772
	public static bool isInTransition;

	// Token: 0x040006ED RID: 1773
	public static bool pressedKeepOnMining;

	// Token: 0x040006EE RID: 1774
	public GameObject settingsFrame;

	// Token: 0x040006EF RID: 1775
	public GameObject circleObject;

	// Token: 0x040006F0 RID: 1776
	public GameObject transitionBlock;

	// Token: 0x040006F1 RID: 1777
	public GameObject statsFrame;

	// Token: 0x040006F2 RID: 1778
	public AllStats statsScript;

	// Token: 0x040006F3 RID: 1779
	public GameObject creditsFrame;

	// Token: 0x040006F4 RID: 1780
	public GameObject resetFrame;

	// Token: 0x040006F5 RID: 1781
	public GameObject resetYesBtn;

	// Token: 0x040006F6 RID: 1782
	public GameObject resetNoBtn;
}
