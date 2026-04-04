using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000018 RID: 24
public class RockMechanics : MonoBehaviour
{
	// Token: 0x06000073 RID: 115 RVA: 0x00006A10 File Offset: 0x00004C10
	private void Awake()
	{
		if (!this.isBigRock)
		{
			this.rockRigidbody = base.gameObject.GetComponent<Rigidbody2D>();
			this.chest = base.transform.Find("Chest");
			this.chestSprite = this.chest.gameObject.GetComponent<SpriteRenderer>();
			this.chestOpen = base.transform.Find("Chest_open");
			this.chestOpenSprite = this.chestOpen.gameObject.GetComponent<SpriteRenderer>();
			this.goldenChest = base.transform.Find("GoldenChest");
			this.goldenChestSprite = this.goldenChest.gameObject.GetComponent<SpriteRenderer>();
			this.goldenChestOpen = base.transform.Find("GoldenChest_open");
			this.goldenChestOpenSprite = this.goldenChestOpen.gameObject.GetComponent<SpriteRenderer>();
			this.originalArtifactParent = GameObject.Find("OriginalArtifactParent");
			this.rockCollider = base.gameObject.GetComponent<Collider2D>();
			this._spriteRenderers = base.GetComponentsInChildren<SpriteRenderer>();
			this.SetMaterials();
			this.rock1 = base.transform.Find("RockFull");
			this.rock1Sprite = this.rock1.gameObject.GetComponent<SpriteRenderer>();
			this.rock1Broken = base.transform.Find("Rock1Broken");
			this.rock1BrokenSprite = this.rock1Broken.gameObject.GetComponent<SpriteRenderer>();
			this.chunkOfGold = base.transform.Find("ChunkOfGold");
			this.chunkOfGoldSprite = this.chunkOfGold.gameObject.GetComponent<SpriteRenderer>();
			this.fullGold = base.transform.Find("Rock_fullGold");
			this.fullGoldSprite = this.fullGold.gameObject.GetComponent<SpriteRenderer>();
			this.rockGoldBroken = base.transform.Find("GoldBroken");
			this.rockGoldBrokenSprite = this.rockGoldBroken.GetComponent<SpriteRenderer>();
			this.chunkOfCopper = base.transform.Find("CopperChunk");
			this.chunkOfCopperSprite = this.chunkOfCopper.GetComponent<SpriteRenderer>();
			this.fullCopper = base.transform.Find("CopperFull");
			this.fullCopperSprite = this.fullCopper.GetComponent<SpriteRenderer>();
			this.rockCopperBroken = base.transform.Find("CopperBroken");
			this.rockCopperBrokenSprite = this.rockCopperBroken.GetComponent<SpriteRenderer>();
			this.chunkOfSilver = base.transform.Find("SilverChunk");
			this.chunkOfSilverSprite = this.chunkOfSilver.GetComponent<SpriteRenderer>();
			this.fullSilver = base.transform.Find("SilverFull");
			this.fullSilverSprite = this.fullSilver.GetComponent<SpriteRenderer>();
			this.rockSilverBroken = base.transform.Find("SilverBroken");
			this.rockSilverBrokenSprite = this.rockSilverBroken.GetComponent<SpriteRenderer>();
			this.chunkOfCobalt = base.transform.Find("CobaltChunk");
			this.chunkOfCobaltSprite = this.chunkOfCobalt.GetComponent<SpriteRenderer>();
			this.fullCobalt = base.transform.Find("CobaltFull");
			this.fullCobaltSprite = this.fullCobalt.GetComponent<SpriteRenderer>();
			this.rockCobaltBroken = base.transform.Find("CobaltBroken");
			this.rockCobaltBrokenSprite = this.rockCobaltBroken.GetComponent<SpriteRenderer>();
			this.chunkOfUranium = base.transform.Find("UraniumChunk");
			this.chunkOfUraniumSprite = this.chunkOfUranium.GetComponent<SpriteRenderer>();
			this.fullUranium = base.transform.Find("UraniumFull");
			this.fullUraniumSprite = this.fullUranium.GetComponent<SpriteRenderer>();
			this.rockUraniumBroken = base.transform.Find("UraniumBroken");
			this.rockUraniumBrokenSprite = this.rockUraniumBroken.GetComponent<SpriteRenderer>();
			this.chunkOfIsmium = base.transform.Find("IsmiumChunk");
			this.chunkOfIsmiumSprite = this.chunkOfIsmium.GetComponent<SpriteRenderer>();
			this.fullIsmium = base.transform.Find("IsmiumFull");
			this.fullIsmiumSprite = this.fullIsmium.GetComponent<SpriteRenderer>();
			this.rockIsmiumBroken = base.transform.Find("IsmiumBroken");
			this.rockIsmiumBrokenSprite = this.rockIsmiumBroken.GetComponent<SpriteRenderer>();
			this.chunkOfIridium = base.transform.Find("IridiumChunk");
			this.chunkOfIridiumSprite = this.chunkOfIridium.GetComponent<SpriteRenderer>();
			this.fullIridium = base.transform.Find("IridiumFull");
			this.fullIridiumSprite = this.fullIridium.GetComponent<SpriteRenderer>();
			this.rockIridiumBroken = base.transform.Find("IridiumBroken");
			this.rockIridiumBrokenSprite = this.rockIridiumBroken.GetComponent<SpriteRenderer>();
			this.chunkOfPainite = base.transform.Find("PainiteChunk");
			this.chunkOfPainiteSprite = this.chunkOfPainite.GetComponent<SpriteRenderer>();
			this.fullPainite = base.transform.Find("PainiteFull");
			this.fullPainiteSprite = this.fullPainite.GetComponent<SpriteRenderer>();
			this.rockPainiteBroken = base.transform.Find("PainiteBroken");
			this.rockPainiteBrokenSprite = this.rockPainiteBroken.GetComponent<SpriteRenderer>();
			GameObject gameObject = GameObject.Find("ScreenShake");
			this.screenShakeScript = gameObject.GetComponent<ScreenShake>();
			GameObject gameObject2 = GameObject.Find("LevelMechanics");
			this.levelScript = gameObject2.GetComponent<LevelMechanics>();
			GameObject gameObject3 = GameObject.Find("Artifacts");
			this.artifactsScript = gameObject3.GetComponent<Artifacts>();
			GameObject gameObject4 = GameObject.Find("SetRockScreen");
			this.setRockScreenScript = gameObject4.GetComponent<SetRockScreen>();
			GameObject gameObject5 = GameObject.Find("GoldAndOreMechanics");
			this.goldScript = gameObject5.GetComponent<GoldAndOreMechanics>();
		}
		SpawnProjectiles.AddRock(base.gameObject);
		GameObject gameObject6 = GameObject.Find("OverlappingSounds");
		this.overlappingScript = gameObject6.GetComponent<OverlappingSounds>();
		GameObject gameObject7 = GameObject.Find("SpawnProjectiles");
		this.spawnProjectileScript = gameObject7.GetComponent<SpawnProjectiles>();
	}

