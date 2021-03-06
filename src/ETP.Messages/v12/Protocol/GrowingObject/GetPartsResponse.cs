// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.GrowingObject
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class GetPartsResponse : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""GetPartsResponse"",""namespace"":""Energistics.Etp.v12.Protocol.GrowingObject"",""fields"":[{""name"":""objectPart"",""type"":{""type"":""record"",""name"":""ObjectPart"",""namespace"":""Energistics.Etp.v12.Datatypes.Object"",""fields"":[{""name"":""uri"",""type"":""string""},{""name"":""uid"",""type"":""string""},{""name"":""contentType"",""type"":""string""},{""name"":""data"",""type"":""bytes""}],""fullName"":""Energistics.Etp.v12.Datatypes.Object.ObjectPart"",""depends"":[]}}],""protocol"":""6"",""messageType"":""6"",""senderRole"":""store"",""protocolRoles"":""store,customer"",""multipartFlag"":true,""fullName"":""Energistics.Etp.v12.Protocol.GrowingObject.GetPartsResponse"",""depends"":[
  ""Energistics.Etp.v12.Datatypes.Object.ObjectPart""
]}");
		private Energistics.Etp.v12.Datatypes.Object.ObjectPart _objectPart;
		public virtual Schema Schema
		{
			get
			{
				return GetPartsResponse._SCHEMA;
			}
		}
		public Energistics.Etp.v12.Datatypes.Object.ObjectPart ObjectPart
		{
			get
			{
				return this._objectPart;
			}
			set
			{
				this._objectPart = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._objectPart;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._objectPart = (Energistics.Etp.v12.Datatypes.Object.ObjectPart)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
