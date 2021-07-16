using Microsoft.EntityFrameworkCore;
using ProductService.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductService.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Product> Prodcuts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=ProductMicroservice;Integrated Security=True");
        }
    }
}
