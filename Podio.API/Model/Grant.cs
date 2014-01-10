using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


/// AUTOGENERATED FROM RUBYSOURCE
namespace Podio.API.Model
{
	[DataContract]
	public partial class Grant
	{


		[DataMember(Name = "ref_type", IsRequired=false)]
		public string RefType { get; set; }


		[DataMember(Name = "ref_id", IsRequired=false)]
		public int? RefId { get; set; }


		[DataMember(Name = "people", IsRequired=false)]
		public Dictionary<string,object> People { get; set; }


		[DataMember(Name = "action", IsRequired=false)]
		public string Action { get; set; }


		[DataMember(Name = "message", IsRequired=false)]
		public string Message { get; set; }


		[DataMember(Name = "ref", IsRequired=false)]
		public Dictionary<string,object> Ref { get; set; }


		[DataMember(Name = "created_by", IsRequired=false)]
		public ByLine CreatedBy { get; set; }


		[DataMember(Name = "user", IsRequired=false)]
		public Contact User { get; set; }


	}
}
