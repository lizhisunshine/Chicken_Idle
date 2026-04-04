using System;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x02000088 RID: 136
	public abstract class LocalizeTargetDesc<T> : ILocalizeTargetDescriptor where T : ILocalizeTarget
	{
		// Token: 0x0600042A RID: 1066 RVA: 0x00063359 File Offset: 0x00061559
		public override ILocalizeTarget CreateTarget(Localize cmp)
		{
			return ScriptableObject.CreateInstance<T>();
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00063365 File Offset: 0x00061565
		public override Type GetTargetType()
		{
			return typeof(T);
		}
	}
}
