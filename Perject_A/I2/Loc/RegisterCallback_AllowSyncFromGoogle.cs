using System;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x020000A4 RID: 164
	public class RegisterCallback_AllowSyncFromGoogle : MonoBehaviour
	{
		// Token: 0x060004E8 RID: 1256 RVA: 0x00065522 File Offset: 0x00063722
		public void Awake()
		{
			LocalizationManager.Callback_AllowSyncFromGoogle = new Func<LanguageSourceData, bool>(this.AllowSyncFromGoogle);
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00065536 File Offset: 0x00063736
		public void OnEnable()
		{
			LocalizationManager.Callback_AllowSyncFromGoogle = new Func<LanguageSourceData, bool>(this.AllowSyncFromGoogle);
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x0006554A File Offset: 0x0006374A
		public void OnDisable()
		{
			LocalizationManager.Callback_AllowSyncFromGoogle = null;
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00065552 File Offset: 0x00063752
		public virtual bool AllowSyncFromGoogle(LanguageSourceData Source)
		{
			return true;
		}
	}
}
