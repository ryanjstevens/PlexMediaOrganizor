using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("locations_parent")]
	public class Locations_Parent
{
		[Key]
		[Column("nodeno")]
		public long Nodeno{get;set;}

		[Column("parentnode")]
		public long? Parentnode{get;set;}

		}
	}
