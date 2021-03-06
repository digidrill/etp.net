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
	
	public partial class ContextInfo : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""ContextInfo"",""namespace"":""Energistics.Etp.v12.Datatypes.Object"",""fields"":[{""name"":""uri"",""type"":""string""},{""name"":""depth"",""type"":""int""},{""name"":""contentTypes"",""type"":{""type"":""array"",""items"":""string""}}],""fullName"":""Energistics.Etp.v12.Datatypes.Object.ContextInfo"",""depends"":[]}");
		private string _uri;
		private int _depth;
		private IList<System.String> _contentTypes;
		public virtual Schema Schema
		{
			get
			{
				return ContextInfo._SCHEMA;
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
		public int Depth
		{
			get
			{
				return this._depth;
			}
			set
			{
				this._depth = value;
			}
		}
		public IList<System.String> ContentTypes
		{
			get
			{
				return this._contentTypes;
			}
			set
			{
				this._contentTypes = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._uri;
			case 1: return this._depth;
			case 2: return this._contentTypes;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._uri = (System.String)fieldValue; break;
			case 1: this._depth = (System.Int32)fieldValue; break;
			case 2: this._contentTypes = (IList<System.String>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
