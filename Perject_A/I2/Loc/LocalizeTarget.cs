using System;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x02000086 RID: 134
	public abstract class LocalizeTarget<T> : ILocalizeTarget where T : Object
	{
		// Token: 0x06000424 RID: 1060 RVA: 0x000632C0 File Offset: 0x000614C0
		public override bool IsValid(Localize cmp)
		{
			if (this.mTarget != null)
			{
				Component component = this.mTarget as Component;
				if (component != null && component.gameObject != cmp.gameObject)
				{
					this.mTarget = default(T);
				}
			}
			if (this.mTarget == null)
			{
				this.mTarget = cmp.GetComponent<T>();
			}
			return this.mTarget != null;
		}

		// Token: 0x04000FD4 RID: 4052
		public T mTarget;
	}
}
