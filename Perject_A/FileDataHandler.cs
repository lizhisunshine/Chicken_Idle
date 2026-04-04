using System;
using System.IO;
using UnityEngine;

// Token: 0x02000031 RID: 49
public class FileDataHandler
{
	// Token: 0x0600017D RID: 381 RVA: 0x0003E2B6 File Offset: 0x0003C4B6
	public FileDataHandler(string dataDirPath, string dataFileName)
	{
		this.dataDirPath = dataDirPath;
		this.dataFileName = dataFileName;
	}

	// Token: 0x0600017E RID: 382 RVA: 0x0003E2F0 File Offset: 0x0003C4F0
	public GameData Load(string profileId, bool allowRestoreFromBackup = true)
	{
		string text = Path.Combine(this.dataDirPath, profileId, this.dataFileName);
		GameData result = null;
		if (File.Exists(text))
		{
			try
			{
				string json = "";
				using (FileStream fileStream = new FileStream(text, FileMode.Open))
				{
					using (StreamReader streamReader = new StreamReader(fileStream))
					{
						json = streamReader.ReadToEnd();
					}
				}
				result = JsonUtility.FromJson<GameData>(json);
			}
			catch (Exception ex)
			{
				if (allowRestoreFromBackup)
				{
					string str = "Failed to load data file. Attempting to roll back.\n";
					Exception ex2 = ex;
					Debug.LogWarning(str + ((ex2 != null) ? ex2.ToString() : null));
					if (this.AttemptRollback(text))
					{
						result = this.Load(profileId, false);
					}
				}
				else
				{
					string str2 = "Error occured when trying to load file at path: ";
					string str3 = text;
					string str4 = " and backup did not work.\n";
					Exception ex3 = ex;
					Debug.Log(str2 + str3 + str4 + ((ex3 != null) ? ex3.ToString() : null));
				}
			}
		}
		return result;
	}

	// Token: 0x0600017F RID: 383 RVA: 0x0003E3E4 File Offset: 0x0003C5E4
	public void Save(GameData data, string profileId)
	{
		string text = Path.Combine(this.dataDirPath, profileId, this.dataFileName);
		string destFileName = text + this.backUpExtension;
		try
		{
			if (DataPersistenceManager.saveIncrement == 1)
			{
				Directory.CreateDirectory(Path.GetDirectoryName(text));
				string value = JsonUtility.ToJson(data, true);
				using (FileStream fileStream = new FileStream(text, FileMode.Create))
				{
					using (StreamWriter streamWriter = new StreamWriter(fileStream))
					{
						streamWriter.Write(value);
					}
				}
			}
			if (DataPersistenceManager.saveIncrement == 2)
			{
				if (this.Load(profileId, true) == null)
				{
					throw new Exception("Save file could not be verified and backup could not be created.");
				}
				File.Copy(text, destFileName, true);
				DataPersistenceManager.saveIncrement = 0;
			}
		}
		catch (Exception ex)
		{
			string str = "Error occured when trying to save data to file: ";
			string str2 = text;
			string str3 = "\n";
			Exception ex2 = ex;
			Debug.LogError(str + str2 + str3 + ((ex2 != null) ? ex2.ToString() : null));
		}
	}

	// Token: 0x06000180 RID: 384 RVA: 0x0003E4E0 File Offset: 0x0003C6E0
	private bool AttemptRollback(string fullPath)
	{
		bool result = false;
		string text = fullPath + this.backUpExtension;
		try
		{
			if (!File.Exists(text))
			{
				throw new Exception("Tried to roll back, but to backup file exists to roll back to");
			}
			FileDataHandler.hadToBackup = true;
			File.Copy(text, fullPath, true);
			result = true;
			Debug.LogWarning("Had to roll back to backup file at: " + text);
		}
		catch (Exception ex)
		{
			string str = "Error occured when tryinh to roll back to backup file at: ";
			string str2 = text;
			string str3 = "\n";
			Exception ex2 = ex;
			Debug.LogError(str + str2 + str3 + ((ex2 != null) ? ex2.ToString() : null));
		}
		return result;
	}

	// Token: 0x04000735 RID: 1845
	private string dataDirPath = "";

	// Token: 0x04000736 RID: 1846
	private string dataFileName = "";

	// Token: 0x04000737 RID: 1847
	private readonly string backUpExtension = ".bak";

	// Token: 0x04000738 RID: 1848
	public static bool hadToBackup;
}
