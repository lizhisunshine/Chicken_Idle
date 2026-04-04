using System;
using System.Collections;
using UnityEngine;

// Token: 0x0200000D RID: 13
public class CampfireMechanics : MonoBehaviour
{
	// Token: 0x0600003C RID: 60 RVA: 0x00004CE7 File Offset: 0x00002EE7
	private void OnEnable()
	{
		this.fire.Play();
		base.StartCoroutine(this.BurnCollider());
	}

	// Token: 0x0600003D RID: 61 RVA: 0x00004D01 File Offset: 0x00002F01
	private IEnumerator BurnCollider()
	{
		for (;;)
		{
			this.collider2d.enabled = false;
			yield return new WaitForSeconds(0.28f);
			this.collider2d.enabled = true;
			yield return new WaitForSeconds(0.06f);
			this.collider2d.enabled = false;
		}
		yield break;
	}

	// Token: 0x0600003E RID: 62 RVA: 0x00004D10 File Offset: 0x00002F10
	private void OnDisable()
	{
		base.StopAllCoroutines();
	}

	// Token: 0x0400015C RID: 348
	public Collider2D collider2d;

	// Token: 0x0400015D RID: 349
	public ParticleSystem fire;
}
