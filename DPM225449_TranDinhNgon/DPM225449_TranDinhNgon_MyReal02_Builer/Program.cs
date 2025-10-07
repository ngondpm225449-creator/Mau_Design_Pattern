using System;

namespace MyRealBuilder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Tạo builder cho máy tính văn phòng
            ComputerBuilder builder = new OfficeComputerBuilder();
            ComputerDirector director = new ComputerDirector(builder);
            director.BuildComputer();
            Computer officePC = builder.GetComputer();
            Console.WriteLine("Office PC:");
            officePC.Show();

            // Tạo builder cho máy tính chơi game
            builder = new GamingComputerBuilder();
            director = new ComputerDirector(builder);
            director.BuildComputer();
            Computer gamingPC = builder.GetComputer();
            Console.WriteLine("\nGaming PC:");
            gamingPC.Show();

            Console.ReadKey();
        }
    }
}
