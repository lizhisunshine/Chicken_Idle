using System;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x02000089 RID: 137
	public class LocalizeTargetDesc_Type<T, G> : LocalizeTargetDesc<G> where T : Object where G : LocalizeTarget<T>
	{
		// Token: 0x0600042D RID: 1069 RVA: 0x00063379 File Offset: 0x00061579
		public override bool CanLocalize(Localize cmp)
		{
			return cmp.GetComponent<T>() != null;
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x0006338C File Offset: 0x0006158C
		public override ILocalizeTarget CreateTarget(Localize cmp)
		{
			T component = cmp.GetComponent<T>();
			if (component == null)
			{
				return null;
			}
			G g = ScriptableObject.CreateInstance<G>();
			g.mTarget = component;
			return g;
		}
	}
}
