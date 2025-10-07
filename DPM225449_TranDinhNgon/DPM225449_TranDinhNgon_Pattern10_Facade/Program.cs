using System;

namespace Facade.Structural
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Facade facade = new Facade();

            facade.MethodA();
            facade.MethodB();

            Console.ReadKey();
        }
    }
}