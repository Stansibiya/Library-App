using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Library.Infrastructure.Context;
using Library.core.Models;

namespace Library.web.DbInitialization
{
    public class DbInitialize : DropCreateDatabaseIfModelChanges<LibraryContext>
    {
        protected override void Seed(LibraryContext context)
        {

            context.books.Add(new Book()
            {
                Author = 1,
                BookId = 100,
                Title = "Once Upon a time",
                Year = "10 Juny 20+9"
            });
            context.books.Add(new Book()
            {
                Author = 2,
                BookId = 200,
                Title = "All Day",
                Year = "10 Juny 20+9"
            });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}