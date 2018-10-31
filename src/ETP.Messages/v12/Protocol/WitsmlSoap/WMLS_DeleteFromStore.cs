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
	
	public partial class WMLS_DeleteFromStore : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""WMLS_DeleteFromStore"",""namespace"":""Energistics.Etp.v12.Protocol.WitsmlSoap"",""fields"":[{""name"":""WMLtypeIn"",""type"":""string""},{""name"":""XMLin"",""type"":""string""},{""name"":""OptionsIn"",""type"":""string""},{""name"":""CapabilitiesIn"",""type"":""string""}],""protocol"":""8"",""messageType"":""3"",""senderRole"":""customer"",""protocolRoles"":""store,customer"",""multipartFlag"":""False"",""fullName"":""Energistics.Etp.v12.Protocol.WitsmlSoap.WMLS_DeleteFromStore"",""depends"":[]}");
		private string _WMLtypeIn;
		private string _XMLin;
		private string _OptionsIn;
		private string _CapabilitiesIn;
		public virtual Schema Schema
		{
			get
			{
				return WMLS_DeleteFromStore._SCHEMA;
			}
		}
		public string WMLtypeIn
		{
			get
			{
				return this._WMLtypeIn;
			}
			set
			{
				this._WMLtypeIn = value;
			}
		}
		public string XMLin
		{
			get
			{
				return this._XMLin;
			}
			set
			{
				this._XMLin = value;
			}
		}
		public string OptionsIn
		{
			get
			{
				return this._OptionsIn;
			}
			set
			{
				this._OptionsIn = value;
			}
		}
		public string CapabilitiesIn
		{
			get
			{
				return this._CapabilitiesIn;
			}
			set
			{
				this._CapabilitiesIn = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._WMLtypeIn;
			case 1: return this._XMLin;
			case 2: return this._OptionsIn;
			case 3: return this._CapabilitiesIn;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._WMLtypeIn = (System.String)fieldValue; break;
			case 1: this._XMLin = (System.String)fieldValue; break;
			case 2: this._OptionsIn = (System.String)fieldValue; break;
			case 3: this._CapabilitiesIn = (System.String)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
