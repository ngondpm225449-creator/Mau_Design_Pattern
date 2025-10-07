using System;

namespace Flyweight.MyRealWorld
{
    public class ArialFont : Font
    {
        public ArialFont(int size, bool bold, bool italic)
        {
            family = "Arial";
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