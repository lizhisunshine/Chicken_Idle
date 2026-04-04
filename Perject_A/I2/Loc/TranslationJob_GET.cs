using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine.Networking;

namespace I2.Loc
{
	// Token: 0x02000076 RID: 118
	public class TranslationJob_GET : TranslationJob_WWW
	{
		// Token: 0x06000335 RID: 821 RVA: 0x0005D4C8 File Offset: 0x0005B6C8
		public TranslationJob_GET(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady)
		{
			this._requests = requests;
			this._OnTranslationReady = OnTranslationReady;
			this.mQueries = GoogleTranslation.ConvertTranslationRequest(requests, true);
			this.GetState();
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0005D4F4 File Offset: 0x0005B6F4
		private void ExecuteNextQuery()
		{
			if (this.mQueries.Count == 0)
			{
				this.mJobState = TranslationJob.eJobState.Succeeded;
				return;
			}
			int index = this.mQueries.Count - 1;
			string str = this.mQueries[index];
			this.mQueries.RemoveAt(index);
			string uri = LocalizationManager.GetWebServiceURL(null) + "?action=Translate&list=" + str;
			this.www = UnityWebRequest.Get(uri);
			I2Utils.SendWebRequest(this.www);
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0005D568 File Offset: 0x0005B768
		public override TranslationJob.eJobState GetState()
		{
			if (this.www != null && this.www.isDone)
			{
				this.ProcessResult(this.www.downloadHandler.data, this.www.error);
				this.www.Dispose();
				this.www = null;
			}
			if (this.www == null)
			{
				this.ExecuteNextQuery();
			}
			return this.mJobState;
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0005D5D4 File Offset: 0x0005B7D4
		public void ProcessResult(byte[] bytes, string errorMsg)
		{
			if (string.IsNullOrEmpty(errorMsg))
			{
				errorMsg = GoogleTranslation.ParseTranslationResult(Encoding.UTF8.GetString(bytes, 0, bytes.Length), this._requests);
				if (string.IsNullOrEmpty(errorMsg))
				{
					if (this._OnTranslationReady != null)
					{
						this._OnTranslationReady(this._requests, null);
					}
					return;
				}
			}
			this.mJobState = TranslationJob.eJobState.Failed;
			this.mErrorMessage = errorMsg;
		}

		// Token: 0x04000F50 RID: 3920
		private Dictionary<string, TranslationQuery> _requests;

		// Token: 0x04000F51 RID: 3921
		private GoogleTranslation.fnOnTranslationReady _OnTranslationReady;

		// Token: 0x04000F52 RID: 3922
		private List<string> mQueries;

		// Token: 0x04000F53 RID: 3923
		public string mErrorMessage;
	}
}
