using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("synced_metadata_items")]
	public class Synced_Metadata_Item
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[Column("sync_list_id")]
		public long? Sync_List_Id{get;set;}

		[Column("sync_item_id")]
		public long? Sync_Item_Id{get;set;}

		[Column("metadata_item_id")]
		public long? Metadata_Item_Id{get;set;}

		[Column("changed_at")]
		public long? Changed_At{get;set;}

		[Column("first_packaged_at")]
		public long? First_Packaged_At{get;set;}

		[Column("state")]
		public long? State{get;set;}

		[Column("state_context")]
		public long? State_Context{get;set;}

		[Column("selected_media_id")]
		public long? Selected_Media_Id{get;set;}

		[Column("selected_part_id")]
		public long? Selected_Part_Id{get;set;}

		[Column("media_decision")]
		public long? Media_Decision{get;set;}

		[Column("file_size")]
		public long? File_Size{get;set;}

		[MaxLength(255)]
		[Column("media_analysis_extra_data")]
		public string Media_Analysis_Extra_Data{get;set;}

		[Column("parent_id")]
		public long? Parent_Id{get;set;}

		[Column("library_section_id")]
		public long? Library_Section_Id{get;set;}

		}
	}
