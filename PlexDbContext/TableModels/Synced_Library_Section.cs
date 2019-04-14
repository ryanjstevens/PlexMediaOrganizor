using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("synced_library_sections")]
	public class Synced_Library_Section
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[Column("sync_list_id")]
		public long? Sync_List_Id{get;set;}

		[Column("library_section_id")]
		public long? Library_Section_Id{get;set;}

		[Column("changed_at")]
		public long? Changed_At{get;set;}

		[Column("reference_count")]
		public long? Reference_Count{get;set;}

		[Column("first_packaged_at")]
		public long? First_Packaged_At{get;set;}

		[Column("state")]
		public long? State{get;set;}

		}
	}
