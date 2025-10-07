using System;

namespace MyRealSingleton
{
    // Singleton: Quản lý kết nối cơ sở dữ liệu duy nhất
    public class KetNoiCSDL
    {
        private static KetNoiCSDL _instance;
        private static readonly object _locker = new();

        // Constructor private để ngăn tạo mới từ bên ngoài
        private KetNoiCSDL()
        {
            Console.WriteLine("Khởi tạo kết nối CSDL...");
        }

        public static KetNoiCSDL Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_locker)
                    {
                        if (_instance == null)
                        {
                            _instance = new KetNoiCSDL();
                        }
                    }
                }
                return _instance;
            }
        }

        public void ThucHienTruyVan(string sql)
        {
            Console.WriteLine($"Thực hiện truy vấn: {sql}");
        }
    }
}