	// Token: 0x06000074 RID: 116 RVA: 0x00006FD8 File Offset: 0x000051D8
	public void SetAllOff()
	{
		this.chest.gameObject.SetActive(false);
		this.chestOpen.gameObject.SetActive(false);
		this.goldenChest.gameObject.SetActive(false);
		this.goldenChestOpen.gameObject.SetActive(false);
		this.rock1.gameObject.SetActive(false);
		this.rock1Broken.gameObject.SetActive(false);
		this.fullGold.gameObject.SetActive(false);
		this.chunkOfGold.gameObject.SetActive(false);
		this.rockGoldBroken.gameObject.SetActive(false);
		this.fullCopper.gameObject.SetActive(false);
		this.chunkOfCopper.gameObject.SetActive(false);
		this.rockCopperBroken.gameObject.SetActive(false);
		this.fullSilver.gameObject.SetActive(false);
		this.chunkOfSilver.gameObject.SetActive(false);
		this.rockSilverBroken.gameObject.SetActive(false);
		this.fullCobalt.gameObject.SetActive(false);
		this.chunkOfCobalt.gameObject.SetActive(false);
		this.rockCobaltBroken.gameObject.SetActive(false);
		this.fullUranium.gameObject.SetActive(false);
		this.chunkOfUranium.gameObject.SetActive(false);
		this.rockUraniumBroken.gameObject.SetActive(false);
		this.fullIsmium.gameObject.SetActive(false);
		this.chunkOfIsmium.gameObject.SetActive(false);
		this.rockIsmiumBroken.gameObject.SetActive(false);
		this.fullIridium.gameObject.SetActive(false);
		this.chunkOfIridium.gameObject.SetActive(false);
		this.rockIridiumBroken.gameObject.SetActive(false);
		this.fullPainite.gameObject.SetActive(false);
		this.chunkOfPainite.gameObject.SetActive(false);
		this.rockPainiteBroken.gameObject.SetActive(false);
	}

	// Token: 0x06000075 RID: 117 RVA: 0x000071E4 File Offset: 0x000053E4
	private void OnEnable()
	{
		SetRockScreen.totalRocksOnScreen++;
		if (this.isBigRock)
		{
			this.bigRockFull.SetActive(true);
			this.bigRockBroken1.SetActive(false);
			this.bigRockBroken2.SetActive(false);
		}
		this.rockRigidbody.constraints = RigidbodyConstraints2D.None;
		this.spawnChest = false;
		this.spawnGoldenChest = false;
		this.isMinedWithHammer = false;
		this.isRockSpawnedIn = false;
		this.isRockBroken = false;
		if (!this.isBigRock)
		{
			base.gameObject.transform.localScale = new Vector2(2.6f, 2.6f);
		}
		if (!this.isBigRock)
		{
			this.SetAllOff();
		}
		if (LevelMechanics.talentLevel == 1)
		{
			this.rockHp = 10f;
		}
		else
		{
			int num = LevelMechanics.talentLevel * LevelMechanics.talentLevelHpIncrease;
			num -= LevelMechanics.talentLevelHpIncrease;
			this.rockHp = (float)(10 + num);
		}
		if (Artifacts.horn_found)
		{
			float num2 = Artifacts.hornRockDecrease;
			if (LevelMechanics.archaeologist_chosen && Artifacts.rune_found)
			{
				num2 *= 1f + LevelMechanics.archeologistIncrease + Artifacts.runeImproveAll;
			}
			else
			{
				if (LevelMechanics.archaeologist_chosen)
				{
					num2 *= 1f + LevelMechanics.archeologistIncrease;
				}
				if (Artifacts.rune_found)
				{
					num2 *= 1f + Artifacts.runeImproveAll;
				}
			}
			float num3 = 1f - num2;
			this.rockHp *= num3;
		}
		this.halfRockHp = this.rockHp / 2f;
		if (this.isBigRock)
		{
			this.rockRigidbody.constraints = RigidbodyConstraints2D.FreezeAll;
			this.isRockSpawnedIn = true;
			this.originalScale = base.transform.localScale;
			this.xScaleTo = this.originalScale.x / 1.06f;
			this.yScaleTo = this.originalScale.y / 0.99f;
			this.rockHp = 3500f;
			this.bigRock2ThirdHP = this.rockHp / 3f;
			this.bigRock2ThirdHP *= 2f;
			this.bigRock3ThirdHP = this.bigRock2ThirdHP / 2f;
			return;
		}
		base.StartCoroutine(this.WaitBeforeSpawningRocks());
	}

	// Token: 0x06000076 RID: 118 RVA: 0x000073F5 File Offset: 0x000055F5
	private IEnumerator WaitBeforeSpawningRocks()
	{
		yield return new WaitForSeconds(0.22f);
		this.SetRandomRocks();
		this.rockRigidbody.constraints = RigidbodyConstraints2D.FreezeAll;
		float scaleToSize = Random.Range(2.1f, 2.7f);
		base.StartCoroutine(this.ScaleRock(scaleToSize));
		yield break;
	}

