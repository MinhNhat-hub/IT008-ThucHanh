using System;

namespace Bai02
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập số:");
            string s1 = Console.ReadLine();
            int Var = int.Parse(s1);

            Console.WriteLine("Tổng các số nguyên tố nhỏ hơn {0} là: {1}", Var, SumofPrimelessthanVar(Var));
        }

        static int SumofPrimelessthanVar(int Var)
        {
            int Sum = 0;
            for (int i = 2; i < Var; i++)
            {
                bool Check_Prime = true;
                for (int j = 2; j <= (int)Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        Check_Prime = false;
                    }
                }
                if (Check_Prime == true)
                    Sum = Sum + i;
            }
            return Sum;
        }
    }
}