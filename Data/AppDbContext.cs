using Microsoft.EntityFrameworkCore;

namespace ValeAtivos32427421.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Models.Equipamento> Equipamentos {get; set;}
    
    }
}