	// Token: 0x06000077 RID: 119 RVA: 0x00007404 File Offset: 0x00005604
	public void SetRandomRocks()
	{
		this.hitByFire = false;
		this.isChunk = false;
		this.isFull = false;
		this.isGoldChunk = false;
		this.isFullGold = false;
		this.isCopperChunk = false;
		this.isFullCopper = false;
		this.isSilverChunk = false;
		this.isFullSilver = false;
		this.isCobaltChunk = false;
		this.isFullCobalt = false;
		this.isUraniumChunk = false;
		this.isFullUranium = false;
		this.isIsmiumChunk = false;
		this.isFullIsmium = false;
		this.isIridiumChunk = false;
		this.isFullIridium = false;
		this.isPainiteChunk = false;
		this.isFullPainite = false;
		bool flag = false;
		float num = 100f;
		float num2 = Random.Range(0f, num);
		if (SkillTree.painiteSpawn_purchased)
		{
			if (num2 < SkillTree.painiteRockChance && !flag)
			{
				AllStats.painiteChunkMined++;
				this.isChunk = true;
				flag = true;
				this.isPainiteChunk = true;
				this.chunkOfPainite.gameObject.SetActive(true);
				this.currentChunkSprite = this.chunkOfPainiteSprite;
			}
			num -= SkillTree.painiteRockChance;
			num2 = Random.Range(0f, num);
			if (num2 < SkillTree.fullPainiteRockChance && !flag)
			{
				AllStats.fullPainiteMined++;
				this.isChunk = false;
				flag = true;
				this.isFullPainite = true;
				this.isFull = true;
				this.currentActiveRock = this.fullPainite.gameObject;
				this.currentRockSprite = this.fullPainiteSprite;
				this.currentBrokenRock = this.rockPainiteBroken.gameObject;
				this.currentBrokenSprite = this.rockPainiteBrokenSprite;
			}
			num -= SkillTree.fullPainiteRockChance;
		}
		if (SkillTree.iridiumSpawn_purchased)
		{
			num2 = Random.Range(0f, num);
			if (num2 < SkillTree.iridiumRockChance && !flag)
			{
				AllStats.iridiumChunkMined++;
				this.isChunk = true;
				flag = true;
				this.isIridiumChunk = true;
				this.chunkOfIridium.gameObject.SetActive(true);
				this.currentChunkSprite = this.chunkOfIridiumSprite;
			}
			num -= SkillTree.iridiumRockChance;
			num2 = Random.Range(0f, num);
			if (num2 < SkillTree.fullIridiumRockChance && !flag)
			{
				AllStats.fullIridiumMined++;
				this.isChunk = false;
				flag = true;
				this.isFullIridium = true;
				this.isFull = true;
				this.currentActiveRock = this.fullIridium.gameObject;
				this.currentRockSprite = this.fullIridiumSprite;
				this.currentBrokenRock = this.rockIridiumBroken.gameObject;
				this.currentBrokenSprite = this.rockIridiumBrokenSprite;
			}
			num -= SkillTree.fullIridiumRockChance;
		}
		if (SkillTree.ismiumSpawn_purchased)
		{
			num2 = Random.Range(0f, num);
			if (num2 < SkillTree.ismiumRockChance && !flag)
			{
				AllStats.ismiumChunkMined++;
				this.isChunk = true;
				flag = true;
				this.isIsmiumChunk = true;
				this.chunkOfIsmium.gameObject.SetActive(true);
				this.currentChunkSprite = this.chunkOfIsmiumSprite;
			}
			num -= SkillTree.ismiumRockChance;
			num2 = Random.Range(0f, num);
			if (num2 < SkillTree.fullIsmiumRockChance && !flag)
			{
				AllStats.fullIsmiumMined++;
				this.isChunk = false;
				flag = true;
				this.isFullIsmium = true;
				this.isFull = true;
				this.currentActiveRock = this.fullIsmium.gameObject;
				this.currentRockSprite = this.fullIsmiumSprite;
				this.currentBrokenRock = this.rockIsmiumBroken.gameObject;
				this.currentBrokenSprite = this.rockIsmiumBrokenSprite;
			}
			num -= SkillTree.fullIsmiumRockChance;
		}
		if (SkillTree.uraniumSpawn_purchased)
		{
			num2 = Random.Range(0f, num);
			if (num2 < SkillTree.uraniumRockChance && !flag)
			{
				AllStats.uraniumChunkMined++;
				this.isChunk = true;
				flag = true;
				this.isUraniumChunk = true;
				this.chunkOfUranium.gameObject.SetActive(true);
				this.currentChunkSprite = this.chunkOfUraniumSprite;
			}
			num -= SkillTree.uraniumRockChance;
			num2 = Random.Range(0f, num);
			if (num2 < SkillTree.fullUraniumRockChance && !flag)
			{
				AllStats.fullUraniumMined++;
				this.isChunk = false;
				flag = true;
				this.isFullUranium = true;
				this.isFull = true;
				this.currentActiveRock = this.fullUranium.gameObject;
				this.currentRockSprite = this.fullUraniumSprite;
				this.currentBrokenRock = this.rockUraniumBroken.gameObject;
				this.currentBrokenSprite = this.rockUraniumBrokenSprite;
			}
			num -= SkillTree.fullUraniumRockChance;
		}
		if (SkillTree.cobaltSpawn_purchased)
		{
			num2 = Random.Range(0f, num);
			if (num2 < SkillTree.cobaltRockChance && !flag)
			{
				AllStats.cobaltChunkMined++;
				this.isChunk = true;
				flag = true;
				this.isCobaltChunk = true;
				this.chunkOfCobalt.gameObject.SetActive(true);
				this.currentChunkSprite = this.chunkOfCobaltSprite;
			}
			num -= SkillTree.cobaltRockChance;
			num2 = Random.Range(0f, num);
			if (num2 < SkillTree.fullCobaltRockChance && !flag)
			{
				AllStats.fullCobaltMined++;
				this.isChunk = false;
				flag = true;
				this.isFullCobalt = true;
				this.isFull = true;
				this.currentActiveRock = this.fullCobalt.gameObject;
				this.currentRockSprite = this.fullCobaltSprite;
				this.currentBrokenRock = this.rockCobaltBroken.gameObject;
				this.currentBrokenSprite = this.rockCobaltBrokenSprite;
			}
			num -= SkillTree.fullCobaltRockChance;
		}
		if (SkillTree.spawnIron_purchased)
		{
			num2 = Random.Range(0f, num);
			if (num2 < SkillTree.ironRockChance && !flag)
			{
				AllStats.ironChunkMined++;
				this.isChunk = true;
				flag = true;
				this.isSilverChunk = true;
				this.chunkOfSilver.gameObject.SetActive(true);
				this.currentChunkSprite = this.chunkOfSilverSprite;
			}
			num -= SkillTree.ironRockChance;
			num2 = Random.Range(0f, num);
			if (num2 < SkillTree.fullIronRockChance && !flag)
			{
				AllStats.fullIronMined++;
				this.isChunk = false;
				flag = true;
				this.isFullSilver = true;
				this.isFull = true;
				this.currentActiveRock = this.fullSilver.gameObject;
				this.currentRockSprite = this.fullSilverSprite;
				this.currentBrokenRock = this.rockSilverBroken.gameObject;
				this.currentBrokenSprite = this.rockSilverBrokenSprite;
			}
			num -= SkillTree.fullIronRockChance;
		}
		if (SkillTree.spawnCopper_purchased)
		{
			num2 = Random.Range(0f, num);
			if (num2 < SkillTree.copperRockChance && !flag)
			{
				AllStats.copperChunkMined++;
				this.isChunk = true;
				flag = true;
				this.isCopperChunk = true;
				this.chunkOfCopper.gameObject.SetActive(true);
				this.currentChunkSprite = this.chunkOfCopperSprite;
			}
			num -= SkillTree.copperRockChance;
			num2 = Random.Range(0f, num);
			if (num2 < SkillTree.fullCopperRockChance && !flag)
			{
				AllStats.fullCopperMined++;
				this.isChunk = false;
				flag = true;
				this.isFullCopper = true;
				this.isFull = true;
				this.currentActiveRock = this.fullCopper.gameObject;
				this.currentRockSprite = this.fullCopperSprite;
				this.currentBrokenRock = this.rockCopperBroken.gameObject;
				this.currentBrokenSprite = this.rockCopperBrokenSprite;
			}
			num -= SkillTree.fullCopperRockChance;
		}
		if (!flag)
		{
			num2 = Random.Range(0f, num);
			if (num2 < SkillTree.goldRockChance && !flag)
			{
				AllStats.goldChunkMined++;
				this.isChunk = true;
				flag = true;
				this.isGoldChunk = true;
				this.chunkOfGold.gameObject.SetActive(true);
				this.currentChunkSprite = this.chunkOfGoldSprite;
			}
			num -= SkillTree.goldRockChance;
			num2 = Random.Range(0f, num);
			if (num2 < SkillTree.fullGoldRockChance && !flag)
			{
				AllStats.fullGoldMined++;
				this.isChunk = false;
				flag = true;
				this.isFullGold = true;
				this.isFull = true;
				this.currentActiveRock = this.fullGold.gameObject;
				this.currentRockSprite = this.fullGoldSprite;
				this.currentBrokenRock = this.rockGoldBroken.gameObject;
				this.currentBrokenSprite = this.rockGoldBrokenSprite;
			}
		}
		if (!flag || this.isChunk)
		{
			this.currentActiveRock = this.rock1.gameObject;
			this.currentRockSprite = this.rock1Sprite;
			this.currentBrokenRock = this.rock1Broken.gameObject;
			this.currentBrokenSprite = this.rock1BrokenSprite;
		}
		if (LevelMechanics.chests_chosen && !this.spawnChest && Random.Range(0f, 100f) < LevelMechanics.rockSpawnChance)
		{
			this.SetAllOff();
			this.spawnChest = true;
		}
		if (LevelMechanics.goldenChests_chosen && !this.spawnGoldenChest && !SetRockScreen.spawnedGoldenChest && SetRockScreen.doSpawnGoldenChest)
		{
			int num3 = SkillTree.totalRocksToSpawn / 2;
			float num4 = 100f / (float)num3;
			if (Random.Range(0f, 95f) < num4)
			{
				this.SetAllOff();
				this.spawnGoldenChest = true;
				SetRockScreen.spawnedGoldenChest = true;
			}
		}
		if (!this.spawnChest && !this.spawnGoldenChest)
		{
			if (this.isChunk)
			{
				base.StartCoroutine(this.SetZPos(this.currentChunkSprite, true));
			}
			this.currentActiveRock.SetActive(true);
			base.StartCoroutine(this.SetZPos(this.currentRockSprite, false));
			this.currentBrokenRock.SetActive(false);
			base.StartCoroutine(this.SetZPos(this.currentBrokenSprite, false));
			return;
		}
		if (this.spawnChest)
		{
			this.chest.gameObject.SetActive(true);
			base.StartCoroutine(this.SetZPos(this.chestSprite, false));
			base.StartCoroutine(this.SetZPos(this.chestOpenSprite, false));
			return;
		}
		if (this.spawnGoldenChest)
		{
			this.goldenChest.gameObject.SetActive(true);
			base.StartCoroutine(this.SetZPos(this.goldenChestSprite, false));
			base.StartCoroutine(this.SetZPos(this.goldenChestOpenSprite, false));
		}
	}

