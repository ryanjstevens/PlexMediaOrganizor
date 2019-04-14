using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("media_subscriptions")]
	public class Media_Subscription
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[Column("order")]
		public double? Order{get;set;}

		[Column("metadata_type")]
		public long? Metadata_Type{get;set;}

		[Column("target_metadata_item_id")]
		public long? Target_Metadata_Item_Id{get;set;}

		[Column("target_library_section_id")]
		public long? Target_Library_Section_Id{get;set;}

		[Column("target_section_location_id")]
		public long? Target_Section_Location_Id{get;set;}

		[MaxLength(255)]
		[Column("extra_data")]
		public string Extra_Data{get;set;}

		[Column("created_at")]
		public DateTime? Created_At{get;set;}

		[Column("updated_at")]
		public DateTime? Updated_At{get;set;}

		}
	}
