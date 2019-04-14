using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("metadata_relations")]
	public class Metadata_Relation
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[Column("metadata_item_id")]
		public long? Metadata_Item_Id{get;set;}

		[Column("related_metadata_item_id")]
		public long? Related_Metadata_Item_Id{get;set;}

		[Column("relation_type")]
		public long? Relation_Type{get;set;}

		[Column("created_at")]
		public DateTime? Created_At{get;set;}

		[Column("updated_at")]
		public DateTime? Updated_At{get;set;}

		}
	}
