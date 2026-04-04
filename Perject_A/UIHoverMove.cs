using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000021 RID: 33
public class UIHoverMove : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	// Token: 0x060000C9 RID: 201 RVA: 0x00012A16 File Offset: 0x00010C16
	private void Awake()
	{
		this.moveAmount = 8f;
		this.moveDuration = 0.1f;
	}

	// Token: 0x060000CA RID: 202 RVA: 0x00012A2E File Offset: 0x00010C2E
	private void OnEnable()
	{
		this.originalPosition = base.transform.localPosition;
	}

	// Token: 0x060000CB RID: 203 RVA: 0x00012A44 File Offset: 0x00010C44
	public void OnPointerEnter(PointerEventData eventData)
	{
		if (MobileAndTesting.isMobile)
		{
			return;
		}
		if (this.isMenuButtons)
		{
			if (!this.isKeepOnMiningBtn)
			{
				this.originalPosition = base.transform.localPosition;
				this.originalPosition.y = 0f;
			}
			UIHoverMove.isHoveringBtn = true;
		}
		if (this.isSkillTreeBtn)
		{
			UIHoverMove.isHoveringSkillTreeBtn = true;
		}
		if (this.doTheAnim)
		{
			this.StartMove(this.originalPosition + Vector3.up * this.moveAmount);
		}
	}

	// Token: 0x060000CC RID: 204 RVA: 0x00012AC7 File Offset: 0x00010CC7
	public void OnPointerExit(PointerEventData eventData)
	{
		if (MobileAndTesting.isMobile)
		{
			return;
		}
		UIHoverMove.isHoveringBtn = false;
		if (this.isSkillTreeBtn)
		{
			UIHoverMove.isHoveringSkillTreeBtn = false;
		}
		if (this.doTheAnim)
		{
			this.StartMove(this.originalPosition);
		}
	}

	// Token: 0x060000CD RID: 205 RVA: 0x00012AF9 File Offset: 0x00010CF9
	private void StartMove(Vector3 targetPosition)
	{
		if (this.moveCoroutine != null)
		{
			base.StopCoroutine(this.moveCoroutine);
		}
		this.moveCoroutine = base.StartCoroutine(this.MoveToPosition(targetPosition));
	}

	// Token: 0x060000CE RID: 206 RVA: 0x00012B22 File Offset: 0x00010D22
	private IEnumerator MoveToPosition(Vector3 targetPosition)
	{
		Vector3 startPos = base.transform.localPosition;
		float elapsed = 0f;
		while (elapsed < this.moveDuration)
		{
			elapsed += Time.unscaledDeltaTime;
			base.transform.localPosition = Vector3.Lerp(startPos, targetPosition, elapsed / this.moveDuration);
			yield return null;
		}
		base.transform.localPosition = targetPosition;
		yield break;
	}

	// Token: 0x04000430 RID: 1072
	private Vector3 originalPosition;

	// Token: 0x04000431 RID: 1073
	public float moveAmount = 10f;

	// Token: 0x04000432 RID: 1074
	public float moveDuration = 0.2f;

	// Token: 0x04000433 RID: 1075
	private Coroutine moveCoroutine;

	// Token: 0x04000434 RID: 1076
	public static bool isHoveringBtn;

	// Token: 0x04000435 RID: 1077
	public static bool isHoveringSkillTreeBtn;

	// Token: 0x04000436 RID: 1078
	public bool doTheAnim;

	// Token: 0x04000437 RID: 1079
	public bool isSkillTreeBtn;

	// Token: 0x04000438 RID: 1080
	public bool isMenuButtons;

	// Token: 0x04000439 RID: 1081
	public bool isKeepOnMiningBtn;
}
