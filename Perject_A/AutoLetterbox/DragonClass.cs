using System;
using UnityEngine;

namespace AutoLetterbox
{
	// Token: 0x020000BA RID: 186
	public class DragonClass : MonoBehaviour
	{
		// Token: 0x0600058C RID: 1420 RVA: 0x0006847F File Offset: 0x0006667F
		public int GetMeat()
		{
			return this.meat;
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00068487 File Offset: 0x00066687
		public int GetFruit()
		{
			return this.fruit;
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00068490 File Offset: 0x00066690
		public void ApplyScore(int IncomingScore, Feed Diet)
		{
			this.nutritionalValue += IncomingScore;
			if (Diet == Feed.Meat)
			{
				this.meat++;
			}
			if (Diet == Feed.Fruit)
			{
				this.fruit++;
			}
			if (this.munchAudio != null)
			{
				this.munchAudio.pitch = Random.Range(2.5f, 3.5f);
				this.munchAudio.Play();
			}
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00068501 File Offset: 0x00066701
		private void Start()
		{
			this.munchAudio = base.GetComponent<AudioSource>();
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x0006850F File Offset: 0x0006670F
		private void Update()
		{
		}

		// Token: 0x0400107C RID: 4220
		private AudioSource munchAudio;

		// Token: 0x0400107D RID: 4221
		private int meat;

		// Token: 0x0400107E RID: 4222
		private int fruit;

		// Token: 0x0400107F RID: 4223
		private int nutritionalValue;
	}
}
