using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000011 RID: 17
public class HoverOverIncreaseSize : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	// Token: 0x0600004D RID: 77 RVA: 0x000052EF File Offset: 0x000034EF
	private void Awake()
	{
		this.scaleMultiplier = 1.08f;
		this.scaleDuration = 0.1f;
		this.coolBtn1Time = false;
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00005310 File Offset: 0x00003510
	private void OnEnable()
	{
		if (base.gameObject.name == "coolBtn")
		{
			base.gameObject.transform.localScale = new Vector2(1f, 1f);
			if (!this.coolBtn1Time)
			{
				this.originalScale = base.transform.localScale;
				this.coolBtn1Time = true;
				return;
			}
		}
		else
		{
			this.originalScale = base.transform.localScale;
		}
	}

	// Token: 0x0600004F RID: 79 RVA: 0x0000538A File Offset: 0x0000358A
	public void OnPointerEnter(PointerEventData eventData)
	{
		HoverOverIncreaseSize.xPos = base.gameObject.transform.localPosition.x;
		if (MobileAndTesting.isMobile)
		{
			return;
		}
		this.StartScale(this.originalScale * this.scaleMultiplier);
	}

	// Token: 0x06000050 RID: 80 RVA: 0x000053C5 File Offset: 0x000035C5
	public void OnPointerExit(PointerEventData eventData)
	{
		if (MobileAndTesting.isMobile)
		{
			return;
		}
		this.StartScale(this.originalScale);
	}

	// Token: 0x06000051 RID: 81 RVA: 0x000053DB File Offset: 0x000035DB
	private void StartScale(Vector3 targetScale)
	{
		if (this.scaleCoroutine != null)
		{
			base.StopCoroutine(this.scaleCoroutine);
		}
		this.scaleCoroutine = base.StartCoroutine(this.ScaleToSize(targetScale));
	}

	// Token: 0x06000052 RID: 82 RVA: 0x00005404 File Offset: 0x00003604
	private IEnumerator ScaleToSize(Vector3 targetScale)
	{
		Vector3 startScale = base.transform.localScale;
		float elapsed = 0f;
		while (elapsed < this.scaleDuration)
		{
			elapsed += Time.unscaledDeltaTime;
			base.transform.localScale = Vector3.Lerp(startScale, targetScale, elapsed / this.scaleDuration);
			yield return null;
		}
		base.transform.localScale = targetScale;
		yield break;
	}

	// Token: 0x0400016F RID: 367
	private Vector3 originalScale;

	// Token: 0x04000170 RID: 368
	public float scaleMultiplier = 1.2f;

	// Token: 0x04000171 RID: 369
	public float scaleDuration = 0.2f;

	// Token: 0x04000172 RID: 370
	private Coroutine scaleCoroutine;

	// Token: 0x04000173 RID: 371
	public static float xPos;

	// Token: 0x04000174 RID: 372
	private bool coolBtn1Time;
}
