using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("fts4_metadata_titles_stat")]
	public class Fts4_Metadata_Titles_Stat
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[Column("value")]
		public byte[] Value{get;set;}

		}
	}
