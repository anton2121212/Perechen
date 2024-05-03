using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Title title = new Title("Война и мир");
            Author author = new Author("Лев Толстой");
            Content content = new Content("Война и мир - это роман-эпопея Льва Толстого, впервые опубликованный в 1869 году.");

            Book book = new Book();
            book.AddTitle(title);
            book.AddAuthor(author);
            book.AddContent(content);

            Console.ForegroundColor = ConsoleColor.Blue;
            title.Show();

            Console.ForegroundColor = ConsoleColor.Green;
            author.Show();

            Console.ForegroundColor = ConsoleColor.Red;
            content.Show();
        }
    }
}
