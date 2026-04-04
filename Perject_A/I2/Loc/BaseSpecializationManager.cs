using System;
using System.Collections.Generic;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x0200006D RID: 109
	public class BaseSpecializationManager
	{
		// Token: 0x060002F5 RID: 757 RVA: 0x00058474 File Offset: 0x00056674
		public virtual void InitializeSpecializations()
		{
			this.mSpecializations = new string[]
			{
				"Any",
				"PC",
				"Touch",
				"Controller",
				"VR",
				"XBox",
				"PS4",
				"PS5",
				"OculusVR",
				"ViveVR",
				"GearVR",
				"Android",
				"IOS",
				"Switch"
			};
			this.mSpecializationsFallbacks = new Dictionary<string, string>(StringComparer.Ordinal)
			{
				{
					"XBox",
					"Controller"
				},
				{
					"PS4",
					"Controller"
				},
				{
					"OculusVR",
					"VR"
				},
				{
					"ViveVR",
					"VR"
				},
				{
					"GearVR",
					"VR"
				},
				{
					"Android",
					"Touch"
				},
				{
					"IOS",
					"Touch"
				}
			};
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00058583 File Offset: 0x00056783
		public virtual string GetCurrentSpecialization()
		{
			if (this.mSpecializations == null)
			{
				this.InitializeSpecializations();
			}
			return "PC";
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00058598 File Offset: 0x00056798
		private bool IsTouchInputSupported()
		{
			return Input.touchSupported;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x000585A0 File Offset: 0x000567A0
		public virtual string GetFallbackSpecialization(string specialization)
		{
			if (this.mSpecializationsFallbacks == null)
			{
				this.InitializeSpecializations();
			}
			string result;
			if (this.mSpecializationsFallbacks.TryGetValue(specialization, out result))
			{
				return result;
			}
			return "Any";
		}

		// Token: 0x04000F39 RID: 3897
		public string[] mSpecializations;

		// Token: 0x04000F3A RID: 3898
		public Dictionary<string, string> mSpecializationsFallbacks;
	}
}
