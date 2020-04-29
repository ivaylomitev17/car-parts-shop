using System;
using System.Collections.Generic;
using System.Text;
using carPartsShop.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace carPartsShop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }
        public DbSet<VehicleModel> VehicleModels { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

    }
}
