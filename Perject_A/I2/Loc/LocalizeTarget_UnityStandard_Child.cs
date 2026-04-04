using System;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x0200008E RID: 142
	public class LocalizeTarget_UnityStandard_Child : LocalizeTarget<GameObject>
	{
		// Token: 0x06000454 RID: 1108 RVA: 0x00063C61 File Offset: 0x00061E61
		static LocalizeTarget_UnityStandard_Child()
		{
			LocalizeTarget_UnityStandard_Child.AutoRegister();
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00063C68 File Offset: 0x00061E68
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
			LocalizationManager.RegisterTarget(new LocalizeTargetDesc_Child
			{
				Name = "Child",
				Priority = 200
			});
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00063C8A File Offset: 0x00061E8A
		public override bool IsValid(Localize cmp)
		{
			return cmp.transform.childCount > 1;
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00063C9A File Offset: 0x00061E9A
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return eTermType.GameObject;
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00063C9D File Offset: 0x00061E9D
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return eTermType.Text;
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00063CA0 File Offset: 0x00061EA0
		public override bool CanUseSecondaryTerm()
		{
			return false;
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00063CA3 File Offset: 0x00061EA3
		public override bool AllowMainTermToBeRTL()
		{
			return false;
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00063CA6 File Offset: 0x00061EA6
		public override bool AllowSecondTermToBeRTL()
		{
			return false;
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00063CA9 File Offset: 0x00061EA9
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
			primaryTerm = cmp.name;
			secondaryTerm = null;
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00063CB8 File Offset: 0x00061EB8
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
			if (string.IsNullOrEmpty(mainTranslation))
			{
				return;
			}
			Transform transform = cmp.transform;
			string text = mainTranslation;
			int num = mainTranslation.LastIndexOfAny(LanguageSourceData.CategorySeparators);
			if (num >= 0)
			{
				text = text.Substring(num + 1);
			}
			for (int i = 0; i < transform.childCount; i++)
			{
				Transform child = transform.GetChild(i);
				child.gameObject.SetActive(child.name == text);
			}
		}
	}
}
