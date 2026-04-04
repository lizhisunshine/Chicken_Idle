using System;

namespace I2.Loc
{
	// Token: 0x02000074 RID: 116
	public class TranslationJob : IDisposable
	{
		// Token: 0x06000330 RID: 816 RVA: 0x0005D492 File Offset: 0x0005B692
		public virtual TranslationJob.eJobState GetState()
		{
			return this.mJobState;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0005D49A File Offset: 0x0005B69A
		public virtual void Dispose()
		{
		}

		// Token: 0x04000F4E RID: 3918
		public TranslationJob.eJobState mJobState;

		// Token: 0x02000150 RID: 336
		public enum eJobState
		{
			// Token: 0x04001343 RID: 4931
			Running,
			// Token: 0x04001344 RID: 4932
			Succeeded,
			// Token: 0x04001345 RID: 4933
			Failed
		}
	}
}
