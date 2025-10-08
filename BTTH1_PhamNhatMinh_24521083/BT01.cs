using System;

namespace Bai01
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập số lượng phần tử trong mảng: ");
            string s1 = Console.ReadLine();
            int n = int.Parse(s1);

            int[] arr = new int[n];
            Console.WriteLine("Nhập mảng:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Tổng các số lẻ trong mảng là : {0}", TongSoLe(arr));
            Console.WriteLine("Số lượng các số nguyên tố trong mảng là: {0}", DemSoNguyenToTrongMang(arr));
            Console.WriteLine("Số chính phương nhỏ nhất trong mảng là (nếu không có thì giá trị là -1) là: {0}", TimSoChinhPhuongNhoNhat(arr));
        }
        static int TongSoLe(int[] arr)
        {
            int Sum = 0;
            foreach (int x in arr)
            {
                if (x % 2 != 0)
                {
                    Sum = Sum + x;
                }
            }
            return Sum;
        }
        static bool KiemTraSNT(int x)
        {
            if (x < 2) return false;
            for (int i = 2; i <= x / 2; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static int DemSoNguyenToTrongMang(int[] arr)
        {
            int Count = 0;
            foreach (int x in arr)
            {
                if (KiemTraSNT(x) == true)
                    Count = Count + 1;
            }
            return Count;
        }
        static int TimSoChinhPhuongNhoNhat(int[] arr)
        {
            int Min = -1;
            foreach (int x in arr)
            {
                int TempVar = (int)Math.Sqrt(x);
                if (TempVar * TempVar == x)
                {
                    if (Min == -1)
                    {
                        Min = x;
                    }
                    else
                    {
                        if (Min > x)
                            Min = x;
                    }
                }
            }
            return Min;
        }
    }
}