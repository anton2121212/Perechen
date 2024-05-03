using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_2
{
    class Author
    {
        private string author;

        public Author(string author)
        {
            author = author;
        }

        public void Show()
        {
            Console.WriteLine($"Имя автора: {author}");
        }
    }
}
