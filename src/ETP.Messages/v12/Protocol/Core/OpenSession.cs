// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.Core
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class OpenSession : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"OpenSession\",\"namespace\":\"Energistics.Etp.v12.Protocol.C" +
				"ore\",\"fields\":[{\"name\":\"applicationName\",\"type\":\"string\"},{\"name\":\"applicationVe" +
				"rsion\",\"type\":\"string\"},{\"name\":\"sessionId\",\"type\":\"string\"},{\"name\":\"supportedP" +
				"rotocols\",\"type\":{\"type\":\"array\",\"items\":{\"type\":\"record\",\"name\":\"SupportedProto" +
				"col\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"protocol\",\"t" +
				"ype\":\"int\"},{\"name\":\"protocolVersion\",\"type\":{\"type\":\"record\",\"name\":\"Version\",\"" +
				"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"major\",\"default\":0" +
				",\"type\":\"int\"},{\"name\":\"minor\",\"default\":0,\"type\":\"int\"},{\"name\":\"revision\",\"def" +
				"ault\":0,\"type\":\"int\"},{\"name\":\"patch\",\"default\":0,\"type\":\"int\"}],\"fullName\":\"Ene" +
				"rgistics.Etp.v12.Datatypes.Version\",\"depends\":[]}},{\"name\":\"role\",\"type\":\"string" +
				"\"},{\"name\":\"protocolCapabilities\",\"type\":{\"type\":\"map\",\"values\":{\"type\":\"record\"" +
				",\"name\":\"DataValue\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name" +
				"\":\"item\",\"type\":[\"null\",\"double\",\"float\",\"int\",\"long\",\"string\",{\"type\":\"record\"," +
				"\"name\":\"ArrayOfDouble\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"n" +
				"ame\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"double\"}}],\"fullName\":\"Energistics" +
				".Etp.v12.Datatypes.ArrayOfDouble\",\"depends\":[]},\"boolean\",\"bytes\"]}],\"fullName\":" +
				"\"Energistics.Etp.v12.Datatypes.DataValue\",\"depends\":[\r\n  \"Energistics.Etp.v12.Da" +
				"tatypes.ArrayOfDouble\"\r\n]}}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.Supporte" +
				"dProtocol\",\"depends\":[\r\n  \"Energistics.Etp.v12.Datatypes.Version\",\r\n  \"Energisti" +
				"cs.Etp.v12.Datatypes.DataValue\"\r\n]}}},{\"name\":\"supportedObjects\",\"type\":{\"type\":" +
				"\"array\",\"items\":\"string\"}},{\"name\":\"supportedCompression\",\"type\":\"string\"}],\"mes" +
				"sageType\":\"2\",\"protocol\":\"0\",\"senderRole\":\"server\",\"protocolRoles\":\"client,serve" +
				"r\",\"fullName\":\"Energistics.Etp.v12.Protocol.Core.OpenSession\",\"depends\":[\r\n  \"En" +
				"ergistics.Etp.v12.Datatypes.SupportedProtocol\"\r\n]}");
		private string _applicationName;
		private string _applicationVersion;
		private string _sessionId;
		private IList<Energistics.Etp.v12.Datatypes.SupportedProtocol> _supportedProtocols;
		private IList<System.String> _supportedObjects;
		private string _supportedCompression;
		public virtual Schema Schema
		{
			get
			{
				return OpenSession._SCHEMA;
			}
		}
		public string ApplicationName
		{
			get
			{
				return this._applicationName;
			}
			set
			{
				this._applicationName = value;
			}
		}
		public string ApplicationVersion
		{
			get
			{
				return this._applicationVersion;
			}
			set
			{
				this._applicationVersion = value;
			}
		}
		public string SessionId
		{
			get
			{
				return this._sessionId;
			}
			set
			{
				this._sessionId = value;
			}
		}
		public IList<Energistics.Etp.v12.Datatypes.SupportedProtocol> SupportedProtocols
		{
			get
			{
				return this._supportedProtocols;
			}
			set
			{
				this._supportedProtocols = value;
			}
		}
		public IList<System.String> SupportedObjects
		{
			get
			{
				return this._supportedObjects;
			}
			set
			{
				this._supportedObjects = value;
			}
		}
		public string SupportedCompression
		{
			get
			{
				return this._supportedCompression;
			}
			set
			{
				this._supportedCompression = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._applicationName;
			case 1: return this._applicationVersion;
			case 2: return this._sessionId;
			case 3: return this._supportedProtocols;
			case 4: return this._supportedObjects;
			case 5: return this._supportedCompression;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._applicationName = (System.String)fieldValue; break;
			case 1: this._applicationVersion = (System.String)fieldValue; break;
			case 2: this._sessionId = (System.String)fieldValue; break;
			case 3: this._supportedProtocols = (IList<Energistics.Etp.v12.Datatypes.SupportedProtocol>)fieldValue; break;
			case 4: this._supportedObjects = (IList<System.String>)fieldValue; break;
			case 5: this._supportedCompression = (System.String)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
