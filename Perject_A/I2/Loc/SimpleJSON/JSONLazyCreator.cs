using System;

namespace I2.Loc.SimpleJSON
{
	// Token: 0x020000B7 RID: 183
	internal class JSONLazyCreator : JSONNode
	{
		// Token: 0x06000572 RID: 1394 RVA: 0x00068213 File Offset: 0x00066413
		public JSONLazyCreator(JSONNode aNode)
		{
			this.m_Node = aNode;
			this.m_Key = null;
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00068229 File Offset: 0x00066429
		public JSONLazyCreator(JSONNode aNode, string aKey)
		{
			this.m_Node = aNode;
			this.m_Key = aKey;
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x0006823F File Offset: 0x0006643F
		private void Set(JSONNode aVal)
		{
			if (this.m_Key == null)
			{
				this.m_Node.Add(aVal);
			}
			else
			{
				this.m_Node.Add(this.m_Key, aVal);
			}
			this.m_Node = null;
		}

		// Token: 0x1700002E RID: 46
		public override JSONNode this[int aIndex]
		{
			get
			{
				return new JSONLazyCreator(this);
			}
			set
			{
				this.Set(new JSONArray
				{
					value
				});
			}
		}

		// Token: 0x1700002F RID: 47
		public override JSONNode this[string aKey]
		{
			get
			{
				return new JSONLazyCreator(this, aKey);
			}
			set
			{
				this.Set(new JSONClass
				{
					{
						aKey,
						value
					}
				});
			}
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x000682C8 File Offset: 0x000664C8
		public override void Add(JSONNode aItem)
		{
			this.Set(new JSONArray
			{
				aItem
			});
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x000682EC File Offset: 0x000664EC
		public override void Add(string aKey, JSONNode aItem)
		{
			this.Set(new JSONClass
			{
				{
					aKey,
					aItem
				}
			});
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x0006830E File Offset: 0x0006650E
		public static bool operator ==(JSONLazyCreator a, object b)
		{
			return b == null || a == b;
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00068319 File Offset: 0x00066519
		public static bool operator !=(JSONLazyCreator a, object b)
		{
			return !(a == b);
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00068325 File Offset: 0x00066525
		public override bool Equals(object obj)
		{
			return obj == null || this == obj;
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x00068330 File Offset: 0x00066530
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00068338 File Offset: 0x00066538
		public override string ToString()
		{
			return "";
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x0006833F File Offset: 0x0006653F
		public override string ToString(string aPrefix)
		{
			return "";
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x00068348 File Offset: 0x00066548
		// (set) Token: 0x06000582 RID: 1410 RVA: 0x00068364 File Offset: 0x00066564
		public override int AsInt
		{
			get
			{
				JSONData aVal = new JSONData(0);
				this.Set(aVal);
				return 0;
			}
			set
			{
				JSONData aVal = new JSONData(value);
				this.Set(aVal);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x00068380 File Offset: 0x00066580
		// (set) Token: 0x06000584 RID: 1412 RVA: 0x000683A4 File Offset: 0x000665A4
		public override float AsFloat
		{
			get
			{
				JSONData aVal = new JSONData(0f);
				this.Set(aVal);
				return 0f;
			}
			set
			{
				JSONData aVal = new JSONData(value);
				this.Set(aVal);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x000683C0 File Offset: 0x000665C0
		// (set) Token: 0x06000586 RID: 1414 RVA: 0x000683EC File Offset: 0x000665EC
		public override double AsDouble
		{
			get
			{
				JSONData aVal = new JSONData(0.0);
				this.Set(aVal);
				return 0.0;
			}
			set
			{
				JSONData aVal = new JSONData(value);
				this.Set(aVal);
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x00068408 File Offset: 0x00066608
		// (set) Token: 0x06000588 RID: 1416 RVA: 0x00068424 File Offset: 0x00066624
		public override bool AsBool
		{
			get
			{
				JSONData aVal = new JSONData(false);
				this.Set(aVal);
				return false;
			}
			set
			{
				JSONData aVal = new JSONData(value);
				this.Set(aVal);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x00068440 File Offset: 0x00066640
		public override JSONArray AsArray
		{
			get
			{
				JSONArray jsonarray = new JSONArray();
				this.Set(jsonarray);
				return jsonarray;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x0006845C File Offset: 0x0006665C
		public override JSONClass AsObject
		{
			get
			{
				JSONClass jsonclass = new JSONClass();
				this.Set(jsonclass);
				return jsonclass;
			}
		}

		// Token: 0x04001077 RID: 4215
		private JSONNode m_Node;

		// Token: 0x04001078 RID: 4216
		private string m_Key;
	}
}
