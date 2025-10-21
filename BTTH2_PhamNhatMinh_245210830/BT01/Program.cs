using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            cLichThang LichHienTai = new cLichThang();
            LichHienTai.NhapThangNam();
            LichHienTai.XuatManHinhLichThang();
        }
    }
}
