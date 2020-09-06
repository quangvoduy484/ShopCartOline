using Microsoft.EntityFrameworkCore;
using Project.Core.Entities;
using System;

namespace Project.Data.ShopCartContext
{
    public class ShopCartContext : DbContext
    {
        public ShopCartContext(DbContextOptions<ShopCartContext> options) : base(options)
        { 
            
        
        }

        public DbSet<User> Blogs { get; set; }

    }
}
