using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BT2
{
    class Program
    {
        static void Main(string[] args)
        {
            cFileDirection FileDirect = new cFileDirection();
            FileDirect.NhapDuongDanThuMuc();
            FileDirect.XuatCacDuongDanTrongThuMuc();
        }
    }
}
