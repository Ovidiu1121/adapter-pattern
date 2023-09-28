using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema91_AdapterPattern.Demonstration2
{
    public class EBook:IEBook
    {
        private string ebookTitle;
        private string ebookAuthor;

        public EBook(string ebookTitle, string ebookAuthor)
        {
            this.ebookTitle = ebookTitle;
            this.ebookAuthor = ebookAuthor;
        }

        public string GetEBookTitle()
        {
            return this.ebookTitle;
        }

        public string GetEBookAuthor()
        {
            return this.ebookAuthor;
        }
    }
}
