using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store
{
    internal class CustomerManager
    {
        List<Book> book = new List<Book>();

        public CustomerManager()
        {
            book = new List<Book>()
            {
                new Book{bookName = "Suç ve Ceza",bookPage = 350,bookPrice=25,bookStatus="Sıfır",bookType="Roman"}
            };
        }

        public List<Book> GetAll()
        {

            return book;
        }

        public void Add(Book _book)
        {
            book.Add(_book);
        }
        public void Remove(Book _book)
        {
            book.Remove(_book);
        }
    }
}
