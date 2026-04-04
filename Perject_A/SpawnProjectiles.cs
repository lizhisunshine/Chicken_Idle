using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000039 RID: 57
public class SpawnProjectiles : MonoBehaviour
{
	// Token: 0x060001D9 RID: 473 RVA: 0x00052367 File Offset: 0x00050567
	public static void AddRock(GameObject rock)
	{
		if (!SpawnProjectiles.rockArray.Contains(rock))
		{
			SpawnProjectiles.rockArray.Add(rock);
		}
	}

	// Token: 0x060001DA RID: 474 RVA: 0x00052384 File Offset: 0x00050584
	public void SelectRandomActiveRock(int projectileType)
	{
		List<GameObject> list = new List<GameObject>();
		foreach (GameObject gameObject in SpawnProjectiles.rockArray)
		{
			if (gameObject != null && gameObject.activeSelf)
			{
				list.Add(gameObject);
			}
		}
		SpawnProjectiles.totalRocksActive = list.Count;
		if (list.Count > 0)
		{
			int index = Random.Range(0, list.Count);
			GameObject gameObject2 = list[index];
			if (projectileType == 1 && SetRockScreen.isInMiningSession)
			{
				if (!SetRockScreen.isInEnding)
				{
					this.plazmaStartPos = gameObject2.transform.position;
					GameObject plazmaBallFromPool = ObjectPool.instance.GetPlazmaBallFromPool();
					float num = Random.Range(0.8f * SkillTree.plazmaBallTotalSize, 0.9f * SkillTree.plazmaBallTotalSize);
					plazmaBallFromPool.transform.localScale = new Vector3(num, num, num);
					plazmaBallFromPool.transform.position = this.plazmaStartPos;
					base.StartCoroutine(this.ScaleObject(plazmaBallFromPool, num));
					AllStats.plazmaBallsSpawned++;
					return;
				}
			}
			else
			{
				if (projectileType == 2 && SetRockScreen.isInMiningSession)
				{
					GameObject beamOfLightFromPool = ObjectPool.instance.GetBeamOfLightFromPool();
					float time = Time.time;
					this.overlappingScript.PlaySoundMaterialCollect(2, time);
					float num2 = 7.2f * SkillTree.lightningSize;
					beamOfLightFromPool.transform.localScale = new Vector3(num2, num2, num2);
					beamOfLightFromPool.tag = "Beam_S";
					beamOfLightFromPool.transform.position = gameObject2.transform.position;
					AllStats.lightningStrikes++;
					SpawnProjectiles.totalBeamsOnScreen++;
					return;
				}
				if (projectileType == 3 && SetRockScreen.isInMiningSession)
				{
					GameObject pickaxeFromPool = ObjectPool.instance.GetPickaxeFromPool();
					Vector2 vector = gameObject2.transform.position;
					float x;
					float y;
					if (Random.Range(1, 3) == 1)
					{
						pickaxeFromPool.layer = 6;
						x = vector.x - 0.22f;
						y = vector.y + 0.22f;
					}
					else
					{
						pickaxeFromPool.layer = 11;
						x = vector.x + 0.22f;
						y = vector.y + 0.22f;
					}
					pickaxeFromPool.transform.localScale = new Vector2(1f, 1f);
					pickaxeFromPool.transform.position = new Vector2(x, y);
					return;
				}
				if (projectileType == 4 && SetRockScreen.isInMiningSession)
				{
					float time2 = Time.time;
					this.overlappingScript.PlaySoundMaterialCollect(2, time2);
					GameObject beamOfLightFromPool2 = ObjectPool.instance.GetBeamOfLightFromPool();
					float num3 = 6f * SkillTree.lightningSize;
					beamOfLightFromPool2.transform.localScale = new Vector3(num3, num3, num3);
					beamOfLightFromPool2.tag = "Beam_PH";
					beamOfLightFromPool2.transform.position = RockMechanics.beamHitPos;
					SpawnProjectiles.totalBeamsOnScreen++;
					AllStats.lightningStrikes++;
					return;
				}
				if (projectileType == 5 && SetRockScreen.isInMiningSession)
				{
					GameObject dynamiteFromPool = ObjectPool.instance.GetDynamiteFromPool();
					dynamiteFromPool.tag = "Dynamite";
					dynamiteFromPool.transform.position = RockMechanics.dynamiteHitPos;
					AllStats.dynamiteExplosions++;
					SpawnProjectiles.totalDynamitesOnScreen++;
					return;
				}
				if (projectileType == 6 && SetRockScreen.isInMiningSession)
				{
					float time3 = Time.time;
					this.overlappingScript.PlaySoundMaterialCollect(2, time3);
					GameObject beamOfLightFromPool3 = ObjectPool.instance.GetBeamOfLightFromPool();
					float num4 = 6f * SkillTree.lightningSize;
					beamOfLightFromPool3.transform.localScale = new Vector3(num4, num4, num4);
					beamOfLightFromPool3.tag = "Beam_PH";
					beamOfLightFromPool3.transform.position = gameObject2.transform.position;
					AllStats.lightningStrikes++;
					SpawnProjectiles.totalBeamsOnScreen++;
					return;
				}
				if (projectileType == 7)
				{
					this.horn_icon.SetActive(false);
					this.ancientDevice_icon.SetActive(false);
					this.bone_icon.SetActive(false);
					this.meteorieOre_icon.SetActive(false);
					this.book_icon.SetActive(false);
					this.goldStack_icon.SetActive(false);
					this.goldRing_icon.SetActive(false);
					this.purpleRing_icon.SetActive(false);
					this.ancientDice_icon.SetActive(false);
					this.cheese_icon.SetActive(false);
					this.wolfClaw_icon.SetActive(false);
					this.axe_icon.SetActive(false);
					this.rune_icon.SetActive(false);
					this.skull_icon.SetActive(false);
					this.allArtifactsParent.transform.SetParent(gameObject2.transform);
					SpawnProjectiles.artifactPos = gameObject2.transform.position;
					this.allArtifactsParent.transform.localScale = new Vector2(0.02f, 0.02f);
					this.allArtifactsParent.transform.localPosition = new Vector2(0f, 0f);
					this.allArtifactsParent.SetActive(true);
					base.StartCoroutine(this.CheckRockScale(gameObject2));
				}
			}
		}
	}

