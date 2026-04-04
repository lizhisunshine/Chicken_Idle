using System;

namespace I2.Loc
{
	// Token: 0x020000A8 RID: 168
	public class RTLFixer
	{
		// Token: 0x060004FB RID: 1275 RVA: 0x0006594A File Offset: 0x00063B4A
		public static string Fix(string str)
		{
			return RTLFixer.Fix(str, false, true);
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00065954 File Offset: 0x00063B54
		public static string Fix(string str, bool rtl)
		{
			if (rtl)
			{
				return RTLFixer.Fix(str);
			}
			string[] array = str.Split(' ', StringSplitOptions.None);
			string text = "";
			string text2 = "";
			foreach (string text3 in array)
			{
				if (char.IsLower(text3.ToLower()[text3.Length / 2]))
				{
					text = text + RTLFixer.Fix(text2) + text3 + " ";
					text2 = "";
				}
				else
				{
					text2 = text2 + text3 + " ";
				}
			}
			if (text2 != "")
			{
				text += RTLFixer.Fix(text2);
			}
			return text;
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x000659F8 File Offset: 0x00063BF8
		public static string Fix(string str, bool showTashkeel, bool useHinduNumbers)
		{
			string text = HindiFixer.Fix(str);
			if (text != str)
			{
				return text;
			}
			RTLFixerTool.showTashkeel = showTashkeel;
			RTLFixerTool.useHinduNumbers = useHinduNumbers;
			if (str.Contains("\n"))
			{
				str = str.Replace("\n", Environment.NewLine);
			}
			if (!str.Contains(Environment.NewLine))
			{
				return RTLFixerTool.FixLine(str);
			}
			string[] separator = new string[]
			{
				Environment.NewLine
			};
			string[] array = str.Split(separator, StringSplitOptions.None);
			if (array.Length == 0)
			{
				return RTLFixerTool.FixLine(str);
			}
			if (array.Length == 1)
			{
				return RTLFixerTool.FixLine(str);
			}
			string text2 = RTLFixerTool.FixLine(array[0]);
			int i = 1;
			if (array.Length > 1)
			{
				while (i < array.Length)
				{
					text2 = text2 + Environment.NewLine + RTLFixerTool.FixLine(array[i]);
					i++;
				}
			}
			return text2;
		}
	}
}
