using System;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x02000091 RID: 145
	public class LocalizeTarget_UnityStandard_Prefab : LocalizeTarget<GameObject>
	{
		// Token: 0x0600046B RID: 1131 RVA: 0x00063E81 File Offset: 0x00062081
		static LocalizeTarget_UnityStandard_Prefab()
		{
			LocalizeTarget_UnityStandard_Prefab.AutoRegister();
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00063E88 File Offset: 0x00062088
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void AutoRegister()
		{
			LocalizationManager.RegisterTarget(new LocalizeTargetDesc_Prefab
			{
				Name = "Prefab",
				Priority = 250
			});
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00063EAA File Offset: 0x000620AA
		public override bool IsValid(Localize cmp)
		{
			return true;
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00063EAD File Offset: 0x000620AD
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return eTermType.GameObject;
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00063EB0 File Offset: 0x000620B0
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return eTermType.Text;
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00063EB3 File Offset: 0x000620B3
		public override bool CanUseSecondaryTerm()
		{
			return false;
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00063EB6 File Offset: 0x000620B6
		public override bool AllowMainTermToBeRTL()
		{
			return false;
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00063EB9 File Offset: 0x000620B9
		public override bool AllowSecondTermToBeRTL()
		{
			return false;
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00063EBC File Offset: 0x000620BC
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
			primaryTerm = cmp.name;
			secondaryTerm = null;
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00063ECC File Offset: 0x000620CC
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
			if (string.IsNullOrEmpty(mainTranslation))
			{
				return;
			}
			if (this.mTarget && this.mTarget.name == mainTranslation)
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
			Transform transform2 = this.InstantiateNewPrefab(cmp, mainTranslation);
			if (transform2 == null)
			{
				return;
			}
			transform2.name = text;
			for (int i = transform.childCount - 1; i >= 0; i--)
			{
				Transform child = transform.GetChild(i);
				if (child != transform2)
				{
					Object.Destroy(child.gameObject);
				}
			}
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00063F78 File Offset: 0x00062178
		private Transform InstantiateNewPrefab(Localize cmp, string mainTranslation)
		{
			GameObject gameObject = cmp.FindTranslatedObject<GameObject>(mainTranslation);
			if (gameObject == null)
			{
				return null;
			}
			GameObject mTarget = this.mTarget;
			this.mTarget = Object.Instantiate<GameObject>(gameObject);
			if (this.mTarget == null)
			{
				return null;
			}
			Transform transform = cmp.transform;
			Transform transform2 = this.mTarget.transform;
			transform2.SetParent(transform);
			Transform transform3 = mTarget ? mTarget.transform : transform;
			transform2.rotation = transform3.rotation;
			transform2.position = transform3.position;
			return transform2;
		}
	}
}
