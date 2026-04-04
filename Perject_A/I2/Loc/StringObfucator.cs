using System;
using System.Text;

namespace I2.Loc
{
	// Token: 0x020000B1 RID: 177
	public class StringObfucator
	{
		// Token: 0x06000513 RID: 1299 RVA: 0x00066F38 File Offset: 0x00065138
		public static string Encode(string NormalString)
		{
			string result;
			try
			{
				result = StringObfucator.ToBase64(StringObfucator.XoREncode(NormalString));
			}
			catch (Exception)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00066F6C File Offset: 0x0006516C
		public static string Decode(string ObfucatedString)
		{
			string result;
			try
			{
				result = StringObfucator.XoREncode(StringObfucator.FromBase64(ObfucatedString));
			}
			catch (Exception)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00066FA0 File Offset: 0x000651A0
		private static string ToBase64(string regularString)
		{
			return Convert.ToBase64String(Encoding.UTF8.GetBytes(regularString));
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00066FB4 File Offset: 0x000651B4
		private static string FromBase64(string base64string)
		{
			byte[] array = Convert.FromBase64String(base64string);
			return Encoding.UTF8.GetString(array, 0, array.Length);
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00066FD8 File Offset: 0x000651D8
		private static string XoREncode(string NormalString)
		{
			string result;
			try
			{
				char[] stringObfuscatorPassword = StringObfucator.StringObfuscatorPassword;
				char[] array = NormalString.ToCharArray();
				int num = stringObfuscatorPassword.Length;
				int i = 0;
				int num2 = array.Length;
				while (i < num2)
				{
					array[i] = (array[i] ^ stringObfuscatorPassword[i % num] ^ (char)((byte)((i % 2 == 0) ? (i * 23) : (-i * 51))));
					i++;
				}
				result = new string(array);
			}
			catch (Exception)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0400106B RID: 4203
		public static char[] StringObfuscatorPassword = "ÝúbUu¸CÁÂ§*4PÚ©-á©¾@T6Dl±ÒWâuzÅm4GÐóØ$=Íg,¥Që®iKEßr¡×60Ít4öÃ~^«y:Èd1<QÛÝúbUu¸CÁÂ§*4PÚ©-á©¾@T6Dl±ÒWâuzÅm4GÐóØ$=Íg,¥Që®iKEßr¡×60Ít4öÃ~^«y:Èd".ToCharArray();
	}
}
