using DevStore.Data.Interfaces;
using DevStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevStore.Data.Repository
{
    public class CategoryRepository : IBookCategory
    {
        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        private readonly AppDBContent appDBContent;

        public IEnumerable<Category> AllCatigories => appDBContent.Category;
    }
}
