using System;
using UnityEngine;

namespace AutoLetterbox
{
	// Token: 0x020000C0 RID: 192
	public class Parralax : MonoBehaviour
	{
		// Token: 0x060005A9 RID: 1449 RVA: 0x00068A1C File Offset: 0x00066C1C
		private void Start()
		{
			this.camLastPos = this.camToParralaxAgainst.transform.position;
			this.parralaxMagnitude = Random.Range(this.movePercentRange.x, this.movePercentRange.y);
			float z = this.baseZ - this.parralaxMagnitude;
			base.transform.position = new Vector3(base.transform.position.x, base.transform.position.y, z);
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00068AA0 File Offset: 0x00066CA0
		private void Update()
		{
			if (this.ignoreThisFrame)
			{
				this.ignoreThisFrame = false;
				this.camLastPos = this.camToParralaxAgainst.transform.position;
				return;
			}
			Vector3 vector = this.camToParralaxAgainst.transform.position - this.camLastPos;
			vector *= this.parralaxMagnitude;
			base.transform.position = base.transform.position + new Vector3(vector.x, vector.y, 0f);
			this.camLastPos = this.camToParralaxAgainst.transform.position;
			if (base.transform.position.x < this.camToParralaxAgainst.transform.position.x - this.maxDistanceToCam)
			{
				this.ResetParralaxObject();
			}
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00068B78 File Offset: 0x00066D78
		private void ResetParralaxObject()
		{
			this.parralaxMagnitude = Random.Range(this.movePercentRange.x, this.movePercentRange.y);
			float z = this.baseZ - this.parralaxMagnitude;
			base.transform.position = new Vector3(this.camToParralaxAgainst.transform.position.x + this.maxDistanceToCam, base.transform.position.y, z);
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00068BF1 File Offset: 0x00066DF1
		public void IgnoreNextFrame()
		{
			this.ignoreThisFrame = true;
		}

		// Token: 0x04001095 RID: 4245
		public Transform camToParralaxAgainst;

		// Token: 0x04001096 RID: 4246
		public Vector2 movePercentRange;

		// Token: 0x04001097 RID: 4247
		public float baseZ = 50f;

		// Token: 0x04001098 RID: 4248
		protected float maxDistanceToCam = 14f;

		// Token: 0x04001099 RID: 4249
		private bool ignoreThisFrame;

		// Token: 0x0400109A RID: 4250
		private float parralaxMagnitude;

		// Token: 0x0400109B RID: 4251
		private Vector3 camLastPos;
	}
}
