using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure(new Point(5, 5, "A"), new Point(10, 10, "B"), new Point(15, 15, "C"));
            Console.WriteLine(figure.Perimeter());

            Figure figure1 = new Figure(new Point(5, 5, "A"), new Point(10, 10, "B"), new Point(15, 15, "C"), new Point(20, 20, "D"));
            Console.WriteLine(figure1.Perimeter());

            Figure figure2 = new Figure(new Point(5, 5, "A"), new Point(10, 10, "B"), new Point(15, 15, "C"), new Point(20, 20, "D"), new Point(25, 25, "E"));
            Console.WriteLine(figure2.Perimeter());

            Console.ReadKey();
        }
    }
}
