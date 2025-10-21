using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    class cLichThang
    {
        private int Nam;
        private int Thang;

        public void NhapThangNam()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập tháng: ");
            Thang = int.Parse(Console.ReadLine());
            Console.Write("Nhập năm: ");
            Nam = int.Parse(Console.ReadLine());
        }

        protected int NgayCuaThang(int Thang, int Nam)
        {
            int[] NgayCuaTungThang = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (Thang == 2 && ((Nam % 4 == 0 && Nam % 100 != 0) || Nam % 400 == 0))
                return NgayCuaTungThang[Thang - 1] + 1;
            return NgayCuaTungThang[Thang - 1];
        }

        protected bool KiemTraTinhHopLeCuaThangNam()
        {
            if (Thang < 1 || Thang > 12 || Nam < 1 || Nam > 9999)
                return false;
            return true;
        }

        protected string ThuCuaNgay(int Ngay)
        {
            if (Thang == 1 || Thang == 2)
            {
                Thang = Thang + 12;
                Nam = Nam - 1;
            }
            int Thu = ((Ngay + (13 * (Thang + 1)) / 5 + Nam + Nam / 4 - Nam / 100 + Nam / 400) % 7);
            switch (Thu)
            {
                case 1:
                    return "Sun";
                case 2:
                    return "Mon";
                case 3:
                    return "Tue";
                case 4:
                    return "Wed";
                case 5:
                    return "Thu";
                case 6:
                    return "Fri";
                default:
                    break;
            }
            return "Sat";
        }

        public void XuatManHinhLichThang()
        {
            if (KiemTraTinhHopLeCuaThangNam() == false)
            {
                Console.WriteLine("Tháng năm nhập không hợp lệ!");
                return;
            }
            int Ngay = NgayCuaThang(Thang, Nam);
            int NgayBatDau = 1;
            string ThuBatDau = ThuCuaNgay(NgayBatDau);
            string[] ThuTrongTuan = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            const int Cot = 7;

            foreach (var t in ThuTrongTuan)
                Console.Write($"{t,4}");
            Console.WriteLine();

            while (NgayBatDau <= Ngay)
            {
                for (int i = 0; i < Cot; i++)
                {
                    if (ThuBatDau != ThuTrongTuan[i] && NgayBatDau == 1)
                    {
                        Console.Write("    ");
                    }
                    else if (NgayBatDau <= Ngay)
                    {
                        Console.Write($"{NgayBatDau,4}");
                        NgayBatDau++;
                    }
                    else
                    {
                        Console.Write("    ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
