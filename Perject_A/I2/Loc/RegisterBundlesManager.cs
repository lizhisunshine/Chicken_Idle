using System;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x02000068 RID: 104
	public class RegisterBundlesManager : MonoBehaviour, IResourceManager_Bundles
	{
		// Token: 0x060002D7 RID: 727 RVA: 0x00057E8E File Offset: 0x0005608E
		public void OnEnable()
		{
			if (!ResourceManager.pInstance.mBundleManagers.Contains(this))
			{
				ResourceManager.pInstance.mBundleManagers.Add(this);
			}
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00057EB2 File Offset: 0x000560B2
		public void OnDisable()
		{
			ResourceManager.pInstance.mBundleManagers.Remove(this);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00057EC5 File Offset: 0x000560C5
		public virtual Object LoadFromBundle(string path, Type assetType)
		{
			return null;
		}
	}
}