	// Token: 0x06000078 RID: 120 RVA: 0x00007D3E File Offset: 0x00005F3E
	private IEnumerator SetZPos(SpriteRenderer rendererObject, bool isChunks)
	{
		yield return new WaitForSeconds(0.04f);
		float y = base.gameObject.transform.localPosition.y;
		Vector3 localPosition = base.gameObject.transform.localPosition;
		if (isChunks)
		{
			rendererObject.sortingOrder = -(int)y + 1;
		}
		else
		{
			rendererObject.sortingOrder = -(int)y;
		}
		yield break;
	}

	// Token: 0x06000079 RID: 121 RVA: 0x00007D5B File Offset: 0x00005F5B
	private IEnumerator ScaleRock(float scaleToSize)
	{
		float duration = 0.18f;
		float elapsedTime = 0f;
		Vector3 startScale = Vector3.zero;
		Vector3 endScale = Vector3.one * scaleToSize;
		while (elapsedTime < duration)
		{
			base.transform.localScale = Vector3.Lerp(startScale, endScale, elapsedTime / duration);
			elapsedTime += Time.deltaTime;
			yield return null;
		}
		this.isRockSpawnedIn = true;
		base.transform.localScale = endScale;
		this.originalScale = base.transform.localScale;
		this.xScaleTo = this.originalScale.x / 1.15f;
		this.yScaleTo = this.originalScale.y / 0.85f;
		yield break;
	}

	// Token: 0x0600007A RID: 122 RVA: 0x00007D74 File Offset: 0x00005F74
	public void OnTriggerEnter2D(Collider2D collision)
	{
		bool flag = false;
		if (SkillTree.allProjectileDoubleDamageChance_purchased)
		{
			flag = true;
		}
		float num = 1f;
		bool flag2 = false;
		if (SkillTree.allProjectileTriggerChance_purchased)
		{
			flag2 = true;
		}
		if (flag2)
		{
			num = 1f + SkillTree.allProjcetileTriggerChance / 100f;
		}
		if (collision.gameObject.layer == 6 || collision.gameObject.layer == 11 || collision.gameObject.layer == 12 || collision.gameObject.layer == 13)
		{
			if (this.isTestRock)
			{
				Debug.Log("Hit with picaxe!");
			}
			AllStats.pickaxeHits++;
			float time = Time.time;
			if (this.spawnChest || this.spawnGoldenChest)
			{
				this.overlappingScript.PlaySound(3, time);
			}
			else
			{
				this.overlappingScript.PlaySound(1, time);
			}
			if ((SkillTree.chanceToMineRandomRock_1_purchased || SkillTree.chanceToMineRandomRock_2_purchased || SkillTree.chanceToMineRandomRock_3_purchased || SkillTree.chanceToMineRandomRock_4_purchased) && (float)Random.Range(0, 100) < SkillTree.chanceToMineRandomRock)
			{
				this.spawnProjectileScript.SelectRandomActiveRock(3);
			}
			if ((SkillTree.lightningBeamChancePH_1_purchased || SkillTree.lightningBeamChancePH_2_purchased) && (float)Random.Range(0, 100) < SkillTree.lightningTriggerChancePH * num && SpawnProjectiles.totalBeamsOnScreen < 17)
			{
				RockMechanics.beamHitPos = collision.transform.position;
				this.spawnProjectileScript.SelectRandomActiveRock(4);
			}
			if ((SkillTree.dynamiteChance_1_purchased || SkillTree.dynamiteChance_2_purchased) && (float)Random.Range(0, 100) < SkillTree.dynamiteStickChance * num && SpawnProjectiles.totalDynamitesOnScreen < 20)
			{
				RockMechanics.dynamiteHitPos = collision.transform.position;
				this.spawnProjectileScript.SelectRandomActiveRock(5);
			}
			if (Artifacts.cheese_found)
			{
				float num2 = Random.Range(0f, 100f);
				float num3 = 1f + (LevelMechanics.archeologistIncrease + Artifacts.runeImproveAll);
				if (num2 < Artifacts.cheeseChance * num3 && SetRockScreen.isInMiningSession && !this.isBigRock)
				{
					this.SpawnMaterialPopUp(1);
				}
			}
			if (LevelMechanics.goldenTouch_chosen && SetRockScreen.isGoldenHand && Random.Range(0, 100) < LevelMechanics.midasTouchSpawnChance && !this.isBigRock && SetRockScreen.isInMiningSession)
			{
				this.SpawnMaterialPopUp(1);
			}
			float num4 = (float)Random.Range(0, 100);
			float num5 = 100f - SkillTree.instaMineChance;
			if (num4 < TheAnvil.current2XPowerChance + SkillTree.doubleDamageChance)
			{
				AllStats.doublePickaxePowerHits++;
				this.DamageRock(TheAnvil.currentMinePower * 2f);
				return;
			}
			if (num4 > num5)
			{
				if (!this.isBigRock)
				{
					this.DamageRock(TheAnvil.currentMinePower * 10000f);
					AllStats.instaMinePickaxeHits++;
					return;
				}
			}
			else
			{
				if (!Artifacts.axe_found)
				{
					this.DamageRock(TheAnvil.currentMinePower);
					return;
				}
				float num6 = Random.Range(0f, 100f);
				float num7 = 1f + (Artifacts.runeImproveAll + LevelMechanics.archeologistIncrease);
				float num8 = 99f - (Artifacts.runeImproveAll + LevelMechanics.archeologistIncrease);
				if (num6 < 2f * num7)
				{
					this.DamageRock(TheAnvil.currentMinePower * 2f);
					AllStats.doublePickaxePowerHits++;
					return;
				}
				if (num6 <= num8)
				{
					this.DamageRock(TheAnvil.currentMinePower);
					return;
				}
				if (!this.isBigRock)
				{
					this.DamageRock(TheAnvil.currentMinePower * 10000f);
					AllStats.instaMinePickaxeHits++;
					return;
				}
			}
		}
		else if (collision.gameObject.layer == 7)
		{
			if (!this.isMinedWithHammer)
			{
				LevelMechanics.rocksMinedByHammer++;
				if (!this.isBigRock)
				{
					this.DamageRock(TheAnvil.currentMinePower * 100000f);
				}
				this.isMinedWithHammer = true;
				return;
			}
		}
		else
		{
			if (collision.gameObject.tag == "Beam_PH")
			{
				float num9 = TheAnvil.currentMinePower * 2f * SkillTree.lightningDamage;
				float num10 = (float)Random.Range(0, 100);
				if (flag && num10 < SkillTree.allProjectileDoubleDamageIncrease)
				{
					num9 *= 2f;
				}
				this.DamageRock(num9);
				return;
			}
			if (collision.gameObject.tag == "Beam_S")
			{
				float num11 = TheAnvil.currentMinePower * 3f * SkillTree.lightningDamage;
				float num12 = (float)Random.Range(0, 100);
				if (flag && num12 < SkillTree.allProjectileDoubleDamageIncrease)
				{
					num11 *= 2f;
				}
				this.DamageRock(num11);
				return;
			}
			if (collision.gameObject.tag == "LightningSplash")
			{
				float num13 = TheAnvil.currentMinePower * 2f * SkillTree.lightningDamage;
				num13 *= 0.15f;
				this.DamageRock(num13);
				return;
			}
			if (collision.gameObject.tag == "PlazmaBallCollider")
			{
				float num14 = TheAnvil.currentMinePower * 0.75f * SkillTree.plazmaBallTotalDamage;
				float num15 = (float)Random.Range(0, 100);
				if (flag && num15 < SkillTree.allProjectileDoubleDamageIncrease)
				{
					num14 *= 2f;
				}
				this.DamageRock(num14);
				if (SkillTree.plazmaBallSpawnPickaxeChance_purchased && (float)Random.Range(0, 100) < SkillTree.plazmaBallChanceToSpawnPickaxe)
				{
					this.spawnProjectileScript.SelectRandomActiveRock(3);
					return;
				}
			}
			else
			{
				if (collision.gameObject.tag == "Dynamite")
				{
					float num16 = TheAnvil.currentMinePower * 1.2f * SkillTree.explosionDamagage;
					float num17 = (float)Random.Range(0, 100);
					if (flag && num17 < SkillTree.allProjectileDoubleDamageIncrease)
					{
						num16 *= 2f;
					}
					this.DamageRock(num16);
					return;
				}
				if (collision.gameObject.tag == "Fire")
				{
					this.hitByFire = true;
					if (!this.isBigRock)
					{
						this.DamageRock(TheAnvil.currentMinePower * 10000f);
					}
				}
			}
		}
	}

