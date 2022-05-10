using System;

namespace vonglapfor
{
    class Program
    {
        static void Main(string[] args)
        {
            int S = 0;
            Console.WriteLine("nhap vao n:");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <=n; i++)
            {
                S += i;
                Console.WriteLine("Tong la: " +S); 
            }
            Console.ReadKey();
        }
        

    }
}
