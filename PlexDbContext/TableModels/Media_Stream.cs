using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("media_streams")]
	public class Media_Stream
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[Column("stream_type_id")]
		public long? Stream_Type_Id{get;set;}

		[Column("media_item_id")]
		public long? Media_Item_Id{get;set;}

		[MaxLength(255)]
		[Column("url")]
		public string Url{get;set;}

		[MaxLength(255)]
		[Column("codec")]
		public string Codec{get;set;}

		[MaxLength(255)]
		[Column("language")]
		public string Language{get;set;}

		[Column("created_at")]
		public DateTime? Created_At{get;set;}

		[Column("updated_at")]
		public DateTime? Updated_At{get;set;}

		[Column("index")]
		public long? Index{get;set;}

		[Column("media_part_id")]
		public long? Media_Part_Id{get;set;}

		[Column("channels")]
		public long? Channels{get;set;}

		[Column("bitrate")]
		public long? Bitrate{get;set;}

		[Column("url_index")]
		public long? Url_Index{get;set;}

		[Column("default")]
		public bool? Default{get;set;}

		[Column("forced")]
		public bool? Forced{get;set;}

		[MaxLength(255)]
		[Column("extra_data")]
		public string Extra_Data{get;set;}

		}
	}
