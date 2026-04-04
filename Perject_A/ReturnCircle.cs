using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000016 RID: 22
public class ReturnCircle : MonoBehaviour
{
	// Token: 0x0600006D RID: 109 RVA: 0x000069C0 File Offset: 0x00004BC0
	private void OnEnable()
	{
		base.StartCoroutine(this.Wait());
	}

	// Token: 0x0600006E RID: 110 RVA: 0x000069CF File Offset: 0x00004BCF
	private IEnumerator Wait()
	{
		yield return new WaitForSeconds(5f);
		ObjectPool.instance.ReturnCircleColliderFromPool(base.gameObject);
		yield break;
	}

	// Token: 0x0600006F RID: 111 RVA: 0x000069DE File Offset: 0x00004BDE
	private void OnDisable()
	{
		base.StopAllCoroutines();
	}
}
