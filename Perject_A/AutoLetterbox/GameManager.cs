using System;
using UnityEngine;

namespace AutoLetterbox
{
	// Token: 0x020000BE RID: 190
	public class GameManager : MonoBehaviour
	{
		// Token: 0x060005A2 RID: 1442 RVA: 0x00068858 File Offset: 0x00066A58
		private void Start()
		{
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x0006885C File Offset: 0x00066A5C
		private void Update()
		{
			if (this.player.GetMeat() == this.meatToWin || this.player.GetFruit() == this.fruitToWin)
			{
				Debug.Log("You've Won Meat " + this.player.GetMeat().ToString() + " Fruit " + this.player.GetFruit().ToString());
			}
		}

		// Token: 0x0400108C RID: 4236
		public DragonClass player;

		// Token: 0x0400108D RID: 4237
		public int meatToWin = 3;

		// Token: 0x0400108E RID: 4238
		public int fruitToWin = 3;
	}
}
