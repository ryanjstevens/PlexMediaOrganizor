using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("fts4_metadata_titles_segdir")]
	public class Fts4_Metadata_Titles_Segdir
{
		[Key]
		[Column("level", Order=0)]
		public long Level{get;set;}

		[Key]
		[Column("idx", Order=1)]
		public long Idx{get;set;}

		[Column("start_block")]
		public long? Start_Block{get;set;}

		[Column("leaves_end_block")]
		public long? Leaves_End_Block{get;set;}

		[Column("end_block")]
		public long? End_Block{get;set;}

		[Column("root")]
		public byte[] Root{get;set;}

		}
	}
