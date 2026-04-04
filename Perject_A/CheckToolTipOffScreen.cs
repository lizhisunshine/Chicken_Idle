using System;
using System.Collections;
using TMPro;
using UnityEngine;

// Token: 0x0200000E RID: 14
public class CheckToolTipOffScreen : MonoBehaviour
{
	// Token: 0x06000040 RID: 64 RVA: 0x00004D20 File Offset: 0x00002F20
	private void Awake()
	{
		this.parentRectTransform = base.gameObject.GetComponent<RectTransform>();
		this.rectTransform = base.GetComponent<RectTransform>();
		this.tooltipAnimFrame = base.transform.Find("tooltipAnim_");
		this.tooltipAnimFrameAnim = this.tooltipAnimFrame.GetComponent<Animation>();
		this.tooltipRectTransform = this.tooltipAnimFrame.GetComponent<RectTransform>();
		Transform transform = base.transform.Find("tooltipAnim_/UpgradeDesc_text");
		this.upgradeDescText = transform.GetComponent<TextMeshProUGUI>();
	}

	// Token: 0x06000041 RID: 65 RVA: 0x00004D9F File Offset: 0x00002F9F
	private void OnEnable()
	{
		this.checkCorners = false;
		base.StartCoroutine(this.PlayToolTipAnimSkillTree());
		this.tooltipAnimFrame.gameObject.SetActive(false);
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00004DC6 File Offset: 0x00002FC6
	private IEnumerator PlayToolTipAnimSkillTree()
	{
		yield return new WaitForSeconds(0.025f);
		this.checkCorners = true;
		yield return new WaitForSeconds(0.025f);
		this.tooltipAnimFrame.gameObject.SetActive(true);
		yield break;
	}

	// Token: 0x06000043 RID: 67 RVA: 0x00004DD8 File Offset: 0x00002FD8
	private void Update()
	{
		this.skillTreeWidth = this.tooltipRectTransform.sizeDelta.x;
		float x = this.upgradeDescText.GetPreferredValues().x;
		this.upgradeDescText.rectTransform.sizeDelta = new Vector2(x, 67f);
		this.parentRectTransform.sizeDelta = new Vector2(x + 100f, 220f);
		this.tooltipRectTransform.sizeDelta = new Vector2(x - 320f, 67f);
		if (this.checkCorners && !MobileAndTesting.isMobile)
		{
			this.CheckOffScreenEdges();
		}
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00004E74 File Offset: 0x00003074
	private void CheckOffScreenEdges()
	{
		Vector3[] array = new Vector3[4];
		this.rectTransform.GetWorldCorners(array);
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		foreach (Vector3 position in array)
		{
			Vector3 vector = this.uiCamera.WorldToViewportPoint(position);
			if (vector.x < 0f)
			{
				flag2 = true;
			}
			if (vector.x > 1f)
			{
				flag3 = true;
			}
			if (vector.y > 1f)
			{
				flag = true;
			}
		}
		float num = 0f;
		if (this.skillTreeWidth < 0f)
		{
			num = 3f;
		}
		else if (this.skillTreeWidth > 450f)
		{
			num = 5.7f;
		}
		else if (this.skillTreeWidth > 250f)
		{
			num = 4.5f;
		}
		else if (this.skillTreeWidth > 150f)
		{
			num = 4f;
		}
		else if (this.skillTreeWidth > 0f)
		{
			num = 3.4f;
		}
		if (Tooltip.isFinalUpgradeHover && this.skillTreeWidth > 0f)
		{
			num *= 1.3f;
		}
		if (flag && flag3)
		{
			base.gameObject.transform.position = new Vector2(Tooltip.skillTreeToolTipPos.x - num, Tooltip.skillTreeToolTipPos.y - 1.65f);
			return;
		}
		if (flag && flag2)
		{
			base.gameObject.transform.position = new Vector2(Tooltip.skillTreeToolTipPos.x + num, Tooltip.skillTreeToolTipPos.y - 1.65f);
			return;
		}
		if (flag)
		{
			if (Tooltip.isFinalUpgradeHover)
			{
				base.gameObject.transform.position = new Vector2(Tooltip.skillTreeToolTipPos.x, Tooltip.skillTreeToolTipPos.y - 2.1f);
				return;
			}
			base.gameObject.transform.position = new Vector2(Tooltip.skillTreeToolTipPos.x, Tooltip.skillTreeToolTipPos.y - 1.65f);
			return;
		}
		else
		{
			if (flag2)
			{
				base.gameObject.transform.position = new Vector2(Tooltip.skillTreeToolTipPos.x + num, Tooltip.skillTreeToolTipPos.y);
				return;
			}
			if (flag3)
			{
				base.gameObject.transform.position = new Vector2(Tooltip.skillTreeToolTipPos.x - num, Tooltip.skillTreeToolTipPos.y);
			}
			return;
		}
	}

	// Token: 0x06000045 RID: 69 RVA: 0x000050DC File Offset: 0x000032DC
	private void OnDisable()
	{
		base.StopAllCoroutines();
	}

	// Token: 0x0400015E RID: 350
	[SerializeField]
	private Camera uiCamera;

	// Token: 0x0400015F RID: 351
	private RectTransform rectTransform;

	// Token: 0x04000160 RID: 352
	private RectTransform parentRectTransform;

	// Token: 0x04000161 RID: 353
	public Transform tooltipAnimFrame;

	// Token: 0x04000162 RID: 354
	public Animation tooltipAnimFrameAnim;

	// Token: 0x04000163 RID: 355
	public RectTransform tooltipRectTransform;

	// Token: 0x04000164 RID: 356
	public TextMeshProUGUI upgradeDescText;

	// Token: 0x04000165 RID: 357
	private bool checkCorners;

	// Token: 0x04000166 RID: 358
	private float skillTreeWidth;
}
