using PlexDbContext;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PlexDbContext.Enums;

namespace MediaFileOrganizer
{
    public class Application
    {
        const string MovieScanner = "Plex Movie Scanner";
        const string VideoScanner = "Plex Video Files Scanner";


        public Application(DatabaseContext db) { this.db = db; }

        public DatabaseContext db { get; private set; }

        public List<Video> GetMovies()
        {
            List<Video> movies = new List<Video>();

            var items = (from ls in db.Library_Sections
                         join dir in db.Directories on ls.Id equals dir.Library_Section_Id
                         join mp in db.Media_Parts on dir.Id equals mp.Directory_Id
                         join mi in db.Media_Items on mp.Media_Item_Id equals mi.Id
                         join md in db.Metadata_Items on mi.Metadata_Item_Id equals md.Id
                         join loc in db.Section_Locations on ls.Id equals loc.Library_Section_Id
                         where
                         ls.Section_Type == (long)LibrarySectionType.Video
                         &&
                         mp.File.StartsWith(loc.Root_Path)
                         &&
                         ls.Scanner == MovieScanner
                         select new
                         {
                             librarySection = ls,
                             sectionLocation = loc,
                             directory = dir,
                             metadataItem = md,
                             mediaPart = mp,
                             mediaItem = mi
                         }).ToList();

            items.ForEach(x =>
            {
                int? index = null;
                string partialIndex = string.Empty;

                var parts = (from mp in db.Media_Parts
                             join mi in db.Media_Items on mp.Media_Item_Id equals mi.Id
                             where mi.Id == x.mediaPart.Media_Item_Id
                             && mi.Width == x.mediaItem.Width
                             && mi.Height == x.mediaItem.Height
                             orderby mp.File ascending
                             select mp.Id).ToList();
                if (parts.Count > 1)
                {
                    index = parts.IndexOf(x.mediaPart.Id) + 1;
                    partialIndex = $" - pt{index}";
                }

                FileInfo file = new FileInfo(x.mediaPart.File);
                string year = x.metadataItem.Year?.ToString();
                string ext = x.mediaPart.File.Substring(x.mediaPart.File.LastIndexOf("."));
                string name = x.metadataItem.Title
                                .Sanitize()
                                .Replace($"({year})", "")
                                .Trim();
                string resolution = Utilities.GetResolution(x.mediaItem.Width, x.mediaItem.Height);

                Video movie = new Video
                {
                    Title = x.metadataItem.Title,
                    Name = name,
                    Year = year,
                    PartialIndex = index,
                    Section = (LibrarySectionType)x.librarySection.Section_Type,
                    Resolution = resolution,

                    RootPath = x.sectionLocation.Root_Path,
                    Source_File = file.Name,
                    Source_Folder = file.Directory.Name,

                    Destination_File = $"{name} ({year}) - {resolution}{partialIndex}{ext}",
                    Destination_Folder = $"{name} ({year})",

                };
                movies.Add(movie);
            });

            return movies;
        }
        public List<Video> GetVideos()
        {
            List<Video> movies = new List<Video>();

            var items = (from ls in db.Library_Sections
                         join dir in db.Directories on ls.Id equals dir.Library_Section_Id
                         join mp in db.Media_Parts on dir.Id equals mp.Directory_Id
                         join mi in db.Media_Items on mp.Media_Item_Id equals mi.Id
                         join md in db.Metadata_Items on mi.Metadata_Item_Id equals md.Id
                         join loc in db.Section_Locations on ls.Id equals loc.Library_Section_Id
                         where
                         ls.Section_Type == (long)LibrarySectionType.Video
                         &&
                         mp.File.StartsWith(loc.Root_Path)
                         &&
                         ls.Scanner == VideoScanner
                         select new
                         {
                             librarySection = ls,
                             sectionLocation = loc,
                             directory = dir,
                             metadataItem = md,
                             mediaPart = mp,
                             mediaItem = mi
                         }).ToList();

            items.ForEach(x =>
            {
                int? index = null;
                string partialIndex = string.Empty;

                var parts = (from mp in db.Media_Parts
                             join mi in db.Media_Items on mp.Media_Item_Id equals mi.Id
                             where mi.Id == x.mediaPart.Media_Item_Id
                             && mi.Width == x.mediaItem.Width
                             && mi.Height == x.mediaItem.Height
                             orderby mp.File ascending
                             select mp.Id).ToList();
                if (parts.Count > 1)
                {
                    index = parts.IndexOf(x.mediaPart.Id) + 1;
                    partialIndex = $" - pt{index}";
                }

                FileInfo file = new FileInfo(x.mediaPart.File);
                string year = x.metadataItem.Year?.ToString();
                string ext = x.mediaPart.File.Substring(x.mediaPart.File.LastIndexOf("."));
                string name = x.metadataItem.Title
                                .Sanitize()
                                .Replace($"({year})", "")
                                .Trim();
                string resolution = Utilities.GetResolution(x.mediaItem.Width, x.mediaItem.Height);

                Video movie = new Video
                {
                    Title = x.metadataItem.Title,
                    Name = name,
                    Year = year,
                    PartialIndex = index,
                    Section = (LibrarySectionType)x.librarySection.Section_Type,
                    Resolution = resolution,

                    RootPath = x.sectionLocation.Root_Path,
                    Source_File = file.Name,
                    Source_Folder = file.Directory.Name,

                    Destination_File = $"{name} ({year}) - {resolution}{partialIndex}{ext}",
                    Destination_Folder = $"{name} ({year})",

                };
                movies.Add(movie);
            });

            return movies;
        }

