using System;
using System.Collections.Generic;

namespace I2.Loc
{
	// Token: 0x02000077 RID: 119
	public class TranslationJob_Main : TranslationJob
	{
		// Token: 0x06000339 RID: 825 RVA: 0x0005D636 File Offset: 0x0005B836
		public TranslationJob_Main(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady)
		{
			this._requests = requests;
			this._OnTranslationReady = OnTranslationReady;
			this.mPost = new TranslationJob_POST(requests, OnTranslationReady);
		}

		// Token: 0x0600033A RID: 826 RVA: 0x0005D65C File Offset: 0x0005B85C
		public override TranslationJob.eJobState GetState()
		{
			if (this.mWeb != null)
			{
				switch (this.mWeb.GetState())
				{
				case TranslationJob.eJobState.Running:
					return TranslationJob.eJobState.Running;
				case TranslationJob.eJobState.Succeeded:
					this.mJobState = TranslationJob.eJobState.Succeeded;
					break;
				case TranslationJob.eJobState.Failed:
					this.mWeb.Dispose();
					this.mWeb = null;
					this.mPost = new TranslationJob_POST(this._requests, this._OnTranslationReady);
					break;
				}
			}
			if (this.mPost != null)
			{
				switch (this.mPost.GetState())
				{
				case TranslationJob.eJobState.Running:
					return TranslationJob.eJobState.Running;
				case TranslationJob.eJobState.Succeeded:
					this.mJobState = TranslationJob.eJobState.Succeeded;
					break;
				case TranslationJob.eJobState.Failed:
					this.mPost.Dispose();
					this.mPost = null;
					this.mGet = new TranslationJob_GET(this._requests, this._OnTranslationReady);
					break;
				}
			}
			if (this.mGet != null)
			{
				switch (this.mGet.GetState())
				{
				case TranslationJob.eJobState.Running:
					return TranslationJob.eJobState.Running;
				case TranslationJob.eJobState.Succeeded:
					this.mJobState = TranslationJob.eJobState.Succeeded;
					break;
				case TranslationJob.eJobState.Failed:
					this.mErrorMessage = this.mGet.mErrorMessage;
					if (this._OnTranslationReady != null)
					{
						this._OnTranslationReady(this._requests, this.mErrorMessage);
					}
					this.mGet.Dispose();
					this.mGet = null;
					break;
				}
			}
			return this.mJobState;
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0005D79C File Offset: 0x0005B99C
		public override void Dispose()
		{
			if (this.mPost != null)
			{
				this.mPost.Dispose();
			}
			if (this.mGet != null)
			{
				this.mGet.Dispose();
			}
			this.mPost = null;
			this.mGet = null;
		}

		// Token: 0x04000F54 RID: 3924
		private TranslationJob_WEB mWeb;

		// Token: 0x04000F55 RID: 3925
		private TranslationJob_POST mPost;

		// Token: 0x04000F56 RID: 3926
		private TranslationJob_GET mGet;

		// Token: 0x04000F57 RID: 3927
		private Dictionary<string, TranslationQuery> _requests;

		// Token: 0x04000F58 RID: 3928
		private GoogleTranslation.fnOnTranslationReady _OnTranslationReady;

		// Token: 0x04000F59 RID: 3929
		public string mErrorMessage;
	}
}
