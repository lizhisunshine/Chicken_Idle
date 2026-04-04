using System;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x02000064 RID: 100
	public class Example_ChangeLanguage : MonoBehaviour
	{
		// Token: 0x060002C4 RID: 708 RVA: 0x00057995 File Offset: 0x00055B95
		public void SetLanguage_English()
		{
			this.SetLanguage("English");
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x000579A2 File Offset: 0x00055BA2
		public void SetLanguage_French()
		{
			this.SetLanguage("French");
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x000579AF File Offset: 0x00055BAF
		public void SetLanguage_Spanish()
		{
			this.SetLanguage("Spanish");
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x000579BC File Offset: 0x00055BBC
		public void SetLanguage(string LangName)
		{
			if (LocalizationManager.HasLanguage(LangName, true, true, true))
			{
				LocalizationManager.CurrentLanguage = LangName;
			}
		}
	}
}
