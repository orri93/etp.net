// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.ChannelDataFrame
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class ChannelDataFrameSet : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""ChannelDataFrameSet"",""namespace"":""Energistics.Etp.v12.Protocol.ChannelDataFrame"",""fields"":[{""name"":""channels"",""type"":{""type"":""array"",""items"":""long""}},{""name"":""data"",""type"":{""type"":""array"",""items"":{""type"":""record"",""name"":""DataFrame"",""namespace"":""Energistics.Etp.v12.Datatypes.ChannelData"",""fields"":[{""name"":""index"",""type"":{""type"":""array"",""items"":""long""}},{""name"":""data"",""type"":{""type"":""array"",""items"":{""type"":""record"",""name"":""DataValue"",""namespace"":""Energistics.Etp.v12.Datatypes"",""fields"":[{""name"":""item"",""type"":[""null"",""double"",""float"",""int"",""long"",""string"",{""type"":""record"",""name"":""ArrayOfDouble"",""namespace"":""Energistics.Etp.v12.Datatypes"",""fields"":[{""name"":""values"",""type"":{""type"":""array"",""items"":""double""}}],""fullName"":""Energistics.Etp.v12.Datatypes.ArrayOfDouble"",""depends"":[]},""boolean"",""bytes""]}],""fullName"":""Energistics.Etp.v12.Datatypes.DataValue"",""depends"":[
  ""Energistics.Etp.v12.Datatypes.ArrayOfDouble""
]}}}],""fullName"":""Energistics.Etp.v12.Datatypes.ChannelData.DataFrame"",""depends"":[
  ""Energistics.Etp.v12.Datatypes.DataValue""
]}}}],""messageType"":""4"",""protocol"":""2"",""senderRole"":""producer"",""protocolRoles"":""producer,consumer"",""fullName"":""Energistics.Etp.v12.Protocol.ChannelDataFrame.ChannelDataFrameSet"",""depends"":[
  ""Energistics.Etp.v12.Datatypes.ChannelData.DataFrame""
]}");
		private IList<System.Int64> _channels;
		private IList<Energistics.Etp.v12.Datatypes.ChannelData.DataFrame> _data;
		public virtual Schema Schema
		{
			get
			{
				return ChannelDataFrameSet._SCHEMA;
			}
		}
		public IList<System.Int64> Channels
		{
			get
			{
				return this._channels;
			}
			set
			{
				this._channels = value;
			}
		}
		public IList<Energistics.Etp.v12.Datatypes.ChannelData.DataFrame> Data
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
			case 0: return this._channels;
			case 1: return this._data;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._channels = (IList<System.Int64>)fieldValue; break;
			case 1: this._data = (IList<Energistics.Etp.v12.Datatypes.ChannelData.DataFrame>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
