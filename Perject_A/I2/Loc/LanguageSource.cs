using System;
using System.Collections.Generic;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x0200007C RID: 124
	[AddComponentMenu("I2/Localization/Source")]
	[ExecuteInEditMode]
	public class LanguageSource : MonoBehaviour, ISerializationCallbackReceiver, ILanguageSource
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600034C RID: 844 RVA: 0x0005DDA2 File Offset: 0x0005BFA2
		// (set) Token: 0x0600034D RID: 845 RVA: 0x0005DDAA File Offset: 0x0005BFAA
		public LanguageSourceData SourceData
		{
			get
			{
				return this.mSource;
			}
			set
			{
				this.mSource = value;
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600034E RID: 846 RVA: 0x0005DDB4 File Offset: 0x0005BFB4
		// (remove) Token: 0x0600034F RID: 847 RVA: 0x0005DDEC File Offset: 0x0005BFEC
		public event LanguageSource.fnOnSourceUpdated Event_OnSourceUpdateFromGoogle;

		// Token: 0x06000350 RID: 848 RVA: 0x0005DE21 File Offset: 0x0005C021
		private void Awake()
		{
			this.mSource.owner = this;
			this.mSource.Awake();
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0005DE3A File Offset: 0x0005C03A
		private void OnDestroy()
		{
			this.NeverDestroy = false;
			if (!this.NeverDestroy)
			{
				this.mSource.OnDestroy();
			}
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0005DE58 File Offset: 0x0005C058
		public string GetSourceName()
		{
			string text = base.gameObject.name;
			Transform parent = base.transform.parent;
			while (parent)
			{
				text = parent.name + "_" + text;
				parent = parent.parent;
			}
			return text;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x0005DEA1 File Offset: 0x0005C0A1
		public void OnBeforeSerialize()
		{
			this.version = 1;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x0005DEAC File Offset: 0x0005C0AC
		public void OnAfterDeserialize()
		{
			if (this.version == 0 || this.mSource == null)
			{
				this.mSource = new LanguageSourceData();
				this.mSource.owner = this;
				this.mSource.UserAgreesToHaveItOnTheScene = this.UserAgreesToHaveItOnTheScene;
				this.mSource.UserAgreesToHaveItInsideThePluginsFolder = this.UserAgreesToHaveItInsideThePluginsFolder;
				this.mSource.IgnoreDeviceLanguage = this.IgnoreDeviceLanguage;
				this.mSource._AllowUnloadingLanguages = this._AllowUnloadingLanguages;
				this.mSource.CaseInsensitiveTerms = this.CaseInsensitiveTerms;
				this.mSource.OnMissingTranslation = this.OnMissingTranslation;
				this.mSource.mTerm_AppName = this.mTerm_AppName;
				this.mSource.GoogleLiveSyncIsUptoDate = this.GoogleLiveSyncIsUptoDate;
				this.mSource.Google_WebServiceURL = this.Google_WebServiceURL;
				this.mSource.Google_SpreadsheetKey = this.Google_SpreadsheetKey;
				this.mSource.Google_SpreadsheetName = this.Google_SpreadsheetName;
				this.mSource.Google_LastUpdatedVersion = this.Google_LastUpdatedVersion;
				this.mSource.GoogleUpdateFrequency = this.GoogleUpdateFrequency;
				this.mSource.GoogleUpdateDelay = this.GoogleUpdateDelay;
				this.mSource.Event_OnSourceUpdateFromGoogle += this.Event_OnSourceUpdateFromGoogle;
				if (this.mLanguages != null && this.mLanguages.Count > 0)
				{
					this.mSource.mLanguages.Clear();
					this.mSource.mLanguages.AddRange(this.mLanguages);
					this.mLanguages.Clear();
				}
				if (this.Assets != null && this.Assets.Count > 0)
				{
					this.mSource.Assets.Clear();
					this.mSource.Assets.AddRange(this.Assets);
					this.Assets.Clear();
				}
				if (this.mTerms != null && this.mTerms.Count > 0)
				{
					this.mSource.mTerms.Clear();
					for (int i = 0; i < this.mTerms.Count; i++)
					{
						this.mSource.mTerms.Add(this.mTerms[i]);
					}
					this.mTerms.Clear();
				}
				this.version = 1;
				this.Event_OnSourceUpdateFromGoogle = null;
			}
		}

		// Token: 0x04000F6B RID: 3947
		public LanguageSourceData mSource = new LanguageSourceData();

		// Token: 0x04000F6C RID: 3948
		public int version;

		// Token: 0x04000F6D RID: 3949
		public bool NeverDestroy;

		// Token: 0x04000F6E RID: 3950
		public bool UserAgreesToHaveItOnTheScene;

		// Token: 0x04000F6F RID: 3951
		public bool UserAgreesToHaveItInsideThePluginsFolder;

		// Token: 0x04000F70 RID: 3952
		public bool GoogleLiveSyncIsUptoDate = true;

		// Token: 0x04000F71 RID: 3953
		public List<Object> Assets = new List<Object>();

		// Token: 0x04000F72 RID: 3954
		public string Google_WebServiceURL;

		// Token: 0x04000F73 RID: 3955
		public string Google_SpreadsheetKey;

		// Token: 0x04000F74 RID: 3956
		public string Google_SpreadsheetName;

		// Token: 0x04000F75 RID: 3957
		public string Google_LastUpdatedVersion;

		// Token: 0x04000F76 RID: 3958
		public LanguageSourceData.eGoogleUpdateFrequency GoogleUpdateFrequency = LanguageSourceData.eGoogleUpdateFrequency.Weekly;

		// Token: 0x04000F77 RID: 3959
		public float GoogleUpdateDelay = 5f;

		// Token: 0x04000F79 RID: 3961
		public List<LanguageData> mLanguages = new List<LanguageData>();

		// Token: 0x04000F7A RID: 3962
		public bool IgnoreDeviceLanguage;

		// Token: 0x04000F7B RID: 3963
		public LanguageSourceData.eAllowUnloadLanguages _AllowUnloadingLanguages;

		// Token: 0x04000F7C RID: 3964
		public List<TermData> mTerms = new List<TermData>();

		// Token: 0x04000F7D RID: 3965
		public bool CaseInsensitiveTerms;

		// Token: 0x04000F7E RID: 3966
		public LanguageSourceData.MissingTranslationAction OnMissingTranslation = LanguageSourceData.MissingTranslationAction.Fallback;

		// Token: 0x04000F7F RID: 3967
		public string mTerm_AppName;

		// Token: 0x02000152 RID: 338
		// (Invoke) Token: 0x06000893 RID: 2195
		public delegate void fnOnSourceUpdated(LanguageSourceData source, bool ReceivedNewData, string errorMsg);
	}
}
