using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task37
{
    class Program
    {
        public delegate double Messege(double a, double b, double c);
        static void Main(string[] args)
        {
            //2 Создание обьекта делегата
            Messege messege;
            //3 присвоение указателя наметод
            messege = Tringle.S;

            Console.WriteLine("Введите сторону а:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону c:");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"S = {messege(a,b,c)}");
            Console.ReadKey();
        }
    }
}
