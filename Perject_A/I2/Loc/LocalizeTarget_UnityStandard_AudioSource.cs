using System;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x0200008C RID: 140
	public class LocalizeTarget_UnityStandard_AudioSource : LocalizeTarget<AudioSource>
	{
		// Token: 0x06000448 RID: 1096 RVA: 0x00063B5C File Offset: 0x00061D5C
		static LocalizeTarget_UnityStandard_AudioSource()
		{
			LocalizeTarget_UnityStandard_AudioSource.AutoRegister();
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00063B63 File Offset: 0x00061D63
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
			LocalizationManager.RegisterTarget(new LocalizeTargetDesc_Type<AudioSource, LocalizeTarget_UnityStandard_AudioSource>
			{
				Name = "AudioSource",
				Priority = 100
			});
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00063B82 File Offset: 0x00061D82
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return eTermType.AudioClip;
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00063B85 File Offset: 0x00061D85
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return eTermType.Text;
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00063B88 File Offset: 0x00061D88
		public override bool CanUseSecondaryTerm()
		{
			return false;
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00063B8B File Offset: 0x00061D8B
		public override bool AllowMainTermToBeRTL()
		{
			return false;
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00063B8E File Offset: 0x00061D8E
		public override bool AllowSecondTermToBeRTL()
		{
			return false;
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00063B94 File Offset: 0x00061D94
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
			AudioClip clip = this.mTarget.clip;
			primaryTerm = (clip ? clip.name : string.Empty);
			secondaryTerm = null;
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00063BCC File Offset: 0x00061DCC
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
			bool flag = (this.mTarget.isPlaying || this.mTarget.loop) && Application.isPlaying;
			Object clip = this.mTarget.clip;
			AudioClip audioClip = cmp.FindTranslatedObject<AudioClip>(mainTranslation);
			if (clip != audioClip)
			{
				this.mTarget.clip = audioClip;
			}
			if (flag && this.mTarget.clip)
			{
				this.mTarget.Play();
			}
		}
	}
}
