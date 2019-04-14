using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("locations_rowid")]
	public class Locations_Rowid
{
		[Key]
		[Column("rowid")]
		public long Rowid{get;set;}

		[Column("nodeno")]
		public long? Nodeno{get;set;}

		}
	}
