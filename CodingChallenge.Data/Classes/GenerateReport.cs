using CodingChallenge.Data.Classes.Shapes;
using CodingChallenge.Data.Classes.Translation;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public class GenerateReport
    {
        public static string Print(List<GeometricShape> shapes, CultureInfo cultureInfo = null)
        {
            var sb = new StringBuilder();

            using (new CultureScope(cultureInfo ?? Languages.Default))
            {
                //HEADER
                if (!shapes.Any()) return sb.Append($"<h1>{Resource.Empty_List}</h1>").ToString();

                sb.Append($"<h1>{Resource.Shapes_Report}</h1>");;

                //BODY
                shapes.GroupBy(s => s.Key).ToList().ForEach(s =>
                {
                    sb.Append($"{s.Count()} {(s.Count() > 1 ? Resource.GetPlural(s.Key) : Resource.GetValue(s.Key))} | ");
                    sb.Append($"{Resource.Area} {s.Sum(x => x.Area):#.##} | ");
                    sb.Append($"{Resource.Perimeter} {s.Sum(x => x.Perimeter):#.##} <br/>");
                });

                //FOOTER
                sb.Append($"{Resource.Total}:<br/>{shapes.Count} {(shapes.Count > 1 ? Resource.Plural_Shape : Resource.Shape)} | ");
                sb.Append($"{Resource.Perimeter} {shapes.Sum(s => s.Perimeter):#.##} | ");
                sb.Append($"{Resource.Area} {shapes.Sum(s => s.Area):#.##}");
            }

            return sb.ToString();
        }
    }
}
