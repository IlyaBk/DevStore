using DevStore.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevStore.Data
{
    public class AppDBContent:DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options):base(options)
        {
            
        }
        public DbSet<Book> Book { get; set; }
        public DbSet<Category> Category { get; set; }
}
}
