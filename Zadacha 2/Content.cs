using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_2
{
    class Content
    {
        private string content;

        public Content(string content)
        {
            content = content;
        }

        public void Show()
        {
            Console.WriteLine($"Содержание книги: {content}");
        }
    }
}
