using System;
using UnityEngine;
using UnityEngine.UI;

namespace I2.Loc
{
	// Token: 0x02000095 RID: 149
	public class LocalizeTarget_UnityUI_Image : LocalizeTarget<Image>
	{
		// Token: 0x06000495 RID: 1173 RVA: 0x00064336 File Offset: 0x00062536
		static LocalizeTarget_UnityUI_Image()
		{
			LocalizeTarget_UnityUI_Image.AutoRegister();
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x0006433D File Offset: 0x0006253D
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
			LocalizationManager.RegisterTarget(new LocalizeTargetDesc_Type<Image, LocalizeTarget_UnityUI_Image>
			{
				Name = "Image",
				Priority = 100
			});
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x0006435C File Offset: 0x0006255C
		public override bool CanUseSecondaryTerm()
		{
			return false;
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x0006435F File Offset: 0x0006255F
		public override bool AllowMainTermToBeRTL()
		{
			return false;
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00064362 File Offset: 0x00062562
		public override bool AllowSecondTermToBeRTL()
		{
			return false;
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00064365 File Offset: 0x00062565
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			if (!(this.mTarget.sprite == null))
			{
				return eTermType.Sprite;
			}
			return eTermType.Texture;
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x0006437D File Offset: 0x0006257D
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return eTermType.Text;
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00064380 File Offset: 0x00062580
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
			primaryTerm = (this.mTarget.mainTexture ? this.mTarget.mainTexture.name : "");
			if (this.mTarget.sprite != null && this.mTarget.sprite.name != primaryTerm)
			{
				primaryTerm = primaryTerm + "." + this.mTarget.sprite.name;
			}
			secondaryTerm = null;
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x0006440C File Offset: 0x0006260C
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
