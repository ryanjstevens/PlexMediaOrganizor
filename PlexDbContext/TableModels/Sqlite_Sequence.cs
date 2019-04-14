using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("sqlite_sequence")]
	public class Sqlite_Sequence
{
		[MaxLength(2147483647)]
		[Column("name")]
		public string Name{get;set;}

		[Column("seq")]
		public long? Seq{get;set;}

		}
	}
