using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


/// AUTOGENERATED FROM RUBYSOURCE
namespace Podio.API.Model
{
	[DataContract]
	public partial class Action
	{


		[DataMember(Name = "action_id", IsRequired=false)]
		public int? ActionId { get; set; }


		[DataMember(Name = "type", IsRequired=false)]
		public string Type { get; set; }


		[DataMember(Name = "data", IsRequired=false)]
		public Dictionary<string,object> Data { get; set; }


		[DataMember(Name = "text", IsRequired=false)]
		public string Text { get; set; }


	}
}

