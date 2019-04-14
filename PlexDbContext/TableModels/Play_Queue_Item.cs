using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("play_queue_items")]
	public class Play_Queue_Item
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[Column("play_queue_id")]
		public long? Play_Queue_Id{get;set;}

		[Column("metadata_item_id")]
		public long? Metadata_Item_Id{get;set;}

		[Column("order")]
		public double? Order{get;set;}

		[Column("up_next")]
		public bool? Up_Next{get;set;}

		[Column("play_queue_generator_id")]
		public long? Play_Queue_Generator_Id{get;set;}

		}
	}
