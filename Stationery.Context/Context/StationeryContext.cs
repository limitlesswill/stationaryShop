using Microsoft.EntityFrameworkCore;
using Models.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stationery.Context.Context
{
    public class StationeryContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        //public DbSet<Admin> Admins { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Stationery2;Integrated Security=True;" +
                                      "Trust Server Certificate=True");
        }
    }

}
