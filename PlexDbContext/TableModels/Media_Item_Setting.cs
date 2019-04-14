using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("media_item_settings")]
	public class Media_Item_Setting
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[Column("account_id")]
		public long? Account_Id{get;set;}

		[Column("media_item_id")]
		public long? Media_Item_Id{get;set;}

		[MaxLength(255)]
		[Column("settings")]
		public string Settings{get;set;}

		[Column("created_at")]
		public DateTime? Created_At{get;set;}

		[Column("updated_at")]
		public DateTime? Updated_At{get;set;}

		}
	}
