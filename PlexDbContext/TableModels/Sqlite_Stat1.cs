using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("sqlite_stat1")]
	public class Sqlite_Stat1
{
		[MaxLength(2147483647)]
		[Column("tbl")]
		public string Tbl{get;set;}

		[MaxLength(2147483647)]
		[Column("idx")]
		public string Idx{get;set;}

		[MaxLength(2147483647)]
		[Column("stat")]
		public string Stat{get;set;}

		}
	}
