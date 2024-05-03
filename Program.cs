using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perech_Pr_03._05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину первой стороны прямоугольника:");
            double side1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите длину второй стороны прямоугольника:");
            double side2 = double.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(side1, side2);

            Console.WriteLine($"Периметр прямоугольника: {rectangle.Perimeter}");
            Console.WriteLine($"Площадь прямоугольника: {rectangle.Area}");

            Console.ReadKey();
        
        }
    }
}
