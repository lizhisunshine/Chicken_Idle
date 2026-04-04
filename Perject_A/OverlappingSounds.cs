using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000024 RID: 36
public class OverlappingSounds : MonoBehaviour
{
	// Token: 0x060000E9 RID: 233 RVA: 0x00013186 File Offset: 0x00011386
	private void Awake()
	{
		this.totalSounds = 24;
	}

	// Token: 0x060000EA RID: 234 RVA: 0x00013190 File Offset: 0x00011390
	public void PlaySound(int soundNumber, float currentTime)
	{
		if (OverlappingSounds.theCurrentTime == currentTime)
		{
			return;
		}
		OverlappingSounds.theCurrentTime = currentTime;
		if (this.soundsPlaying >= this.totalSounds)
		{
			return;
		}
		this.soundsPlaying++;
		AudioClip audioClip = null;
		if (soundNumber == 1)
		{
			float pitch = Random.Range(0.94f, 1.25f);
			Random.Range(0.54f, 0.62f);
			this.pickaxeHitSource.pitch = pitch;
			int num = Random.Range(0, 3);
			if (num == 0)
			{
				audioClip = this.pickaxeHitSound1;
			}
			if (num == 1)
			{
				audioClip = this.pickaxeHitSound2;
			}
			if (num == 2)
			{
				audioClip = this.pickaxeHitSound3;
			}
			this.pickaxeHitSource.PlayOneShot(audioClip);
		}
		if (soundNumber == 3)
		{
			audioClip = this.chestHitSound;
			this.rockBreakSource.PlayOneShot(audioClip);
		}
		base.StartCoroutine(this.WaitForSoundToFinish(audioClip.length));
	}

	// Token: 0x060000EB RID: 235 RVA: 0x00013258 File Offset: 0x00011458
	public void PlaySoundRockBreaking(int soundNumber, float currentTime)
	{
		if (OverlappingSounds.currentTimeRockBreaking == currentTime)
		{
			return;
		}
		OverlappingSounds.currentTimeRockBreaking = currentTime;
		if (this.soundsPlaying >= this.totalSounds)
		{
			return;
		}
		this.soundsPlaying++;
		AudioClip audioClip = null;
		if (soundNumber == 1)
		{
			audioClip = this.rockBreakSound1;
			this.rockBreakSource.PlayOneShot(audioClip);
		}
		base.StartCoroutine(this.WaitForSoundToFinish(audioClip.length));
	}

	// Token: 0x060000EC RID: 236 RVA: 0x000132C0 File Offset: 0x000114C0
	public void PlaySoundMaterialCollect(int soundNumber, float currentTime)
	{
		if (OverlappingSounds.currentCollectTime == currentTime)
		{
			return;
		}
		OverlappingSounds.currentCollectTime = currentTime;
		int num = this.soundsPlaying;
		int num2 = this.totalSounds;
		if (soundNumber == 1)
		{
			AudioClip clip = this.popSound1;
			float pitch = Random.Range(0.9f, 1.1f);
			this.popSource.pitch = pitch;
			this.popSource.PlayOneShot(clip);
		}
		if (soundNumber == 2)
		{
			AudioClip clip = this.beamSound1;
			float pitch2 = Random.Range(1.21f, 1.3f);
			if (!LevelMechanics.isZeusActive)
			{
				this.beamSource.PlayOneShot(clip);
				return;
			}
			if (Random.Range(0, 100) < 35)
			{
				this.beamSource.pitch = pitch2;
				this.beamSource.PlayOneShot(clip);
			}
		}
	}

	// Token: 0x060000ED RID: 237 RVA: 0x00013372 File Offset: 0x00011572
	private IEnumerator WaitForSoundToFinish(float clipLength)
	{
		yield return new WaitForSeconds(clipLength);
		this.soundsPlaying--;
		if (this.soundsPlaying < 0)
		{
			this.soundsPlaying = 0;
		}
		yield break;
	}

	// Token: 0x0400044C RID: 1100
	public AudioSource pickaxeHitSource;

	// Token: 0x0400044D RID: 1101
	public AudioClip pickaxeHitSound1;

	// Token: 0x0400044E RID: 1102
	public AudioClip pickaxeHitSound2;

	// Token: 0x0400044F RID: 1103
	public AudioClip pickaxeHitSound3;

	// Token: 0x04000450 RID: 1104
	public AudioSource rockBreakSource;

	// Token: 0x04000451 RID: 1105
	public AudioClip rockBreakSound1;

	// Token: 0x04000452 RID: 1106
	public AudioClip chestHitSound;

	// Token: 0x04000453 RID: 1107
	public AudioSource popSource;

	// Token: 0x04000454 RID: 1108
	public AudioClip popSound1;

	// Token: 0x04000455 RID: 1109
	public AudioSource beamSource;

	// Token: 0x04000456 RID: 1110
	public AudioClip beamSound1;

	// Token: 0x04000457 RID: 1111
	public int totalSounds;

	// Token: 0x04000458 RID: 1112
	public int soundsPlaying;

	// Token: 0x04000459 RID: 1113
	public static float theCurrentTime;

	// Token: 0x0400045A RID: 1114
	public static float currentTimeRockBreaking;

	// Token: 0x0400045B RID: 1115
	public static float currentCollectTime;
}
