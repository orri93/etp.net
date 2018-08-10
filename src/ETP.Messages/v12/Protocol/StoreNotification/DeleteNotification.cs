// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.StoreNotification
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class DeleteNotification : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""DeleteNotification"",""namespace"":""Energistics.Etp.v12.Protocol.StoreNotification"",""fields"":[{""name"":""uri"",""type"":""string""},{""name"":""changeTime"",""type"":""long""}],""messageType"":""3"",""protocol"":""5"",""senderRole"":""store"",""protocolRoles"":""store,customer"",""fullName"":""Energistics.Etp.v12.Protocol.StoreNotification.DeleteNotification"",""depends"":[]}");
		private string _uri;
		private long _changeTime;
		public virtual Schema Schema
		{
			get
			{
				return DeleteNotification._SCHEMA;
			}
		}
		public string Uri
		{
			get
			{
				return this._uri;
			}
			set
			{
				this._uri = value;
			}
		}
		public long ChangeTime
		{
			get
			{
				return this._changeTime;
			}
			set
			{
				this._changeTime = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._uri;
			case 1: return this._changeTime;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._uri = (System.String)fieldValue; break;
			case 1: this._changeTime = (System.Int64)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
