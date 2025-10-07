using System;
using System.Collections.Generic;

namespace MyRealComposite
{
    public class ThuMuc : ThucThe
    {
        private List<ThucThe> danhSach = new List<ThucThe>();

        public ThuMuc(string ten)
            : base(ten)
        {
        }

        public override void Them(ThucThe thucThe)
        {
            danhSach.Add(thucThe);
        }

        public override void Xoa(ThucThe thucThe)
        {
            danhSach.Remove(thucThe);
        }

        public override void HienThi(int cap)
        {
            Console.WriteLine(new string('-', cap) + "+ " + ten);
            foreach (var thucThe in danhSach)
            {
                thucThe.HienThi(cap + 2);
            }
        }
    }
}