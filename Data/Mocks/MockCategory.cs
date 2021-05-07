using DevStore.Data.Interfaces;
using DevStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevStore.Data.Mocks
{
    public class MockCategory :IBookCategory

    {
        public IEnumerable<Category> AllCatigories
        {
            get
            {
                return new List<Category>
                {
                    new Category 
                    { 
                        CategoryName = "Бумажная книга", 
                        DescCategory = "Книга в бумажном виде" 
                    },
                    new Category 
                    { 
                        CategoryName = "Электронная книга", 
                        DescCategory = "Книга в электронном виде" 
                    }
                };
            }
        }
    }
}

