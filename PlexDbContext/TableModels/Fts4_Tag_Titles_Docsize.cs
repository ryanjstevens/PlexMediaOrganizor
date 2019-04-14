using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("fts4_tag_titles_docsize")]
	public class Fts4_Tag_Titles_Docsize
{
		[Key]
		[Column("docid")]
		public long Docid{get;set;}

		[Column("size")]
		public byte[] Size{get;set;}

		}
	}
