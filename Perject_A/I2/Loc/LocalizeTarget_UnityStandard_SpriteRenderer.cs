using System;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x02000092 RID: 146
	public class LocalizeTarget_UnityStandard_SpriteRenderer : LocalizeTarget<SpriteRenderer>
	{
		// Token: 0x06000477 RID: 1143 RVA: 0x00064006 File Offset: 0x00062206
		static LocalizeTarget_UnityStandard_SpriteRenderer()
		{
			LocalizeTarget_UnityStandard_SpriteRenderer.AutoRegister();
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x0006400D File Offset: 0x0006220D
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
			LocalizationManager.RegisterTarget(new LocalizeTargetDesc_Type<SpriteRenderer, LocalizeTarget_UnityStandard_SpriteRenderer>
			{
				Name = "SpriteRenderer",
				Priority = 100
			});
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0006402C File Offset: 0x0006222C
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return eTermType.Sprite;
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x0006402F File Offset: 0x0006222F
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return eTermType.Text;
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00064032 File Offset: 0x00062232
		public override bool CanUseSecondaryTerm()
		{
			return false;
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00064035 File Offset: 0x00062235
		public override bool AllowMainTermToBeRTL()
		{
			return false;
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00064038 File Offset: 0x00062238
		public override bool AllowSecondTermToBeRTL()
		{
			return false;
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x0006403C File Offset: 0x0006223C
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
			Sprite sprite = this.mTarget.sprite;
			primaryTerm = ((sprite != null) ? sprite.name : string.Empty);
			secondaryTerm = null;
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00064074 File Offset: 0x00062274
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
			Sprite sprite = this.mTarget.sprite;
			if (sprite == null || sprite.name != mainTranslation)
			{
				this.mTarget.sprite = cmp.FindTranslatedObject<Sprite>(mainTranslation);
			}
		}
	}
}
