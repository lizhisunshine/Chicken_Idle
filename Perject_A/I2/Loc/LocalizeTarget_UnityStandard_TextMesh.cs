using System;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x02000093 RID: 147
	public class LocalizeTarget_UnityStandard_TextMesh : LocalizeTarget<TextMesh>
	{
		// Token: 0x06000481 RID: 1153 RVA: 0x000640BE File Offset: 0x000622BE
		static LocalizeTarget_UnityStandard_TextMesh()
		{
			LocalizeTarget_UnityStandard_TextMesh.AutoRegister();
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x000640C5 File Offset: 0x000622C5
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
			LocalizationManager.RegisterTarget(new LocalizeTargetDesc_Type<TextMesh, LocalizeTarget_UnityStandard_TextMesh>
			{
				Name = "TextMesh",
				Priority = 100
			});
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x000640E4 File Offset: 0x000622E4
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return eTermType.Text;
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x000640E7 File Offset: 0x000622E7
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return eTermType.Font;
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x000640EA File Offset: 0x000622EA
		public override bool CanUseSecondaryTerm()
		{
			return true;
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x000640ED File Offset: 0x000622ED
		public override bool AllowMainTermToBeRTL()
		{
			return true;
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x000640F0 File Offset: 0x000622F0
		public override bool AllowSecondTermToBeRTL()
		{
			return false;
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x000640F4 File Offset: 0x000622F4
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
			primaryTerm = (this.mTarget ? this.mTarget.text : null);
			secondaryTerm = ((string.IsNullOrEmpty(Secondary) && this.mTarget.font != null) ? this.mTarget.font.name : null);
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00064150 File Offset: 0x00062350
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
			Font secondaryTranslatedObj = cmp.GetSecondaryTranslatedObj<Font>(ref mainTranslation, ref secondaryTranslation);
			if (secondaryTranslatedObj != null && this.mTarget.font != secondaryTranslatedObj)
			{
				this.mTarget.font = secondaryTranslatedObj;
				this.mTarget.GetComponentInChildren<MeshRenderer>().material = secondaryTranslatedObj.material;
			}
			if (this.mInitializeAlignment)
			{
				this.mInitializeAlignment = false;
				this.mAlignment_LTR = (this.mAlignment_RTL = this.mTarget.alignment);
				if (LocalizationManager.IsRight2Left && this.mAlignment_RTL == TextAlignment.Right)
				{
					this.mAlignment_LTR = TextAlignment.Left;
				}
				if (!LocalizationManager.IsRight2Left && this.mAlignment_LTR == TextAlignment.Left)
				{
					this.mAlignment_RTL = TextAlignment.Right;
				}
			}
			if (mainTranslation != null && this.mTarget.text != mainTranslation)
			{
				if (cmp.CorrectAlignmentForRTL && this.mTarget.alignment != TextAlignment.Center)
				{
					this.mTarget.alignment = (LocalizationManager.IsRight2Left ? this.mAlignment_RTL : this.mAlignment_LTR);
				}
				this.mTarget.font.RequestCharactersInTexture(mainTranslation);
				this.mTarget.text = mainTranslation;
			}
		}

		// Token: 0x04000FDF RID: 4063
		private TextAlignment mAlignment_RTL = TextAlignment.Right;

		// Token: 0x04000FE0 RID: 4064
		private TextAlignment mAlignment_LTR;

		// Token: 0x04000FE1 RID: 4065
		private bool mAlignmentWasRTL;

		// Token: 0x04000FE2 RID: 4066
		private bool mInitializeAlignment = true;
	}
}
