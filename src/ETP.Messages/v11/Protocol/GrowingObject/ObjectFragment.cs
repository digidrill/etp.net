// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v11.Protocol.GrowingObject
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class ObjectFragment : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""ObjectFragment"",""namespace"":""Energistics.Protocol.GrowingObject"",""fields"":[{""name"":""uri"",""type"":""string""},{""name"":""contentType"",""type"":""string""},{""name"":""contentEncoding"",""type"":""string""},{""name"":""data"",""type"":""bytes""}],""messageType"":""6"",""protocol"":""6"",""senderRole"":""store"",""protocolRoles"":""store,customer"",""fullName"":""Energistics.Protocol.GrowingObject.ObjectFragment"",""depends"":[]}");
		private string _uri;
		private string _contentType;
		private string _contentEncoding;
		private byte[] _data;
		public virtual Schema Schema
		{
			get
			{
				return ObjectFragment._SCHEMA;
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
		public string ContentEncoding
		{
			get
			{
				return this._contentEncoding;
			}
			set
			{
				this._contentEncoding = value;
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
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._uri;
			case 1: return this._contentType;
			case 2: return this._contentEncoding;
			case 3: return this._data;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._uri = (System.String)fieldValue; break;
			case 1: this._contentType = (System.String)fieldValue; break;
			case 2: this._contentEncoding = (System.String)fieldValue; break;
			case 3: this._data = (System.Byte[])fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}