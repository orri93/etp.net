// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.WitsmlSoap
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class WMLS_GetVersion : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""WMLS_GetVersion"",""namespace"":""Energistics.Etp.v12.Protocol.WitsmlSoap"",""fields"":[],""messageType"":""11"",""protocol"":""8"",""senderRole"":""customer"",""protocolRoles"":""store,customer"",""fullName"":""Energistics.Etp.v12.Protocol.WitsmlSoap.WMLS_GetVersion"",""depends"":[]}");
		public virtual Schema Schema
		{
			get
			{
				return WMLS_GetVersion._SCHEMA;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
