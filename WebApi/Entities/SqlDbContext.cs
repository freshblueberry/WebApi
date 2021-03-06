using Microsoft.EntityFrameworkCore;


namespace WebApi.Entities
{
    public class SqlDbContext : DbContext
    {
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Review> Review { get; set; }

        public SqlDbContext(DbContextOptions<SqlDbContext> options)
        : base(options)
        {
        }
    }
}
