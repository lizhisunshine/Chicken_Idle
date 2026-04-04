using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro.Examples
{
	// Token: 0x02000046 RID: 70
	public class Benchmark01_UGUI : MonoBehaviour
	{
		// Token: 0x06000233 RID: 563 RVA: 0x00053A89 File Offset: 0x00051C89
		private IEnumerator Start()
		{
			if (this.BenchmarkType == 0)
			{
				this.m_textMeshPro = base.gameObject.AddComponent<TextMeshProUGUI>();
				if (this.TMProFont != null)
				{
					this.m_textMeshPro.font = this.TMProFont;
				}
				this.m_textMeshPro.fontSize = 48f;
				this.m_textMeshPro.alignment = TextAlignmentOptions.Center;
				this.m_textMeshPro.extraPadding = true;
				this.m_material01 = this.m_textMeshPro.font.material;
				this.m_material02 = Resources.Load<Material>("Fonts & Materials/LiberationSans SDF - BEVEL");
			}
			else if (this.BenchmarkType == 1)
			{
				this.m_textMesh = base.gameObject.AddComponent<Text>();
				if (this.TextMeshFont != null)
				{
					this.m_textMesh.font = this.TextMeshFont;
				}
				this.m_textMesh.fontSize = 48;
				this.m_textMesh.alignment = TextAnchor.MiddleCenter;
			}
			int num;
			for (int i = 0; i <= 1000000; i = num + 1)
			{
				if (this.BenchmarkType == 0)
				{
					this.m_textMeshPro.text = "The <#0050FF>count is: </color>" + (i % 1000).ToString();
					if (i % 1000 == 999)
					{
						this.m_textMeshPro.fontSharedMaterial = ((this.m_textMeshPro.fontSharedMaterial == this.m_material01) ? (this.m_textMeshPro.fontSharedMaterial = this.m_material02) : (this.m_textMeshPro.fontSharedMaterial = this.m_material01));
					}
				}
				else if (this.BenchmarkType == 1)
				{
					this.m_textMesh.text = "The <color=#0050FF>count is: </color>" + (i % 1000).ToString();
				}
				yield return null;
				num = i;
			}
			yield return null;
			yield break;
		}

		// Token: 0x04000E7D RID: 3709
		public int BenchmarkType;

		// Token: 0x04000E7E RID: 3710
		public Canvas canvas;

		// Token: 0x04000E7F RID: 3711
		public TMP_FontAsset TMProFont;

		// Token: 0x04000E80 RID: 3712
		public Font TextMeshFont;

		// Token: 0x04000E81 RID: 3713
		private TextMeshProUGUI m_textMeshPro;

		// Token: 0x04000E82 RID: 3714
		private Text m_textMesh;

		// Token: 0x04000E83 RID: 3715
		private const string label01 = "The <#0050FF>count is: </color>";

		// Token: 0x04000E84 RID: 3716
		private const string label02 = "The <color=#0050FF>count is: </color>";

		// Token: 0x04000E85 RID: 3717
		private Material m_material01;

		// Token: 0x04000E86 RID: 3718
		private Material m_material02;
	}
}
