using Microsoft.EntityFrameworkCore;

namespace NSK_Food_City.Database
{
    public class NSKDbContext :DbContext
    {
        public NSKDbContext(DbContextOptions<NSKDbContext> options) : base (options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
