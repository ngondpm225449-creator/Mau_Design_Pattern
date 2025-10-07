using System;

namespace Adapter.Structural
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Target target = new Adapter();
            target.Request();

            Console.ReadKey();
        }
    }
}