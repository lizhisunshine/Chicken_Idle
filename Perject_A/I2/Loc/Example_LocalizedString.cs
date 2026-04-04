using System;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x02000065 RID: 101
	public class Example_LocalizedString : MonoBehaviour
	{
		// Token: 0x060002C9 RID: 713 RVA: 0x000579D8 File Offset: 0x00055BD8
		public void Start()
		{
			Debug.Log(this._MyLocalizedString);
			Debug.Log(LocalizationManager.GetTranslation(this._NormalString, true, 0, true, false, null, null, true));
			Debug.Log(LocalizationManager.GetTranslation(this._StringWithTermPopup, true, 0, true, false, null, null, true));
			Debug.Log("Term2");
			Debug.Log(this._MyLocalizedString);
			Debug.Log("Term3");
			LocalizedString localizedString = "Term3";
			localizedString.mRTL_IgnoreArabicFix = true;
			Debug.Log(localizedString);
			LocalizedString localizedString2 = "Term3";
			localizedString2.mRTL_ConvertNumbers = true;
			localizedString2.mRTL_MaxLineLength = 20;
			Debug.Log(localizedString2);
			Debug.Log(localizedString2);
		}

		// Token: 0x04000F32 RID: 3890
		public LocalizedString _MyLocalizedString;

		// Token: 0x04000F33 RID: 3891
		public string _NormalString;

		// Token: 0x04000F34 RID: 3892
		[TermsPopup("")]
		public string _StringWithTermPopup;
	}
}
