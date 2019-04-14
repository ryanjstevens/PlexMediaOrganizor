using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("play_queue_generators")]
	public class Play_Queue_Generator
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[Column("playlist_id")]
		public long? Playlist_Id{get;set;}

		[Column("metadata_item_id")]
		public long? Metadata_Item_Id{get;set;}

		[MaxLength(255)]
		[Column("uri")]
		public string Uri{get;set;}

		[Column("limit")]
		public long? Limit{get;set;}

		[Column("continuous")]
		public bool? Continuous{get;set;}

		[Column("order")]
		public double? Order{get;set;}

		[Column("created_at")]
		public DateTime Created_At{get;set;}

		[Column("updated_at")]
		public DateTime Updated_At{get;set;}

		[Column("changed_at")]
		public long? Changed_At{get;set;}

		[Column("recursive")]
		public bool? Recursive{get;set;}

		[Column("type")]
		public long? Type{get;set;}

		[MaxLength(255)]
		[Column("extra_data")]
		public string Extra_Data{get;set;}

		}
	}
