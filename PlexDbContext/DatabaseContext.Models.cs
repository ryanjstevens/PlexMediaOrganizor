using PlexDbContext.TableModels;
using System.Data.Entity;
namespace PlexDbContext
{

    public partial class DatabaseContext : SQLiteContext.DatabaseContext
    {




        public DbSet<Account> Accounts { get; set; }


        public DbSet<Blob> Blobs { get; set; }


        public DbSet<Cloudsync_File> Cloudsync_Files { get; set; }


        public DbSet<Device> Devices { get; set; }


        public DbSet<Directory> Directories { get; set; }


        public DbSet<External_Metadata_Item> External_Metadata_Items { get; set; }


        public DbSet<External_Metadata_Source> External_Metadata_Sources { get; set; }


        //public DbSet<Fts4_Metadata_Title>Fts4_Metadata_Titles{get;set;}


        public DbSet<Fts4_Metadata_Titles_Docsize> Fts4_Metadata_Titles_Docsizes { get; set; }


        public DbSet<Fts4_Metadata_Titles_Segdir> Fts4_Metadata_Titles_Segdirs { get; set; }


        public DbSet<Fts4_Metadata_Titles_Segment> Fts4_Metadata_Titles_Segments { get; set; }


        public DbSet<Fts4_Metadata_Titles_Stat> Fts4_Metadata_Titles_Stats { get; set; }


        //public DbSet<Fts4_Tag_Title>Fts4_Tag_Titles{get;set;}


        public DbSet<Fts4_Tag_Titles_Docsize> Fts4_Tag_Titles_Docsizes { get; set; }


        public DbSet<Fts4_Tag_Titles_Segdir> Fts4_Tag_Titles_Segdirs { get; set; }


        public DbSet<Fts4_Tag_Titles_Segment> Fts4_Tag_Titles_Segments { get; set; }


        public DbSet<Fts4_Tag_Titles_Stat> Fts4_Tag_Titles_Stats { get; set; }


        public DbSet<Library_Section_Permission> Library_Section_Permissions { get; set; }


        public DbSet<Library_Section> Library_Sections { get; set; }


        public DbSet<Library_Timeline_Entry> Library_Timeline_Entries { get; set; }


        public DbSet<Locatable> Locatables { get; set; }


        public DbSet<Location_Place> Location_Places { get; set; }


        public DbSet<Location> Locations { get; set; }


        public DbSet<Locations_Node> Locations_Nodes { get; set; }


        public DbSet<Locations_Parent> Locations_Parents { get; set; }


        public DbSet<Locations_Rowid> Locations_Rowids { get; set; }


        public DbSet<Media_Grab> Media_Grabs { get; set; }


        public DbSet<Media_Item_Setting> Media_Item_Settings { get; set; }


        public DbSet<Media_Item> Media_Items { get; set; }


        public DbSet<Media_Metadata_Mapping> Media_Metadata_Mappings { get; set; }


        public DbSet<Media_Part_Setting> Media_Part_Settings { get; set; }


        public DbSet<Media_Part> Media_Parts { get; set; }


        public DbSet<Media_Provider_Resource> Media_Provider_Resources { get; set; }


        public DbSet<Media_Stream> Media_Streams { get; set; }


        public DbSet<Media_Subscription> Media_Subscriptions { get; set; }


        public DbSet<Metadata_Item_Account> Metadata_Item_Accounts { get; set; }


        public DbSet<Metadata_Item_Clustering> Metadata_Item_Clusterings { get; set; }


        public DbSet<Metadata_Item_Cluster> Metadata_Item_Clusters { get; set; }


        public DbSet<Metadata_Item_Setting> Metadata_Item_Settings { get; set; }


        public DbSet<Metadata_Item_View> Metadata_Item_Views { get; set; }


        public DbSet<Metadata_Item> Metadata_Items { get; set; }


        public DbSet<Metadata_Relation> Metadata_Relations { get; set; }


        public DbSet<Play_Queue_Generator> Play_Queue_Generators { get; set; }


        public DbSet<Play_Queue_Item> Play_Queue_Items { get; set; }


        public DbSet<Play_Queue> Play_Queues { get; set; }


        public DbSet<Plugin_Permission> Plugin_Permissions { get; set; }


        public DbSet<Plugin_Prefix> Plugin_Prefixes { get; set; }


        public DbSet<Plugin> Plugins { get; set; }


        public DbSet<Preference> Preferences { get; set; }


        //public DbSet<Schema_Migration>Schema_Migrations{get;set;}


        public DbSet<Section_Location> Section_Locations { get; set; }


        public DbSet<Spellfix_Metadata_Titles_Vocab> Spellfix_Metadata_Titles_Vocabs { get; set; }


        public DbSet<Spellfix_Tag_Titles_Vocab> Spellfix_Tag_Titles_Vocabs { get; set; }


        //public DbSet<Sqlite_Sequence>Sqlite_Sequences{get;set;}


        //public DbSet<Sqlite_Stat1>Sqlite_Stat1{get;set;}


        public DbSet<Statistics_Bandwidth> Statistics_Bandwidths { get; set; }


        public DbSet<Statistics_Medium> Statistics_Media { get; set; }


        public DbSet<Stream_Type> Stream_Types { get; set; }


        public DbSet<Sync_Schema_Version> Sync_Schema_Versions { get; set; }


        public DbSet<Synced_Ancestor_Item> Synced_Ancestor_Items { get; set; }


        public DbSet<Synced_Library_Section> Synced_Library_Sections { get; set; }


        public DbSet<Synced_Metadata_Item> Synced_Metadata_Items { get; set; }


        public DbSet<Synced_Play_Queue_Generator> Synced_Play_Queue_Generators { get; set; }


        public DbSet<Synchronization_File> Synchronization_Files { get; set; }


        public DbSet<Tagging> Taggings { get; set; }


        public DbSet<Tag> Tags { get; set; }


        public DbSet<Versioned_Metadata_Item> Versioned_Metadata_Items { get; set; }


        public DbSet<View_Setting> View_Settings { get; set; }


    }
}

