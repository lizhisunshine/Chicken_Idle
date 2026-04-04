using System;

namespace TMPro
{
	// Token: 0x02000042 RID: 66
	[Serializable]
	public class TMP_DigitValidator : TMP_InputValidator
	{
		// Token: 0x06000219 RID: 537 RVA: 0x000533F6 File Offset: 0x000515F6
		public override char Validate(ref string text, ref int pos, char ch)
		{
			if (ch >= '0' && ch <= '9')
			{
				text += ch.ToString();
				pos++;
				return ch;
			}
			return '\0';
		}
	}
}
