// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.DataArray
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class GetDataArray : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""GetDataArray"",""namespace"":""Energistics.Etp.v12.Protocol.DataArray"",""fields"":[{""name"":""uri"",""type"":""string""},{""name"":""pathInResource"",""type"":""string""}],""messageType"":""2"",""protocol"":""9"",""senderRole"":""customer"",""protocolRoles"":""store,customer"",""fullName"":""Energistics.Etp.v12.Protocol.DataArray.GetDataArray"",""depends"":[]}");
		private string _uri;
		private string _pathInResource;
		public virtual Schema Schema
		{
			get
			{
				return GetDataArray._SCHEMA;
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
		public string PathInResource
		{
			get
			{
				return this._pathInResource;
			}
			set
			{
				this._pathInResource = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._uri;
			case 1: return this._pathInResource;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._uri = (System.String)fieldValue; break;
			case 1: this._pathInResource = (System.String)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
