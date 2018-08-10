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
	
	public partial class CancelPartNotification : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""CancelPartNotification"",""namespace"":""Energistics.Etp.v12.Protocol.GrowingObjectNotification"",""fields"":[{""name"":""requestUuid"",""type"":""string""}],""messageType"":""4"",""protocol"":""7"",""senderRole"":""customer"",""protocolRoles"":""store,customer"",""fullName"":""Energistics.Etp.v12.Protocol.GrowingObjectNotification.CancelPartNotification"",""depends"":[]}");
		private string _requestUuid;
		public virtual Schema Schema
		{
			get
			{
				return CancelPartNotification._SCHEMA;
			}
		}
		public string RequestUuid
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
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._requestUuid;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._requestUuid = (System.String)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