        public List<SeryEpisode> GetSeryEpisodes()
        {
            List<SeryEpisode> episodes = new List<SeryEpisode>();
            var results = (from ls in db.Library_Sections
                           join dir in db.Directories on ls.Id equals dir.Library_Section_Id
                           join mp in db.Media_Parts on dir.Id equals mp.Directory_Id
                           join mi in db.Media_Items on mp.Media_Item_Id equals mi.Id
                           join md in db.Metadata_Items on mi.Metadata_Item_Id equals md.Id
                           join smd in db.Metadata_Items on md.Parent_Id equals smd.Id
                           join shmd in db.Metadata_Items on smd.Parent_Id equals shmd.Id
                           join loc in db.Section_Locations on ls.Id equals loc.Library_Section_Id
                           where
                           ls.Section_Type == (long)LibrarySectionType.TvShow
                           &&
                           mp.File.StartsWith(loc.Root_Path)
                           select new
                           {
                               librarySection = ls,
                               sectionLocation = loc,
                               directory = dir,
                               metadataItem = md,
                               seasonItem = smd,
                               showItem = shmd,
                               mediaPart = mp,
                               mediaItem = mi
                           }).ToList();
            results.ForEach(x =>
            {
                int? index = null;
                string partialIndex = string.Empty;

                FileInfo file = new FileInfo(x.mediaPart.File);
                string year = x.showItem.Year?.ToString();
                string ext = x.mediaPart.File.Substring(x.mediaPart.File.LastIndexOf("."));
                string episodeName = x.metadataItem.Title
                                .Sanitize()
                                .Replace($"({year})", "")
                                .Trim();
                string showName = x.showItem.Title
                                .Sanitize()
                                .Replace($"({year})", "")
                                .Trim();
                string resolution = Utilities.GetResolution(x.mediaItem.Width, x.mediaItem.Height);

                string seasonNumber = string.Format("{0:00}", x.seasonItem.Index);
                string episodeNumber = string.Format("{0:00}", x.metadataItem.Index);

                var parts = (from mp in db.Media_Parts
                             join mi in db.Media_Items on mp.Media_Item_Id equals mi.Id
                             where mi.Id == x.mediaPart.Media_Item_Id
                             orderby mp.File ascending
                             select mp.Id).ToList();
                if (parts.Count > 1)
                {
                    index = parts.IndexOf(x.mediaPart.Id) + 1;
                }

                SeryEpisode episode = new SeryEpisode
                {
                    Episode_Title = x.metadataItem.Title,
                    Episode_Name = episodeName,
                    Year = year,
                    PartialIndex = index,
                    Section = (LibrarySectionType)x.librarySection.Section_Type,
                    Resolution = resolution,

                    RootPath = x.sectionLocation.Root_Path,

                    Episode_Number = episodeNumber,
                    Episode_Source_File = file.Name,
                    Episode_Destination_File = $"{showName} ({year}) - s{seasonNumber}e{episodeNumber} - {episodeName} - {resolution}{partialIndex}{ext}",

                    Season_Number = seasonNumber,
                    Season_Source_Folder = file.Directory.Name,
                    Season_Destination_Folder = $"Season {seasonNumber}",

                    Sery_Source_Folder = file.Directory.Parent.FullName != x.sectionLocation.Root_Path ? file.Directory.Parent.Name : "",
                    Sery_Destination_Folder = $"{showName} ({year})",
                    Sery_Name = showName,
                    Sery_Title = x.showItem.Title,
                };

                episodes.Add(episode);
            });



            return episodes;
        }

