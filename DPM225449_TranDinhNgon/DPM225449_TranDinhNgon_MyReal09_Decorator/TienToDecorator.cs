using System;

namespace MyRealDecorator
{
    // ConcreteDecorator: Thêm tiền tố vào thông báo
    public class TienToDecorator : ThongBaoDecorator
    {
        private readonly string tienTo;

        public TienToDecorator(ThongBao thongBao, string tienTo)
            : base(thongBao)
        {
            this.tienTo = tienTo;
        }

        public override void HienThi()
        {
            Console.Write(tienTo + " ");
            base.HienThi();
        }
    }
}