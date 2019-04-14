using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("external_metadata_items")]
	public class External_Metadata_Item
{
		[Column("id")]
		public long? Id{get;set;}

		[Column("external_metadata_source_id")]
		public long? External_Metadata_Source_Id{get;set;}

		[Column("library_section_id")]
		public long? Library_Section_Id{get;set;}

		[Column("metadata_type")]
		public long? Metadata_Type{get;set;}

		[MaxLength(255)]
		[Column("guid")]
		public string Guid{get;set;}

		[MaxLength(255)]
		[Column("title")]
		public string Title{get;set;}

		[MaxLength(255)]
		[Column("parent_title")]
		public string Parent_Title{get;set;}

		[Column("year")]
		public long? Year{get;set;}

		[Column("added_at")]
		public long? Added_At{get;set;}

		[Column("updated_at")]
		public long? Updated_At{get;set;}

		}
	}
