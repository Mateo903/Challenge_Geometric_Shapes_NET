using System.Globalization;

namespace CodingChallenge.Data.Classes.Translation
{
    public struct Languages
    {
        public static readonly CultureInfo Spanish = new CultureInfo("es");
        public static readonly CultureInfo English = new CultureInfo("en");
        public static readonly CultureInfo French = new CultureInfo("fr");
        public static readonly CultureInfo German = new CultureInfo("de");
        public static readonly CultureInfo Default = new CultureInfo("en");
    }
}
