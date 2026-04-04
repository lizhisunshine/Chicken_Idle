using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

// Token: 0x02000036 RID: 54
public class SettingsOptions : MonoBehaviour, IDataPersistence
{
	// Token: 0x060001B1 RID: 433 RVA: 0x00040758 File Offset: 0x0003E958
	private void Awake()
	{
		this.triggerResolution = true;
		if (!PlayerPrefs.HasKey("saveIndex"))
		{
			this.FindResolutionIndex();
		}
		else
		{
			this.resolutionIndexSave = PlayerPrefs.GetInt("saveIndex");
		}
		if (!PlayerPrefs.HasKey("SaveFullScreen"))
		{
			SettingsOptions.saveFullsScreen = 0;
		}
		else
		{
			SettingsOptions.saveFullsScreen = PlayerPrefs.GetInt("SaveFullScreen");
		}
		if (!MobileAndTesting.isMobile)
		{
			if (SettingsOptions.saveFullsScreen == 1)
			{
				this.fullScreenCheckMark.SetActive(false);
				Screen.fullScreenMode = FullScreenMode.Windowed;
			}
			else
			{
				this.fullScreenCheckMark.SetActive(true);
				Screen.fullScreenMode = FullScreenMode.FullScreenWindow;
			}
			if (!PlayerPrefs.HasKey("ScreenWidth"))
			{
				Screen.fullScreenMode = FullScreenMode.FullScreenWindow;
			}
			else
			{
				this.saveWidth = PlayerPrefs.GetInt("ScreenWidth");
				this.saveHeight = PlayerPrefs.GetInt("ScreenHeight");
				Screen.SetResolution(this.saveWidth, this.saveHeight, Screen.fullScreenMode);
			}
		}
		else
		{
			Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
		}
		base.StartCoroutine(this.Wait());
	}

	// Token: 0x060001B2 RID: 434 RVA: 0x00040847 File Offset: 0x0003EA47
	private IEnumerator Wait()
	{
		yield return new WaitForSeconds(1f);
		if (MobileAndTesting.isMobile)
		{
			this.tooltipAnimToogle.SetActive(false);
			this.googlePlayBtn.SetActive(false);
			this.appStoreBTN.SetActive(false);
			this.settingsFrame.transform.localScale = new Vector2(1.43f, 1.43f);
			this.flags.transform.localPosition = new Vector2(0f, -33f);
			this.flags.transform.localScale = new Vector2(1.6f, 1.6f);
			this.mainMenuBTN.transform.localPosition = new Vector2(0f, -233f);
			this.mainMenuBTN.transform.localScale = new Vector2(0.8f, 0.8f);
			this.resolutionDropdown.gameObject.SetActive(false);
			this.fullscreenBtn.gameObject.SetActive(false);
		}
		else if (SettingsOptions.isTooltipAnimOn)
		{
			this.toogleOffCircle.SetActive(true);
			this.toggleOnCircle.SetActive(false);
		}
		else
		{
			this.toogleOffCircle.SetActive(false);
			this.toggleOnCircle.SetActive(true);
		}
		this.triggerResolution = false;
		yield break;
	}

	// Token: 0x060001B3 RID: 435 RVA: 0x00040858 File Offset: 0x0003EA58
	private void Start()
	{
		this.resolutions = new List<Resolution>
		{
			new Resolution
			{
				width = 800,
				height = 600
			},
			new Resolution
			{
				width = 1024,
				height = 768
			},
			new Resolution
			{
				width = 1280,
				height = 720
			},
			new Resolution
			{
				width = 1280,
				height = 800
			},
			new Resolution
			{
				width = 1280,
				height = 1024
			},
			new Resolution
			{
				width = 1366,
				height = 768
			},
			new Resolution
			{
				width = 1600,
				height = 900
			},
			new Resolution
			{
				width = 1920,
				height = 1080
			},
			new Resolution
			{
				width = 1920,
				height = 1200
			},
			new Resolution
			{
				width = 2560,
				height = 1440
			},
			new Resolution
			{
				width = 2560,
				height = 1600
			},
			new Resolution
			{
				width = 2560,
				height = 1080
			},
			new Resolution
			{
				width = 3440,
				height = 1440
			},
			new Resolution
			{
				width = 3840,
				height = 1440
			},
			new Resolution
			{
				width = 3840,
				height = 2160
			},
			new Resolution
			{
				width = 3840,
				height = 2400
			}
		};
		this.resolutionDropdown.ClearOptions();
		List<string> list = new List<string>();
		int value = 0;
		for (int i = 0; i < this.resolutions.Count; i++)
		{
			string item = this.resolutions[i].width.ToString() + " x " + this.resolutions[i].height.ToString();
			list.Add(item);
			if (this.resolutions[i].width == Screen.currentResolution.width && this.resolutions[i].height == Screen.currentResolution.height)
			{
				value = i;
			}
		}
		this.resolutionDropdown.AddOptions(list);
		this.resolutionDropdown.value = value;
		this.resolutionDropdown.RefreshShownValue();
		this.resolutionDropdown.value = this.resolutionIndexSave;
	}

