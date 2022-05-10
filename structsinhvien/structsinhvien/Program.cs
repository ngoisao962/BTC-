using System;

namespace baistruct
{
    class Program
    {
        public struct sinhvien
        {
            public string maso241;
            public string hoten241;
            public double diemtoan241;
            public gioitinh gioitinh241;
            public double diemly241;
            public double diemhoa241;
        }
        public enum gioitinh
        {
            Nam,
            Nu
        };
        public enum hocluc
        {
            Yeu,
            TrungBinh,
            Kha,
            Gioi
        };
        public static void nhapDS(ref sinhvien[] sv, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap sinh vien thu " + (i + 1));
                Console.Write("Ho ten: ");
                string ht241 = Console.ReadLine();
                Console.Write("Ma sinh vien: ");
                string msv241 = Console.ReadLine();
                Console.Write("Gioi tinh (0: nam  1: nu): ");
                int gt241 = int.Parse(Console.ReadLine());
                Console.Write("Diem toan: ");
                double dt241 = double.Parse(Console.ReadLine());
                Console.Write("Diem ly: ");
                double dl241 = double.Parse(Console.ReadLine());
                Console.Write("Diem hoa: ");
                double dh241 = double.Parse(Console.ReadLine());


                sv[i].hoten241 = ht241;
                sv[i].maso241 = msv241;
                if (gt241 == 0)
                    sv[i].gioitinh241 = gioitinh.Nam;
                else
                    sv[i].gioitinh241 = gioitinh.Nu;
                sv[i].diemtoan241 = dt241;
                sv[i].diemly241 = dl241;
                sv[i].diemhoa241 = dh241;

            }
        }
        public static void xuatDS(sinhvien[] sv, int n)
        {
            int i = 1;
            foreach (sinhvien item241 in sv)
            {
                Console.WriteLine("----- " + i + " -----");
                Console.WriteLine("Ho ten: " + item241.hoten241);
                Console.WriteLine("Ma sinh vien: " + item241.maso241);
                int gt = (int)item241.gioitinh241;
                if (gt == 0)
                    Console.WriteLine("Gioi tinh: Nam");
                else
                    Console.WriteLine("Gioi tinh: Nữ");
                Console.WriteLine("Diem toan: " + item241.diemtoan241);
                Console.WriteLine("Diem ly: " + item241.diemly241);
                Console.WriteLine("Diem hoa: " + item241.diemhoa241);
                int hocluc = (int)diemTB(item241.diemtoan241, item241.diemly241, item241.diemhoa241);
                switch (hocluc)
                {
                    case 0:
                        Console.WriteLine("Hoc luc: Yeu");
                        break;
                    case 1:
                        Console.WriteLine("Hoc luc: Trung Binh");
                        break;
                    case 2:
                        Console.WriteLine("Hoc luc: Kha");
                        break;
                    case 3:
                        Console.WriteLine("Hoc luc:Gioi");
                        break;

                }

                i++;
            }
        }
        public static hocluc diemTB(double toan, double ly, double hoa)
        {
            double dtb = (toan + ly + hoa) / 3;
            if (dtb <= 4)
                return hocluc.Yeu;
            else if (dtb <= 5)
                return hocluc.TrungBinh;
            else if (dtb <= 7)
                return hocluc.Kha;
            else
                return hocluc.Gioi;
        }
        public static void timKiem(sinhvien[] sv, int n, string ht)
        {
            foreach (sinhvien item241 in sv)
            {
                if (item241.hoten241 == ht)
                {
                    Console.WriteLine("Ho ten: " + item241.hoten241);
                    Console.WriteLine("Ma sinh vien: " + item241.maso241);
                    int gt = (int)item241.gioitinh241;
                    if (gt == 0)
                        Console.WriteLine("Gioi tinh: Nam");
                    else
                        Console.WriteLine("Gioi tinh: Nữ");
                    Console.WriteLine("Diem toan: " + item241.diemtoan241);
                    Console.WriteLine("Diem ly: " + item241.diemly241);
                    Console.WriteLine("Diem hoa: " + item241.diemhoa241);
                    int hocluc = (int)diemTB(item241.diemtoan241, item241.diemly241, item241.diemhoa241);
                    switch (hocluc)
                    {
                        case 0:
                            Console.WriteLine("Hoc luc: Yeu");
                            break;
                        case 1:
                            Console.WriteLine("Hoc luc: Trung Binh");
                            break;
                        case 2:
                            Console.WriteLine("Hoc luc: Kha");
                            break;
                        case 3:
                            Console.WriteLine("Hoc luc:Gioi");
                            break;

                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap so sinh vien: ");
            int n241 = int.Parse(Console.ReadLine());
            sinhvien[] sv241 = new sinhvien[n241];
            nhapDS(ref sv241, n241);
            Console.WriteLine("\n\n==========DANH SACH SINH VIEN==========");
            xuatDS(sv241, n241);

            Console.WriteLine("\n==========TIM KIEM SINH VIEN==========");
            Console.Write("Nhap ten sinh vien: ");
            string ht241 = Console.ReadLine();
            timKiem(sv241, n241, ht241);

            Console.ReadLine();
        }
    }
}

