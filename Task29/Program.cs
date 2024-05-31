using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task29
{
    class Program
    {
        static void Main(string[] args)
        {
            Tovar tovar = new Tovar("Яблоки",14, 9);
            Tovar tovar1 = new Tovar("Апельсины",3,6);
            Console.WriteLine($"Стоимость всех яблок= {tovar.Sum()}");
            Console.WriteLine($"Стоимость всех апельсинов= {tovar1.Sum()}");
            Console.WriteLine($"Сумма = {tovar.Sum()+ tovar1.Sum()}");

            Console.ReadKey();
        }
    }
}
