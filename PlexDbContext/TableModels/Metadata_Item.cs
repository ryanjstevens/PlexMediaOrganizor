using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("metadata_items")]
	public class Metadata_Item
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[Column("library_section_id")]
		public long? Library_Section_Id{get;set;}

		[Column("parent_id")]
		public long? Parent_Id{get;set;}

		[Column("metadata_type")]
		public long? Metadata_Type{get;set;}

		[MaxLength(255)]
		[Column("guid")]
		public string Guid{get;set;}

		[Column("media_item_count")]
		public long? Media_Item_Count{get;set;}

		[MaxLength(255)]
		[Column("title")]
		public string Title{get;set;}

		[MaxLength(255)]
		[Column("title_sort")]
		public string Title_Sort{get;set;}

		[MaxLength(255)]
		[Column("original_title")]
		public string Original_Title{get;set;}

		[MaxLength(255)]
		[Column("studio")]
		public string Studio{get;set;}

		[Column("rating")]
		public double? Rating{get;set;}

		[Column("rating_count")]
		public long? Rating_Count{get;set;}

		[MaxLength(255)]
		[Column("tagline")]
		public string Tagline{get;set;}

		[MaxLength(2147483647)]
		[Column("summary")]
		public string Summary{get;set;}

		[MaxLength(2147483647)]
		[Column("trivia")]
		public string Trivia{get;set;}

		[MaxLength(2147483647)]
		[Column("quotes")]
		public string Quotes{get;set;}

		[MaxLength(255)]
		[Column("content_rating")]
		public string Content_Rating{get;set;}

		[Column("content_rating_age")]
		public long? Content_Rating_Age{get;set;}

		[Column("index")]
		public long? Index{get;set;}

		[Column("absolute_index")]
		public long? Absolute_Index{get;set;}

		[Column("duration")]
		public long? Duration{get;set;}

		[MaxLength(255)]
		[Column("user_thumb_url")]
		public string User_Thumb_Url{get;set;}

		[MaxLength(255)]
		[Column("user_art_url")]
		public string User_Art_Url{get;set;}

		[MaxLength(255)]
		[Column("user_banner_url")]
		public string User_Banner_Url{get;set;}

		[MaxLength(255)]
		[Column("user_music_url")]
		public string User_Music_Url{get;set;}

		[MaxLength(255)]
		[Column("user_fields")]
		public string User_Fields{get;set;}

		[MaxLength(255)]
		[Column("tags_genre")]
		public string Tags_Genre{get;set;}

		[MaxLength(255)]
		[Column("tags_collection")]
		public string Tags_Collection{get;set;}

		[MaxLength(255)]
		[Column("tags_director")]
		public string Tags_Director{get;set;}

		[MaxLength(255)]
		[Column("tags_writer")]
		public string Tags_Writer{get;set;}

		[MaxLength(255)]
		[Column("tags_star")]
		public string Tags_Star{get;set;}

		[Column("originally_available_at")]
		public DateTime? Originally_Available_At{get;set;}

		[Column("available_at")]
		public DateTime? Available_At{get;set;}

		[Column("expires_at")]
		public DateTime? Expires_At{get;set;}

		[Column("refreshed_at")]
		public DateTime? Refreshed_At{get;set;}

		[Column("year")]
		public long? Year{get;set;}

		[Column("added_at")]
		public DateTime? Added_At{get;set;}

		[Column("created_at")]
		public DateTime? Created_At{get;set;}

		[Column("updated_at")]
		public DateTime? Updated_At{get;set;}

		[Column("deleted_at")]
		public DateTime? Deleted_At{get;set;}

		[MaxLength(255)]
		[Column("tags_country")]
		public string Tags_Country{get;set;}

		[MaxLength(255)]
		[Column("extra_data")]
		public string Extra_Data{get;set;}

		[MaxLength(255)]
		[Column("hash")]
		public string Hash{get;set;}

		[Column("audience_rating")]
		public double? Audience_Rating{get;set;}

		[Column("changed_at")]
		public long? Changed_At{get;set;}

		[Column("resources_changed_at")]
		public long? Resources_Changed_At{get;set;}

		}
	}
