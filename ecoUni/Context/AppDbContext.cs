using ecoUni.Models;
using Microsoft.EntityFrameworkCore;

namespace ecoUni.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Coleta> Coletas { get; set; }
    }
}
        