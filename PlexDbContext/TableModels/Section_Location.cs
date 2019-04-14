using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("section_locations")]
	public class Section_Location
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[Column("library_section_id")]
		public long? Library_Section_Id{get;set;}

		[MaxLength(255)]
		[Column("root_path")]
		public string Root_Path{get;set;}

		[Column("available")]
		public bool? Available{get;set;}

		[Column("scanned_at")]
		public DateTime? Scanned_At{get;set;}

		[Column("created_at")]
		public DateTime? Created_At{get;set;}

		[Column("updated_at")]
		public DateTime? Updated_At{get;set;}

		}
	}
