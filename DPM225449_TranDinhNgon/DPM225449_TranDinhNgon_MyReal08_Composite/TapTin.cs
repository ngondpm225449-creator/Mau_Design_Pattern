using System;

namespace MyRealComposite
{
    public class TapTin : ThucThe
    {
        public TapTin(string ten)
            : base(ten)
        {
        }

        public override void Them(ThucThe thucThe)
        {
            Console.WriteLine("Không thể thêm vào tập tin!");
        }

        public override void Xoa(ThucThe thucThe)
        {
            Console.WriteLine("Không thể xóa khỏi tập tin!");
        }

        public override void HienThi(int cap)
        {
            Console.WriteLine(new string('-', cap) + " " + ten);
        }
    }
}