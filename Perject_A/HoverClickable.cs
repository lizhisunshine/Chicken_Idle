using System;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000010 RID: 16
public class HoverClickable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	// Token: 0x0600004A RID: 74 RVA: 0x00005208 File Offset: 0x00003408
	public void OnPointerEnter(PointerEventData eventData)
	{
		if (MobileAndTesting.isMobile)
		{
			return;
		}
		Cursor.visible = true;
		if (!MobileAndTesting.isMobile && this.isEndSessionBtn)
		{
			this.goldHand.SetActive(false);
			this.normalHand.SetActive(false);
		}
		Cursor.SetCursor(this.hoverCursor, Vector2.zero, CursorMode.Auto);
	}

	// Token: 0x0600004B RID: 75 RVA: 0x0000525C File Offset: 0x0000345C
	public void OnPointerExit(PointerEventData eventData)
	{
		if (MobileAndTesting.isMobile)
		{
			return;
		}
		Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
		if (SetRockScreen.isInMiningSession)
		{
			Cursor.visible = false;
		}
		else
		{
			Cursor.visible = true;
		}
		if (this.isEndSessionBtn && !MobileAndTesting.isMobile)
		{
			if (SetRockScreen.isGoldenHand)
			{
				this.goldHand.SetActive(true);
				this.normalHand.SetActive(false);
			}
			else
			{
				this.goldHand.SetActive(false);
				this.normalHand.SetActive(true);
			}
		}
		if (SetRockScreen.isInEnding)
		{
			Cursor.visible = true;
		}
	}

	// Token: 0x0400016B RID: 363
	public Texture2D hoverCursor;

	// Token: 0x0400016C RID: 364
	public bool isEndSessionBtn;

	// Token: 0x0400016D RID: 365
	public GameObject goldHand;

	// Token: 0x0400016E RID: 366
	public GameObject normalHand;
}
