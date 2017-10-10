using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Library.Infrastructure.Repository;
using Library.core.Models;
using System.Data.Entity;
using Library.web.DbInitialization;

namespace Library.web.Controllers
{
    public class LibraryController : Controller
    {
        BookRepository repo = new BookRepository();

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Book bookModel)
        {
            if(ModelState.IsValid)
            {
                repo.CreateBook(bookModel);
                return RedirectToAction("BooksList");
            }
            else
            {
                return View();
            }
        }
        public ActionResult BooksList()
        {
            var bookList = repo.GetBookList();
            return View(bookList);
        }

        public ActionResult BookDetails(int Id)
        {
            var book = repo.GetSingleBook(Id);
            return View(book);
        }

        //Book Update
        [HttpGet]
        public ActionResult UpdateBook(int Id)
        {
            var book = repo.GetSingleBook(Id);
            return View(book);
        }
        [HttpPost]
        public ActionResult UpdateBook(Book bookModel)
        {
            if(ModelState.IsValid)
            {
                repo.UpdateBook(bookModel);
                return RedirectToAction("BookDetails");
            }
            else
            {
                return View();
            }
        }

        //Delete Book
        public ActionResult Delete( )
        {
            return View();
        }
        [HttpPost]
        public ActionResult Delete(int Id)
        {
            repo.RemoveBook(Id);
            return RedirectToAction("BookLIst");
        }

	}
}