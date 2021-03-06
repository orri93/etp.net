// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.ChannelDataLoad
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class OpenChannel : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"OpenChannel\",\"namespace\":\"Energistics.Etp.v12.Protocol.C" +
				"hannelDataLoad\",\"fields\":[{\"name\":\"channels\",\"type\":{\"type\":\"array\",\"items\":{\"ty" +
				"pe\":\"record\",\"name\":\"ChannelMetadataRecord\",\"namespace\":\"Energistics.Etp.v12.Dat" +
				"atypes.ChannelData\",\"fields\":[{\"name\":\"uri\",\"type\":\"string\"},{\"name\":\"id\",\"type\"" +
				":\"long\"},{\"name\":\"indexes\",\"default\":[],\"type\":{\"type\":\"array\",\"items\":{\"type\":\"" +
				"record\",\"name\":\"IndexMetadataRecord\",\"namespace\":\"Energistics.Etp.v12.Datatypes." +
				"ChannelData\",\"fields\":[{\"name\":\"indexKind\",\"default\":\"Time\",\"type\":{\"type\":\"enum" +
				"\",\"name\":\"ChannelIndexKind\",\"namespace\":\"Energistics.Etp.v12.Datatypes.ChannelDa" +
				"ta\",\"symbols\":[\"Time\",\"Depth\"],\"fullName\":\"Energistics.Etp.v12.Datatypes.Channel" +
				"Data.ChannelIndexKind\",\"depends\":[]}},{\"name\":\"interval\",\"type\":{\"type\":\"record\"" +
				",\"name\":\"IndexInterval\",\"namespace\":\"Energistics.Etp.v12.Datatypes.Object\",\"fiel" +
				"ds\":[{\"name\":\"startIndex\",\"type\":{\"type\":\"record\",\"name\":\"IndexValue\",\"namespace" +
				"\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"item\",\"type\":[\"null\",\"long\"" +
				",\"double\"]}],\"fullName\":\"Energistics.Etp.v12.Datatypes.IndexValue\",\"depends\":[]}" +
				"},{\"name\":\"endIndex\",\"type\":\"Energistics.Etp.v12.Datatypes.IndexValue\"},{\"name\":" +
				"\"uom\",\"type\":\"string\"},{\"name\":\"depthDatum\",\"default\":\"\",\"type\":\"string\"}],\"full" +
				"Name\":\"Energistics.Etp.v12.Datatypes.Object.IndexInterval\",\"depends\":[\r\n  \"Energ" +
				"istics.Etp.v12.Datatypes.IndexValue\",\r\n  \"Energistics.Etp.v12.Datatypes.IndexVal" +
				"ue\"\r\n]}},{\"name\":\"direction\",\"default\":\"Increasing\",\"type\":{\"type\":\"enum\",\"name\"" +
				":\"IndexDirection\",\"namespace\":\"Energistics.Etp.v12.Datatypes.ChannelData\",\"symbo" +
				"ls\":[\"Increasing\",\"Decreasing\"],\"fullName\":\"Energistics.Etp.v12.Datatypes.Channe" +
				"lData.IndexDirection\",\"depends\":[]}},{\"name\":\"name\",\"default\":\"\",\"type\":\"string\"" +
				"}],\"fullName\":\"Energistics.Etp.v12.Datatypes.ChannelData.IndexMetadataRecord\",\"d" +
				"epends\":[\r\n  \"Energistics.Etp.v12.Datatypes.ChannelData.ChannelIndexKind\",\r\n  \"E" +
				"nergistics.Etp.v12.Datatypes.Object.IndexInterval\",\r\n  \"Energistics.Etp.v12.Data" +
				"types.ChannelData.IndexDirection\"\r\n]}}},{\"name\":\"channelName\",\"type\":\"string\"},{" +
				"\"name\":\"dataType\",\"type\":\"string\"},{\"name\":\"uom\",\"type\":\"string\"},{\"name\":\"measu" +
				"reClass\",\"type\":\"string\"},{\"name\":\"status\",\"type\":{\"type\":\"enum\",\"name\":\"Channel" +
				"StatusKind\",\"namespace\":\"Energistics.Etp.v12.Datatypes.ChannelData\",\"symbols\":[\"" +
				"Active\",\"Inactive\",\"Closed\"],\"fullName\":\"Energistics.Etp.v12.Datatypes.ChannelDa" +
				"ta.ChannelStatusKind\",\"depends\":[]}},{\"name\":\"source\",\"type\":\"string\"},{\"name\":\"" +
				"axisVectorLengths\",\"type\":{\"type\":\"array\",\"items\":\"int\"}},{\"name\":\"customData\",\"" +
				"type\":{\"type\":\"map\",\"values\":{\"type\":\"record\",\"name\":\"DataValue\",\"namespace\":\"En" +
				"ergistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"item\",\"type\":[\"null\",\"boolean\",\"" +
				"int\",\"long\",\"float\",\"double\",\"string\",{\"type\":\"record\",\"name\":\"ArrayOfBoolean\",\"" +
				"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"t" +
				"ype\":\"array\",\"items\":\"boolean\"}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.Arra" +
				"yOfBoolean\",\"depends\":[]},{\"type\":\"record\",\"name\":\"ArrayOfInt\",\"namespace\":\"Ener" +
				"gistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"it" +
				"ems\":\"int\"}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.ArrayOfInt\",\"depends\":[]" +
				"},{\"type\":\"record\",\"name\":\"ArrayOfLong\",\"namespace\":\"Energistics.Etp.v12.Datatyp" +
				"es\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"long\"}}],\"fullNam" +
				"e\":\"Energistics.Etp.v12.Datatypes.ArrayOfLong\",\"depends\":[]},{\"type\":\"record\",\"n" +
				"ame\":\"ArrayOfFloat\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name" +
				"\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"float\"}}],\"fullName\":\"Energistics.Etp" +
				".v12.Datatypes.ArrayOfFloat\",\"depends\":[]},{\"type\":\"record\",\"name\":\"ArrayOfDoubl" +
				"e\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\"" +
				":{\"type\":\"array\",\"items\":\"double\"}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.A" +
				"rrayOfDouble\",\"depends\":[]},{\"type\":\"record\",\"name\":\"ArrayOfString\",\"namespace\":" +
				"\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array" +
				"\",\"items\":\"string\"}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.ArrayOfString\",\"" +
				"depends\":[]},\"bytes\"]}],\"fullName\":\"Energistics.Etp.v12.Datatypes.DataValue\",\"de" +
				"pends\":[\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfBoolean\",\r\n  \"Energistics.Etp." +
				"v12.Datatypes.ArrayOfInt\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfLong\",\r\n  \"E" +
				"nergistics.Etp.v12.Datatypes.ArrayOfFloat\",\r\n  \"Energistics.Etp.v12.Datatypes.Ar" +
				"rayOfDouble\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfString\"\r\n]}}},{\"name\":\"at" +
				"tributeMetadata\",\"default\":[],\"type\":{\"type\":\"array\",\"items\":{\"type\":\"record\",\"n" +
				"ame\":\"AttributeMetadataRecord\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fiel" +
				"ds\":[{\"name\":\"attributeId\",\"type\":\"int\"},{\"name\":\"attributeName\",\"type\":\"string\"" +
				"},{\"name\":\"dataType\",\"type\":\"string\"},{\"name\":\"description\",\"type\":\"string\"}],\"f" +
				"ullName\":\"Energistics.Etp.v12.Datatypes.AttributeMetadataRecord\",\"depends\":[]}}}" +
				"],\"fullName\":\"Energistics.Etp.v12.Datatypes.ChannelData.ChannelMetadataRecord\",\"" +
				"depends\":[\r\n  \"Energistics.Etp.v12.Datatypes.ChannelData.IndexMetadataRecord\",\r\n" +
				"  \"Energistics.Etp.v12.Datatypes.ChannelData.ChannelStatusKind\",\r\n  \"Energistics" +
				".Etp.v12.Datatypes.DataValue\",\r\n  \"Energistics.Etp.v12.Datatypes.AttributeMetada" +
				"taRecord\"\r\n]}}}],\"protocol\":\"22\",\"messageType\":\"1\",\"senderRole\":\"producer\",\"prot" +
				"ocolRoles\":\"producer,consumer\",\"multipartFlag\":true,\"fullName\":\"Energistics.Etp." +
				"v12.Protocol.ChannelDataLoad.OpenChannel\",\"depends\":[\r\n  \"Energistics.Etp.v12.Da" +
				"tatypes.ChannelData.ChannelMetadataRecord\"\r\n]}");
		private IList<Energistics.Etp.v12.Datatypes.ChannelData.ChannelMetadataRecord> _channels;
		public virtual Schema Schema
		{
			get
			{
				return OpenChannel._SCHEMA;
			}
		}
		public IList<Energistics.Etp.v12.Datatypes.ChannelData.ChannelMetadataRecord> Channels
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
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._channels;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._channels = (IList<Energistics.Etp.v12.Datatypes.ChannelData.ChannelMetadataRecord>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
