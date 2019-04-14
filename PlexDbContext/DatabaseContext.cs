using System;
using System.Collections.Generic;
using System.Text;

namespace PlexDbContext
{
    public partial class DatabaseContext : SQLiteContext.DatabaseContext
    {
        public DatabaseContext(string dbFilename) : base(dbFilename) { }
    }
}
