using System;

namespace I2.Loc
{
	// Token: 0x020000A3 RID: 163
	[Serializable]
	public struct LocalizedString
	{
		// Token: 0x060004E4 RID: 1252 RVA: 0x00065471 File Offset: 0x00063671
		public static implicit operator string(LocalizedString s)
		{
			return s.ToString();
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00065480 File Offset: 0x00063680
		public static implicit operator LocalizedString(string term)
		{
			return new LocalizedString
			{
				mTerm = term
			};
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x0006549E File Offset: 0x0006369E
		public LocalizedString(LocalizedString str)
		{
			this.mTerm = str.mTerm;
			this.mRTL_IgnoreArabicFix = str.mRTL_IgnoreArabicFix;
			this.mRTL_MaxLineLength = str.mRTL_MaxLineLength;
			this.mRTL_ConvertNumbers = str.mRTL_ConvertNumbers;
			this.m_DontLocalizeParameters = str.m_DontLocalizeParameters;
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x000654DC File Offset: 0x000636DC
		public override string ToString()
		{
			string translation = LocalizationManager.GetTranslation(this.mTerm, !this.mRTL_IgnoreArabicFix, this.mRTL_MaxLineLength, !this.mRTL_ConvertNumbers, true, null, null, true);
			LocalizationManager.ApplyLocalizationParams(ref translation, !this.m_DontLocalizeParameters);
			return translation;
		}

		// Token: 0x04001005 RID: 4101
		public string mTerm;

		// Token: 0x04001006 RID: 4102
		public bool mRTL_IgnoreArabicFix;

		// Token: 0x04001007 RID: 4103
		public int mRTL_MaxLineLength;

		// Token: 0x04001008 RID: 4104
		public bool mRTL_ConvertNumbers;

		// Token: 0x04001009 RID: 4105
		public bool m_DontLocalizeParameters;
	}
}
