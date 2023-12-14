using System.Data.Entity;
namespace _4_tema_praktika.Models.Data
{
    public class CustomerDbContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<Table> Table { get; set; }

    }
}
