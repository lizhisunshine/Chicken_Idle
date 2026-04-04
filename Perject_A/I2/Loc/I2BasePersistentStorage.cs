using System;
using System.Globalization;
using System.IO;
using System.Text;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x0200006B RID: 107
	public abstract class I2BasePersistentStorage
	{
		// Token: 0x060002E8 RID: 744 RVA: 0x00058064 File Offset: 0x00056264
		public virtual void SetSetting_String(string key, string value)
		{
			try
			{
				int length = value.Length;
				int num = 8000;
				if (length <= num)
				{
					PlayerPrefs.SetString(key, value);
				}
				else
				{
					int num2 = Mathf.CeilToInt((float)length / (float)num);
					for (int i = 0; i < num2; i++)
					{
						int num3 = num * i;
						PlayerPrefs.SetString(string.Format("[I2split]{0}{1}", i, key), value.Substring(num3, Mathf.Min(num, length - num3)));
					}
					PlayerPrefs.SetString(key, "[$I2#@div$]" + num2.ToString());
				}
			}
			catch (Exception)
			{
				Debug.LogError("Error saving PlayerPrefs " + key);
			}
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0005810C File Offset: 0x0005630C
		public virtual string GetSetting_String(string key, string defaultValue)
		{
			string result;
			try
			{
				string text = PlayerPrefs.GetString(key, defaultValue);
				if (!string.IsNullOrEmpty(text) && text.StartsWith("[I2split]", StringComparison.Ordinal))
				{
					int num = int.Parse(text.Substring("[I2split]".Length), CultureInfo.InvariantCulture);
					text = "";
					for (int i = 0; i < num; i++)
					{
						text += PlayerPrefs.GetString(string.Format("[I2split]{0}{1}", i, key), "");
					}
				}
				result = text;
			}
			catch (Exception)
			{
				Debug.LogError("Error loading PlayerPrefs " + key);
				result = defaultValue;
			}
			return result;
		}

		// Token: 0x060002EA RID: 746 RVA: 0x000581B0 File Offset: 0x000563B0
		public virtual void DeleteSetting(string key)
		{
			try
			{
				string @string = PlayerPrefs.GetString(key, null);
				if (!string.IsNullOrEmpty(@string) && @string.StartsWith("[I2split]", StringComparison.Ordinal))
				{
					int num = int.Parse(@string.Substring("[I2split]".Length), CultureInfo.InvariantCulture);
					for (int i = 0; i < num; i++)
					{
						PlayerPrefs.DeleteKey(string.Format("[I2split]{0}{1}", i, key));
					}
				}
				PlayerPrefs.DeleteKey(key);
			}
			catch (Exception)
			{
				Debug.LogError("Error deleting PlayerPrefs " + key);
			}
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00058244 File Offset: 0x00056444
		public virtual void ForceSaveSettings()
		{
			PlayerPrefs.Save();
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0005824B File Offset: 0x0005644B
		public virtual bool HasSetting(string key)
		{
			return PlayerPrefs.HasKey(key);
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00058253 File Offset: 0x00056453
		public virtual bool CanAccessFiles()
		{
			return true;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00058258 File Offset: 0x00056458
		private string UpdateFilename(PersistentStorage.eFileType fileType, string fileName)
		{
			switch (fileType)
			{
			case PersistentStorage.eFileType.Persistent:
				fileName = Application.persistentDataPath + "/" + fileName;
				break;
			case PersistentStorage.eFileType.Temporal:
				fileName = Application.temporaryCachePath + "/" + fileName;
				break;
			case PersistentStorage.eFileType.Streaming:
				fileName = Application.streamingAssetsPath + "/" + fileName;
				break;
			}
			return fileName;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x000582B8 File Offset: 0x000564B8
		public virtual bool SaveFile(PersistentStorage.eFileType fileType, string fileName, string data, bool logExceptions = true)
		{
			if (!this.CanAccessFiles())
			{
				return false;
			}
			bool result;
			try
			{
				fileName = this.UpdateFilename(fileType, fileName);
				File.WriteAllText(fileName, data, Encoding.UTF8);
				result = true;
			}
			catch (Exception ex)
			{
				if (logExceptions)
				{
					string str = "Error saving file '";
					string str2 = fileName;
					string str3 = "'\n";
					Exception ex2 = ex;
					Debug.LogError(str + str2 + str3 + ((ex2 != null) ? ex2.ToString() : null));
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00058328 File Offset: 0x00056528
		public virtual string LoadFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
			if (!this.CanAccessFiles())
			{
				return null;
			}
			string result;
			try
			{
				fileName = this.UpdateFilename(fileType, fileName);
				result = File.ReadAllText(fileName, Encoding.UTF8);
			}
			catch (Exception ex)
			{
				if (logExceptions)
				{
					string str = "Error loading file '";
					string str2 = fileName;
					string str3 = "'\n";
					Exception ex2 = ex;
					Debug.LogError(str + str2 + str3 + ((ex2 != null) ? ex2.ToString() : null));
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00058394 File Offset: 0x00056594
		public virtual bool DeleteFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
			if (!this.CanAccessFiles())
			{
				return false;
			}
			bool result;
			try
			{
				fileName = this.UpdateFilename(fileType, fileName);
				File.Delete(fileName);
				result = true;
			}
			catch (Exception ex)
			{
				if (logExceptions)
				{
					string str = "Error deleting file '";
					string str2 = fileName;
					string str3 = "'\n";
					Exception ex2 = ex;
					Debug.LogError(str + str2 + str3 + ((ex2 != null) ? ex2.ToString() : null));
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x000583FC File Offset: 0x000565FC
		public virtual bool HasFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
			if (!this.CanAccessFiles())
			{
				return false;
			}
			bool result;
			try
			{
				fileName = this.UpdateFilename(fileType, fileName);
				result = File.Exists(fileName);
			}
			catch (Exception ex)
			{
				if (logExceptions)
				{
					string str = "Error requesting file '";
					string str2 = fileName;
					string str3 = "'\n";
					Exception ex2 = ex;
					Debug.LogError(str + str2 + str3 + ((ex2 != null) ? ex2.ToString() : null));
				}
				result = false;
			}
			return result;
		}
	}
}
