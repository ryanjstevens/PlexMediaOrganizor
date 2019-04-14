using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MediaFileOrganizer
{
    public static class Utilities
    {
        public static string Sanitize(this string source, string replacement = "_") {
            string pattern = "[\\~#%*{}/:<>?|\"]";

            Regex regEx = new Regex(pattern);
            return Regex.Replace(regEx.Replace(source, replacement), @"\s+", " ");
        }

        public static string GetResolution(long? width, long? height)
        {
            switch ($"{width}x{height}")
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
}
