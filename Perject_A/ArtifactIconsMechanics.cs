using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000002 RID: 2
public class ArtifactIconsMechanics : MonoBehaviour
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	private void OnEnable()
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
		this.startMoving = false;
	}

	// Token: 0x06000002 RID: 2 RVA: 0x0000210C File Offset: 0x0000030C
	private void Update()
	{
		if (Artifacts.minedRockWithArtifact && !this.startMoving)
		{
			this.startMoving = true;
			this.horn_stuck.SetActive(false);
			this.ancientDevice_stuck.SetActive(false);
			this.bone_stuck.SetActive(false);
			this.meteorieOre_stuck.SetActive(false);
			this.book_stuck.SetActive(false);
			this.goldStack_stuck.SetActive(false);
			this.goldRing_stuck.SetActive(false);
			this.purpleRing_stuck.SetActive(false);
			this.ancientDice_stuck.SetActive(false);
			this.cheese_stuck.SetActive(false);
			this.wolfClaw_stuck.SetActive(false);
			this.axe_stuck.SetActive(false);
			this.rune_stuck.SetActive(false);
			this.skull_stuck.SetActive(false);
			if (Artifacts.horn_spawned)
			{
				this.horn_icon.SetActive(true);
			}
			if (Artifacts.ancientDevice_spawned)
			{
				this.ancientDevice_icon.SetActive(true);
			}
			if (Artifacts.bone_spawned)
			{
				this.bone_icon.SetActive(true);
			}
			if (Artifacts.meteorieOre_spawned)
			{
				this.meteorieOre_icon.SetActive(true);
			}
			if (Artifacts.book_spawned)
			{
				this.book_icon.SetActive(true);
			}
			if (Artifacts.goldStack_spawned)
			{
				this.goldStack_icon.SetActive(true);
			}
			if (Artifacts.goldRing_spawned)
			{
				this.goldRing_icon.SetActive(true);
			}
			if (Artifacts.purpleRing_spawned)
			{
				this.purpleRing_icon.SetActive(true);
			}
			if (Artifacts.ancientDice_spawned)
			{
				this.ancientDice_icon.SetActive(true);
			}
			if (Artifacts.cheese_spawned)
			{
				this.cheese_icon.SetActive(true);
			}
			if (Artifacts.wolfClaw_spawned)
			{
				this.wolfClaw_icon.SetActive(true);
			}
			if (Artifacts.axe_spawned)
			{
				this.axe_icon.SetActive(true);
			}
			if (Artifacts.rune_spawned)
			{
				this.rune_icon.SetActive(true);
			}
			if (Artifacts.skull_spawned)
			{
				this.skull_icon.SetActive(true);
			}
			base.StartCoroutine(this.MoveArtifact());
		}
	}

	// Token: 0x06000003 RID: 3 RVA: 0x000022F4 File Offset: 0x000004F4
	private IEnumerator MoveArtifact()
	{
		yield return new WaitForSeconds(0.5f);
		float moveStartTime = Time.time;
		float moveDuration = 0.5f;
		if (SetRockScreen.timeLeft < 3f)
		{
			moveDuration = 0.2f;
		}
		Vector3 startPos = base.transform.position;
		Vector3 endPos = this.moveToHere.transform.position;
		while (Time.time < moveStartTime + moveDuration)
		{
			float t = (Time.time - moveStartTime) / moveDuration;
			base.transform.position = Vector3.Lerp(startPos, endPos, t);
			yield return null;
		}
		base.transform.position = endPos;
		yield return base.StartCoroutine(this.ScaleArtifact(base.transform));
		yield break;
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002303 File Offset: 0x00000503
	private IEnumerator ScaleArtifact(Transform target)
	{
		Vector3 originalScale = target.localScale;
		Vector3 scaleUp = Vector3.one * 0.7f;
		Vector3 scaleDown = Vector3.one * 0.6f;
		float t = 0f;
		while (t < 0.2f)
		{
			target.localScale = Vector3.Lerp(originalScale, scaleUp, t / 0.2f);
			t += Time.deltaTime;
			yield return null;
		}
		target.localScale = scaleUp;
		t = 0f;
		while (t < 0.1f)
		{
			target.localScale = Vector3.Lerp(scaleUp, scaleDown, t / 0.1f);
			t += Time.deltaTime;
			yield return null;
		}
		target.localScale = scaleDown;
		yield break;
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002312 File Offset: 0x00000512
	private void OnDisable()
	{
		base.StopAllCoroutines();
	}

	// Token: 0x04000001 RID: 1
	private bool startMoving;

	// Token: 0x04000002 RID: 2
	public Transform moveToHere;

	// Token: 0x04000003 RID: 3
	public GameObject horn_icon;

	// Token: 0x04000004 RID: 4
	public GameObject ancientDevice_icon;

	// Token: 0x04000005 RID: 5
	public GameObject bone_icon;

	// Token: 0x04000006 RID: 6
	public GameObject meteorieOre_icon;

	// Token: 0x04000007 RID: 7
	public GameObject book_icon;

	// Token: 0x04000008 RID: 8
	public GameObject goldStack_icon;

	// Token: 0x04000009 RID: 9
	public GameObject goldRing_icon;

	// Token: 0x0400000A RID: 10
	public GameObject purpleRing_icon;

	// Token: 0x0400000B RID: 11
	public GameObject ancientDice_icon;

	// Token: 0x0400000C RID: 12
	public GameObject cheese_icon;

	// Token: 0x0400000D RID: 13
	public GameObject wolfClaw_icon;

	// Token: 0x0400000E RID: 14
	public GameObject axe_icon;

	// Token: 0x0400000F RID: 15
	public GameObject rune_icon;

	// Token: 0x04000010 RID: 16
	public GameObject skull_icon;

	// Token: 0x04000011 RID: 17
	public GameObject horn_stuck;

	// Token: 0x04000012 RID: 18
	public GameObject ancientDevice_stuck;

	// Token: 0x04000013 RID: 19
	public GameObject bone_stuck;

	// Token: 0x04000014 RID: 20
	public GameObject meteorieOre_stuck;

	// Token: 0x04000015 RID: 21
	public GameObject book_stuck;

	// Token: 0x04000016 RID: 22
	public GameObject goldStack_stuck;

	// Token: 0x04000017 RID: 23
	public GameObject goldRing_stuck;

	// Token: 0x04000018 RID: 24
	public GameObject purpleRing_stuck;

	// Token: 0x04000019 RID: 25
	public GameObject ancientDice_stuck;

	// Token: 0x0400001A RID: 26
	public GameObject cheese_stuck;

	// Token: 0x0400001B RID: 27
	public GameObject wolfClaw_stuck;

	// Token: 0x0400001C RID: 28
	public GameObject axe_stuck;

	// Token: 0x0400001D RID: 29
	public GameObject rune_stuck;

	// Token: 0x0400001E RID: 30
	public GameObject skull_stuck;
}
