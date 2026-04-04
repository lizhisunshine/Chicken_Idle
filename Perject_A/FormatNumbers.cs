using System;
using UnityEngine;

// Token: 0x02000027 RID: 39
public class FormatNumbers : MonoBehaviour
{
	// Token: 0x060000F4 RID: 244 RVA: 0x000133CC File Offset: 0x000115CC
	public static string FormatPoints(double gold)
	{
		string result;
		if (gold >= 1E+51)
		{
			if (gold >= 1E+75)
			{
				if (gold >= 1E+81)
				{
					if (gold >= 1E+87)
					{
						if (gold < 1E+90)
						{
							result = (gold / 1E+72).ToString("0.##") + "ovt";
						}
						else
						{
							result = (gold / 1E+72).ToString("0.##") + "nvt";
						}
					}
					else if (gold < 1E+84)
					{
						result = (gold / 1E+72).ToString("0.##") + "svt";
					}
					else
					{
						result = (gold / 1E+72).ToString("0.##") + "stt";
					}
				}
				else if (gold < 1E+78)
				{
					result = (gold / 1E+72).ToString("0.##") + "qtv";
				}
				else
				{
					result = (gold / 1E+72).ToString("0.##") + "qvt";
				}
			}
			else if (gold >= 1E+63)
			{
				if (gold >= 1E+69)
				{
					if (gold < 1E+72)
					{
						result = (gold / 1E+69).ToString("0.##") + "dt";
					}
					else
					{
						result = (gold / 1E+72).ToString("0.##") + "tt";
					}
				}
				else if (gold < 1E+66)
				{
					result = (gold / 1E+63).ToString("0.##") + "vt";
				}
				else
				{
					result = (gold / 1E+66).ToString("0.##") + "ut";
				}
			}
			else if (gold >= 1E+57)
			{
				if (gold < 1E+60)
				{
					result = (gold / 1E+57).ToString("0.##") + "od";
				}
				else
				{
					result = (gold / 1E+60).ToString("0.##") + "nd";
				}
			}
			else if (gold < 1E+54)
			{
				result = (gold / 1E+51).ToString("0.##") + "sc";
			}
			else
			{
				result = (gold / 1E+54).ToString("0.##") + "sp";
			}
		}
		else if (gold >= 1E+27)
		{
			if (gold >= 1E+39)
			{
				if (gold >= 1E+45)
				{
					if (gold < 1E+48)
					{
						result = (gold / 1E+45).ToString("0.##") + "qtc";
					}
					else
					{
						result = (gold / 1E+48).ToString("0.##") + "qd";
					}
				}
				else if (gold < 1E+42)
				{
					result = (gold / 1E+39).ToString("0.##") + "dd";
				}
				else
				{
					result = (gold / 1E+42).ToString("0.##") + "td";
				}
			}
			else if (gold >= 1E+33)
			{
				if (gold < 1E+36)
				{
					result = (gold / 1E+33).ToString("0.##") + "d";
				}
				else
				{
					result = (gold / 1E+36).ToString("0.##") + "ud";
				}
			}
			else if (gold < 1E+30)
			{
				result = (gold / 1E+27).ToString("0.##") + "o";
			}
			else
			{
				result = (gold / 1E+30).ToString("0.##") + "n";
			}
		}
		else if (gold >= 1000000000000000.0)
		{
			if (gold >= 1E+21)
			{
				if (gold < 1E+24)
				{
					result = (gold / 1E+21).ToString("0.##") + "sx";
				}
				else
				{
					result = (gold / 1E+24).ToString("0.##") + "sp";
				}
			}
			else if (gold < 1E+18)
			{
				result = (gold / 1000000000000000.0).ToString("0.##") + "qd";
			}
			else
			{
				result = (gold / 1E+18).ToString("0.##") + "qt";
			}
		}
		else if (gold >= 1000000000.0)
		{
			if (gold < 1000000000000.0)
			{
				result = (gold / 1000000000.0).ToString("0.##") + "b";
			}
			else
			{
				result = (gold / 1000000000000.0).ToString("0.##") + "t";
			}
		}
		else if (gold < 1000000.0)
		{
			result = gold.ToString("0");
		}
		else
		{
			result = (gold / 1000000.0).ToString("0.##") + "m";
		}
		return result;
	}
}
