using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000038 RID: 56
public class SkillTreeDrag : MonoBehaviour
{
	// Token: 0x060001D3 RID: 467 RVA: 0x0005214E File Offset: 0x0005034E
	private void Awake()
	{
		this.dragThreshold = 100f;
		this.rectTransform = base.GetComponent<RectTransform>();
		base.StartCoroutine(this.Wait());
	}

	// Token: 0x060001D4 RID: 468 RVA: 0x00052174 File Offset: 0x00050374
	private IEnumerator Wait()
	{
		yield return new WaitForSeconds(0.2f);
		if (MobileAndTesting.isMobile)
		{
			this.zoomSliderMobile.gameObject.SetActive(true);
		}
		else
		{
			this.zoomSliderMobile.gameObject.SetActive(false);
		}
		yield break;
	}

	// Token: 0x060001D5 RID: 469 RVA: 0x00052183 File Offset: 0x00050383
	private void OnEnable()
	{
	}

	// Token: 0x060001D6 RID: 470 RVA: 0x00052188 File Offset: 0x00050388
	private void Update()
	{
		if (MainMenu.isInUpgrades && !SkillTree.isInEndlessPopUp)
		{
			SkillTreeDrag.scaleX = base.gameObject.transform.localScale.x;
			if (!UIHoverMove.isHoveringBtn)
			{
				if (Input.GetMouseButtonDown(0))
				{
					this.mouseDownPosition = Input.mousePosition;
					this.isDragging = false;
				}
				if (Input.GetMouseButton(0))
				{
					if (!this.isDragging && Vector3.Distance(Input.mousePosition, this.mouseDownPosition) > this.dragThreshold)
					{
						this.isDragging = true;
					}
					if (this.isDragging && !MobileAndTesting.isMobile)
					{
						this.skillTreeTooltip.SetActive(false);
					}
				}
				if (Input.GetMouseButtonUp(0))
				{
					this.isDragging = false;
				}
				if (!MobileAndTesting.isMobile)
				{
					float y = Input.mouseScrollDelta.y;
					if (Mathf.Abs(y) > 0.01f)
					{
						float d = 1f + y * 0.1f;
						SkillTreeDrag.targetScale *= d;
						float x = Mathf.Clamp(SkillTreeDrag.targetScale.x, this.minZoom, this.maxZoom);
						float y2 = Mathf.Clamp(SkillTreeDrag.targetScale.y, this.minZoom, this.maxZoom);
						SkillTreeDrag.targetScale = new Vector3(x, y2, 1f);
					}
					base.transform.localScale = Vector3.Lerp(base.transform.localScale, SkillTreeDrag.targetScale, Time.deltaTime * this.zoomSpeed);
					return;
				}
				base.transform.localScale = new Vector3(this.zoomSliderMobile.value, this.zoomSliderMobile.value, this.zoomSliderMobile.value);
			}
		}
	}

	// Token: 0x04000DE9 RID: 3561
	[SerializeField]
	private float zoomSpeed = 5f;

	// Token: 0x04000DEA RID: 3562
	[SerializeField]
	private float minZoom = 0.5f;

	// Token: 0x04000DEB RID: 3563
	[SerializeField]
	private float maxZoom = 1.5f;

	// Token: 0x04000DEC RID: 3564
	[SerializeField]
	public static float defaultZoom = 0.9f;

	// Token: 0x04000DED RID: 3565
	public static Vector3 targetScale;

	// Token: 0x04000DEE RID: 3566
	private bool isDragging;

	// Token: 0x04000DEF RID: 3567
	private Vector3 lastMousePosition;

	// Token: 0x04000DF0 RID: 3568
	private RectTransform rectTransform;

	// Token: 0x04000DF1 RID: 3569
	public GameObject skillTreeTooltip;

	// Token: 0x04000DF2 RID: 3570
	public GameObject contentFrame;

	// Token: 0x04000DF3 RID: 3571
	public static float scaleX;

	// Token: 0x04000DF4 RID: 3572
	public Slider zoomSliderMobile;

	// Token: 0x04000DF5 RID: 3573
	public float divideDiff;

	// Token: 0x04000DF6 RID: 3574
	public float currentXscale;

	// Token: 0x04000DF7 RID: 3575
	public Transform skillTreeMoveTo;

	// Token: 0x04000DF8 RID: 3576
	private Vector3 mouseDownPosition;

	// Token: 0x04000DF9 RID: 3577
	private float dragThreshold = 10f;
}
