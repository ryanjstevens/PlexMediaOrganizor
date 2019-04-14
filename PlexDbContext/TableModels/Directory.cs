using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("directories")]
	public class Directory
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[Column("library_section_id")]
		public long? Library_Section_Id{get;set;}

		[Column("parent_directory_id")]
		public long? Parent_Directory_Id{get;set;}

		[MaxLength(255)]
		[Column("path")]
		public string Path{get;set;}

		[Column("created_at")]
		public DateTime? Created_At{get;set;}

		[Column("updated_at")]
		public DateTime? Updated_At{get;set;}

		[Column("deleted_at")]
		public DateTime? Deleted_At{get;set;}

		}
	}
