using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("synced_ancestor_items")]
	public class Synced_Ancestor_Item
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[Column("sync_list_id")]
		public long? Sync_List_Id{get;set;}

		[Column("metadata_item_id")]
		public long? Metadata_Item_Id{get;set;}

		[Column("changed_at")]
		public long? Changed_At{get;set;}

		[Column("reference_count")]
		public long? Reference_Count{get;set;}

		[Column("first_packaged_at")]
		public long? First_Packaged_At{get;set;}

		[Column("parent_id")]
		public long? Parent_Id{get;set;}

		[Column("state")]
		public long? State{get;set;}

		}
	}
