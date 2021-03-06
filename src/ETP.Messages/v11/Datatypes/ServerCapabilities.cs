// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v11.Datatypes
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class ServerCapabilities : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"ServerCapabilities\",\"namespace\":\"Energistics.Datatypes\"," +
				"\"fields\":[{\"name\":\"applicationName\",\"type\":\"string\"},{\"name\":\"applicationVersion" +
				"\",\"type\":\"string\"},{\"name\":\"supportedProtocols\",\"type\":{\"type\":\"array\",\"items\":{" +
				"\"type\":\"record\",\"name\":\"SupportedProtocol\",\"namespace\":\"Energistics.Datatypes\",\"" +
				"fields\":[{\"name\":\"protocol\",\"type\":\"int\"},{\"name\":\"protocolVersion\",\"type\":{\"typ" +
				"e\":\"record\",\"name\":\"Version\",\"namespace\":\"Energistics.Datatypes\",\"fields\":[{\"nam" +
				"e\":\"major\",\"type\":\"int\"},{\"name\":\"minor\",\"type\":\"int\"},{\"name\":\"revision\",\"type\"" +
				":\"int\"},{\"name\":\"patch\",\"type\":\"int\"}],\"fullName\":\"Energistics.Datatypes.Version" +
				"\",\"depends\":[]}},{\"name\":\"role\",\"type\":\"string\"},{\"name\":\"protocolCapabilities\"," +
				"\"type\":{\"type\":\"map\",\"values\":{\"type\":\"record\",\"name\":\"DataValue\",\"namespace\":\"E" +
				"nergistics.Datatypes\",\"fields\":[{\"name\":\"item\",\"type\":[\"null\",\"double\",\"float\",\"" +
				"int\",\"long\",\"string\",{\"type\":\"record\",\"name\":\"ArrayOfDouble\",\"namespace\":\"Energi" +
				"stics.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"doub" +
				"le\"}}],\"fullName\":\"Energistics.Datatypes.ArrayOfDouble\",\"depends\":[]},\"boolean\"," +
				"\"bytes\"]}],\"fullName\":\"Energistics.Datatypes.DataValue\",\"depends\":[\r\n  \"Energist" +
				"ics.Datatypes.ArrayOfDouble\"\r\n]}}}],\"fullName\":\"Energistics.Datatypes.SupportedP" +
				"rotocol\",\"depends\":[\r\n  \"Energistics.Datatypes.Version\",\r\n  \"Energistics.Datatyp" +
				"es.DataValue\"\r\n]}}},{\"name\":\"supportedObjects\",\"type\":{\"type\":\"array\",\"items\":\"s" +
				"tring\"}},{\"name\":\"contactInformation\",\"type\":{\"type\":\"record\",\"name\":\"Contact\",\"" +
				"namespace\":\"Energistics.Datatypes\",\"fields\":[{\"name\":\"organizationName\",\"type\":[" +
				"\"null\",\"string\"]},{\"name\":\"contactName\",\"type\":[\"null\",\"string\"]},{\"name\":\"conta" +
				"ctPhone\",\"type\":[\"null\",\"string\"]},{\"name\":\"contactEmail\",\"type\":[\"null\",\"string" +
				"\"]}],\"fullName\":\"Energistics.Datatypes.Contact\",\"depends\":[]}},{\"name\":\"supporte" +
				"dEncodings\",\"type\":\"string\"}],\"fullName\":\"Energistics.Datatypes.ServerCapabiliti" +
				"es\",\"depends\":[\r\n  \"Energistics.Datatypes.SupportedProtocol\",\r\n  \"Energistics.Da" +
				"tatypes.Contact\"\r\n]}");
		private string _applicationName;
		private string _applicationVersion;
		private IList<Energistics.Etp.v11.Datatypes.SupportedProtocol> _supportedProtocols;
		private IList<System.String> _supportedObjects;
		private Energistics.Etp.v11.Datatypes.Contact _contactInformation;
		private string _supportedEncodings;
		public virtual Schema Schema
		{
			get
			{
				return ServerCapabilities._SCHEMA;
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
		public IList<Energistics.Etp.v11.Datatypes.SupportedProtocol> SupportedProtocols
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
		public Energistics.Etp.v11.Datatypes.Contact ContactInformation
		{
			get
			{
				return this._contactInformation;
			}
			set
			{
				this._contactInformation = value;
			}
		}
		public string SupportedEncodings
		{
			get
			{
				return this._supportedEncodings;
			}
			set
			{
				this._supportedEncodings = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._applicationName;
			case 1: return this._applicationVersion;
			case 2: return this._supportedProtocols;
			case 3: return this._supportedObjects;
			case 4: return this._contactInformation;
			case 5: return this._supportedEncodings;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._applicationName = (System.String)fieldValue; break;
			case 1: this._applicationVersion = (System.String)fieldValue; break;
			case 2: this._supportedProtocols = (IList<Energistics.Etp.v11.Datatypes.SupportedProtocol>)fieldValue; break;
			case 3: this._supportedObjects = (IList<System.String>)fieldValue; break;
			case 4: this._contactInformation = (Energistics.Etp.v11.Datatypes.Contact)fieldValue; break;
			case 5: this._supportedEncodings = (System.String)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
