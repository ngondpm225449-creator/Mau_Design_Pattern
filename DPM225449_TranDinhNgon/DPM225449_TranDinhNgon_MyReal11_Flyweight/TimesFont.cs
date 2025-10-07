using System;

namespace Flyweight.MyRealWorld
{
    public class TimesFont : Font
    {
        public TimesFont(int size, bool bold, bool italic)
        {
            family = "Times New Roman";
            this.size = size;
            this.bold = bold;
            this.italic = italic;
        }

        public override void Display(string text, int position)
        {
            Console.WriteLine($"[{position}] {text} - {family}, {size}px, Bold: {bold}, Italic: {italic}");
        }
    }
}