using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000003 RID: 3
public class CheckNonTileErea : MonoBehaviour
{
	// Token: 0x06000007 RID: 7 RVA: 0x00002322 File Offset: 0x00000522
	public void OnTriggerEnter2D(Collider2D collision)
	{
		collision.gameObject.tag == "Rock";
	}

	// Token: 0x06000008 RID: 8 RVA: 0x0000233A File Offset: 0x0000053A
	private IEnumerator SetCollider()
	{
		this.collider2d.enabled = false;
		yield return new WaitForSeconds(0.1f);
		this.collider2d.enabled = true;
		yield break;
	}

	// Token: 0x0400001F RID: 31
	public Collider2D collider2d;
}
