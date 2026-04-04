using System;
using System.Collections.Generic;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x020000A2 RID: 162
	public class LocalizationParamsManager : MonoBehaviour, ILocalizationParamsManager
	{
		// Token: 0x060004DD RID: 1245 RVA: 0x00065308 File Offset: 0x00063508
		public string GetParameterValue(string ParamName)
		{
			if (this._Params != null)
			{
				int i = 0;
				int count = this._Params.Count;
				while (i < count)
				{
					if (this._Params[i].Name == ParamName)
					{
						return this._Params[i].Value;
					}
					i++;
				}
			}
			return null;
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00065364 File Offset: 0x00063564
		public void SetParameterValue(string ParamName, string ParamValue, bool localize = true)
		{
			bool flag = false;
			int i = 0;
			int count = this._Params.Count;
			while (i < count)
			{
				if (this._Params[i].Name == ParamName)
				{
					LocalizationParamsManager.ParamValue value = this._Params[i];
					value.Value = ParamValue;
					this._Params[i] = value;
					flag = true;
					break;
				}
				i++;
			}
			if (!flag)
			{
				this._Params.Add(new LocalizationParamsManager.ParamValue
				{
					Name = ParamName,
					Value = ParamValue
				});
			}
			if (localize)
			{
				this.OnLocalize();
			}
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x000653FC File Offset: 0x000635FC
		public void OnLocalize()
		{
			Localize component = base.GetComponent<Localize>();
			if (component != null)
			{
				component.OnLocalize(true);
			}
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00065420 File Offset: 0x00063620
		public virtual void OnEnable()
		{
			if (this._IsGlobalManager)
			{
				this.DoAutoRegister();
			}
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00065430 File Offset: 0x00063630
		public void DoAutoRegister()
		{
			if (!LocalizationManager.ParamManagers.Contains(this))
			{
				LocalizationManager.ParamManagers.Add(this);
				LocalizationManager.LocalizeAll(true);
			}
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00065450 File Offset: 0x00063650
		public void OnDisable()
		{
			LocalizationManager.ParamManagers.Remove(this);
		}

		// Token: 0x04001003 RID: 4099
		[SerializeField]
		public List<LocalizationParamsManager.ParamValue> _Params = new List<LocalizationParamsManager.ParamValue>();

		// Token: 0x04001004 RID: 4100
		public bool _IsGlobalManager;

		// Token: 0x02000169 RID: 361
		[Serializable]
		public struct ParamValue
		{
			// Token: 0x0400138D RID: 5005
			public string Name;

			// Token: 0x0400138E RID: 5006
			public string Value;
		}
	}
}
