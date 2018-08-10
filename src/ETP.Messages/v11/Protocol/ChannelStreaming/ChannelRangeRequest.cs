// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v11.Protocol.ChannelStreaming
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class ChannelRangeRequest : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""ChannelRangeRequest"",""namespace"":""Energistics.Protocol.ChannelStreaming"",""fields"":[{""name"":""channelRanges"",""type"":{""type"":""array"",""items"":{""type"":""record"",""name"":""ChannelRangeInfo"",""namespace"":""Energistics.Datatypes.ChannelData"",""fields"":[{""name"":""channelId"",""type"":{""type"":""array"",""items"":""long""}},{""name"":""startIndex"",""type"":""long""},{""name"":""endIndex"",""type"":""long""}],""fullName"":""Energistics.Datatypes.ChannelData.ChannelRangeInfo"",""depends"":[]}}}],""messageType"":""9"",""protocol"":""1"",""senderRole"":""consumer"",""protocolRoles"":""producer,consumer"",""fullName"":""Energistics.Protocol.ChannelStreaming.ChannelRangeRequest"",""depends"":[
  ""Energistics.Datatypes.ChannelData.ChannelRangeInfo""
]}");
		private IList<Energistics.Etp.v11.Datatypes.ChannelData.ChannelRangeInfo> _channelRanges;
		public virtual Schema Schema
		{
			get
			{
				return ChannelRangeRequest._SCHEMA;
			}
		}
		public IList<Energistics.Etp.v11.Datatypes.ChannelData.ChannelRangeInfo> ChannelRanges
		{
			get
			{
				return this._channelRanges;
			}
			set
			{
				this._channelRanges = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._channelRanges;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._channelRanges = (IList<Energistics.Etp.v11.Datatypes.ChannelData.ChannelRangeInfo>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
