using KevArt.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace KevArt.Database
{
    public class DataContext : DbContext
    {

        protected readonly IConfiguration Configuration;
        public DbSet<Product> Products { get; set; }
        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server database
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));

        }

        
    }
}