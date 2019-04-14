using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("play_queues")]
	public class Play_Queue
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[MaxLength(255)]
		[Column("client_identifier")]
		public string Client_Identifier{get;set;}

		[Column("account_id")]
		public long? Account_Id{get;set;}

		[Column("playlist_id")]
		public long? Playlist_Id{get;set;}

		[Column("sync_item_id")]
		public long? Sync_Item_Id{get;set;}

		[Column("play_queue_generator_id")]
		public long? Play_Queue_Generator_Id{get;set;}

		[Column("generator_start_index")]
		public long? Generator_Start_Index{get;set;}

		[Column("generator_end_index")]
		public long? Generator_End_Index{get;set;}

		[Column("generator_items_count")]
		public long? Generator_Items_Count{get;set;}

		[Column("generator_ids")]
		public byte[] Generator_Ids{get;set;}

		[Column("seed")]
		public long? Seed{get;set;}

		[Column("current_play_queue_item_id")]
		public long? Current_Play_Queue_Item_Id{get;set;}

		[Column("last_added_play_queue_item_id")]
		public long? Last_Added_Play_Queue_Item_Id{get;set;}

		[Column("version")]
		public long? Version{get;set;}

		[Column("created_at")]
		public DateTime? Created_At{get;set;}

		[Column("updated_at")]
		public DateTime? Updated_At{get;set;}

		[Column("metadata_type")]
		public long? Metadata_Type{get;set;}

		[Column("total_items_count")]
		public long? Total_Items_Count{get;set;}

		[Column("generator_generator_ids")]
		public byte[] Generator_Generator_Ids{get;set;}

		}
	}
