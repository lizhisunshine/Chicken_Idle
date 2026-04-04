using System;
using UnityEngine;

namespace LayerLab.CasualGame
{
	// Token: 0x02000061 RID: 97
	public class PanelView : MonoBehaviour
	{
		// Token: 0x060002B2 RID: 690 RVA: 0x000573C8 File Offset: 0x000555C8
		public void OnEnable()
		{
			for (int i = 0; i < this.otherPanels.Length; i++)
			{
				this.otherPanels[i].SetActive(true);
			}
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x000573F8 File Offset: 0x000555F8
		public void OnDisable()
		{
			for (int i = 0; i < this.otherPanels.Length; i++)
			{
				this.otherPanels[i].SetActive(false);
			}
		}

		// Token: 0x04000F27 RID: 3879
		[SerializeField]
		private GameObject[] otherPanels;
	}
}
