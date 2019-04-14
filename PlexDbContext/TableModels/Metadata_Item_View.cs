using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("metadata_item_views")]
	public class Metadata_Item_View
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[Column("account_id")]
		public long? Account_Id{get;set;}

		[MaxLength(255)]
		[Column("guid")]
		public string Guid{get;set;}

		[Column("metadata_type")]
		public long? Metadata_Type{get;set;}

		[Column("library_section_id")]
		public long? Library_Section_Id{get;set;}

		[MaxLength(255)]
		[Column("grandparent_title")]
		public string Grandparent_Title{get;set;}

		[Column("parent_index")]
		public long? Parent_Index{get;set;}

		[MaxLength(255)]
		[Column("parent_title")]
		public string Parent_Title{get;set;}

		[Column("index")]
		public long? Index{get;set;}

		[MaxLength(255)]
		[Column("title")]
		public string Title{get;set;}

		[MaxLength(255)]
		[Column("thumb_url")]
		public string Thumb_Url{get;set;}

		[Column("viewed_at")]
		public DateTime? Viewed_At{get;set;}

		[MaxLength(255)]
		[Column("grandparent_guid")]
		public string Grandparent_Guid{get;set;}

		[Column("originally_available_at")]
		public DateTime? Originally_Available_At{get;set;}

		}
	}
