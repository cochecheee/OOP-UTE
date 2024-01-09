using System;

namespace EnumTest
{
    enum LuongNhanVien
    {
        NV1 = 100,
        NV2 = 150,
        NV3 = 200
    };
    class Program
    {
        public static void ThuongNhanVien(LuongNhanVien lnv)
        {
            switch(lnv)
            {
                case LuongNhanVien.NV1:
                    Console.WriteLine("thuong cho nv 1 ...");
                    break;
                case LuongNhanVien.NV2:
                    Console.WriteLine("thuong cho nv 2 ...");
                    break;
                case LuongNhanVien.NV3:
                    Console.WriteLine("thuong cho nv 3 ...");
                    break;
                default: 
                    break;
            }
        }

        static void Main()
        {
            int x = (int)LuongNhanVien.NV1;

            LuongNhanVien cal;
            cal = LuongNhanVien.NV2;
            ThuongNhanVien(cal);

            Console.WriteLine("Hello C#\n");
            Console.WriteLine("luong nhan vien 1 la: {0}\n, luong nhan vien 2 la: {1}\n", x, cal);
        }

    }
}