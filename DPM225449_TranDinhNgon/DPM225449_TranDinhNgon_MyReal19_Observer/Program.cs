using System;


namespace MyReal19Observer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Stock vnm = new VNM("VNM", 70000.0);
            vnm.Attach(new Investor("Nguyen Van A"));
            vnm.Attach(new Investor("Tran Thi B"));

            vnm.Price = 70500.0;
            vnm.Price = 71000.0;
            vnm.Price = 70800.0;
            vnm.Price = 71200.0;

            Console.ReadKey();
        }
    }
}
