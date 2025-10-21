using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5
{
    class cKhuDat : cBatDongSan
    {
        public override void NhapThongTin()
        {
            Console.WriteLine("Nhap thong tin khu dat:");
            base.NhapThongTin();
        }

        public override void XuatThongTin()
        {
            base.XuatThongTin();
        }
    }
}
