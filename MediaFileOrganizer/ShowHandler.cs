using PlexDbContext;
using PlexDbContext.TableModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using static PlexDbContext.Enums;

namespace MediaFileOrganizer
{
    public class ShowHandler
    {
        public DatabaseContext db { get; set; }
        public Library_Section librarySection { get; set; }
        public Section_Location sectionLocation { get; set; }
        public PlexDbContext.TableModels.Directory directory { get; set; }
        public Metadata_Item metadataItem { get; set; }
        public Metadata_Item seasonItem { get; set; }
        public Metadata_Item showItem { get; set; }
        public Media_Part mediaPart { get; set; }
        public Media_Item mediaItem { get; set; }


        int? index { get; set; }
        public string title { get { return metadataItem.Title; } }
        public string name { get; set; }
        public string show { get; set; }
        public string seasonNumber { get; set; }
        public string episodeNumber { get; set; }
        private DirectoryInfo root { get; set; }

        public static List<ShowHandler> GetShows(DatabaseContext db)
        {
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
                           select new ShowHandler()
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
            results.ForEach(x => { x.db = db; x.Init(); });
            return results;
        }
        public ShowHandler() { }
        public ShowHandler(DatabaseContext db, Library_Section librarySection, Section_Location sectionLocation, PlexDbContext.TableModels.Directory directory, Metadata_Item metadataItem, Metadata_Item seasonItem, Metadata_Item showItem, Media_Part mediaPart)
        {
            this.db = db;
            this.librarySection = librarySection;
            this.sectionLocation = sectionLocation;
            this.directory = directory;
            this.metadataItem = metadataItem;
            this.mediaPart = mediaPart;

            this.seasonItem = seasonItem;
            this.showItem = showItem;
        }
        public void Init()
        {
            root = new DirectoryInfo(sectionLocation.Root_Path);
            name = santize(title);
            show = santize(showItem.Title);

            seasonNumber = string.Format("{0:00}", seasonItem.Index);
            episodeNumber = string.Format("{0:00}", metadataItem.Index);

            var parts = (from mp in db.Media_Parts
                         join mi in db.Media_Items on mp.Media_Item_Id equals mi.Id
                         where mi.Id == mediaPart.Media_Item_Id
                         orderby mp.File ascending
                         select mp.Id).ToList();
            if (parts.Count > 1)
            {
                index = parts.IndexOf(mediaPart.Id) + 1;
            }
        }

        #region Folder

        public string MetaFolderName { get { return Path.Combine(MetaShowFolderName, metaSeasonFolder); } }

        public string MetaShowFolderName { get { return Path.Combine(root.FullName, metaShowFolder); } }

        public bool UsingMetaFolderName { get { return directory.Path.Equals(MetaFolderName); } }

        private string metaSeasonFolder { get { return $"Season {seasonNumber}"; } }

        private string metaShowFolder { get { return $"{show} ({showItem.Year})"; } }
        #endregion

        #region File
        public bool UsingMetaFileName
        {
            get
            {
                return mediaPart.File.Equals(MetaFileName);
            }
        }

        public string MetaFileName
        {
            get
            {
                string n = (string.IsNullOrWhiteSpace(name)) ? string.Empty : " - " + name;
                string part = string.Empty;
                if (index.HasValue) part = $" - pt{index}";

                return Path.Combine(MetaFolderName, $"{show} ({showItem.Year}) - s{seasonNumber}e{episodeNumber}{n} - {Resolution}{part}{mediaPart.File.Substring(mediaPart.File.LastIndexOf("."))}");
            }
        }
        #endregion
        public string Resolution
        {
            get
            {
                switch ($"{mediaItem.Width}x{mediaItem.Height}")
                {
                    case "720x480":
                        return "480p";
                    case "720x576":
                        return "576p";
                    case "1280x720":
                        return "720p";
                    case "1920x1080":
                        return "1080p";
                    case "3840x2160":
                        return "4K UHD";
                    case "7680x4320":
                        return "8K UHD";
                    case "15360x8640":
                        return "8640p";
                    case "800x600":
                        return "SVGA";
                    case "1024x600":
                        return "WSVGA";
                    case "1024x768":
                        return "XGA";
                    case "1152x864":
                        return "XGA+";
                    //case "1280x720":
                    case "1280x768":
                    case "1280x800":
                        return "WXGA";
                    case "1280x960":
                        return "UVGA";
                    case "1280x1024":
                        return "SXGA";
                    case "1360x768":
                    case "1366x768":
                        return "HD";
                    case "1400x1050":
                        return "SXGA+";
                    case "1440x900":
                        return "WXGA+";
                    case "1600x900":
                        return "HD+";
                    case "1600x1200":
                        return "UXGA";
                    case "1680x1050":
                        return "WSXGA+";
                    //case "1920x1080":
                    //    return "FHD";
                    case "1920x1200":
                        return "WUXGA";
                    case "208x1152":
                        return "QWXGA";
                    case "2560x1440":
                        return "WQHD";
                    case "2560x1600":
                        return "WQXGA";

                    //iPhone
                    case "1136x640":
                    case "568x320":
                    case "320x134":
                    case "720x352":
                        return "iPhone5";
                    case "1334x750":
                    case "667x375":
                        return "iPhone6";
                    //case "1334x750":
                    //    return "iPhone7";
                    default: return "SD";
                }

            }
        }
        private string santize(string input, string replacement = "_")
        {
            string pattern = "[\\~#%*{}/:<>?|\"]";

            Regex regEx = new Regex(pattern);
            return Regex.Replace(regEx.Replace(input, replacement), @"\s+", " ");
        }

