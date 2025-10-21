using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BT5
{
    class cBatDongSan
    {
        protected string DiaDiem
        {
            get; set;
        }
        protected double GiaBan
        {
            get; set;
        }
        protected double DienTich
        {
            get; set;
        }
        public virtual void NhapThongTin()
        {
            Console.Write("Nhap dia diem: ");
            DiaDiem = Console.ReadLine().Trim().ToLower();

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
        }

        public virtual void XuatThongTin()
        {
            Console.WriteLine("Dia diem: {0}", DiaDiem);
            Console.WriteLine("Gia ban: {0}", GiaBan);
            Console.WriteLine("Dien tich: {0}", DienTich);
        }
        public double getGiaBan()
        {
            return GiaBan;
        }
        public double getDienTich()
        {
            return DienTich;
        }
        public string getDiaDiem()
        {
            return DiaDiem;
        }
    }
}
