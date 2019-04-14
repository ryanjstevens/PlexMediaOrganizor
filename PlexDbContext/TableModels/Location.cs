using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("locations")]
	public class Location
{
		[Column("id")]
		public long? Id{get;set;}

		[Column("lat_min")]
		public double? Lat_Min{get;set;}

		[Column("lat_max")]
		public double? Lat_Max{get;set;}

		[Column("lon_min")]
		public double? Lon_Min{get;set;}

		[Column("lon_max")]
		public double? Lon_Max{get;set;}

		}
	}
