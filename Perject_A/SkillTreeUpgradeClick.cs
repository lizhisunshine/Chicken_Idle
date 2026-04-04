using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000019 RID: 25
public class SkillTreeUpgradeClick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler
{
	// Token: 0x06000088 RID: 136 RVA: 0x00008FB4 File Offset: 0x000071B4
	private void Awake()
	{
		this.btn = base.gameObject.GetComponent<Button>();
		this.clickAnim = base.gameObject.GetComponent<Animation>();
		this.originalScale = base.transform.localScale;
		this.originalRotation = base.transform.rotation;
		this.targetScale = this.originalScale * 0.85f;
		this.targetRotation = Quaternion.Euler(0f, 0f, -14f);
	}

	// Token: 0x06000089 RID: 137 RVA: 0x00009035 File Offset: 0x00007235
	public void OnPointerEnter(PointerEventData eventData)
	{
		this.isMouseOver = true;
	}

	// Token: 0x0600008A RID: 138 RVA: 0x0000903E File Offset: 0x0000723E
	public void OnPointerExit(PointerEventData eventData)
	{
		this.isMouseOver = false;
	}

	// Token: 0x0600008B RID: 139 RVA: 0x00009048 File Offset: 0x00007248
	public void OnPointerDown(PointerEventData eventData)
	{
		if (MobileAndTesting.isMobile)
		{
			return;
		}
		if (this.btn.enabled)
		{
			if (this.clickAnim.isPlaying)
			{
				base.transform.localScale = this.originalScale;
				base.transform.rotation = this.originalRotation;
				this.clickAnim.Stop();
				this.clickAnim.Play();
				return;
			}
			this.clickAnim.Play();
		}
	}

	// Token: 0x0600008C RID: 140 RVA: 0x000090BD File Offset: 0x000072BD
	public void OnPointerUp(PointerEventData eventData)
	{
	}

	// Token: 0x04000282 RID: 642
	private Vector3 originalScale;

	// Token: 0x04000283 RID: 643
	private Quaternion originalRotation;

	// Token: 0x04000284 RID: 644
	private Vector3 targetScale;

	// Token: 0x04000285 RID: 645
	private Quaternion targetRotation;

	// Token: 0x04000286 RID: 646
	private bool isMouseOver;

	// Token: 0x04000287 RID: 647
	public Animation clickAnim;

	// Token: 0x04000288 RID: 648
	public Button btn;
}
