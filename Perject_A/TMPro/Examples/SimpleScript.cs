using System;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x0200004D RID: 77
	public class SimpleScript : MonoBehaviour
	{
		// Token: 0x06000248 RID: 584 RVA: 0x00054B14 File Offset: 0x00052D14
		private void Start()
		{
			this.m_textMeshPro = base.gameObject.AddComponent<TextMeshPro>();
			this.m_textMeshPro.autoSizeTextContainer = true;
			this.m_textMeshPro.fontSize = 48f;
			this.m_textMeshPro.alignment = TextAlignmentOptions.Center;
			this.m_textMeshPro.textWrappingMode = TextWrappingModes.NoWrap;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00054B6A File Offset: 0x00052D6A
		private void Update()
		{
			this.m_textMeshPro.SetText("The <#0050FF>count is: </color>{0:2}", this.m_frame % 1000f);
			this.m_frame += 1f * Time.deltaTime;
		}

		// Token: 0x04000EBB RID: 3771
		private TextMeshPro m_textMeshPro;

		// Token: 0x04000EBC RID: 3772
		private const string label = "The <#0050FF>count is: </color>{0:2}";

		// Token: 0x04000EBD RID: 3773
		private float m_frame;
	}
}
