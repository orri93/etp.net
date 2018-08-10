// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Datatypes.Object
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class GraphResource : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""GraphResource"",""namespace"":""Energistics.Etp.v12.Datatypes.Object"",""fields"":[{""name"":""uri"",""type"":""string""},{""name"":""contentType"",""type"":""string""},{""name"":""name"",""type"":""string""},{""name"":""channelSubscribable"",""default"":false,""type"":""boolean""},{""name"":""customData"",""type"":{""type"":""map"",""values"":""string""}},{""name"":""resourceType"",""type"":""string""},{""name"":""sourceCount"",""default"":-1,""type"":""int""},{""name"":""targetCount"",""default"":-1,""type"":""int""},{""name"":""contentCount"",""default"":-1,""type"":""int""},{""name"":""uuid"",""default"":"""",""type"":""string""},{""name"":""lastChanged"",""type"":""long""},{""name"":""objectNotifiable"",""default"":false,""type"":""boolean""}],""fullName"":""Energistics.Etp.v12.Datatypes.Object.GraphResource"",""depends"":[]}");
		private string _uri;
		private string _contentType;
		private string _name;
		private bool _channelSubscribable;
		private IDictionary<string,System.String> _customData;
		private string _resourceType;
		private int _sourceCount;
		private int _targetCount;
		private int _contentCount;
		private string _uuid;
		private long _lastChanged;
		private bool _objectNotifiable;
		public virtual Schema Schema
		{
			get
			{
				return GraphResource._SCHEMA;
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
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		public bool ChannelSubscribable
		{
			get
			{
				return this._channelSubscribable;
			}
			set
			{
				this._channelSubscribable = value;
			}
		}
		public IDictionary<string,System.String> CustomData
		{
			get
			{
				return this._customData;
			}
			set
			{
				this._customData = value;
			}
		}
		public string ResourceType
		{
			get
			{
				return this._resourceType;
			}
			set
			{
				this._resourceType = value;
			}
		}
		public int SourceCount
		{
			get
			{
				return this._sourceCount;
			}
			set
			{
				this._sourceCount = value;
			}
		}
		public int TargetCount
		{
			get
			{
				return this._targetCount;
			}
			set
			{
				this._targetCount = value;
			}
		}
		public int ContentCount
		{
			get
			{
				return this._contentCount;
			}
			set
			{
				this._contentCount = value;
			}
		}
		public string Uuid
		{
			get
			{
				return this._uuid;
			}
			set
			{
				this._uuid = value;
			}
		}
		public long LastChanged
		{
			get
			{
				return this._lastChanged;
			}
			set
			{
				this._lastChanged = value;
			}
		}
		public bool ObjectNotifiable
		{
			get
			{
				return this._objectNotifiable;
			}
			set
			{
				this._objectNotifiable = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._uri;
			case 1: return this._contentType;
			case 2: return this._name;
			case 3: return this._channelSubscribable;
			case 4: return this._customData;
			case 5: return this._resourceType;
			case 6: return this._sourceCount;
			case 7: return this._targetCount;
			case 8: return this._contentCount;
			case 9: return this._uuid;
			case 10: return this._lastChanged;
			case 11: return this._objectNotifiable;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._uri = (System.String)fieldValue; break;
			case 1: this._contentType = (System.String)fieldValue; break;
			case 2: this._name = (System.String)fieldValue; break;
			case 3: this._channelSubscribable = (System.Boolean)fieldValue; break;
			case 4: this._customData = (IDictionary<string,System.String>)fieldValue; break;
			case 5: this._resourceType = (System.String)fieldValue; break;
			case 6: this._sourceCount = (System.Int32)fieldValue; break;
			case 7: this._targetCount = (System.Int32)fieldValue; break;
			case 8: this._contentCount = (System.Int32)fieldValue; break;
			case 9: this._uuid = (System.String)fieldValue; break;
			case 10: this._lastChanged = (System.Int64)fieldValue; break;
			case 11: this._objectNotifiable = (System.Boolean)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
