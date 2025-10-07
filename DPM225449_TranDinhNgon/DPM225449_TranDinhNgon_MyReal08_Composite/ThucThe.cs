namespace MyRealComposite
{
    public abstract class ThucThe
    {
        protected string ten;

        public ThucThe(string ten)
        {
            this.ten = ten;
        }

        public abstract void Them(ThucThe thucThe);
        public abstract void Xoa(ThucThe thucThe);
        public abstract void HienThi(int cap);
    }
}