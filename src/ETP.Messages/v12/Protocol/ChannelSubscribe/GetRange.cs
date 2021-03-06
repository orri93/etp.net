// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.ChannelSubscribe
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class GetRange : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"GetRange\",\"namespace\":\"Energistics.Etp.v12.Protocol.Chan" +
				"nelSubscribe\",\"fields\":[{\"name\":\"requestUuid\",\"type\":{\"type\":\"fixed\",\"name\":\"Uui" +
				"d\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"size\":16,\"fullName\":\"Energistics" +
				".Etp.v12.Datatypes.Uuid\",\"depends\":[]}},{\"name\":\"channelRanges\",\"type\":{\"type\":\"" +
				"array\",\"items\":{\"type\":\"record\",\"name\":\"ChannelRangeInfo\",\"namespace\":\"Energisti" +
				"cs.Etp.v12.Datatypes.ChannelData\",\"fields\":[{\"name\":\"channelIds\",\"type\":{\"type\":" +
				"\"array\",\"items\":\"long\"}},{\"name\":\"interval\",\"type\":{\"type\":\"record\",\"name\":\"Inde" +
				"xInterval\",\"namespace\":\"Energistics.Etp.v12.Datatypes.Object\",\"fields\":[{\"name\":" +
				"\"startIndex\",\"type\":{\"type\":\"record\",\"name\":\"IndexValue\",\"namespace\":\"Energistic" +
				"s.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"item\",\"type\":[\"null\",\"long\",\"double\"]}]," +
				"\"fullName\":\"Energistics.Etp.v12.Datatypes.IndexValue\",\"depends\":[]}},{\"name\":\"en" +
				"dIndex\",\"type\":\"Energistics.Etp.v12.Datatypes.IndexValue\"},{\"name\":\"uom\",\"type\":" +
				"\"string\"},{\"name\":\"depthDatum\",\"default\":\"\",\"type\":\"string\"}],\"fullName\":\"Energi" +
				"stics.Etp.v12.Datatypes.Object.IndexInterval\",\"depends\":[\r\n  \"Energistics.Etp.v1" +
				"2.Datatypes.IndexValue\",\r\n  \"Energistics.Etp.v12.Datatypes.IndexValue\"\r\n]}}],\"fu" +
				"llName\":\"Energistics.Etp.v12.Datatypes.ChannelData.ChannelRangeInfo\",\"depends\":[" +
				"\r\n  \"Energistics.Etp.v12.Datatypes.Object.IndexInterval\"\r\n]}}}],\"protocol\":\"21\"," +
				"\"messageType\":\"9\",\"senderRole\":\"consumer\",\"protocolRoles\":\"producer,consumer\",\"m" +
				"ultipartFlag\":false,\"fullName\":\"Energistics.Etp.v12.Protocol.ChannelSubscribe.Ge" +
				"tRange\",\"depends\":[\r\n  \"Energistics.Etp.v12.Datatypes.Uuid\",\r\n  \"Energistics.Etp" +
				".v12.Datatypes.ChannelData.ChannelRangeInfo\"\r\n]}");
		private Energistics.Etp.v12.Datatypes.Uuid _requestUuid;
		private IList<Energistics.Etp.v12.Datatypes.ChannelData.ChannelRangeInfo> _channelRanges;
		public virtual Schema Schema
		{
			get
			{
				return GetRange._SCHEMA;
			}
		}
		public Energistics.Etp.v12.Datatypes.Uuid RequestUuid
		{
			get
			{
				return this._requestUuid;
			}
			set
			{
				this._requestUuid = value;
			}
		}
		public IList<Energistics.Etp.v12.Datatypes.ChannelData.ChannelRangeInfo> ChannelRanges
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
			case 0: return this._requestUuid;
			case 1: return this._channelRanges;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._requestUuid = (Energistics.Etp.v12.Datatypes.Uuid)fieldValue; break;
			case 1: this._channelRanges = (IList<Energistics.Etp.v12.Datatypes.ChannelData.ChannelRangeInfo>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
