using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    class cMaTran
    {
        private int Hang
        {
            get; set;
        }
        private int Cot
        {
            get; set;
        }
        private int[,] MaTran
        {
            get; set;
        }

        public void NhapMaTran()
        {
            while (true)
            {
                Console.Write("Nhap so hang (So hang > 0): ");
                if (int.TryParse(Console.ReadLine(), out int H) && H > 0)
                {
                    Hang = H;
                    break;
                }
                else
                {
                    Console.WriteLine("Xin hay nhap lai so hang");
                }
            }
            while (true)
            {
                Console.Write("Nhap so cot (So cot > 0): ");
                if (int.TryParse(Console.ReadLine(), out int C) && C > 0)
                {
                    Cot = C;
                    break;
                }
                else
                {
                    Console.WriteLine("Xin hay nhap lai so cot");
                }
            }
            MaTran = new int[Hang, Cot];
            for (int i = 0; i < Hang; i++)
            {
                while (true)
                {
                    string Dong = Console.ReadLine();
                    string[] parts = Dong.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    if (parts.Length != Cot)
                    {
                        Console.WriteLine(" Vui long nhap dung {0} so cho dong nay.", Cot);
                        continue;
                    }

                    bool isValid = true;
                    for (int j = 0; j < Cot; j++)
                    {
                        if (int.TryParse(parts[j], out int value))
                        {
                            MaTran[i, j] = value;
                        }
                        else
                        {
                            Console.WriteLine("Xin hay nhap lai bang so nguyen.");
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid)
                        break;
                }
            }
        }

        public void XuatMaTran()
        {
            Console.WriteLine("----Xuat ma tran----");
            for (int i = 0; i < MaTran.GetLength(0); i++)
            {
                for (int j = 0; j < MaTran.GetLength(1); j++)
                {
                    Console.Write(MaTran[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void TimPhanTuTrongMaTran()
        {
            Console.WriteLine("----Tim phan tu trong ma tran----");
            int PhanTu;
            while (true)
            {
                Console.Write("Nhap phan tu can tim trong ma tran: ");
                if (int.TryParse(Console.ReadLine(), out int PT))
                {
                    PhanTu = PT;
                    break;
                }
                else
                {
                    Console.WriteLine("Xin hay nhap lai phan tu la so nguyen.");
                }
            }
            bool IsExist = false;
            for (int i = 0; i < MaTran.GetLength(0); i++)
            {
                for (int j = 0; j < MaTran.GetLength(1); j++)
                {
                    if (MaTran[i,j] == PhanTu)
                    {
                        IsExist = true;
                        Console.WriteLine("Phan tu {0} ton tai va o hang thu {1}, cot thu {2}", PhanTu, i + 1, j + 1);
                        break;
                    }
                }
            }
            if (IsExist == false)
            {
                Console.WriteLine("Phan tu {0} khong ton tai trong ma tran.", PhanTu);
            }
        }

        private bool KiemTraPhanTuLaSoNguyenTo(int SNT)
        {
            if(SNT <= 1)
            {
                return false;
            }

            for(int i = 2; i <= (int) Math.Sqrt(SNT); i++)
            {
                if(SNT % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public void XuatCacSoNguyenToTrongMaTran()
        {
            Console.WriteLine("----Xuat cac phan tu la so nguyen to trong ma tran----");

            bool IsExist = false;

            for(int i = 0; i < MaTran.GetLength (0); i++)
            {
                for (int j = 0; j < MaTran.GetLength (1); j++)
                {
                    if(KiemTraPhanTuLaSoNguyenTo(MaTran[i, j]))
                    {
                        IsExist = true;
                        Console.Write (MaTran[i, j] + " ");
                    }
                }
            }

            if(IsExist == false)
            {
                Console.Write("Khong co so nguyen to nao trong ma tran");
            }

            Console.WriteLine();
        }

        public void TimDongNaoCoNhieuSoNguyenToNhat()
        {
            Console.WriteLine("----Tim dong co nhieu so nguyen to nhat----");

            int DongCoNhieuSoNguyenToNhat = 0;
            int SoNguyenToThuocDongCoNhieuSoNguyenToNhat = 0;
            bool IsExist = false;

            for (int i = 0;i < MaTran.GetLength (0);i++)
            {
                int SoNguyenToThuocDongHienTai = 0;
                for(int j = 0;  j < MaTran.GetLength (1);j++)
                {
                    if(KiemTraPhanTuLaSoNguyenTo(MaTran [i, j]))
                    {
                        SoNguyenToThuocDongHienTai++;
                        IsExist = true;
                    }
                }
                if (SoNguyenToThuocDongHienTai > SoNguyenToThuocDongCoNhieuSoNguyenToNhat)
                {
                    SoNguyenToThuocDongCoNhieuSoNguyenToNhat = SoNguyenToThuocDongHienTai;
                    DongCoNhieuSoNguyenToNhat = i + 1;
                }
            }

            if (IsExist == false)
                Console.WriteLine("Khong co dong nao co so nguyen to");
            else
                Console.WriteLine("Dong co nhieu so nguyen to nhat la dong thu: {0}", DongCoNhieuSoNguyenToNhat);
        }
    }
}
