using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập ngày: ");
            int Day = int.Parse(Console.ReadLine());
            Console.Write("Nhập tháng: ");
            int Month = int.Parse(Console.ReadLine());
            Console.Write("Nhập năm: ");
            int Year = int.Parse(Console.ReadLine());
            if (KiemTraNgayThangNam(Day, Month, Year) == false)
            {
                Console.WriteLine("Ngày tháng năm không hợp lệ!");
                return;
            }
            Console.Write("Thứ của {0}/{1}/{2} là: ", Day, Month, Year);
            if (TimThu(Day, Month, Year) == 1)
                Console.Write("Chủ nhật");
            else if (TimThu(Day, Month, Year) == 0)
                Console.Write("7");
            else
                Console.Write(TimThu(Day, Month, Year));
        }
        static bool KiemTraNgayThangNam(int Day, int Month, int Year)
        {
            if (Month > 12 || Month < 1 || Day > 31 || Day < 1)
                return false;
            switch (Month)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    {
                        if (Day == 31)
                            return false;
                        break;
                    }
                case 2:
                    {
                        if ((Year % 4 == 0 && Year % 100 != 0) || Year % 400 == 0)
                        {
                            if (Day > 29)
                                return false;
                        }
                        else
                        {
                            if (Day > 28)
                                return false;
                        }
                        break;
                    }
            }
            return true;
        }
        static int TimThu(int Day, int Month, int Year)
        {
            if(Month == 1 || Month == 2)
            {
                Month = Month + 12;
                Year = Year - 1;
            }
            return ((Day + (13 *(Month + 1)) / 5 + Year + Year / 4 - Year / 100 + Year / 400) % 7);
        }
    }
}
