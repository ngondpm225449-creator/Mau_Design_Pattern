using System;

namespace Flyweight.MyRealWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FontFactory factory = new FontFactory();

            var texts = new[]
            {
                ("Hello, World!", "Arial", 12, false, false),
                ("Flyweight Pattern", "Arial", 12, false, false),
                ("Software Maintenance", "Times New Roman", 14, true, false),
                ("Design Patterns", "Arial", 12, false, false),
                ("C# .NET 9", "Times New Roman", 14, true, false)
            };

            int position = 1;
            foreach (var (text, family, size, bold, italic) in texts)
            {
                Font font = factory.GetFont(family, size, bold, italic);
                font.Display(text, position++);
            }

            Console.ReadKey();
        }
    }
}