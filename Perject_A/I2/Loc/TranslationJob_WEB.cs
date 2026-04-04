using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.Networking;

namespace I2.Loc
{
	// Token: 0x02000079 RID: 121
	public class TranslationJob_WEB : TranslationJob_WWW
	{
		// Token: 0x0600033F RID: 831 RVA: 0x0005D8FA File Offset: 0x0005BAFA
		public TranslationJob_WEB(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady)
		{
			this._requests = requests;
			this._OnTranslationReady = OnTranslationReady;
			this.FindAllQueries();
			this.ExecuteNextBatch();
		}

		// Token: 0x06000340 RID: 832 RVA: 0x0005D91C File Offset: 0x0005BB1C
		private void FindAllQueries()
		{
			this.mQueries = new List<KeyValuePair<string, string>>();
			foreach (KeyValuePair<string, TranslationQuery> keyValuePair in this._requests)
			{
				foreach (string str in keyValuePair.Value.TargetLanguagesCode)
				{
					this.mQueries.Add(new KeyValuePair<string, string>(keyValuePair.Value.OrigText, keyValuePair.Value.LanguageCode + ":" + str));
				}
			}
			this.mQueries.Sort((KeyValuePair<string, string> a, KeyValuePair<string, string> b) => a.Value.CompareTo(b.Value));
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0005D9F4 File Offset: 0x0005BBF4
		private void ExecuteNextBatch()
		{
			if (this.mQueries.Count == 0)
			{
				this.mJobState = TranslationJob.eJobState.Succeeded;
				return;
			}
			this.mCurrentBatch_Text = new List<string>();
			string text = null;
			int num = 200;
			StringBuilder stringBuilder = new StringBuilder();
			int i;
			for (i = 0; i < this.mQueries.Count; i++)
			{
				string key = this.mQueries[i].Key;
				string value = this.mQueries[i].Value;
				if (text == null || value == text)
				{
					if (i != 0)
					{
						stringBuilder.Append("|||");
					}
					stringBuilder.Append(key);
					this.mCurrentBatch_Text.Add(key);
					text = value;
				}
				if (stringBuilder.Length > num)
				{
					break;
				}
			}
			this.mQueries.RemoveRange(0, i);
			string[] array = text.Split(':', StringSplitOptions.None);
			this.mCurrentBatch_FromLanguageCode = array[0];
			this.mCurrentBatch_ToLanguageCode = array[1];
			string text2 = string.Format("http://www.google.com/translate_t?hl=en&vi=c&ie=UTF8&oe=UTF8&submit=Translate&langpair={0}|{1}&text={2}", this.mCurrentBatch_FromLanguageCode, this.mCurrentBatch_ToLanguageCode, Uri.EscapeUriString(stringBuilder.ToString()));
			Debug.Log(text2);
			this.www = UnityWebRequest.Get(text2);
			I2Utils.SendWebRequest(this.www);
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0005DB20 File Offset: 0x0005BD20
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
				this.ExecuteNextBatch();
			}
			return this.mJobState;
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0005DB8C File Offset: 0x0005BD8C
		public void ProcessResult(byte[] bytes, string errorMsg)
		{
			if (string.IsNullOrEmpty(errorMsg))
			{
				string @string = Encoding.UTF8.GetString(bytes, 0, bytes.Length);
				Debug.Log(this.ParseTranslationResult(@string, "aab"));
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

		// Token: 0x06000344 RID: 836 RVA: 0x0005DBF4 File Offset: 0x0005BDF4
		private string ParseTranslationResult(string html, string OriginalText)
		{
			string result;
			try
			{
				int num = html.IndexOf("TRANSLATED_TEXT='", StringComparison.Ordinal) + "TRANSLATED_TEXT='".Length;
				int num2 = html.IndexOf("';var", num, StringComparison.Ordinal);
				string text = html.Substring(num, num2 - num);
				text = Regex.Replace(text, "\\\\x([a-fA-F0-9]{2})", (Match match) => char.ConvertFromUtf32(int.Parse(match.Groups[1].Value, NumberStyles.HexNumber)));
				text = Regex.Replace(text, "&#(\\d+);", (Match match) => char.ConvertFromUtf32(int.Parse(match.Groups[1].Value)));
				text = text.Replace("<br>", "\n");
				if (OriginalText.ToUpper() == OriginalText)
				{
					text = text.ToUpper();
				}
				else if (GoogleTranslation.UppercaseFirst(OriginalText) == OriginalText)
				{
					text = GoogleTranslation.UppercaseFirst(text);
				}
				else if (GoogleTranslation.TitleCase(OriginalText) == OriginalText)
				{
					text = GoogleTranslation.TitleCase(text);
				}
				result = text;
			}
			catch (Exception ex)
			{
				Debug.LogError(ex.Message);
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x04000F5C RID: 3932
		private Dictionary<string, TranslationQuery> _requests;

		// Token: 0x04000F5D RID: 3933
		private GoogleTranslation.fnOnTranslationReady _OnTranslationReady;

		// Token: 0x04000F5E RID: 3934
		public string mErrorMessage;

		// Token: 0x04000F5F RID: 3935
		private string mCurrentBatch_ToLanguageCode;

		// Token: 0x04000F60 RID: 3936
		private string mCurrentBatch_FromLanguageCode;

		// Token: 0x04000F61 RID: 3937
		private List<string> mCurrentBatch_Text;

		// Token: 0x04000F62 RID: 3938
		private List<KeyValuePair<string, string>> mQueries;
	}
}
