using SQLiteContext;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Pluralization;
using System.IO;
using System.Linq;
using System.Text;

namespace SQLiteModelBuilder
{
    public class SQLiteContextBuilder
    {
        private string _ns { get; set; }
        private string name { get; set; }
        private string contextFile { get; set; }
        private string dbPath { get; set; }

        public SQLiteContextBuilder(string _namespace, string name, string contextFile, string dbPath)
        {
            this._ns = _namespace;
            this.name = name;
            this.contextFile = contextFile;
            this.dbPath = dbPath;
        }

        public void GenerateContext(List<string> modelNames)
        {
            // dbContext partial


            var folder = new FileInfo(contextFile).Directory;
            if (!folder.Exists) folder.Create();
            if (File.Exists(contextFile)) File.Delete(contextFile);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("using System.Data.Entity;");
            sb.AppendLine($"namespace {_ns}");
            sb.AppendLine("{\n");
            sb.AppendLine($"\tpublic partial class {name} : DbContext");
            sb.AppendLine("{\n\n\n\n");

            foreach (var model in modelNames)
            {
                if (!string.IsNullOrWhiteSpace(model))
                    sb.AppendLine($"\t\tpublic DbSet<{model}>{model.Pluralize()}{{get;set;}}\n\n");
            }

            sb.AppendLine("}\n}\n");
            File.AppendAllText(contextFile, sb.ToString());
        }

        public List<string> GenerateModels(string _namespace, string targetFolder)
        {
            List<string> modelNames = new List<string>();

            var db = new DatabaseContext(dbPath);

            var tables = db.Master.Where(w => w.Type == "table").OrderBy(o => o.Name).ToList();

            // Generate models
            var builder = new SQLiteModelBuilder();
            foreach (var table in tables)
            {
                var tName = builder.GenerateTableModel(db.Database.Connection.ConnectionString, table.Name, targetFolder, _namespace);
                if (!string.IsNullOrWhiteSpace(tName))
                    modelNames.Add(tName);
            }
            return modelNames;
        }
    }
}
