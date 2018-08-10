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
	
	public partial class RequestSession : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"RequestSession\",\"namespace\":\"Energistics.Etp.v12.Protoco" +
				"l.Core\",\"fields\":[{\"name\":\"applicationName\",\"type\":\"string\"},{\"name\":\"applicatio" +
				"nVersion\",\"type\":\"string\"},{\"name\":\"requestedProtocols\",\"type\":{\"type\":\"array\",\"" +
				"items\":{\"type\":\"record\",\"name\":\"SupportedProtocol\",\"namespace\":\"Energistics.Etp." +
				"v12.Datatypes\",\"fields\":[{\"name\":\"protocol\",\"type\":\"int\"},{\"name\":\"protocolVersi" +
				"on\",\"type\":{\"type\":\"record\",\"name\":\"Version\",\"namespace\":\"Energistics.Etp.v12.Da" +
				"tatypes\",\"fields\":[{\"name\":\"major\",\"default\":0,\"type\":\"int\"},{\"name\":\"minor\",\"de" +
				"fault\":0,\"type\":\"int\"},{\"name\":\"revision\",\"default\":0,\"type\":\"int\"},{\"name\":\"pat" +
				"ch\",\"default\":0,\"type\":\"int\"}],\"fullName\":\"Energistics.Etp.v12.Datatypes.Version" +
				"\",\"depends\":[]}},{\"name\":\"role\",\"type\":\"string\"},{\"name\":\"protocolCapabilities\"," +
				"\"type\":{\"type\":\"map\",\"values\":{\"type\":\"record\",\"name\":\"DataValue\",\"namespace\":\"E" +
				"nergistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"item\",\"type\":[\"null\",\"double\",\"" +
				"float\",\"int\",\"long\",\"string\",{\"type\":\"record\",\"name\":\"ArrayOfDouble\",\"namespace\"" +
				":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"arra" +
				"y\",\"items\":\"double\"}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.ArrayOfDouble\"," +
				"\"depends\":[]},\"boolean\",\"bytes\"]}],\"fullName\":\"Energistics.Etp.v12.Datatypes.Dat" +
				"aValue\",\"depends\":[\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfDouble\"\r\n]}}}],\"ful" +
				"lName\":\"Energistics.Etp.v12.Datatypes.SupportedProtocol\",\"depends\":[\r\n  \"Energis" +
				"tics.Etp.v12.Datatypes.Version\",\r\n  \"Energistics.Etp.v12.Datatypes.DataValue\"\r\n]" +
				"}}},{\"name\":\"supportedObjects\",\"type\":{\"type\":\"array\",\"items\":\"string\"}},{\"name\"" +
				":\"supportedCompression\",\"type\":\"string\"}],\"messageType\":\"1\",\"protocol\":\"0\",\"send" +
				"erRole\":\"client\",\"protocolRoles\":\"client,server\",\"fullName\":\"Energistics.Etp.v12" +
				".Protocol.Core.RequestSession\",\"depends\":[\r\n  \"Energistics.Etp.v12.Datatypes.Sup" +
				"portedProtocol\"\r\n]}");
		private string _applicationName;
		private string _applicationVersion;
		private IList<Energistics.Etp.v12.Datatypes.SupportedProtocol> _requestedProtocols;
		private IList<System.String> _supportedObjects;
		private string _supportedCompression;
		public virtual Schema Schema
		{
			get
			{
				return RequestSession._SCHEMA;
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
		public IList<Energistics.Etp.v12.Datatypes.SupportedProtocol> RequestedProtocols
		{
			get
			{
				return this._requestedProtocols;
			}
			set
			{
				this._requestedProtocols = value;
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
			case 2: return this._requestedProtocols;
			case 3: return this._supportedObjects;
			case 4: return this._supportedCompression;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._applicationName = (System.String)fieldValue; break;
			case 1: this._applicationVersion = (System.String)fieldValue; break;
			case 2: this._requestedProtocols = (IList<Energistics.Etp.v12.Datatypes.SupportedProtocol>)fieldValue; break;
			case 3: this._supportedObjects = (IList<System.String>)fieldValue; break;
			case 4: this._supportedCompression = (System.String)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
