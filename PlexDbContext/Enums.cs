using System;
using System.Collections.Generic;
using System.Text;

namespace PlexDbContext
{
    static public class Enums
    {
        public enum LibrarySectionType
        {
            Video = 1,
            TvShow = 2,
            Music = 8,
            Photos = 13
        }

        public enum MetaDataItemType
        {
            Movie = 12,
            Show = 2,
            Season = 3,
            Episode = 4
        }
    }
}
