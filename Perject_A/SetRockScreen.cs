using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000035 RID: 53
public class SetRockScreen : MonoBehaviour
{
	// Token: 0x06000192 RID: 402 RVA: 0x0003F618 File Offset: 0x0003D818
	private void Awake()
	{
		this.circleObject.transform.localScale = new Vector2(24f, 24f);
		this.circleObject.SetActive(true);
		SetRockScreen.grassLayer = -346;
		this.mainCamera = Camera.main;
		SetRockScreen.rockZPos = 100f;
		this.tileZPos = 0f;
		this.startPos = new Vector2(1160f, 330f);
		base.StartCoroutine(this.SetAllTiles());
	}

	// Token: 0x06000193 RID: 403 RVA: 0x0003F6A1 File Offset: 0x0003D8A1
	private void Start()
	{
		this.handCollider.SetActive(false);
		base.StartCoroutine(this.Wait1Sec());
	}

	// Token: 0x06000194 RID: 404 RVA: 0x0003F6BC File Offset: 0x0003D8BC
	private void Update()
	{
		if (MobileAndTesting.isMobile)
		{
			this.normalCursorHand.SetActive(false);
		}
		Input.GetKeyDown(KeyCode.E);
		Vector3 position = Vector3.zero;
		if (!MobileAndTesting.isMobile)
		{
			Vector3 mousePosition = Input.mousePosition;
			position = this.mainCamera.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, this.mainCamera.nearClipPlane));
		}
		else
		{
			if (Input.touchCount <= 0)
			{
				return;
			}
			Vector3 vector = Input.GetTouch(0).position;
			position = this.mainCamera.ScreenToWorldPoint(new Vector3(vector.x, vector.y, this.mainCamera.nearClipPlane + 10f));
		}
		float num = 1f + LevelMechanics.inflationBurstIncrease;
		this.handCollider.transform.position = position;
		if (LevelMechanics.isDoubleAreaSize && !SkillTree.increaseAndDecreaseMinignErea_purchased)
		{
			this.handCollider_actualCollider.transform.localScale = new Vector2(TheAnvil.currentColliderSize * num, TheAnvil.currentColliderSize * num);
			this.hexagonCollider_actualCollider.transform.localScale = new Vector2(TheAnvil.currentColliderSize * num, TheAnvil.currentColliderSize * num);
			this.squareCollider_actualCollider.transform.localScale = new Vector2(TheAnvil.currentColliderSize * num, TheAnvil.currentColliderSize * num);
			return;
		}
		if (!LevelMechanics.isDoubleAreaSize && !SkillTree.increaseAndDecreaseMinignErea_purchased)
		{
			this.handCollider_actualCollider.transform.localScale = new Vector2(TheAnvil.currentColliderSize, TheAnvil.currentColliderSize);
			this.hexagonCollider_actualCollider.transform.localScale = new Vector2(TheAnvil.currentColliderSize, TheAnvil.currentColliderSize);
			this.squareCollider_actualCollider.transform.localScale = new Vector2(TheAnvil.currentColliderSize, TheAnvil.currentColliderSize);
			return;
		}
		if (!LevelMechanics.isDoubleAreaSize && SkillTree.increaseAndDecreaseMinignErea_purchased)
		{
			this.handCollider_actualCollider.transform.localScale = new Vector2(TheAnvil.currentColliderSize, TheAnvil.currentColliderSize);
			this.hexagonCollider_actualCollider.transform.localScale = new Vector2(TheAnvil.currentColliderSize, TheAnvil.currentColliderSize);
			this.squareCollider_actualCollider.transform.localScale = new Vector2(TheAnvil.currentColliderSize, TheAnvil.currentColliderSize);
		}
	}

	// Token: 0x06000195 RID: 405 RVA: 0x0003F90D File Offset: 0x0003DB0D
	private IEnumerator SetAllTiles()
	{
		int num = 13;
		float num2 = 600f;
		float num3 = -293f;
		for (int i = 0; i < 14; i++)
		{
			this.tileRow[num].transform.localScale = new Vector2(0.45562f, 0.45562f);
			Vector2 v = new Vector2(num2, num3);
			this.tileRow[num].transform.localPosition = v;
			num--;
			num2 -= 70f;
			num3 += 34.6f;
		}
		yield return new WaitForSeconds(0.25f);
		while (this.totalTimesSpawned < 196)
		{
			GameObject tileFromPool = ObjectPool.instance.GetTileFromPool();
			tileFromPool.transform.SetParent(this.tileRow[this.parentFilled].transform);
			tileFromPool.transform.localScale = new Vector2(61.5f, 61.5f);
			this.tileZPos -= 0.1f;
			Vector3 localPosition = new Vector3(this.startPos.x, this.startPos.y, this.tileZPos);
			tileFromPool.transform.localPosition = localPosition;
			float x = this.startPos.x - 153.5f;
			float y = this.startPos.y - 76.4f;
			this.startPos = new Vector2(x, y);
			this.totalTimesSpawned++;
			this.timesSpawned++;
			if (this.timesSpawned == 14)
			{
				this.timesSpawned = 0;
				this.parentFilled++;
				this.startPos = new Vector2(1160f, 330f);
			}
		}
		yield return new WaitForSeconds(0.1f);
		base.StartCoroutine(this.ScaleCircleCoroutine(false));
		if (MobileAndTesting.isTesting)
		{
			base.StartCoroutine(this.TileWaveAnim());
		}
		yield break;
	}

	// Token: 0x06000196 RID: 406 RVA: 0x0003F91C File Offset: 0x0003DB1C
	public void StartWaveTutorialBtn()
	{
		base.StartCoroutine(this.TileWaveAnim());
	}

	// Token: 0x06000197 RID: 407 RVA: 0x0003F92B File Offset: 0x0003DB2B
	private IEnumerator TileWaveAnim()
	{
		SetRockScreen.oresPopedUp = false;
		SpawnProjectiles.totalDynamitesOnScreen = 0;
		SpawnProjectiles.totalBeamsOnScreen = 0;
		SetRockScreen.totalRocksOnScreen = 0;
		LevelMechanics.xpThisRound = 0f;
		SetRockScreen.spawnedGoldenChest = false;
		SetRockScreen.doSpawnGoldenChest = false;
		if (LevelMechanics.goldenChests_chosen && Random.Range(0, 2) == 0)
		{
			SetRockScreen.doSpawnGoldenChest = true;
		}
		Artifacts.horn_spawned = false;
		Artifacts.ancientDevice_spawned = false;
		Artifacts.bone_spawned = false;
		Artifacts.meteorieOre_spawned = false;
		Artifacts.book_spawned = false;
		Artifacts.goldStack_spawned = false;
		Artifacts.goldRing_spawned = false;
		Artifacts.purpleRing_spawned = false;
		Artifacts.ancientDice_spawned = false;
		Artifacts.cheese_spawned = false;
		Artifacts.wolfClaw_spawned = false;
		Artifacts.axe_spawned = false;
		Artifacts.rune_spawned = false;
		Artifacts.skull_spawned = false;
		Artifacts.oneArtifactSpawned = false;
		Artifacts.minedRockWithArtifact = false;
		Artifacts.oneArtifactMined = false;
		if (SkillTree.mineSessionTime >= 10)
		{
			this.timerText.text = SkillTree.mineSessionTime.ToString("F0") + ":00";
		}
		else
		{
			this.timerText.text = "0" + SkillTree.mineSessionTime.ToString("F0") + ":00";
		}
		this.timerText.color = Color.white;
		this.isTimeStarted = false;
		this.rocksLeftAdded = 0;
		SetRockScreen.timeLeft = (float)SkillTree.mineSessionTime;
		int num;
		for (int i = 0; i < this.tileRow.Length; i = num + 1)
		{
			base.StartCoroutine(this.TileUpAndDown(this.tileRow[i].transform));
			yield return new WaitForSeconds(0.065f);
			num = i;
		}
		yield break;
	}

	// Token: 0x06000198 RID: 408 RVA: 0x0003F93A File Offset: 0x0003DB3A
	private IEnumerator TileUpAndDown(Transform tileTransform)
	{
		float num = (float)SkillTree.totalRocksToSpawn / 14f;
		float num2 = num - Mathf.Floor(num);
		int num3 = SkillTree.totalRocksToSpawn % 14;
		this.SpawnRockCount((int)num);
		if (Random.Range(0f, 1f) <= num2)
		{
			if (this.rocksLeftAdded < num3)
			{
				this.SpawnRockCount(1);
			}
			this.rocksLeftAdded++;
		}
		if (SetRockScreen.tileWaveNumber == 13 && this.rocksLeftAdded < num3)
		{
			this.SpawnRockCount(num3 - this.rocksLeftAdded);
		}
		SetRockScreen.tileWaveNumber++;
		Vector3 startPos = tileTransform.localPosition;
		Vector3 upPos = startPos + new Vector3(0f, 63f, 0f);
		float num4 = 0.21f;
		float halfDuration = num4 / 2f;
		float t = 0f;
		this.audioManager.Play("Wave");
		while (t < halfDuration)
		{
			t += Time.deltaTime;
			float t2 = t / halfDuration;
			tileTransform.localPosition = Vector3.Lerp(startPos, upPos, t2);
			yield return null;
		}
		t = 0f;
		while (t < halfDuration)
		{
			t += Time.deltaTime;
			float t3 = t / halfDuration;
			tileTransform.localPosition = Vector3.Lerp(upPos, startPos, t3);
			yield return null;
		}
		tileTransform.localPosition = startPos;
		if (SetRockScreen.tileWaveNumber == 14 && !this.isTimeStarted)
		{
			this.isTimeStarted = true;
			base.StartCoroutine(this.StartTimer());
		}
		yield break;
	}

	// Token: 0x06000199 RID: 409 RVA: 0x0003F950 File Offset: 0x0003DB50
	public void SpawnRockCount(int count)
	{
		if (SetRockScreen.isInEnding)
		{
			return;
		}
		if (SetRockScreen.totalRocksOnScreen > 450)
		{
			return;
		}
		for (int i = 0; i < count; i++)
		{
			AllStats.totalRocksSpawned++;
			GameObject rockFromPool = ObjectPool.instance.GetRockFromPool();
			rockFromPool.transform.SetParent(this.rockParent[SetRockScreen.tileWaveNumber]);
			Vector2 v = new Vector2((float)Random.Range(77, -77), Random.Range(-1.5f, 1.5f));
			rockFromPool.transform.localPosition = v;
			rockFromPool.transform.SetParent(this.originalRockParent);
			float x = rockFromPool.transform.localPosition.x;
			float y = rockFromPool.transform.localPosition.y;
			rockFromPool.transform.localPosition = new Vector3(x, y, y);
			int num = Random.Range(1, 3);
			if (num == 1)
			{
				rockFromPool.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
			}
			else if (num == 2)
			{
				rockFromPool.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
			}
			this.totalRocksSpawned++;
			if (!Artifacts.oneArtifactSpawned)
			{
				this.artifactsScript.ArtifactDropChances();
			}
		}
	}

	// Token: 0x0600019A RID: 410 RVA: 0x0003FA9F File Offset: 0x0003DC9F
	private IEnumerator StartTimer()
	{
		if (LevelMechanics.potionDrinker_chosen && !LevelMechanics.potionChugger_chosen)
		{
			AllStats.potionsDrank++;
		}
		if (LevelMechanics.potionChugger_chosen)
		{
			AllStats.potionsDrank += 4;
		}
		AllStats.miningSessions++;
		LevelMechanics.didLevelUp = false;
		LevelMechanics.didLevelUpTotalTalentPoints = 0;
		base.StartCoroutine(this.SpawnMineOrTimesUpText(true));
		yield return new WaitForSeconds(1f);
		SetRockScreen.isInMiningSession = true;
		Cursor.visible = false;
		this.handCollider.SetActive(true);
		if (MobileAndTesting.isMobile)
		{
			this.handCollider.transform.localPosition = new Vector2(-1439f, 900f);
		}
		if (SkillTree.lightningBeamChanceS_1_purchased || SkillTree.lightningBeamChanceS_2_purchased)
		{
			this.spawnProjectilesScript.SpawnLightningS();
		}
		if (SkillTree.spawnPickaxeEverySecond_1_purchased || SkillTree.spawnPickaxeEverySecond_2_purchased || SkillTree.spawnPickaxeEverySecond_3_purchased)
		{
			this.spawnProjectilesScript.SpawnPickaxe();
		}
		if (SkillTree.spawnXRockEveryXSecond_1_purchased || SkillTree.spawnXRockEveryXSecond_2_purchased || SkillTree.spawnXRockEveryXSecond_3_purchased)
		{
			SpawnRocks.spawnRockCoroutine = null;
			this.spawnRocksScript.SpawnRockXSecond();
		}
		if (SkillTree.plazmaBallSpawn_1_purchased || SkillTree.plazmaBallSpawn_2_purchased)
		{
			this.spawnProjectilesScript.SpawnPlazmaBalls();
		}
		if (Artifacts.ancientDice_found)
		{
			SpawnRocks.ancientDiceRockSpawn = null;
			this.spawnRocksScript.SpawnRockDice();
		}
		SetRockScreen.currentTime = 0f;
		float reachTime = (float)SkillTree.mineSessionTime;
		float oneSecondTimer = 0f;
		while (SetRockScreen.currentTime < reachTime)
		{
			if (reachTime - SetRockScreen.currentTime < 3f)
			{
				this.timerText.color = Color.red;
			}
			else
			{
				this.timerText.color = Color.white;
			}
			SetRockScreen.currentTime += Time.deltaTime;
			float num = SetRockScreen.timeLeft = Mathf.Max(0f, reachTime - SetRockScreen.currentTime);
			int num2 = (int)num;
			int num3 = (int)((num - (float)num2) * 100f);
			this.timerText.text = string.Format("{0:00}:{1:00}", num2, num3);
			oneSecondTimer += Time.deltaTime;
			if (oneSecondTimer >= 1f)
			{
				AllStats.timeSpentMining++;
				oneSecondTimer = 0f;
			}
			yield return null;
		}
		AllStats.timeSpentMining++;
		Cursor.visible = true;
		this.timerText.text = "00:00";
		this.ResetTimeISUpStuff();
		base.StartCoroutine(this.SpawnMineOrTimesUpText(false));
		SetRockScreen.isInMiningSession = false;
		if ((SkillTree.spawnXRockEveryXSecond_1_purchased || SkillTree.spawnXRockEveryXSecond_2_purchased || SkillTree.spawnXRockEveryXSecond_3_purchased) && SpawnRocks.spawnRockCoroutine != null)
		{
			this.spawnRocksScript.StopCoroutine(SpawnRocks.spawnRockCoroutine);
		}
		if (Artifacts.ancientDice_found && SpawnRocks.ancientDiceRockSpawn != null)
		{
			this.spawnRocksScript.StopCoroutine(SpawnRocks.ancientDiceRockSpawn);
			SpawnRocks.ancientDiceRockSpawn = null;
		}
		yield break;
	}

	// Token: 0x0600019B RID: 411 RVA: 0x0003FAAE File Offset: 0x0003DCAE
	private IEnumerator Wait1Sec()
	{
		for (;;)
		{
			yield return new WaitForSeconds(1f);
			if (SetRockScreen.isInMiningSession && SkillTree.chanceToAdd1SecondEverySecond_purchased && (float)Random.Range(0, 100) < SkillTree.chanceToAdd1SecEverySec)
			{
				SetRockScreen.currentTime -= 1f;
			}
		}
		yield break;
	}

	// Token: 0x0600019C RID: 412 RVA: 0x0003FAB6 File Offset: 0x0003DCB6
	private IEnumerator SpawnMineOrTimesUpText(bool miningStarted)
	{
		if (miningStarted)
		{
			this.textFrameText.text = "<bounce>" + LocalizationScript.startMining + "</bounce>";
			this.audioManager.Play("StartMining");
			if ((SkillTree.lightningBeamChanceS_1_purchased || SkillTree.lightningBeamChanceS_2_purchased) && SetRockScreen.isInEnding)
			{
				this.spawnProjectilesScript.SpawnLightningS();
			}
		}
		else
		{
			this.textFrameText.text = "<wave>" + LocalizationScript.outOfTime + "</wave>";
			this.handCollider.SetActive(false);
			this.audioManager.Play("OutOfTime");
		}
		this.textFrameAnim.gameObject.SetActive(true);
		this.textFrameText.gameObject.SetActive(true);
		this.textFrameAnim.Play("TextFrameAnim");
		yield return new WaitForSeconds(0.3f);
		yield return new WaitForSeconds(0.45f);
		if (miningStarted)
		{
			this.textFrameAnim.Play("TextFrameAnimDown");
		}
		if (miningStarted)
		{
			yield return new WaitForSeconds(0.25f);
		}
		else
		{
			yield return new WaitForSeconds(0.37f);
		}
		this.textFrameAnim.gameObject.SetActive(false);
		this.textFrameText.gameObject.SetActive(false);
		if (SetRockScreen.pressEnding)
		{
			this.handCollider.SetActive(true);
			SetRockScreen.isInMiningSession = true;
			Cursor.visible = false;
		}
		if (!miningStarted)
		{
			base.StartCoroutine(this.OpenTimeIsOutFrame());
		}
		yield break;
	}

	// Token: 0x0600019D RID: 413 RVA: 0x0003FACC File Offset: 0x0003DCCC
	public void BackToUpgradesOrKeepMining(bool backToUpgrade)
	{
		SetRockScreen.tileWaveNumber = 0;
		this.circleObject.SetActive(false);
		base.StartCoroutine(this.ScaleCircleCoroutine(true));
		SetRockScreen.pressEnding = false;
		base.StartCoroutine(this.ScaleCircleDownAgain(backToUpgrade));
		if (backToUpgrade)
		{
			this.mainMenuScript.SetSkillTree();
			MainMenu.pressedKeepOnMining = false;
			MainMenu.currentScreen = 0;
			this.mainMenuScript.SelectScreen("Upgrades");
		}
	}

	// Token: 0x0600019E RID: 414 RVA: 0x0003FB37 File Offset: 0x0003DD37
	private IEnumerator ScaleCircleDownAgain(bool backToUpgrade)
	{
		yield return new WaitForSeconds(0.85f);
		base.StartCoroutine(this.ScaleCircleCoroutine(false));
		if (backToUpgrade)
		{
			this.mainMenu.SetActive(true);
			this.backgroundDark.SetActive(true);
			this.SetStuffBackToObjectPool();
		}
		else
		{
			this.dustParticleParent.SetActive(false);
			this.backgroundDark.SetActive(false);
			this.mainMenu.SetActive(false);
			this.timeIsUpFrame.SetActive(false);
			this.SetStuffBackToObjectPool();
			if (LevelMechanics.springSeason_chosen)
			{
				this.SetFlowers();
			}
			if (LevelMechanics.camper_chosen)
			{
				this.SetCampfire();
			}
			else
			{
				this.campfire.SetActive(false);
			}
			this.circleGold.SetActive(false);
			this.hexagonGold.SetActive(false);
			this.squareGold.SetActive(false);
			if (LevelMechanics.goldenTouch_chosen)
			{
				this.circleNormal.SetActive(true);
				this.circleGold.SetActive(false);
				this.hexagonNormal.SetActive(true);
				this.hexagonGold.SetActive(false);
				this.squareNormal.SetActive(true);
				this.squareGold.SetActive(false);
				if (Random.Range(0f, 100f) < (float)LevelMechanics.midasTouchChance)
				{
					AllStats.midasTouchSessions++;
					if (MobileAndTesting.isMobile)
					{
						this.normalCursorHand.SetActive(false);
						this.goldenHand.SetActive(false);
					}
					SetRockScreen.isGoldenHand = true;
					if (MobileAndTesting.isMobile)
					{
						this.circleNormal.SetActive(false);
						this.circleGold.SetActive(true);
						this.hexagonNormal.SetActive(false);
						this.hexagonGold.SetActive(true);
						this.squareNormal.SetActive(false);
						this.squareGold.SetActive(true);
						this.goldenHand.SetActive(false);
					}
					else
					{
						this.goldenHand.SetActive(true);
						this.normalCursorHand.SetActive(false);
						this.circleGold.SetActive(false);
						this.hexagonGold.SetActive(false);
						this.squareGold.SetActive(false);
					}
				}
				else
				{
					if (MobileAndTesting.isMobile)
					{
						this.normalCursorHand.SetActive(false);
						this.goldenHand.SetActive(false);
					}
					else
					{
						this.normalCursorHand.SetActive(true);
						this.goldenHand.SetActive(false);
					}
					SetRockScreen.isGoldenHand = false;
				}
			}
			else
			{
				if (MobileAndTesting.isMobile)
				{
					this.goldenHand.SetActive(false);
					this.normalCursorHand.SetActive(false);
				}
				else
				{
					this.normalCursorHand.SetActive(true);
				}
				SetRockScreen.isGoldenHand = false;
			}
			SetRockScreen.tileWaveNumber = 0;
			yield return new WaitForSeconds(0.6f);
			if (!SetRockScreen.pressEnding)
			{
				base.StartCoroutine(this.TileWaveAnim());
			}
			else
			{
				base.StartCoroutine(this.SpawnMineOrTimesUpText(true));
			}
		}
		yield break;
	}

	// Token: 0x0600019F RID: 415 RVA: 0x0003FB4D File Offset: 0x0003DD4D
	private IEnumerator ScaleCircleCoroutine(bool scaleUp)
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
		if (SetRockScreen.pressEnding)
		{
			this.audioManager.Play("CreditsMusic");
			this.endingScript.SoundVolumeSet("CreditsMusic", false, 0f, 0f, 0.1f, false);
		}
		if (scaleUp)
		{
			this.ResetBetweenTransitions();
			this.copperOreFrame.SetActive(false);
			this.ironOreFrame.SetActive(false);
			this.cobaltOreFrame.SetActive(false);
			this.uraniumOre_frame.SetActive(false);
			this.ismiumOre_frame.SetActive(false);
			this.iridiumOre_frame.SetActive(false);
			this.painiteOre_frame.SetActive(false);
			if (SkillTree.spawnCopper_purchased)
			{
				this.copperOreFrame.SetActive(true);
			}
			if (SkillTree.spawnIron_purchased)
			{
				this.ironOreFrame.SetActive(true);
			}
			if (SkillTree.cobaltSpawn_purchased)
			{
				this.cobaltOreFrame.SetActive(true);
			}
			if (SkillTree.uraniumSpawn_purchased)
			{
				this.uraniumOre_frame.SetActive(true);
			}
			if (SkillTree.ismiumSpawn_purchased)
			{
				this.ismiumOre_frame.SetActive(true);
			}
			if (SkillTree.iridiumSpawn_purchased)
			{
				this.iridiumOre_frame.SetActive(true);
			}
			if (SkillTree.painiteSpawn_purchased)
			{
				this.painiteOre_frame.SetActive(true);
			}
			this.copperOreFrame.transform.localPosition = new Vector2(-108f, -76f);
			this.ironOreFrame.transform.localPosition = new Vector2(108.7f, -76f);
			this.cobaltOreFrame.transform.localPosition = new Vector2(-108f, -129f);
			this.uraniumOre_frame.transform.localPosition = new Vector2(108f, -129f);
			this.ismiumOre_frame.transform.localPosition = new Vector2(-108f, -182f);
			this.iridiumOre_frame.transform.localPosition = new Vector2(108f, -182f);
			this.painiteOre_frame.transform.localPosition = new Vector2(-108f, -235f);
		}
		this.circleObject.transform.localScale = targetScale;
		if (!scaleUp)
		{
			this.transitionBlock.SetActive(false);
			this.circleObject.SetActive(false);
			MainMenu.isInTransition = false;
		}
		yield break;
	}

	// Token: 0x060001A0 RID: 416 RVA: 0x0003FB64 File Offset: 0x0003DD64
	public void SetAllMaterialTextsInactive()
	{
		this.chunks_mined.gameObject.SetActive(false);
		this.goldBar_crafted.gameObject.SetActive(false);
		this.totalGoldBars.gameObject.SetActive(false);
		this.chunksMined_Copper.gameObject.SetActive(false);
		this.goldBarsCrafted_Copper.gameObject.SetActive(false);
		this.totalGoldBars_Copper.gameObject.SetActive(false);
		this.chunksMined_Silver.gameObject.SetActive(false);
		this.goldBarsCrafted_Silver.gameObject.SetActive(false);
		this.totalGoldBars_Silver.gameObject.SetActive(false);
		this.chunksMined_Cobalt.gameObject.SetActive(false);
		this.goldBarsCrafted_Cobalt.gameObject.SetActive(false);
		this.totalGoldBars_Cobalt.gameObject.SetActive(false);
		this.chunksMined_Uranium.gameObject.SetActive(false);
		this.goldBarsCrafted_Uranium.gameObject.SetActive(false);
		this.totalGoldBars_Uranium.gameObject.SetActive(false);
		this.chunksMined_Ismium.gameObject.SetActive(false);
		this.goldBarsCrafted_Ismium.gameObject.SetActive(false);
		this.totalGoldBars_Ismium.gameObject.SetActive(false);
		this.chunksMined_Iridium.gameObject.SetActive(false);
		this.goldBarsCrafted_Iridium.gameObject.SetActive(false);
		this.totalGoldBars_Iridium.gameObject.SetActive(false);
		this.chunksMined_Painite.gameObject.SetActive(false);
		this.goldBarsCrafted_Painite.gameObject.SetActive(false);
		this.totalGoldBars_Painite.gameObject.SetActive(false);
		this.resourcesGatheredText.SetActive(false);
		this.resourcesCraftedText.SetActive(false);
		this.totalResourcesText.SetActive(false);
		this.xpParent.SetActive(false);
		this.xpGathereredText.SetActive(false);
		this.miningSessionDoneText.SetActive(false);
		this.levelUpText.SetActive(false);
		this.didLevelUpTalentPointsParent.gameObject.SetActive(false);
	}

	// Token: 0x060001A1 RID: 417 RVA: 0x0003FD6E File Offset: 0x0003DF6E
	private IEnumerator OpenTimeIsOutFrame()
	{
		this.miningSessionDoneText.transform.localPosition = new Vector2(0f, 285f);
		this.miningSessionDoneText.transform.localScale = new Vector2(1.55f, 1.55f);
		if (Artifacts.oneArtifactMined)
		{
			this.audioManager.Play("FoundArtifact");
			if (Artifacts.horn_spawned)
			{
				this.artifactsScript.SetArtifactFrame(1);
				Artifacts.artifactsFound++;
			}
			if (Artifacts.ancientDevice_spawned)
			{
				this.artifactsScript.SetArtifactFrame(2);
				Artifacts.artifactsFound++;
			}
			if (Artifacts.bone_spawned)
			{
				this.artifactsScript.SetArtifactFrame(3);
				Artifacts.artifactsFound++;
			}
			if (Artifacts.meteorieOre_spawned)
			{
				this.artifactsScript.SetArtifactFrame(4);
				Artifacts.artifactsFound++;
			}
			if (Artifacts.book_spawned)
			{
				this.artifactsScript.SetArtifactFrame(5);
				Artifacts.artifactsFound++;
			}
			if (Artifacts.goldStack_spawned)
			{
				this.artifactsScript.SetArtifactFrame(6);
				Artifacts.artifactsFound++;
			}
			if (Artifacts.goldRing_spawned)
			{
				this.artifactsScript.SetArtifactFrame(7);
				Artifacts.artifactsFound++;
			}
			if (Artifacts.purpleRing_spawned)
			{
				this.artifactsScript.SetArtifactFrame(8);
				Artifacts.artifactsFound++;
			}
			if (Artifacts.ancientDice_spawned)
			{
				this.artifactsScript.SetArtifactFrame(9);
				Artifacts.artifactsFound++;
			}
			if (Artifacts.cheese_spawned)
			{
				this.artifactsScript.SetArtifactFrame(10);
				Artifacts.artifactsFound++;
			}
			if (Artifacts.wolfClaw_spawned)
			{
				this.artifactsScript.SetArtifactFrame(11);
				Artifacts.artifactsFound++;
			}
			if (Artifacts.axe_spawned)
			{
				this.artifactsScript.SetArtifactFrame(12);
				Artifacts.artifactsFound++;
			}
			if (Artifacts.rune_spawned)
			{
				this.artifactsScript.SetArtifactFrame(13);
				Artifacts.artifactsFound++;
			}
			if (Artifacts.skull_spawned)
			{
				this.artifactsScript.SetArtifactFrame(14);
				Artifacts.artifactsFound++;
			}
		}
		bool flag = false;
		if (LevelMechanics.d100_chosen)
		{
			this.D100.SetActive(true);
			int num = Random.Range(1, 101);
			if (num == 100 || num == 1 || num == 10)
			{
				AllStats.d100Rolls++;
				this.D100text.text = string.Format("{0} {1}\n{2}", LocalizationScript.rolled, num, LocalizationScript.oresTripled);
				flag = true;
			}
			else
			{
				this.D100text.text = string.Format("{0} {1}", LocalizationScript.rolled, num);
			}
		}
		else
		{
			this.D100.SetActive(false);
		}
		this.SetAllMaterialTextsInactive();
		this.resourcesGatheredText.transform.localScale = new Vector2(1.3f, 1.3f);
		this.resourcesCraftedText.transform.localScale = new Vector2(1.3f, 1.3f);
		this.totalResourcesText.transform.localScale = new Vector2(1.3f, 1.3f);
		float x = 0f;
		float x2 = 183f;
		if (LevelMechanics.didLevelUp)
		{
			this.levelUpTalentPoints.text = string.Format("+{0}", LevelMechanics.didLevelUpTotalTalentPoints);
			x = -183f;
		}
		if (SkillTree.totalMaterialRocksSpawning == 1)
		{
			this.resourcesGatheredText.transform.localPosition = new Vector2(-370f, 156f);
			this.resourcesCraftedText.transform.localPosition = new Vector2(0f, 156f);
			this.totalResourcesText.transform.localPosition = new Vector2(370f, 156f);
			this.resourcesGathered_parent.transform.localPosition = new Vector2(-397f, 79f);
			this.resourcesGathered_parent.transform.localScale = new Vector2(10f, 10f);
			this.resourcesCrafted_parent.transform.localPosition = new Vector2(0f, 79f);
			this.resourcesCrafted_parent.transform.localScale = new Vector2(10f, 10f);
			this.totalResources_parent.transform.localPosition = new Vector2(330f, 79f);
			this.totalResources_parent.transform.localScale = new Vector2(10f, 10f);
			this.xpGathereredText.transform.localPosition = new Vector2(x, -51f);
			this.xpGathereredText.transform.localScale = new Vector2(1.2f, 1.2f);
			this.xpParent.transform.localPosition = new Vector2(x, -121f);
			this.xpParent.transform.localScale = new Vector2(13f, 13f);
			this.levelUpText.transform.localPosition = new Vector2(x2, -51f);
			this.levelUpText.transform.localScale = new Vector2(1.2f, 1.2f);
			this.didLevelUpTalentPointsParent.transform.localPosition = new Vector2(x2, -121f);
			this.didLevelUpTalentPointsParent.transform.localScale = new Vector2(13f, 13f);
		}
		if (SkillTree.totalMaterialRocksSpawning == 2)
		{
			this.resourcesGatheredText.transform.localPosition = new Vector2(-370f, 173f);
			this.resourcesCraftedText.transform.localPosition = new Vector2(0f, 173f);
			this.totalResourcesText.transform.localPosition = new Vector2(370f, 173f);
			this.resourcesGathered_parent.transform.localPosition = new Vector2(-398f, 96f);
			this.resourcesGathered_parent.transform.localScale = new Vector2(10f, 10f);
			this.resourcesCrafted_parent.transform.localPosition = new Vector2(0f, 96f);
			this.resourcesCrafted_parent.transform.localScale = new Vector2(10f, 10f);
			this.totalResources_parent.transform.localPosition = new Vector2(326f, 96f);
			this.totalResources_parent.transform.localScale = new Vector2(10f, 10f);
			this.xpGathereredText.transform.localPosition = new Vector2(x, -73f);
			this.xpGathereredText.transform.localScale = new Vector2(1.12f, 1.12f);
			this.xpParent.transform.localPosition = new Vector2(x, -143f);
			this.xpParent.transform.localScale = new Vector2(12.3f, 12.3f);
			this.levelUpText.transform.localPosition = new Vector2(x2, -73f);
			this.levelUpText.transform.localScale = new Vector2(1.12f, 1.12f);
			this.didLevelUpTalentPointsParent.transform.localPosition = new Vector2(x2, -143f);
			this.didLevelUpTalentPointsParent.transform.localScale = new Vector2(12.3f, 12.3f);
		}
		if (SkillTree.totalMaterialRocksSpawning == 3)
		{
			this.resourcesGatheredText.transform.localPosition = new Vector2(-370f, 173f);
			this.resourcesCraftedText.transform.localPosition = new Vector2(0f, 173f);
			this.totalResourcesText.transform.localPosition = new Vector2(370f, 173f);
			this.resourcesGathered_parent.transform.localPosition = new Vector2(-396f, 109f);
			this.resourcesGathered_parent.transform.localScale = new Vector2(8.7f, 8.7f);
			this.resourcesCrafted_parent.transform.localPosition = new Vector2(0f, 109f);
			this.resourcesCrafted_parent.transform.localScale = new Vector2(8.7f, 8.7f);
			this.totalResources_parent.transform.localPosition = new Vector2(337f, 109f);
			this.totalResources_parent.transform.localScale = new Vector2(8.7f, 8.7f);
			this.xpGathereredText.transform.localPosition = new Vector2(x, -92f);
			this.xpGathereredText.transform.localScale = new Vector2(1f, 1f);
			this.xpParent.transform.localPosition = new Vector2(x, -159f);
			this.xpParent.transform.localScale = new Vector2(10.6f, 10.6f);
			this.levelUpText.transform.localPosition = new Vector2(x2, -92f);
			this.levelUpText.transform.localScale = new Vector2(1f, 1f);
			this.didLevelUpTalentPointsParent.transform.localPosition = new Vector2(x2, -159f);
			this.didLevelUpTalentPointsParent.transform.localScale = new Vector2(10.6f, 10.6f);
		}
		if (SkillTree.totalMaterialRocksSpawning == 4)
		{
			this.resourcesGatheredText.transform.localPosition = new Vector2(-370f, 197f);
			this.resourcesCraftedText.transform.localPosition = new Vector2(0f, 197f);
			this.totalResourcesText.transform.localPosition = new Vector2(370f, 197f);
			this.resourcesGathered_parent.transform.localPosition = new Vector2(-392f, 133f);
			this.resourcesGathered_parent.transform.localScale = new Vector2(7.9f, 7.9f);
			this.resourcesCrafted_parent.transform.localPosition = new Vector2(0f, 133f);
			this.resourcesCrafted_parent.transform.localScale = new Vector2(7.9f, 7.9f);
			this.totalResources_parent.transform.localPosition = new Vector2(337f, 133f);
			this.totalResources_parent.transform.localScale = new Vector2(7.9f, 7.9f);
			this.xpGathereredText.transform.localPosition = new Vector2(x, -97f);
			this.xpGathereredText.transform.localScale = new Vector2(0.98f, 0.98f);
			this.xpParent.transform.localPosition = new Vector2(x, -164f);
			this.xpParent.transform.localScale = new Vector2(10.6f, 10.6f);
			this.levelUpText.transform.localPosition = new Vector2(x2, -97f);
			this.levelUpText.transform.localScale = new Vector2(0.98f, 0.98f);
			this.didLevelUpTalentPointsParent.transform.localPosition = new Vector2(x2, -164f);
			this.didLevelUpTalentPointsParent.transform.localScale = new Vector2(10.6f, 10.6f);
		}
		if (SkillTree.totalMaterialRocksSpawning == 5)
		{
			this.resourcesGatheredText.transform.localPosition = new Vector2(-370f, 203f);
			this.resourcesCraftedText.transform.localPosition = new Vector2(0f, 203f);
			this.totalResourcesText.transform.localPosition = new Vector2(370f, 203f);
			this.resourcesGathered_parent.transform.localPosition = new Vector2(-391f, 144f);
			this.resourcesGathered_parent.transform.localScale = new Vector2(7f, 7f);
			this.resourcesCrafted_parent.transform.localPosition = new Vector2(0f, 144f);
			this.resourcesCrafted_parent.transform.localScale = new Vector2(7f, 7f);
			this.totalResources_parent.transform.localPosition = new Vector2(342f, 144f);
			this.totalResources_parent.transform.localScale = new Vector2(7f, 7f);
			this.xpGathereredText.transform.localPosition = new Vector2(x, -108f);
			this.xpGathereredText.transform.localScale = new Vector2(0.98f, 0.98f);
			this.xpParent.transform.localPosition = new Vector2(x, -175f);
			this.xpParent.transform.localScale = new Vector2(10.6f, 10.6f);
			this.levelUpText.transform.localPosition = new Vector2(x2, -108f);
			this.levelUpText.transform.localScale = new Vector2(0.98f, 0.98f);
			this.didLevelUpTalentPointsParent.transform.localPosition = new Vector2(x2, -175f);
			this.didLevelUpTalentPointsParent.transform.localScale = new Vector2(10.6f, 10.6f);
		}
		if (SkillTree.totalMaterialRocksSpawning == 6)
		{
			this.resourcesGatheredText.transform.localPosition = new Vector2(-370f, 208f);
			this.resourcesCraftedText.transform.localPosition = new Vector2(0f, 208f);
			this.totalResourcesText.transform.localPosition = new Vector2(370f, 208f);
			this.resourcesGathered_parent.transform.localPosition = new Vector2(-389f, 152f);
			this.resourcesGathered_parent.transform.localScale = new Vector2(6.5f, 6.5f);
			this.resourcesCrafted_parent.transform.localPosition = new Vector2(0f, 152f);
			this.resourcesCrafted_parent.transform.localScale = new Vector2(6.5f, 6.5f);
			this.totalResources_parent.transform.localPosition = new Vector2(343f, 152f);
			this.totalResources_parent.transform.localScale = new Vector2(6.5f, 6.5f);
			this.xpGathereredText.transform.localPosition = new Vector2(x, -124f);
			this.xpGathereredText.transform.localScale = new Vector2(0.88f, 0.88f);
			this.xpParent.transform.localPosition = new Vector2(x, -183f);
			this.xpParent.transform.localScale = new Vector2(9.54f, 9.54f);
			this.levelUpText.transform.localPosition = new Vector2(x2, -124f);
			this.levelUpText.transform.localScale = new Vector2(0.88f, 0.88f);
			this.didLevelUpTalentPointsParent.transform.localPosition = new Vector2(x2, -183f);
			this.didLevelUpTalentPointsParent.transform.localScale = new Vector2(9.54f, 9.54f);
		}
		if (SkillTree.totalMaterialRocksSpawning == 7)
		{
			this.resourcesGatheredText.transform.localPosition = new Vector2(-370f, 208f);
			this.resourcesCraftedText.transform.localPosition = new Vector2(0f, 208f);
			this.totalResourcesText.transform.localPosition = new Vector2(370f, 208f);
			this.resourcesGathered_parent.transform.localPosition = new Vector2(-387f, 150f);
			this.resourcesGathered_parent.transform.localScale = new Vector2(6.04f, 6.04f);
			this.resourcesCrafted_parent.transform.localPosition = new Vector2(0f, 150f);
			this.resourcesCrafted_parent.transform.localScale = new Vector2(6.04f, 6.04f);
			this.totalResources_parent.transform.localPosition = new Vector2(345f, 150f);
			this.totalResources_parent.transform.localScale = new Vector2(6.04f, 6.04f);
			this.xpGathereredText.transform.localPosition = new Vector2(x, -136f);
			this.xpGathereredText.transform.localScale = new Vector2(0.8f, 0.8f);
			this.xpParent.transform.localPosition = new Vector2(x, -189f);
			this.xpParent.transform.localScale = new Vector2(8.7f, 8.7f);
			this.levelUpText.transform.localPosition = new Vector2(x2, -136f);
			this.levelUpText.transform.localScale = new Vector2(0.8f, 0.8f);
			this.didLevelUpTalentPointsParent.transform.localPosition = new Vector2(x2, -189f);
			this.didLevelUpTalentPointsParent.transform.localScale = new Vector2(8.7f, 8.7f);
		}
		if (SkillTree.totalMaterialRocksSpawning == 8)
		{
			this.resourcesGatheredText.transform.localPosition = new Vector2(-370f, 203f);
			this.resourcesCraftedText.transform.localPosition = new Vector2(0f, 203f);
			this.totalResourcesText.transform.localPosition = new Vector2(370f, 203f);
			this.resourcesGathered_parent.transform.localPosition = new Vector2(-386f, 156f);
			this.resourcesGathered_parent.transform.localScale = new Vector2(5.3f, 5.3f);
			this.resourcesCrafted_parent.transform.localPosition = new Vector2(0f, 156f);
			this.resourcesCrafted_parent.transform.localScale = new Vector2(5.3f, 5.3f);
			this.totalResources_parent.transform.localPosition = new Vector2(347f, 156f);
			this.totalResources_parent.transform.localScale = new Vector2(5.3f, 5.3f);
			this.xpGathereredText.transform.localPosition = new Vector2(x, -148f);
			this.xpGathereredText.transform.localScale = new Vector2(0.74f, 0.74f);
			this.xpParent.transform.localPosition = new Vector2(x, -191f);
			this.xpParent.transform.localScale = new Vector2(8f, 8f);
			this.levelUpText.transform.localPosition = new Vector2(x2, -148f);
			this.levelUpText.transform.localScale = new Vector2(0.74f, 0.74f);
			this.didLevelUpTalentPointsParent.transform.localPosition = new Vector2(x2, -191f);
			this.didLevelUpTalentPointsParent.transform.localScale = new Vector2(8f, 8f);
		}
		if (flag)
		{
			GoldAndOreMechanics.totalGoldore *= 5.0;
			GoldAndOreMechanics.totalCopperOre *= 5.0;
			GoldAndOreMechanics.totalIronOre *= 5.0;
			GoldAndOreMechanics.totalCobaltOre *= 5.0;
			GoldAndOreMechanics.totalUraniumOre *= 5.0;
			GoldAndOreMechanics.totalIsmiumOre *= 5.0;
			GoldAndOreMechanics.totalIridiumOre *= 5.0;
			GoldAndOreMechanics.totalPainiteOre *= 5.0;
		}
		SetRockScreen.oresPopedUp = true;
		this.chunks_mined.text = FormatNumbers.FormatPoints(GoldAndOreMechanics.totalGoldore);
		this.chunksMined_Copper.text = FormatNumbers.FormatPoints(GoldAndOreMechanics.totalCopperOre);
		this.chunksMined_Silver.text = FormatNumbers.FormatPoints(GoldAndOreMechanics.totalIronOre);
		this.chunksMined_Cobalt.text = FormatNumbers.FormatPoints(GoldAndOreMechanics.totalCobaltOre);
		this.chunksMined_Uranium.text = FormatNumbers.FormatPoints(GoldAndOreMechanics.totalUraniumOre);
		this.chunksMined_Ismium.text = FormatNumbers.FormatPoints(GoldAndOreMechanics.totalIsmiumOre);
		this.chunksMined_Iridium.text = FormatNumbers.FormatPoints(GoldAndOreMechanics.totalIridiumOre);
		this.chunksMined_Painite.text = FormatNumbers.FormatPoints(GoldAndOreMechanics.totalPainiteOre);
		this.CraftOres(GoldAndOreMechanics.totalGoldore, this.goldBar_crafted, 1);
		if (SkillTree.spawnCopper_purchased)
		{
			this.CraftOres(GoldAndOreMechanics.totalCopperOre, this.goldBarsCrafted_Copper, 2);
		}
		if (SkillTree.spawnIron_purchased)
		{
			this.CraftOres(GoldAndOreMechanics.totalIronOre, this.goldBarsCrafted_Silver, 3);
		}
		if (SkillTree.cobaltSpawn_purchased)
		{
			this.CraftOres(GoldAndOreMechanics.totalCobaltOre, this.goldBarsCrafted_Cobalt, 4);
		}
		if (SkillTree.uraniumSpawn_purchased)
		{
			this.CraftOres(GoldAndOreMechanics.totalUraniumOre, this.goldBarsCrafted_Uranium, 5);
		}
		if (SkillTree.ismiumSpawn_purchased)
		{
			this.CraftOres(GoldAndOreMechanics.totalIsmiumOre, this.goldBarsCrafted_Ismium, 6);
		}
		if (SkillTree.iridiumSpawn_purchased)
		{
			this.CraftOres(GoldAndOreMechanics.totalIridiumOre, this.goldBarsCrafted_Iridium, 7);
		}
		if (SkillTree.painiteSpawn_purchased)
		{
			this.CraftOres(GoldAndOreMechanics.totalPainiteOre, this.goldBarsCrafted_Painite, 8);
		}
		this.totalGoldBars.text = FormatNumbers.FormatPoints(GoldAndOreMechanics.totalGoldBars);
		this.totalGoldBars_Copper.text = FormatNumbers.FormatPoints(GoldAndOreMechanics.totalCopperBars);
		this.totalGoldBars_Silver.text = FormatNumbers.FormatPoints(GoldAndOreMechanics.totalIronBars);
		this.totalGoldBars_Cobalt.text = FormatNumbers.FormatPoints(GoldAndOreMechanics.totalCobaltBars);
		this.totalGoldBars_Uranium.text = FormatNumbers.FormatPoints(GoldAndOreMechanics.totalUraniumBars);
		this.totalGoldBars_Ismium.text = FormatNumbers.FormatPoints(GoldAndOreMechanics.totalIsmiumBar);
		this.totalGoldBars_Iridium.text = FormatNumbers.FormatPoints(GoldAndOreMechanics.totalIridiumBars);
		this.totalGoldBars_Painite.text = FormatNumbers.FormatPoints(GoldAndOreMechanics.totalPainiteBars);
		this.goldAndOreScript.SetTotalResourcesText();
		float waitTime = 0.15f;
		if (SkillTree.totalMaterialRocksSpawning == 2)
		{
			waitTime = 0.15f;
		}
		if (SkillTree.totalMaterialRocksSpawning == 3)
		{
			waitTime = 0.14f;
		}
		if (SkillTree.totalMaterialRocksSpawning == 4)
		{
			waitTime = 0.13f;
		}
		if (SkillTree.totalMaterialRocksSpawning == 5)
		{
			waitTime = 0.125f;
		}
		if (SkillTree.totalMaterialRocksSpawning == 6)
		{
			waitTime = 0.12f;
		}
		if (SkillTree.totalMaterialRocksSpawning == 7)
		{
			waitTime = 0.11f;
		}
		if (SkillTree.totalMaterialRocksSpawning == 8)
		{
			waitTime = 0.1f;
		}
		this.upgradeButton.SetActive(false);
		this.keepMiningButton.SetActive(false);
		this.timeIsUpFrame.SetActive(true);
		this.timeIsUpAnimFrame.Play();
		yield return new WaitForSeconds(waitTime);
		this.miningSessionDoneText.SetActive(true);
		this.audioManager.Play("Pop");
		yield return new WaitForSeconds(waitTime);
		this.resourcesGatheredText.SetActive(true);
		this.resourcesCraftedText.SetActive(true);
		this.totalResourcesText.SetActive(true);
		this.audioManager.Play("Pop");
		yield return new WaitForSeconds(waitTime);
		this.chunks_mined.gameObject.SetActive(true);
		this.goldBar_crafted.gameObject.SetActive(true);
		this.totalGoldBars.gameObject.SetActive(true);
		this.audioManager.Play("Pop");
		if (SkillTree.spawnCopper_purchased)
		{
			yield return new WaitForSeconds(waitTime);
			this.chunksMined_Copper.gameObject.SetActive(true);
			this.goldBarsCrafted_Copper.gameObject.SetActive(true);
			this.totalGoldBars_Copper.gameObject.SetActive(true);
			this.audioManager.Play("Pop");
		}
		if (SkillTree.spawnIron_purchased)
		{
			yield return new WaitForSeconds(waitTime);
			this.chunksMined_Silver.gameObject.SetActive(true);
			this.goldBarsCrafted_Silver.gameObject.SetActive(true);
			this.totalGoldBars_Silver.gameObject.SetActive(true);
			this.audioManager.Play("Pop");
		}
		if (SkillTree.cobaltSpawn_purchased)
		{
			yield return new WaitForSeconds(waitTime);
			this.chunksMined_Cobalt.gameObject.SetActive(true);
			this.goldBarsCrafted_Cobalt.gameObject.SetActive(true);
			this.totalGoldBars_Cobalt.gameObject.SetActive(true);
			this.audioManager.Play("Pop");
		}
		if (SkillTree.uraniumSpawn_purchased)
		{
			yield return new WaitForSeconds(waitTime);
			this.chunksMined_Uranium.gameObject.SetActive(true);
			this.goldBarsCrafted_Uranium.gameObject.SetActive(true);
			this.totalGoldBars_Uranium.gameObject.SetActive(true);
			this.audioManager.Play("Pop");
		}
		if (SkillTree.ismiumSpawn_purchased)
		{
			yield return new WaitForSeconds(waitTime);
			this.chunksMined_Ismium.gameObject.SetActive(true);
			this.goldBarsCrafted_Ismium.gameObject.SetActive(true);
			this.totalGoldBars_Ismium.gameObject.SetActive(true);
			this.audioManager.Play("Pop");
		}
		if (SkillTree.iridiumSpawn_purchased)
		{
			yield return new WaitForSeconds(waitTime);
			this.chunksMined_Iridium.gameObject.SetActive(true);
			this.goldBarsCrafted_Iridium.gameObject.SetActive(true);
			this.totalGoldBars_Iridium.gameObject.SetActive(true);
			this.audioManager.Play("Pop");
		}
		if (SkillTree.painiteSpawn_purchased)
		{
			yield return new WaitForSeconds(waitTime);
			this.chunksMined_Painite.gameObject.SetActive(true);
			this.goldBarsCrafted_Painite.gameObject.SetActive(true);
			this.totalGoldBars_Painite.gameObject.SetActive(true);
			this.audioManager.Play("Pop");
		}
		yield return new WaitForSeconds(waitTime);
		this.xpGainedThisRound_text.text = "+0XP";
		this.xpGainedThisRound_text.text = "+" + FormatNumbers.FormatPoints((double)(LevelMechanics.xpThisRound * 100f)) + "XP";
		this.xpGathereredText.SetActive(true);
		if (LevelMechanics.didLevelUp)
		{
			this.levelUpText.SetActive(true);
		}
		else
		{
			this.levelUpText.SetActive(false);
		}
		this.audioManager.Play("Pop");
		yield return new WaitForSeconds(waitTime);
		this.xpParent.SetActive(true);
		if (LevelMechanics.didLevelUp)
		{
			this.didLevelUpTalentPointsParent.gameObject.SetActive(true);
		}
		else
		{
			this.didLevelUpTalentPointsParent.gameObject.SetActive(false);
		}
		this.audioManager.Play("Pop");
		yield return new WaitForSeconds(waitTime);
		this.audioManager.Play("Pop");
		if (!Tutorial.pressedOkCraftingTurotialFrame)
		{
			this.tutorialScript.SetTutorial(1);
		}
		this.upgradeButton.SetActive(true);
		this.keepMiningButton.SetActive(true);
		this.achScript.CheckAch();
		yield break;
	}

	// Token: 0x060001A2 RID: 418 RVA: 0x0003FD80 File Offset: 0x0003DF80
	public void CraftOres(double totalOre, TextMeshProUGUI craftedText, int materialToAdd)
	{
		int num = 3;
		if (SkillTree.craft2Material_purchased)
		{
			num = 2;
		}
		double num2 = totalOre / (double)num;
		if (totalOre % (double)num > 0.0)
		{
			num2 += 1.0;
		}
		if (Artifacts.goldRing_found)
		{
			float num3 = Random.Range(1.025f, 1.035f);
			if (SkillTree.craft2Material_purchased)
			{
				num3 = Random.Range(1.018f, 1.023f);
			}
			num2 *= (double)num3;
		}
		if (num2 % 1.0 != 0.0)
		{
			num2 -= num2 % 1.0;
		}
		craftedText.text = FormatNumbers.FormatPoints(num2);
		if (materialToAdd == 1)
		{
			GoldAndOreMechanics.totalGoldBars += num2;
		}
		if (materialToAdd == 2)
		{
			GoldAndOreMechanics.totalCopperBars += num2;
		}
		if (materialToAdd == 3)
		{
			GoldAndOreMechanics.totalIronBars += num2;
		}
		if (materialToAdd == 4)
		{
			GoldAndOreMechanics.totalCobaltBars += num2;
		}
		if (materialToAdd == 5)
		{
			GoldAndOreMechanics.totalUraniumBars += num2;
		}
		if (materialToAdd == 6)
		{
			GoldAndOreMechanics.totalIsmiumBar += num2;
		}
		if (materialToAdd == 7)
		{
			GoldAndOreMechanics.totalIridiumBars += num2;
		}
		if (materialToAdd == 8)
		{
			GoldAndOreMechanics.totalPainiteBars += num2;
		}
		AllStats.barsCrafted += num2;
	}

	// Token: 0x060001A3 RID: 419 RVA: 0x0003FEA7 File Offset: 0x0003E0A7
	private IEnumerator CraftTheResource(int craftType, int totalCrafted, TextMeshProUGUI textToCraft)
	{
		textToCraft.text = "0";
		float timeToCraft = 0.17f;
		float currentTime = 0f;
		while (currentTime < timeToCraft)
		{
			currentTime += Time.deltaTime;
			float t = Mathf.Clamp01(currentTime / timeToCraft);
			textToCraft.text = Mathf.RoundToInt(Mathf.Lerp(0f, (float)totalCrafted, t)).ToString();
			yield return null;
		}
		if (craftType == 1)
		{
			textToCraft.text = totalCrafted.ToString();
		}
		yield break;
	}

	// Token: 0x060001A4 RID: 420 RVA: 0x0003FEC4 File Offset: 0x0003E0C4
	public void SetStuffBackToObjectPool()
	{
		this.allArtifactsParent.SetActive(false);
		foreach (GameObject gameObject in GameObject.FindGameObjectsWithTag("Rock"))
		{
			if (gameObject.activeSelf)
			{
				gameObject.transform.SetParent(this.originalRockParent);
				ObjectPool.instance.ReturnRockFromPool(gameObject);
			}
		}
		if (LevelMechanics.springSeason_chosen)
		{
			foreach (GameObject gameObject2 in GameObject.FindGameObjectsWithTag("Flower"))
			{
				if (gameObject2.activeSelf)
				{
					gameObject2.transform.SetParent(this.originalFLowerParent);
					gameObject2.gameObject.SetActive(false);
				}
			}
		}
		if (LevelMechanics.camper_chosen)
		{
			this.campfire.SetActive(false);
		}
	}

	// Token: 0x060001A5 RID: 421 RVA: 0x0003FF7C File Offset: 0x0003E17C
	public void ResetTimeISUpStuff()
	{
		foreach (GameObject gameObject in GameObject.FindGameObjectsWithTag("CircleShoot"))
		{
			if (gameObject.activeSelf)
			{
				ObjectPool.instance.ReturnCircleColliderFromPool(gameObject);
			}
		}
	}

	// Token: 0x060001A6 RID: 422 RVA: 0x0003FFBC File Offset: 0x0003E1BC
	public void ResetBetweenTransitions()
	{
		if (LevelMechanics.shapeShifter_chosen)
		{
			this.circleColl.SetActive(false);
			this.squareColl.SetActive(false);
			this.hexagonColl.SetActive(false);
			int num = Random.Range(1, 4);
			if (num == 1)
			{
				this.circleColl.SetActive(true);
			}
			if (num == 2)
			{
				this.squareColl.SetActive(true);
			}
			if (num == 3)
			{
				this.hexagonColl.SetActive(true);
			}
		}
		else
		{
			this.circleColl.SetActive(true);
		}
		this.potion_materialsWorthMore.SetActive(false);
		SetRockScreen.isPotionMaterialWorthMore = false;
		this.potion_xp.SetActive(false);
		SetRockScreen.isPotionXp = false;
		this.potion_pickaxeStats.SetActive(false);
		SetRockScreen.isPotionPickaxeStats = false;
		this.potion_doubleMaterialAndXPChance.SetActive(false);
		SetRockScreen.isPotionDoubleMaterialAndXPChance = false;
		SetRockScreen.potionDoubleChance_increase = 0f;
		SetRockScreen.potionXp_increase = 0f;
		SetRockScreen.potionMaterialWorthMore_increase = 0f;
		SetRockScreen.potionPickaxeStats_increase = 0f;
		if (LevelMechanics.potionDrinker_chosen)
		{
			int num2 = Random.Range(1, 5);
			if (num2 == 1)
			{
				this.potion_materialsWorthMore.SetActive(true);
				SetRockScreen.isPotionMaterialWorthMore = true;
			}
			if (num2 == 2)
			{
				this.potion_xp.SetActive(true);
				SetRockScreen.isPotionXp = true;
			}
			if (num2 == 3)
			{
				this.potion_pickaxeStats.SetActive(true);
				SetRockScreen.isPotionPickaxeStats = true;
			}
			if (num2 == 4)
			{
				this.potion_doubleMaterialAndXPChance.SetActive(true);
				SetRockScreen.isPotionDoubleMaterialAndXPChance = true;
			}
		}
		if (LevelMechanics.potionChugger_chosen)
		{
			this.potion_materialsWorthMore.SetActive(true);
			SetRockScreen.isPotionMaterialWorthMore = true;
			this.potion_xp.SetActive(true);
			SetRockScreen.isPotionXp = true;
			this.potion_pickaxeStats.SetActive(true);
			SetRockScreen.isPotionPickaxeStats = true;
			this.potion_doubleMaterialAndXPChance.SetActive(true);
			SetRockScreen.isPotionDoubleMaterialAndXPChance = true;
		}
		if (SetRockScreen.isPotionMaterialWorthMore)
		{
			if (SkillTree.materialsTotalWorth < 7f)
			{
				SetRockScreen.potionMaterialWorthMore_increase = 1f;
			}
			else if (SkillTree.materialsTotalWorth < 12f)
			{
				SetRockScreen.potionMaterialWorthMore_increase = 2f;
			}
			else if (SkillTree.materialsTotalWorth < 20f)
			{
				SetRockScreen.potionMaterialWorthMore_increase = 3f;
			}
			else if (SkillTree.materialsTotalWorth < 30f)
			{
				SetRockScreen.potionMaterialWorthMore_increase = 4f;
			}
			else if (SkillTree.materialsTotalWorth < 50f)
			{
				SetRockScreen.potionMaterialWorthMore_increase = 5f;
			}
			else if (SkillTree.materialsTotalWorth < 70f)
			{
				SetRockScreen.potionMaterialWorthMore_increase = 6f;
			}
			else if (SkillTree.materialsTotalWorth < 100f)
			{
				SetRockScreen.potionMaterialWorthMore_increase = 7f;
			}
			else
			{
				SetRockScreen.potionMaterialWorthMore_increase = 8f;
			}
		}
		else
		{
			SetRockScreen.potionMaterialWorthMore_increase = 0f;
		}
		if (SetRockScreen.isPotionXp)
		{
			SetRockScreen.potionXp_increase = Random.Range(0.13f, 0.21f);
		}
		else
		{
			SetRockScreen.potionXp_increase = 0f;
		}
		if (SetRockScreen.isPotionPickaxeStats)
		{
			if (SkillTree.improvedPickaxeStrength < 1.06f)
			{
				SetRockScreen.potionPickaxeStats_increase = 0.02f;
			}
			else if (SkillTree.improvedPickaxeStrength < 1.13f)
			{
				SetRockScreen.potionPickaxeStats_increase = 0.03f;
			}
			else if (SkillTree.improvedPickaxeStrength < 1.3f)
			{
				SetRockScreen.potionPickaxeStats_increase = 0.04f;
			}
			else if (SkillTree.improvedPickaxeStrength < 1.4f)
			{
				SetRockScreen.potionPickaxeStats_increase = 0.05f;
			}
			else if (SkillTree.improvedPickaxeStrength < 1.6f)
			{
				SetRockScreen.potionPickaxeStats_increase = 0.08f;
			}
			else
			{
				SetRockScreen.potionPickaxeStats_increase = 0.1f;
			}
		}
		else
		{
			SetRockScreen.potionPickaxeStats_increase = 0f;
		}
		if (SetRockScreen.isPotionDoubleMaterialAndXPChance)
		{
			if (SkillTree.doubleXpAndGoldChance < 6f)
			{
				SetRockScreen.potionDoubleChance_increase = 2f;
			}
			else if (SkillTree.doubleXpAndGoldChance < 11f)
			{
				SetRockScreen.potionDoubleChance_increase = 2f;
			}
			else if (SkillTree.doubleXpAndGoldChance < 20f)
			{
				SetRockScreen.potionDoubleChance_increase = 3f;
			}
			else if (SkillTree.doubleXpAndGoldChance < 50f)
			{
				SetRockScreen.potionDoubleChance_increase = 4f;
			}
			else
			{
				SetRockScreen.potionDoubleChance_increase = 5f;
			}
		}
		else
		{
			SetRockScreen.potionDoubleChance_increase = 0f;
		}
		this.anvilScript.DisplayEquippedAndSetStats(TheAnvil.equippedMineTime, TheAnvil.equippedMinePower, TheAnvil.equipped2XChance, TheAnvil.equippedMiningArea);
		this.SetNewBackground();
		this.goldAndOreScript.ResetStuff();
	}

	// Token: 0x060001A7 RID: 423 RVA: 0x00040398 File Offset: 0x0003E598
	public void SetNewBackground()
	{
	}

	// Token: 0x060001A8 RID: 424 RVA: 0x000403A8 File Offset: 0x0003E5A8
	public void SetFlowers()
	{
		int num = Random.Range(2, 18);
		SetRockScreen.flowersOnScreen = num;
		for (int i = 0; i < num; i++)
		{
			AllStats.flowersSpawned++;
			this.flowers[i].SetActive(true);
			SetRockScreen.tileWaveNumber = Random.Range(0, 14);
			this.flowers[i].transform.SetParent(this.rockParent[SetRockScreen.tileWaveNumber]);
			Vector2 v = new Vector2((float)Random.Range(77, -77), Random.Range(-1.5f, 1.5f));
			this.flowers[i].transform.localPosition = v;
			this.flowers[i].transform.localScale = new Vector2(0.075f, 0.075f);
		}
		this.totalFlowersObject.gameObject.SetActive(true);
		this.totalFlowersText.text = "X" + SetRockScreen.flowersOnScreen.ToString("F0");
	}

	// Token: 0x060001A9 RID: 425 RVA: 0x000404B0 File Offset: 0x0003E6B0
	public void SetCampfire()
	{
		AllStats.campfiresSpawned++;
		this.campfire.SetActive(true);
		SetRockScreen.tileWaveNumber = Random.Range(0, 14);
		this.campfire.transform.SetParent(this.rockParent[SetRockScreen.tileWaveNumber]);
		Vector2 v = new Vector2((float)Random.Range(77, -77), Random.Range(-1.5f, 1.5f));
		this.campfire.transform.localPosition = v;
	}

	// Token: 0x060001AA RID: 426 RVA: 0x00040534 File Offset: 0x0003E734
	public void EndSession()
	{
		SetRockScreen.currentTime = 100f;
	}

	// Token: 0x060001AB RID: 427 RVA: 0x00040540 File Offset: 0x0003E740
	public void KeepOnMining_MainMenu()
	{
		base.StartCoroutine(this.ScaleCircleCoroutine(true));
		SetRockScreen.pressEnding = false;
		base.StartCoroutine(this.ScaleCircleDownAgain(false));
	}

	// Token: 0x060001AC RID: 428 RVA: 0x00040564 File Offset: 0x0003E764
	public void PressEndingBtn()
	{
		MainMenu.isInTheMine = false;
		MainMenu.isInArtifacts = false;
		MainMenu.isInTalents = false;
		MainMenu.isInTheAnvil = false;
		this.endingScript.SoundVolumeSet("MainMenuMusic", true, TheEnding.gameMusicFullVolume, 0f, 1f, true);
		this.bigRock.SetActive(true);
		this.bigRockTiles.SetActive(true);
		this.tiles.SetActive(false);
		this.xpFrame.SetActive(false);
		this.timeFrame.SetActive(false);
		this.materialFrame.SetActive(false);
		this.potionsFrame.SetActive(false);
		this.endSessionBtn.SetActive(false);
		SetRockScreen.pressEnding = true;
		SetRockScreen.isInEnding = true;
		base.StartCoroutine(this.ScaleCircleCoroutine(true));
		base.StartCoroutine(this.ScaleCircleDownAgain(false));
		this.SetStuffBackToObjectPool();
		this.ResetBetweenTransitions();
	}

	// Token: 0x060001AD RID: 429 RVA: 0x00040640 File Offset: 0x0003E840
	public void SetUiStuff()
	{
		SetRockScreen.oresPopedUp = false;
		this.bigRock.SetActive(false);
		this.bigRockTiles.SetActive(false);
		this.tiles.SetActive(true);
		this.xpFrame.SetActive(true);
		this.timeFrame.SetActive(true);
		this.materialFrame.SetActive(true);
		this.potionsFrame.SetActive(true);
		this.endSessionBtn.SetActive(true);
	}

	// Token: 0x060001AE RID: 430 RVA: 0x000406B4 File Offset: 0x0003E8B4
	public void SetRandomHexColor(Image image)
	{
		string str = this.GenerateRandomHexColor();
		Debug.Log("Random HEX: #" + str);
		Color color;
		if (ColorUtility.TryParseHtmlString("#" + str, out color))
		{
			image.color = color;
			return;
		}
		Debug.LogError("Failed to parse hex: #" + str);
	}

	// Token: 0x060001AF RID: 431 RVA: 0x00040704 File Offset: 0x0003E904
	private string GenerateRandomHexColor()
	{
		string text = "";
		for (int i = 0; i < 6; i++)
		{
			text += "0123456789ABCDEF"[Random.Range(0, "0123456789ABCDEF".Length)].ToString();
		}
		return text;
	}

	// Token: 0x04000945 RID: 2373
	public GoldAndOreMechanics goldAndOreScript;

	// Token: 0x04000946 RID: 2374
	public MainMenu mainMenuScript;

	// Token: 0x04000947 RID: 2375
	public SpawnRocks spawnRocksScript;

	// Token: 0x04000948 RID: 2376
	public SpawnProjectiles spawnProjectilesScript;

	// Token: 0x04000949 RID: 2377
	public Artifacts artifactsScript;

	// Token: 0x0400094A RID: 2378
	public TheAnvil anvilScript;

	// Token: 0x0400094B RID: 2379
	public AudioManager audioManager;

	// Token: 0x0400094C RID: 2380
	public Tutorial tutorialScript;

	// Token: 0x0400094D RID: 2381
	public TheEnding endingScript;

	// Token: 0x0400094E RID: 2382
	public Achievements achScript;

	// Token: 0x0400094F RID: 2383
	public GameObject dustParticleParent;

	// Token: 0x04000950 RID: 2384
	public GameObject goldenHand;

	// Token: 0x04000951 RID: 2385
	public GameObject normalCursorHand;

	// Token: 0x04000952 RID: 2386
	public static bool isGoldenHand;

	// Token: 0x04000953 RID: 2387
	public static float mineTotalTime;

	// Token: 0x04000954 RID: 2388
	public static float startTileZPos;

	// Token: 0x04000955 RID: 2389
	public GameObject[] tileRow;

	// Token: 0x04000956 RID: 2390
	public Vector2 startPos;

	// Token: 0x04000957 RID: 2391
	public int timesSpawned;

	// Token: 0x04000958 RID: 2392
	public int totalTimesSpawned;

	// Token: 0x04000959 RID: 2393
	public int parentFilled;

	// Token: 0x0400095A RID: 2394
	public float tileZPos;

	// Token: 0x0400095B RID: 2395
	public static int tileWaveNumber;

	// Token: 0x0400095C RID: 2396
	public GameObject handCollider;

	// Token: 0x0400095D RID: 2397
	public GameObject handCollider_actualCollider;

	// Token: 0x0400095E RID: 2398
	public GameObject hexagonCollider_actualCollider;

	// Token: 0x0400095F RID: 2399
	public GameObject squareCollider_actualCollider;

	// Token: 0x04000960 RID: 2400
	public static float rockZPos;

	// Token: 0x04000961 RID: 2401
	public static bool isInMiningSession;

	// Token: 0x04000962 RID: 2402
	public GameObject allArtifactsParent;

	// Token: 0x04000963 RID: 2403
	public GameObject potion_materialsWorthMore;

	// Token: 0x04000964 RID: 2404
	public GameObject potion_pickaxeStats;

	// Token: 0x04000965 RID: 2405
	public GameObject potion_xp;

	// Token: 0x04000966 RID: 2406
	public GameObject potion_doubleMaterialAndXPChance;

	// Token: 0x04000967 RID: 2407
	public static bool isPotionMaterialWorthMore;

	// Token: 0x04000968 RID: 2408
	public static bool isPotionPickaxeStats;

	// Token: 0x04000969 RID: 2409
	public static bool isPotionXp;

	// Token: 0x0400096A RID: 2410
	public static bool isPotionDoubleMaterialAndXPChance;

	// Token: 0x0400096B RID: 2411
	public static float potionMaterialWorthMore_increase;

	// Token: 0x0400096C RID: 2412
	public static float potionPickaxeStats_increase;

	// Token: 0x0400096D RID: 2413
	public static float potionXp_increase;

	// Token: 0x0400096E RID: 2414
	public static float potionDoubleChance_increase;

	// Token: 0x0400096F RID: 2415
	public static bool spawnedGoldenChest;

	// Token: 0x04000970 RID: 2416
	public static bool doSpawnGoldenChest;

	// Token: 0x04000971 RID: 2417
	public GameObject circleColl;

	// Token: 0x04000972 RID: 2418
	public GameObject squareColl;

	// Token: 0x04000973 RID: 2419
	public GameObject hexagonColl;

	// Token: 0x04000974 RID: 2420
	public Camera mainCamera;

	// Token: 0x04000975 RID: 2421
	public static int totalRocksOnScreen;

	// Token: 0x04000976 RID: 2422
	public static int grassLayer;

	// Token: 0x04000977 RID: 2423
	public static bool oresPopedUp;

	// Token: 0x04000978 RID: 2424
	private bool isTimeStarted;

	// Token: 0x04000979 RID: 2425
	private int rocksLeftAdded;

	// Token: 0x0400097A RID: 2426
	public static bool noLongerCheckCollision;

	// Token: 0x0400097B RID: 2427
	public Transform[] rockParent;

	// Token: 0x0400097C RID: 2428
	private int totalRocksSpawned;

	// Token: 0x0400097D RID: 2429
	public Image timerLine;

	// Token: 0x0400097E RID: 2430
	public TextMeshProUGUI timerText;

	// Token: 0x0400097F RID: 2431
	public static float timeLeft;

	// Token: 0x04000980 RID: 2432
	public static float currentTime;

	// Token: 0x04000981 RID: 2433
	public Animation textFrameAnim;

	// Token: 0x04000982 RID: 2434
	public TextMeshProUGUI textFrameText;

	// Token: 0x04000983 RID: 2435
	public GameObject mainMenu;

	// Token: 0x04000984 RID: 2436
	public GameObject copperOreFrame;

	// Token: 0x04000985 RID: 2437
	public GameObject ironOreFrame;

	// Token: 0x04000986 RID: 2438
	public GameObject cobaltOreFrame;

	// Token: 0x04000987 RID: 2439
	public GameObject uraniumOre_frame;

	// Token: 0x04000988 RID: 2440
	public GameObject ismiumOre_frame;

	// Token: 0x04000989 RID: 2441
	public GameObject iridiumOre_frame;

	// Token: 0x0400098A RID: 2442
	public GameObject painiteOre_frame;

	// Token: 0x0400098B RID: 2443
	public GameObject circleObject;

	// Token: 0x0400098C RID: 2444
	public GameObject backgroundDark;

	// Token: 0x0400098D RID: 2445
	public GameObject transitionBlock;

	// Token: 0x0400098E RID: 2446
	public GameObject timeIsUpFrame;

	// Token: 0x0400098F RID: 2447
	public Animation timeIsUpAnimFrame;

	// Token: 0x04000990 RID: 2448
	public GameObject upgradeButton;

	// Token: 0x04000991 RID: 2449
	public GameObject keepMiningButton;

	// Token: 0x04000992 RID: 2450
	public static bool didCollectOtherResources;

	// Token: 0x04000993 RID: 2451
	public static bool didCollectArtifact;

	// Token: 0x04000994 RID: 2452
	public GameObject resourcesGatheredText;

	// Token: 0x04000995 RID: 2453
	public GameObject resourcesCraftedText;

	// Token: 0x04000996 RID: 2454
	public GameObject totalResourcesText;

	// Token: 0x04000997 RID: 2455
	public GameObject resourcesGathered_parent;

	// Token: 0x04000998 RID: 2456
	public GameObject resourcesCrafted_parent;

	// Token: 0x04000999 RID: 2457
	public GameObject totalResources_parent;

	// Token: 0x0400099A RID: 2458
	public GameObject xpParent;

	// Token: 0x0400099B RID: 2459
	public GameObject xpGathereredText;

	// Token: 0x0400099C RID: 2460
	public TextMeshProUGUI chunks_mined;

	// Token: 0x0400099D RID: 2461
	public TextMeshProUGUI goldBar_crafted;

	// Token: 0x0400099E RID: 2462
	public TextMeshProUGUI totalGoldBars;

	// Token: 0x0400099F RID: 2463
	public GameObject miningSessionDoneText;

	// Token: 0x040009A0 RID: 2464
	public TextMeshProUGUI chunksMined_Copper;

	// Token: 0x040009A1 RID: 2465
	public TextMeshProUGUI goldBarsCrafted_Copper;

	// Token: 0x040009A2 RID: 2466
	public TextMeshProUGUI totalGoldBars_Copper;

	// Token: 0x040009A3 RID: 2467
	public TextMeshProUGUI chunksMined_Silver;

	// Token: 0x040009A4 RID: 2468
	public TextMeshProUGUI goldBarsCrafted_Silver;

	// Token: 0x040009A5 RID: 2469
	public TextMeshProUGUI totalGoldBars_Silver;

	// Token: 0x040009A6 RID: 2470
	public TextMeshProUGUI chunksMined_Cobalt;

	// Token: 0x040009A7 RID: 2471
	public TextMeshProUGUI goldBarsCrafted_Cobalt;

	// Token: 0x040009A8 RID: 2472
	public TextMeshProUGUI totalGoldBars_Cobalt;

	// Token: 0x040009A9 RID: 2473
	public TextMeshProUGUI chunksMined_Uranium;

	// Token: 0x040009AA RID: 2474
	public TextMeshProUGUI goldBarsCrafted_Uranium;

	// Token: 0x040009AB RID: 2475
	public TextMeshProUGUI totalGoldBars_Uranium;

	// Token: 0x040009AC RID: 2476
	public TextMeshProUGUI chunksMined_Ismium;

	// Token: 0x040009AD RID: 2477
	public TextMeshProUGUI goldBarsCrafted_Ismium;

	// Token: 0x040009AE RID: 2478
	public TextMeshProUGUI totalGoldBars_Ismium;

	// Token: 0x040009AF RID: 2479
	public TextMeshProUGUI chunksMined_Iridium;

	// Token: 0x040009B0 RID: 2480
	public TextMeshProUGUI goldBarsCrafted_Iridium;

	// Token: 0x040009B1 RID: 2481
	public TextMeshProUGUI totalGoldBars_Iridium;

	// Token: 0x040009B2 RID: 2482
	public TextMeshProUGUI chunksMined_Painite;

	// Token: 0x040009B3 RID: 2483
	public TextMeshProUGUI goldBarsCrafted_Painite;

	// Token: 0x040009B4 RID: 2484
	public TextMeshProUGUI totalGoldBars_Painite;

	// Token: 0x040009B5 RID: 2485
	public TextMeshProUGUI xpGainedThisRound_text;

	// Token: 0x040009B6 RID: 2486
	public GameObject D100;

	// Token: 0x040009B7 RID: 2487
	public TextMeshProUGUI D100text;

	// Token: 0x040009B8 RID: 2488
	public GameObject didLevelUpTalentPointsParent;

	// Token: 0x040009B9 RID: 2489
	public GameObject levelUpText;

	// Token: 0x040009BA RID: 2490
	public TextMeshProUGUI levelUpTalentPoints;

	// Token: 0x040009BB RID: 2491
	public Transform originalRockParent;

	// Token: 0x040009BC RID: 2492
	public GameObject circleNormal;

	// Token: 0x040009BD RID: 2493
	public GameObject circleGold;

	// Token: 0x040009BE RID: 2494
	public GameObject hexagonNormal;

	// Token: 0x040009BF RID: 2495
	public GameObject hexagonGold;

	// Token: 0x040009C0 RID: 2496
	public GameObject squareNormal;

	// Token: 0x040009C1 RID: 2497
	public GameObject squareGold;

	// Token: 0x040009C2 RID: 2498
	public int backgroundIncrement;

	// Token: 0x040009C3 RID: 2499
	public int currentBackground;

	// Token: 0x040009C4 RID: 2500
	public GameObject background1;

	// Token: 0x040009C5 RID: 2501
	public GameObject background2;

	// Token: 0x040009C6 RID: 2502
	public GameObject background3;

	// Token: 0x040009C7 RID: 2503
	public GameObject background4;

	// Token: 0x040009C8 RID: 2504
	public GameObject background5;

	// Token: 0x040009C9 RID: 2505
	public GameObject[] flowers;

	// Token: 0x040009CA RID: 2506
	public static int flowersOnScreen;

	// Token: 0x040009CB RID: 2507
	public Transform originalFLowerParent;

	// Token: 0x040009CC RID: 2508
	public TextMeshProUGUI totalFlowersText;

	// Token: 0x040009CD RID: 2509
	public GameObject totalFlowersObject;

	// Token: 0x040009CE RID: 2510
	public GameObject campfire;

	// Token: 0x040009CF RID: 2511
	public GameObject tiles;

	// Token: 0x040009D0 RID: 2512
	public GameObject xpFrame;

	// Token: 0x040009D1 RID: 2513
	public GameObject timeFrame;

	// Token: 0x040009D2 RID: 2514
	public GameObject materialFrame;

	// Token: 0x040009D3 RID: 2515
	public GameObject potionsFrame;

	// Token: 0x040009D4 RID: 2516
	public GameObject endSessionBtn;

	// Token: 0x040009D5 RID: 2517
	public GameObject bigRock;

	// Token: 0x040009D6 RID: 2518
	public GameObject bigRockTiles;

	// Token: 0x040009D7 RID: 2519
	public static bool pressEnding;

	// Token: 0x040009D8 RID: 2520
	public static bool isInEnding;
}
