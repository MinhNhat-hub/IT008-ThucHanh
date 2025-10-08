using System;

namespace BT04
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập tháng: ");
            int Month = int.Parse(Console.ReadLine());
            Console.Write("Nhập năm: ");
            int Year = int.Parse(Console.ReadLine());

            NgayCuaThang(Month, Year);
            Console.ReadKey();
        }
        static bool KiemTraTinhHopLeCuaThang(int Month)
        {
            if (Month > 12 || Month < 1)
                return false;
            return true;
        }
        static void NgayCuaThang(int Month, int Year)
        {
            if (KiemTraTinhHopLeCuaThang(Month) == false)
            {
                Console.WriteLine("Tháng không hợp lệ!");
                return;
            }
            Console.Write("Ngày là: ");
            switch (Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.Write("31");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.Write("30");
                    break;
                case 2:
                    if ((Year % 4 == 0 && Year % 100 != 0) || Year % 400 == 0)
                        Console.Write("29");
                    else
                        Console.Write("28");
                    break;
            }
        }
    }
}