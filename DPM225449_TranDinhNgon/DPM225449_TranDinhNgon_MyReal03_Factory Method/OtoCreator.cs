namespace MyRealFactoryMethod
{
    // ConcreteCreator: Tạo ô tô
    public class OtoCreator : PhuongTienCreator
    {
        public override PhuongTien TaoPhuongTien()
        {
            return new Oto();
        }
    }
}