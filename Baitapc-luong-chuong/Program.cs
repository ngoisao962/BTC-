using System;

namespace BTDIEMDANH
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap a,b,c: ");
            double a205 = Int32.Parse(Console.ReadLine());
            double b205 = Int32.Parse(Console.ReadLine());
            double c205 = Int32.Parse(Console.ReadLine());
            ptb2 pt = new ptb2(a205, b205, c205);

            double delta = pt.delta(a205, b205, c205);
            int check205 = pt.nghiem(delta);
            if (check205 < 0)
            {
                Console.WriteLine("Pt vo nghiem");
            }
            else if (check205 == 0)
            {
                double x = -b205 / (2 * a205);
                Console.WriteLine("pt co nghiem kep: ", x);
            }
            else
            {
                double x1 = (-b205 - Math.Sqrt(delta)) / (2 * a205);
                double x2 = (-b205 + Math.Sqrt(delta)) / (2 * a205);

                Console.WriteLine("Pt co 2 nghiem x1={0} , x2={1}: ", x1, x2);
            }
        }
    }

    class ptb2
    {
        private double a205;
        private double b205;
        private double c205;

        public ptb2()
        {
        }

        public ptb2(double a205, double b205, double c205)
        {
            A = a205;
            B = b205;
            C = c205;
        }

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public double delta(double a205, double b205, double c205)
        {
            return b205 * b205 - 4 * a205 * c205;
        }

        public int nghiem(double delta205)
        {
            if (delta205 < 0)
            {
                return -1;
            }
            else if (delta205 == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
