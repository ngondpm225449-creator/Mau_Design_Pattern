using System;

namespace MyRealFacade
{
    public class DangKyHocPhanFacade
    {
        private readonly KiemTraHocPhi hocPhi = new KiemTraHocPhi();
        private readonly KiemTraTienQuyet tienQuyet = new KiemTraTienQuyet();
        private readonly KiemTraSoLuong soLuong = new KiemTraSoLuong();

        public bool KiemTraDangKy(SinhVien sv, string hocPhan)
        {
            Console.WriteLine($"{sv.Ten} đăng ký học phần {hocPhan}\n");

            bool duocDangKy = true;

            if (!hocPhi.DaDongHocPhi(sv))
                duocDangKy = false;
            else if (!tienQuyet.DatTienQuyet(sv, hocPhan))
                duocDangKy = false;
            else if (!soLuong.ConChoTrong(hocPhan))
                duocDangKy = false;

            return duocDangKy;
        }
    }
}