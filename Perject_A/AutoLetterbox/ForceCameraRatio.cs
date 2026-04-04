using System;
using System.Collections.Generic;
using UnityEngine;

namespace AutoLetterbox
{
	// Token: 0x020000CB RID: 203
	[Serializable]
	public class ForceCameraRatio : MonoBehaviour
	{
		// Token: 0x060005D6 RID: 1494 RVA: 0x0006A644 File Offset: 0x00068844
		private void Start()
		{
			if (this.findCamerasAutomatically)
			{
				this.FindAllCamerasInScene();
			}
			else if (this.cameras == null || this.cameras.Count == 0)
			{
				this.cameras = new List<CameraRatio>();
			}
			this.ValidateCameraArray();
			for (int i = 0; i < this.cameras.Count; i++)
			{
				this.cameras[i].ResetOriginViewport();
			}
			if (this.createCameraForLetterBoxRendering)
			{
				this.letterBoxCamera = new GameObject().AddComponent<Camera>();
				this.letterBoxCamera.backgroundColor = this.letterBoxCameraColor;
				this.letterBoxCamera.cullingMask = 0;
				this.letterBoxCamera.depth = -100f;
				this.letterBoxCamera.farClipPlane = 1f;
				this.letterBoxCamera.useOcclusionCulling = false;
				this.letterBoxCamera.allowHDR = false;
				this.letterBoxCamera.clearFlags = CameraClearFlags.Color;
				this.letterBoxCamera.name = "Letter Box Camera";
				for (int j = 0; j < this.cameras.Count; j++)
				{
					if (this.cameras[j].camera.depth == -100f)
					{
						Debug.LogError(this.cameras[j].camera.name + " has a depth of -100 and may conflict with the Letter Box Camera in Forced Camera Ratio!");
					}
				}
			}
			if (this.forceRatioOnAwake)
			{
				this.CalculateAndSetAllCameraRatios();
			}
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x0006A7A0 File Offset: 0x000689A0
		private void Update()
		{
			if (this.listenForWindowChanges)
			{
				this.CalculateAndSetAllCameraRatios();
				if (this.letterBoxCamera != null)
				{
					this.letterBoxCamera.backgroundColor = this.letterBoxCameraColor;
				}
			}
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x0006A7D0 File Offset: 0x000689D0
		private CameraRatio GetCameraRatioByCamera(Camera _camera)
		{
			if (this.cameras == null)
			{
				return null;
			}
			for (int i = 0; i < this.cameras.Count; i++)
			{
				if (this.cameras[i] != null && this.cameras[i].camera == _camera)
				{
					return this.cameras[i];
				}
			}
			return null;
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x0006A834 File Offset: 0x00068A34
		private void ValidateCameraArray()
		{
			for (int i = this.cameras.Count - 1; i >= 0; i--)
			{
				if (this.cameras[i].camera == null)
				{
					this.cameras.RemoveAt(i);
				}
			}
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x0006A880 File Offset: 0x00068A80
		public void FindAllCamerasInScene()
		{
			Camera[] array = Object.FindObjectsOfType<Camera>();
			this.cameras = new List<CameraRatio>();
			for (int i = 0; i < array.Length; i++)
			{
				if (this.createCameraForLetterBoxRendering || array[i] != this.letterBoxCamera)
				{
					this.cameras.Add(new CameraRatio(array[i], new Vector2(0.5f, 0.5f)));
				}
			}
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x0006A8E8 File Offset: 0x00068AE8
		public void CalculateAndSetAllCameraRatios()
		{
			float num = this.ratio.x / this.ratio.y;
			float num2 = (float)Screen.width / (float)Screen.height;
			bool horizontalLetterbox = false;
			float width = num / num2;
			float height = num2 / num;
			if (num2 > num)
			{
				horizontalLetterbox = false;
			}
			for (int i = 0; i < this.cameras.Count; i++)
			{
				this.cameras[i].SetAnchorBasedOnEnum(this.cameras[i].anchor);
				this.cameras[i].CalculateAndSetCameraRatio(width, height, horizontalLetterbox);
			}
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x0006A980 File Offset: 0x00068B80
		public void SetCameraAnchor(Camera _camera, Vector2 _anchor)
		{
			CameraRatio cameraRatioByCamera = this.GetCameraRatioByCamera(_camera);
			if (cameraRatioByCamera != null)
			{
				cameraRatioByCamera.vectorAnchor = _anchor;
			}
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x0006A99F File Offset: 0x00068B9F
		public CameraRatio[] GetCameras()
		{
			if (this.cameras == null)
			{
				this.cameras = new List<CameraRatio>();
			}
			return this.cameras.ToArray();
		}

		// Token: 0x040010DA RID: 4314
		public Vector2 ratio = new Vector2(16f, 9f);

		// Token: 0x040010DB RID: 4315
		public bool forceRatioOnAwake = true;

		// Token: 0x040010DC RID: 4316
		public bool listenForWindowChanges = true;

		// Token: 0x040010DD RID: 4317
		public bool createCameraForLetterBoxRendering = true;

		// Token: 0x040010DE RID: 4318
		public bool findCamerasAutomatically = true;

		// Token: 0x040010DF RID: 4319
		public Color letterBoxCameraColor = new Color(0f, 0f, 0f, 1f);

		// Token: 0x040010E0 RID: 4320
		public List<CameraRatio> cameras;

		// Token: 0x040010E1 RID: 4321
		public Camera letterBoxCamera;
	}
}
