using System;

namespace Template.RealWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DataAccessor categories = new Categories();
            categories.Run(5);

            DataAccessor products = new Products();
            products.Run(3);

            Console.ReadKey();
        }
    }
}