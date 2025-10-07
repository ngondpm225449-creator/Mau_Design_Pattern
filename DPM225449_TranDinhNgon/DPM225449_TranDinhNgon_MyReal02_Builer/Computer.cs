using System;
using System.Collections.Generic;

namespace MyRealBuilder
{
    public class Computer
    {
        private readonly Dictionary<string, string> _parts = new();

        public void AddPart(string key, string value)
        {
            _parts[key] = value;
        }

        public void Show()
        {
            foreach (var part in _parts)
            {
                Console.WriteLine($"{part.Key}: {part.Value}");
            }
        }
    }
}