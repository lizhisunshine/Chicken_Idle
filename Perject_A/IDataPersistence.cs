using System;

// Token: 0x02000033 RID: 51
public interface IDataPersistence
{
	// Token: 0x0600018C RID: 396
	void LoadData(GameData data);

	// Token: 0x0600018D RID: 397
	void SaveData(ref GameData data);
}
