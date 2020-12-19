using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            double A1, A2, A3, x1, x2, x3, y1, y2, y3, d;
            Console.WriteLine("Исходные данные");
            Console.WriteLine("Введите кординаты A1");
            Console.Write("x1 = ");
            x1 = double.Parse(Console.ReadLine());
            Console.Write("y1 = ");
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите кординаты A2");
            Console.Write("x2 = ");
            x2 = double.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите кординаты A3");
            Console.Write("x3 = ");
            x3 = double.Parse(Console.ReadLine());
            Console.Write("y3 = ");
            y3 = double.Parse(Console.ReadLine());
            A1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            A2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
            A3 = Math.Sqrt(Math.Pow(x3, 2) + Math.Pow(y3, 2));
            if (A1 > A2 & A1 > A3)
                Console.WriteLine("точка A1 дальше от начала координат");
            if (A2 > A1 & A2 > A3)
                Console.WriteLine("точка A2 дальше от начала координат");
            if (A3 > A1 & A3 > A2)
                Console.WriteLine("точка A3 дальше от начала координат");
            if (A1 == A2 & A1 == A3 & A2 == A3)
                Console.WriteLine("точки равноудалены от начала координат");
            if (A1 == A2)
                Console.WriteLine("точки A1 и A2 равноудалены от начала координат");
            if (A1 == A3)
                Console.WriteLine("точки A1 и A3 равноудалены от начала координат");
            if (A2 == A3)
                Console.WriteLine("точки A2 и A3 равноудалены от начала координат");
            Console.ReadKey();
        }
    }
}