	// Token: 0x0600007B RID: 123 RVA: 0x000082E4 File Offset: 0x000064E4
	public void DamageRock(float damage)
	{
		if (!this.isRockSpawnedIn)
		{
			return;
		}
		this.rockHp -= damage;
		if (!this.isBigRock)
		{
			if (this.rockHp <= this.halfRockHp)
			{
				this.currentActiveRock.gameObject.SetActive(false);
				if (!this.spawnChest && !this.spawnGoldenChest)
				{
					this.currentBrokenRock.gameObject.SetActive(true);
				}
			}
		}
		else if (this.rockHp <= this.bigRock3ThirdHP)
		{
			this.bigRockFull.SetActive(false);
			this.bigRockBroken1.SetActive(false);
			this.bigRockBroken2.SetActive(true);
		}
		else if (this.rockHp <= this.bigRock2ThirdHP)
		{
			this.bigRockFull.SetActive(false);
			this.bigRockBroken1.SetActive(true);
		}
		if (this.rockHp <= 0f)
		{
			if (!this.isRockBroken)
			{
				Achievements.checkAch = true;
				this.isRockBroken = true;
				AllStats.totalRockMined++;
				SetRockScreen.totalRocksOnScreen--;
				float time = Time.time;
				this.overlappingScript.PlaySoundRockBreaking(1, time);
				if (Artifacts.oneArtifactSpawned)
				{
					Transform transform = base.transform.Find("AllArtifacts");
					if (transform != null)
					{
						transform.SetParent(this.originalArtifactParent.transform);
						Artifacts.minedRockWithArtifact = true;
						Artifacts.oneArtifactMined = true;
						if (Artifacts.horn_spawned)
						{
							Artifacts.horn_found = true;
						}
						if (Artifacts.ancientDevice_spawned)
						{
							Artifacts.ancientDevice_found = true;
						}
						if (Artifacts.bone_spawned)
						{
							Artifacts.bone_found = true;
							SkillTree.improvedPickaxeStrength += Artifacts.bonePickaxeIncrease;
							SkillTree.reducePickaxeMineTime -= Artifacts.bonePickaxeIncrease;
						}
						if (Artifacts.meteorieOre_spawned)
						{
							Artifacts.meteorieOre_found = true;
							float num = 1f + Artifacts.meteoriteRockSpawnIncrease;
							SkillTree.fullGoldRockChance *= num;
							SkillTree.fullCopperRockChance *= num;
							SkillTree.fullIronRockChance *= num;
							SkillTree.fullCobaltRockChance *= num;
							SkillTree.fullUraniumRockChance *= num;
							SkillTree.fullIsmiumRockChance *= num;
							SkillTree.fullIridiumRockChance *= num;
							SkillTree.fullPainiteRockChance *= num;
						}
						if (Artifacts.book_spawned)
						{
							Artifacts.book_found = true;
						}
						if (Artifacts.goldStack_spawned)
						{
							Artifacts.goldStack_found = true;
						}
						if (Artifacts.goldRing_spawned)
						{
							Artifacts.goldRing_found = true;
						}
						if (Artifacts.purpleRing_spawned)
						{
							Artifacts.purpleRing_found = true;
						}
						if (Artifacts.ancientDice_spawned)
						{
							Artifacts.ancientDice_found = true;
						}
						if (Artifacts.cheese_spawned)
						{
							Artifacts.cheese_found = true;
						}
						if (Artifacts.wolfClaw_spawned)
						{
							Artifacts.wolfClaw_found = true;
						}
						if (Artifacts.axe_spawned)
						{
							Artifacts.axe_found = true;
						}
						if (Artifacts.rune_spawned)
						{
							Artifacts.rune_found = true;
							Artifacts.runeImproveAll = 0.05f;
							SkillTree.improvedPickaxeStrength += 0.02f * Artifacts.runeImproveAll;
							SkillTree.reducePickaxeMineTime -= 0.02f * Artifacts.runeImproveAll;
							float num2 = 1f + 0.03f * Artifacts.runeImproveAll;
							SkillTree.fullGoldRockChance *= num2;
							SkillTree.fullCopperRockChance *= num2;
							SkillTree.fullIronRockChance *= num2;
							SkillTree.fullCobaltRockChance *= num2;
							SkillTree.fullUraniumRockChance *= num2;
							SkillTree.fullIsmiumRockChance *= num2;
							SkillTree.fullIridiumRockChance *= num2;
							SkillTree.fullPainiteRockChance *= num2;
						}
						if (Artifacts.skull_spawned)
						{
							Artifacts.skull_found = true;
							SkillTree.totalRocksToSpawn += 10;
						}
						this.artifactsScript.CheckFoundArtifacts();
					}
				}
				if (!this.isBigRock)
				{
					if (SkillTree.chanceAdd1SecondEveryRockMined_purchased && Random.Range(0f, 100f) < SkillTree.chanceToAdd1SecEveryRockMined)
					{
						SetRockScreen.currentTime -= 1f;
					}
					if (SkillTree.spawnRockEveryXrock_1_purchased || SkillTree.spawnRockEveryXrock_2_purchased || SkillTree.spawnRockEveryXrock_3_purchased)
					{
						SkillTree.rocksMinedBeforeSpawn++;
						if ((float)SkillTree.rocksMinedBeforeSpawn >= SkillTree.spawnRockEveryXRock)
						{
							SkillTree.rocksMinedBeforeSpawn = 0;
							this.SpawnRock();
						}
					}
					if ((float)Random.Range(0, 100) < SkillTree.chanceToSpawnRockWhenMined)
					{
						this.SpawnRock();
					}
				}
				this.rockRigidbody.constraints = RigidbodyConstraints2D.FreezeAll;
				if (this.spawnChest || this.spawnGoldenChest)
				{
					this.OpenChestAndSpawnLoot();
					return;
				}
				this.RockBreakParticle();
				if (!this.isBigRock)
				{
					this.levelScript.GiveXP();
					this.screenShakeScript.ShakeTheScreen();
					if (this.isChunk)
					{
						if (SetRockScreen.isInMiningSession || this.hitByFire)
						{
							this.SpawnMaterialPopUp(SkillTree.materialsFromChunkRocks);
						}
					}
					else if (this.isFull)
					{
						if (SetRockScreen.isInMiningSession || this.hitByFire)
						{
							this.SpawnMaterialPopUp(SkillTree.materialsFromFullRocks);
						}
					}
					else if (SetRockScreen.isInMiningSession || this.hitByFire)
					{
						this.SpawnMaterialPopUp(1);
					}
				}
				if (!this.isBigRock)
				{
					ObjectPool.instance.ReturnRockFromPool(base.gameObject);
					return;
				}
				base.gameObject.SetActive(false);
				return;
			}
		}
		else if (base.gameObject.activeInHierarchy)
		{
			if (!this.isBigRock)
			{
				if (this.rockScaleCoroutine != null)
				{
					base.StopCoroutine(this.rockScaleCoroutine);
					this.rockScaleCoroutine = base.StartCoroutine(this.ScaleXY());
					return;
				}
				this.rockScaleCoroutine = base.StartCoroutine(this.ScaleXY());
				return;
			}
			else
			{
				if (this.rockScaleCoroutineBIG != null)
				{
					base.StopCoroutine(this.rockScaleCoroutineBIG);
					this.rockScaleCoroutineBIG = base.StartCoroutine(this.ScaleXYBIGROCK());
					return;
				}
				this.rockScaleCoroutineBIG = base.StartCoroutine(this.ScaleXYBIGROCK());
			}
		}
	}

