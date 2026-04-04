using System;

namespace I2.Loc
{
	// Token: 0x02000087 RID: 135
	public abstract class ILocalizeTargetDescriptor
	{
		// Token: 0x06000426 RID: 1062
		public abstract bool CanLocalize(Localize cmp);

		// Token: 0x06000427 RID: 1063
		public abstract ILocalizeTarget CreateTarget(Localize cmp);

		// Token: 0x06000428 RID: 1064
		public abstract Type GetTargetType();

		// Token: 0x04000FD5 RID: 4053
		public string Name;

		// Token: 0x04000FD6 RID: 4054
		public int Priority;
	}
}
