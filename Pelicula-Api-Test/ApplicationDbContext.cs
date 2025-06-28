using Microsoft.EntityFrameworkCore;
using Pelicula_Api_Test.Entidad;

namespace Pelicula_Api_Test
{
    public class ApplicationDbContext : DbContext
    {
       

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Genero> Generos { get; set; }
    }
}
