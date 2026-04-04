using System;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x02000085 RID: 133
	public abstract class ILocalizeTarget : ScriptableObject
	{
		// Token: 0x0600041B RID: 1051
		public abstract bool IsValid(Localize cmp);

		// Token: 0x0600041C RID: 1052
		public abstract void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm);

		// Token: 0x0600041D RID: 1053
		public abstract void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation);

		// Token: 0x0600041E RID: 1054
		public abstract bool CanUseSecondaryTerm();

		// Token: 0x0600041F RID: 1055
		public abstract bool AllowMainTermToBeRTL();

		// Token: 0x06000420 RID: 1056
		public abstract bool AllowSecondTermToBeRTL();

		// Token: 0x06000421 RID: 1057
		public abstract eTermType GetPrimaryTermType(Localize cmp);

		// Token: 0x06000422 RID: 1058
		public abstract eTermType GetSecondaryTermType(Localize cmp);
	}
}
