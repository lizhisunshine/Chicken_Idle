using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace I2.Loc
{
	// Token: 0x020000B0 RID: 176
	[AddComponentMenu("I2/Localization/SetLanguage Dropdown")]
	public class SetLanguageDropdown : MonoBehaviour
	{
		// Token: 0x06000510 RID: 1296 RVA: 0x00066E70 File Offset: 0x00065070
		private void OnEnable()
		{
			Dropdown component = base.GetComponent<Dropdown>();
			if (component == null)
			{
				return;
			}
			string currentLanguage = LocalizationManager.CurrentLanguage;
			if (LocalizationManager.Sources.Count == 0)
			{
				LocalizationManager.UpdateSources();
			}
			List<string> allLanguages = LocalizationManager.GetAllLanguages(true);
			component.ClearOptions();
			component.AddOptions(allLanguages);
			component.value = allLanguages.IndexOf(currentLanguage);
			component.onValueChanged.RemoveListener(new UnityAction<int>(this.OnValueChanged));
			component.onValueChanged.AddListener(new UnityAction<int>(this.OnValueChanged));
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00066EF8 File Offset: 0x000650F8
		private void OnValueChanged(int index)
		{
			Dropdown component = base.GetComponent<Dropdown>();
			if (index < 0)
			{
				index = 0;
				component.value = index;
			}
			LocalizationManager.CurrentLanguage = component.options[index].text;
		}
	}
}
