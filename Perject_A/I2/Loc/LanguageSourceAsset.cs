using System;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x0200007D RID: 125
	[CreateAssetMenu(fileName = "I2Languages", menuName = "I2 Localization/LanguageSource", order = 1)]
	public class LanguageSourceAsset : ScriptableObject, ILanguageSource
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000356 RID: 854 RVA: 0x0005E143 File Offset: 0x0005C343
		// (set) Token: 0x06000357 RID: 855 RVA: 0x0005E14B File Offset: 0x0005C34B
		public LanguageSourceData SourceData
		{
			get
			{
				return this.mSource;
			}
			set
			{
				this.mSource = value;
			}
		}

		// Token: 0x04000F80 RID: 3968
		public LanguageSourceData mSource = new LanguageSourceData();
	}
}
