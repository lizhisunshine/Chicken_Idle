using System;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x020000AF RID: 175
	[AddComponentMenu("I2/Localization/SetLanguage Button")]
	public class SetLanguage : MonoBehaviour
	{
		// Token: 0x0600050D RID: 1293 RVA: 0x00066E40 File Offset: 0x00065040
		private void OnClick()
		{
			this.ApplyLanguage();
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00066E48 File Offset: 0x00065048
		public void ApplyLanguage()
		{
			if (LocalizationManager.HasLanguage(this._Language, true, true, true))
			{
				LocalizationManager.CurrentLanguage = this._Language;
			}
		}

		// Token: 0x0400106A RID: 4202
		public string _Language;
	}
}
