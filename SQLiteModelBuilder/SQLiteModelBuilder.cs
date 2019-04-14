using SQLiteContext;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace SQLiteModelBuilder
{
    public class SQLiteModelBuilder
    {
        string TABLES_QUERY = @"SELECT type, name, tbl_name, rootpage, sql FROM sqlite_master WHERE type = 'table' ORDER BY 1";

        public List<SQLiteSchema> GetTableSchema(string dbConnection, string tableName)
        {
            try
            {
                List<SQLiteSchema> fields = new List<SQLiteSchema>();
                string sql = $"SELECT * FROM {tableName} LIMIT 1";
                DataTable dt = new DataTable();
                using (var c = new SQLiteConnection(dbConnection))
                {
                    c.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                    {
                        using (SQLiteDataReader rdr = cmd.ExecuteReader())
                        {
                            dt = rdr.GetSchemaTable();
                            foreach (DataRow row in dt.Rows)
                            {
                                SQLiteSchema schema = new SQLiteSchema();
                                fields.Add(schema);
                                foreach (DataColumn col in dt.Columns)
                                {
                                    try
                                    {
                                        object val = row[col];
                                        if (val != DBNull.Value)
                                            schema.GetType().GetProperty(col.ColumnName).SetValue(schema, val);
                                    }
                                    catch (Exception ee)
                                    {
                                        Console.WriteLine($"{ee.Message}[{tableName}:{col.ColumnName}]");
                                    }
                                }
                            }
                        }
                    }
                    c.Close();
                }
                return fields;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public string GenerateTableModel(string dbConnection, string tableName, string destinationFolder, string _namespace)
        {
            Console.WriteLine($"Processing table: [{tableName}]");
            List<SQLiteSchema> tableSchema = GetTableSchema(dbConnection, tableName);
            if (tableSchema == null) return null;

            string usingStatement =
                    @"using System;
                    using System.ComponentModel.DataAnnotations;
                    using System.ComponentModel.DataAnnotations.Schema;
                    
                    ";

            StringBuilder sb = new StringBuilder();


            string tName = tableName.Replace(" ", String.Empty).Singularize();


            bool compositeKey = tableSchema.Where(w => w.IsKey).Count() > 1;
            int ckIndex = 0;
            foreach (var field in tableSchema)
            {
                // Annotations
                if (field.IsKey) sb.AppendLine($"\t\t[Key]");
                //if (field.IsAutoIncrement) sb.AppendLine($"\t\t[DatabaseGenerated(DatabaseGeneratedOption.Identity)]");
                //if (field.IsUnique) sb.AppendLine($"\t\t[DatabaseGenerated(DatabaseGeneratedOption.Computed)]");
                if (field.DataType == typeof(string) && field.ColumnSize > 0) sb.AppendLine($"\t\t[MaxLength({field.ColumnSize})]");

                if (field.IsKey && compositeKey)
                    sb.AppendLine($"\t\t[Column(\"{field.ColumnName}\", Order={ckIndex++})]");
                else
                    sb.AppendLine($"\t\t[Column(\"{field.ColumnName}\")]");

                // Property
                string fName = field.ColumnName.ToLower().TitleCase().Replace(" ", String.Empty);
                string fType = _propTypeString(field.DataType, field.AllowDBNull);
                //if (fName == "Size") Debugger.Break();
                sb.AppendLine($"\t\tpublic {fType} {fName}{{get;set;}}\n");
            }

            // Reset file
            string path = $"{ destinationFolder}\\{tName}.cs";
            if (File.Exists(path)) File.Delete(path);
            var folder = new FileInfo(path).Directory;
            if (!folder.Exists) folder.Create();
            File.AppendAllText(path, usingStatement);
            File.AppendAllText(path, $"namespace {_namespace}\n{{\n\n");
            File.AppendAllText(path, $"\t[Table(\"{tableName}\")]\n");
            File.AppendAllText(path, $"\tpublic class {tName}" + "\n{\n");

            // Write properties
            File.AppendAllText(path, sb.ToString());

            // End class
            File.AppendAllText(path, "\t\t}\n\t}\n");

            return tName;
        }

        private string _propTypeString(Type type, bool AllowDBNull)
        {
            if (type.BaseType == typeof(Array))
            {
                Debug.WriteLine(type.FullName, "Processing Array");
                var arrayType = Type.GetType(type.FullName.Substring(0, type.FullName.IndexOf("[")));
                return _propTypeString(arrayType, arrayType.Name.Contains("?") || arrayType.Name.Contains("Nullable")) + "[]";
            }

            // Set type name for primitives
            string typeName = type.ToString();
            if (type == typeof(int)) typeName = "int";
            else if (type == typeof(long)) typeName = "long";
            else if (type == typeof(bool)) typeName = "bool";
            else if (type == typeof(double)) typeName = "double";
            else if (type == typeof(string)) typeName = "string";
            else if (type == typeof(byte)) typeName = "byte";
            else if (type == typeof(System.Byte)) typeName = "byte";
            else if (type == typeof(System.DateTime)) typeName = "DateTime";

            // Determine if the type is a nullable primitive
            bool nullableType =
                type == typeof(int) ||
                type == typeof(long) ||
                type == typeof(bool) ||
                type == typeof(double) ||
                type == typeof(byte) ||
                type == typeof(System.Byte) ||
                type == typeof(DateTime);
            string nullable = AllowDBNull && nullableType ? "?" : "";

            // Composite type string
            return $"{typeName}{nullable}";
        }


    }
}
