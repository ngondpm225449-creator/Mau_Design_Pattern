namespace MyRealDecorator
{
    // Decorator: Trang trí cho thông báo
    public abstract class ThongBaoDecorator : ThongBao
    {
        protected ThongBao thongBao;

        public ThongBaoDecorator(ThongBao thongBao)
        {
            this.thongBao = thongBao;
        }

        public override void HienThi()
        {
            thongBao.HienThi();
        }
    }
}