	// Token: 0x0600007C RID: 124 RVA: 0x00008829 File Offset: 0x00006A29
	public void SpawnRock()
	{
		if (SetRockScreen.isInMiningSession)
		{
			SetRockScreen.tileWaveNumber = Random.Range(0, 14);
			this.setRockScreenScript.SpawnRockCount(1);
		}
	}

	// Token: 0x0600007D RID: 125 RVA: 0x0000884C File Offset: 0x00006A4C
	public void OpenChestAndSpawnLoot()
	{
		this.RockBreakParticle();
		int num = 0;
		if (this.spawnChest)
		{
			num = LevelMechanics.totalChestMaterials;
			AllStats.chestsOpened++;
		}
		if (this.spawnGoldenChest)
		{
			num = LevelMechanics.totalGoldenChestMaterials;
			AllStats.goldenChestsOpened++;
		}
		for (int i = 0; i < num; i++)
		{
			GameObject textFromPool = ObjectPool.instance.GetTextFromPool();
			int totalMaterialRocksSpawning = SkillTree.totalMaterialRocksSpawning;
			int num2 = Random.Range(1, totalMaterialRocksSpawning + 1);
			if (num2 == 1)
			{
				textFromPool.gameObject.transform.localScale = new Vector2(0.25f, 0.25f);
			}
			if (num2 == 2)
			{
				textFromPool.gameObject.transform.localScale = new Vector2(0.35f, 0.35f);
			}
			if (num2 == 3)
			{
				textFromPool.gameObject.transform.localScale = new Vector2(0.45f, 0.45f);
			}
			if (num2 == 4)
			{
				textFromPool.gameObject.transform.localScale = new Vector2(0.55f, 0.55f);
			}
			if (num2 == 5)
			{
				textFromPool.gameObject.transform.localScale = new Vector2(0.65f, 0.65f);
			}
			if (num2 == 6)
			{
				textFromPool.gameObject.transform.localScale = new Vector2(0.75f, 0.75f);
			}
			if (num2 == 7)
			{
				textFromPool.gameObject.transform.localScale = new Vector2(0.85f, 0.85f);
			}
			if (num2 == 8)
			{
				textFromPool.gameObject.transform.localScale = new Vector2(0.95f, 0.95f);
			}
			float num3 = Random.Range(-0.5f, 0.5f);
			float num4 = Random.Range(0.4f, 0.6f);
			textFromPool.gameObject.transform.position = new Vector2(base.gameObject.transform.position.x + num3, base.gameObject.transform.position.y + num4);
		}
		if (!this.isBigRock)
		{
			ObjectPool.instance.ReturnRockFromPool(base.gameObject);
		}
	}

	// Token: 0x0600007E RID: 126 RVA: 0x00008A84 File Offset: 0x00006C84
	public void SpawnMaterialPopUp(int count)
	{
		for (int i = 0; i < count; i++)
		{
			if (MineMaterialMechanics.totalTextsOnScreen < 430)
			{
				GameObject textFromPool = ObjectPool.instance.GetTextFromPool();
				if (this.isGoldChunk || this.isFullGold)
				{
					textFromPool.gameObject.transform.localScale = new Vector2(0.25f, 0.25f);
				}
				else if (this.isCopperChunk || this.isFullCopper)
				{
					textFromPool.gameObject.transform.localScale = new Vector2(0.35f, 0.35f);
				}
				else if (this.isSilverChunk || this.isFullSilver)
				{
					textFromPool.gameObject.transform.localScale = new Vector2(0.45f, 0.45f);
				}
				else if (this.isCobaltChunk || this.isFullCobalt)
				{
					textFromPool.gameObject.transform.localScale = new Vector2(0.55f, 0.55f);
				}
				else if (this.isUraniumChunk || this.isFullUranium)
				{
					textFromPool.gameObject.transform.localScale = new Vector2(0.65f, 0.65f);
				}
				else if (this.isIsmiumChunk || this.isFullIsmium)
				{
					textFromPool.gameObject.transform.localScale = new Vector2(0.75f, 0.75f);
				}
				else if (this.isIridiumChunk || this.isFullIridium)
				{
					textFromPool.gameObject.transform.localScale = new Vector2(0.85f, 0.85f);
				}
				else if (this.isPainiteChunk || this.isFullPainite)
				{
					textFromPool.gameObject.transform.localScale = new Vector2(0.95f, 0.95f);
				}
				else
				{
					textFromPool.gameObject.transform.localScale = new Vector2(0.25f, 0.25f);
				}
				float num = Random.Range(-0.5f, 0.5f);
				float num2 = Random.Range(0.4f, 0.6f);
				textFromPool.gameObject.transform.position = new Vector2(base.gameObject.transform.position.x + num, base.gameObject.transform.position.y + num2);
			}
			else if (this.isGoldChunk || this.isFullGold)
			{
				this.goldScript.GiveMaterialOre(1, 1);
			}
			else if (this.isCopperChunk || this.isFullCopper)
			{
				this.goldScript.GiveMaterialOre(2, 1);
			}
			else if (this.isSilverChunk || this.isFullSilver)
			{
				this.goldScript.GiveMaterialOre(3, 1);
			}
			else if (this.isCobaltChunk || this.isFullCobalt)
			{
				this.goldScript.GiveMaterialOre(4, 1);
			}
			else if (this.isUraniumChunk || this.isFullUranium)
			{
				this.goldScript.GiveMaterialOre(5, 1);
			}
			else if (this.isIsmiumChunk || this.isFullIsmium)
			{
				this.goldScript.GiveMaterialOre(6, 1);
			}
			else if (this.isIridiumChunk || this.isFullIridium)
			{
				this.goldScript.GiveMaterialOre(7, 1);
			}
			else if (this.isPainiteChunk || this.isFullPainite)
			{
				this.goldScript.GiveMaterialOre(8, 1);
			}
			else
			{
				this.goldScript.GiveMaterialOre(1, 1);
			}
		}
	}

