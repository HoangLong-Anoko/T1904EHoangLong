using Microsoft.EntityFrameworkCore;


namespace MVC_Core.Models
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
        {

        }

        public DbSet<Employees> Employees { get; set; }
    }
}
