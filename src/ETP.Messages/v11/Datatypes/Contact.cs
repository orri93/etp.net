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
	
	public partial class Contact : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""Contact"",""namespace"":""Energistics.Datatypes"",""fields"":[{""name"":""organizationName"",""type"":[""null"",""string""]},{""name"":""contactName"",""type"":[""null"",""string""]},{""name"":""contactPhone"",""type"":[""null"",""string""]},{""name"":""contactEmail"",""type"":[""null"",""string""]}],""fullName"":""Energistics.Datatypes.Contact"",""depends"":[]}");
		private string _organizationName;
		private string _contactName;
		private string _contactPhone;
		private string _contactEmail;
		public virtual Schema Schema
		{
			get
			{
				return Contact._SCHEMA;
			}
		}
		public string OrganizationName
		{
			get
			{
				return this._organizationName;
			}
			set
			{
				this._organizationName = value;
			}
		}
		public string ContactName
		{
			get
			{
				return this._contactName;
			}
			set
			{
				this._contactName = value;
			}
		}
		public string ContactPhone
		{
			get
			{
				return this._contactPhone;
			}
			set
			{
				this._contactPhone = value;
			}
		}
		public string ContactEmail
		{
			get
			{
				return this._contactEmail;
			}
			set
			{
				this._contactEmail = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._organizationName;
			case 1: return this._contactName;
			case 2: return this._contactPhone;
			case 3: return this._contactEmail;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._organizationName = (System.String)fieldValue; break;
			case 1: this._contactName = (System.String)fieldValue; break;
			case 2: this._contactPhone = (System.String)fieldValue; break;
			case 3: this._contactEmail = (System.String)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}