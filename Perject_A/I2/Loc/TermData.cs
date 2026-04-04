using System;
using System.Collections.Generic;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x0200009A RID: 154
	[Serializable]
	public class TermData
	{
		// Token: 0x060004B4 RID: 1204 RVA: 0x00064780 File Offset: 0x00062980
		public string GetTranslation(int idx, string specialization = null, bool editMode = false)
		{
			string text = this.Languages[idx];
			if (text != null)
			{
				text = SpecializationManager.GetSpecializedText(text, specialization);
				if (!editMode)
				{
					text = text.Replace("[i2nt]", "").Replace("[/i2nt]", "");
				}
			}
			return text;
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x000647C5 File Offset: 0x000629C5
		public void SetTranslation(int idx, string translation, string specialization = null)
		{
			this.Languages[idx] = SpecializationManager.SetSpecializedText(this.Languages[idx], translation, specialization);
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x000647E0 File Offset: 0x000629E0
		public void RemoveSpecialization(string specialization)
		{
			for (int i = 0; i < this.Languages.Length; i++)
			{
				this.RemoveSpecialization(i, specialization);
			}
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00064808 File Offset: 0x00062A08
		public void RemoveSpecialization(int idx, string specialization)
		{
			string text = this.Languages[idx];
			if (specialization == "Any" || !text.Contains("[i2s_" + specialization + "]"))
			{
				return;
			}
			Dictionary<string, string> specializations = SpecializationManager.GetSpecializations(text, null);
			specializations.Remove(specialization);
			this.Languages[idx] = SpecializationManager.SetSpecializedText(specializations);
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00064862 File Offset: 0x00062A62
		public bool IsAutoTranslated(int idx, bool IsTouch)
		{
			return (this.Flags[idx] & 2) > 0;
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00064874 File Offset: 0x00062A74
		public void Validate()
		{
			int num = Mathf.Max(this.Languages.Length, this.Flags.Length);
			if (this.Languages.Length != num)
			{
				Array.Resize<string>(ref this.Languages, num);
			}
			if (this.Flags.Length != num)
			{
				Array.Resize<byte>(ref this.Flags, num);
			}
			if (this.Languages_Touch != null)
			{
				for (int i = 0; i < Mathf.Min(this.Languages_Touch.Length, num); i++)
				{
					if (string.IsNullOrEmpty(this.Languages[i]) && !string.IsNullOrEmpty(this.Languages_Touch[i]))
					{
						this.Languages[i] = this.Languages_Touch[i];
						this.Languages_Touch[i] = null;
					}
				}
				this.Languages_Touch = null;
			}
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00064924 File Offset: 0x00062B24
		public bool IsTerm(string name, bool allowCategoryMistmatch)
		{
			if (!allowCategoryMistmatch)
			{
				return name == this.Term;
			}
			return name == LanguageSourceData.GetKeyFromFullTerm(this.Term, false);
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00064948 File Offset: 0x00062B48
		public bool HasSpecializations()
		{
			for (int i = 0; i < this.Languages.Length; i++)
			{
				if (!string.IsNullOrEmpty(this.Languages[i]) && this.Languages[i].Contains("[i2s_"))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00064990 File Offset: 0x00062B90
		public List<string> GetAllSpecializations()
		{
			List<string> list = new List<string>();
			for (int i = 0; i < this.Languages.Length; i++)
			{
				SpecializationManager.AppendSpecializations(this.Languages[i], list);
			}
			return list;
		}

		// Token: 0x04000FF7 RID: 4087
		public string Term = string.Empty;

		// Token: 0x04000FF8 RID: 4088
		public eTermType TermType;

		// Token: 0x04000FF9 RID: 4089
		[NonSerialized]
		public string Description;

		// Token: 0x04000FFA RID: 4090
		public string[] Languages = Array.Empty<string>();

		// Token: 0x04000FFB RID: 4091
		public byte[] Flags = Array.Empty<byte>();

		// Token: 0x04000FFC RID: 4092
		[SerializeField]
		private string[] Languages_Touch;
	}
}
