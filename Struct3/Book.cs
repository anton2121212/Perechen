using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct3
{
    public struct Book
    {
        public string title;
        public string authorName;
        public int yearPublished;
        public int pageCount;

        // Конструктор для инициализации полей
        public Book(string title, string authorName, int yearPublished, int pageCount)
        {
            this.title = title;
            this.authorName = authorName;
            this.yearPublished = yearPublished;
            this.pageCount = pageCount;
        }

        // Метод для вывода информации об объекте
        public void DisplayInfo()
        {
            Console.WriteLine("Название: " + title);
            Console.WriteLine("Автор: " + authorName);
            Console.WriteLine("Год издания: " + yearPublished);
            Console.WriteLine("Количество страниц: " + pageCount);
            Console.WriteLine();
        }
    }
}
