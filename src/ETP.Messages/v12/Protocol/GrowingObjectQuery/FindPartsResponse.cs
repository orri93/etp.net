// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.GrowingObjectQuery
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class FindPartsResponse : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""FindPartsResponse"",""namespace"":""Energistics.Etp.v12.Protocol.GrowingObjectQuery"",""fields"":[{""name"":""uri"",""type"":""string""},{""name"":""uid"",""type"":""string""},{""name"":""contentType"",""type"":""string""},{""name"":""data"",""type"":""bytes""},{""name"":""serverSortOrder"",""type"":""string""}],""messageType"":""2"",""protocol"":""16"",""senderRole"":""store"",""protocolRoles"":""store,customer"",""fullName"":""Energistics.Etp.v12.Protocol.GrowingObjectQuery.FindPartsResponse"",""depends"":[]}");
		private string _uri;
		private string _uid;
		private string _contentType;
		private byte[] _data;
		private string _serverSortOrder;
		public virtual Schema Schema
		{
			get
			{
				return FindPartsResponse._SCHEMA;
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
		public string Uid
		{
			get
			{
				return this._uid;
			}
			set
			{
				this._uid = value;
			}
		}
		public string ContentType
		{
			get
			{
				return this._contentType;
			}
			set
			{
				this._contentType = value;
			}
		}
		public byte[] Data
		{
			get
			{
				return this._data;
			}
			set
			{
				this._data = value;
			}
		}
		public string ServerSortOrder
		{
			get
			{
				return this._serverSortOrder;
			}
			set
			{
				this._serverSortOrder = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._uri;
			case 1: return this._uid;
			case 2: return this._contentType;
			case 3: return this._data;
			case 4: return this._serverSortOrder;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._uri = (System.String)fieldValue; break;
			case 1: this._uid = (System.String)fieldValue; break;
			case 2: this._contentType = (System.String)fieldValue; break;
			case 3: this._data = (System.Byte[])fieldValue; break;
			case 4: this._serverSortOrder = (System.String)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}