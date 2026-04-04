using System;
using UnityEngine;

// Token: 0x0200000F RID: 15
public class FlowerMechanics : MonoBehaviour
{
	// Token: 0x06000047 RID: 71 RVA: 0x000050EC File Offset: 0x000032EC
	private void Awake()
	{
		this.flower1 = base.transform.Find("flower1");
		this.flower2 = base.transform.Find("flower2");
		this.flower3 = base.transform.Find("flower3");
		this.flower4 = base.transform.Find("flower4");
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00005154 File Offset: 0x00003354
	private void OnEnable()
	{
		this.flower1.gameObject.SetActive(false);
		this.flower2.gameObject.SetActive(false);
		this.flower3.gameObject.SetActive(false);
		this.flower4.gameObject.SetActive(false);
		int num = Random.Range(0, 4);
		if (num == 0)
		{
			this.flower1.gameObject.SetActive(true);
		}
		if (num == 1)
		{
			this.flower2.gameObject.SetActive(true);
		}
		if (num == 2)
		{
			this.flower3.gameObject.SetActive(true);
		}
		if (num == 3)
		{
			this.flower4.gameObject.SetActive(true);
		}
	}

	// Token: 0x04000167 RID: 359
	public Transform flower1;

	// Token: 0x04000168 RID: 360
	public Transform flower2;

	// Token: 0x04000169 RID: 361
	public Transform flower3;

	// Token: 0x0400016A RID: 362
	public Transform flower4;
}
