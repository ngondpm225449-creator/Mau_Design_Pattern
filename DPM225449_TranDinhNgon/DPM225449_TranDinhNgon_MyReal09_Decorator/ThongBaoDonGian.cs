using System;

namespace MyRealDecorator
{
    // ConcreteComponent: Thông báo đơn giản
    public class ThongBaoDonGian : ThongBao
    {
        private readonly string noiDung;

        public ThongBaoDonGian(string noiDung)
        {
            this.noiDung = noiDung;
        }

        public override void HienThi()
        {
            Console.WriteLine(noiDung);
        }
    }
}