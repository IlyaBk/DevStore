using DevStore.Data.Interfaces;
using DevStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevStore.Controllers
{
    public class BooksController : Controller
    {
        private readonly IAllBook _AllBook;
        private readonly IBookCategory _AllBookCategory;

        public BooksController(IAllBook allBook, IBookCategory bookCategory)
        {
            ViewBag.Title = "Страница магазина";
            _AllBook = allBook;
            _AllBookCategory = bookCategory;
        }

        public ViewResult List()
        {
            BooksListViewModel obj = new BooksListViewModel();
            obj.AllBooks = _AllBook.Books;
            obj.CurrCategory = "Книги";
            return View (obj );
        }


    }
}
