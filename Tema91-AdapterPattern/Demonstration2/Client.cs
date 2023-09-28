using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema91_AdapterPattern.Demonstration2
{
    public class Client
    {
        public Client()
        {
            IBook book = new Book("The Great Gatsby", "F. Scott Fitzgerald");
            IEBook ebook = new EBook("The Catcher in the Rye", "J.D. Salinger");

            IBook adapter = new Adapter(ebook);

            Console.WriteLine("Book title: " + book.GetTitle());
            Console.WriteLine("Book author: " + book.GetAuthor()+"\n");

            Console.WriteLine("EBook title: " + adapter.GetTitle());
            Console.WriteLine("EBook author: " + adapter.GetAuthor());
        }
    }
}
