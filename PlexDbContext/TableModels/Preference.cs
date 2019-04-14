using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("preferences")]
	public class Preference
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[MaxLength(255)]
		[Column("name")]
		public string Name{get;set;}

		[MaxLength(255)]
		[Column("value")]
		public string Value{get;set;}

		}
	}
