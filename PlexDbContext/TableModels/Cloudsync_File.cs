using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("cloudsync_files")]
	public class Cloudsync_File
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[MaxLength(255)]
		[Column("device_identifier")]
		public string Device_Identifier{get;set;}

		[MaxLength(255)]
		[Column("original_url")]
		public string Original_Url{get;set;}

		[MaxLength(255)]
		[Column("provider")]
		public string Provider{get;set;}

		[MaxLength(255)]
		[Column("new_key")]
		public string New_Key{get;set;}

		[MaxLength(255)]
		[Column("query_string")]
		public string Query_String{get;set;}

		[MaxLength(255)]
		[Column("extra_data")]
		public string Extra_Data{get;set;}

		}
	}
