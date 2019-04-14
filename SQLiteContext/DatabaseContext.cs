using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;

namespace SQLiteContext
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext(string dbFilename) : base(new SQLiteConnection()
        {
            ConnectionString = new SQLiteConnectionStringBuilder()
            {
                DataSource = dbFilename,
                ForeignKeys = true
            }.ConnectionString
        }, true)
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<SQLiteMaster> Master { get; set; }

        public DbSet GetSet(string name)
        {
            var type = Assembly.GetExecutingAssembly()
                        .GetTypes()
                        .FirstOrDefault(t => t.Name == name.Singularize());

            return (type != null) ? Set(type) : null;
        }
    }
}
