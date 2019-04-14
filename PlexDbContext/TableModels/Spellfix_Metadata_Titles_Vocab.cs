using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("spellfix_metadata_titles_vocab")]
	public class Spellfix_Metadata_Titles_Vocab
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[Column("rank")]
		public int? Rank{get;set;}

		[Column("langid")]
		public int? Langid{get;set;}

		[MaxLength(2147483647)]
		[Column("word")]
		public string Word{get;set;}

		[MaxLength(2147483647)]
		[Column("k1")]
		public string K1{get;set;}

		[MaxLength(2147483647)]
		[Column("k2")]
		public string K2{get;set;}

		}
	}
