using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PlexDbContext.Enums;

namespace MediaFileOrganizer
{
    public class SeryEpisode
    {
        #region Collection
        public LibrarySectionType Section { get; set; }
        public string RootPath { get; set; }
        #endregion

        #region Sery
        public string Sery_Title { get; set; }
        public string Sery_Name { get; set; }
        public string Year { get; set; }

        public string Sery_Source_Folder{ get; set; }
        public string Sery_Destination_Folder { get; set; }
        #endregion

        #region Season
        public string Season_Number { get; set; }
        public string Season_Source_Folder { get; set; }
        public string Season_Destination_Folder { get; set; }
        #endregion

        #region Episode

        public string Episode_Number { get; set; }
        public int? PartialIndex { get; set; }

        public string Episode_Title { get; set; }
        public string Episode_Name { get; set; }
        public string Resolution { get; set; }
        
        public string Episode_Source_File { get; set; }
        public string Episode_Destination_File { get; set; }

        #endregion
    }
}
