using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task40
{
    class Program
    {
        public delegate double Messege(int n,int m);
        static void Main(string[] args)
        {
            Messege messege;
            messege = Class.Averege;

            Console.WriteLine("ОТ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ДО");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Среднее ар-е = {messege(n,m)}");

            Console.ReadKey();
        }
    }
}
