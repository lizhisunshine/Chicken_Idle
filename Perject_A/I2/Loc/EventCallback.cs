using System;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x0200006F RID: 111
	[Serializable]
	public class EventCallback
	{
		// Token: 0x06000301 RID: 769 RVA: 0x00058900 File Offset: 0x00056B00
		public void Execute(Object Sender = null)
		{
			if (this.HasCallback() && Application.isPlaying)
			{
				this.Target.gameObject.SendMessage(this.MethodName, Sender, SendMessageOptions.DontRequireReceiver);
			}
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00058929 File Offset: 0x00056B29
		public bool HasCallback()
		{
			return this.Target != null && !string.IsNullOrEmpty(this.MethodName);
		}

		// Token: 0x04000F3C RID: 3900
		public MonoBehaviour Target;

		// Token: 0x04000F3D RID: 3901
		public string MethodName = string.Empty;
	}
}
