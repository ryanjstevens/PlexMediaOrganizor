using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("statistics_media")]
	public class Statistics_Medium
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[Column("account_id")]
		public long? Account_Id{get;set;}

		[Column("device_id")]
		public long? Device_Id{get;set;}

		[Column("timespan")]
		public long? Timespan{get;set;}

		[Column("at")]
		public DateTime? At{get;set;}

		[Column("metadata_type")]
		public long? Metadata_Type{get;set;}

		[Column("count")]
		public long? Count{get;set;}

		[Column("duration")]
		public long? Duration{get;set;}

		}
	}
