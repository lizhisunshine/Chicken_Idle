using System;
using System.Collections;
using UnityEngine;

// Token: 0x0200002A RID: 42
public class HandMechanics : MonoBehaviour
{
	// Token: 0x06000109 RID: 265 RVA: 0x0001484C File Offset: 0x00012A4C
	private void OnEnable()
	{
		base.StartCoroutine(this.Mine());
	}

	// Token: 0x0600010A RID: 266 RVA: 0x0001485B File Offset: 0x00012A5B
	private IEnumerator Mine()
	{
		for (;;)
		{
			if (LevelMechanics.isEnergiDrinkActive)
			{
				yield return new WaitForSeconds(TheAnvil.currentMineTime / 2f);
			}
			else
			{
				yield return new WaitForSeconds(TheAnvil.currentMineTime);
			}
			this.mineCollider.enabled = true;
			if (LevelMechanics.shapeShifter_chosen)
			{
				this.squareCollider.enabled = true;
				this.hexagonCollider.enabled = true;
			}
			yield return new WaitForSeconds(TheAnvil.collTime);
			this.mineCollider.enabled = false;
			if (LevelMechanics.shapeShifter_chosen)
			{
				this.squareCollider.enabled = false;
				this.hexagonCollider.enabled = false;
			}
			yield return null;
		}
		yield break;
	}

	// Token: 0x0600010B RID: 267 RVA: 0x0001486A File Offset: 0x00012A6A
	private void OnDisable()
	{
		this.mineCollider.enabled = false;
		this.squareCollider.enabled = false;
		this.hexagonCollider.enabled = false;
		base.StopAllCoroutines();
	}

	// Token: 0x0400048B RID: 1163
	public Collider2D mineCollider;

	// Token: 0x0400048C RID: 1164
	public Collider2D squareCollider;

	// Token: 0x0400048D RID: 1165
	public Collider2D hexagonCollider;
}
