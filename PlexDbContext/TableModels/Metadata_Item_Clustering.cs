using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("metadata_item_clusterings")]
	public class Metadata_Item_Clustering
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[Column("metadata_item_id")]
		public long? Metadata_Item_Id{get;set;}

		[Column("metadata_item_cluster_id")]
		public long? Metadata_Item_Cluster_Id{get;set;}

		[Column("index")]
		public long? Index{get;set;}

		[Column("version")]
		public long? Version{get;set;}

		}
	}
