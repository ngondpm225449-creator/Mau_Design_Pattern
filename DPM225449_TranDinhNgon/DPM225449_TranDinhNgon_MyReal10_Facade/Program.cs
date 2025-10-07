using System;

namespace MyRealFacade
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DangKyHocPhanFacade facade = new DangKyHocPhanFacade();

            SinhVien sv = new SinhVien("Nguyễn Văn A");
            bool duocDangKy = facade.KiemTraDangKy(sv, "Lập trình C#");

            Console.WriteLine("\n" + sv.Ten +
                (duocDangKy ? " được đăng ký học phần." : " không được đăng ký học phần."));

            Console.ReadKey();
        }
    }
}
