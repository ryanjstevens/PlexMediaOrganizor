using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("plugin_prefixes")]
	public class Plugin_Prefix
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[Column("plugin_id")]
		public long? Plugin_Id{get;set;}

		[MaxLength(255)]
		[Column("name")]
		public string Name{get;set;}

		[MaxLength(255)]
		[Column("prefix")]
		public string Prefix{get;set;}

		[MaxLength(255)]
		[Column("art_url")]
		public string Art_Url{get;set;}

		[MaxLength(255)]
		[Column("thumb_url")]
		public string Thumb_Url{get;set;}

		[MaxLength(255)]
		[Column("titlebar_url")]
		public string Titlebar_Url{get;set;}

		[Column("share")]
		public bool? Share{get;set;}

		[Column("has_store_services")]
		public bool? Has_Store_Services{get;set;}

		[Column("prefs")]
		public bool? Prefs{get;set;}

		}
	}
