// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.Transaction
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class RollbackTransaction : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""RollbackTransaction"",""namespace"":""Energistics.Etp.v12.Protocol.Transaction"",""fields"":[{""name"":""uuid"",""type"":""string""}],""protocol"":""18"",""messageType"":""4"",""senderRole"":""customer"",""protocolRoles"":""store,customer"",""multipartFlag"":""False"",""fullName"":""Energistics.Etp.v12.Protocol.Transaction.RollbackTransaction"",""depends"":[]}");
		private string _uuid;
		public virtual Schema Schema
		{
			get
			{
				return RollbackTransaction._SCHEMA;
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
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._uuid;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._uuid = (System.String)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
