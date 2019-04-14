using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("versioned_metadata_items")]
	public class Versioned_Metadata_Item
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[Column("metadata_item_id")]
		public long? Metadata_Item_Id{get;set;}

		[Column("generator_id")]
		public long? Generator_Id{get;set;}

		[Column("target_tag_id")]
		public long? Target_Tag_Id{get;set;}

		[Column("state")]
		public long? State{get;set;}

		[Column("state_context")]
		public long? State_Context{get;set;}

		[Column("selected_media_id")]
		public long? Selected_Media_Id{get;set;}

		[Column("version_media_id")]
		public long? Version_Media_Id{get;set;}

		[Column("media_decision")]
		public long? Media_Decision{get;set;}

		[Column("file_size")]
		public long? File_Size{get;set;}

		}
	}
