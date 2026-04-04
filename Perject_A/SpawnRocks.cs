using System;
using System.Collections;
using UnityEngine;

// Token: 0x0200003A RID: 58
public class SpawnRocks : MonoBehaviour
{
	// Token: 0x060001E7 RID: 487 RVA: 0x00052A12 File Offset: 0x00050C12
	public void SpawnRockXSecond()
	{
		if (SpawnRocks.spawnRockCoroutine != null)
		{
			base.StopCoroutine(SpawnRocks.spawnRockCoroutine);
			SpawnRocks.spawnRockCoroutine = base.StartCoroutine(this.SpawnRockWait());
			return;
		}
		SpawnRocks.spawnRockCoroutine = base.StartCoroutine(this.SpawnRockWait());
	}

	// Token: 0x060001E8 RID: 488 RVA: 0x00052A49 File Offset: 0x00050C49
	private IEnumerator SpawnRockWait()
	{
		float waitTime = SkillTree.spawnXRockEveryXSecond;
		for (;;)
		{
			yield return new WaitForSeconds(waitTime);
			if (SetRockScreen.isInMiningSession)
			{
				SetRockScreen.tileWaveNumber = Random.Range(0, 13);
				this.setRockScreeScript.SpawnRockCount(1);
			}
		}
		yield break;
	}

	// Token: 0x060001E9 RID: 489 RVA: 0x00052A58 File Offset: 0x00050C58
	public void SpawnRockDice()
	{
		if (Artifacts.ancientDice_found)
		{
			if (SpawnRocks.ancientDiceRockSpawn != null)
			{
				base.StopCoroutine(SpawnRocks.ancientDiceRockSpawn);
				SpawnRocks.ancientDiceRockSpawn = base.StartCoroutine(this.SpawnRock_Dice());
				return;
			}
			SpawnRocks.ancientDiceRockSpawn = base.StartCoroutine(this.SpawnRock_Dice());
		}
	}

	// Token: 0x060001EA RID: 490 RVA: 0x00052A96 File Offset: 0x00050C96
	private IEnumerator SpawnRock_Dice()
	{
		float waitTime = Artifacts.diceTime;
		for (;;)
		{
			if (LevelMechanics.archaeologist_chosen && Artifacts.rune_found)
			{
				waitTime = 1f - (LevelMechanics.archeologistIncrease + Artifacts.runeImproveAll);
			}
			else
			{
				if (LevelMechanics.archaeologist_chosen)
				{
					waitTime = 1f - LevelMechanics.archeologistIncrease;
				}
				if (Artifacts.rune_found)
				{
					waitTime = 1f - Artifacts.runeImproveAll;
				}
			}
			yield return new WaitForSeconds(waitTime);
			if (SetRockScreen.isInMiningSession)
			{
				SetRockScreen.tileWaveNumber = Random.Range(0, 14);
				this.setRockScreeScript.SpawnRockCount(1);
			}
		}
		yield break;
	}

	// Token: 0x04000E14 RID: 3604
	public SetRockScreen setRockScreeScript;

	// Token: 0x04000E15 RID: 3605
	public static Coroutine spawnRockCoroutine;

	// Token: 0x04000E16 RID: 3606
	public static Coroutine ancientDiceRockSpawn;
}
