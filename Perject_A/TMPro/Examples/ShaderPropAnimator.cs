using System;
using System.Collections;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x0200004C RID: 76
	public class ShaderPropAnimator : MonoBehaviour
	{
		// Token: 0x06000244 RID: 580 RVA: 0x00054ACE File Offset: 0x00052CCE
		private void Awake()
		{
			this.m_Renderer = base.GetComponent<Renderer>();
			this.m_Material = this.m_Renderer.material;
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00054AED File Offset: 0x00052CED
		private void Start()
		{
			base.StartCoroutine(this.AnimateProperties());
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00054AFC File Offset: 0x00052CFC
		private IEnumerator AnimateProperties()
		{
			this.m_frame = Random.Range(0f, 1f);
			for (;;)
			{
				float value = this.GlowCurve.Evaluate(this.m_frame);
				this.m_Material.SetFloat(ShaderUtilities.ID_GlowPower, value);
				this.m_frame += Time.deltaTime * Random.Range(0.2f, 0.3f);
				yield return new WaitForEndOfFrame();
			}
			yield break;
		}

		// Token: 0x04000EB7 RID: 3767
		private Renderer m_Renderer;

		// Token: 0x04000EB8 RID: 3768
		private Material m_Material;

		// Token: 0x04000EB9 RID: 3769
		public AnimationCurve GlowCurve;

		// Token: 0x04000EBA RID: 3770
		public float m_frame;
	}
}