        public void Process(List<Video> movies, string lib="Movie")
        {
            Console.WriteLine($"Updating {lib} file names.");

            foreach (var item in movies)
            {
                Console.WriteLine($"{lib}:\t{item.Destination_File}");

                // Renaming Sery content folder.

                DirectoryInfo s = new DirectoryInfo(Path.Combine(item.RootPath, item.Source_Folder));
                DirectoryInfo d = new DirectoryInfo(Path.Combine(item.RootPath, item.Destination_Folder));

                if (s.Exists && s.FullName != d.FullName)
                {
                    try
                    {
                        Console.WriteLine($"\t\tMoving movie contents to new folder. [{item.Source_Folder}==>{item.Destination_Folder}]");
                        Directory.Move(s.FullName, d.FullName);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"\n\t\tError: {ex.Message}");
                    }
                }

                FileInfo srcFile = new FileInfo(Path.Combine(s.FullName, item.Source_File));
                FileInfo dscFile = new FileInfo(Path.Combine(s.FullName, item.Destination_File));

                if (srcFile.Exists && srcFile.FullName != dscFile.FullName)
                {
                    try
                    {
                        Console.WriteLine($"\t\tRenaming episode file. [{item.Source_File}==>{item.Destination_File}]");
                        File.Move(srcFile.FullName, dscFile.FullName);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"\n\t\tError: {ex.Message}");
                    }
                }
            }
        }
        public void Process(List<SeryEpisode> episodes)
        {
            Console.WriteLine("Updating TV Show file names.");
            episodes
                .Select(x => x.RootPath)
                .Distinct()
                .OrderBy(x => x)
                .ToList()
                .ForEach(root =>
                {
                    DirectoryInfo r = new DirectoryInfo(root);
                    Console.WriteLine($"{root}");
                    episodes
                        .Where(x => x.RootPath == root)
                        .Select(x => x.Sery_Destination_Folder)
                        .Distinct()
                        .OrderBy(x => x)
                        .ToList()
                        .ForEach(sery =>
                        {
                            Console.WriteLine($"\n...{sery}");

                            episodes
                               .Where(x => x.RootPath == root && x.Sery_Destination_Folder == sery)
                               .Select(x => x.Sery_Source_Folder)
                               .Distinct()
                               .ToList()
                               .ForEach(src =>
                               {
                                   // Renaming Sery content folder.
                                   DirectoryInfo s = new DirectoryInfo(Path.Combine(root, src));
                                   DirectoryInfo d = new DirectoryInfo(Path.Combine(root, sery));

                                   if (s.Exists && s.FullName != d.FullName)
                                   {
                                       try
                                       {
                                           Console.WriteLine($"\t\tMoving sery contents to new folder. [{src}==>{sery}]");
                                           Directory.Move(s.FullName, d.FullName);
                                       }
                                       catch (Exception ex)
                                       {
                                           Console.WriteLine($"\n\t\tError: {ex.Message}");
                                       }
                                   }

                               });

                            episodes
                                .Where(x => x.RootPath == root && x.Sery_Destination_Folder == sery)
                                .Select(x => x.Season_Destination_Folder)
                                .Distinct()
                                .OrderBy(x => x)
                                .ToList()
                                .ForEach(season =>
                                {
                                    Console.WriteLine($"......{season}");

                                    episodes
                                       .Where(x => x.RootPath == root && x.Sery_Destination_Folder == sery && x.Season_Destination_Folder == season)
                                       .Select(x => x.Season_Source_Folder)
                                       .Distinct()
                                       .ToList()
                                       .ForEach(src =>
                                       {
                                           // Renaming Season content folder.
                                           DirectoryInfo s = new DirectoryInfo(Path.Combine(Path.Combine(root, sery), src));
                                           DirectoryInfo d = new DirectoryInfo(Path.Combine(Path.Combine(root, sery), season));

                                           if (s.Exists && s.FullName != d.FullName)
                                           {
                                               try
                                               {
                                                   Console.WriteLine($"\t\tMoving season contents to new folder. [{src}==>{season}]");
                                                   Directory.Move(s.FullName, d.FullName);
                                               }
                                               catch (Exception ex)
                                               {
                                                   Console.WriteLine($"\n\t\tError: {ex.Message}");
                                               }
                                           }
                                           if (!d.Exists)
                                           {
                                               try
                                               {
                                                   Console.WriteLine($"\t\tCreating missing season folder. [{season}]");
                                                   d.Create();
                                               }
                                               catch (Exception ex)
                                               {
                                                   Console.WriteLine($"\n\t\tError: {ex.Message}");
                                               }
                                           }
                                       });

                                    episodes
                                        .Where(x => x.RootPath == root && x.Sery_Destination_Folder == sery && x.Season_Destination_Folder == season)
                                        .OrderBy(x => x.Episode_Number)
                                        .ThenBy(x => x.PartialIndex)
                                        .ToList()
                                        .ForEach(episode =>
                                        {
                                            Console.WriteLine($".........Desc:\t{episode.Episode_Destination_File}");

                                            // Renaming Episodes.
                                            DirectoryInfo s = new DirectoryInfo(Path.Combine(Path.Combine(root, sery), season));
                                            DirectoryInfo d = new DirectoryInfo(Path.Combine(Path.Combine(root, sery), season));

                                            FileInfo srcFile = new FileInfo(Path.Combine(s.FullName, episode.Episode_Source_File));
                                            FileInfo dscFile = new FileInfo(Path.Combine(s.FullName, episode.Episode_Destination_File));

                                            if (srcFile.Exists && srcFile.FullName != dscFile.FullName)
                                            {
                                                try
                                                {
                                                    Console.WriteLine($"\t\tRenaming episode file. [{episode.Episode_Source_File}==>{episode.Episode_Destination_File}]");
                                                    File.Move(srcFile.FullName, dscFile.FullName);
                                                }
                                                catch (Exception ex)
                                                {
                                                    Console.WriteLine($"\n\t\tError: {ex.Message}");
                                                }
                                            }

                                            s = s.Parent;
                                            srcFile = new FileInfo(Path.Combine(s.FullName, episode.Episode_Source_File));
                                            if (s.FullName != root && srcFile.FullName != dscFile.FullName && srcFile.Exists)
                                            {
                                                try
                                                {
                                                    Console.WriteLine($"\t\tRenaming episode file. [{episode.Episode_Source_File}==>{episode.Episode_Destination_File}]");
                                                    File.Move(srcFile.FullName, dscFile.FullName);
                                                }
                                                catch (Exception ex)
                                                {
                                                    Console.WriteLine($"\n\t\tError: {ex.Message}");
                                                }
                                            }
                                        });
                                });
                        });
                });
        }

    }
}
