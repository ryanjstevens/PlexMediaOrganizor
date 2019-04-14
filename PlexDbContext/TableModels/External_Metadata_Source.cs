using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("external_metadata_sources")]
	public class External_Metadata_Source
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[MaxLength(255)]
		[Column("uri")]
		public string Uri{get;set;}

		[MaxLength(255)]
		[Column("source_title")]
		public string Source_Title{get;set;}

		[MaxLength(255)]
		[Column("user_title")]
		public string User_Title{get;set;}

		[Column("online")]
		public long? Online{get;set;}

		}
	}
