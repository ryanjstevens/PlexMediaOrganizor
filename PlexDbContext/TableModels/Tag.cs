using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("tags")]
	public class Tag
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[Column("metadata_item_id")]
		public long? Metadata_Item_Id{get;set;}

		[MaxLength(255)]
		[Column("tag")]
		public string Tag_{get;set;}

		[Column("tag_type")]
		public long? Tag_Type{get;set;}

		[MaxLength(255)]
		[Column("user_thumb_url")]
		public string User_Thumb_Url{get;set;}

		[MaxLength(255)]
		[Column("user_art_url")]
		public string User_Art_Url{get;set;}

		[MaxLength(255)]
		[Column("user_music_url")]
		public string User_Music_Url{get;set;}

		[Column("created_at")]
		public DateTime? Created_At{get;set;}

		[Column("updated_at")]
		public DateTime? Updated_At{get;set;}

		[Column("tag_value")]
		public long? Tag_Value{get;set;}

		[MaxLength(255)]
		[Column("extra_data")]
		public string Extra_Data{get;set;}

		[MaxLength(255)]
		[Column("key")]
		public string Key{get;set;}

		[Column("parent_id")]
		public long? Parent_Id{get;set;}

		}
	}
