using Microsoft.EntityFrameworkCore;
using Soonet.Models;

namespace Soonet.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; } 
        public DbSet<Calificacion> Calificacion { get; set; } 
        public DbSet<ProveedorServicios> ProveedorServicios { get; set; } 
        public DbSet<SeccionServicio> SeccionServicio { get; set; } 
        public DbSet<Servicio> Servicio { get; set; } 
    }
}
