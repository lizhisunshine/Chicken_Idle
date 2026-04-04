using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000023 RID: 35
public class AudioOptionsManager : MonoBehaviour
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x060000DE RID: 222 RVA: 0x00012FC7 File Offset: 0x000111C7
	// (set) Token: 0x060000DF RID: 223 RVA: 0x00012FCE File Offset: 0x000111CE
	public static float soundEffectolume { get; private set; }

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x060000E0 RID: 224 RVA: 0x00012FD6 File Offset: 0x000111D6
	// (set) Token: 0x060000E1 RID: 225 RVA: 0x00012FDD File Offset: 0x000111DD
	public static float musicVolume { get; private set; }

	// Token: 0x060000E2 RID: 226 RVA: 0x00012FE8 File Offset: 0x000111E8
	public void Start()
	{
		if (!PlayerPrefs.HasKey("saveAudio"))
		{
			this.audioSlider.value = 0.5f;
		}
		else
		{
			this.audioSlider.value = PlayerPrefs.GetFloat("saveAudio");
		}
		if (!PlayerPrefs.HasKey("saveMusic"))
		{
			this.musicSlider.value = 0.5f;
		}
		else
		{
			this.musicSlider.value = PlayerPrefs.GetFloat("saveMusic");
		}
		this.musicValue = this.musicSlider.value;
		this.audioValue = this.audioSlider.value;
		if (this.audioSlider.value == 0.0001f)
		{
			AudioOptionsManager.soundEffectolume = -80f;
			this.MuteAudio();
			AudioManager.Instance.UpdateMixerVolume();
		}
		if (this.musicSlider.value == 0.0001f)
		{
			AudioOptionsManager.musicVolume = -80f;
			this.MuteAudio();
			AudioManager.Instance.UpdateMixerVolume();
		}
	}

	// Token: 0x060000E3 RID: 227 RVA: 0x000130D5 File Offset: 0x000112D5
	public void OnAudioSliderValueChange(float value)
	{
		AudioOptionsManager.soundEffectolume = value;
		PlayerPrefs.SetFloat("saveAudio", this.audioSlider.value);
		AudioManager.Instance.UpdateMixerVolume();
		this.audioValue = this.audioSlider.value;
	}

	// Token: 0x060000E4 RID: 228 RVA: 0x0001310D File Offset: 0x0001130D
	public void OnMusicSliderValueChance(float value)
	{
		AudioOptionsManager.musicVolume = value;
		PlayerPrefs.SetFloat("saveMusic", this.musicSlider.value);
		AudioManager.Instance.UpdateMixerVolume();
		this.musicValue = this.musicSlider.value;
	}

	// Token: 0x060000E5 RID: 229 RVA: 0x00013145 File Offset: 0x00011345
	private void OnApplicationFocus(bool hasFocus)
	{
		if (!hasFocus)
		{
			AudioOptionsManager.altTabbed = true;
		}
	}

	// Token: 0x060000E6 RID: 230 RVA: 0x00013150 File Offset: 0x00011350
	private void MuteAudio()
	{
	}

	// Token: 0x060000E7 RID: 231 RVA: 0x00013152 File Offset: 0x00011352
	private void UnmuteAudio()
	{
		AudioOptionsManager.soundEffectolume = this.audioValue;
		AudioManager.Instance.UpdateMixerVolume();
		AudioOptionsManager.musicVolume = this.musicValue;
		AudioManager.Instance.UpdateMixerVolume();
	}

	// Token: 0x04000447 RID: 1095
	public Slider audioSlider;

	// Token: 0x04000448 RID: 1096
	public Slider musicSlider;

	// Token: 0x04000449 RID: 1097
	public float musicValue;

	// Token: 0x0400044A RID: 1098
	public float audioValue;

	// Token: 0x0400044B RID: 1099
	public static bool altTabbed;
}
