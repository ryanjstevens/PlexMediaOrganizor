using System;
using System.IO;

namespace SQLiteModelBuilder
{
    class Program
    {
        static string dbFile = "com.plexapp.plugins.library.db";
        static string liveFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"Plex Media Server\Plug-in Support\Databases";
        static string devFolder = new DirectoryInfo($"{AppDomain.CurrentDomain.BaseDirectory}\\..\\..\\..\\Data").FullName;

        static void Main(string[] args)
        {
            var cb = new SQLiteContextBuilder("PlexDbContext", "DatabaseContext", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\PlexDbContext\DatabaseContext.Models.cs"), Path.Combine(liveFolder, dbFile));
            var models = cb.GenerateModels("PlexDbContext.TableModels", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\PlexDbContext\TableModels"));
            cb.GenerateContext(models);

            Console.WriteLine("Completed");
            Console.ReadLine();
        }


    }
}
