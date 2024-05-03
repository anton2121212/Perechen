using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_2
{
    class Title
    {
        private string title;

        public Title(string title)
        {
            title = title;
        }

        public void Show()
        {
            Console.WriteLine($"Название книги: {title}");
        }
    }
}
