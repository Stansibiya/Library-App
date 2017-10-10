using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.core.Models;

namespace Library.core.Interfaces
{
    public interface IBookRepository
    {
        void CreateBook(Book bookModel);
        void RemoveBook(int Id);
        void UpdateBook(Book bookModel);
        IEnumerable<Book> GetBookList();
        Book GetSingleBook(int Id);
    }
}
