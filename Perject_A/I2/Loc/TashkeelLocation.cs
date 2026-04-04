using System;

namespace I2.Loc
{
	// Token: 0x020000AD RID: 173
	internal class TashkeelLocation
	{
		// Token: 0x06000503 RID: 1283 RVA: 0x00065F74 File Offset: 0x00064174
		public TashkeelLocation(char tashkeel, int position)
		{
			this.tashkeel = tashkeel;
			this.position = position;
		}

		// Token: 0x04001066 RID: 4198
		public char tashkeel;

		// Token: 0x04001067 RID: 4199
		public int position;
	}
}
