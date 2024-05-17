using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание массива из n книг
            int n = 3; 

            Book[] books = new Book[n];
            books[0] = new Book("Война и мир", "Лев Толстой", 1869, 1225);
            books[1] = new Book("Преступление и наказание", "Федор Достоевский", 1866, 671);
            books[2] = new Book("1984", "Джордж Оруэлл", 1949, 328);

            // Вывод полной информации обо всех книгах
            Console.WriteLine("Информация о книгах:");
            foreach (var book in books)
            {
                book.DisplayInfo();
            }
            Console.ReadKey();
        }
    }
}
