using DevStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevStore.Data.Interfaces
{
    public interface IAllBook
    {
        IEnumerable<Book> Books { get; }
        IEnumerable<Book> getFavBooks { get;}
        Book getObjectBook(int BookId);

    }
}
