using System;

namespace MyRealSingleton
{
    public class Program
    {
        public static void Main(string[] args)
        {
            KetNoiCSDL ketNoi1 = KetNoiCSDL.Instance;
            KetNoiCSDL ketNoi2 = KetNoiCSDL.Instance;

            if (ketNoi1 == ketNoi2)
            {
                Console.WriteLine("Hai đối tượng là cùng một kết nối duy nhất!");
            }

            ketNoi1.ThucHienTruyVan("SELECT * FROM SinhVien");
            ketNoi2.ThucHienTruyVan("SELECT * FROM Lop");

            Console.ReadKey();
        }
    }
}
