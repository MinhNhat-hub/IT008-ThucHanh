using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5
{
    class Program
    {
        static void Main(string[] args)
        {
            cQuanLi BDSCongTyDiaOcDaiPhu = new cQuanLi();
            BDSCongTyDiaOcDaiPhu.NhapDanhSachBatDongSan();
            BDSCongTyDiaOcDaiPhu.XuatDanhSachBatDongSan();
            BDSCongTyDiaOcDaiPhu.XuatTongGiaBan();
            BDSCongTyDiaOcDaiPhu.XuatDanhSachTMDK();
            BDSCongTyDiaOcDaiPhu.XuatThongTinTimKiem();
        }
    }
}