	// Token: 0x0600007F RID: 127 RVA: 0x00008E24 File Offset: 0x00007024
	public void RockBreakParticle()
	{
		GameObject rockParticleFromPool = ObjectPool.instance.GetRockParticleFromPool();
		rockParticleFromPool.transform.position = base.gameObject.transform.position;
		if (this.isBigRock)
		{
			rockParticleFromPool.transform.localScale = new Vector2(10f, 10f);
			TheEnding.bigRockBroken = true;
			return;
		}
		rockParticleFromPool.transform.localScale = new Vector2(2.6f, 2.6f);
	}

	// Token: 0x06000080 RID: 128 RVA: 0x00008EA4 File Offset: 0x000070A4
	private IEnumerator ScaleXY()
	{
		float halfDuration = this.duration / 2f;
		float elapsed = 0f;
		Vector3 targetScale = new Vector3(this.xScaleTo, this.yScaleTo, this.originalScale.z);
		while (elapsed < halfDuration)
		{
			float t = elapsed / halfDuration;
			base.transform.localScale = Vector3.Lerp(this.originalScale, targetScale, t);
			elapsed += Time.deltaTime;
			yield return null;
		}
		base.transform.localScale = targetScale;
		elapsed = 0f;
		while (elapsed < halfDuration)
		{
			float t2 = elapsed / halfDuration;
			base.transform.localScale = Vector3.Lerp(targetScale, this.originalScale, t2);
			elapsed += Time.deltaTime;
			yield return null;
		}
		base.transform.localScale = this.originalScale;
		this.rockScaleCoroutine = null;
		yield break;
	}

	// Token: 0x06000081 RID: 129 RVA: 0x00008EB3 File Offset: 0x000070B3
	private IEnumerator ScaleXYBIGROCK()
	{
		float halfDuration = this.duration / 1.4f;
		float elapsed = 0f;
		Vector3 targetScale = new Vector3(this.xScaleTo, this.yScaleTo, this.originalScale.z);
		while (elapsed < halfDuration)
		{
			float t = elapsed / halfDuration;
			base.transform.localScale = Vector3.Lerp(this.originalScale, targetScale, t);
			elapsed += Time.deltaTime;
			yield return null;
		}
		base.transform.localScale = targetScale;
		elapsed = 0f;
		while (elapsed < halfDuration)
		{
			float t2 = elapsed / halfDuration;
			base.transform.localScale = Vector3.Lerp(targetScale, this.originalScale, t2);
			elapsed += Time.deltaTime;
			yield return null;
		}
		base.transform.localScale = this.originalScale;
		this.rockScaleCoroutine = null;
		yield break;
	}

	// Token: 0x06000082 RID: 130 RVA: 0x00008EC4 File Offset: 0x000070C4
	private void SetMaterials()
	{
		this._materials = new Material[this._spriteRenderers.Length];
		for (int i = 0; i < this._spriteRenderers.Length; i++)
		{
			this._materials[i] = this._spriteRenderers[i].material;
		}
	}

	// Token: 0x06000083 RID: 131 RVA: 0x00008F0C File Offset: 0x0000710C
	public void ApplyFlash()
	{
	}

	// Token: 0x06000084 RID: 132 RVA: 0x00008F0E File Offset: 0x0000710E
	private IEnumerator TriggerWhiteFlash()
	{
		this.SetFlahsColor();
		float elaspedTime = 0f;
		while (elaspedTime < this._flashTime)
		{
			elaspedTime += Time.deltaTime;
			float flashAmount = Mathf.Lerp(1f, 0f, elaspedTime / this._flashTime);
			this.SetFlashAmount(flashAmount);
			yield return null;
		}
		this.flashCoroutine = null;
		yield break;
	}

	// Token: 0x06000085 RID: 133 RVA: 0x00008F20 File Offset: 0x00007120
	private void SetFlahsColor()
	{
		for (int i = 0; i < this._materials.Length; i++)
		{
			this._materials[i].SetColor("_FlashColor", this._flashColor);
		}
	}

	// Token: 0x06000086 RID: 134 RVA: 0x00008F58 File Offset: 0x00007158
	private void SetFlashAmount(float amount)
	{
		for (int i = 0; i < this._materials.Length; i++)
		{
			this._materials[i].SetFloat("_FlashAmount", amount);
		}
	}

	// Token: 0x04000209 RID: 521
	public bool isTestRock;

	// Token: 0x0400020A RID: 522
	public ScreenShake screenShakeScript;

	// Token: 0x0400020B RID: 523
	public LevelMechanics levelScript;

	// Token: 0x0400020C RID: 524
	public SpawnProjectiles spawnProjectileScript;

	// Token: 0x0400020D RID: 525
	public SetRockScreen setRockScreenScript;

	// Token: 0x0400020E RID: 526
	public Artifacts artifactsScript;

	// Token: 0x0400020F RID: 527
	public OverlappingSounds overlappingScript;

	// Token: 0x04000210 RID: 528
	public GoldAndOreMechanics goldScript;

	// Token: 0x04000211 RID: 529
	public Transform rock1;

	// Token: 0x04000212 RID: 530
	public SpriteRenderer rock1Sprite;

	// Token: 0x04000213 RID: 531
	public bool isRockSpawnedIn;

	// Token: 0x04000214 RID: 532
	public Transform rock1Broken;

	// Token: 0x04000215 RID: 533
	public SpriteRenderer rock1BrokenSprite;

	// Token: 0x04000216 RID: 534
	public Transform rockGoldBroken;

	// Token: 0x04000217 RID: 535
	public SpriteRenderer rockGoldBrokenSprite;

	// Token: 0x04000218 RID: 536
	public Transform rockCopperBroken;

	// Token: 0x04000219 RID: 537
	public SpriteRenderer rockCopperBrokenSprite;

	// Token: 0x0400021A RID: 538
	public Transform rockSilverBroken;

	// Token: 0x0400021B RID: 539
	public SpriteRenderer rockSilverBrokenSprite;

	// Token: 0x0400021C RID: 540
	public Transform rockCobaltBroken;

	// Token: 0x0400021D RID: 541
	public SpriteRenderer rockCobaltBrokenSprite;

	// Token: 0x0400021E RID: 542
	public Transform rockUraniumBroken;

	// Token: 0x0400021F RID: 543
	public SpriteRenderer rockUraniumBrokenSprite;

	// Token: 0x04000220 RID: 544
	public Transform rockIsmiumBroken;

	// Token: 0x04000221 RID: 545
	public SpriteRenderer rockIsmiumBrokenSprite;

	// Token: 0x04000222 RID: 546
	public Transform rockIridiumBroken;

	// Token: 0x04000223 RID: 547
	public SpriteRenderer rockIridiumBrokenSprite;

	// Token: 0x04000224 RID: 548
	public Transform rockPainiteBroken;

	// Token: 0x04000225 RID: 549
	public SpriteRenderer rockPainiteBrokenSprite;

	// Token: 0x04000226 RID: 550
	public Transform chunkOfGold;

	// Token: 0x04000227 RID: 551
	public SpriteRenderer chunkOfGoldSprite;

	// Token: 0x04000228 RID: 552
	public Transform fullGold;

