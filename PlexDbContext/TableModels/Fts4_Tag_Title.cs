using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("fts4_tag_titles")]
	public class Fts4_Tag_Title
{
		[MaxLength(2147483647)]
		[Column("tag")]
		public string Tag{get;set;}

		}
	}
