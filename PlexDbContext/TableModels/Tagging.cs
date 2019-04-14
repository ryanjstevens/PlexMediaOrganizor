using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("taggings")]
	public class Tagging
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[Column("metadata_item_id")]
		public long? Metadata_Item_Id{get;set;}

		[Column("tag_id")]
		public long? Tag_Id{get;set;}

		[Column("index")]
		public long? Index{get;set;}

		[MaxLength(255)]
		[Column("text")]
		public string Text{get;set;}

		[Column("time_offset")]
		public long? Time_Offset{get;set;}

		[Column("end_time_offset")]
		public long? End_Time_Offset{get;set;}

		[MaxLength(255)]
		[Column("thumb_url")]
		public string Thumb_Url{get;set;}

		[Column("created_at")]
		public DateTime? Created_At{get;set;}

		[MaxLength(255)]
		[Column("extra_data")]
		public string Extra_Data{get;set;}

		}
	}
