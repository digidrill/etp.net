// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.Discovery
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class GetTreeResources : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""GetTreeResources"",""namespace"":""Energistics.Etp.v12.Protocol.Discovery"",""fields"":[{""name"":""context"",""type"":{""type"":""record"",""name"":""ContextInfo"",""namespace"":""Energistics.Etp.v12.Datatypes.Object"",""fields"":[{""name"":""uri"",""type"":""string""},{""name"":""depth"",""type"":""int""},{""name"":""contentTypes"",""type"":{""type"":""array"",""items"":""string""}}],""fullName"":""Energistics.Etp.v12.Datatypes.Object.ContextInfo"",""depends"":[]}}],""protocol"":""3"",""messageType"":""5"",""senderRole"":""customer"",""protocolRoles"":""store,customer"",""multipartFlag"":false,""fullName"":""Energistics.Etp.v12.Protocol.Discovery.GetTreeResources"",""depends"":[
  ""Energistics.Etp.v12.Datatypes.Object.ContextInfo""
]}");
		private Energistics.Etp.v12.Datatypes.Object.ContextInfo _context;
		public virtual Schema Schema
		{
			get
			{
				return GetTreeResources._SCHEMA;
			}
		}
		public Energistics.Etp.v12.Datatypes.Object.ContextInfo Context
		{
			get
			{
				return this._context;
			}
			set
			{
				this._context = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._context;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._context = (Energistics.Etp.v12.Datatypes.Object.ContextInfo)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}