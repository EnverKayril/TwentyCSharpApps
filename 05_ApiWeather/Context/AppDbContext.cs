using _05_ApiWeather.Entities;
using Microsoft.EntityFrameworkCore;

namespace _05_ApiWeather.Context
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ENVER\\SQLEXPRESS01; Database=20ProjectF; Trusted_Connection=True; TrustServerCertificate=True;");
        }

        public DbSet<City> Cities { get; set; }
    }
}
