using System;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000026 RID: 38
public class ButtonAnim : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	// Token: 0x060000F0 RID: 240 RVA: 0x00013398 File Offset: 0x00011598
	private void Start()
	{
		this.anim = base.transform.GetComponent<Animation>();
	}

	// Token: 0x060000F1 RID: 241 RVA: 0x000133AB File Offset: 0x000115AB
	public void OnPointerEnter(PointerEventData eventData)
	{
		if (MobileAndTesting.isMobile)
		{
			return;
		}
		this.anim.Play();
	}

	// Token: 0x060000F2 RID: 242 RVA: 0x000133C1 File Offset: 0x000115C1
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	// Token: 0x04000464 RID: 1124
	public Animation anim;
}
