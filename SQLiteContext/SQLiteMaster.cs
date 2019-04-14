//using System.ComponentModel.DataAnnotations;
//using System.Data.Linq.Mapping;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SQLiteContext
{
    //  CREATE TABLE sqlite_master(
    //  type TEXT,
    //  name TEXT,
    //  tbl_name TEXT,
    //  rootpage INTEGER,
    //  sql TEXT
    //);

    [Table("sqlite_master")]
    public class SQLiteMaster
    {
        [Column("type")]
        public string Type { get; set; }
        [Key]
        [Column("name")]
        public string Name { get; set; }

        [Column("tbl_name")]
        public string TableName { get; set; }

        [Column("rootpage")]
        public int RootPage { get; set; }

        [Column("sql")]
        public string Sql { get; set; }
    }
}
