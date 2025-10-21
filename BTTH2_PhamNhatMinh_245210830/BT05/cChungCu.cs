using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5
{
    class cChungCu : cBatDongSan
    {
        protected int Tang
        {
            get; set;
        }

        public override void NhapThongTin()
        {
            Console.WriteLine("Nhap thong tin chung cu: ");
            base.NhapThongTin();
            while (true)
            {
                Console.Write("Nhap so tang (> 0): ");
                if (int.TryParse(Console.ReadLine(), out int sotang) && sotang > 0)
                {
                    Tang = sotang;
                    break;
                }
                Console.WriteLine("So tang khong hop le, vui long nhap lai.");
            }
        }

        public override void XuatThongTin()
        {
            base.XuatThongTin();
            Console.WriteLine("So tang: {0}", Tang);
        }
    }
}
