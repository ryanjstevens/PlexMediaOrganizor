using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("view_settings")]
	public class View_Setting
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[Column("account_id")]
		public long? Account_Id{get;set;}

		[MaxLength(255)]
		[Column("client_type")]
		public string Client_Type{get;set;}

		[MaxLength(255)]
		[Column("view_group")]
		public string View_Group{get;set;}

		[Column("view_id")]
		public long? View_Id{get;set;}

		[Column("sort_id")]
		public long? Sort_Id{get;set;}

		[Column("sort_asc")]
		public bool? Sort_Asc{get;set;}

		[Column("created_at")]
		public DateTime? Created_At{get;set;}

		[Column("updated_at")]
		public DateTime? Updated_At{get;set;}

		}
	}
