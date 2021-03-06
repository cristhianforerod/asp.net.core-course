using Microsoft.EntityFrameworkCore;

namespace App2.Models
{
    public class EscuelaContext : DbContext
    {
        public DbSet<Escuela> Escuelas { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Evaluación> Evaluaciones { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }

        public EscuelaContext(DbContextOptions<EscuelaContext> options) : base(options)
        {
            
        }

    }
}