using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("accounts")]
	public class Account
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[MaxLength(255)]
		[Column("name")]
		public string Name{get;set;}

		[MaxLength(255)]
		[Column("hashed_password")]
		public string Hashed_Password{get;set;}

		[MaxLength(255)]
		[Column("salt")]
		public string Salt{get;set;}

		[Column("created_at")]
		public DateTime? Created_At{get;set;}

		[Column("updated_at")]
		public DateTime? Updated_At{get;set;}

		[MaxLength(255)]
		[Column("default_audio_language")]
		public string Default_Audio_Language{get;set;}

		[MaxLength(255)]
		[Column("default_subtitle_language")]
		public string Default_Subtitle_Language{get;set;}

		[Column("auto_select_subtitle")]
		public bool? Auto_Select_Subtitle{get;set;}

		[Column("auto_select_audio")]
		public bool? Auto_Select_Audio{get;set;}

		}
	}
