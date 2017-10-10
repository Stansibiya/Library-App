using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Library.core.Models;

namespace Library.Infrastructure.Context
{
    public class LibraryContext : DbContext
    {
        public LibraryContext() :
            base("name = LibraryDbConnection")
        {
        }
        public DbSet<Book> books { get; set; }
    }
}
