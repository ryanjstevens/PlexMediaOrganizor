using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("locatables")]
	public class Locatable
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[Column("location_id")]
		public long Location_Id{get;set;}

		[Column("locatable_id")]
		public long Locatable_Id{get;set;}

		[MaxLength(255)]
		[Column("locatable_type")]
		public string Locatable_Type{get;set;}

		[Column("created_at")]
		public DateTime? Created_At{get;set;}

		[Column("updated_at")]
		public DateTime? Updated_At{get;set;}

		[MaxLength(255)]
		[Column("extra_data")]
		public string Extra_Data{get;set;}

		[Column("geocoding_version")]
		public long? Geocoding_Version{get;set;}

		}
	}