	// Token: 0x04000229 RID: 553
	public SpriteRenderer fullGoldSprite;

	// Token: 0x0400022A RID: 554
	public Transform chunkOfCopper;

	// Token: 0x0400022B RID: 555
	public SpriteRenderer chunkOfCopperSprite;

	// Token: 0x0400022C RID: 556
	public Transform fullCopper;

	// Token: 0x0400022D RID: 557
	public SpriteRenderer fullCopperSprite;

	// Token: 0x0400022E RID: 558
	public Transform chunkOfSilver;

	// Token: 0x0400022F RID: 559
	public SpriteRenderer chunkOfSilverSprite;

	// Token: 0x04000230 RID: 560
	public Transform fullSilver;

	// Token: 0x04000231 RID: 561
	public SpriteRenderer fullSilverSprite;

	// Token: 0x04000232 RID: 562
	public Transform chunkOfCobalt;

	// Token: 0x04000233 RID: 563
	public SpriteRenderer chunkOfCobaltSprite;

	// Token: 0x04000234 RID: 564
	public Transform fullCobalt;

	// Token: 0x04000235 RID: 565
	public SpriteRenderer fullCobaltSprite;

	// Token: 0x04000236 RID: 566
	public Transform chunkOfUranium;

	// Token: 0x04000237 RID: 567
	public SpriteRenderer chunkOfUraniumSprite;

	// Token: 0x04000238 RID: 568
	public Transform fullUranium;

	// Token: 0x04000239 RID: 569
	public SpriteRenderer fullUraniumSprite;

	// Token: 0x0400023A RID: 570
	public Transform chunkOfIsmium;

	// Token: 0x0400023B RID: 571
	public SpriteRenderer chunkOfIsmiumSprite;

	// Token: 0x0400023C RID: 572
	public Transform fullIsmium;

	// Token: 0x0400023D RID: 573
	public SpriteRenderer fullIsmiumSprite;

	// Token: 0x0400023E RID: 574
	public Transform chunkOfIridium;

	// Token: 0x0400023F RID: 575
	public SpriteRenderer chunkOfIridiumSprite;

	// Token: 0x04000240 RID: 576
	public Transform fullIridium;

	// Token: 0x04000241 RID: 577
	public SpriteRenderer fullIridiumSprite;

	// Token: 0x04000242 RID: 578
	public Transform chunkOfPainite;

	// Token: 0x04000243 RID: 579
	public SpriteRenderer chunkOfPainiteSprite;

	// Token: 0x04000244 RID: 580
	public Transform fullPainite;

	// Token: 0x04000245 RID: 581
	public SpriteRenderer fullPainiteSprite;

	// Token: 0x04000246 RID: 582
	public GameObject currentActiveRock;

	// Token: 0x04000247 RID: 583
	public GameObject currentBrokenRock;

	// Token: 0x04000248 RID: 584
	public SpriteRenderer currentRockSprite;

	// Token: 0x04000249 RID: 585
	public SpriteRenderer currentBrokenSprite;

	// Token: 0x0400024A RID: 586
	public SpriteRenderer currentChunkSprite;

	// Token: 0x0400024B RID: 587
	private bool isGoldChunk;

	// Token: 0x0400024C RID: 588
	private bool isFullGold;

	// Token: 0x0400024D RID: 589
	private bool isCopperChunk;

	// Token: 0x0400024E RID: 590
	private bool isFullCopper;

	// Token: 0x0400024F RID: 591
	private bool isSilverChunk;

	// Token: 0x04000250 RID: 592
	private bool isFullSilver;

	// Token: 0x04000251 RID: 593
	private bool isCobaltChunk;

	// Token: 0x04000252 RID: 594
	private bool isFullCobalt;

	// Token: 0x04000253 RID: 595
	private bool isUraniumChunk;

	// Token: 0x04000254 RID: 596
	private bool isFullUranium;

	// Token: 0x04000255 RID: 597
	private bool isIsmiumChunk;

	// Token: 0x04000256 RID: 598
	private bool isFullIsmium;

	// Token: 0x04000257 RID: 599
	private bool isIridiumChunk;

	// Token: 0x04000258 RID: 600
	private bool isFullIridium;

	// Token: 0x04000259 RID: 601
	private bool isPainiteChunk;

	// Token: 0x0400025A RID: 602
	private bool isFullPainite;

	// Token: 0x0400025B RID: 603
	public float rockHp;

	// Token: 0x0400025C RID: 604
	private Collider2D rockCollider;

	// Token: 0x0400025D RID: 605
	private bool isMinedWithHammer;

	// Token: 0x0400025E RID: 606
	public GameObject originalArtifactParent;

	// Token: 0x0400025F RID: 607
	private Transform chest;

	// Token: 0x04000260 RID: 608
	private Transform chestOpen;

	// Token: 0x04000261 RID: 609
	private Transform goldenChest;

	// Token: 0x04000262 RID: 610
	private Transform goldenChestOpen;

	// Token: 0x04000263 RID: 611
	private SpriteRenderer chestSprite;

	// Token: 0x04000264 RID: 612
	private SpriteRenderer chestOpenSprite;

	// Token: 0x04000265 RID: 613
	private SpriteRenderer goldenChestSprite;

	// Token: 0x04000266 RID: 614
	private SpriteRenderer goldenChestOpenSprite;

	// Token: 0x04000267 RID: 615
	public Rigidbody2D rockRigidbody;

	// Token: 0x04000268 RID: 616
	public bool isBigRock;

	// Token: 0x04000269 RID: 617
	public GameObject bigRockFull;

	// Token: 0x0400026A RID: 618
	public GameObject bigRockBroken1;

	// Token: 0x0400026B RID: 619
	public GameObject bigRockBroken2;

	// Token: 0x0400026C RID: 620
	private bool spawnChest;

	// Token: 0x0400026D RID: 621
	private bool spawnGoldenChest;

	// Token: 0x0400026E RID: 622
	private float halfRockHp;

	// Token: 0x0400026F RID: 623
	private float bigRock2ThirdHP;

	// Token: 0x04000270 RID: 624
	private float bigRock3ThirdHP;

	// Token: 0x04000271 RID: 625
	private bool isChunk;

	// Token: 0x04000272 RID: 626
	private bool isFull;

	// Token: 0x04000273 RID: 627
	public static Vector2 beamHitPos;

	// Token: 0x04000274 RID: 628
	public static Vector2 dynamiteHitPos;

	// Token: 0x04000275 RID: 629
	private bool hitByFire;

	// Token: 0x04000276 RID: 630
	private bool isRockBroken;

	// Token: 0x04000277 RID: 631
	private Vector3 originalScale;

	// Token: 0x04000278 RID: 632
	private float duration = 0.2f;

	// Token: 0x04000279 RID: 633
	public float xScaleTo;

	// Token: 0x0400027A RID: 634
	public float yScaleTo;

	// Token: 0x0400027B RID: 635
	public Coroutine rockScaleCoroutine;

	// Token: 0x0400027C RID: 636
	public Coroutine rockScaleCoroutineBIG;

	// Token: 0x0400027D RID: 637
	[SerializeField]
	private Color _flashColor = Color.white;

	// Token: 0x0400027E RID: 638
	[SerializeField]
	private float _flashTime = 0.2f;

	// Token: 0x0400027F RID: 639
	public SpriteRenderer[] _spriteRenderers;

	// Token: 0x04000280 RID: 640
	public Material[] _materials;

	// Token: 0x04000281 RID: 641
	private Coroutine flashCoroutine;
}
