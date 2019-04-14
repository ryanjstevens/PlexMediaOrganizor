using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("fts4_tag_titles_segments")]
	public class Fts4_Tag_Titles_Segment
{
		[Key]
		[Column("blockid")]
		public long Blockid{get;set;}

		[Column("block")]
		public byte[] Block{get;set;}

		}
	}
