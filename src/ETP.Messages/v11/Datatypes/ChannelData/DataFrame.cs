// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v11.Datatypes.ChannelData
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class DataFrame : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""DataFrame"",""namespace"":""Energistics.Datatypes.ChannelData"",""fields"":[{""name"":""index"",""type"":{""type"":""array"",""items"":""long""}},{""name"":""data"",""type"":{""type"":""array"",""items"":{""type"":""record"",""name"":""DataValue"",""namespace"":""Energistics.Datatypes"",""fields"":[{""name"":""item"",""type"":[""null"",""double"",""float"",""int"",""long"",""string"",{""type"":""record"",""name"":""ArrayOfDouble"",""namespace"":""Energistics.Datatypes"",""fields"":[{""name"":""values"",""type"":{""type"":""array"",""items"":""double""}}],""fullName"":""Energistics.Datatypes.ArrayOfDouble"",""depends"":[]},""boolean"",""bytes""]}],""fullName"":""Energistics.Datatypes.DataValue"",""depends"":[
  ""Energistics.Datatypes.ArrayOfDouble""
]}}}],""fullName"":""Energistics.Datatypes.ChannelData.DataFrame"",""depends"":[
  ""Energistics.Datatypes.DataValue""
]}");
		private IList<System.Int64> _index;
		private IList<Energistics.Etp.v11.Datatypes.DataValue> _data;
		public virtual Schema Schema
		{
			get
			{
				return DataFrame._SCHEMA;
			}
		}
		public IList<System.Int64> Index
		{
			get
			{
				return this._index;
			}
			set
			{
				this._index = value;
			}
		}
		public IList<Energistics.Etp.v11.Datatypes.DataValue> Data
		{
			get
			{
				return this._data;
			}
			set
			{
				this._data = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._index;
			case 1: return this._data;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._index = (IList<System.Int64>)fieldValue; break;
			case 1: this._data = (IList<Energistics.Etp.v11.Datatypes.DataValue>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
