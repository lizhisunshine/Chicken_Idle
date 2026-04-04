using System;
using UnityEngine;

namespace AutoLetterbox
{
	// Token: 0x020000C9 RID: 201
	public class MenuSpin : MonoBehaviour
	{
		// Token: 0x060005CF RID: 1487 RVA: 0x0006A1F8 File Offset: 0x000683F8
		private void Start()
		{
			switch (this.axisRotation)
			{
			case rotAxis.xAxis:
				this.rotationVector = Vector3.right;
				break;
			case rotAxis.yAxis:
				this.rotationVector = Vector3.up;
				break;
			case rotAxis.zAxis:
				this.rotationVector = Vector3.back;
				break;
			}
			if (this.spinDirection == MenuSpin.direc.random)
			{
				if (Random.Range(0, 99) <= 49)
				{
					this.spinDirection = MenuSpin.direc.clockwise;
					return;
				}
				this.spinDirection = MenuSpin.direc.counterclockwise;
			}
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x0006A26C File Offset: 0x0006846C
		private void Update()
		{
			if (this.spinDirection == MenuSpin.direc.clockwise)
			{
				base.gameObject.transform.rotation *= Quaternion.AngleAxis(this.spinSpeed * Time.deltaTime, this.rotationVector);
				return;
			}
			base.gameObject.transform.rotation *= Quaternion.AngleAxis(this.spinSpeed * Time.deltaTime, -this.rotationVector);
		}

		// Token: 0x040010D2 RID: 4306
		public float spinSpeed;

		// Token: 0x040010D3 RID: 4307
		public MenuSpin.direc spinDirection;

		// Token: 0x040010D4 RID: 4308
		public rotAxis axisRotation = rotAxis.yAxis;

		// Token: 0x040010D5 RID: 4309
		private Vector3 rotationVector;

		// Token: 0x02000171 RID: 369
		public enum direc
		{
			// Token: 0x040013AC RID: 5036
			clockwise,
			// Token: 0x040013AD RID: 5037
			counterclockwise,
			// Token: 0x040013AE RID: 5038
			random
		}
	}
}
