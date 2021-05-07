using DevStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevStore.Data.Interfaces
{
    public interface IBookCategory
    {
        IEnumerable<Category> AllCatigories { get; }
    }
}
