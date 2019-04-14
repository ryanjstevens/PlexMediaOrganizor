using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("sync_schema_versions")]
	public class Sync_Schema_Version
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[Column("version")]
		public long? Version{get;set;}

		[Column("changed_at")]
		public long? Changed_At{get;set;}

		}
	}
