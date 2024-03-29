using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


/// AUTOGENERATED FROM RUBYSOURCE
namespace Podio.API.Model
{
	[DataContract]
	public partial class OAuthClient
	{


		[DataMember(Name = "auth_client_id", IsRequired=false)]
		public int? AuthClientId { get; set; }


		[DataMember(Name = "name", IsRequired=false)]
		public string Name { get; set; }


		[DataMember(Name = "key", IsRequired=false)]
		public string Key { get; set; }


		[DataMember(Name = "secret", IsRequired=false)]
		public string Secret { get; set; }


		[DataMember(Name = "url", IsRequired=false)]
		public string Url { get; set; }


		[DataMember(Name = "domain", IsRequired=false)]
		public string Domain { get; set; }


	}
}

