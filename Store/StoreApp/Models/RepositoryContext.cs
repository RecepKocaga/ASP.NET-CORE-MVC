
using Microsoft.EntityFrameworkCore;

namespace StoreApp.Models
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; } //Product modelinde olan alanları Products tablosuna at
        
        public RepositoryContext(DbContextOptions<RepositoryContext> options)
        :base(options)
        {
              
        }
    }
}
