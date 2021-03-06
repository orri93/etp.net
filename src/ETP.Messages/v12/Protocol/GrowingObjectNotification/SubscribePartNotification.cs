// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.GrowingObjectNotification
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class SubscribePartNotification : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"SubscribePartNotification\",\"namespace\":\"Energistics.Etp." +
				"v12.Protocol.GrowingObjectNotification\",\"fields\":[{\"name\":\"request\",\"type\":{\"typ" +
				"e\":\"record\",\"name\":\"SubscriptionInfo\",\"namespace\":\"Energistics.Etp.v12.Datatypes" +
				".Object\",\"fields\":[{\"name\":\"context\",\"type\":{\"type\":\"record\",\"name\":\"ContextInfo" +
				"\",\"namespace\":\"Energistics.Etp.v12.Datatypes.Object\",\"fields\":[{\"name\":\"uri\",\"ty" +
				"pe\":\"string\"},{\"name\":\"depth\",\"type\":\"int\"},{\"name\":\"contentTypes\",\"type\":{\"type" +
				"\":\"array\",\"items\":\"string\"}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.Object.C" +
				"ontextInfo\",\"depends\":[]}},{\"name\":\"scope\",\"type\":{\"type\":\"enum\",\"name\":\"Context" +
				"ScopeKind\",\"namespace\":\"Energistics.Etp.v12.Datatypes.Object\",\"symbols\":[\"self\"," +
				"\"sources\",\"targets\",\"sourcesOrSelf\",\"targetsOrSelf\"],\"fullName\":\"Energistics.Etp" +
				".v12.Datatypes.Object.ContextScopeKind\",\"depends\":[]}},{\"name\":\"requestUuid\",\"ty" +
				"pe\":{\"type\":\"fixed\",\"name\":\"Uuid\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"s" +
				"ize\":16,\"fullName\":\"Energistics.Etp.v12.Datatypes.Uuid\",\"depends\":[]}},{\"name\":\"" +
				"startTime\",\"type\":\"long\"},{\"name\":\"includeObjectData\",\"type\":\"boolean\"}],\"fullNa" +
				"me\":\"Energistics.Etp.v12.Datatypes.Object.SubscriptionInfo\",\"depends\":[\r\n  \"Ener" +
				"gistics.Etp.v12.Datatypes.Object.ContextInfo\",\r\n  \"Energistics.Etp.v12.Datatypes" +
				".Object.ContextScopeKind\",\r\n  \"Energistics.Etp.v12.Datatypes.Uuid\"\r\n]}}],\"protoc" +
				"ol\":\"7\",\"messageType\":\"7\",\"senderRole\":\"customer\",\"protocolRoles\":\"store,custome" +
				"r\",\"multipartFlag\":false,\"fullName\":\"Energistics.Etp.v12.Protocol.GrowingObjectN" +
				"otification.SubscribePartNotification\",\"depends\":[\r\n  \"Energistics.Etp.v12.Datat" +
				"ypes.Object.SubscriptionInfo\"\r\n]}");
		private Energistics.Etp.v12.Datatypes.Object.SubscriptionInfo _request;
		public virtual Schema Schema
		{
			get
			{
				return SubscribePartNotification._SCHEMA;
			}
		}
		public Energistics.Etp.v12.Datatypes.Object.SubscriptionInfo Request
		{
			get
			{
				return this._request;
			}
			set
			{
				this._request = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._request;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._request = (Energistics.Etp.v12.Datatypes.Object.SubscriptionInfo)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
