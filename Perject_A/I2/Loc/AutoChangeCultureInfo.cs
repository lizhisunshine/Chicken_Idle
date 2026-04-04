using System;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x0200009C RID: 156
	public class AutoChangeCultureInfo : MonoBehaviour
	{
		// Token: 0x060004C1 RID: 1217 RVA: 0x00064A0E File Offset: 0x00062C0E
		public void Start()
		{
			LocalizationManager.EnableChangingCultureInfo(true);
		}
	}
}
