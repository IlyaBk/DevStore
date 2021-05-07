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
                        NameBook = "Идеальный программист",
                        ShortDesc = "Как стать профессионалом разработки ПО",
                        AuthorBook = "Роберт Мартин",
                        PublishingHouse = "Питер",
                        LongDesc = "Книга насыщена практическими советами в отношении всех аспектов программирования: от оценки проекта и написания кода до рефакторинга и тестирования. Эта книга - больше, чем описание методов, она о профессиональном подходе к процессу разработки.",
                        Img ="/img/3book.jpg",
                        Price = 840f,
                        IsFavorite = true,
                        StockaResidue = 1,
                        CategoryID = 1,
                        Category = bookCategory.AllCatigories.First()
                    },                    
                    new Book
                    {
                        NameBook = "Чистый Agile",
                        ShortDesc = "Основы гибкости",
                        AuthorBook = "Роберт Мартин",
                        PublishingHouse = "Питер",
                        LongDesc = "По сути Agile - это всего лишь небольшая подборка методов и инструментов, помогающая небольшим командам программистов управлять небольшими проектами,… но приводящая к большим результатам, потому что каждый крупный проект состоит из огромного количества кирпичиков.",
                        Img ="/img/4book.jpg",
                        Price = 1400f,
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
                        LongDesc = "Роберт Мартин дает прямые и лаконичные ответы на ключевые вопросы архитектуры и дизайна. Чистую архитектуру обязаны прочитать разработчики всех уровней, системные аналитики, архитекторы и каждый программист, который желает подняться по карьерной лестнице или хотя бы повлиять на людей, которые занимаются данной работой. Все архитектуры подчиняются одним и тем же правилам! Роберт Мартин (дядюшка Боб)",
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
