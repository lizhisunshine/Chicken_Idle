using System;
using TMPro;
using UnityEngine;

// Token: 0x0200000A RID: 10
public class AdjustText_2 : MonoBehaviour
{
	// Token: 0x06000032 RID: 50 RVA: 0x00004BE5 File Offset: 0x00002DE5
	private void Update()
	{
		this.AdjustWidthToText();
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00004BF0 File Offset: 0x00002DF0
	private void AdjustWidthToText()
	{
		float preferredWidth = this.textMeshPro.preferredWidth;
		this.textMeshPro.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, preferredWidth + this.padding);
	}

	// Token: 0x04000157 RID: 343
	public TextMeshProUGUI textMeshPro;

	// Token: 0x04000158 RID: 344
	public float padding = 10f;
}
