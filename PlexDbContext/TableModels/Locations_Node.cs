using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("locations_node")]
	public class Locations_Node
{
		[Key]
		[Column("nodeno")]
		public long Nodeno{get;set;}

		[Column("data")]
		public byte[] Data{get;set;}

		}
	}