	// Token: 0x060001DB RID: 475 RVA: 0x000528BC File Offset: 0x00050ABC
	private IEnumerator CheckRockScale(GameObject rock)
	{
		while (rock.gameObject.transform.localScale.x > 0.15f && !SetRockScreen.isInMiningSession)
		{
			yield return null;
		}
		if (Artifacts.horn_spawned)
		{
			this.horn_icon.SetActive(true);
		}
		else if (Artifacts.ancientDevice_spawned)
		{
			this.ancientDevice_icon.SetActive(true);
		}
		else if (Artifacts.bone_spawned)
		{
			this.bone_icon.SetActive(true);
		}
		else if (Artifacts.meteorieOre_spawned)
		{
			this.meteorieOre_icon.SetActive(true);
		}
		else if (Artifacts.book_spawned)
		{
			this.book_icon.SetActive(true);
		}
		else if (Artifacts.goldStack_spawned)
		{
			this.goldStack_icon.SetActive(true);
		}
		else if (Artifacts.goldRing_spawned)
		{
			this.goldRing_icon.SetActive(true);
		}
		else if (Artifacts.purpleRing_spawned)
		{
			this.purpleRing_icon.SetActive(true);
		}
		else if (Artifacts.ancientDice_spawned)
		{
			this.ancientDice_icon.SetActive(true);
		}
		else if (Artifacts.cheese_spawned)
		{
			this.cheese_icon.SetActive(true);
		}
		else if (Artifacts.wolfClaw_spawned)
		{
			this.wolfClaw_icon.SetActive(true);
		}
		else if (Artifacts.axe_spawned)
		{
			this.axe_icon.SetActive(true);
		}
		else if (Artifacts.rune_spawned)
		{
			this.rune_icon.SetActive(true);
		}
		else if (Artifacts.skull_spawned)
		{
			this.skull_icon.SetActive(true);
		}
		yield break;
	}

	// Token: 0x060001DC RID: 476 RVA: 0x000528D2 File Offset: 0x00050AD2
	public int GetRockIndex(GameObject rock)
	{
		if (rock == null)
		{
			Debug.LogError("Rock is null. Cannot find index.");
			return -1;
		}
		int num = SpawnProjectiles.rockArray.IndexOf(rock);
		if (num == -1)
		{
			Debug.LogWarning("The provided rock is not in the list.");
		}
		return num;
	}

	// Token: 0x060001DD RID: 477 RVA: 0x00052902 File Offset: 0x00050B02
	public void SpawnPlazmaBalls()
	{
		if (this.plazmaBallTimerCorutine == null)
		{
			this.plazmaBallTimerCorutine = base.StartCoroutine(this.PlazmaBallTimer());
			return;
		}
		base.StopCoroutine(this.plazmaBallTimerCorutine);
		this.plazmaBallTimerCorutine = base.StartCoroutine(this.PlazmaBallTimer());
	}

	// Token: 0x060001DE RID: 478 RVA: 0x0005293D File Offset: 0x00050B3D
	private IEnumerator PlazmaBallTimer()
	{
		for (;;)
		{
			yield return new WaitForSeconds(1f);
			float num = 1f;
			bool flag = false;
			if (SkillTree.allProjectileTriggerChance_purchased)
			{
				flag = true;
			}
			if (flag)
			{
				num = 1f + SkillTree.allProjcetileTriggerChance / 100f;
			}
			if (SetRockScreen.isInMiningSession && (float)Random.Range(0, 100) < SkillTree.plazmaBallChance * num)
			{
				this.SelectRandomActiveRock(1);
			}
		}
		yield break;
	}

	// Token: 0x060001DF RID: 479 RVA: 0x0005294C File Offset: 0x00050B4C
	public void SpawnPickaxe()
	{
		if (this.spawnPickaxeCorotuine == null)
		{
			this.spawnPickaxeCorotuine = base.StartCoroutine(this.PickaxeTimer());
			return;
		}
		base.StopCoroutine(this.spawnPickaxeCorotuine);
		this.spawnPickaxeCorotuine = base.StartCoroutine(this.PickaxeTimer());
	}

