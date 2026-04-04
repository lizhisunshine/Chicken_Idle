using System;
using UnityEngine;

namespace AutoLetterbox
{
	// Token: 0x020000BF RID: 191
	public class LetterboxGameDemo : MonoBehaviour
	{
		// Token: 0x060005A5 RID: 1445 RVA: 0x000688DF File Offset: 0x00066ADF
		public void Start()
		{
			this.targetRatio = new Vector2(5f, 4f);
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x000688F6 File Offset: 0x00066AF6
		public void Update()
		{
			this.cameraManager.ratio = Vector2.Lerp(this.cameraManager.ratio, this.targetRatio, this.letterboxRate * Time.deltaTime);
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00068928 File Offset: 0x00066B28
		public void OnGUI()
		{
			Rect position = new Rect(20f, 10f, 200f, 50f);
			if (!this.inRatio)
			{
				GUI.color = new Color(1f, 0.1f, 0.1f);
				if (GUI.Button(position, "Letterbox off :("))
				{
					this.inRatio = true;
					this.letterboxRate = this.letterboxInRate;
					this.targetRatio = new Vector2(16f, 9f);
					return;
				}
			}
			else if (this.inRatio)
			{
				GUI.color = new Color(0.1f, 1f, 0.1f);
				if (GUI.Button(position, "LETTERBOX ON!"))
				{
					this.inRatio = false;
					this.letterboxRate = this.letterboxOutRate;
					this.targetRatio = new Vector2(5f, 4f);
				}
			}
		}

		// Token: 0x0400108F RID: 4239
		public ForceCameraRatio cameraManager;

		// Token: 0x04001090 RID: 4240
		public float letterboxInRate = 2f;

		// Token: 0x04001091 RID: 4241
		public float letterboxOutRate = 10f;

		// Token: 0x04001092 RID: 4242
		private float letterboxRate;

		// Token: 0x04001093 RID: 4243
		private Vector2 targetRatio;

		// Token: 0x04001094 RID: 4244
		private bool inRatio;
	}
}
