using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CodeAcademy.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = config.GetSection("ConnectionStrings:DefaultConnection").Value;
        }
    }
}
