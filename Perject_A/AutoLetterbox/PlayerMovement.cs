using System;
using UnityEngine;

namespace AutoLetterbox
{
	// Token: 0x020000C1 RID: 193
	public class PlayerMovement : MonoBehaviour
	{
		// Token: 0x060005AE RID: 1454 RVA: 0x00068C18 File Offset: 0x00066E18
		private void Awake()
		{
			this.rigid = base.GetComponent<Rigidbody2D>();
			if (this.rigid == null)
			{
				Debug.Log("Warning: There is no Rigidbody2D on the Player!");
			}
			if (this.feetMarker == null)
			{
				Debug.Log("Warning: Feet have not been set on the Player so we cannot jump!");
			}
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00068C58 File Offset: 0x00066E58
		private void FixedUpdate()
		{
			Vector3 v = this.rigid.linearVelocity;
			float axis = Input.GetAxis("Horizontal");
			if (this.grounded && Input.GetButton("Jump"))
			{
				v.y = this.jumpSpeed;
			}
			v.x = this.runSpeed * axis;
			this.rigid.linearVelocity = v;
			this.grounded = false;
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00068CCC File Offset: 0x00066ECC
		private void OnCollisionStay2D(Collision2D collision)
		{
			for (int i = 0; i < collision.contacts.Length; i++)
			{
				if (collision.contacts[i].point.y < this.feetMarker.position.y)
				{
					this.grounded = true;
				}
			}
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00068D1B File Offset: 0x00066F1B
		public void OnDrawGizmos()
		{
			if (this.feetMarker != null)
			{
				Gizmos.color = Color.magenta;
				Gizmos.DrawSphere(this.feetMarker.position, 0.1f);
			}
		}

		// Token: 0x0400109C RID: 4252
		public float runSpeed = 7.5f;

		// Token: 0x0400109D RID: 4253
		public float jumpSpeed = 5f;

		// Token: 0x0400109E RID: 4254
		public Transform feetMarker;

		// Token: 0x0400109F RID: 4255
		private Rigidbody2D rigid;

		// Token: 0x040010A0 RID: 4256
		private bool grounded;
	}
}
