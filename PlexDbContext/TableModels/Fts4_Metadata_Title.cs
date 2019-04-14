using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("fts4_metadata_titles")]
	public class Fts4_Metadata_Title
{
		[MaxLength(2147483647)]
		[Column("title")]
		public string Title{get;set;}

		[MaxLength(2147483647)]
		[Column("title_sort")]
		public string Title_Sort{get;set;}

		[MaxLength(2147483647)]
		[Column("original_title")]
		public string Original_Title{get;set;}

		}
	}
