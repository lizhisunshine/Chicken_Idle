using System;
using System.IO;

namespace I2.Loc.SimpleJSON
{
	// Token: 0x020000B6 RID: 182
	public class JSONData : JSONNode
	{
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x00068088 File Offset: 0x00066288
		// (set) Token: 0x06000569 RID: 1385 RVA: 0x00068090 File Offset: 0x00066290
		public override string Value
		{
			get
			{
				return this.m_Data;
			}
			set
			{
				this.m_Data = value;
			}
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00068099 File Offset: 0x00066299
		public JSONData(string aData)
		{
			this.m_Data = aData;
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x000680A8 File Offset: 0x000662A8
		public JSONData(float aData)
		{
			this.AsFloat = aData;
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x000680B7 File Offset: 0x000662B7
		public JSONData(double aData)
		{
			this.AsDouble = aData;
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x000680C6 File Offset: 0x000662C6
		public JSONData(bool aData)
		{
			this.AsBool = aData;
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x000680D5 File Offset: 0x000662D5
		public JSONData(int aData)
		{
			this.AsInt = aData;
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x000680E4 File Offset: 0x000662E4
		public override string ToString()
		{
			return "\"" + JSONNode.Escape(this.m_Data) + "\"";
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00068100 File Offset: 0x00066300
		public override string ToString(string aPrefix)
		{
			return "\"" + JSONNode.Escape(this.m_Data) + "\"";
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x0006811C File Offset: 0x0006631C
		public override void Serialize(BinaryWriter aWriter)
		{
			JSONData jsondata = new JSONData("");
			jsondata.AsInt = this.AsInt;
			if (jsondata.m_Data == this.m_Data)
			{
				aWriter.Write(4);
				aWriter.Write(this.AsInt);
				return;
			}
			jsondata.AsFloat = this.AsFloat;
			if (jsondata.m_Data == this.m_Data)
			{
				aWriter.Write(7);
				aWriter.Write(this.AsFloat);
				return;
			}
			jsondata.AsDouble = this.AsDouble;
			if (jsondata.m_Data == this.m_Data)
			{
				aWriter.Write(5);
				aWriter.Write(this.AsDouble);
				return;
			}
			jsondata.AsBool = this.AsBool;
			if (jsondata.m_Data == this.m_Data)
			{
				aWriter.Write(6);
				aWriter.Write(this.AsBool);
				return;
			}
			aWriter.Write(3);
			aWriter.Write(this.m_Data);
		}

		// Token: 0x04001076 RID: 4214
		private string m_Data;
	}
}
