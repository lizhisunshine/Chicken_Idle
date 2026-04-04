using System;
using UnityEngine;
using UnityEngine.Video;

namespace I2.Loc
{
	// Token: 0x02000094 RID: 148
	public class LocalizeTarget_UnityStandard_VideoPlayer : LocalizeTarget<VideoPlayer>
	{
		// Token: 0x0600048B RID: 1163 RVA: 0x0006427B File Offset: 0x0006247B
		static LocalizeTarget_UnityStandard_VideoPlayer()
		{
			LocalizeTarget_UnityStandard_VideoPlayer.AutoRegister();
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00064282 File Offset: 0x00062482
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
			LocalizationManager.RegisterTarget(new LocalizeTargetDesc_Type<VideoPlayer, LocalizeTarget_UnityStandard_VideoPlayer>
			{
				Name = "VideoPlayer",
				Priority = 100
			});
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x000642A1 File Offset: 0x000624A1
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return eTermType.Video;
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x000642A5 File Offset: 0x000624A5
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return eTermType.Text;
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x000642A8 File Offset: 0x000624A8
		public override bool CanUseSecondaryTerm()
		{
			return false;
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x000642AB File Offset: 0x000624AB
		public override bool AllowMainTermToBeRTL()
		{
			return false;
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x000642AE File Offset: 0x000624AE
		public override bool AllowSecondTermToBeRTL()
		{
			return false;
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x000642B4 File Offset: 0x000624B4
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
			VideoClip clip = this.mTarget.clip;
			primaryTerm = ((clip != null) ? clip.name : string.Empty);
			secondaryTerm = null;
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x000642EC File Offset: 0x000624EC
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
			VideoClip clip = this.mTarget.clip;
			if (clip == null || clip.name != mainTranslation)
			{
				this.mTarget.clip = cmp.FindTranslatedObject<VideoClip>(mainTranslation);
			}
		}
	}
}
