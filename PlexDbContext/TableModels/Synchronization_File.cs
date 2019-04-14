using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    namespace PlexDbContext.TableModels
{

	[Table("synchronization_files")]
	public class Synchronization_File
{
		[Key]
		[Column("id")]
		public long Id{get;set;}

		[MaxLength(255)]
		[Column("client_identifier")]
		public string Client_Identifier{get;set;}

		[Column("sync_list_id")]
		public long? Sync_List_Id{get;set;}

		[Column("sync_item_id")]
		public long? Sync_Item_Id{get;set;}

		[MaxLength(255)]
		[Column("item_uri")]
		public string Item_Uri{get;set;}

		[Column("num_parts")]
		public long? Num_Parts{get;set;}

		[Column("state")]
		public long? State{get;set;}

		[Column("state_context")]
		public long? State_Context{get;set;}

		[MaxLength(255)]
		[Column("extra_data")]
		public string Extra_Data{get;set;}

		}
	}
