using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("synced_play_queue_generators")]
	public class Synced_Play_Queue_Generator
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[Column("sync_list_id")]
		public long? Sync_List_Id{get;set;}

		[Column("sync_item_id")]
		public long? Sync_Item_Id{get;set;}

		[Column("playlist_id")]
		public long? Playlist_Id{get;set;}

		[Column("play_queue_generator_id")]
		public long? Play_Queue_Generator_Id{get;set;}

		[Column("changed_at")]
		public long? Changed_At{get;set;}

		[Column("state")]
		public long? State{get;set;}

		[Column("state_context")]
		public long? State_Context{get;set;}

		[Column("first_packaged_at")]
		public long? First_Packaged_At{get;set;}

		}
	}
