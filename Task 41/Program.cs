using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_41
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point<int> point = new Point<int>(1,5);
            //point.Info();

            //Point<uint> point1 = new Point<uint>(2u, 4u);
            //point1.Info();

            //Point<double> point2 = new Point<double>(3.1, 5.4);
            //point2.Info();


            //Console.WriteLine("Введите сторону а");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Введите сторону b");
            //int b = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Введите сторону c");
            //int c = Convert.ToInt32(Console.ReadLine());

            Triangle<int> triangle = new Triangle<int>(2,3,4);
            triangle.Print();
            Console.WriteLine($"Площадь = {triangle.Area()}");

            Triangle<int> triangle1 = new Triangle<int>(2, 3, 4);
            triangle1.Print();
            Console.WriteLine($"Площадь = {triangle1.Area()}");

            Triangle<int> triangle2 = new Triangle<int>(2, 3, 4);
            triangle2.Print();
            Console.WriteLine($"Площадь = {triangle2.Area()}");

            Console.ReadKey();
        }
    }
}
