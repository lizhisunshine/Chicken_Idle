using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Events;

namespace I2.Loc
{
	// Token: 0x02000082 RID: 130
	[AddComponentMenu("I2/Localization/I2 Localize")]
	public class Localize : MonoBehaviour
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x00060DF0 File Offset: 0x0005EFF0
		// (set) Token: 0x060003B6 RID: 950 RVA: 0x00060DF8 File Offset: 0x0005EFF8
		public string Term
		{
			get
			{
				return this.mTerm;
			}
			set
			{
				this.SetTerm(value);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x00060E01 File Offset: 0x0005F001
		// (set) Token: 0x060003B8 RID: 952 RVA: 0x00060E09 File Offset: 0x0005F009
		public string SecondaryTerm
		{
			get
			{
				return this.mTermSecondary;
			}
			set
			{
				this.SetTerm(null, value);
			}
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00060E13 File Offset: 0x0005F013
		private void Awake()
		{
			this.UpdateAssetDictionary();
			this.FindTarget();
			if (this.LocalizeOnAwake)
			{
				this.OnLocalize(false);
			}
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00060E31 File Offset: 0x0005F031
		private void OnEnable()
		{
			this.OnLocalize(false);
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00060E3A File Offset: 0x0005F03A
		public bool HasCallback()
		{
			return this.LocalizeCallBack.HasCallback() || this.LocalizeEvent.GetPersistentEventCount() > 0;
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00060E5C File Offset: 0x0005F05C
		public void OnLocalize(bool Force = false)
		{
			if (!Force && (!base.enabled || base.gameObject == null || !base.gameObject.activeInHierarchy))
			{
				return;
			}
			if (string.IsNullOrEmpty(LocalizationManager.CurrentLanguage))
			{
				return;
			}
			if (!this.AlwaysForceLocalize && !Force && !this.HasCallback() && this.LastLocalizedLanguage == LocalizationManager.CurrentLanguage)
			{
				return;
			}
			this.LastLocalizedLanguage = LocalizationManager.CurrentLanguage;
			if (string.IsNullOrEmpty(this.FinalTerm) || string.IsNullOrEmpty(this.FinalSecondaryTerm))
			{
				this.GetFinalTerms(out this.FinalTerm, out this.FinalSecondaryTerm);
			}
			bool flag = I2Utils.IsPlaying() && this.HasCallback();
			if (!flag && string.IsNullOrEmpty(this.FinalTerm) && string.IsNullOrEmpty(this.FinalSecondaryTerm))
			{
				return;
			}
			Localize.CurrentLocalizeComponent = this;
			Localize.CallBackTerm = this.FinalTerm;
			Localize.CallBackSecondaryTerm = this.FinalSecondaryTerm;
			Localize.MainTranslation = ((string.IsNullOrEmpty(this.FinalTerm) || this.FinalTerm == "-") ? null : LocalizationManager.GetTranslation(this.FinalTerm, false, 0, true, false, null, null, true));
			Localize.SecondaryTranslation = ((string.IsNullOrEmpty(this.FinalSecondaryTerm) || this.FinalSecondaryTerm == "-") ? null : LocalizationManager.GetTranslation(this.FinalSecondaryTerm, false, 0, true, false, null, null, true));
			if (!flag && string.IsNullOrEmpty(this.FinalTerm) && string.IsNullOrEmpty(Localize.SecondaryTranslation))
			{
				return;
			}
			this.LocalizeCallBack.Execute(this);
			this.LocalizeEvent.Invoke();
			if (this.AllowParameters)
			{
				LocalizationManager.ApplyLocalizationParams(ref Localize.MainTranslation, base.gameObject, this.AllowLocalizedParameters);
			}
			if (!this.FindTarget())
			{
				return;
			}
			bool flag2 = LocalizationManager.IsRight2Left && !this.IgnoreRTL;
			if (Localize.MainTranslation != null)
			{
				switch (this.PrimaryTermModifier)
				{
				case Localize.TermModification.ToUpper:
					Localize.MainTranslation = Localize.MainTranslation.ToUpper();
					break;
				case Localize.TermModification.ToLower:
					Localize.MainTranslation = Localize.MainTranslation.ToLower();
					break;
				case Localize.TermModification.ToUpperFirst:
					Localize.MainTranslation = GoogleTranslation.UppercaseFirst(Localize.MainTranslation);
					break;
				case Localize.TermModification.ToTitle:
					Localize.MainTranslation = GoogleTranslation.TitleCase(Localize.MainTranslation);
					break;
				}
				if (!string.IsNullOrEmpty(this.TermPrefix))
				{
					Localize.MainTranslation = (flag2 ? (Localize.MainTranslation + this.TermPrefix) : (this.TermPrefix + Localize.MainTranslation));
				}
				if (!string.IsNullOrEmpty(this.TermSuffix))
				{
					Localize.MainTranslation = (flag2 ? (this.TermSuffix + Localize.MainTranslation) : (Localize.MainTranslation + this.TermSuffix));
				}
				if (this.AddSpacesToJoinedLanguages && LocalizationManager.HasJoinedWords && !string.IsNullOrEmpty(Localize.MainTranslation))
				{
					StringBuilder stringBuilder = new StringBuilder();
					stringBuilder.Append(Localize.MainTranslation[0]);
					int i = 1;
					int length = Localize.MainTranslation.Length;
					while (i < length)
					{
						stringBuilder.Append(' ');
						stringBuilder.Append(Localize.MainTranslation[i]);
						i++;
					}
					Localize.MainTranslation = stringBuilder.ToString();
				}
				if (flag2 && this.mLocalizeTarget.AllowMainTermToBeRTL() && !string.IsNullOrEmpty(Localize.MainTranslation))
				{
					Localize.MainTranslation = LocalizationManager.ApplyRTLfix(Localize.MainTranslation, this.MaxCharactersInRTL, this.IgnoreNumbersInRTL);
				}
			}
			if (Localize.SecondaryTranslation != null)
			{
				switch (this.SecondaryTermModifier)
				{
				case Localize.TermModification.ToUpper:
					Localize.SecondaryTranslation = Localize.SecondaryTranslation.ToUpper();
					break;
				case Localize.TermModification.ToLower:
					Localize.SecondaryTranslation = Localize.SecondaryTranslation.ToLower();
					break;
				case Localize.TermModification.ToUpperFirst:
					Localize.SecondaryTranslation = GoogleTranslation.UppercaseFirst(Localize.SecondaryTranslation);
					break;
				case Localize.TermModification.ToTitle:
					Localize.SecondaryTranslation = GoogleTranslation.TitleCase(Localize.SecondaryTranslation);
					break;
				}
				if (flag2 && this.mLocalizeTarget.AllowSecondTermToBeRTL() && !string.IsNullOrEmpty(Localize.SecondaryTranslation))
				{
					Localize.SecondaryTranslation = LocalizationManager.ApplyRTLfix(Localize.SecondaryTranslation);
				}
			}
			if (LocalizationManager.HighlightLocalizedTargets)
			{
				Localize.MainTranslation = "LOC:" + this.FinalTerm;
			}
			this.mLocalizeTarget.DoLocalize(this, Localize.MainTranslation, Localize.SecondaryTranslation);
			Localize.CurrentLocalizeComponent = null;
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00061280 File Offset: 0x0005F480
		public bool FindTarget()
		{
			if (this.mLocalizeTarget != null && this.mLocalizeTarget.IsValid(this))
			{
				return true;
			}
			if (this.mLocalizeTarget != null)
			{
				Object.DestroyImmediate(this.mLocalizeTarget);
				this.mLocalizeTarget = null;
				this.mLocalizeTargetName = null;
			}
			if (!string.IsNullOrEmpty(this.mLocalizeTargetName))
			{
				foreach (ILocalizeTargetDescriptor localizeTargetDescriptor in LocalizationManager.mLocalizeTargets)
				{
					if (this.mLocalizeTargetName == localizeTargetDescriptor.GetTargetType().ToString())
					{
						if (localizeTargetDescriptor.CanLocalize(this))
						{
							this.mLocalizeTarget = localizeTargetDescriptor.CreateTarget(this);
						}
						if (this.mLocalizeTarget != null)
						{
							return true;
						}
					}
				}
			}
			foreach (ILocalizeTargetDescriptor localizeTargetDescriptor2 in LocalizationManager.mLocalizeTargets)
			{
				if (localizeTargetDescriptor2.CanLocalize(this))
				{
					this.mLocalizeTarget = localizeTargetDescriptor2.CreateTarget(this);
					this.mLocalizeTargetName = localizeTargetDescriptor2.GetTargetType().ToString();
					if (this.mLocalizeTarget != null)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060003BE RID: 958 RVA: 0x000613D8 File Offset: 0x0005F5D8
		public void GetFinalTerms(out string primaryTerm, out string secondaryTerm)
		{
			primaryTerm = string.Empty;
			secondaryTerm = string.Empty;
			if (!this.FindTarget())
			{
				return;
			}
			if (this.mLocalizeTarget != null)
			{
				this.mLocalizeTarget.GetFinalTerms(this, this.mTerm, this.mTermSecondary, out primaryTerm, out secondaryTerm);
				primaryTerm = I2Utils.GetValidTermName(primaryTerm, false);
			}
			if (!string.IsNullOrEmpty(this.mTerm))
			{
				primaryTerm = this.mTerm;
			}
			if (!string.IsNullOrEmpty(this.mTermSecondary))
			{
				secondaryTerm = this.mTermSecondary;
			}
			if (primaryTerm != null)
			{
				primaryTerm = primaryTerm.Trim();
			}
			if (secondaryTerm != null)
			{
				secondaryTerm = secondaryTerm.Trim();
			}
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00061474 File Offset: 0x0005F674
		public string GetMainTargetsText()
		{
			string text = null;
			string text2 = null;
			if (this.mLocalizeTarget != null)
			{
				this.mLocalizeTarget.GetFinalTerms(this, null, null, out text, out text2);
			}
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return this.mTerm;
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x000614B5 File Offset: 0x0005F6B5
		public void SetFinalTerms(string Main, string Secondary, out string primaryTerm, out string secondaryTerm, bool RemoveNonASCII)
		{
			primaryTerm = (RemoveNonASCII ? I2Utils.GetValidTermName(Main, false) : Main);
			secondaryTerm = Secondary;
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x000614CC File Offset: 0x0005F6CC
		public void SetTerm(string primary)
		{
			if (!string.IsNullOrEmpty(primary))
			{
				this.mTerm = primary;
				this.FinalTerm = primary;
			}
			this.OnLocalize(true);
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x000614F8 File Offset: 0x0005F6F8
		public void SetTerm(string primary, string secondary)
		{
			if (!string.IsNullOrEmpty(primary))
			{
				this.mTerm = primary;
				this.FinalTerm = primary;
			}
			this.mTermSecondary = secondary;
			this.FinalSecondaryTerm = secondary;
			this.OnLocalize(true);
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00061534 File Offset: 0x0005F734
		internal T GetSecondaryTranslatedObj<T>(ref string mainTranslation, ref string secondaryTranslation) where T : Object
		{
			string text;
			string text2;
			this.DeserializeTranslation(mainTranslation, out text, out text2);
			T t = default(T);
			if (!string.IsNullOrEmpty(text2))
			{
				t = this.GetObject<T>(text2);
				if (t != null)
				{
					mainTranslation = text;
					secondaryTranslation = text2;
				}
			}
			if (t == null)
			{
				t = this.GetObject<T>(secondaryTranslation);
			}
			return t;
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00061594 File Offset: 0x0005F794
		public void UpdateAssetDictionary()
		{
			this.TranslatedObjects.RemoveAll((Object x) => x == null);
			this.mAssetDictionary = (from o in this.TranslatedObjects.Distinct<Object>()
			group o by o.name).ToDictionary((IGrouping<string, Object> g) => g.Key, (IGrouping<string, Object> g) => g.First<Object>());
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00061644 File Offset: 0x0005F844
		internal T GetObject<T>(string Translation) where T : Object
		{
			if (string.IsNullOrEmpty(Translation))
			{
				return default(T);
			}
			return this.GetTranslatedObject<T>(Translation);
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0006166A File Offset: 0x0005F86A
		private T GetTranslatedObject<T>(string Translation) where T : Object
		{
			return this.FindTranslatedObject<T>(Translation);
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00061674 File Offset: 0x0005F874
		private void DeserializeTranslation(string translation, out string value, out string secondary)
		{
			if (!string.IsNullOrEmpty(translation) && translation.Length > 1 && translation[0] == '[')
			{
				int num = translation.IndexOf(']');
				if (num > 0)
				{
					secondary = translation.Substring(1, num - 1);
					value = translation.Substring(num + 1);
					return;
				}
			}
			value = translation;
			secondary = string.Empty;
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x000616CC File Offset: 0x0005F8CC
		public T FindTranslatedObject<T>(string value) where T : Object
		{
			if (string.IsNullOrEmpty(value))
			{
				T result = default(T);
				return result;
			}
			if (this.mAssetDictionary == null || this.mAssetDictionary.Count != this.TranslatedObjects.Count)
			{
				this.UpdateAssetDictionary();
			}
			foreach (KeyValuePair<string, Object> keyValuePair in this.mAssetDictionary)
			{
				if (keyValuePair.Value is T && value.EndsWith(keyValuePair.Key, StringComparison.OrdinalIgnoreCase) && string.Compare(value, keyValuePair.Key, StringComparison.OrdinalIgnoreCase) == 0)
				{
					return (T)((object)keyValuePair.Value);
				}
			}
			T t = LocalizationManager.FindAsset(value) as T;
			if (t)
			{
				return t;
			}
			return ResourceManager.pInstance.GetAsset<T>(value);
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x000617BC File Offset: 0x0005F9BC
		public bool HasTranslatedObject(Object Obj)
		{
			return this.TranslatedObjects.Contains(Obj) || ResourceManager.pInstance.HasAsset(Obj);
		}

		// Token: 0x060003CA RID: 970 RVA: 0x000617D9 File Offset: 0x0005F9D9
		public void AddTranslatedObject(Object Obj)
		{
			if (this.TranslatedObjects.Contains(Obj))
			{
				return;
			}
			this.TranslatedObjects.Add(Obj);
			this.UpdateAssetDictionary();
		}

		// Token: 0x060003CB RID: 971 RVA: 0x000617FC File Offset: 0x0005F9FC
		public void SetGlobalLanguage(string Language)
		{
			LocalizationManager.CurrentLanguage = Language;
		}

		// Token: 0x04000FA1 RID: 4001
		public string mTerm = string.Empty;

		// Token: 0x04000FA2 RID: 4002
		public string mTermSecondary = string.Empty;

		// Token: 0x04000FA3 RID: 4003
		[NonSerialized]
		public string FinalTerm;

		// Token: 0x04000FA4 RID: 4004
		[NonSerialized]
		public string FinalSecondaryTerm;

		// Token: 0x04000FA5 RID: 4005
		public Localize.TermModification PrimaryTermModifier;

		// Token: 0x04000FA6 RID: 4006
		public Localize.TermModification SecondaryTermModifier;

		// Token: 0x04000FA7 RID: 4007
		public string TermPrefix;

		// Token: 0x04000FA8 RID: 4008
		public string TermSuffix;

		// Token: 0x04000FA9 RID: 4009
		public bool LocalizeOnAwake = true;

		// Token: 0x04000FAA RID: 4010
		private string LastLocalizedLanguage;

		// Token: 0x04000FAB RID: 4011
		public bool IgnoreRTL;

		// Token: 0x04000FAC RID: 4012
		public int MaxCharactersInRTL;

		// Token: 0x04000FAD RID: 4013
		public bool IgnoreNumbersInRTL = true;

		// Token: 0x04000FAE RID: 4014
		public bool CorrectAlignmentForRTL = true;

		// Token: 0x04000FAF RID: 4015
		public bool AddSpacesToJoinedLanguages;

		// Token: 0x04000FB0 RID: 4016
		public bool AllowLocalizedParameters = true;

		// Token: 0x04000FB1 RID: 4017
		public bool AllowParameters = true;

		// Token: 0x04000FB2 RID: 4018
		public List<Object> TranslatedObjects = new List<Object>();

		// Token: 0x04000FB3 RID: 4019
		[NonSerialized]
		public Dictionary<string, Object> mAssetDictionary = new Dictionary<string, Object>(StringComparer.Ordinal);

		// Token: 0x04000FB4 RID: 4020
		public UnityEvent LocalizeEvent = new UnityEvent();

		// Token: 0x04000FB5 RID: 4021
		public static string MainTranslation;

		// Token: 0x04000FB6 RID: 4022
		public static string SecondaryTranslation;

		// Token: 0x04000FB7 RID: 4023
		public static string CallBackTerm;

		// Token: 0x04000FB8 RID: 4024
		public static string CallBackSecondaryTerm;

		// Token: 0x04000FB9 RID: 4025
		public static Localize CurrentLocalizeComponent;

		// Token: 0x04000FBA RID: 4026
		public bool AlwaysForceLocalize;

		// Token: 0x04000FBB RID: 4027
		[SerializeField]
		public EventCallback LocalizeCallBack = new EventCallback();

		// Token: 0x04000FBC RID: 4028
		public bool mGUI_ShowReferences;

		// Token: 0x04000FBD RID: 4029
		public bool mGUI_ShowTems = true;

		// Token: 0x04000FBE RID: 4030
		public bool mGUI_ShowCallback;

		// Token: 0x04000FBF RID: 4031
		public ILocalizeTarget mLocalizeTarget;

		// Token: 0x04000FC0 RID: 4032
		public string mLocalizeTargetName;

		// Token: 0x02000159 RID: 345
		public enum TermModification
		{
			// Token: 0x0400136D RID: 4973
			DontModify,
			// Token: 0x0400136E RID: 4974
			ToUpper,
			// Token: 0x0400136F RID: 4975
			ToLower,
			// Token: 0x04001370 RID: 4976
			ToUpperFirst,
			// Token: 0x04001371 RID: 4977
			ToTitle
		}
	}
}
