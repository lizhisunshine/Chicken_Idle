using System;

namespace I2.Loc
{
	// Token: 0x02000066 RID: 102
	public class GlobalParametersExample : RegisterGlobalParameters
	{
		// Token: 0x060002CB RID: 715 RVA: 0x00057AB4 File Offset: 0x00055CB4
		public override string GetParameterValue(string ParamName)
		{
			if (ParamName == "WINNER")
			{
				return "Javier";
			}
			if (ParamName == "NUM PLAYERS")
			{
				return 5.ToString();
			}
			return null;
		}
	}
}
