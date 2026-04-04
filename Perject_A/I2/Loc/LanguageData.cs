using System;

namespace I2.Loc
{
	// Token: 0x0200007B RID: 123
	[Serializable]
	public class LanguageData
	{
		// Token: 0x06000345 RID: 837 RVA: 0x0005DD04 File Offset: 0x0005BF04
		public bool IsEnabled()
		{
			return (this.Flags & 1) == 0;
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0005DD11 File Offset: 0x0005BF11
		public void SetEnabled(bool bEnabled)
		{
			if (bEnabled)
			{
				this.Flags = (byte)((int)this.Flags & -2);
				return;
			}
			this.Flags |= 1;
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0005DD36 File Offset: 0x0005BF36
		public bool IsLoaded()
		{
			return (this.Flags & 4) == 0;
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0005DD43 File Offset: 0x0005BF43
		public bool CanBeUnloaded()
		{
			return (this.Flags & 2) == 0;
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0005DD50 File Offset: 0x0005BF50
		public void SetLoaded(bool loaded)
		{
			if (loaded)
			{
				this.Flags = (byte)((int)this.Flags & -5);
				return;
			}
			this.Flags |= 4;
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0005DD75 File Offset: 0x0005BF75
		public void SetCanBeUnLoaded(bool allowUnloading)
		{
			if (allowUnloading)
			{
				this.Flags = (byte)((int)this.Flags & -3);
				return;
			}
			this.Flags |= 2;
		}

		// Token: 0x04000F67 RID: 3943
		public string Name;

		// Token: 0x04000F68 RID: 3944
		public string Code;

		// Token: 0x04000F69 RID: 3945
		public byte Flags;

		// Token: 0x04000F6A RID: 3946
		[NonSerialized]
		public bool Compressed;
	}
}
