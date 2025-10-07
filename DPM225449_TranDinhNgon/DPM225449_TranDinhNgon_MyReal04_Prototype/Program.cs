using System;

namespace MyRealPrototype
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TaiLieu taiLieu1 = new TaiLieu("Báo cáo", "Nguyễn Văn A");
            TaiLieu banSao1 = (TaiLieu)taiLieu1.Clone();
            Console.WriteLine($"Đã nhân bản: {banSao1.TieuDe}, tác giả: {banSao1.TacGia}");

            TaiLieu taiLieu2 = new TaiLieu("Đề án", "Trần Thị B");
            TaiLieu banSao2 = (TaiLieu)taiLieu2.Clone();
            Console.WriteLine($"Đã nhân bản: {banSao2.TieuDe}, tác giả: {banSao2.TacGia}");

            Console.ReadKey();
        }
    }
}
