using System;
using UnityEngine;

namespace AutoLetterbox
{
	// Token: 0x020000C7 RID: 199
	public class Demo : MonoBehaviour
	{
		// Token: 0x060005CB RID: 1483 RVA: 0x00069AE8 File Offset: 0x00067CE8
		private void Awake()
		{
			this.currentDefault = this.startingDefault;
			this.EnableCameras(this.singlePlayerCameras, true);
			this.EnableCameras(this.twoPlayerCameras, false);
			this.EnableCameras(this.fourPlayerCameras, false);
			this.EnableCameras(this.crazyCameras, false);
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00069B38 File Offset: 0x00067D38
		private void EnableCameras(Camera[] _cameras, bool _enable)
		{
			for (int i = 0; i < _cameras.Length; i++)
			{
				_cameras[i].enabled = _enable;
			}
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00069B5C File Offset: 0x00067D5C
		private void OnGUI()
		{
			if (Input.mousePosition.x < 0f || Input.mousePosition.x > 120f || Input.mousePosition.y < 0f || Input.mousePosition.y > (float)Screen.height)
			{
				this.guiColorProgress = Util.Clamp(0.2f, 1f, this.guiColorProgress - Time.deltaTime * 2f);
			}
			else
			{
				this.guiColorProgress = Util.Clamp(0.2f, 1f, this.guiColorProgress + Time.deltaTime * 2f);
			}
			GUI.color = Color.Lerp(this.guiOffColor, this.guiOnColor, this.guiColorProgress);
			GUI.Label(new Rect(10f, 10f, 100f, 25f), "Camera Ratio:");
			string s = GUI.TextField(new Rect(10f, 35f, 45f, 25f), this.forceRatio.ratio.x.ToString());
			string s2 = GUI.TextField(new Rect(65f, 35f, 45f, 25f), this.forceRatio.ratio.y.ToString());
			bool flag = false;
			if (GUI.Button(new Rect(10f, 70f, 45f, 25f), "<"))
			{
				flag = true;
				this.currentDefault--;
				if (this.currentDefault < 0)
				{
					this.currentDefault = this.defaultRatios.Length - 1;
				}
				this.forceRatio.ratio = new Vector2(this.defaultRatios[this.currentDefault].x, this.defaultRatios[this.currentDefault].y);
			}
			if (GUI.Button(new Rect(65f, 70f, 45f, 25f), ">"))
			{
				flag = true;
				this.currentDefault++;
				if (this.currentDefault >= this.defaultRatios.Length)
				{
					this.currentDefault = 0;
				}
				this.forceRatio.ratio = new Vector2(this.defaultRatios[this.currentDefault].x, this.defaultRatios[this.currentDefault].y);
			}
			float x;
			float y;
			if (!flag && float.TryParse(s, out x) && float.TryParse(s2, out y))
			{
				this.forceRatio.ratio = new Vector2(x, y);
			}
			if (GUI.Button(new Rect(10f, 105f, 100f, 25f), "Single Camera"))
			{
				this.EnableCameras(this.singlePlayerCameras, true);
				this.EnableCameras(this.twoPlayerCameras, false);
				this.EnableCameras(this.fourPlayerCameras, false);
				this.EnableCameras(this.crazyCameras, false);
			}
			if (GUI.Button(new Rect(10f, 140f, 100f, 25f), "Two Player"))
			{
				this.EnableCameras(this.singlePlayerCameras, false);
				this.EnableCameras(this.twoPlayerCameras, true);
				this.EnableCameras(this.fourPlayerCameras, false);
				this.EnableCameras(this.crazyCameras, false);
			}
			if (GUI.Button(new Rect(10f, 175f, 100f, 25f), "Four Player"))
			{
				this.EnableCameras(this.singlePlayerCameras, false);
				this.EnableCameras(this.twoPlayerCameras, false);
				this.EnableCameras(this.fourPlayerCameras, true);
				this.EnableCameras(this.crazyCameras, false);
			}
			if (GUI.Button(new Rect(10f, 215f, 100f, 25f), "Various Angles"))
			{
				this.EnableCameras(this.singlePlayerCameras, false);
				this.EnableCameras(this.twoPlayerCameras, false);
				this.EnableCameras(this.fourPlayerCameras, false);
				this.EnableCameras(this.crazyCameras, true);
			}
			GUI.Label(new Rect(10f, 250f, 100f, 25f), "Letterbox Color");
			string text;
			if (this.forceRatio.letterBoxCameraColor.r == 0f)
			{
				text = "";
			}
			else
			{
				text = (this.forceRatio.letterBoxCameraColor.r * 255f).ToString();
			}
			string text2;
			if (this.forceRatio.letterBoxCameraColor.g == 0f)
			{
				text2 = "";
			}
			else
			{
				text2 = (this.forceRatio.letterBoxCameraColor.g * 255f).ToString();
			}
			string text3;
			if (this.forceRatio.letterBoxCameraColor.b == 0f)
			{
				text3 = "";
			}
			else
			{
				text3 = (this.forceRatio.letterBoxCameraColor.b * 255f).ToString();
			}
			string text4 = GUI.TextField(new Rect(10f, 275f, 35f, 25f), text);
			string text5 = GUI.TextField(new Rect(45f, 275f, 35f, 25f), text2);
			string text6 = GUI.TextField(new Rect(80f, 275f, 35f, 25f), text3);
			if (text4 == "")
			{
				text4 = "0";
			}
			if (text5 == "")
			{
				text5 = "0";
			}
			if (text6 == "")
			{
				text6 = "0";
			}
			float num;
			float num2;
			float num3;
			if (float.TryParse(text4, out num) && float.TryParse(text5, out num2) && float.TryParse(text6, out num3))
			{
				if (num > 0f)
				{
					num /= 255f;
				}
				else
				{
					num = 0f;
				}
				if (num2 > 0f)
				{
					num2 /= 255f;
				}
				else
				{
					num2 = 0f;
				}
				if (num3 > 0f)
				{
					num3 /= 255f;
				}
				else
				{
					num3 = 0f;
				}
				this.forceRatio.letterBoxCameraColor = new Color(Util.Clamp(0f, 1f, num), Util.Clamp(0f, 1f, num2), Util.Clamp(0f, 1f, num3), 1f);
			}
		}

		// Token: 0x040010C3 RID: 4291
		public ForceCameraRatio forceRatio;

		// Token: 0x040010C4 RID: 4292
		public Camera[] fourPlayerCameras;

		// Token: 0x040010C5 RID: 4293
		public Camera[] twoPlayerCameras;

		// Token: 0x040010C6 RID: 4294
		public Camera[] singlePlayerCameras;

		// Token: 0x040010C7 RID: 4295
		public Camera[] crazyCameras;

		// Token: 0x040010C8 RID: 4296
		public int startingDefault;

		// Token: 0x040010C9 RID: 4297
		public Vector2[] defaultRatios;

		// Token: 0x040010CA RID: 4298
		private Color guiOnColor = new Color(1f, 1f, 1f, 1f);

		// Token: 0x040010CB RID: 4299
		private Color guiOffColor = new Color(1f, 1f, 1f, 0.2f);

		// Token: 0x040010CC RID: 4300
		private float guiColorProgress = 1f;

		// Token: 0x040010CD RID: 4301
		private int currentDefault;
	}
}
