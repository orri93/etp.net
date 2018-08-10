// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.ChannelStreaming
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class ChannelStatusChange : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""ChannelStatusChange"",""namespace"":""Energistics.Etp.v12.Protocol.ChannelStreaming"",""fields"":[{""name"":""channelId"",""type"":""long""},{""name"":""status"",""type"":{""type"":""enum"",""name"":""ChannelStatuses"",""namespace"":""Energistics.Etp.v12.Datatypes.ChannelData"",""symbols"":[""Active"",""Inactive"",""Closed""],""fullName"":""Energistics.Etp.v12.Datatypes.ChannelData.ChannelStatuses"",""depends"":[]}}],""messageType"":""10"",""protocol"":""1"",""senderRole"":""producer"",""protocolRoles"":""producer,consumer"",""fullName"":""Energistics.Etp.v12.Protocol.ChannelStreaming.ChannelStatusChange"",""depends"":[
  ""Energistics.Etp.v12.Datatypes.ChannelData.ChannelStatuses""
]}");
		private long _channelId;
		private Energistics.Etp.v12.Datatypes.ChannelData.ChannelStatuses _status;
		public virtual Schema Schema
		{
			get
			{
				return ChannelStatusChange._SCHEMA;
			}
		}
		public long ChannelId
		{
			get
			{
				return this._channelId;
			}
			set
			{
				this._channelId = value;
			}
		}
		public Energistics.Etp.v12.Datatypes.ChannelData.ChannelStatuses Status
		{
			get
			{
				return this._status;
			}
			set
			{
				this._status = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._channelId;
			case 1: return this._status;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._channelId = (System.Int64)fieldValue; break;
			case 1: this._status = (Energistics.Etp.v12.Datatypes.ChannelData.ChannelStatuses)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
