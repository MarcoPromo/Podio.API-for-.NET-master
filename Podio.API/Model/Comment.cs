using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


/// AUTOGENERATED FROM RUBYSOURCE
namespace Podio.API.Model
{
	[DataContract]
	public partial class Comment
	{


		[DataMember(Name = "comment_id", IsRequired=false)]
		public int? CommentId { get; set; }


		[DataMember(Name = "value", IsRequired=false)]
		public string Value { get; set; }


		[DataMember(Name = "rich_value", IsRequired=false)]
		public string RichValue { get; set; }


		[DataMember(Name = "external_id", IsRequired=false)]
		public string ExternalId { get; set; }


		[DataMember(Name = "space_id", IsRequired=false)]
		public int? SpaceId { get; set; }


		[DataMember(Name = "created_on", IsRequired=false)]
		public DateTime? CreatedOn { get; set; }


		[DataMember(Name = "file_ids", IsRequired=false)]
		public List<int> FileIds { get; set; }


		[DataMember(Name = "embed_id", IsRequired=false)]
		public int? EmbedId { get; set; }


		[DataMember(Name = "embed_file_id", IsRequired=false)]
		public int? EmbedFileId { get; set; }


		[DataMember(Name = "embed", IsRequired=false)]
		public Embed Embed { get; set; }


		[DataMember(Name = "embed_file", IsRequired=false)]
		public FileAttachment EmbedFile { get; set; }


		[DataMember(Name = "created_by", IsRequired=false)]
		public ByLine CreatedBy { get; set; }


		[DataMember(Name = "created_via", IsRequired=false)]
		public Via CreatedVia { get; set; }


		[DataMember(Name = "files", IsRequired=false)]
		public List<FileAttachment> Files { get; set; }


		[DataMember(Name = "questions", IsRequired=false)]
		public List<Question> Questions { get; set; }


	}
}

