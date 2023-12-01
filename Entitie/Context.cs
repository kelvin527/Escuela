using Microsoft.EntityFrameworkCore;

namespace Escuela.Entitie
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Maestro> Maestro { get; set; }
        public DbSet<Alumno> Alumno { get; set; }
        public DbSet<Calificaciones> Calificaciones { get; set; }
        public DbSet<Materia> Materia { get; set; }
    }
}
