using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("plugins")]
	public class Plugin
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[MaxLength(255)]
		[Column("identifier")]
		public string Identifier{get;set;}

		[Column("framework_version")]
		public long? Framework_Version{get;set;}

		[Column("access_count")]
		public long? Access_Count{get;set;}

		[Column("installed_at")]
		public DateTime? Installed_At{get;set;}

		[Column("accessed_at")]
		public DateTime? Accessed_At{get;set;}

		[Column("modified_at")]
		public DateTime? Modified_At{get;set;}

		}
	}
