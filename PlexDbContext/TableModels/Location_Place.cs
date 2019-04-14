using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("location_places")]
	public class Location_Place
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[Column("location_id")]
		public long? Location_Id{get;set;}

		[MaxLength(255)]
		[Column("guid")]
		public string Guid{get;set;}

		}
	}
