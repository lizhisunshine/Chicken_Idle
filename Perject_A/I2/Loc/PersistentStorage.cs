using System;

namespace I2.Loc
{
	// Token: 0x0200006A RID: 106
	public static class PersistentStorage
	{
		// Token: 0x060002DE RID: 734 RVA: 0x00057F2F File Offset: 0x0005612F
		public static void SetSetting_String(string key, string value)
		{
			if (PersistentStorage.mStorage == null)
			{
				PersistentStorage.mStorage = new I2CustomPersistentStorage();
			}
			PersistentStorage.mStorage.SetSetting_String(key, value);
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00057F4E File Offset: 0x0005614E
		public static string GetSetting_String(string key, string defaultValue)
		{
			if (PersistentStorage.mStorage == null)
			{
				PersistentStorage.mStorage = new I2CustomPersistentStorage();
			}
			return PersistentStorage.mStorage.GetSetting_String(key, defaultValue);
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00057F6D File Offset: 0x0005616D
		public static void DeleteSetting(string key)
		{
			if (PersistentStorage.mStorage == null)
			{
				PersistentStorage.mStorage = new I2CustomPersistentStorage();
			}
			PersistentStorage.mStorage.DeleteSetting(key);
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00057F8B File Offset: 0x0005618B
		public static bool HasSetting(string key)
		{
			if (PersistentStorage.mStorage == null)
			{
				PersistentStorage.mStorage = new I2CustomPersistentStorage();
			}
			return PersistentStorage.mStorage.HasSetting(key);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00057FA9 File Offset: 0x000561A9
		public static void ForceSaveSettings()
		{
			if (PersistentStorage.mStorage == null)
			{
				PersistentStorage.mStorage = new I2CustomPersistentStorage();
			}
			PersistentStorage.mStorage.ForceSaveSettings();
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00057FC6 File Offset: 0x000561C6
		public static bool CanAccessFiles()
		{
			if (PersistentStorage.mStorage == null)
			{
				PersistentStorage.mStorage = new I2CustomPersistentStorage();
			}
			return PersistentStorage.mStorage.CanAccessFiles();
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00057FE3 File Offset: 0x000561E3
		public static bool SaveFile(PersistentStorage.eFileType fileType, string fileName, string data, bool logExceptions = true)
		{
			if (PersistentStorage.mStorage == null)
			{
				PersistentStorage.mStorage = new I2CustomPersistentStorage();
			}
			return PersistentStorage.mStorage.SaveFile(fileType, fileName, data, logExceptions);
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00058004 File Offset: 0x00056204
		public static string LoadFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
			if (PersistentStorage.mStorage == null)
			{
				PersistentStorage.mStorage = new I2CustomPersistentStorage();
			}
			return PersistentStorage.mStorage.LoadFile(fileType, fileName, logExceptions);
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00058024 File Offset: 0x00056224
		public static bool DeleteFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
			if (PersistentStorage.mStorage == null)
			{
				PersistentStorage.mStorage = new I2CustomPersistentStorage();
			}
			return PersistentStorage.mStorage.DeleteFile(fileType, fileName, logExceptions);
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00058044 File Offset: 0x00056244
		public static bool HasFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
			if (PersistentStorage.mStorage == null)
			{
				PersistentStorage.mStorage = new I2CustomPersistentStorage();
			}
			return PersistentStorage.mStorage.HasFile(fileType, fileName, logExceptions);
		}

		// Token: 0x04000F38 RID: 3896
		private static I2CustomPersistentStorage mStorage;

		// Token: 0x0200014A RID: 330
		public enum eFileType
		{
			// Token: 0x04001334 RID: 4916
			Raw,
			// Token: 0x04001335 RID: 4917
			Persistent,
			// Token: 0x04001336 RID: 4918
			Temporal,
			// Token: 0x04001337 RID: 4919
			Streaming
		}
	}
}
