using DevStore.Data.Interfaces;
using DevStore.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevStore.Data.Repository
{
    public class BookRepository : IAllBook
    {
        public BookRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        private readonly AppDBContent appDBContent;

        public IEnumerable<Book> Books => appDBContent.Book.Include(c => c.Category);
        public IEnumerable<Book> getFavBooks => appDBContent.Book.Where(p => p.IsFavorite).Include(c => c.Category);
        public Book getObjectBook(int BookId) => appDBContent.Book.FirstOrDefault(p => p.IdBook == BookId);
    }
}
