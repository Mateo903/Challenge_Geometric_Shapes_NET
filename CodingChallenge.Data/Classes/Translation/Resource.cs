using System;

namespace CodingChallenge.Data.Classes.Translation
{
    public partial class Resource
    {
        public static string GetValue(string key) => ResourceManager.GetString(key) ?? throw new ArgumentException($"The key '{key}' does not exist in the resource file.");

        public static string GetPlural(string key) => GetValue("Plural_" + key);
    }
}
