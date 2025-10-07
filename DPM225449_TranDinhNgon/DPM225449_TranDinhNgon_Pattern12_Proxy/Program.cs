using System;

namespace Proxy.Structural
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Proxy proxy = new Proxy();
            proxy.Request();

            Console.ReadKey();
        }
    }
}
