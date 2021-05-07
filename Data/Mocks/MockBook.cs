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
                        NameBook = "Чистый код",
                        ShortDesc = "Исскувство разработки ПО",
                        AuthorBook = "Роберт Мартин",
                        PublishingHouse = "Питер",
                        LongDesc = "***",
                        Img ="/img/2book.jpg",
                        Price = 900f,
                        IsFavorite = true,
                        StockaResidue = 2,
                        CategoryID = 1,
                        Category = bookCategory.AllCatigories.First()
                    },                    
                    new Book
                    {
                        NameBook = "Чистая архитектура",
                        ShortDesc = "Исскувство разработки ПО",
                        AuthorBook = "Роберт Мартин",
                        PublishingHouse = "Питер",
                        LongDesc = "Роберт Мартин дает прямые и лаконичные ответы на ключевые вопросы архитектуры и дизайна. " +
                        "Чистую архитектуру обязаны прочитать разработчики всех уровней, системные аналитики, архитекторы и каждый программист, " +
                        "который желает подняться по карьерной лестнице или хотя бы повлиять на людей, которые занимаются данной работой." +
                        "Все архитектуры подчиняются одним и тем же правилам! Роберт Мартин (дядюшка Боб)",
                        Img ="/img/1book.jpg",
                        Price = 1500f,
                        IsFavorite = true,
                        StockaResidue = 3,
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
