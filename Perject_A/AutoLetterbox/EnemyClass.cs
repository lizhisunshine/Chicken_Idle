using System;
using UnityEngine;

namespace AutoLetterbox
{
	// Token: 0x020000BB RID: 187
	public class EnemyClass : MonoBehaviour
	{
		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x00068519 File Offset: 0x00066719
		// (set) Token: 0x06000593 RID: 1427 RVA: 0x00068521 File Offset: 0x00066721
		public Rigidbody2D rigid { get; private set; }

		// Token: 0x06000594 RID: 1428 RVA: 0x0006852A File Offset: 0x0006672A
		private void Start()
		{
			this.rigid = base.GetComponent<Rigidbody2D>();
			this.hitAudio = base.GetComponent<AudioSource>();
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x00068544 File Offset: 0x00066744
		private void OnMouseDown()
		{
			this.beingDragged = true;
			this.EnableGravity();
			this.PlayHitAudio(1.5f, 2.5f);
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00068563 File Offset: 0x00066763
		private void OnMouseUp()
		{
			if (this.rigid != null)
			{
				this.rigid.linearVelocity = Vector3.zero;
				this.rigid.angularVelocity = 0f;
			}
			this.beingDragged = false;
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x000685A0 File Offset: 0x000667A0
		private void OnCollisionEnter2D(Collision2D coll)
		{
			this.EnableGravity();
			if (this.rigid != null && this.rigid.linearVelocity.sqrMagnitude > 1f)
			{
				this.PlayHitAudio(0.5f, 1.5f);
			}
			DragonClass component = coll.gameObject.GetComponent<DragonClass>();
			if (component != null)
			{
				component.ApplyScore(this.nutrition, this.diet);
				Object.Destroy(base.gameObject);
			}
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x0006861D File Offset: 0x0006681D
		private void PlayHitAudio(float _lowPitch, float _highPitch)
		{
			if (this.hitAudio != null)
			{
				this.hitAudio.pitch = Random.Range(_lowPitch, _highPitch);
				this.hitAudio.Play();
			}
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x0006864A File Offset: 0x0006684A
		private void EnableGravity()
		{
			if (this.rigid != null)
			{
				this.rigid.gravityScale = 1f;
			}
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x0006866C File Offset: 0x0006686C
		private void Update()
		{
			if (this.beingDragged)
			{
				Vector3 position = Input.mousePosition;
				position.z = -Camera.main.gameObject.transform.position.z;
				position = Camera.main.ScreenToWorldPoint(position);
				base.gameObject.transform.position = position;
			}
		}

		// Token: 0x04001080 RID: 4224
		public int nutrition;

		// Token: 0x04001081 RID: 4225
		public Feed diet;

		// Token: 0x04001082 RID: 4226
		private AudioSource hitAudio;

		// Token: 0x04001083 RID: 4227
		private bool beingDragged;
	}
}
