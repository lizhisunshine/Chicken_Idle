using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

// Token: 0x02000022 RID: 34
public class AudioManager : MonoBehaviour
{
	// Token: 0x060000D0 RID: 208 RVA: 0x00012B56 File Offset: 0x00010D56
	private IEnumerator Wait()
	{
		yield return new WaitForSeconds(0.2f);
		this.PlaySong(1);
		yield break;
	}

	// Token: 0x060000D1 RID: 209 RVA: 0x00012B68 File Offset: 0x00010D68
	public void Awake()
	{
		AudioManager.Instance = this;
		base.StartCoroutine(this.Wait());
		foreach (Sounds sounds in this.sounds)
		{
			sounds.source = base.gameObject.AddComponent<AudioSource>();
			sounds.source.clip = sounds.audioClip;
			sounds.source.volume = sounds.volume;
			sounds.source.pitch = sounds.pitch;
			sounds.source.loop = sounds.Loop;
			Sounds.AudioTypes audioType = sounds.audioType;
			if (audioType != Sounds.AudioTypes.soundEffect)
			{
				if (audioType == Sounds.AudioTypes.music)
				{
					sounds.source.outputAudioMixerGroup = this.musicEffectGroup;
				}
			}
			else
			{
				sounds.source.outputAudioMixerGroup = this.soundEffectsGroup;
			}
		}
	}

