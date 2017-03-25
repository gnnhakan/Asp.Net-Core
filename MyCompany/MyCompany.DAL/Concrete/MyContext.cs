using Microsoft.EntityFrameworkCore;
using MyCompany.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.DAL.Concrete
{
    public class MyContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=WIN-4CN623OQMH5\\SQLEXPRESS2012;Database=Northwind;user=sa;pwd=******");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        //more Set Dbset
    }
}
