using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("blobs")]
	public class Blob
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[Column("blob")]
		public byte[] Blob_{get;set;}

		[MaxLength(255)]
		[Column("linked_type")]
		public string Linked_Type{get;set;}

		[Column("linked_id")]
		public long? Linked_Id{get;set;}

		[MaxLength(255)]
		[Column("linked_guid")]
		public string Linked_Guid{get;set;}

		[Column("created_at")]
		public DateTime? Created_At{get;set;}

		}
	}
