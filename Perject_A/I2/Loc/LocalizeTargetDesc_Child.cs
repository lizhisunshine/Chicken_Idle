using System;

namespace I2.Loc
{
	// Token: 0x0200008D RID: 141
	public class LocalizeTargetDesc_Child : LocalizeTargetDesc<LocalizeTarget_UnityStandard_Child>
	{
		// Token: 0x06000452 RID: 1106 RVA: 0x00063C49 File Offset: 0x00061E49
		public override bool CanLocalize(Localize cmp)
		{
			return cmp.transform.childCount > 1;
		}
	}
}
