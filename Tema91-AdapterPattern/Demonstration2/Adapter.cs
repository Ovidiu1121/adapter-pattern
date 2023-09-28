using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema91_AdapterPattern.Demonstration2
{
    public class Adapter : IBook
    {
        private IEBook ebook;

        public Adapter(IEBook ebook)
        {
            this.ebook = ebook;
        }

        public string GetAuthor()
        {
            return this.ebook.GetEBookAuthor();
        }

        public string GetTitle()
        {
            return this.ebook.GetEBookTitle();
        }
    }
}
