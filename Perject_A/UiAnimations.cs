using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000020 RID: 32
public class UiAnimations : MonoBehaviour
{
	// Token: 0x060000C4 RID: 196 RVA: 0x00012994 File Offset: 0x00010B94
	private void Awake()
	{
		this.moveDistance = 0.5f;
		this.moveDuration = 1f;
	}

	// Token: 0x060000C5 RID: 197 RVA: 0x000129AC File Offset: 0x00010BAC
	private void OnEnable()
	{
		this.startPosition = base.transform.position;
		base.StartCoroutine(this.FloatLoop());
	}

	// Token: 0x060000C6 RID: 198 RVA: 0x000129CC File Offset: 0x00010BCC
	private IEnumerator FloatLoop()
	{
		for (;;)
		{
			yield return this.MoveToPosition(this.startPosition - Vector3.up * this.moveDistance, this.moveDuration);
			yield return this.MoveToPosition(this.startPosition + Vector3.up * this.moveDistance, this.moveDuration);
			yield return this.MoveToPosition(this.startPosition, this.moveDuration);
		}
		yield break;
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x000129DB File Offset: 0x00010BDB
	private IEnumerator MoveToPosition(Vector3 target, float duration)
	{
		Vector3 initialPosition = base.transform.position;
		float time = 0f;
		while (time < duration)
		{
			base.transform.position = Vector3.Lerp(initialPosition, target, time / duration);
			time += Time.deltaTime;
			yield return null;
		}
		base.transform.position = target;
		yield break;
	}

	// Token: 0x0400042D RID: 1069
	public float moveDistance = 0.5f;

	// Token: 0x0400042E RID: 1070
	public float moveDuration = 1f;

	// Token: 0x0400042F RID: 1071
	private Vector3 startPosition;
}
