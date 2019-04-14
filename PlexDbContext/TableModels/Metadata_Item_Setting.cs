using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("metadata_item_settings")]
	public class Metadata_Item_Setting
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[Column("account_id")]
		public long? Account_Id{get;set;}

		[MaxLength(255)]
		[Column("guid")]
		public string Guid{get;set;}

		[Column("rating")]
		public double? Rating{get;set;}

		[Column("view_offset")]
		public long? View_Offset{get;set;}

		[Column("view_count")]
		public long? View_Count{get;set;}

		[Column("last_viewed_at")]
		public DateTime? Last_Viewed_At{get;set;}

		[Column("created_at")]
		public DateTime? Created_At{get;set;}

		[Column("updated_at")]
		public DateTime? Updated_At{get;set;}

		[Column("skip_count")]
		public long? Skip_Count{get;set;}

		[Column("last_skipped_at")]
		public DateTime? Last_Skipped_At{get;set;}

		[Column("changed_at")]
		public long? Changed_At{get;set;}

		[MaxLength(255)]
		[Column("extra_data")]
		public string Extra_Data{get;set;}

		}
	}
