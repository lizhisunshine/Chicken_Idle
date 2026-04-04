using System;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x0200000C RID: 12
public class ButtonPressAnimation : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
	// Token: 0x06000038 RID: 56 RVA: 0x00004C90 File Offset: 0x00002E90
	private void OnEnable()
	{
		this.originalScale = base.transform.localScale;
		this.pressedScale = this.originalScale * 0.8f;
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00004CB9 File Offset: 0x00002EB9
	public void OnPointerDown(PointerEventData eventData)
	{
		base.transform.localScale = this.pressedScale;
	}

	// Token: 0x0600003A RID: 58 RVA: 0x00004CCC File Offset: 0x00002ECC
	public void OnPointerUp(PointerEventData eventData)
	{
		base.transform.localScale = this.originalScale;
	}

	// Token: 0x0400015A RID: 346
	private Vector3 originalScale;

	// Token: 0x0400015B RID: 347
	private Vector3 pressedScale;
}
