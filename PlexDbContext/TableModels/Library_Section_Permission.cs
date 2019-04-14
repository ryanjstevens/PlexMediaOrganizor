using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("library_section_permissions")]
	public class Library_Section_Permission
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[Column("library_section_id")]
		public long? Library_Section_Id{get;set;}

		[Column("account_id")]
		public long? Account_Id{get;set;}

		[Column("permission")]
		public long? Permission{get;set;}

		}
	}
