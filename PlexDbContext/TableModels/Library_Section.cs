using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("library_sections")]
	public class Library_Section
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[Column("library_id")]
		public long? Library_Id{get;set;}

		[MaxLength(255)]
		[Column("name")]
		public string Name{get;set;}

		[MaxLength(255)]
		[Column("name_sort")]
		public string Name_Sort{get;set;}

		[Column("section_type")]
		public long? Section_Type{get;set;}

		[MaxLength(255)]
		[Column("language")]
		public string Language{get;set;}

		[MaxLength(255)]
		[Column("agent")]
		public string Agent{get;set;}

		[MaxLength(255)]
		[Column("scanner")]
		public string Scanner{get;set;}

		[MaxLength(255)]
		[Column("user_thumb_url")]
		public string User_Thumb_Url{get;set;}

		[MaxLength(255)]
		[Column("user_art_url")]
		public string User_Art_Url{get;set;}

		[MaxLength(255)]
		[Column("user_theme_music_url")]
		public string User_Theme_Music_Url{get;set;}

		[Column("public")]
		public bool? Public{get;set;}

		[Column("created_at")]
		public DateTime? Created_At{get;set;}

		[Column("updated_at")]
		public DateTime? Updated_At{get;set;}

		[Column("scanned_at")]
		public DateTime? Scanned_At{get;set;}

		[Column("display_secondary_level")]
		public bool? Display_Secondary_Level{get;set;}

		[MaxLength(255)]
		[Column("user_fields")]
		public string User_Fields{get;set;}

		[MaxLength(2147483647)]
		[Column("query_xml")]
		public string Query_Xml{get;set;}

		[Column("query_type")]
		public long? Query_Type{get;set;}

		[MaxLength(255)]
		[Column("uuid")]
		public string Uuid{get;set;}

		[Column("changed_at")]
		public long? Changed_At{get;set;}

		}
	}
