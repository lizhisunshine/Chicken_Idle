using System;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x0200008F RID: 143
	public class LocalizeTarget_UnityStandard_MeshRenderer : LocalizeTarget<MeshRenderer>
	{
		// Token: 0x0600045F RID: 1119 RVA: 0x00063D2C File Offset: 0x00061F2C
		static LocalizeTarget_UnityStandard_MeshRenderer()
		{
			LocalizeTarget_UnityStandard_MeshRenderer.AutoRegister();
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00063D33 File Offset: 0x00061F33
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
			LocalizationManager.RegisterTarget(new LocalizeTargetDesc_Type<MeshRenderer, LocalizeTarget_UnityStandard_MeshRenderer>
			{
				Name = "MeshRenderer",
				Priority = 800
			});
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00063D55 File Offset: 0x00061F55
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return eTermType.Mesh;
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00063D58 File Offset: 0x00061F58
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return eTermType.Material;
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00063D5B File Offset: 0x00061F5B
		public override bool CanUseSecondaryTerm()
		{
			return true;
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00063D5E File Offset: 0x00061F5E
		public override bool AllowMainTermToBeRTL()
		{
			return false;
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00063D61 File Offset: 0x00061F61
		public override bool AllowSecondTermToBeRTL()
		{
			return false;
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00063D64 File Offset: 0x00061F64
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
			if (this.mTarget == null)
			{
				string text;
				secondaryTerm = (text = null);
				primaryTerm = text;
			}
			else
			{
				MeshFilter component = this.mTarget.GetComponent<MeshFilter>();
				if (component == null || component.sharedMesh == null)
				{
					primaryTerm = null;
				}
				else
				{
					primaryTerm = component.sharedMesh.name;
				}
			}
			if (this.mTarget == null || this.mTarget.sharedMaterial == null)
			{
				secondaryTerm = null;
				return;
			}
			secondaryTerm = this.mTarget.sharedMaterial.name;
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00063DFC File Offset: 0x00061FFC
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
			Material secondaryTranslatedObj = cmp.GetSecondaryTranslatedObj<Material>(ref mainTranslation, ref secondaryTranslation);
			if (secondaryTranslatedObj != null && this.mTarget.sharedMaterial != secondaryTranslatedObj)
			{
				this.mTarget.material = secondaryTranslatedObj;
			}
			Mesh mesh = cmp.FindTranslatedObject<Mesh>(mainTranslation);
			MeshFilter component = this.mTarget.GetComponent<MeshFilter>();
			if (mesh != null && component.sharedMesh != mesh)
			{
				component.mesh = mesh;
			}
		}
	}
}
