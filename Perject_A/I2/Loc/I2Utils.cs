using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

namespace I2.Loc
{
	// Token: 0x020000A0 RID: 160
	public static class I2Utils
	{
		// Token: 0x060004CD RID: 1229 RVA: 0x00064CD0 File Offset: 0x00062ED0
		public static string ReverseText(string source)
		{
			I2Utils.<>c__DisplayClass3_0 CS$<>8__locals1;
			CS$<>8__locals1.source = source;
			int length = CS$<>8__locals1.source.Length;
			CS$<>8__locals1.output = new char[length];
			char[] anyOf = new char[]
			{
				'\r',
				'\n'
			};
			int i = 0;
			while (i < length)
			{
				int num = CS$<>8__locals1.source.IndexOfAny(anyOf, i);
				if (num < 0)
				{
					num = length;
				}
				I2Utils.<ReverseText>g__Reverse|3_0(i, num - 1, ref CS$<>8__locals1);
				i = num;
				while (i < length && (CS$<>8__locals1.source[i] == '\r' || CS$<>8__locals1.source[i] == '\n'))
				{
					CS$<>8__locals1.output[i] = CS$<>8__locals1.source[i];
					i++;
				}
			}
			return new string(CS$<>8__locals1.output);
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00064D88 File Offset: 0x00062F88
		public static string GetValidTermName(string text, bool allowCategory = false)
		{
			if (text == null)
			{
				return null;
			}
			StringBuilder stringBuilder = new StringBuilder();
			bool flag = false;
			char c = '\0';
			bool flag2 = false;
			for (int i = 0; i < text.Length; i++)
			{
				char c2 = text[i];
				bool flag3 = true;
				if ((c2 == '{' || c2 == '[' || c2 == '<') && !flag)
				{
					if (c2 != '{' || i + 1 >= text.Length || text[i + 1] == '[')
					{
						flag = true;
						flag3 = false;
						c = c2;
					}
				}
				else if (flag && ((c2 == '}' && c == '{') || (c2 == ']' && c == '[') || (c2 == '>' && c == '<')))
				{
					flag = false;
					flag3 = false;
				}
				else if (flag)
				{
					flag3 = false;
				}
				if (flag3)
				{
					char value = ' ';
					if ((allowCategory && (c2 == '\\' || c2 == '"' || c2 == '/')) || char.IsLetterOrDigit(c2) || ".-_$#@*()[]{}+:?!&',^=<>~`".IndexOf(c2) >= 0)
					{
						value = c2;
					}
					if (char.IsWhiteSpace(c2))
					{
						if (!flag2)
						{
							if (stringBuilder.Length > 0)
							{
								stringBuilder.Append(' ');
							}
							flag2 = true;
						}
					}
					else
					{
						flag2 = false;
						stringBuilder.Append(value);
					}
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00064EAC File Offset: 0x000630AC
		public static string SplitLine(string line, int maxCharacters)
		{
			if (maxCharacters <= 0 || line.Length < maxCharacters)
			{
				return line;
			}
			char[] array = line.ToCharArray();
			bool flag = true;
			bool flag2 = false;
			int i = 0;
			int num = 0;
			while (i < array.Length)
			{
				if (flag)
				{
					num++;
					if (array[i] == '\n')
					{
						num = 0;
					}
					if (num >= maxCharacters && char.IsWhiteSpace(array[i]))
					{
						array[i] = '\n';
						flag = false;
						flag2 = false;
					}
				}
				else if (!char.IsWhiteSpace(array[i]))
				{
					flag = true;
					num = 0;
				}
				else if (array[i] != '\n')
				{
					array[i] = '\0';
				}
				else
				{
					if (!flag2)
					{
						array[i] = '\0';
					}
					flag2 = true;
				}
				i++;
			}
			return new string((from c in array
			where c > '\0'
			select c).ToArray<char>());
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00064F68 File Offset: 0x00063168
		public static bool FindNextTag(string line, int iStart, out int tagStart, out int tagEnd)
		{
			tagStart = -1;
			tagEnd = -1;
			int length = line.Length;
			tagStart = iStart;
			while (tagStart < length && line[tagStart] != '[' && line[tagStart] != '(' && line[tagStart] != '{' && line[tagStart] != '<')
			{
				tagStart++;
			}
			if (tagStart == length)
			{
				return false;
			}
			bool flag = false;
			for (tagEnd = tagStart + 1; tagEnd < length; tagEnd++)
			{
				char c = line[tagEnd];
				if (c == ']' || c == ')' || c == '}' || c == '>')
				{
					return !flag || I2Utils.FindNextTag(line, tagEnd + 1, out tagStart, out tagEnd);
				}
				if (c > 'ÿ')
				{
					flag = true;
				}
			}
			return false;
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00065018 File Offset: 0x00063218
		public static string RemoveTags(string text)
		{
			return Regex.Replace(text, "\\{\\[(.*?)]}|\\[(.*?)]|\\<(.*?)>", "");
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x0006502C File Offset: 0x0006322C
		public static bool RemoveResourcesPath(ref string sPath)
		{
			int num = sPath.IndexOf("\\Resources\\", StringComparison.Ordinal);
			int num2 = sPath.IndexOf("\\Resources/", StringComparison.Ordinal);
			int num3 = sPath.IndexOf("/Resources\\", StringComparison.Ordinal);
			int num4 = sPath.IndexOf("/Resources/", StringComparison.Ordinal);
			int num5 = Mathf.Max(new int[]
			{
				num,
				num2,
				num3,
				num4
			});
			bool result = false;
			if (num5 >= 0)
			{
				sPath = sPath.Substring(num5 + 11);
				result = true;
			}
			else
			{
				num5 = sPath.LastIndexOfAny(LanguageSourceData.CategorySeparators);
				if (num5 > 0)
				{
					sPath = sPath.Substring(num5 + 1);
				}
			}
			string extension = Path.GetExtension(sPath);
			if (!string.IsNullOrEmpty(extension))
			{
				sPath = sPath.Substring(0, sPath.Length - extension.Length);
			}
			return result;
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x000650F6 File Offset: 0x000632F6
		public static bool IsPlaying()
		{
			return Application.isPlaying;
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00065104 File Offset: 0x00063304
		public static string GetPath(this Transform tr)
		{
			Transform parent = tr.parent;
			if (tr == null)
			{
				return tr.name;
			}
			return parent.GetPath() + "/" + tr.name;
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x0006513E File Offset: 0x0006333E
		public static Transform FindObject(string objectPath)
		{
			return I2Utils.FindObject(SceneManager.GetActiveScene(), objectPath);
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x0006514C File Offset: 0x0006334C
		public static Transform FindObject(Scene scene, string objectPath)
		{
			GameObject[] rootGameObjects = scene.GetRootGameObjects();
			for (int i = 0; i < rootGameObjects.Length; i++)
			{
				Transform transform = rootGameObjects[i].transform;
				if (transform.name == objectPath)
				{
					return transform;
				}
				if (objectPath.StartsWith(transform.name + "/", StringComparison.Ordinal))
				{
					return I2Utils.FindObject(transform, objectPath.Substring(transform.name.Length + 1));
				}
			}
			return null;
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x000651BC File Offset: 0x000633BC
		public static Transform FindObject(Transform root, string objectPath)
		{
			for (int i = 0; i < root.childCount; i++)
			{
				Transform child = root.GetChild(i);
				if (child.name == objectPath)
				{
					return child;
				}
				if (objectPath.StartsWith(child.name + "/", StringComparison.Ordinal))
				{
					return I2Utils.FindObject(child, objectPath.Substring(child.name.Length + 1));
				}
			}
			return null;
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00065228 File Offset: 0x00063428
		public static H FindInParents<H>(Transform tr) where H : Component
		{
			if (!tr)
			{
				return default(H);
			}
			H component = tr.GetComponent<H>();
			while (!component && tr)
			{
				component = tr.GetComponent<H>();
				tr = tr.parent;
			}
			return component;
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00065278 File Offset: 0x00063478
		public static string GetCaptureMatch(Match match)
		{
			for (int i = match.Groups.Count - 1; i >= 0; i--)
			{
				if (match.Groups[i].Success)
				{
					return match.Groups[i].ToString();
				}
			}
			return match.ToString();
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x000652C8 File Offset: 0x000634C8
		public static void SendWebRequest(UnityWebRequest www)
		{
			www.SendWebRequest();
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x000652D4 File Offset: 0x000634D4
		[CompilerGenerated]
		internal static void <ReverseText>g__Reverse|3_0(int start, int end, ref I2Utils.<>c__DisplayClass3_0 A_2)
		{
			for (int i = 0; i <= end - start; i++)
			{
				A_2.output[end - i] = A_2.source[start + i];
			}
		}

		// Token: 0x04001000 RID: 4096
		public const string ValidChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_";

		// Token: 0x04001001 RID: 4097
		public const string NumberChars = "0123456789";

		// Token: 0x04001002 RID: 4098
		public const string ValidNameSymbols = ".-_$#@*()[]{}+:?!&',^=<>~`";
	}
}
