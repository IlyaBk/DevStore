using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevStore.Data.Models
{
     public class Book
    {
        //ид книги
        [Key]
        public int IdBook { get; set; }
        //название
        public string NameBook { get; set; }
        //автор книги
        public string AuthorBook { get; set; }
        //издательство
        public string PublishingHouse { get; set; }
        //короткое описание
        public string ShortDesc { get; set; }
        //длинное описание
        public string LongDesc { get; set; }

        public string Img { get; set; }
        //цена
        public float Price { get; set; }
        //популярность
        public bool IsFavorite { get; set; }
        //остаток на складе
        public int StockaResidue { get; set; }
        //ид категории
        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }

    }
}
