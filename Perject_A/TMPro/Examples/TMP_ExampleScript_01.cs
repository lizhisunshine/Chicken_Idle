using System;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x02000054 RID: 84
	public class TMP_ExampleScript_01 : MonoBehaviour
	{
		// Token: 0x06000267 RID: 615 RVA: 0x000554C8 File Offset: 0x000536C8
		private void Awake()
		{
			if (this.ObjectType == TMP_ExampleScript_01.objectType.TextMeshPro)
			{
				this.m_text = (base.GetComponent<TextMeshPro>() ?? base.gameObject.AddComponent<TextMeshPro>());
			}
			else
			{
				this.m_text = (base.GetComponent<TextMeshProUGUI>() ?? base.gameObject.AddComponent<TextMeshProUGUI>());
			}
			this.m_text.font = Resources.Load<TMP_FontAsset>("Fonts & Materials/Anton SDF");
			this.m_text.fontSharedMaterial = Resources.Load<Material>("Fonts & Materials/Anton SDF - Drop Shadow");
			this.m_text.fontSize = 120f;
			this.m_text.text = "A <#0080ff>simple</color> line of text.";
			Vector2 preferredValues = this.m_text.GetPreferredValues(float.PositiveInfinity, float.PositiveInfinity);
			this.m_text.rectTransform.sizeDelta = new Vector2(preferredValues.x, preferredValues.y);
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00055596 File Offset: 0x00053796
		private void Update()
		{
			if (!this.isStatic)
			{
				this.m_text.SetText("The count is <#0080ff>{0}</color>", (float)(this.count % 1000));
				this.count++;
			}
		}

		// Token: 0x04000EDE RID: 3806
		public TMP_ExampleScript_01.objectType ObjectType;

		// Token: 0x04000EDF RID: 3807
		public bool isStatic;

		// Token: 0x04000EE0 RID: 3808
		private TMP_Text m_text;

		// Token: 0x04000EE1 RID: 3809
		private const string k_label = "The count is <#0080ff>{0}</color>";

		// Token: 0x04000EE2 RID: 3810
		private int count;

		// Token: 0x0200013F RID: 319
		public enum objectType
		{
			// Token: 0x04001300 RID: 4864
			TextMeshPro,
			// Token: 0x04001301 RID: 4865
			TextMeshProUGUI
		}
	}
}
