using System;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x020000A5 RID: 165
	public class RegisterGlobalParameters : MonoBehaviour, ILocalizationParamsManager
	{
		// Token: 0x060004ED RID: 1261 RVA: 0x0006555D File Offset: 0x0006375D
		public virtual void OnEnable()
		{
			if (!LocalizationManager.ParamManagers.Contains(this))
			{
				LocalizationManager.ParamManagers.Add(this);
				LocalizationManager.LocalizeAll(true);
			}
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x0006557D File Offset: 0x0006377D
		public virtual void OnDisable()
		{
			LocalizationManager.ParamManagers.Remove(this);
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x0006558B File Offset: 0x0006378B
		public virtual string GetParameterValue(string ParamName)
		{
			return null;
		}
	}
}
