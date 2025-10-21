using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5
{
    class cNhaPho : cBatDongSan
    {
        protected int NamXayDung
        {
            get; set;
        }
        protected int SoTang
        {
            get; set;
        }
        public override void NhapThongTin()
        {
            Console.WriteLine("Nhap thong tin nha pho: ");
            base.NhapThongTin();

            while (true)
            {
                Console.Write("Nhap nam xay dung (> 0): ");
                if (int.TryParse(Console.ReadLine(), out int nam) && nam > 0)
                {
                    NamXayDung = nam;
                    break;
                }
                Console.WriteLine("Gia ban khong hop le, vui long nhap lai.");
            }

            while (true)
            {
                Console.Write("Nhap so tang (> 0): ");
                if (int.TryParse(Console.ReadLine(), out int sotang) && sotang > 0)
                {
                    SoTang = sotang;
                    break;
                }
                Console.WriteLine("So tang khong hop le, vui long nhap lai.");
            }
        }

        public override void XuatThongTin()
        {
            base.XuatThongTin();
            Console.WriteLine("Nam xay dung: {0}", NamXayDung);
            Console.WriteLine("So tang: {0}", SoTang);
        }

        public int getNamXayDung()
        {
            return NamXayDung;
        }
    }
}
