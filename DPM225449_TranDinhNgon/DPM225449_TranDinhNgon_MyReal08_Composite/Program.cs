using System;

namespace MyRealComposite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ThuMuc goc = new ThuMuc("Gốc");
            goc.Them(new TapTin("BaiTap.docx"));
            goc.Them(new TapTin("HinhAnh.png"));

            ThuMuc duAn = new ThuMuc("DuAn");
            duAn.Them(new TapTin("KeHoach.xlsx"));
            duAn.Them(new TapTin("BaoCao.pdf"));

            goc.Them(duAn);

            TapTin tapTinRieng = new TapTin("Readme.txt");
            goc.Them(tapTinRieng);
            goc.Xoa(tapTinRieng);

            goc.HienThi(1);

            Console.ReadKey();
        }
    }
}
