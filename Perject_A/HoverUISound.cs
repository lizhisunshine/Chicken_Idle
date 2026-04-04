using System;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000012 RID: 18
public class HoverUISound : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler
{
	// Token: 0x06000054 RID: 84 RVA: 0x00005438 File Offset: 0x00003638
	private void Awake()
	{
		GameObject gameObject = GameObject.Find("AudioManager");
		this.audioManager = gameObject.GetComponent<AudioManager>();
		if (base.gameObject.tag == "Card")
		{
			this.isCard = true;
		}
	}

	// Token: 0x06000055 RID: 85 RVA: 0x0000547A File Offset: 0x0000367A
	public void OnPointerEnter(PointerEventData eventData)
	{
		if (MobileAndTesting.isMobile)
		{
			return;
		}
		if (this.isCard)
		{
			this.audioManager.Play("CardHover");
			return;
		}
		this.audioManager.Play("HoverUI");
	}

	// Token: 0x04000175 RID: 373
	public AudioManager audioManager;

	// Token: 0x04000176 RID: 374
	private bool isCard;
}
