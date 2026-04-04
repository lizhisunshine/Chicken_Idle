using System;
using UnityEngine;
using UnityEngine.UI;

namespace I2.Loc
{
	// Token: 0x02000097 RID: 151
	public class LocalizeTarget_UnityUI_Text : LocalizeTarget<Text>
	{
		// Token: 0x060004A9 RID: 1193 RVA: 0x0006450A File Offset: 0x0006270A
		static LocalizeTarget_UnityUI_Text()
		{
			LocalizeTarget_UnityUI_Text.AutoRegister();
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00064511 File Offset: 0x00062711
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
			LocalizationManager.RegisterTarget(new LocalizeTargetDesc_Type<Text, LocalizeTarget_UnityUI_Text>
			{
				Name = "Text",
				Priority = 100
			});
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00064530 File Offset: 0x00062730
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return eTermType.Text;
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00064533 File Offset: 0x00062733
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return eTermType.Font;
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00064536 File Offset: 0x00062736
		public override bool CanUseSecondaryTerm()
		{
			return true;
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00064539 File Offset: 0x00062739
		public override bool AllowMainTermToBeRTL()
		{
			return true;
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x0006453C File Offset: 0x0006273C
		public override bool AllowSecondTermToBeRTL()
		{
			return false;
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00064540 File Offset: 0x00062740
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
			primaryTerm = (this.mTarget ? this.mTarget.text : null);
			secondaryTerm = ((this.mTarget.font != null) ? this.mTarget.font.name : string.Empty);
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00064598 File Offset: 0x00062798
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
			Font secondaryTranslatedObj = cmp.GetSecondaryTranslatedObj<Font>(ref mainTranslation, ref secondaryTranslation);
			if (secondaryTranslatedObj != null && secondaryTranslatedObj != this.mTarget.font)
			{
				this.mTarget.font = secondaryTranslatedObj;
			}
			if (this.mInitializeAlignment)
			{
				this.mInitializeAlignment = false;
				this.mAlignmentWasRTL = LocalizationManager.IsRight2Left;
				this.InitAlignment(this.mAlignmentWasRTL, this.mTarget.alignment, out this.mAlignment_LTR, out this.mAlignment_RTL);
			}
			else
			{
				TextAnchor textAnchor;
				TextAnchor textAnchor2;
				this.InitAlignment(this.mAlignmentWasRTL, this.mTarget.alignment, out textAnchor, out textAnchor2);
				if ((this.mAlignmentWasRTL && this.mAlignment_RTL != textAnchor2) || (!this.mAlignmentWasRTL && this.mAlignment_LTR != textAnchor))
				{
					this.mAlignment_LTR = textAnchor;
					this.mAlignment_RTL = textAnchor2;
				}
				this.mAlignmentWasRTL = LocalizationManager.IsRight2Left;
			}
			if (mainTranslation != null && this.mTarget.text != mainTranslation)
			{
				if (cmp.CorrectAlignmentForRTL)
				{
					this.mTarget.alignment = (LocalizationManager.IsRight2Left ? this.mAlignment_RTL : this.mAlignment_LTR);
				}
				this.mTarget.text = mainTranslation;
				this.mTarget.SetVerticesDirty();
			}
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x000646C4 File Offset: 0x000628C4
		private void InitAlignment(bool isRTL, TextAnchor alignment, out TextAnchor alignLTR, out TextAnchor alignRTL)
		{
			alignRTL = alignment;
			alignLTR = alignment;
			if (isRTL)
			{
				switch (alignment)
				{
				case TextAnchor.UpperLeft:
					alignLTR = TextAnchor.UpperRight;
					return;
				case TextAnchor.UpperCenter:
				case TextAnchor.MiddleCenter:
				case TextAnchor.LowerCenter:
					break;
				case TextAnchor.UpperRight:
					alignLTR = TextAnchor.UpperLeft;
					return;
				case TextAnchor.MiddleLeft:
					alignLTR = TextAnchor.MiddleRight;
					return;
				case TextAnchor.MiddleRight:
					alignLTR = TextAnchor.MiddleLeft;
					return;
				case TextAnchor.LowerLeft:
					alignLTR = TextAnchor.LowerRight;
					return;
				case TextAnchor.LowerRight:
					alignLTR = TextAnchor.LowerLeft;
					return;
				default:
					return;
				}
			}
			else
			{
				switch (alignment)
				{
				case TextAnchor.UpperLeft:
					alignRTL = TextAnchor.UpperRight;
					return;
				case TextAnchor.UpperCenter:
				case TextAnchor.MiddleCenter:
				case TextAnchor.LowerCenter:
					break;
				case TextAnchor.UpperRight:
					alignRTL = TextAnchor.UpperLeft;
					return;
				case TextAnchor.MiddleLeft:
					alignRTL = TextAnchor.MiddleRight;
					return;
				case TextAnchor.MiddleRight:
					alignRTL = TextAnchor.MiddleLeft;
					return;
				case TextAnchor.LowerLeft:
					alignRTL = TextAnchor.LowerRight;
					break;
				case TextAnchor.LowerRight:
					alignRTL = TextAnchor.LowerLeft;
					return;
				default:
					return;
				}
			}
		}

		// Token: 0x04000FE3 RID: 4067
		private TextAnchor mAlignment_RTL = TextAnchor.UpperRight;

		// Token: 0x04000FE4 RID: 4068
		private TextAnchor mAlignment_LTR;

		// Token: 0x04000FE5 RID: 4069
		private bool mAlignmentWasRTL;

		// Token: 0x04000FE6 RID: 4070
		private bool mInitializeAlignment = true;
	}
}
