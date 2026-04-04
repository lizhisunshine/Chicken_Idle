using System;
using UnityEngine;
using UnityEngine.Events;

namespace I2.Loc
{
	// Token: 0x0200009E RID: 158
	[AddComponentMenu("I2/Localization/I2 Localize Callback")]
	public class CustomLocalizeCallback : MonoBehaviour
	{
		// Token: 0x060004C7 RID: 1223 RVA: 0x00064A93 File Offset: 0x00062C93
		public void OnEnable()
		{
			LocalizationManager.OnLocalizeEvent -= this.OnLocalize;
			LocalizationManager.OnLocalizeEvent += this.OnLocalize;
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00064AB7 File Offset: 0x00062CB7
		public void OnDisable()
		{
			LocalizationManager.OnLocalizeEvent -= this.OnLocalize;
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00064ACA File Offset: 0x00062CCA
		public void OnLocalize()
		{
			this._OnLocalize.Invoke();
		}

		// Token: 0x04000FFF RID: 4095
		public UnityEvent _OnLocalize = new UnityEvent();
	}
}
