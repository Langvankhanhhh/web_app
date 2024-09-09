using System;
using System.Collections.Generic;
using System.Text;

namespace dientichhinhthangkhongthuvien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double a, b, h, dientich;

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

                dientich = (a+b)*h/2;
                Console.WriteLine($"Dien tich hinh thang la : {dientich}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi: " + ex.Message);
            }
            Console.ReadLine();
        }
        }
    }



