using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_2
{
    class Book
    {
        private Title title;
        private Author author;
        private Content content;

        public void AddTitle(Title title)
        {
            title = title;
        }

        public void AddAuthor(Author author)
        {
            author = author;
        }

        public void AddContent(Content content)
        {
            content = content;
        }
    }
}
