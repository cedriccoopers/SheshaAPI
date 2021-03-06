using Microsoft.EntityFrameworkCore;

namespace SheshaAPI.Models
{
    public class SheshaContext : DbContext
    {
        public SheshaContext(DbContextOptions<SheshaContext> options) : base(options)
        {
        }

        public DbSet<City> City { get; set; }

        public DbSet<Province> Province { get; set; }

        public DbSet<Users> Users { get; set; }

        public DbSet<Suppliers> Suppliers { get; set; }
    }
}