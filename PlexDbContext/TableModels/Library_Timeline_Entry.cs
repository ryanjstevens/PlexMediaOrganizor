using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("library_timeline_entries")]
	public class Library_Timeline_Entry
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[Column("library_section_id")]
		public long? Library_Section_Id{get;set;}

		[Column("metadata_item_id")]
		public long? Metadata_Item_Id{get;set;}

		[Column("state")]
		public long? State{get;set;}

		[Column("updated_at")]
		public DateTime? Updated_At{get;set;}

		}
	}
