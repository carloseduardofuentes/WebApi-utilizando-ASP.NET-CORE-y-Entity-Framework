using WebApi_CargoWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApi_CargoWeb.Data
{
    public class CargoContext : DbContext
    {
        public CargoContext(DbContextOptions<CargoContext> options) : base(options)
        {

        }

        public DbSet<Pais> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pais>().ToTable("TPais");
            
        }
    }
}
