using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("media_items")]
	public class Media_Item
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[Column("library_section_id")]
		public long? Library_Section_Id{get;set;}

		[Column("section_location_id")]
		public long? Section_Location_Id{get;set;}

		[Column("metadata_item_id")]
		public long? Metadata_Item_Id{get;set;}

		[Column("type_id")]
		public long? Type_Id{get;set;}

		[Column("width")]
		public long? Width{get;set;}

		[Column("height")]
		public long? Height{get;set;}

		[Column("size")]
		public long? Size{get;set;}

		[Column("duration")]
		public long? Duration{get;set;}

		[Column("bitrate")]
		public long? Bitrate{get;set;}

		[MaxLength(255)]
		[Column("container")]
		public string Container{get;set;}

		[MaxLength(255)]
		[Column("video_codec")]
		public string Video_Codec{get;set;}

		[MaxLength(255)]
		[Column("audio_codec")]
		public string Audio_Codec{get;set;}

		[Column("display_aspect_ratio")]
		public double? Display_Aspect_Ratio{get;set;}

		[Column("frames_per_second")]
		public double? Frames_Per_Second{get;set;}

		[Column("audio_channels")]
		public long? Audio_Channels{get;set;}

		[Column("interlaced")]
		public bool? Interlaced{get;set;}

		[MaxLength(255)]
		[Column("source")]
		public string Source{get;set;}

		[MaxLength(255)]
		[Column("hints")]
		public string Hints{get;set;}

		[Column("display_offset")]
		public long? Display_Offset{get;set;}

		[MaxLength(255)]
		[Column("settings")]
		public string Settings{get;set;}

		[Column("created_at")]
		public DateTime? Created_At{get;set;}

		[Column("updated_at")]
		public DateTime? Updated_At{get;set;}

		[Column("optimized_for_streaming")]
		public bool? Optimized_For_Streaming{get;set;}

		[Column("deleted_at")]
		public DateTime? Deleted_At{get;set;}

		[Column("media_analysis_version")]
		public long? Media_Analysis_Version{get;set;}

		[Column("sample_aspect_ratio")]
		public double? Sample_Aspect_Ratio{get;set;}

		[MaxLength(255)]
		[Column("extra_data")]
		public string Extra_Data{get;set;}

		[Column("proxy_type")]
		public long? Proxy_Type{get;set;}

		[Column("channel_id")]
		public long? Channel_Id{get;set;}

		[Column("begins_at")]
		public DateTime? Begins_At{get;set;}

		[Column("ends_at")]
		public DateTime? Ends_At{get;set;}

		}
	}
