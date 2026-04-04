using System;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000004 RID: 4
public class CraftMobileButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
	// Token: 0x0600000A RID: 10 RVA: 0x00002351 File Offset: 0x00000551
	private void Awake()
	{
		this.originalScale = base.transform.localScale;
		this.pressedScale = this.originalScale * 0.85f;
	}

	// Token: 0x0600000B RID: 11 RVA: 0x0000237A File Offset: 0x0000057A
	public void OnPointerDown(PointerEventData eventData)
	{
		CraftMobileButton.isPressing = true;
		base.transform.localScale = this.pressedScale;
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002393 File Offset: 0x00000593
	public void OnPointerUp(PointerEventData eventData)
	{
		CraftMobileButton.isPressing = false;
		base.transform.localScale = this.originalScale;
	}

	// Token: 0x0600000D RID: 13 RVA: 0x000023AC File Offset: 0x000005AC
	private void Update()
	{
		if (!base.gameObject.activeInHierarchy)
		{
			CraftMobileButton.isPressing = false;
			base.transform.localScale = this.originalScale;
		}
	}

	// Token: 0x0600000E RID: 14 RVA: 0x000023D2 File Offset: 0x000005D2
	private void OnDisable()
	{
		CraftMobileButton.isPressing = false;
		base.transform.localScale = this.originalScale;
	}

	// Token: 0x04000020 RID: 32
	public static bool isPressing;

	// Token: 0x04000021 RID: 33
	private Vector3 originalScale;

	// Token: 0x04000022 RID: 34
	private Vector3 pressedScale;
}
