using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("media_parts")]
	public class Media_Part
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[Column("media_item_id")]
		public long? Media_Item_Id{get;set;}

		[Column("directory_id")]
		public long? Directory_Id{get;set;}

		[MaxLength(255)]
		[Column("hash")]
		public string Hash{get;set;}

		[MaxLength(255)]
		[Column("open_subtitle_hash")]
		public string Open_Subtitle_Hash{get;set;}

		[MaxLength(255)]
		[Column("file")]
		public string File{get;set;}

		[Column("index")]
		public long? Index{get;set;}

		[Column("size")]
		public long? Size{get;set;}

		[Column("duration")]
		public long? Duration{get;set;}

		[Column("created_at")]
		public DateTime? Created_At{get;set;}

		[Column("updated_at")]
		public DateTime? Updated_At{get;set;}

		[Column("deleted_at")]
		public DateTime? Deleted_At{get;set;}

		[MaxLength(255)]
		[Column("extra_data")]
		public string Extra_Data{get;set;}

		}
	}
