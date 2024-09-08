using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tinh dien tich tam giac");

            Console.Write("Nhap do dai canh a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Nhap do dai canh b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Nhap do dai canh c: ");
            int c = int.Parse(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                double s = (a + b + c) / 2.0;
                double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                Console.WriteLine($"Dien tich tam giac voi cac canh {a}, {b}, {c} la: {area:F2}");
            }
            else
            {
                Console.WriteLine("Cac canh nhap vao khong tao thanh mot tam giac hop le.");
            }
        }
    }
}