	// Token: 0x060001B4 RID: 436 RVA: 0x00040BDC File Offset: 0x0003EDDC
	public void SetResolution(int resolutionIndex)
	{
		if (!this.triggerResolution)
		{
			Resolution resolution = this.resolutions[resolutionIndex];
			Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
			this.saveWidth = resolution.width;
			this.saveHeight = resolution.height;
			PlayerPrefs.SetInt("ScreenWidth", this.saveWidth);
			PlayerPrefs.SetInt("ScreenHeight", this.saveHeight);
			this.resolutionIndexSave = resolutionIndex;
			PlayerPrefs.SetInt("saveIndex", this.resolutionIndexSave);
		}
	}

	// Token: 0x060001B5 RID: 437 RVA: 0x00040C68 File Offset: 0x0003EE68
	public void SetFullSCreen()
	{
		this.audioManager.Play("UI_Click1");
		if (SettingsOptions.saveFullsScreen == 0)
		{
			this.fullScreenCheckMark.SetActive(false);
			Screen.fullScreenMode = FullScreenMode.Windowed;
			SettingsOptions.saveFullsScreen = 1;
			PlayerPrefs.SetInt("SaveFullScreen", SettingsOptions.saveFullsScreen);
			return;
		}
		this.fullScreenCheckMark.SetActive(true);
		Screen.fullScreenMode = FullScreenMode.FullScreenWindow;
		int width = 0;
		int height = 0;
		if (this.resolutionIndexSave == 0)
		{
			int width2 = 1024;
			int height2 = 768;
			Screen.SetResolution(width2, height2, FullScreenMode.FullScreenWindow);
			width = 600;
			height = 800;
		}
		if (this.resolutionIndexSave == 1)
		{
			int width3 = 600;
			int height2 = 800;
			Screen.SetResolution(width3, height2, FullScreenMode.FullScreenWindow);
			width = 1024;
			height = 768;
		}
		if (this.resolutionIndexSave == 2)
		{
			int width4 = 1024;
			int height2 = 768;
			Screen.SetResolution(width4, height2, FullScreenMode.FullScreenWindow);
			width = 1280;
			height = 720;
		}
		if (this.resolutionIndexSave == 3)
		{
			int width5 = 1280;
			int height2 = 720;
			Screen.SetResolution(width5, height2, FullScreenMode.FullScreenWindow);
			width = 1280;
			height = 800;
		}
		if (this.resolutionIndexSave == 4)
		{
			int width6 = 1280;
			int height2 = 800;
			Screen.SetResolution(width6, height2, FullScreenMode.FullScreenWindow);
			width = 1280;
			height = 1024;
		}
		if (this.resolutionIndexSave == 5)
		{
			int width7 = 1280;
			int height2 = 1024;
			Screen.SetResolution(width7, height2, FullScreenMode.FullScreenWindow);
			width = 1366;
			height = 768;
		}
		if (this.resolutionIndexSave == 6)
		{
			int width8 = 1366;
			int height2 = 768;
			Screen.SetResolution(width8, height2, FullScreenMode.FullScreenWindow);
			width = 1600;
			height = 900;
		}
		if (this.resolutionIndexSave == 7)
		{
			int width9 = 1600;
			int height2 = 900;
			Screen.SetResolution(width9, height2, FullScreenMode.FullScreenWindow);
			width = 1920;
			height = 1080;
		}
		if (this.resolutionIndexSave == 8)
		{
			int width10 = 1920;
			int height2 = 1080;
			Screen.SetResolution(width10, height2, FullScreenMode.FullScreenWindow);
			width = 1920;
			height = 1200;
		}
		if (this.resolutionIndexSave == 9)
		{
			int width11 = 1920;
			int height2 = 1200;
			Screen.SetResolution(width11, height2, FullScreenMode.FullScreenWindow);
			width = 2560;
			height = 1440;
		}
		if (this.resolutionIndexSave == 10)
		{
			int width12 = 2560;
			int height2 = 1440;
			Screen.SetResolution(width12, height2, FullScreenMode.FullScreenWindow);
			width = 2560;
			height = 1600;
		}
		if (this.resolutionIndexSave == 11)
		{
			int width13 = 2560;
			int height2 = 1600;
			Screen.SetResolution(width13, height2, FullScreenMode.FullScreenWindow);
			width = 2560;
			height = 1080;
		}
		if (this.resolutionIndexSave == 12)
		{
			int width14 = 2560;
			int height2 = 1080;
			Screen.SetResolution(width14, height2, FullScreenMode.FullScreenWindow);
			width = 3440;
			height = 1440;
		}
		if (this.resolutionIndexSave == 13)
		{
			int width15 = 3440;
			int height2 = 1440;
			Screen.SetResolution(width15, height2, FullScreenMode.FullScreenWindow);
			width = 3840;
			height = 1440;
		}
		if (this.resolutionIndexSave == 14)
		{
			int width16 = 3840;
			int height2 = 1440;
			Screen.SetResolution(width16, height2, FullScreenMode.FullScreenWindow);
			width = 3840;
			height = 2160;
		}
		if (this.resolutionIndexSave == 15)
		{
			int width17 = 3840;
			int height2 = 2160;
			Screen.SetResolution(width17, height2, FullScreenMode.FullScreenWindow);
			width = 3840;
			height = 2400;
		}
		Screen.SetResolution(width, height, FullScreenMode.FullScreenWindow);
		SettingsOptions.saveFullsScreen = 0;
		PlayerPrefs.SetInt("SaveFullScreen", SettingsOptions.saveFullsScreen);
	}

