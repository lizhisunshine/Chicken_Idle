using System;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x0200004B RID: 75
	public class ObjectSpin : MonoBehaviour
	{
		// Token: 0x06000241 RID: 577 RVA: 0x000548D8 File Offset: 0x00052AD8
		private void Awake()
		{
			this.m_transform = base.transform;
			this.m_initial_Rotation = this.m_transform.rotation.eulerAngles;
			this.m_initial_Position = this.m_transform.position;
			Light component = base.GetComponent<Light>();
			this.m_lightColor = ((component != null) ? component.color : Color.black);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00054944 File Offset: 0x00052B44
		private void Update()
		{
			switch (this.Motion)
			{
			case ObjectSpin.MotionType.Rotation:
				this.m_transform.Rotate(0f, this.SpinSpeed * Time.deltaTime, 0f);
				return;
			case ObjectSpin.MotionType.SearchLight:
				this.m_time += this.SpinSpeed * Time.deltaTime;
				this.m_transform.rotation = Quaternion.Euler(this.m_initial_Rotation.x, Mathf.Sin(this.m_time) * (float)this.RotationRange + this.m_initial_Rotation.y, this.m_initial_Rotation.z);
				return;
			case ObjectSpin.MotionType.Translation:
			{
				this.m_time += this.TranslationSpeed * Time.deltaTime;
				float x = this.TranslationDistance.x * Mathf.Cos(this.m_time);
				float z = this.TranslationDistance.y * Mathf.Sin(this.m_time) * Mathf.Cos(this.m_time * 1f);
				float y = this.TranslationDistance.z * Mathf.Sin(this.m_time);
				this.m_transform.position = this.m_initial_Position + new Vector3(x, y, z);
				this.m_prevPOS = this.m_transform.position;
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x04000EAC RID: 3756
		public ObjectSpin.MotionType Motion;

		// Token: 0x04000EAD RID: 3757
		public Vector3 TranslationDistance = new Vector3(5f, 0f, 0f);

		// Token: 0x04000EAE RID: 3758
		public float TranslationSpeed = 1f;

		// Token: 0x04000EAF RID: 3759
		public float SpinSpeed = 5f;

		// Token: 0x04000EB0 RID: 3760
		public int RotationRange = 15;

		// Token: 0x04000EB1 RID: 3761
		private Transform m_transform;

		// Token: 0x04000EB2 RID: 3762
		private float m_time;

		// Token: 0x04000EB3 RID: 3763
		private Vector3 m_prevPOS;

		// Token: 0x04000EB4 RID: 3764
		private Vector3 m_initial_Rotation;

		// Token: 0x04000EB5 RID: 3765
		private Vector3 m_initial_Position;

		// Token: 0x04000EB6 RID: 3766
		private Color32 m_lightColor;

		// Token: 0x02000136 RID: 310
		public enum MotionType
		{
			// Token: 0x040012C7 RID: 4807
			Rotation,
			// Token: 0x040012C8 RID: 4808
			SearchLight,
			// Token: 0x040012C9 RID: 4809
			Translation
		}
	}
}
