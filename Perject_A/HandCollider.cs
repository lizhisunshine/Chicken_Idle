using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000029 RID: 41
public class HandCollider : MonoBehaviour
{
	// Token: 0x06000105 RID: 261 RVA: 0x00014618 File Offset: 0x00012818
	public void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.layer == 9 || collision.gameObject.layer == 10)
		{
			HandCollider.rockHoverPos = collision.transform.position;
			GameObject pickaxeFromPool = ObjectPool.instance.GetPickaxeFromPool();
			AllStats.pickaxesSpawned++;
			float x;
			float y;
			if (Random.Range(1, 3) == 1)
			{
				pickaxeFromPool.layer = 6;
				x = HandCollider.rockHoverPos.x - Random.Range(0.22f, 0.35f);
				y = HandCollider.rockHoverPos.y + Random.Range(0.2f, 0.23f);
				if (SetRockScreen.isInEnding)
				{
					x = HandCollider.rockHoverPos.x - Random.Range(1f, 2.1f);
					y = HandCollider.rockHoverPos.y + Random.Range(0.2f, 1.4f);
				}
			}
			else
			{
				pickaxeFromPool.layer = 11;
				x = HandCollider.rockHoverPos.x + Random.Range(0.22f, 0.35f);
				y = HandCollider.rockHoverPos.y + Random.Range(0.2f, 0.23f);
				if (SetRockScreen.isInEnding)
				{
					x = HandCollider.rockHoverPos.x + Random.Range(1f, 2.1f);
					y = HandCollider.rockHoverPos.y + Random.Range(0.2f, 1.4f);
				}
			}
			pickaxeFromPool.transform.localScale = new Vector2(1.15f, 1.15f);
			if (SetRockScreen.isInEnding)
			{
				pickaxeFromPool.transform.localScale = new Vector2(3f, 3f);
			}
			pickaxeFromPool.transform.position = new Vector2(x, y);
		}
	}

	// Token: 0x06000106 RID: 262 RVA: 0x000147E0 File Offset: 0x000129E0
	private void OnEnable()
	{
		if (this.isMainCollider && SkillTree.shootCircleChance_purchased)
		{
			if (this.shootCoroutine == null)
			{
				this.shootCoroutine = base.StartCoroutine(this.ChanceToShootCircle());
				return;
			}
			base.StopCoroutine(this.shootCoroutine);
			this.shootCoroutine = base.StartCoroutine(this.ChanceToShootCircle());
		}
	}

	// Token: 0x06000107 RID: 263 RVA: 0x00014835 File Offset: 0x00012A35
	private IEnumerator ChanceToShootCircle()
	{
		for (;;)
		{
			yield return new WaitForSeconds(1f);
			if ((float)Random.Range(0, 100) < SkillTree.circleShootChance && !SetRockScreen.isInEnding)
			{
				GameObject colliderCircleFromPool = ObjectPool.instance.GetColliderCircleFromPool();
				colliderCircleFromPool.transform.position = base.gameObject.transform.position;
				Rigidbody2D component = colliderCircleFromPool.GetComponent<Rigidbody2D>();
				Vector2 normalized = Random.insideUnitCircle.normalized;
				float d = 4f;
				component.linearVelocity = normalized * d;
			}
		}
		yield break;
	}

	// Token: 0x04000488 RID: 1160
	public bool isMainCollider;

	// Token: 0x04000489 RID: 1161
	public static Vector2 rockHoverPos;

	// Token: 0x0400048A RID: 1162
	private Coroutine shootCoroutine;
}