	// Token: 0x060000D2 RID: 210 RVA: 0x00012C30 File Offset: 0x00010E30
	public void FixedUpdate()
	{
		foreach (Sounds sounds in this.sounds)
		{
			sounds.source.volume = sounds.volume;
			sounds.source.pitch = sounds.pitch;
		}
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x00012C78 File Offset: 0x00010E78
	public void Stop(string name)
	{
		Sounds sounds = Array.Find<Sounds>(this.sounds, (Sounds sound) => sound.clipName == name);
		if (sounds == null)
		{
			Debug.LogWarning("Sound clip not found: " + name);
			return;
		}
		if (sounds.source.isPlaying)
		{
			sounds.source.Stop();
		}
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x00012CDC File Offset: 0x00010EDC
	public void Play(string name)
	{
		Sounds sounds = Array.Find<Sounds>(this.sounds, (Sounds sound) => sound.clipName == name);
		if (name == "HoverUI")
		{
			sounds.pitch = Random.Range(0.9f, 1.1f);
		}
		else if (name == "UI_Click1")
		{
			sounds.pitch = Random.Range(0.9f, 1.1f);
		}
		else if (name == "Click_1")
		{
			sounds.pitch = Random.Range(0.9f, 1.1f);
		}
		else if (name == "FadeIn")
		{
			sounds.pitch = Random.Range(0.87f, 1.12f);
		}
		else
		{
			name == "Wave";
		}
		if (sounds == null)
		{
			Debug.LogWarning("Sound clip not found: " + name);
			return;
		}
		sounds.source.Play();
		if (name == "Music1" || name == "Music2" || name == "Music3")
		{
			base.StartCoroutine(this.WaitForSongToEnd(name));
			base.StartCoroutine(this.MonitorAudioClipEnd(name, sounds.source.clip.length));
		}
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x00012E56 File Offset: 0x00011056
	private IEnumerator WaitForSongToEnd(string songName)
	{
		Sounds s = Array.Find<Sounds>(this.sounds, (Sounds sound) => sound.clipName == songName);
		if (s == null)
		{
			Debug.LogWarning("Sound clip not found: " + songName);
			yield break;
		}
		while (s.source.isPlaying)
		{
			yield return null;
		}
		this.PlaySong(this.songNumber);
		yield break;
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x00012E6C File Offset: 0x0001106C
	private IEnumerator MonitorAudioClipEnd(string clipName, float clipLength)
	{
		float endTime = Time.time + clipLength;
		while (Time.time < endTime)
		{
			yield return null;
		}
		yield break;
	}

	// Token: 0x060000D7 RID: 215 RVA: 0x00012E7C File Offset: 0x0001107C
	public void UpdateMixerVolume()
	{
		this.musicEffectGroup.audioMixer.SetFloat("Music Volume", Mathf.Log10(AudioOptionsManager.musicVolume) * 20f);
		this.soundEffectsGroup.audioMixer.SetFloat("Audio Volume", Mathf.Log10(AudioOptionsManager.soundEffectolume) * 20f);
	}

	// Token: 0x060000D8 RID: 216 RVA: 0x00012ED8 File Offset: 0x000110D8
	public void ChangeVolume(string name, float newVolume)
	{
		Sounds sounds = Array.Find<Sounds>(this.sounds, (Sounds sound) => sound.clipName == name);
		if (sounds == null)
		{
			Debug.LogWarning("Sound clip not found: " + name);
			return;
		}
		sounds.volume = Mathf.Clamp01(newVolume);
		sounds.source.volume = sounds.volume;
		sounds.source.volume = sounds.volume;
	}

	// Token: 0x060000D9 RID: 217 RVA: 0x00012F51 File Offset: 0x00011151
	public void PlaySong(int songNumber)
	{
		if (songNumber == 1)
		{
			this.Play("MainMenuMusic");
		}
		if (songNumber == 2)
		{
			this.Play("MainMenuMusic");
		}
	}

	// Token: 0x060000DA RID: 218 RVA: 0x00012F71 File Offset: 0x00011171
	private IEnumerator CheckSongPlaying(int songNumber)
	{
		float startTime = Time.realtimeSinceStartup;
		float elapsedTime = 0f;
		while (elapsedTime < AudioManager.musicLength)
		{
			elapsedTime = Time.realtimeSinceStartup - startTime;
			Debug.Log("Time Remaining: " + (AudioManager.musicLength - elapsedTime).ToString("F2") + " seconds");
			yield return null;
		}
		AudioManager.music1Playing = false;
		AudioManager.music2Playing = false;
		AudioManager.music3Playing = false;
		int num;
		do
		{
			num = Random.Range(1, 4);
		}
		while (num == songNumber);
		if (num == 1)
		{
			this.Play("Music1");
			AudioManager.music1Playing = true;
		}
		if (num == 2)
		{
			this.Play("Music2");
			AudioManager.music2Playing = true;
		}
		if (num == 3)
		{
			this.Play("Music3");
			AudioManager.music3Playing = true;
		}
		this.PlayNewsong(num);
		this.waitForSongCoroutine = null;
		yield break;
	}

	// Token: 0x060000DB RID: 219 RVA: 0x00012F87 File Offset: 0x00011187
	public void PlayNewsong(int songNumber)
	{
		base.StartCoroutine(this.CheckSongPlaying(songNumber));
	}

	// Token: 0x060000DC RID: 220 RVA: 0x00012F97 File Offset: 0x00011197
	public void StopSongTimer()
	{
		if (this.waitForSongCoroutine != null)
		{
			base.StopCoroutine(this.waitForSongCoroutine);
			this.waitForSongCoroutine = null;
		}
	}

	// Token: 0x0400043A RID: 1082
	[SerializeField]
	private AudioMixerGroup musicEffectGroup;

	// Token: 0x0400043B RID: 1083
	[SerializeField]
	private AudioMixerGroup soundEffectsGroup;

	// Token: 0x0400043C RID: 1084
	public static AudioManager Instance;

	// Token: 0x0400043D RID: 1085
	public Sounds[] sounds;

	// Token: 0x0400043E RID: 1086
	private Dictionary<string, float> musicPlaybackPositions = new Dictionary<string, float>();

	// Token: 0x0400043F RID: 1087
	public int songNumber;

	// Token: 0x04000440 RID: 1088
	public Coroutine waitForSongCoroutine;

	// Token: 0x04000441 RID: 1089
	public static bool music1Playing;

	// Token: 0x04000442 RID: 1090
	public static bool music2Playing;

	// Token: 0x04000443 RID: 1091
	public static bool music3Playing;

	// Token: 0x04000444 RID: 1092
	public static float musicLength;
}
