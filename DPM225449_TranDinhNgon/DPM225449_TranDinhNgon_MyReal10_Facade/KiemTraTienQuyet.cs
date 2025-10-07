using System;

namespace MyRealFacade
{
    public class KiemTraTienQuyet
    {
        public bool DatTienQuyet(SinhVien sv, string hocPhan)
        {
            Console.WriteLine("Kiểm tra học phần tiên quyết cho " + sv.Ten + " với " + hocPhan);
            return true;
        }
    }
}