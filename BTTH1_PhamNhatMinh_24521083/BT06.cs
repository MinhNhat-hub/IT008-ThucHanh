    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace BT06
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.Write("Nhập số hàng: ");
                int Hang = int.Parse(Console.ReadLine());
                Console.Write("Nhập số cột: ");
                int Cot = int.Parse(Console.ReadLine());
                if(Hang <= 0 || Cot <= 0)
                {
                    Console.WriteLine("Số hàng hoặc số cột không hợp lệ!");
                    return;
                }
                int[,] matrix = new int[Hang, Cot];
                for (int i = 0; i < Hang; i++)
                {
                    string line = Console.ReadLine();
                    int[] numbers = line.Split(' ')
                                        .Select(int.Parse)
                                        .ToArray();
                    if (numbers.Length != Cot)
                    {
                        Console.WriteLine("Số phần tử không khớp cột, vui lòng nhập lại");
                        i--;
                        continue;
                    }
                    for (int j = 0; j < Cot; j++)
                    {
                        matrix[i, j] = numbers[j];
                    }
                }
                int Base = -1;
                while(Base == -1)
                {
                    Console.WriteLine("1. Xuất ma trận.");
                    Console.WriteLine("2. Tìm phần tử lớn nhất/nhỏ nhất.");
                    Console.WriteLine("3. Tìm dòng có tổng lớn nhất.");
                    Console.WriteLine("4. Tính tổng các số không phải số nguyên tố.");
                    Console.WriteLine("5. Xóa dòng thứ k trong ma trận.");
                    Console.WriteLine("6. Xóa cột chứa phần tử lớn nhất trong ma trận.");
                    Console.WriteLine("7. Thoát.");
                    Console.WriteLine();
                    Console.Write("Nhập vào thứ tự chức năng bạn muốn dùng: ");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    if(x == 1)
                        XuatMaTran(matrix);
                    if(x == 2)
                        TimPhanTuLonNhatVaNhoNhat(matrix);
                    if(x == 3)
                        TimDongCoTongLonNhat(matrix);
                    if(x == 4)
                        TinhTongCacSoKhongPhaiNguyenToTrongMaTran(matrix);
                    if (x == 5)
                    {
                        Console.Write("Nhập k: ");
                        int k = int.Parse(Console.ReadLine());
                        XoaDongThuKTrongMaTran(ref matrix, k - 1);
                        XuatMaTran(matrix);
                    }
                    if (x == 6)
                    {
                        XoaCotChuaPhanTuLonNhatTrongMaTran(ref matrix);
                        XuatMaTran(matrix);
                    }
                    if (x == 7)
                        Base = 0;
                    if(matrix.GetLength(0) <= 0 || matrix.GetLength(1) <= 0)
                    {
                        Console.WriteLine("Ma trận hiện tại rỗng, kết thúc chương trình");
                        Base = 0;
                    }
                    Console.WriteLine();
                }
            }
            static void XuatMaTran(int[,] matrix)
            {
                Console.WriteLine("Ma trận hiện tại là: ");
                int Hang = matrix.GetLength(0);
                int Cot = matrix.GetLength(1);
                for (int i = 0; i < Hang; i++)
                {
                    for (int j = 0; j < Cot; j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            static void TimPhanTuLonNhatVaNhoNhat(int[,] matrix)
            {
                int Hang = matrix.GetLength (0);
                int Cot = matrix.GetLength (1);

                int PhanTuLonNhat = matrix[0, 0];
                for(int i = 0; i < Hang; i++)
                {
                    for (int j = 0; j < Cot; j++)
                    {
                        if(PhanTuLonNhat <  matrix[i, j])
                        {
                            PhanTuLonNhat = matrix [i, j];
                        }
                    }
                }

                int PhanTuNhoNhat = matrix[0, 0];
                for (int i = 0; i < Hang; i++)
                {
                    for (int j = 0; j < Cot; j++)
                    {
                        if (PhanTuNhoNhat > matrix[i, j])
                        {
                            PhanTuNhoNhat = matrix[i, j];
                        }
                    }
                }

                Console.WriteLine("Phần tử lớn nhất trong ma trận là: {0} ", PhanTuLonNhat);
                Console.WriteLine("Phần tử nhỏ nhất trong ma trận là: {0} ", PhanTuNhoNhat);
            }
            static void TimDongCoTongLonNhat(int[,] matrix)
            {
                int Hang = matrix.GetLength (0);
                int Cot = matrix.GetLength (1);
                int TongHangLonNhat = 0;
                int HangCoTongLonNhat = 0;
                for(int i = 0; i < Cot; i++)
                {
                    TongHangLonNhat += matrix [0, i];
                }
                for(int i = 0;i < Hang; i++)
                {
                    int TongHangHienTai = 0;
                    for(int j = 0;j < Cot; j++)
                    {
                        TongHangHienTai += matrix [i, j];
                    }
                    if(TongHangHienTai > TongHangLonNhat)
                    {
                        TongHangLonNhat = TongHangHienTai;
                        HangCoTongLonNhat = i;
                    }
                }
                Console.WriteLine("Hàng {0} có tổng lớn nhất và tổng đó là : {1}", HangCoTongLonNhat, TongHangLonNhat);
            }
            static bool KiemTraSoNguyenTo(int x)
            {
                if(x < 2) 
                    return false;
                for(int i = 2;i <= Math.Sqrt(x);i++)
                {
                    if(x % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            static void TinhTongCacSoKhongPhaiNguyenToTrongMaTran(int[,] matrix)
            {
                int Hang = matrix.GetLength(0);
                int Cot = matrix.GetLength(1);
                int TongCacSoKhongNguyenTo = 0;
                for(int i = 0; i < Hang ; i++)
                {
                    for(int j = 0; j < Cot ; j++)
                    {
                        if (KiemTraSoNguyenTo(matrix[i,j]) == false)
                            TongCacSoKhongNguyenTo += matrix[i,j];
                    }
                }
                Console.WriteLine("Tổng các số không phải số nguyên tố trong ma trận là: {0}", TongCacSoKhongNguyenTo);
            }
        static void XoaDongThuKTrongMaTran(ref int[,] matrix, int k)
        {
            int Hang = matrix.GetLength(0);
            int Cot = matrix.GetLength(1);

            if (k < 0 || k >= Hang)
            {
                Console.WriteLine("Dòng cần xóa không hợp lệ!");
                return;
            }
            int[,] MaTranMoi = new int[Hang - 1, Cot];

            int DongMoi = 0;
            for (int i = 0; i < Hang; i++)
            {
                if (i == k)
                    continue;
                for (int j = 0; j < Cot; j++)
                {
                    MaTranMoi[DongMoi, j] = matrix[i, j];
                }
                DongMoi++;
            }
            matrix = MaTranMoi;
        }

        static void XoaCotChuaPhanTuLonNhatTrongMaTran(ref int[,] matrix)
            {
                int Hang = matrix.GetLength(0);
                int Cot = matrix.GetLength(1);
                int PhanTuLonNhat = matrix[0, 0];
                int ThuTuCotCanXoa = 0;
                for(int i = 0; i < Hang ; i++)
                {
                    for (int j = 0;j < Cot ; j++)
                    {
                        if(PhanTuLonNhat <  matrix[i,j])
                        {
                            PhanTuLonNhat = matrix[i, j];
                            ThuTuCotCanXoa = j;
                        }
                    }
                }
                int[,] MaTranMoi = new int[Hang, Cot - 1];
                for(int i = 0;  i < Hang ; i++)
                {
                    int CotMoi = 0;
                    for(int j = 0; j < Cot ; j++)
                    {
                        if (j == ThuTuCotCanXoa)
                            continue;
                        MaTranMoi[i, CotMoi++] = matrix[i, j];
                    }
                }
                matrix = MaTranMoi;
            }
        }
    }
