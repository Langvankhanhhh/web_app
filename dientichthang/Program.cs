using System;
using System.Collections.Generic;
using System.Text;
using libHinhthang;
namespace appdientichthang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double a, b, h;

                while (true)
                {
                    Console.Write("Nhap day lon : ");
                    if (double.TryParse(Console.ReadLine(), out a) && a > 0)
                    {
                        break;  
                    }
                    Console.WriteLine("Nhap sai roi , nhap lai!");
                }

                while (true)
                {
                    Console.Write("Nhap day nho : ");
                    if (double.TryParse(Console.ReadLine(), out b) && b > 0)
                    {
                        break;  
                    }
                    Console.WriteLine("Nhap sai roi , nhap lai!");
                }

                while (true)
                {
                    Console.Write("Nhap chieu cao : ");
                    if (double.TryParse(Console.ReadLine(), out h) && h > 0)
                    {
                        break;  
                    }
                    Console.WriteLine("Nhap sai roi , nhap lai!");
                }

                double area = dientichthang.dientich(a, b, h);
                Console.WriteLine($"Dien tich hinh thang la : {area}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi: " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
