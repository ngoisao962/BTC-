using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapcoban2
{
    class Program
    {
        public static int[] taoMang1(int[] mang, int n)
        {
            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {
                mang[i] = rd.Next(10, 20);
            }
            return mang;
        }

        public static void xuatMang1(int[] mang, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("[" + i + "]:" + mang[i] + " ");
            }
        }

        public static void sum(int[] mang, int n)
        {
            int a = 0, b = 0;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 != 0 && mang[i] % 2 == 0)
                    a += mang[i];
                if (i % 2 == 0 && mang[i] % 2 != 0)
                    b += mang[i];
            }
            Console.Write("\nTong cac so chan o vi tri le: " + a + "\nTong cac so le o vi tri chan: " + b);
            if (a == b)
                Console.WriteLine("\n=> Bang nhau.");
            else
                Console.WriteLine("\n=> Khong bang nhau.");
        }

        public static int[] taoMang(int[] mang, int n)
        {
            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {
                mang[i] = rd.Next(-100, 100);
            }
            return mang;
        }

        public static void xuatMang(int[] mang, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(mang[i] + " ");
            }
        }

        public static int[] shuffle(int[] mangA, int n)
        {
            int[] mangB = new int[n];
            int a = n / 2;
            int b = a;
            int j = 0;
            for (int i = 0; i < a; i++)
            {
                mangB[j] = mangA[i];
                j++;
                mangB[j] = mangA[b];
                b++;
                j++;
            }
            return mangB;
        }
        public static int sum(int[] mang)
        {
            int sum = 0;
            foreach (int a in mang)
            {
                if (a > 0)
                    sum += a;
            }
            return sum;
        }

        public static int[] delete(int[] mang, int n, int p)
        {
            for (int i = p; i < n - 1; i++)
            {
                mang[i] = mang[i + 1];
            }
            return mang;
        }
        public static int UCLN(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }

        public static void capSo(int[] mang, int n)
        {
            Console.WriteLine("Cac cap nguyen to cũng nhau: ");
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (i != j)
                    {
                        int uc = UCLN(mang[i], mang[j]);
                        if (uc == 1)
                            Console.WriteLine("(" + mang[i] + ", " + mang[j] + ")");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Bai1: 59.Nhap vao nam duong lich, xuat ten nam am lich. Xuat nam duong lich ke tiep co cung ten nam am lich");
           
            Console.WriteLine("Bai2: 60.Viet chuong trinh thuc hien nhung yeu cau sau: \n a) Tao ngau nhien mang mot chieu nhieu phan tu nguyen(n chan) co gia tri trong doan chua [-100,100] va xuat mang \n " +
                "b) Viet ham thuc hien viec tron hoan hao mot mang sao cho mot nua mang sau xen ke voi cac phan tu cua mot nua mang dau va xuat mang\n" +
                " c) Xac dinh so lan tron hoan hao de mang tro ve nhu ban dau"  );

            Console.WriteLine("Bai3: 61.Viet chuong trinh thuc hien nhung yeu cau sau: \n a)Tao ngau nhien mang mot chieu nhieu phan tu nguyen co gia tri trong doan chua [-100,100] va xuat mang \n" +
                " b) Tinh tong cac so nguyen duong trong mang\n" +
                " c) Xoa phan tu co chi so p(nhap tu ban phim) trong mang"
                );
            Console.WriteLine("Bai4: 62.Viet chuong trinh thuc hien nhung yeu cau sau: \n a)Tao ngau nhien mang mot chieu nhieu phan tu nguyen co gia tri trong doan chua [-100,100] va xuat mang \n " +
                " b) Kiem tra xem tong các so chan o vi tri le co bang tong cac so le o vi tri chan hay khong\n" +
                " c) Xac dinh xem mang co cap so nguyen to cung nhau nao khong");
            Console.WriteLine("bai5:Viet chuong trinh thuc hien thuat toan sang  Erastosthenes10(Sieve  of Erastosthenes)de in ra cac so nguyen to nho hon n cho truoc (n < 100).");
            Console.WriteLine("chon 1 bai:");
            int k = int.Parse(Console.ReadLine());
            switch (k)
            {
                case 1:
                    {
                    
                        Console.Clear();
                        Console.WriteLine("Nhap nam duong lich:");
                        int nam = Int32.Parse(Console.ReadLine());
                        string[] strCan = { "Canh", "Tan", "Nham", "Quy", "Giap", "At", "Binh", "Dinh", "Mau", "Ky" };
                        string[] strChi = { "Than", "Dau", "Tuat", "Hoi", "Ty", "Suu", "Dan", "Mao", "Thin", "Ti", "Ngo", "Mui" };
                        Console.Write("\nNam {0} la :{1} {2}", nam, strCan[nam % 10], strChi[nam % 12]);
     
                    }
                    break;
                case 2:
                    {
                        Console.Clear();
                        Console.Write("Nhap do dai cua mang: ");
                        int n = int.Parse(Console.ReadLine());
                        int[] mang = new int[n];
                        int[] mang2 = new int[n];
                        int[] mang3 = new int[n];

                        mang = taoMang(mang, n);
                        xuatMang(mang, n);

                        Console.WriteLine("\n");

                        mang2 = shuffle(mang, n);
                        xuatMang(mang2, n);

                        int dem = 0;
                        do
                        {
                            mang3 = shuffle(mang2, n);
                            mang2 = mang3;
                            dem++;
                        } while (mang.SequenceEqual(mang3) == false);
                        Console.WriteLine("\nCan " + (dem + 1) + " lan shuffle de mang tro ve ban dau");

                        Console.ReadLine();
                    }
                    break;
                case 3:
                    {
                        Console.Clear();
                        Console.Write("Nhap do dai cua mang: ");
                        int n = int.Parse(Console.ReadLine());
                        int[] mang = new int[n];

                        mang = taoMang(mang, n);
                        xuatMang(mang, n);

                        Console.Write("\nNhap p [0, " + (n - 1) + "]: ");
                        int p = int.Parse(Console.ReadLine());

                        mang = delete(mang, n, p);
                        n--;
                        xuatMang(mang, n);

                        Console.ReadLine();
                    }
                    break;
                case 4:
                    {
                        Console.Clear();
                        Console.Write("Nhap do dai cua mang: ");
                        int n = int.Parse(Console.ReadLine());
                        int[] mang = new int[n];

                        mang = taoMang1(mang, n);
                        xuatMang1(mang, n);

                        sum(mang, n);

                        capSo(mang, n);

                        Console.ReadLine();
                    }
                    break;
                case 5:
                    {
                        Console.Clear();
                        int i;
                        Console.Write("Nhap do dai cua mang: ");
                        int h = int.Parse(Console.ReadLine());
                        bool[] mang = new bool[h + 1];
                        for (i = 2; i <= h; ++i)
                            mang[i] = true;
                        for (i = 2; i < Math.Sqrt(h); i++)
                        {
                            if (mang[i])
                            {
                                int j = (int)Math.Pow(i, 2);
                                while (j <= h)
                                {
                                    mang[j] = false;
                                    j += i;
                                }
                            }
                        }
                        Console.WriteLine("Cac so nguyen to la:");
                        for (i = 2; i <= h; i++)
                        {
                            if (mang[i])
                                Console.Write("{0}, ", i);
                        }
                    }
                    break;
            }
        }
    }
}
