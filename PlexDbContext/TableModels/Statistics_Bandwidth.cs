using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("statistics_bandwidth")]
	public class Statistics_Bandwidth
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

		[Column("lan")]
		public bool? Lan{get;set;}

		[Column("bytes")]
		public long? Bytes{get;set;}

		}
	}
