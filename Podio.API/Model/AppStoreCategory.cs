using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


/// AUTOGENERATED FROM RUBYSOURCE
namespace Podio.API.Model
{
	[DataContract]
	public partial class AppStoreCategory
	{


		[DataMember(Name = "category_id", IsRequired=false)]
		public int? CategoryId { get; set; }


		[DataMember(Name = "name", IsRequired=false)]
		public string Name { get; set; }


		[DataMember(Name = "type", IsRequired=false)]
		public string Type { get; set; }


	}
}

