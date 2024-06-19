using Microsoft.EntityFrameworkCore;
using SegundoParcial.Entities;

namespace SegundoParcial
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        
        public DbSet<Juguete> juguete { get; set; }

        public DbSet<Marca> marca { get; set; }

    }
}