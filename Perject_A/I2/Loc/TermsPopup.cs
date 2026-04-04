using System;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x0200009B RID: 155
	public class TermsPopup : PropertyAttribute
	{
		// Token: 0x060004BE RID: 1214 RVA: 0x000649EE File Offset: 0x00062BEE
		public TermsPopup(string filter = "")
		{
			this.Filter = filter;
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x000649FD File Offset: 0x00062BFD
		// (set) Token: 0x060004C0 RID: 1216 RVA: 0x00064A05 File Offset: 0x00062C05
		public string Filter { get; private set; }
	}
}
