using System;
using System.Collections.Generic;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x02000069 RID: 105
	public class ToggleLanguage : MonoBehaviour
	{
		// Token: 0x060002DB RID: 731 RVA: 0x00057ED0 File Offset: 0x000560D0
		private void Start()
		{
			base.Invoke("test", 3f);
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00057EE4 File Offset: 0x000560E4
		private void test()
		{
			List<string> allLanguages = LocalizationManager.GetAllLanguages(true);
			int num = allLanguages.IndexOf(LocalizationManager.CurrentLanguage);
			if (num >= 0)
			{
				num = (num + 1) % allLanguages.Count;
			}
			base.Invoke("test", 3f);
		}
	}
}
