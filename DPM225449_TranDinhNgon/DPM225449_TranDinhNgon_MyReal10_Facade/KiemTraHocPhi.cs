using System;

namespace MyRealFacade
{
    public class KiemTraHocPhi
    {
        public bool DaDongHocPhi(SinhVien sv)
        {
            Console.WriteLine("Kiểm tra học phí cho " + sv.Ten);
            return true;
        }
    }
}