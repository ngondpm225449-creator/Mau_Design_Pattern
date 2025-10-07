namespace MyRealPrototype
{
    // Prototype: Định nghĩa interface nhân bản
    public abstract class TaiLieuPrototype
    {
        public abstract TaiLieuPrototype Clone();
    }

    // ConcretePrototype: Tài liệu cụ thể
    public class TaiLieu : TaiLieuPrototype
    {
        public string TieuDe { get; }
        public string TacGia { get; }

        public TaiLieu(string tieuDe, string tacGia)
        {
            TieuDe = tieuDe;
            TacGia = tacGia;
        }

        public override TaiLieuPrototype Clone()
        {
            // Nhân bản nông (shallow copy)
            return (TaiLieu)this.MemberwiseClone();
        }
    }
}