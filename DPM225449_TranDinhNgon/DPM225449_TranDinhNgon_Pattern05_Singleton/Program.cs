using System;

namespace Singleton.Structural
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();

            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instance");
            }

            Console.ReadKey();
        }
    }
}