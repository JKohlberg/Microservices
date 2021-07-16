using Microsoft.EntityFrameworkCore;
using OrderMicroservice.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderMicroservice.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Order> orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=OrderMicroservice;Integrated Security=True");
        }
    }
}
