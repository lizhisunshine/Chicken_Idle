using System;
using UnityEngine.Networking;

namespace I2.Loc
{
	// Token: 0x02000075 RID: 117
	public class TranslationJob_WWW : TranslationJob
	{
		// Token: 0x06000333 RID: 819 RVA: 0x0005D4A4 File Offset: 0x0005B6A4
		public override void Dispose()
		{
			if (this.www != null)
			{
				this.www.Dispose();
			}
			this.www = null;
		}

		// Token: 0x04000F4F RID: 3919
		public UnityWebRequest www;
	}
}
