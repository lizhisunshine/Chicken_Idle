using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

// Token: 0x02000030 RID: 48
public class DataPersistenceManager : MonoBehaviour
{
	// Token: 0x17000003 RID: 3
	// (get) Token: 0x0600016E RID: 366 RVA: 0x0003E0A6 File Offset: 0x0003C2A6
	// (set) Token: 0x0600016F RID: 367 RVA: 0x0003E0AD File Offset: 0x0003C2AD
	public static DataPersistenceManager instance { get; private set; }

	// Token: 0x06000170 RID: 368 RVA: 0x0003E0B5 File Offset: 0x0003C2B5
	private void Update()
	{
		if (FileDataHandler.hadToBackup)
		{
			FileDataHandler.hadToBackup = false;
		}
	}

	// Token: 0x06000171 RID: 369 RVA: 0x0003E0C4 File Offset: 0x0003C2C4
	private void Awake()
	{
		if (DataPersistenceManager.instance != null)
		{
			Debug.LogError("Found more than one Data Persistance Manager in the scene");
		}
		DataPersistenceManager.instance = this;
		base.StartCoroutine(this.WaitForSaveStuff());
		base.StartCoroutine(this.AutoSave());
	}

	// Token: 0x06000172 RID: 370 RVA: 0x0003E0FD File Offset: 0x0003C2FD
	private IEnumerator AutoSave()
	{
		for (;;)
		{
			yield return new WaitForSeconds(5f);
			this.SaveGame();
		}
		yield break;
	}

	// Token: 0x06000173 RID: 371 RVA: 0x0003E10C File Offset: 0x0003C30C
	private IEnumerator WaitForSaveStuff()
	{
		this.saveForMobile = false;
		yield return new WaitForSeconds(4f);
		this.saveForMobile = true;
		yield break;
	}

	// Token: 0x06000174 RID: 372 RVA: 0x0003E11B File Offset: 0x0003C31B
	private void Start()
	{
		this.dataHandler = new FileDataHandler(Application.persistentDataPath, this.fileName);
		this.dataPersistenceObjects = this.FindAllDataPersistenceObjects();
		this.LoadGame();
	}

	// Token: 0x06000175 RID: 373 RVA: 0x0003E145 File Offset: 0x0003C345
	public void NewGame()
	{
		this.gameDataJSON = new GameData();
	}

	// Token: 0x06000176 RID: 374 RVA: 0x0003E154 File Offset: 0x0003C354
	public void LoadGame()
	{
		this.gameDataJSON = this.dataHandler.Load("", true);
		if (this.gameDataJSON == null)
		{
			Debug.Log("No data was found. Initialzing data to defaults");
			this.NewGame();
		}
		foreach (IDataPersistence dataPersistence in this.dataPersistenceObjects)
		{
			dataPersistence.LoadData(this.gameDataJSON);
		}
	}

	// Token: 0x06000177 RID: 375 RVA: 0x0003E1DC File Offset: 0x0003C3DC
	public void SaveGame()
	{
		DataPersistenceManager.saveIncrement++;
		if (this.clickSave)
		{
			this.clickSave = false;
			DataPersistenceManager.saveIncrement = 1;
		}
		foreach (IDataPersistence dataPersistence in this.dataPersistenceObjects)
		{
			dataPersistence.SaveData(ref this.gameDataJSON);
		}
		this.dataHandler.Save(this.gameDataJSON, "");
	}

	// Token: 0x06000178 RID: 376 RVA: 0x0003E26C File Offset: 0x0003C46C
	private void OnApplicationQuit()
	{
		this.SaveTheGameData();
	}

	// Token: 0x06000179 RID: 377 RVA: 0x0003E274 File Offset: 0x0003C474
	private void OnApplicationPause(bool pauseStatus)
	{
		if (MobileAndTesting.isMobile && this.saveForMobile && pauseStatus)
		{
			this.SaveTheGameData();
		}
	}

	// Token: 0x0600017A RID: 378 RVA: 0x0003E28E File Offset: 0x0003C48E
	private List<IDataPersistence> FindAllDataPersistenceObjects()
	{
		return new List<IDataPersistence>(Object.FindObjectsOfType<MonoBehaviour>().OfType<IDataPersistence>());
	}

	// Token: 0x0600017B RID: 379 RVA: 0x0003E29F File Offset: 0x0003C49F
	public void SaveTheGameData()
	{
		this.clickSave = true;
		this.SaveGame();
	}

	// Token: 0x0400072A RID: 1834
	[Header("File Storage Config")]
	[SerializeField]
	private string fileName;

	// Token: 0x0400072B RID: 1835
	private GameData gameDataJSON;

	// Token: 0x0400072C RID: 1836
	private List<IDataPersistence> dataPersistenceObjects;

	// Token: 0x0400072D RID: 1837
	private FileDataHandler dataHandler;

	// Token: 0x0400072F RID: 1839
	private bool saveForMobile;

	// Token: 0x04000730 RID: 1840
	public GameObject testingObject;

	// Token: 0x04000731 RID: 1841
	public GameObject saveGamePopUp;

	// Token: 0x04000732 RID: 1842
	public static int saveIncrement;

	// Token: 0x04000733 RID: 1843
	public AudioManager audioManager;

	// Token: 0x04000734 RID: 1844
	public bool clickSave;
}
