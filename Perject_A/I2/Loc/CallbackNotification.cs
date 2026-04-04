using System;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x02000063 RID: 99
	public class CallbackNotification : MonoBehaviour
	{
		// Token: 0x060002C2 RID: 706 RVA: 0x0005794C File Offset: 0x00055B4C
		public void OnModifyLocalization()
		{
			if (string.IsNullOrEmpty(Localize.MainTranslation))
			{
				return;
			}
			string translation = LocalizationManager.GetTranslation("Color/Red", true, 0, true, false, null, null, true);
			Localize.MainTranslation = Localize.MainTranslation.Replace("{PLAYER_COLOR}", translation);
		}
	}
}
