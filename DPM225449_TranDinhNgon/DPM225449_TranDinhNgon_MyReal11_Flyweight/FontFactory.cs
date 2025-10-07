using System.Collections.Generic;

namespace Flyweight.MyRealWorld
{
    public class FontFactory
    {
        private Dictionary<string, Font> fonts = new();

        public Font GetFont(string family, int size, bool bold, bool italic)
        {
            string key = $"{family}_{size}_{bold}_{italic}";
            if (!fonts.ContainsKey(key))
            {
                Font font = family switch
                {
                    "Arial" => new ArialFont(size, bold, italic),
                    "Times New Roman" => new TimesFont(size, bold, italic),
                    _ => new ArialFont(size, bold, italic)
                };
                fonts[key] = font;
            }
            return fonts[key];
        }
    }
}