	// Token: 0x060001B6 RID: 438 RVA: 0x00040F60 File Offset: 0x0003F160
	public void FindResolutionIndex()
	{
		if (Screen.width == 600 && Screen.height == 800)
		{
			this.resolutionIndexSave = 0;
		}
		if (Screen.width == 1024 && Screen.height == 768)
		{
			this.resolutionIndexSave = 1;
		}
		if (Screen.width == 1280 && Screen.height == 720)
		{
			this.resolutionIndexSave = 2;
		}
		if (Screen.width == 1280 && Screen.height == 800)
		{
			this.resolutionIndexSave = 3;
		}
		if (Screen.width == 1280 && Screen.height == 1024)
		{
			this.resolutionIndexSave = 4;
		}
		if (Screen.width == 1366 && Screen.height == 768)
		{
			this.resolutionIndexSave = 5;
		}
		if (Screen.width == 1600 && Screen.height == 900)
		{
			this.resolutionIndexSave = 6;
		}
		if (Screen.width == 1920 && Screen.height == 1080)
		{
			this.resolutionIndexSave = 7;
		}
		if (Screen.width == 1920 && Screen.height == 1200)
		{
			this.resolutionIndexSave = 8;
		}
		if (Screen.width == 2560 && Screen.height == 1440)
		{
			this.resolutionIndexSave = 9;
		}
		if (Screen.width == 2560 && Screen.height == 1600)
		{
			this.resolutionIndexSave = 10;
		}
		if (Screen.width == 2560 && Screen.height == 1080)
		{
			this.resolutionIndexSave = 11;
		}
		if (Screen.width == 3440 && Screen.height == 1440)
		{
			this.resolutionIndexSave = 12;
		}
		if (Screen.width == 3840 && Screen.height == 1440)
		{
			this.resolutionIndexSave = 13;
		}
		if (Screen.width == 3840 && Screen.height == 2160)
		{
			this.resolutionIndexSave = 14;
		}
		if (Screen.width == 3840 && Screen.height == 2400)
		{
			this.resolutionIndexSave = 15;
		}
	}

	// Token: 0x060001B7 RID: 439 RVA: 0x00041164 File Offset: 0x0003F364
	public void OpenYoutube()
	{
		Application.OpenURL("https://www.youtube.com/@EagleEyeGames");
	}

	// Token: 0x060001B8 RID: 440 RVA: 0x00041170 File Offset: 0x0003F370
	public void OpenDiscord()
	{
		Application.OpenURL("https://discord.gg/qrBGyWkCgJ");
	}

	// Token: 0x060001B9 RID: 441 RVA: 0x0004117C File Offset: 0x0003F37C
	public void OpenSteam()
	{
		Application.OpenURL("https://store.steampowered.com/curator/45970014");
	}

	// Token: 0x060001BA RID: 442 RVA: 0x00041188 File Offset: 0x0003F388
	public void OpenGooglePlay()
	{
		Application.OpenURL("https://play.google.com/store/apps/details?id=com.EagleEyeGames.KeeponMining");
	}

	// Token: 0x060001BB RID: 443 RVA: 0x00041194 File Offset: 0x0003F394
	public void OpenAppStore()
	{
		Application.OpenURL("https://apps.apple.com/us/app/keep-on-mining/id6751413449");
	}

