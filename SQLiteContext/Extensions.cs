using System.Data.Entity.Infrastructure.Pluralization;
using System.Globalization;
using System.Text.RegularExpressions;

namespace SQLiteContext
{
    internal static class Extensions
    {
        public static string Pluralize(this string source)
        {
            if (string.IsNullOrWhiteSpace(source)) return string.Empty;
            source = source.TitleCase();
            var ps = new EnglishPluralizationService();
            var match = new Regex(@"([A-Z]+[^A-Z]*)$").Match(source);
            string ending = match.Groups.Count > 0 ? match.Groups[0].Value : source; 
            string pEnding = ps.Pluralize(ending);
            return source.Substring(0, source.Length - ending.Length) + pEnding;
        }

        public static string Singularize(this string source)
        {
            if (string.IsNullOrWhiteSpace(source)) return string.Empty;
            source = source.TitleCase();
            var ps = new EnglishPluralizationService();
            var match = new Regex(@"([A-Z]+[^A-Z]*)$").Match(source);
            string ending = match.Groups.Count > 0 ? match.Groups[0].Value : source;
            string pEnding = ps.Singularize(ending);
            return source.Substring(0, source.Length - ending.Length) + pEnding;
        }
        public static string TitleCase(this string source)
        {
            return new CultureInfo("en-US", false).TextInfo.ToTitleCase(source);
        }
    }
}
