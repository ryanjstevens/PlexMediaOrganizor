using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("media_part_settings")]
	public class Media_Part_Setting
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[Column("account_id")]
		public long? Account_Id{get;set;}

		[Column("media_part_id")]
		public long? Media_Part_Id{get;set;}

		[Column("selected_audio_stream_id")]
		public long? Selected_Audio_Stream_Id{get;set;}

		[Column("selected_subtitle_stream_id")]
		public long? Selected_Subtitle_Stream_Id{get;set;}

		[MaxLength(255)]
		[Column("settings")]
		public string Settings{get;set;}

		[Column("created_at")]
		public DateTime? Created_At{get;set;}

		[Column("updated_at")]
		public DateTime? Updated_At{get;set;}

		[Column("changed_at")]
		public long? Changed_At{get;set;}

		}
	}
