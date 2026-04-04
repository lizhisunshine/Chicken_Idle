using System;
using UnityEngine;
using UnityEngine.UI;

namespace AutoLetterbox
{
	// Token: 0x020000BD RID: 189
	public class FoodTracker : MonoBehaviour
	{
		// Token: 0x0600059F RID: 1439 RVA: 0x00068800 File Offset: 0x00066A00
		private void Start()
		{
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00068804 File Offset: 0x00066A04
		private void Update()
		{
			for (int i = 0; i < this.textPieces.Length; i++)
			{
				this.textPieces[i].text = (this.dragon.GetFruit() + this.dragon.GetMeat()).ToString();
			}
		}

		// Token: 0x0400108A RID: 4234
		public DragonClass dragon;

		// Token: 0x0400108B RID: 4235
		public Text[] textPieces;
	}
}