        public void UpdateFiles()
        {
            try
            {
                //if (show.Contains("Murder")) Debugger.Break();
                var original = new FileInfo(mediaPart.File);
                var target = new FileInfo(MetaFileName);

                if (original.FullName == target.FullName)
                {
                    Console.WriteLine("No changes.");
                    return;
                }


                if (!UsingMetaFolderName)
                {
                    // Update folder
                    bool working = false;
                    if (original.Directory.FullName != root.FullName &&
                        original.Directory.Parent.FullName != root.FullName)
                    {
                        // We have the source episode path in a show/season folder structure.
                        DirectoryInfo seasonFolder = new DirectoryInfo(Path.Combine(original.Directory.Parent.FullName, metaSeasonFolder));
                        if (original.Directory.FullName != seasonFolder.FullName && !seasonFolder.Exists && original.Directory.Exists)
                        {
                            Console.WriteLine($"\t\tMoving season contents to new folder. [{seasonFolder.FullName}==>{metaSeasonFolder}]");
                            System.IO.Directory.Move(original.Directory.FullName, seasonFolder.FullName);
                        }
                        DirectoryInfo showFolder = new DirectoryInfo(Path.Combine(seasonFolder.Parent.FullName, metaShowFolder));
                        if (seasonFolder.Parent.FullName != showFolder.FullName && !showFolder.Exists && seasonFolder.Parent.Exists)
                        {
                            Console.WriteLine($"\t\tMoving show contents to new folder. [{seasonFolder.Parent.FullName}==>{metaShowFolder}]");
                            System.IO.Directory.Move(seasonFolder.Parent.FullName, showFolder.FullName);
                        }

                        // This means that the folder structure is updated using the meta-data, so we adjust the source file path.
                        seasonFolder = new DirectoryInfo(Path.Combine(showFolder.FullName, metaSeasonFolder));
                        original = new FileInfo(Path.Combine(seasonFolder.FullName, original.Name));
                    }
                    else if (original.Directory.FullName != root.FullName)
                    {
                        // We have the source episode path in a show only folder structure.

                        DirectoryInfo showTarget = new DirectoryInfo(Path.Combine(original.Directory.FullName, metaShowFolder));
                        if (original.Directory.FullName != showTarget.FullName && !showTarget.Exists && original.Directory.Exists)
                        {
                            Console.WriteLine($"\t\tMoving show contents to new folder. [{original.Directory.FullName}==>{metaShowFolder}]");
                            System.IO.Directory.Move(original.Directory.FullName, showTarget.FullName);
                        }
                        DirectoryInfo seasonTarget = new DirectoryInfo(Path.Combine(showTarget.FullName, metaSeasonFolder));
                        if (!seasonTarget.Exists)
                        {
                            Console.WriteLine($"\t\tCreating missing season folder. [{metaSeasonFolder}]");
                            seasonTarget.Create();
                        }

                        // This means that the folder structure is updated using the meta-data, so we adjust the source file path.
                        original = new FileInfo(Path.Combine(showTarget.FullName, original.Name));
                    }
                }

                if (!UsingMetaFileName)
                {
                    if (!target.Exists)
                    {
                        if (!original.Exists) return;

                        if (original.FullName != target.FullName)
                        {
                            Console.WriteLine($"\t\tRenaming file. [{original.FullName}==>{target.FullName}]");
                            File.Move(original.FullName, target.FullName);
                        }
                    }
                    //mediaPart.File = target.FullName;
                    //directory.Path = MetaFolderName;
                    //db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\t\tError: {ex.Message}");
            }
        }
    }
}
