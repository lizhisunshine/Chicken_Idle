using System;
using UnityEngine;
using UnityEngine.UI;

namespace I2.Loc
{
	// Token: 0x02000096 RID: 150
	public class LocalizeTarget_UnityUI_RawImage : LocalizeTarget<RawImage>
	{
		// Token: 0x0600049F RID: 1183 RVA: 0x00064456 File Offset: 0x00062656
		static LocalizeTarget_UnityUI_RawImage()
		{
			LocalizeTarget_UnityUI_RawImage.AutoRegister();
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x0006445D File Offset: 0x0006265D
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
			LocalizationManager.RegisterTarget(new LocalizeTargetDesc_Type<RawImage, LocalizeTarget_UnityUI_RawImage>
			{
				Name = "RawImage",
				Priority = 100
			});
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x0006447C File Offset: 0x0006267C
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return eTermType.Texture;
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x0006447F File Offset: 0x0006267F
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return eTermType.Text;
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00064482 File Offset: 0x00062682
		public override bool CanUseSecondaryTerm()
		{
			return false;
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00064485 File Offset: 0x00062685
		public override bool AllowMainTermToBeRTL()
		{
			return false;
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00064488 File Offset: 0x00062688
		public override bool AllowSecondTermToBeRTL()
		{
			return false;
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x0006448B File Offset: 0x0006268B
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
			primaryTerm = (this.mTarget.mainTexture ? this.mTarget.mainTexture.name : "");
			secondaryTerm = null;
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x000644C0 File Offset: 0x000626C0
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
			Texture texture = this.mTarget.texture;
			if (texture == null || texture.name != mainTranslation)
			{
				this.mTarget.texture = cmp.FindTranslatedObject<Texture>(mainTranslation);
			}
		}
	}
}
