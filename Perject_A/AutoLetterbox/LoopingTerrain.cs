using System;
using UnityEngine;

namespace AutoLetterbox
{
	// Token: 0x020000C4 RID: 196
	public class LoopingTerrain : MonoBehaviour
	{
		// Token: 0x060005BA RID: 1466 RVA: 0x00068EEC File Offset: 0x000670EC
		private void Start()
		{
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00068EF0 File Offset: 0x000670F0
		private void Update()
		{
			Vector3 position = this.upperTerrainDummy.transform.position;
			if (this.lowerTerrainDummy.transform.position.x <= position.x)
			{
				base.gameObject.transform.position = base.gameObject.transform.position + this.jumpPosition;
			}
		}

		// Token: 0x040010A4 RID: 4260
		public GameObject upperTerrainDummy;

		// Token: 0x040010A5 RID: 4261
		public GameObject lowerTerrainDummy;

		// Token: 0x040010A6 RID: 4262
		public Vector3 jumpPosition;
	}
}
