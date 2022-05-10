  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Dahinh
{
    class HinhHoc
    {
        public virtual void xuat()
        {
            Console.WriteLine("Day la hinh hoc!");
        }
    }

    class TamGiac : HinhHoc
    {
        public override void xuat()
        {
            Console.WriteLine("Hinh tam giac:" +
                            "Co 3 canh");
        }
    }
    class TuGiac : HinhHoc
    {
        public override void xuat()
        {
            Console.WriteLine("Hinh tu giac:" +
                            "Co 4 canh");
        }
    }
    class hinhBinhHanh : HinhHoc
    {
        public override void xuat()
        {
            Console.WriteLine("Hinh binh hanh:" +
                            "Co 4 canh" +
                            "Co 2 cap canh song song khong bang nhau");
        }
    }
    class hinhVuong : HinhHoc
    {
        public override void xuat()
        {
            Console.WriteLine("Hinh vuong:" +
                            "Co 4 canh bang nhau" +
                            "Co 1 goc vuong");
        }
    }

    class hinhChuNhat : HinhHoc
    {
        public override void xuat()
        {
            Console.WriteLine("Hinh chu nhat:" +
                            "Co 4 canh" +
                            "Co 2 cap canh song song khong bang nhau" +
                            "Co 1 goc vuong");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int hinhHoc;
            Console.WriteLine("1 - hinh tam giac");
            Console.WriteLine("2 - hinh tu giac");
            Console.WriteLine("3 - hinh binh hanh ");
            Console.WriteLine("4 - hinh chu nhat ");
            Console.WriteLine("5 - hinh vuong ");
            Console.WriteLine("Nhap hinh: ");
            Console.WriteLine("=========================================");
            hinhHoc = int.Parse(Console.ReadLine());

            switch (hinhHoc)
            {
                case 1:
                    {
                        TamGiac tg = new TamGiac();
                        tg.xuat();
                    }
                    break;
                case 2:
                    {
                        TuGiac tg = new TuGiac();
                        tg.xuat();
                    }
                    break;
                case 3:
                    {
                        hinhBinhHanh hbh = new hinhBinhHanh();
                        hbh.xuat();
                    }
                    break;
                case 4:
                    {
                        hinhChuNhat hcn = new hinhChuNhat();
                        hcn.xuat();
                    }
                    break;
                case 5:
                    {
                        hinhVuong hv = new hinhVuong();
                        hv.xuat();
                    }
                    break;
                default:
                    break;
            }
            Console.ReadKey();

        }
    }
}

