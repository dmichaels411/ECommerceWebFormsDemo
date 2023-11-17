using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ECommerceWebFormsDemo.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("ECommerceWebFormsDemo") { }

        public DbSet<Product> Products { get; set;}

        public DbSet<Category> Categories { get; set;}

        public DbSet<CartItem> CartItems { get; set;}
    }
}