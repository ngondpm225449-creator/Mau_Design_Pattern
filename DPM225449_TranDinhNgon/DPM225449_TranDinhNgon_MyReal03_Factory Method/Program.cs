using System;

namespace MyRealFactoryMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PhuongTienCreator creator;

            creator = new XeMayCreator();
            PhuongTien xeMay = creator.TaoPhuongTien();
            Console.WriteLine("Đã tạo: " + xeMay.Loai);

            creator = new OtoCreator();
            PhuongTien oto = creator.TaoPhuongTien();
            Console.WriteLine("Đã tạo: " + oto.Loai);

            Console.ReadKey();
        }
    }
}
