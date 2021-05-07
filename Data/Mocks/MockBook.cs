using DevStore.Data.Interfaces;
using DevStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevStore.Data.Mocks
{
    public class MockBook :IAllBook
    {
        private readonly IBookCategory bookCategory = new MockCategory ( );
        public IEnumerable<Book> Books 
        {
            get
            {
                return new List<Book>
                {
                    new Book
                    {
                        NameBook = "тест",
                        ShortDesc = "***",
                        LongSesc = "***",
                        Img ="/img/book.png",
                        Price = 1250f,
                        IsFavorite = true,
                        Available = 3,
                        CategoryID = 1,
                        Category = bookCategory.AllCatigories.First()
                    }
                };
            }
            set { }
        }
        public IEnumerable<Book> getFavBooks { get; set; }

        public Book getObjectBook(int BookId)
        {
            throw new NotImplementedException ( );
        }
    }
}
