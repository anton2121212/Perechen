using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task44
{
    class Program
    {
        public delegate int Messege(int n,int m);
        static void Main(string[] args)
        {
            Messege messege;
            messege = Sum.Sum2;

            Console.WriteLine("Число 1");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Число 2");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Результат - {messege(n,m)}");

            Console.ReadKey();
        }
    }
}
