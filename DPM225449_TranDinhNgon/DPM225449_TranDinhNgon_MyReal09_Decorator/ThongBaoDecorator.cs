namespace MyRealDecorator
{
    // Decorator: Trang tr� cho th�ng b�o
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