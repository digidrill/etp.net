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
	
	public partial class ReplacePartsByRange : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""ReplacePartsByRange"",""namespace"":""Energistics.Etp.v12.Protocol.GrowingObject"",""fields"":[{""name"":""uri"",""type"":""string""},{""name"":""deleteInterval"",""type"":{""type"":""record"",""name"":""IndexInterval"",""namespace"":""Energistics.Etp.v12.Datatypes.Object"",""fields"":[{""name"":""startIndex"",""type"":{""type"":""record"",""name"":""IndexValue"",""namespace"":""Energistics.Etp.v12.Datatypes"",""fields"":[{""name"":""item"",""type"":[""null"",""long"",""double""]}],""fullName"":""Energistics.Etp.v12.Datatypes.IndexValue"",""depends"":[]}},{""name"":""endIndex"",""type"":""Energistics.Etp.v12.Datatypes.IndexValue""},{""name"":""uom"",""type"":""string""},{""name"":""depthDatum"",""default"":"""",""type"":""string""}],""fullName"":""Energistics.Etp.v12.Datatypes.Object.IndexInterval"",""depends"":[
  ""Energistics.Etp.v12.Datatypes.IndexValue"",
  ""Energistics.Etp.v12.Datatypes.IndexValue""
]}},{""name"":""includeOverlappingIntervals"",""type"":""boolean""},{""name"":""contentType"",""type"":""string""},{""name"":""uid"",""type"":""string""},{""name"":""data"",""type"":""bytes""}],""protocol"":""6"",""messageType"":""7"",""senderRole"":""customer"",""protocolRoles"":""store,customer"",""multipartFlag"":""True"",""fullName"":""Energistics.Etp.v12.Protocol.GrowingObject.ReplacePartsByRange"",""depends"":[
  ""Energistics.Etp.v12.Datatypes.Object.IndexInterval""
]}");
		private string _uri;
		private Energistics.Etp.v12.Datatypes.Object.IndexInterval _deleteInterval;
		private bool _includeOverlappingIntervals;
		private string _contentType;
		private string _uid;
		private byte[] _data;
		public virtual Schema Schema
		{
			get
			{
				return ReplacePartsByRange._SCHEMA;
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
		public Energistics.Etp.v12.Datatypes.Object.IndexInterval DeleteInterval
		{
			get
			{
				return this._deleteInterval;
			}
			set
			{
				this._deleteInterval = value;
			}
		}
		public bool IncludeOverlappingIntervals
		{
			get
			{
				return this._includeOverlappingIntervals;
			}
			set
			{
				this._includeOverlappingIntervals = value;
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
		public string Uid
		{
			get
			{
				return this._uid;
			}
			set
			{
				this._uid = value;
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
			case 1: return this._deleteInterval;
			case 2: return this._includeOverlappingIntervals;
			case 3: return this._contentType;
			case 4: return this._uid;
			case 5: return this._data;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._uri = (System.String)fieldValue; break;
			case 1: this._deleteInterval = (Energistics.Etp.v12.Datatypes.Object.IndexInterval)fieldValue; break;
			case 2: this._includeOverlappingIntervals = (System.Boolean)fieldValue; break;
			case 3: this._contentType = (System.String)fieldValue; break;
			case 4: this._uid = (System.String)fieldValue; break;
			case 5: this._data = (System.Byte[])fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
