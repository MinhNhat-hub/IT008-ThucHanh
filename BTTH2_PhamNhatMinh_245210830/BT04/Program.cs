using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4
{
    class Program
    {
        static void Main(string[] args)
        {
            cPhanSo PhanSoThuNhat = new cPhanSo();
            cPhanSo PhanSoThuHai = new cPhanSo();

            PhanSoThuNhat.NhapPhanSo();
            PhanSoThuHai.NhapPhanSo();

            cPhanSo Tong = PhanSoThuNhat + PhanSoThuHai;
            Console.Write("Tong hai phan so la: ");
            Tong.XuatPhanSo();

            cPhanSo Hieu = PhanSoThuNhat - PhanSoThuHai;
            Console.Write("Hieu hai phan so la: ");
            Hieu.XuatPhanSo();

            cPhanSo Tich = PhanSoThuNhat * PhanSoThuHai;
            Console.Write("Tich hai phan so la: ");
            Tich.XuatPhanSo();

            try
            {
                cPhanSo Thuong = PhanSoThuNhat / PhanSoThuHai;
                Console.Write("Thuong hai phan so la: ");
                Thuong.XuatPhanSo();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Loi khong the chia: " + ex.Message);
            }

            int SoLuongPhanTu;
            while (true)
            {
                Console.Write("Nhap so luong phan so trong mang: ");
                if (int.TryParse(Console.ReadLine(), out int SL) && SL > 0)
                {
                    SoLuongPhanTu = SL;
                    break;
                }
                else
                {
                    Console.WriteLine("So luong khong phu hop, xin hay nhap lai");
                }
            }

            cPhanSo[] DanhSachPhanSo = new cPhanSo[SoLuongPhanTu];

            Console.WriteLine("Nhap danh sach phan so: ");

            for(int i = 0;i < SoLuongPhanTu;i++)
            {
                DanhSachPhanSo[i] = new cPhanSo();
                DanhSachPhanSo[i].NhapPhanSo();
                DanhSachPhanSo[i].RutGon();
            }

            cPhanSo PhanSoLonNhat = DanhSachPhanSo[0];

            foreach (cPhanSo PS  in DanhSachPhanSo)
            {
                if((PhanSoLonNhat - PS).getTuSo() < 0)
                {
                    PhanSoLonNhat = PS;
                }
            }

            Console.Write("Phan so lon nhat cua mang la: ");
            PhanSoLonNhat.XuatPhanSo();

            Console.WriteLine("Sap xep cac phan so trong mang theo thu tu tang dan: ");

            Array.Sort(DanhSachPhanSo);

            foreach(cPhanSo PS in DanhSachPhanSo)
            {
                PS.XuatPhanSo();
            }
        }
    }
}
