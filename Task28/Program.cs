using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task28
{
    class Program
    {
        static void Main(string[] args)
        {
            Tour tour = new Tour();
            tour.Tour1();
            tour.Tour2("Молдова");
            tour.Tour3("Россия", 5);




            Console.ReadKey();
        }
    }
}
