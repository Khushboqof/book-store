using BookStore.Domain.Entities.Books;
using BookStore.Domain.Entities.Orders;
using BookStore.Domain.Entities.Ordersr;
using BookStore.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data.DbContexts
{
    public class AppDbContext : DbContext
    {
        public virtual DbSet<Book> Books { get; set; } = null!;
        public virtual DbSet<Publisher> Publishers { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderDetails> OrderDetails { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost; Port=5432; Database=book-store-db; User Id=postgres; Password=2003");
        }
    }
}
