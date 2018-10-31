// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.ChannelDataLoad
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class RealtimeData : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"RealtimeData\",\"namespace\":\"Energistics.Etp.v12.Protocol." +
				"ChannelDataLoad\",\"fields\":[{\"name\":\"data\",\"type\":{\"type\":\"array\",\"items\":{\"type\"" +
				":\"record\",\"name\":\"DataItem\",\"namespace\":\"Energistics.Etp.v12.Datatypes.ChannelDa" +
				"ta\",\"fields\":[{\"name\":\"channelId\",\"type\":\"long\"},{\"name\":\"indexes\",\"type\":{\"type" +
				"\":\"array\",\"items\":{\"type\":\"record\",\"name\":\"IndexValue\",\"namespace\":\"Energistics." +
				"Etp.v12.Datatypes\",\"fields\":[{\"name\":\"item\",\"type\":[\"null\",\"long\",\"double\"]}],\"f" +
				"ullName\":\"Energistics.Etp.v12.Datatypes.IndexValue\",\"depends\":[]}}},{\"name\":\"val" +
				"ue\",\"type\":{\"type\":\"record\",\"name\":\"DataValue\",\"namespace\":\"Energistics.Etp.v12." +
				"Datatypes\",\"fields\":[{\"name\":\"item\",\"type\":[\"null\",\"boolean\",\"int\",\"long\",\"float" +
				"\",\"double\",\"string\",{\"type\":\"record\",\"name\":\"ArrayOfBoolean\",\"namespace\":\"Energi" +
				"stics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"item" +
				"s\":\"boolean\"}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.ArrayOfBoolean\",\"depen" +
				"ds\":[]},{\"type\":\"record\",\"name\":\"ArrayOfInt\",\"namespace\":\"Energistics.Etp.v12.Da" +
				"tatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"int\"}}],\"ful" +
				"lName\":\"Energistics.Etp.v12.Datatypes.ArrayOfInt\",\"depends\":[]},{\"type\":\"record\"" +
				",\"name\":\"ArrayOfLong\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"na" +
				"me\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"long\"}}],\"fullName\":\"Energistics.Et" +
				"p.v12.Datatypes.ArrayOfLong\",\"depends\":[]},{\"type\":\"record\",\"name\":\"ArrayOfFloat" +
				"\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":" +
				"{\"type\":\"array\",\"items\":\"float\"}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.Arr" +
				"ayOfFloat\",\"depends\":[]},{\"type\":\"record\",\"name\":\"ArrayOfDouble\",\"namespace\":\"En" +
				"ergistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"" +
				"items\":\"double\"}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.ArrayOfDouble\",\"dep" +
				"ends\":[]},{\"type\":\"record\",\"name\":\"ArrayOfString\",\"namespace\":\"Energistics.Etp.v" +
				"12.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"string\"" +
				"}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.ArrayOfString\",\"depends\":[]},\"byte" +
				"s\"]}],\"fullName\":\"Energistics.Etp.v12.Datatypes.DataValue\",\"depends\":[\r\n  \"Energ" +
				"istics.Etp.v12.Datatypes.ArrayOfBoolean\",\r\n  \"Energistics.Etp.v12.Datatypes.Arra" +
				"yOfInt\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfLong\",\r\n  \"Energistics.Etp.v12" +
				".Datatypes.ArrayOfFloat\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfDouble\",\r\n  \"" +
				"Energistics.Etp.v12.Datatypes.ArrayOfString\"\r\n]}},{\"name\":\"valueAttributes\",\"typ" +
				"e\":{\"type\":\"array\",\"items\":{\"type\":\"record\",\"name\":\"DataAttribute\",\"namespace\":\"" +
				"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"attributeId\",\"type\":\"int\"},{\"n" +
				"ame\":\"attributeValue\",\"type\":\"DataValue\"}],\"fullName\":\"Energistics.Etp.v12.Datat" +
				"ypes.DataAttribute\",\"depends\":[\r\n  \"Energistics.Etp.v12.Datatypes.DataValue\"\r\n]}" +
				"}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.ChannelData.DataItem\",\"depends\":[\r" +
				"\n  \"Energistics.Etp.v12.Datatypes.IndexValue\",\r\n  \"Energistics.Etp.v12.Datatypes" +
				".DataValue\",\r\n  \"Energistics.Etp.v12.Datatypes.DataAttribute\"\r\n]}}}],\"protocol\":" +
				"\"22\",\"messageType\":\"4\",\"senderRole\":\"producer\",\"protocolRoles\":\"producer,consume" +
				"r\",\"multipartFlag\":\"True\",\"fullName\":\"Energistics.Etp.v12.Protocol.ChannelDataLo" +
				"ad.RealtimeData\",\"depends\":[\r\n  \"Energistics.Etp.v12.Datatypes.ChannelData.DataI" +
				"tem\"\r\n]}");
		private IList<Energistics.Etp.v12.Datatypes.ChannelData.DataItem> _data;
		public virtual Schema Schema
		{
			get
			{
				return RealtimeData._SCHEMA;
			}
		}
		public IList<Energistics.Etp.v12.Datatypes.ChannelData.DataItem> Data
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
			case 0: return this._data;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._data = (IList<Energistics.Etp.v12.Datatypes.ChannelData.DataItem>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
