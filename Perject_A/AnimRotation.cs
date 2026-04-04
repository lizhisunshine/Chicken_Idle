using System;
using UnityEngine;

// Token: 0x0200000B RID: 11
public class AnimRotation : MonoBehaviour
{
	// Token: 0x06000035 RID: 53 RVA: 0x00004C35 File Offset: 0x00002E35
	private void Awake()
	{
		this.anim = base.gameObject.GetComponent<Animation>();
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00004C48 File Offset: 0x00002E48
	private void OnEnable()
	{
		base.gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
		if (!MobileAndTesting.isMobile && SettingsOptions.isTooltipAnimOn)
		{
			this.anim.Play();
		}
	}

	// Token: 0x04000159 RID: 345
	public Animation anim;
}
