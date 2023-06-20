
using Microsoft.EntityFrameworkCore;
using Entities.Models;
namespace StoreApp.Models
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; } //Product modelinde olan alanları Products tablosuna at

        public RepositoryContext(DbContextOptions<RepositoryContext> options) //veritabanını dizesine gitmek üzere bağlantı dizesi RepositoryContext
        : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
            .HasData(

                new Product() { ProductId = 1, ProductName = "Computer", Price = 17_000 },
                new Product() { ProductId = 2, ProductName = "Keyboard", Price = 18_000 },
                new Product() { ProductId = 3, ProductName = "Mouse", Price = 19_000 },
                new Product() { ProductId = 4, ProductName = "Monitor", Price = 19_000 },
                new Product() { ProductId = 5, ProductName = "Deck", Price = 20_000 }

            );
        }
    }
}
