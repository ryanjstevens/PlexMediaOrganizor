using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("schema_migrations")]
	public class Schema_Migration
{
		[MaxLength(255)]
		[Column("version")]
		public string Version{get;set;}

		[MaxLength(2147483647)]
		[Column("rollback_sql")]
		public string Rollback_Sql{get;set;}

		[Column("optimize_on_rollback")]
		public bool? Optimize_On_Rollback{get;set;}

		}
	}
