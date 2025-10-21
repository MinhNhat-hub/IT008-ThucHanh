using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BT2
{
    class cFileDirection
    {
        private string strFile;

        public void NhapDuongDanThuMuc()
        {
            Console.Write("Nhap duong dan thu muc: ");
            strFile = Console.ReadLine();
        }


        public void XuatCacDuongDanTrongThuMuc()
        {
            if (Directory.Exists(strFile))
            {
                DirectoryInfo DirIF = new DirectoryInfo(strFile);
                if (DirIF.Exists)
                {
                    string[] strings = Directory.GetDirectories(strFile);
                    Console.WriteLine();
                    for (int i = 0; i < strings.Length; i++)
                    {
                        FileInfo fi = new FileInfo(strings[i]);
                        Console.Write($"{fi.CreationTime} \t");
                        Console.WriteLine(strings[i]);
                    }
                    FileInfo[] Files = DirIF.GetFiles();
                    foreach (FileInfo fi in Files)
                    {
                        Console.Write($"{fi.CreationTime} \t");
                        Console.WriteLine($"{fi.FullName}");
                    }
                }
                else
                {
                    Console.Write("Khong co tap tin nao trong thu muc");
                }
            }
            else
            {
                Console.Write("Khong tim thay thu muc");
            }
            Console.WriteLine();
        }
    }
}
