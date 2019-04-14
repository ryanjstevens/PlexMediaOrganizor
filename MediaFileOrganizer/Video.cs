using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PlexDbContext.Enums;

namespace MediaFileOrganizer
{
    public class Video
    {
        #region Collection
        public LibrarySectionType Section { get; set; }
        public string RootPath { get; set; }
        #endregion

        public string Year { get; set; }
        public int? PartialIndex { get; set; }

        public string Title { get; set; }
        public string Name { get; set; }
        public string Resolution { get; set; }

        public string Source_Folder { get; set; }
        public string Destination_Folder { get; set; }
        
        public string Source_File { get; set; }
        public string Destination_File { get; set; }
    }
}
