using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("plugin_permissions")]
	public class Plugin_Permission
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[Column("plugin_id")]
		public long? Plugin_Id{get;set;}

		[Column("account_id")]
		public long? Account_Id{get;set;}

		[Column("permission")]
		public long? Permission{get;set;}

		}
	}
