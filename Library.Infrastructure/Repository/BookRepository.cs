using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.core.Interfaces;
using Library.Infrastructure.Context;
using Library.core.Models;

namespace Library.Infrastructure.Repository
{
    public class BookRepository : IBookRepository
    {
        LibraryContext dbContext = new LibraryContext();
        public void CreateBook(Book bookModel)
        {
            dbContext.books.Add(bookModel);
            dbContext.SaveChanges();
        }

        public void RemoveBook(int Id)
        {
            Book book = dbContext.books.Find(Id);
            dbContext.books.Remove(book);
            dbContext.SaveChanges();
        }

        public void UpdateBook(core.Models.Book bookModel)
        {
            dbContext.Entry(bookModel).State = System.Data.Entity.EntityState.Modified;
            dbContext.SaveChanges();
        }

        public IEnumerable<Book> GetBookList()
        {
            return dbContext.books.ToList();
        }

        public Book GetSingleBook(int Id)
        {
            return dbContext.books.Find(Id);
        }
    }
}
