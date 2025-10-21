using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5
{
    class cQuanLi
    {
        private int SoLuong
        {
            get; set;
        }

        private cBatDongSan[] DanhSachBatDongSan;



        public void NhapDanhSachBatDongSan()
        {
            do
            {
                Console.Write("Nhap so luong danh sach bat dong san Cong Ti quan li: ");
                SoLuong = int.Parse(Console.ReadLine());
            } while ( SoLuong <= 0 );

            DanhSachBatDongSan = new cBatDongSan[SoLuong];

            for (int i = 0; i < SoLuong; i++)
            {
                int Loai;
                while (true)
                {
                    Console.Write("Nhap loai bat dong san (1. Khu Dat, 2. Nha Pho, 3. Chung Cu): ");
                    if (int.TryParse(Console.ReadLine(), out Loai) && (Loai >= 1 && Loai <= 3))
                    {
                        break;
                    }
                    Console.WriteLine("Loai bat dong san khong hop le, vui long nhap lai.");
                }

                switch (Loai)
                {
                    case 1:
                        cKhuDat KhuDat = new cKhuDat();
                        KhuDat.NhapThongTin();
                        DanhSachBatDongSan[i] = KhuDat;
                        break;
                    case 2:
                        cNhaPho NhaPho = new cNhaPho();
                        NhaPho.NhapThongTin();
                        DanhSachBatDongSan[i] = NhaPho;
                        break;
                    case 3:
                        cChungCu ChungCu = new cChungCu();
                        ChungCu.NhapThongTin();
                        DanhSachBatDongSan[i] = ChungCu;
                        break;
                    default:
                        Console.WriteLine("Loai bat dong san khong hop le, vui long nhap lai.");
                        i--;
                        break;
                }
            }
            
        }

        public void XuatDanhSachBatDongSan()
        {
            Console.WriteLine("----Xuat danh sach bat dong san cong ti quan ly----");
            foreach (cBatDongSan BDS in DanhSachBatDongSan)
            {
                BDS.XuatThongTin();
                Console.WriteLine();
            }
        }

        public void XuatTongGiaBan()
        {
            Console.WriteLine("----Danh sach tong gia ban cua tung loai bat dong san cong ti quan ly----");
            double GiaBanKhuDat = 0;
            double GiaBanNhaPho = 0;
            double GiaBanChungCu = 0;
            foreach (cBatDongSan BDS in DanhSachBatDongSan)
            {
                if(BDS is cKhuDat)
                {
                    GiaBanKhuDat += BDS.getGiaBan();
                }
                if (BDS is cNhaPho)
                {
                    GiaBanNhaPho += BDS.getGiaBan();
                }
                if (BDS is cChungCu)
                {
                    GiaBanChungCu += BDS.getGiaBan();
                }
            }
            Console.WriteLine("Tong gia ban khu dat la: {0}", GiaBanKhuDat);
            Console.WriteLine("Tong gia ban nha pho la: {0}", GiaBanNhaPho);
            Console.WriteLine("Tong gia ban chung cu la: {0}", GiaBanChungCu);
        }

        public void XuatDanhSachTMDK()
        {
            Console.WriteLine("----Danh sach cac bat dong san thoa man dieu kien----");
            foreach (cBatDongSan BDS in DanhSachBatDongSan)
            {
                if(BDS is cKhuDat && BDS.getDienTich() > 100)
                {
                    BDS.XuatThongTin();
                }
                if(BDS is cNhaPho NhaPho)
                {
                    if(NhaPho.getDienTich() > 60 && NhaPho.getNamXayDung() >= 2019)
                    {
                        NhaPho.XuatThongTin();
                    }
                }
            }
        }

        public void XuatThongTinTimKiem()
        {
            Console.WriteLine("----Tim kiem nha pho hoac chung cu----");

            Console.Write("Nhap dia diem: ");
            string diaDiemTK = Console.ReadLine().Trim().ToLower();
            double GiaBan;
            double DienTich;
            while (true)
            {
                Console.Write("Nhap gia ban (> 0): ");
                if (double.TryParse(Console.ReadLine(), out double gia) && gia > 0)
                {
                    GiaBan = gia;
                    break;
                }
                Console.WriteLine("Gia ban khong hop le, vui long nhap lai.");
            }

            while (true)
            {
                Console.Write("Nhap dien tich (> 0): ");
                if (double.TryParse(Console.ReadLine(), out double dientich) && dientich > 0)
                {
                    DienTich = dientich;
                    break;
                }
                Console.WriteLine("Dien tich khong hop le, vui long nhap lai.");
            }

            bool IsExist = false;

            foreach (cBatDongSan bds in DanhSachBatDongSan)
            {
                if (bds is cNhaPho || bds is cChungCu)
                {
                    string diaDiemBDS = bds.getDiaDiem().ToLower();

                    if (diaDiemBDS.Contains(diaDiemTK) && bds.getGiaBan() <= GiaBan && bds.getDienTich() >= DienTich)
                    {
                        bds.XuatThongTin();
                        IsExist = true;
                    }
                }
            }

            if (!IsExist)
            {
                Console.WriteLine("Khong co bat dong san nao phu hop.");
            }
        }

    }
}
