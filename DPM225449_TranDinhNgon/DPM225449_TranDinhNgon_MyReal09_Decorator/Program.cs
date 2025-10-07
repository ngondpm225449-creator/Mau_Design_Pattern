using System;

namespace MyRealDecorator
{
    // Component: Định nghĩa interface cho thông báo
    public abstract class ThongBao
    {
        public abstract void HienThi();
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            ThongBao thongBao = new ThongBaoDonGian("Xin chào Decorator!");
            thongBao.HienThi();

            ThongBao thongBaoTienTo = new TienToDecorator(thongBao, "[Tiền Tố]");
            thongBaoTienTo.HienThi();

            ThongBao thongBaoHauTo = new HauToDecorator(thongBaoTienTo, "[Hậu Tố]");
            thongBaoHauTo.HienThi();

            Console.ReadKey();
        }
    }
}
