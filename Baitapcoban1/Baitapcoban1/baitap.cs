using System;

namespace Baitapcoban1
{
    public class baitap
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bai 1: Viet chuong trinh cho phep ta nhap vao mot so nguyen, in ra ma hinh la so nguyen duong neu so do lon hon hoac bang 0, nguoc lai in ra la so nguyen am");
            Console.WriteLine("Bai 2: Viet chuong trinh cho phep ta nhap vao mot so nguyen dang so,sau khi chay thi chuong trinh se ghi so do ra dang chu.");
            Console.WriteLine("Bai 3: Viet chuong trinh cho phep ta nhap vao 3 so thuc, chuong trinh se kiem tra 3 so nay co phai la 3 canh cua tam giac hay khong ?");
            Console.WriteLine("Bai 4: Viet chuong trinh cho phep ta nhap vao 3 so,  chuong tỉnh se kiem tra 3 so nay co phai la 3 canh cua tam giac vuong hay khong ");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------\n \n");
            Console.Write(" Moi ban nhap mot so bat ky: ");
                int u_241 = int.Parse(Console.ReadLine());
            switch (u_241)
            {
                case 1:
                    {
                        Console.Write("Nhap vao mot so nguyen:");
                        int m_241 = int.Parse(Console.ReadLine());
                        if (m_241 >= 0)
                            Console.WriteLine("{0} la so nguyen duong", m_241);
                        else
                            Console.WriteLine("{0} la so nguyen am", m_241);
                        Console.ReadKey();
                    }
                    break;
                case 2:
                    {
                        Console.Write("Nhap vao mot so:");
                        int a_241 = int.Parse(Console.ReadLine());
                        if(a_241 == 1)
                            Console.WriteLine("Mot");
                        else
                            if(a_241 == 2)
                                 Console.WriteLine("Hai");
                            else
                                if(a_241 == 3)
                                     Console.WriteLine("Ba");
                                else
                                    if(a_241 == 4)
                                         Console.WriteLine("Bon");
                                     else
                                          if(a_241 == 5)
                                              Console.WriteLine("Nam");
                                           else
                                                if(a_241 == 6)
                                                  Console.WriteLine("Sau");
                                                else
                                                    if(a_241 == 7)
                                                         Console.WriteLine("Bay");
                                                    else
                                                         if(a_241 == 8)
                                                              Console.WriteLine("Tam");
                                                         else
                                                              Console.WriteLine("Chin");
                    }
                    break;

                case 3:
                    {
                        Console.Write("Nhap canh thu nhat: ");
                        double x_241 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Nhap canh thu hai: ");
                        double y_241 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Nhap canh thu ba: ");
                        double z_241 = Convert.ToDouble(Console.ReadLine());
                        if ((x_241 * x_241 < y_241 * y_241 + z_241 * z_241) && (y_241 * y_241 < x_241 * x_241 + z_241 * z_241) && (z_241 * z_241 < y_241 * y_241 + x_241 * x_241))
                        {

                            Console.WriteLine("\nDay la ba canh cua tam giac");
                        }
                        else

                            Console.WriteLine("\nDay khong phai la ba canh cua tam giac");
                        Console.ReadKey();
                    }
                    break;
                case 4:
                    {
                        int k_241, l_241, n_241;
                        Console.Write("Nhap canh thu nhat: ");
                        k_241 = int.Parse(Console.ReadLine());
                        Console.Write("Nhap canh thu hai: ");
                        l_241 = int.Parse(Console.ReadLine());
                        Console.Write("Nhap canh thu ba: ");
                        n_241 = int.Parse(Console.ReadLine());

     
                            if ((l_241 * l_241 + n_241 * n_241 == k_241 * k_241) || (k_241 * k_241 + n_241 * n_241 == l_241 * l_241) || (l_241 * l_241 + k_241 * k_241 == n_241 * n_241))

                            {

                                Console.WriteLine("\nDay la ba canh cua tam giac vuong");
                            }
                            else

                                Console.WriteLine("\nDay khong phai la ba canh cua tam giac vuong");
                            Console.ReadKey();
                        
                    }
                    break;
                default:
                    Console.WriteLine("Ban da nhap sai!");
                    break;

            }

        }
    }
}
        
    

    

