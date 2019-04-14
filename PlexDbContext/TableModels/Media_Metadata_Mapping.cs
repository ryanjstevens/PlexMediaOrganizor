using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("media_metadata_mappings")]
	public class Media_Metadata_Mapping
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[MaxLength(255)]
		[Column("media_guid")]
		public string Media_Guid{get;set;}

		[MaxLength(255)]
		[Column("metadata_guid")]
		public string Metadata_Guid{get;set;}

		[Column("created_at")]
		public DateTime? Created_At{get;set;}

		[Column("updated_at")]
		public DateTime? Updated_At{get;set;}

		}
	}
