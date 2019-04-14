using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("metadata_item_clusters")]
	public class Metadata_Item_Cluster
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[Column("zoom_level")]
		public long? Zoom_Level{get;set;}

		[Column("library_section_id")]
		public long? Library_Section_Id{get;set;}

		[MaxLength(255)]
		[Column("title")]
		public string Title{get;set;}

		[Column("count")]
		public long? Count{get;set;}

		[Column("starts_at")]
		public DateTime? Starts_At{get;set;}

		[Column("ends_at")]
		public DateTime? Ends_At{get;set;}

		[MaxLength(255)]
		[Column("extra_data")]
		public string Extra_Data{get;set;}

		}
	}
