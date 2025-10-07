using System;

namespace MyRealDecorator
{
    // ConcreteDecorator: Thêm hậu tố vào thông báo
    public class HauToDecorator : ThongBaoDecorator
    {
        private readonly string hauTo;

        public HauToDecorator(ThongBao thongBao, string hauTo)
            : base(thongBao)
        {
            this.hauTo = hauTo;
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine(" " + hauTo);
        }
    }
}