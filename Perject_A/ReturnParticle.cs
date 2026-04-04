using System;
using UnityEngine;

// Token: 0x02000017 RID: 23
public class ReturnParticle : MonoBehaviour
{
	// Token: 0x06000071 RID: 113 RVA: 0x000069EE File Offset: 0x00004BEE
	private void OnDisable()
	{
		if (this.isRockParticle)
		{
			ObjectPool.instance.ReturnRockParticleToPool(base.gameObject);
		}
	}

	// Token: 0x04000208 RID: 520
	public bool isRockParticle;
}
