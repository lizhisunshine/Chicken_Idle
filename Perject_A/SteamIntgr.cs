using System;
using Steamworks;
using UnityEngine;

// Token: 0x0200003B RID: 59
public class SteamIntgr : MonoBehaviour
{
	// Token: 0x060001EC RID: 492 RVA: 0x00052AAD File Offset: 0x00050CAD
	public void Awake()
	{
		SteamIntgr.noSteamInt = false;
	}

	// Token: 0x060001ED RID: 493 RVA: 0x00052AB8 File Offset: 0x00050CB8
	private void Start()
	{
		if (!SteamIntgr.noSteamInt)
		{
			try
			{
				SteamClient.Init(3769130U, true);
			}
			catch (Exception message)
			{
				Debug.Log(message);
			}
		}
	}

	// Token: 0x060001EE RID: 494 RVA: 0x00052AF0 File Offset: 0x00050CF0
	private void Update()
	{
		if (!SteamIntgr.noSteamInt)
		{
			SteamClient.RunCallbacks();
		}
	}

	// Token: 0x060001EF RID: 495 RVA: 0x00052AFE File Offset: 0x00050CFE
	private void OnApplicationQuit()
	{
		if (!SteamIntgr.noSteamInt)
		{
			SteamClient.Shutdown();
		}
	}

	// Token: 0x04000E17 RID: 3607
	public static bool noSteamInt;
}
