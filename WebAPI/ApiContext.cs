using Microsoft.EntityFrameworkCore;

namespace WebAPI
{
    public class ApiContext: DbContext
    {
        public DbSet<WeatherForecast> WeatherForecasts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source=forecasts.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WeatherForecast>().HasKey(x => x.Id);
            base.OnModelCreating(modelBuilder);
        }
    }
}
