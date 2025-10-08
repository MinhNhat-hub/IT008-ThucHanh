using System;

namespace BT03
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Lần lượt nhập ngày tháng năm: ");
            Console.Write("Ngày là:");
            string s1 = Console.ReadLine();
            int Day = int.Parse(s1);
            Console.Write("Tháng là:");
            string s2 = Console.ReadLine();
            int Month = int.Parse(s2);
            Console.Write("Năm là:");
            string s3 = Console.ReadLine();
            int Year = int.Parse(s3);
            if (KiemTraNgayThangNam(Day, Month, Year))
                Console.WriteLine("Ngày tháng năm hợp lệ!");
            else
                Console.WriteLine("Ngày tháng năm không hợp lệ!");
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
    }
}