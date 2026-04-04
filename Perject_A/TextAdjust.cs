using System;
using TMPro;
using UnityEngine;

// Token: 0x0200001A RID: 26
public class TextAdjust : MonoBehaviour
{
	// Token: 0x0600008E RID: 142 RVA: 0x000090C7 File Offset: 0x000072C7
	public void Awake()
	{
		this.textMeshPro = base.GetComponent<TextMeshProUGUI>();
	}

	// Token: 0x0600008F RID: 143 RVA: 0x000090D8 File Offset: 0x000072D8
	private void OnEnable()
	{
		float x = this.textMeshPro.GetPreferredValues().x;
		this.textMeshPro.rectTransform.sizeDelta = new Vector2(x, this.textMeshPro.rectTransform.sizeDelta.y);
	}

	// Token: 0x06000090 RID: 144 RVA: 0x00009124 File Offset: 0x00007324
	private void Update()
	{
		float x = this.textMeshPro.GetPreferredValues().x;
		this.textMeshPro.rectTransform.sizeDelta = new Vector2(x, this.textMeshPro.rectTransform.sizeDelta.y);
	}

	// Token: 0x04000289 RID: 649
	private TextMeshProUGUI textMeshPro;
}
