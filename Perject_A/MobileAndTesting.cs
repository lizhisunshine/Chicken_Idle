using System;
using UnityEngine;

// Token: 0x0200002E RID: 46
public class MobileAndTesting : MonoBehaviour
{
	// Token: 0x06000150 RID: 336 RVA: 0x0003D7AB File Offset: 0x0003B9AB
	private void Awake()
	{
		MobileAndTesting.isMobile = false;
		MobileAndTesting.isTesting = false;
		this.isThisIos = false;
		this.isThisAndroid = false;
	}

	// Token: 0x06000151 RID: 337 RVA: 0x0003D7C8 File Offset: 0x0003B9C8
	private void Start()
	{
		if (MobileAndTesting.isMobile)
		{
			Application.targetFrameRate = 60;
			if (this.isThisIos)
			{
				this.moreAppStore.SetActive(true);
			}
			if (this.isThisAndroid)
			{
				this.moreGooglePlay.SetActive(true);
			}
			this.steam.transform.localPosition = new Vector2(267f, 395f);
			this.discord.transform.localPosition = new Vector2(87f, 395f);
			this.youtube.transform.localPosition = new Vector2(-93f, 395f);
			this.moreAppStore.transform.localPosition = new Vector2(-263f, 395f);
			this.moreGooglePlay.transform.localPosition = new Vector2(-263f, 395f);
			return;
		}
		this.moreGooglePlay.SetActive(false);
		this.moreAppStore.SetActive(false);
	}

	// Token: 0x06000152 RID: 338 RVA: 0x0003D8DB File Offset: 0x0003BADB
	public void MoreAppStoreGames()
	{
		Application.OpenURL("https://apps.apple.com/us/developer/simon-eftest%C3%B8l/id1782530055");
	}

	// Token: 0x06000153 RID: 339 RVA: 0x0003D8E7 File Offset: 0x0003BAE7
	public void MoreGooglePlayGames()
	{
		Application.OpenURL("https://play.google.com/store/apps/developer?id=EagleEye+Games+Norway");
	}

	// Token: 0x040006F7 RID: 1783
	public static bool isTesting;

	// Token: 0x040006F8 RID: 1784
	public static bool isMobile;

	// Token: 0x040006F9 RID: 1785
	public bool isThisIos;

	// Token: 0x040006FA RID: 1786
	public bool isThisAndroid;

	// Token: 0x040006FB RID: 1787
	public GameObject moreGooglePlay;

	// Token: 0x040006FC RID: 1788
	public GameObject moreAppStore;

	// Token: 0x040006FD RID: 1789
	public GameObject youtube;

	// Token: 0x040006FE RID: 1790
	public GameObject discord;

	// Token: 0x040006FF RID: 1791
	public GameObject steam;
}
