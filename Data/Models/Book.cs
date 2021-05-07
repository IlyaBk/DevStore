using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevStore.Data.Models
{
     public class Book
    {
        public int IdBook { get; set; }
        public string NameBook { get; set; }
        public string ShortDesc { get; set; }
        public string LongSesc { get; set; }
        public string Img { get; set; }
        public float Price { get; set; }
        public bool IsFavorite { get; set; }
        public int Available { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

    }
}
