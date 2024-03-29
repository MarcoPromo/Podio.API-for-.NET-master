using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


/// AUTOGENERATED FROM RUBYSOURCE
namespace Podio.API.Model
{
	[DataContract]
	public partial class ByLine
	{


		[DataMember(Name = "type", IsRequired=false)]
		public string Type { get; set; }


		[DataMember(Name = "id", IsRequired=false)]
		public int? Id { get; set; }


		[DataMember(Name = "avatar_type", IsRequired=false)]
		public string AvatarType { get; set; }


		[DataMember(Name = "avatar_id", IsRequired=false)]
		public int? AvatarId { get; set; }


		[DataMember(Name = "image", IsRequired=false)]
		public FileAttachment Image { get; set; }


		[DataMember(Name = "name", IsRequired=false)]
		public string Name { get; set; }


		[DataMember(Name = "url", IsRequired=false)]
		public string Url { get; set; }


		[DataMember(Name = "avatar", IsRequired=false)]
		public int? Avatar { get; set; }


	}
}

