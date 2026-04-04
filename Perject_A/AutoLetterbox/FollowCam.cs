using System;
using UnityEngine;

namespace AutoLetterbox
{
	// Token: 0x020000BC RID: 188
	public class FollowCam : MonoBehaviour
	{
		// Token: 0x0600059C RID: 1436 RVA: 0x000686CD File Offset: 0x000668CD
		private void Awake()
		{
			this.originLocalPosition = base.transform.localPosition;
			if (this.objectToFollow == null)
			{
				Debug.Log("Warning: There is no Object to follow on the Following Camera!");
				return;
			}
			this.targetLocalPosition = base.transform.localPosition;
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x0006870C File Offset: 0x0006690C
		private void Update()
		{
			float axis = Input.GetAxis("Horizontal");
			if (axis > 0.05f)
			{
				this.targetLocalPosition = new Vector3(this.localDistanceAheadOfObject, this.originLocalPosition.y, this.originLocalPosition.z);
			}
			else if (axis < -0.05f)
			{
				this.targetLocalPosition = new Vector3(-this.localDistanceAheadOfObject, this.originLocalPosition.y, this.originLocalPosition.z);
			}
			base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, this.targetLocalPosition, this.followWeight);
			base.transform.parent.position = Vector3.Lerp(base.transform.parent.position, this.objectToFollow.position, this.followWeight);
		}

		// Token: 0x04001085 RID: 4229
		public Transform objectToFollow;

		// Token: 0x04001086 RID: 4230
		public float localDistanceAheadOfObject = 6f;

		// Token: 0x04001087 RID: 4231
		public float followWeight = 0.1f;

		// Token: 0x04001088 RID: 4232
		private Vector3 targetLocalPosition;

		// Token: 0x04001089 RID: 4233
		private Vector3 originLocalPosition;
	}
}
