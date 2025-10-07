namespace MyRealFactoryMethod
{
    // ConcreteCreator: Tạo xe máy
    public class XeMayCreator : PhuongTienCreator
    {
        public override PhuongTien TaoPhuongTien()
        {
            return new XeMay();
        }
    }
}