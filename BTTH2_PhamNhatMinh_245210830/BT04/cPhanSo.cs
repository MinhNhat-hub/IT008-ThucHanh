using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4
{
    class cPhanSo : IComparable<cPhanSo>
    {
        private int TuSo
        {
            get; set;
        }
        private int MauSo
        {
            get; set;
        }

        public cPhanSo(int Tu = 0, int Mau = 1)
        {
            TuSo = Tu;
            MauSo = Mau;
                
        }

        private int UCLN(int TuSo, int MauSo)
        {
            while (MauSo != 0)
            {
                int temp = MauSo;
                MauSo = TuSo % MauSo;
                TuSo = temp;
            }
            return TuSo;
        }

        public void NhapPhanSo()
        {
            while (true)
            {
                Console.Write("Nhap tu so: ");
                if (int.TryParse(Console.ReadLine(), out int TS))
                {
                    TuSo = TS;
                    break;
                }
                else
                {
                    Console.WriteLine("Ban nhap tu so khong phu hop, vui long nhap lai.");
                }
            }
            while (true)
            {
                Console.Write("Nhap mau so: ");
                if (int.TryParse(Console.ReadLine(), out int MS) && MS != 0)
                {
                    MauSo = MS;
                    break;
                }
                else
                {
                    Console.WriteLine("Ban nhap mau so khong phu hop, vui long nhap lai.");
                }
            }
        }

        public cPhanSo RutGon()
        {
            int ucln = UCLN(Math.Abs(TuSo), Math.Abs(MauSo));
            return new cPhanSo(TuSo / ucln, MauSo / ucln);
        }

        public static cPhanSo operator +(cPhanSo A, cPhanSo B)
        {
            return new cPhanSo(A.TuSo * B.MauSo + B.TuSo * A.MauSo, A.MauSo * B.MauSo).RutGon();
        }

        public static cPhanSo operator -(cPhanSo A, cPhanSo B)
        {
            return new cPhanSo(A.TuSo * B.MauSo - B.TuSo * A.MauSo, A.MauSo * B.MauSo).RutGon();
        }

        public static cPhanSo operator *(cPhanSo A, cPhanSo B)
        {
            return new cPhanSo(A.TuSo * B.TuSo, A.MauSo * B.MauSo).RutGon();
        }

        public static cPhanSo operator /(cPhanSo A, cPhanSo B)
        {
            if (B.TuSo == 0)
                throw new ArgumentException("Khong the chia cho phan so co tu so bang 0 (phan so bang 0)");
            return new cPhanSo(A.TuSo * B.MauSo, A.MauSo * B.TuSo).RutGon();
        }

        public void XuatPhanSo()
        {
            Console.WriteLine("{0}/{1}", TuSo, MauSo);
        }

        public int getTuSo()
        {
            return TuSo;
        }

        public int CompareTo(cPhanSo other)
        {
            double value1 = (double)TuSo / MauSo;
            double value2 = (double)other.TuSo / other.MauSo;

            if (value1 < value2) return -1;
            if (value1 > value2) return 1;
            return 0;
        }
    }
}
