using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


/// AUTOGENERATED FROM RUBYSOURCE
namespace Podio.API.Model
{
	[DataContract]
	public partial class AppStoreShare
	{


		[DataMember(Name = "share_id", IsRequired=false)]
		public int? ShareId { get; set; }


		[DataMember(Name = "type", IsRequired=false)]
		public string Type { get; set; }


		[DataMember(Name = "status", IsRequired=false)]
		public string Status { get; set; }


		[DataMember(Name = "name", IsRequired=false)]
		public string Name { get; set; }


		[DataMember(Name = "description", IsRequired=false)]
		public string Description { get; set; }


		[DataMember(Name = "abstract", IsRequired=false)]
		public string Abstract { get; set; }


		[DataMember(Name = "language", IsRequired=false)]
		public string Language { get; set; }


		[DataMember(Name = "features", IsRequired=false)]
		public string[] Features { get; set; }


		[DataMember(Name = "filters", IsRequired=false)]
		public string[] Filters { get; set; }


		[DataMember(Name = "integration", IsRequired=false)]
		public string Integration { get; set; }


		[DataMember(Name = "categories", IsRequired=false)]
		public Dictionary<string,object> Categories { get; set; }


		[DataMember(Name = "org", IsRequired=false)]
		public Dictionary<string,object> Org { get; set; }


		[DataMember(Name = "author_apps", IsRequired=false)]
		public int? AuthorApps { get; set; }


		[DataMember(Name = "author_packs", IsRequired=false)]
		public int? AuthorPacks { get; set; }


		[DataMember(Name = "icon", IsRequired=false)]
		public string Icon { get; set; }


		[DataMember(Name = "icon_id", IsRequired=false)]
		public int? IconId { get; set; }


		[DataMember(Name = "ratings", IsRequired=false)]
		public Dictionary<string,object> Ratings { get; set; }


		[DataMember(Name = "user_rating", IsRequired=false)]
		public string[] UserRating { get; set; }


		[DataMember(Name = "video", IsRequired=false)]
		public string Video { get; set; }


		[DataMember(Name = "rating", IsRequired=false)]
		public int? Rating { get; set; }


		[DataMember(Name = "author", IsRequired=false)]
		public ByLine Author { get; set; }


		[DataMember(Name = "space", IsRequired=false)]
		public Space Space { get; set; }


		[DataMember(Name = "app", IsRequired=false)]
		public Application App { get; set; }


		[DataMember(Name = "children", IsRequired=false)]
		public List<AppStoreShare> Children { get; set; }


		[DataMember(Name = "parents", IsRequired=false)]
		public List<AppStoreShare> Parents { get; set; }


		[DataMember(Name = "screenshots", IsRequired=false)]
		public List<FileAttachment> Screenshots { get; set; }


		[DataMember(Name = "comments", IsRequired=false)]
		public List<Comment> Comments { get; set; }


	}
}

