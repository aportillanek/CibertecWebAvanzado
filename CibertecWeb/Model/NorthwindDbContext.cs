using Microsoft.EntityFrameworkCore;

namespace CibertecWeb.Model
{
    public class NorthwindDbContext:DbContext
    {
        
        public NorthwindDbContext(DbContextOptions<NorthwindDbContext> options):base(options)
        {
           
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Order>().ToTable("Order");
        }



    }
}
