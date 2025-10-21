using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    class Program
    {
        static void Main(string[] args)
        {
            cMaTran MaTran = new cMaTran();
            MaTran.NhapMaTran();
            MaTran.XuatMaTran();
            MaTran.TimPhanTuTrongMaTran();
            MaTran.XuatCacSoNguyenToTrongMaTran();
            MaTran.TimDongNaoCoNhieuSoNguyenToNhat();
        }
    }
}
