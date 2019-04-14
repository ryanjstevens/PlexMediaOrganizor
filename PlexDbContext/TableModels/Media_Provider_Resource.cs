using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("media_provider_resources")]
	public class Media_Provider_Resource
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[Column("parent_id")]
		public long? Parent_Id{get;set;}

		[Column("type")]
		public long? Type{get;set;}

		[Column("status")]
		public long? Status{get;set;}

		[Column("state")]
		public long? State{get;set;}

		[MaxLength(255)]
		[Column("identifier")]
		public string Identifier{get;set;}

		[MaxLength(255)]
		[Column("protocol")]
		public string Protocol{get;set;}

		[MaxLength(255)]
		[Column("uri")]
		public string Uri{get;set;}

		[MaxLength(255)]
		[Column("uuid")]
		public string Uuid{get;set;}

		[MaxLength(255)]
		[Column("extra_data")]
		public string Extra_Data{get;set;}

		[Column("last_seen_at")]
		public DateTime? Last_Seen_At{get;set;}

		[Column("created_at")]
		public DateTime? Created_At{get;set;}

		[Column("updated_at")]
		public DateTime? Updated_At{get;set;}

		[Column("data")]
		public byte[] Data{get;set;}

		}
	}
