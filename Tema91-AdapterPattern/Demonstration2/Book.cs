using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema91_AdapterPattern.Demonstration2
{
    public class Book:IBook
    {
        private string title;
        private string author;

        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        public string GetTitle()
        {
            return this.title;
        }

        public string GetAuthor()
        {
            return this.author;
        }
    }
}
