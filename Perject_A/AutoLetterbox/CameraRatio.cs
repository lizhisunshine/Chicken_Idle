using System;
using UnityEngine;

namespace AutoLetterbox
{
	// Token: 0x020000CA RID: 202
	[Serializable]
	public class CameraRatio
	{
		// Token: 0x060005D2 RID: 1490 RVA: 0x0006A2FA File Offset: 0x000684FA
		public CameraRatio(Camera _camera, Vector2 _anchor)
		{
			this.camera = _camera;
			this.vectorAnchor = _anchor;
			this.originViewPort = this.camera.rect;
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x0006A321 File Offset: 0x00068521
		public void ResetOriginViewport()
		{
			this.originViewPort = this.camera.rect;
			this.SetAnchorBasedOnEnum(this.anchor);
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x0006A340 File Offset: 0x00068540
		public void SetAnchorBasedOnEnum(CameraRatio.CameraAnchor _anchor)
		{
			switch (_anchor)
			{
			case CameraRatio.CameraAnchor.Center:
				this.vectorAnchor = new Vector2(0.5f, 0.5f);
				return;
			case CameraRatio.CameraAnchor.Top:
				this.vectorAnchor = new Vector2(0.5f, 1f);
				return;
			case CameraRatio.CameraAnchor.Bottom:
				this.vectorAnchor = new Vector2(0.5f, 0f);
				return;
			case CameraRatio.CameraAnchor.Left:
				this.vectorAnchor = new Vector2(0f, 0.5f);
				return;
			case CameraRatio.CameraAnchor.Right:
				this.vectorAnchor = new Vector2(1f, 0.5f);
				return;
			case CameraRatio.CameraAnchor.TopLeft:
				this.vectorAnchor = new Vector2(0f, 1f);
				return;
			case CameraRatio.CameraAnchor.TopRight:
				this.vectorAnchor = new Vector2(1f, 1f);
				return;
			case CameraRatio.CameraAnchor.BottomLeft:
				this.vectorAnchor = new Vector2(0f, 0f);
				return;
			case CameraRatio.CameraAnchor.BottomRight:
				this.vectorAnchor = new Vector2(1f, 0f);
				return;
			default:
				return;
			}
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x0006A440 File Offset: 0x00068640
		public void CalculateAndSetCameraRatio(float _width, float _height, bool _horizontalLetterbox)
		{
			Rect rect = default(Rect);
			if (_horizontalLetterbox)
			{
				rect.height = _height;
				rect.width = 1f;
			}
			else
			{
				rect.height = 1f;
				rect.width = _width;
			}
			Rect rect2 = default(Rect);
			Rect rect3 = default(Rect);
			rect2.width = this.originViewPort.width;
			rect2.height = this.originViewPort.width * (rect.height / rect.width);
			rect2.x = this.originViewPort.x;
			rect2.y = Mathf.Lerp(this.originViewPort.y, this.originViewPort.y + (this.originViewPort.height - rect2.height), this.vectorAnchor.y);
			rect3.width = this.originViewPort.height * (rect.width / rect.height);
			rect3.height = this.originViewPort.height;
			rect3.x = Mathf.Lerp(this.originViewPort.x, this.originViewPort.x + (this.originViewPort.width - rect3.width), this.vectorAnchor.x);
			rect3.y = this.originViewPort.y;
			if (rect2.height >= rect3.height && rect2.width >= rect3.width)
			{
				if (rect2.height <= this.originViewPort.height && rect2.width <= this.originViewPort.width)
				{
					this.camera.rect = rect2;
					return;
				}
				this.camera.rect = rect3;
				return;
			}
			else
			{
				if (rect3.height <= this.originViewPort.height && rect3.width <= this.originViewPort.width)
				{
					this.camera.rect = rect3;
					return;
				}
				this.camera.rect = rect2;
				return;
			}
		}

		// Token: 0x040010D6 RID: 4310
		[Tooltip("The Camera assigned to have an automatically calculated Viewport Ratio")]
		public Camera camera;

		// Token: 0x040010D7 RID: 4311
		[Tooltip("When a Camera Viewport is shrunk to fit a ratio, it will anchor the new Viewport Rectangle at the given point (relative to the original, unshrunk Viewport)")]
		public CameraRatio.CameraAnchor anchor;

		// Token: 0x040010D8 RID: 4312
		[HideInInspector]
		public Vector2 vectorAnchor;

		// Token: 0x040010D9 RID: 4313
		private Rect originViewPort;

		// Token: 0x02000172 RID: 370
		public enum CameraAnchor
		{
			// Token: 0x040013B0 RID: 5040
			Center,
			// Token: 0x040013B1 RID: 5041
			Top,
			// Token: 0x040013B2 RID: 5042
			Bottom,
			// Token: 0x040013B3 RID: 5043
			Left,
			// Token: 0x040013B4 RID: 5044
			Right,
			// Token: 0x040013B5 RID: 5045
			TopLeft,
			// Token: 0x040013B6 RID: 5046
			TopRight,
			// Token: 0x040013B7 RID: 5047
			BottomLeft,
			// Token: 0x040013B8 RID: 5048
			BottomRight
		}
	}
}
