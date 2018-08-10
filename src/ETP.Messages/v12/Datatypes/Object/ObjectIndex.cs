// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Datatypes.Object
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class ObjectIndex : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""ObjectIndex"",""namespace"":""Energistics.Etp.v12.Datatypes.Object"",""fields"":[{""name"":""indexValue"",""type"":{""type"":""record"",""name"":""IndexValue"",""namespace"":""Energistics.Etp.v12.Datatypes"",""fields"":[{""name"":""item"",""type"":[""null"",""double"",""long""]}],""fullName"":""Energistics.Etp.v12.Datatypes.IndexValue"",""depends"":[]}},{""name"":""uom"",""type"":""string""},{""name"":""depthDatum"",""default"":"""",""type"":""string""}],""fullName"":""Energistics.Etp.v12.Datatypes.Object.ObjectIndex"",""depends"":[
  ""Energistics.Etp.v12.Datatypes.IndexValue""
]}");
		private Energistics.Etp.v12.Datatypes.IndexValue _indexValue;
		private string _uom;
		private string _depthDatum;
		public virtual Schema Schema
		{
			get
			{
				return ObjectIndex._SCHEMA;
			}
		}
		public Energistics.Etp.v12.Datatypes.IndexValue IndexValue
		{
			get
			{
				return this._indexValue;
			}
			set
			{
				this._indexValue = value;
			}
		}
		public string Uom
		{
			get
			{
				return this._uom;
			}
			set
			{
				this._uom = value;
			}
		}
		public string DepthDatum
		{
			get
			{
				return this._depthDatum;
			}
			set
			{
				this._depthDatum = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._indexValue;
			case 1: return this._uom;
			case 2: return this._depthDatum;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._indexValue = (Energistics.Etp.v12.Datatypes.IndexValue)fieldValue; break;
			case 1: this._uom = (System.String)fieldValue; break;
			case 2: this._depthDatum = (System.String)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
