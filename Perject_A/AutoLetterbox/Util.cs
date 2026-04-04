using System;
using System.Globalization;
using System.Linq.Expressions;
using UnityEngine;

namespace AutoLetterbox
{
	// Token: 0x020000CC RID: 204
	public static class Util
	{
		// Token: 0x060005DF RID: 1503 RVA: 0x0006AA23 File Offset: 0x00068C23
		public static string GrootWhatAreYouDoing()
		{
			return "I am Groot.";
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x0006AA2A File Offset: 0x00068C2A
		public static float AsPositive(float value)
		{
			return Mathf.Abs(value);
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x0006AA32 File Offset: 0x00068C32
		public static float AsNegative(float value)
		{
			return -Mathf.Abs(value);
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x0006AA3C File Offset: 0x00068C3C
		public static float BezierCurve(float[] p, float t)
		{
			if (p.Length > 2)
			{
				float[] array = new float[p.Length - 1];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = Util.Lerp(p[i], p[i + 1], t);
				}
				return Util.BezierCurve(array, t);
			}
			if (p.Length == 2)
			{
				return Util.Lerp(p[0], p[1], t);
			}
			Debug.Log("WARNING: A class attempted to get a Bezier Curve with less than two points!");
			return 0f;
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x0006AAA4 File Offset: 0x00068CA4
		public static Vector3 BezierCurve(Vector3[] p, float t)
		{
			if (p.Length > 2)
			{
				Vector3[] array = new Vector3[p.Length - 1];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = Util.Lerp(p[i], p[i + 1], t);
				}
				return Util.BezierCurve(array, t);
			}
			if (p.Length == 2)
			{
				return Util.Lerp(p[0], p[1], t);
			}
			return Vector3.zero;
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x0006AB18 File Offset: 0x00068D18
		public static Vector3 CalculateReflectedVelocity(Vector3 originalVelocity, Vector3 normalOfCollision)
		{
			Vector3 vector = -normalOfCollision;
			Vector3 vector2 = originalVelocity.normalized;
			vector2 = new Vector3(vector2.x - vector.x, vector2.y - vector.y, 0f);
			if (vector2.sqrMagnitude == 0f)
			{
				vector2 = -originalVelocity.normalized;
			}
			return vector2;
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x0006AB76 File Offset: 0x00068D76
		public static float Clamp(float min, float max, float value)
		{
			value = ((value < min) ? min : value);
			value = ((value > max) ? max : value);
			return value;
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x0006AB8D File Offset: 0x00068D8D
		public static int Clamp(int min, int max, int value)
		{
			value = ((value < min) ? min : value);
			value = ((value > max) ? max : value);
			return value;
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x0006ABA4 File Offset: 0x00068DA4
		public static string ColorToHex(Color32 color)
		{
			return color.r.ToString("X2") + color.g.ToString("X2") + color.b.ToString("X2");
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x0006ABDE File Offset: 0x00068DDE
		public static Vector2 DegreesToVector(float _angle)
		{
			return new Vector2((float)Math.Cos((double)(_angle * 0.017453292f)), (float)Math.Sin((double)(_angle * 0.017453292f)));
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x0006AC01 File Offset: 0x00068E01
		public static float Difference(float a, float b)
		{
			if (a <= b)
			{
				return b - a;
			}
			return a - b;
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x0006AC0E File Offset: 0x00068E0E
		public static int Difference(int a, int b)
		{
			if (a <= b)
			{
				return b - a;
			}
			return a - b;
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x0006AC1C File Offset: 0x00068E1C
		public static Vector3 DirectionVector(Vector3 origin, Vector3 target)
		{
			return (target - origin).normalized;
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x0006AC38 File Offset: 0x00068E38
		public static void Error(object sender, string error)
		{
			if (sender != null)
			{
				Debug.Log(sender.GetType().ToString() + ": " + error);
				return;
			}
			Debug.Log("NULL SENDER: " + error);
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x0006AC69 File Offset: 0x00068E69
		public static string GetMemberName<T>(Expression<Func<T>> expression)
		{
			return ((MemberExpression)expression.Body).Member.Name;
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x0006AC80 File Offset: 0x00068E80
		public static Color HexToColor(string hex)
		{
			byte r = byte.Parse(hex.Substring(0, 2), NumberStyles.HexNumber);
			byte g = byte.Parse(hex.Substring(2, 2), NumberStyles.HexNumber);
			byte b = byte.Parse(hex.Substring(4, 2), NumberStyles.HexNumber);
			return new Color32(r, g, b, byte.MaxValue);
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x0006ACD8 File Offset: 0x00068ED8
		public static int IndexToFlags(int _index)
		{
			switch (_index)
			{
			case 0:
				return 1;
			case 1:
				return 2;
			case 2:
				return 4;
			case 3:
				return 8;
			case 4:
				return 16;
			case 5:
				return 32;
			case 6:
				return 64;
			case 7:
				return 128;
			case 8:
				return 256;
			case 9:
				return 512;
			default:
				return -1;
			}
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x0006AD39 File Offset: 0x00068F39
		public static bool IsOdd(int value)
		{
			return value % 2 != 0;
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x0006AD41 File Offset: 0x00068F41
		public static Vector3 Lerp(Vector3 p1, Vector3 p2, float t)
		{
			return p1 + (p2 - p1) * t;
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x0006AD56 File Offset: 0x00068F56
		public static float Lerp(float p1, float p2, float t)
		{
			return p1 + (p2 - p1) * t;
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x0006AD60 File Offset: 0x00068F60
		public static void NullError(object sender, string variableName, string extraNotes = "")
		{
			if (sender == null)
			{
				Debug.Log("NULL SENDER: " + variableName + " is null! " + extraNotes);
				return;
			}
			Debug.Log(string.Concat(new string[]
			{
				sender.GetType().ToString(),
				": ",
				variableName,
				" is null! ",
				extraNotes
			}));
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x0006ADBD File Offset: 0x00068FBD
		public static float Percent(float min, float max, float value)
		{
			if (max - min == 0f)
			{
				return 0f;
			}
			return Util.Clamp(0f, 1f, (value - min) / (max - min));
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x0006ADE5 File Offset: 0x00068FE5
		public static float PercentUnclampled(float min, float max, float value)
		{
			if (max - min == 0f)
			{
				Debug.Log("WARNING: A class attempted to find an unclamped percentage of 0!");
				return 0f;
			}
			return (value - min) / (max - min);
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x0006AE08 File Offset: 0x00069008
		public static bool RectContainsRect(Vector2 extremeMinA, Vector2 extremeMaxA, Vector2 extremeMinB, Vector2 extremeMaxB)
		{
			return extremeMinA.y <= extremeMaxB.y && extremeMaxA.y >= extremeMinB.y && extremeMinA.x <= extremeMaxB.x && extremeMaxA.x >= extremeMinB.x;
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x0006AE45 File Offset: 0x00069045
		public static Vector3 ReflectOnXAxis(Vector3 _vector)
		{
			_vector.x = -_vector.x;
			return _vector;
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x0006AE56 File Offset: 0x00069056
		public static Vector3 ReflectOnXandYAxis(Vector3 _vector)
		{
			_vector.x = -_vector.x;
			_vector.y = -_vector.y;
			return _vector;
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x0006AE75 File Offset: 0x00069075
		public static Vector3 ReflectOnYAxis(Vector3 _vector)
		{
			_vector.y = -_vector.y;
			return _vector;
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x0006AE88 File Offset: 0x00069088
		public static float VectorToDegrees(Vector2 _vector)
		{
			float num = Mathf.Atan2(_vector.y, _vector.x) * 57.29578f;
			if (num <= 0f)
			{
				return num + 360f;
			}
			return num;
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x0006AEBF File Offset: 0x000690BF
		public static Vector3 XYplaneUpDirection()
		{
			return new Vector3(0f, 0f, -1f);
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x0006AED8 File Offset: 0x000690D8
		public static bool IsPointOnMainCamera(Vector3 _point)
		{
			if (Camera.main == null)
			{
				return false;
			}
			Vector3 vector = Camera.main.WorldToScreenPoint(_point);
			return vector.x >= 0f && vector.y <= (float)Screen.width && vector.y >= 0f && vector.y <= (float)Screen.height;
		}
	}
}