	// Token: 0x060001BC RID: 444 RVA: 0x000411A0 File Offset: 0x0003F3A0
	public void ToggleTooltipAnim()
	{
		this.audioManager.Play("UI_Click1");
		if (!SettingsOptions.isTooltipAnimOn)
		{
			this.toogleOffCircle.SetActive(true);
			this.toggleOnCircle.SetActive(false);
			SettingsOptions.isTooltipAnimOn = true;
			return;
		}
		this.toogleOffCircle.SetActive(false);
		this.toggleOnCircle.SetActive(true);
		SettingsOptions.isTooltipAnimOn = false;
	}

	// Token: 0x060001BD RID: 445 RVA: 0x00041204 File Offset: 0x0003F404
	public void SetTooltipsAnims()
	{
		if (SettingsOptions.isTooltipAnimOn)
		{
			this.theMineSpeedtooltip.enabled = true;
			this.theMineBarsTooltip.enabled = true;
			this.skillTreeTooltip.enabled = true;
			this.talentLeftTooltip.enabled = true;
			this.talentLevelTooltip.enabled = true;
			this.theMineInfoTooltip.enabled = true;
			this.artifactTooltipAnim.enabled = true;
			this.potionTooltip.enabled = true;
			this.flowerTooltip.enabled = true;
			return;
		}
		this.theMineSpeedtooltip.enabled = false;
		this.theMineBarsTooltip.enabled = false;
		this.skillTreeTooltip.enabled = false;
		this.talentLeftTooltip.enabled = false;
		this.talentLevelTooltip.enabled = false;
		this.theMineInfoTooltip.enabled = false;
		this.artifactTooltipAnim.enabled = false;
		this.potionTooltip.enabled = false;
		this.flowerTooltip.enabled = false;
	}

	// Token: 0x060001BE RID: 446 RVA: 0x000412F1 File Offset: 0x0003F4F1
	public void LoadData(GameData data)
	{
		SettingsOptions.isTooltipAnimOn = data.isTooltipAnimOn;
	}

	// Token: 0x060001BF RID: 447 RVA: 0x000412FE File Offset: 0x0003F4FE
	public void SaveData(ref GameData data)
	{
		data.isTooltipAnimOn = SettingsOptions.isTooltipAnimOn;
	}

	// Token: 0x040009D9 RID: 2521
	private List<Resolution> resolutions = new List<Resolution>();

	// Token: 0x040009DA RID: 2522
	public TMP_Dropdown resolutionDropdown;

	// Token: 0x040009DB RID: 2523
	public AudioManager audioManager;

	// Token: 0x040009DC RID: 2524
	public GameObject fullscreenBtn;

	// Token: 0x040009DD RID: 2525
	public GameObject flags;

	// Token: 0x040009DE RID: 2526
	public GameObject mainMenuBTN;

	// Token: 0x040009DF RID: 2527
	public GameObject settingsFrame;

	// Token: 0x040009E0 RID: 2528
	public GameObject googlePlayBtn;

	// Token: 0x040009E1 RID: 2529
	public GameObject appStoreBTN;

	// Token: 0x040009E2 RID: 2530
	public int resolutionIndexSave;

	// Token: 0x040009E3 RID: 2531
	public bool triggerResolution;

	// Token: 0x040009E4 RID: 2532
	public int saveHeight;

	// Token: 0x040009E5 RID: 2533
	public int saveWidth;

	// Token: 0x040009E6 RID: 2534
	public static int saveFullsScreen;

	// Token: 0x040009E7 RID: 2535
	public TextMeshProUGUI fullscreenText;

	// Token: 0x040009E8 RID: 2536
	public GameObject fullScreenCheckMark;

	// Token: 0x040009E9 RID: 2537
	public GameObject tooltipAnimToogle;

	// Token: 0x040009EA RID: 2538
	public GameObject toogleOffCircle;

	// Token: 0x040009EB RID: 2539
	public GameObject toggleOnCircle;

	// Token: 0x040009EC RID: 2540
	public static bool isTooltipAnimOn;

	// Token: 0x040009ED RID: 2541
	public Animation skillTreeTooltip;

	// Token: 0x040009EE RID: 2542
	public Animation talentLeftTooltip;

	// Token: 0x040009EF RID: 2543
	public Animation talentLevelTooltip;

	// Token: 0x040009F0 RID: 2544
	public Animation theMineInfoTooltip;

	// Token: 0x040009F1 RID: 2545
	public Animation artifactTooltipAnim;

	// Token: 0x040009F2 RID: 2546
	public Animation potionTooltip;

	// Token: 0x040009F3 RID: 2547
	public Animation flowerTooltip;

	// Token: 0x040009F4 RID: 2548
	public Animation theMineSpeedtooltip;

	// Token: 0x040009F5 RID: 2549
	public Animation theMineBarsTooltip;
}
