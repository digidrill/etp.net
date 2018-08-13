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
	
	public partial class DataAttribute : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""DataAttribute"",""namespace"":""Energistics.Datatypes"",""fields"":[{""name"":""attributeId"",""type"":""int""},{""name"":""attributeValue"",""type"":{""type"":""record"",""name"":""DataValue"",""namespace"":""Energistics.Datatypes"",""fields"":[{""name"":""item"",""type"":[""null"",""double"",""float"",""int"",""long"",""string"",{""type"":""record"",""name"":""ArrayOfDouble"",""namespace"":""Energistics.Datatypes"",""fields"":[{""name"":""values"",""type"":{""type"":""array"",""items"":""double""}}],""fullName"":""Energistics.Datatypes.ArrayOfDouble"",""depends"":[]},""boolean"",""bytes""]}],""fullName"":""Energistics.Datatypes.DataValue"",""depends"":[
  ""Energistics.Datatypes.ArrayOfDouble""
]}}],""fullName"":""Energistics.Datatypes.DataAttribute"",""depends"":[
  ""Energistics.Datatypes.DataValue""
]}");
		private int _attributeId;
		private Energistics.Etp.v11.Datatypes.DataValue _attributeValue;
		public virtual Schema Schema
		{
			get
			{
				return DataAttribute._SCHEMA;
			}
		}
		public int AttributeId
		{
			get
			{
				return this._attributeId;
			}
			set
			{
				this._attributeId = value;
			}
		}
		public Energistics.Etp.v11.Datatypes.DataValue AttributeValue
		{
			get
			{
				return this._attributeValue;
			}
			set
			{
				this._attributeValue = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._attributeId;
			case 1: return this._attributeValue;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._attributeId = (System.Int32)fieldValue; break;
			case 1: this._attributeValue = (Energistics.Etp.v11.Datatypes.DataValue)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}