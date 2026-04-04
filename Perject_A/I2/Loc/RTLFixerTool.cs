using System;
using System.Collections.Generic;

namespace I2.Loc
{
	// Token: 0x020000AE RID: 174
	internal class RTLFixerTool
	{
		// Token: 0x06000504 RID: 1284 RVA: 0x00065F8C File Offset: 0x0006418C
		internal static string RemoveTashkeel(string str, out List<TashkeelLocation> tashkeelLocation)
		{
			tashkeelLocation = new List<TashkeelLocation>();
			char[] array = str.ToCharArray();
			int num = 0;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == 'ً')
				{
					tashkeelLocation.Add(new TashkeelLocation('ً', i));
					num++;
				}
				else if (array[i] == 'ٌ')
				{
					tashkeelLocation.Add(new TashkeelLocation('ٌ', i));
					num++;
				}
				else if (array[i] == 'ٍ')
				{
					tashkeelLocation.Add(new TashkeelLocation('ٍ', i));
					num++;
				}
				else if (array[i] == 'َ')
				{
					if (num > 0 && tashkeelLocation[num - 1].tashkeel == 'ّ')
					{
						tashkeelLocation[num - 1].tashkeel = 'ﱠ';
					}
					else
					{
						tashkeelLocation.Add(new TashkeelLocation('َ', i));
						num++;
					}
				}
				else if (array[i] == 'ُ')
				{
					if (num > 0 && tashkeelLocation[num - 1].tashkeel == 'ّ')
					{
						tashkeelLocation[num - 1].tashkeel = 'ﱡ';
					}
					else
					{
						tashkeelLocation.Add(new TashkeelLocation('ُ', i));
						num++;
					}
				}
				else if (array[i] == 'ِ')
				{
					if (num > 0 && tashkeelLocation[num - 1].tashkeel == 'ّ')
					{
						tashkeelLocation[num - 1].tashkeel = 'ﱢ';
					}
					else
					{
						tashkeelLocation.Add(new TashkeelLocation('ِ', i));
						num++;
					}
				}
				else if (array[i] == 'ّ')
				{
					if (num > 0)
					{
						if (tashkeelLocation[num - 1].tashkeel == 'َ')
						{
							tashkeelLocation[num - 1].tashkeel = 'ﱠ';
							goto IL_286;
						}
						if (tashkeelLocation[num - 1].tashkeel == 'ُ')
						{
							tashkeelLocation[num - 1].tashkeel = 'ﱡ';
							goto IL_286;
						}
						if (tashkeelLocation[num - 1].tashkeel == 'ِ')
						{
							tashkeelLocation[num - 1].tashkeel = 'ﱢ';
							goto IL_286;
						}
					}
					tashkeelLocation.Add(new TashkeelLocation('ّ', i));
					num++;
				}
				else if (array[i] == 'ْ')
				{
					tashkeelLocation.Add(new TashkeelLocation('ْ', i));
					num++;
				}
				else if (array[i] == 'ٓ')
				{
					tashkeelLocation.Add(new TashkeelLocation('ٓ', i));
					num++;
				}
				IL_286:;
			}
			string[] array2 = str.Split(new char[]
			{
				'ً',
				'ٌ',
				'ٍ',
				'َ',
				'ُ',
				'ِ',
				'ّ',
				'ْ',
				'ٓ',
				'ﱠ',
				'ﱡ',
				'ﱢ'
			});
			str = "";
			foreach (string str2 in array2)
			{
				str += str2;
			}
			return str;
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00066270 File Offset: 0x00064470
		internal static char[] ReturnTashkeel(char[] letters, List<TashkeelLocation> tashkeelLocation)
		{
			char[] array = new char[letters.Length + tashkeelLocation.Count];
			int num = 0;
			for (int i = 0; i < letters.Length; i++)
			{
				array[num] = letters[i];
				num++;
				foreach (TashkeelLocation tashkeelLocation2 in tashkeelLocation)
				{
					if (tashkeelLocation2.position == num)
					{
						array[num] = tashkeelLocation2.tashkeel;
						num++;
					}
				}
			}
			return array;
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x000662FC File Offset: 0x000644FC
		internal static string FixLine(string str)
		{
			string str2 = "";
			List<TashkeelLocation> tashkeelLocation;
			string text = RTLFixerTool.RemoveTashkeel(str, out tashkeelLocation);
			char[] array = text.ToCharArray();
			char[] array2 = text.ToCharArray();
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = (char)ArabicTable.ArabicMapper.Convert((int)array[i]);
			}
			for (int j = 0; j < array.Length; j++)
			{
				bool flag = false;
				if (array[j] == 'ﻝ' && j < array.Length - 1)
				{
					if (array[j + 1] == 'ﺇ')
					{
						array[j] = 'ﻷ';
						array2[j + 1] = char.MaxValue;
						flag = true;
					}
					else if (array[j + 1] == 'ﺍ')
					{
						array[j] = 'ﻹ';
						array2[j + 1] = char.MaxValue;
						flag = true;
					}
					else if (array[j + 1] == 'ﺃ')
					{
						array[j] = 'ﻵ';
						array2[j + 1] = char.MaxValue;
						flag = true;
					}
					else if (array[j + 1] == 'ﺁ')
					{
						array[j] = 'ﻳ';
						array2[j + 1] = char.MaxValue;
						flag = true;
					}
				}
				if (!RTLFixerTool.IsIgnoredCharacter(array[j]))
				{
					if (RTLFixerTool.IsMiddleLetter(array, j))
					{
						array2[j] = array[j] + '\u0003';
					}
					else if (RTLFixerTool.IsFinishingLetter(array, j))
					{
						array2[j] = array[j] + '\u0001';
					}
					else if (RTLFixerTool.IsLeadingLetter(array, j))
					{
						array2[j] = array[j] + '\u0002';
					}
				}
				str2 = str2 + Convert.ToString((int)array[j], 16) + " ";
				if (flag)
				{
					j++;
				}
				if (RTLFixerTool.useHinduNumbers)
				{
					if (array[j] == '0')
					{
						array2[j] = '٠';
					}
					else if (array[j] == '1')
					{
						array2[j] = '١';
					}
					else if (array[j] == '2')
					{
						array2[j] = '٢';
					}
					else if (array[j] == '3')
					{
						array2[j] = '٣';
					}
					else if (array[j] == '4')
					{
						array2[j] = '٤';
					}
					else if (array[j] == '5')
					{
						array2[j] = '٥';
					}
					else if (array[j] == '6')
					{
						array2[j] = '٦';
					}
					else if (array[j] == '7')
					{
						array2[j] = '٧';
					}
					else if (array[j] == '8')
					{
						array2[j] = '٨';
					}
					else if (array[j] == '9')
					{
						array2[j] = '٩';
					}
				}
			}
			if (RTLFixerTool.showTashkeel)
			{
				array2 = RTLFixerTool.ReturnTashkeel(array2, tashkeelLocation);
			}
			List<char> list = new List<char>();
			List<char> list2 = new List<char>();
			for (int k = array2.Length - 1; k >= 0; k--)
			{
				if (char.IsPunctuation(array2[k]) && k > 0 && k < array2.Length - 1 && (char.IsPunctuation(array2[k - 1]) || char.IsPunctuation(array2[k + 1])))
				{
					if (array2[k] == '(')
					{
						list.Add(')');
					}
					else if (array2[k] == ')')
					{
						list.Add('(');
					}
					else if (array2[k] == '<')
					{
						list.Add('>');
					}
					else if (array2[k] == '>')
					{
						list.Add('<');
					}
					else if (array2[k] == '[')
					{
						list.Add(']');
					}
					else if (array2[k] == ']')
					{
						list.Add('[');
					}
					else if (array2[k] != '￿')
					{
						list.Add(array2[k]);
					}
				}
				else if (array2[k] == ' ' && k > 0 && k < array2.Length - 1 && (char.IsLower(array2[k - 1]) || char.IsUpper(array2[k - 1]) || char.IsNumber(array2[k - 1])) && (char.IsLower(array2[k + 1]) || char.IsUpper(array2[k + 1]) || char.IsNumber(array2[k + 1])))
				{
					list2.Add(array2[k]);
				}
				else if (char.IsNumber(array2[k]) || char.IsLower(array2[k]) || char.IsUpper(array2[k]) || char.IsSymbol(array2[k]) || char.IsPunctuation(array2[k]))
				{
					if (array2[k] == '(')
					{
						list2.Add(')');
					}
					else if (array2[k] == ')')
					{
						list2.Add('(');
					}
					else if (array2[k] == '<')
					{
						list2.Add('>');
					}
					else if (array2[k] == '>')
					{
						list2.Add('<');
					}
					else if (array2[k] == '[')
					{
						list.Add(']');
					}
					else if (array2[k] == ']')
					{
						list.Add('[');
					}
					else
					{
						list2.Add(array2[k]);
					}
				}
				else if ((array2[k] >= '\ud800' && array2[k] <= '\udbff') || (array2[k] >= '\udc00' && array2[k] <= '\udfff'))
				{
					list2.Add(array2[k]);
				}
				else
				{
					if (list2.Count > 0)
					{
						for (int l = 0; l < list2.Count; l++)
						{
							list.Add(list2[list2.Count - 1 - l]);
						}
						list2.Clear();
					}
					if (array2[k] != '￿')
					{
						list.Add(array2[k]);
					}
				}
			}
			if (list2.Count > 0)
			{
				for (int m = 0; m < list2.Count; m++)
				{
					list.Add(list2[list2.Count - 1 - m]);
				}
				list2.Clear();
			}
			array2 = new char[list.Count];
			for (int n = 0; n < array2.Length; n++)
			{
				array2[n] = list[n];
			}
			str = new string(array2);
			return str;
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x000668B4 File Offset: 0x00064AB4
		internal static bool IsIgnoredCharacter(char ch)
		{
			bool flag = char.IsPunctuation(ch);
			bool flag2 = char.IsNumber(ch);
			bool flag3 = char.IsLower(ch);
			bool flag4 = char.IsUpper(ch);
			bool flag5 = char.IsSymbol(ch);
			bool flag6 = ch == 'ﭖ' || ch == 'ﭺ' || ch == 'ﮊ' || ch == 'ﮒ' || ch == 'ﮎ';
			bool flag7 = (ch <= '﻿' && ch >= 'ﹰ') || flag6 || ch == 'ﯼ';
			return flag || flag2 || flag3 || flag4 || flag5 || !flag7 || ch == 'a' || ch == '>' || ch == '<' || ch == '؛';
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00066960 File Offset: 0x00064B60
		internal static bool IsLeadingLetter(char[] letters, int index)
		{
			bool flag = index == 0 || letters[index - 1] == ' ' || letters[index - 1] == '*' || letters[index - 1] == 'A' || char.IsPunctuation(letters[index - 1]) || letters[index - 1] == '>' || letters[index - 1] == '<' || letters[index - 1] == 'ﺍ' || letters[index - 1] == 'ﺩ' || letters[index - 1] == 'ﺫ' || letters[index - 1] == 'ﺭ' || letters[index - 1] == 'ﺯ' || letters[index - 1] == 'ﮊ' || letters[index - 1] == 'ﻭ' || letters[index - 1] == 'ﺁ' || letters[index - 1] == 'ﺃ' || letters[index - 1] == 'ﺇ' || letters[index - 1] == 'ﺅ';
			bool flag2 = letters[index] != ' ' && letters[index] != 'ﺩ' && letters[index] != 'ﺫ' && letters[index] != 'ﺭ' && letters[index] != 'ﺯ' && letters[index] != 'ﮊ' && letters[index] != 'ﺍ' && letters[index] != 'ﺃ' && letters[index] != 'ﺇ' && letters[index] != 'ﺁ' && letters[index] != 'ﺅ' && letters[index] != 'ﻭ' && letters[index] != 'ﺀ';
			bool flag3 = index < letters.Length - 1 && letters[index + 1] != ' ' && !char.IsPunctuation(letters[index + 1]) && !char.IsNumber(letters[index + 1]) && !char.IsSymbol(letters[index + 1]) && !char.IsLower(letters[index + 1]) && !char.IsUpper(letters[index + 1]) && letters[index + 1] != 'ﺀ';
			return flag && flag2 && flag3;
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00066B34 File Offset: 0x00064D34
		internal static bool IsFinishingLetter(char[] letters, int index)
		{
			bool flag = index != 0 && (letters[index - 1] != ' ' && letters[index - 1] != 'ﺩ' && letters[index - 1] != 'ﺫ' && letters[index - 1] != 'ﺭ' && letters[index - 1] != 'ﺯ' && letters[index - 1] != 'ﮊ' && letters[index - 1] != 'ﻭ' && letters[index - 1] != 'ﺍ' && letters[index - 1] != 'ﺁ' && letters[index - 1] != 'ﺃ' && letters[index - 1] != 'ﺇ' && letters[index - 1] != 'ﺅ' && letters[index - 1] != 'ﺀ' && !char.IsPunctuation(letters[index - 1]) && letters[index - 1] != '>') && letters[index - 1] != '<';
			bool flag2 = letters[index] != ' ' && letters[index] != 'ﺀ';
			return flag && flag2;
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00066C38 File Offset: 0x00064E38
		internal static bool IsMiddleLetter(char[] letters, int index)
		{
			bool flag = index != 0 && (letters[index] != 'ﺍ' && letters[index] != 'ﺩ' && letters[index] != 'ﺫ' && letters[index] != 'ﺭ' && letters[index] != 'ﺯ' && letters[index] != 'ﮊ' && letters[index] != 'ﻭ' && letters[index] != 'ﺁ' && letters[index] != 'ﺃ' && letters[index] != 'ﺇ' && letters[index] != 'ﺅ') && letters[index] != 'ﺀ';
			bool flag2 = index != 0 && (letters[index - 1] != 'ﺍ' && letters[index - 1] != 'ﺩ' && letters[index - 1] != 'ﺫ' && letters[index - 1] != 'ﺭ' && letters[index - 1] != 'ﺯ' && letters[index - 1] != 'ﮊ' && letters[index - 1] != 'ﻭ' && letters[index - 1] != 'ﺁ' && letters[index - 1] != 'ﺃ' && letters[index - 1] != 'ﺇ' && letters[index - 1] != 'ﺅ' && letters[index - 1] != 'ﺀ' && !char.IsPunctuation(letters[index - 1]) && letters[index - 1] != '>' && letters[index - 1] != '<' && letters[index - 1] != ' ') && letters[index - 1] != '*';
			if (index < letters.Length - 1 && (letters[index + 1] != ' ' && letters[index + 1] != '\r' && letters[index + 1] != 'ﺀ' && !char.IsNumber(letters[index + 1]) && !char.IsSymbol(letters[index + 1])) && !char.IsPunctuation(letters[index + 1]) && flag2 && flag)
			{
				try
				{
					if (char.IsPunctuation(letters[index + 1]))
					{
						return false;
					}
					return true;
				}
				catch
				{
					return false;
				}
				return false;
			}
			return false;
		}

		// Token: 0x04001068 RID: 4200
		internal static bool showTashkeel = true;

		// Token: 0x04001069 RID: 4201
		internal static bool useHinduNumbers;
	}
}
