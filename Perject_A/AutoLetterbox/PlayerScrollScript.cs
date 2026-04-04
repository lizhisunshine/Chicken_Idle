using System;
using UnityEngine;

namespace AutoLetterbox
{
	// Token: 0x020000C2 RID: 194
	public class PlayerScrollScript : MonoBehaviour
	{
		// Token: 0x060005B3 RID: 1459 RVA: 0x00068D68 File Offset: 0x00066F68
		private void Start()
		{
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00068D6C File Offset: 0x00066F6C
		private void FixedUpdate()
		{
			Vector3 vector = new Vector3(1f, 0f, 0f);
			vector = this.speed * vector;
			base.gameObject.transform.position = base.gameObject.transform.position + vector;
		}

		// Token: 0x040010A1 RID: 4257
		public float speed = 1f;
	}
}