	// Token: 0x060001E0 RID: 480 RVA: 0x00052987 File Offset: 0x00050B87
	private IEnumerator PickaxeTimer()
	{
		for (;;)
		{
			yield return new WaitForSeconds(SkillTree.spawnPickaxeEverySecond);
			if (SetRockScreen.isInMiningSession)
			{
				this.SelectRandomActiveRock(3);
			}
		}
		yield break;
	}

	// Token: 0x060001E1 RID: 481 RVA: 0x00052996 File Offset: 0x00050B96
	public void SpawnLightningS()
	{
		if (this.spawnLightningCoroutine == null)
		{
			this.spawnLightningCoroutine = base.StartCoroutine(this.LightningBeamTimer());
			return;
		}
		base.StopCoroutine(this.spawnLightningCoroutine);
		this.spawnLightningCoroutine = base.StartCoroutine(this.LightningBeamTimer());
	}

	// Token: 0x060001E2 RID: 482 RVA: 0x000529D1 File Offset: 0x00050BD1
	private IEnumerator LightningBeamTimer()
	{
		for (;;)
		{
			yield return new WaitForSeconds(1f);
			float num = (float)Random.Range(0, 100);
			float num2 = 1f;
			bool flag = false;
			if (SkillTree.allProjectileTriggerChance_purchased)
			{
				flag = true;
			}
			if (flag)
			{
				num2 = 1f + SkillTree.allProjcetileTriggerChance / 100f;
			}
			if (num < SkillTree.lightningTriggerChanceS * num2 && (SetRockScreen.isInMiningSession || SetRockScreen.isInEnding))
			{
				this.SelectRandomActiveRock(2);
			}
		}
		yield break;
	}

	// Token: 0x060001E3 RID: 483 RVA: 0x000529E0 File Offset: 0x00050BE0
	private IEnumerator ScaleObject(GameObject objectToScale, float scaleToSize)
	{
		float duration = 0.2f;
		float elapsedTime = 0f;
		Vector3 startScale = Vector3.zero;
		Vector3 endScale = Vector3.one * scaleToSize;
		while (elapsedTime < duration)
		{
			objectToScale.transform.localScale = Vector3.Lerp(startScale, endScale, elapsedTime / duration);
			elapsedTime += Time.deltaTime;
			yield return null;
		}
		objectToScale.transform.localScale = endScale;
		yield break;
	}

	// Token: 0x060001E4 RID: 484 RVA: 0x000529F6 File Offset: 0x00050BF6
	public void ResetSpanwProjeciles()
	{
		base.StopAllCoroutines();
	}

	// Token: 0x04000DFA RID: 3578
	public static List<GameObject> rockArray = new List<GameObject>();

	// Token: 0x04000DFB RID: 3579
	public GameObject allArtifactsParent;

	// Token: 0x04000DFC RID: 3580
	public GameObject originalAritfactParent;

	// Token: 0x04000DFD RID: 3581
	public GameObject horn_icon;

	// Token: 0x04000DFE RID: 3582
	public GameObject ancientDevice_icon;

	// Token: 0x04000DFF RID: 3583
	public GameObject bone_icon;

	// Token: 0x04000E00 RID: 3584
	public GameObject meteorieOre_icon;

	// Token: 0x04000E01 RID: 3585
	public GameObject book_icon;

	// Token: 0x04000E02 RID: 3586
	public GameObject goldStack_icon;

	// Token: 0x04000E03 RID: 3587
	public GameObject goldRing_icon;

	// Token: 0x04000E04 RID: 3588
	public GameObject purpleRing_icon;

	// Token: 0x04000E05 RID: 3589
	public GameObject ancientDice_icon;

	// Token: 0x04000E06 RID: 3590
	public GameObject cheese_icon;

	// Token: 0x04000E07 RID: 3591
	public GameObject wolfClaw_icon;

	// Token: 0x04000E08 RID: 3592
	public GameObject axe_icon;

	// Token: 0x04000E09 RID: 3593
	public GameObject rune_icon;

	// Token: 0x04000E0A RID: 3594
	public GameObject skull_icon;

	// Token: 0x04000E0B RID: 3595
	public static Vector2 artifactPos;

	// Token: 0x04000E0C RID: 3596
	public OverlappingSounds overlappingScript;

	// Token: 0x04000E0D RID: 3597
	public static int totalDynamitesOnScreen;

	// Token: 0x04000E0E RID: 3598
	public static int totalBeamsOnScreen;

	// Token: 0x04000E0F RID: 3599
	public static int totalRocksActive;

	// Token: 0x04000E10 RID: 3600
	public Vector2 plazmaStartPos;

	// Token: 0x04000E11 RID: 3601
	public Coroutine plazmaBallTimerCorutine;

	// Token: 0x04000E12 RID: 3602
	public Coroutine spawnPickaxeCorotuine;

	// Token: 0x04000E13 RID: 3603
	public Coroutine spawnLightningCoroutine;
}
