using Microsoft.EntityFrameworkCore;
using EstudiantesWebApp.Models;

namespace EstudiantesWebApp.Data
{
    /*Esta clase representa el contexto de la base de datos para la aplicación*/
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        /*Esto representa una tabla en la base de datos que contiene
                una colección de objetos Estudiante.*/
        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}
