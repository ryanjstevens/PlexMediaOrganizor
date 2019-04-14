using PlexDbContext;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MediaFileOrganizer
{
    class Program
    {
        const string MovieSwitch = "-m";
        const string VideoSwitch = "-v";
        const string ShowSwitch = "-tv";
        const string UsageSwitch = "/?";

        const string DefaultDb = "%userprofile%\\AppData\\Local\\Plex Media Server\\Plug-in Support\\Databases\\com.plexapp.plugins.library.db";

        readonly string[] switches = new string[] { MovieSwitch, VideoSwitch, ShowSwitch };

        static void Main(string[] args)
        {
            try
            {
                if (args.Contains(UsageSwitch))
                {
                    ShowUsage();
                    return;
                }
                if (args == null) args = new string[0];
                string file = args.Length > 0 && !args[0].StartsWith("-") ? args[0] : DefaultDb.Replace("%userprofile%\\AppData\\Local", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
                bool updateMovies = Enable(args, MovieSwitch);
                bool updateShows = Enable(args, ShowSwitch);
                bool updateVideos = Enable(args, VideoSwitch);



                if (file == null || !new FileInfo(file).Exists)
                {
                    Console.WriteLine("No Plex db provided...");
                    Console.WriteLine("Cancelling updates.");

                    ShowUsage();
                    return;
                }

                Application app = new Application(new DatabaseContext(file));

                if (updateMovies)
                    app.Process(app.GetMovies(), "Movie");
                if (updateShows)
                    app.Process(app.GetSeryEpisodes());
                if (updateVideos)
                    app.Process(app.GetVideos(), "Video");
                if (!updateMovies && !updateShows && !updateVideos)
                {
                    Console.WriteLine("No collection updated.");
                    ShowUsage();
                    return;
                }

                Console.WriteLine("Completed");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        static void ShowUsage()
        {
            Console.WriteLine("Usage:");
            Console.WriteLine("\t\"{database file path}\" -m -tv");
            Console.WriteLine("\t-m : Optional switch to enable Movie collection update.");
            Console.WriteLine("\t-tv : Optional switch to enable Tv Show collection update.");
            Console.WriteLine("\t-v : Optional switch to enable Video collection update.");
            Console.WriteLine($"\nPlex db location: \n\t{DefaultDb}");
            Console.ReadLine();
        }

        static bool Enable(string[] args, string sw)
        {
            return args.Contains(sw) || (!args.Any(x => x == MovieSwitch) && !args.Any(x => x == ShowSwitch) && !args.Any(x => x == VideoSwitch));
        }
    }
}
