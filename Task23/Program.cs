using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string stroka = Console.ReadLine();
            Console.WriteLine("Каким цветом вывести текст?");
            foreach(Pattern.Colors c in Enum.GetValues(typeof(Pattern.Colors)))
            {
                Console.WriteLine($"{(int)c} - {c}");
            }
            Console.WriteLine("Введите цифру цвета: ");
            int color = int.Parse(Console.ReadLine());
            Pattern.Print(stroka, color);
            Console.ReadLine();
        }
    }
}
