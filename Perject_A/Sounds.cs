using System;
using UnityEngine;

// Token: 0x02000025 RID: 37
[Serializable]
public class Sounds
{
	// Token: 0x0400045C RID: 1116
	public string clipName;

	// Token: 0x0400045D RID: 1117
	public Sounds.AudioTypes audioType;

	// Token: 0x0400045E RID: 1118
	[HideInInspector]
	public AudioSource source;

	// Token: 0x0400045F RID: 1119
	public AudioClip audioClip;

	// Token: 0x04000460 RID: 1120
	[Range(0f, 1f)]
	public float volume;

	// Token: 0x04000461 RID: 1121
	[Range(0.1f, 3f)]
	public float pitch;

	// Token: 0x04000462 RID: 1122
	public bool Loop;

	// Token: 0x04000463 RID: 1123
	[HideInInspector]
	public float playbackPosition;

	// Token: 0x020000F6 RID: 246
	public enum AudioTypes
	{
		// Token: 0x0400119A RID: 4506
		soundEffect,
		// Token: 0x0400119B RID: 4507
		music
	}
}
