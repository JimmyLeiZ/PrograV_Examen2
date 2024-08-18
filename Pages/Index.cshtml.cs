using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EstudiantesWebApp.Data;
using EstudiantesWebApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstudiantesWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]

        // Propiedad enlazada que contiene la lista de estudiantes que se mostrará en la página.

        public List<Estudiante> DetalleEstudiantes { get; set; }

        // Método que se ejecuta en la solicitud GET, recuperando los estudiantes desde la base de datos.
        public async Task OnGetAsync()
        {
            try
            {
                 // Recupera todos los estudiantes y los asigna a la propiedad DetalleEstudiantes.
                DetalleEstudiantes = await _context.Estudiantes.ToListAsync();
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error si falla la conexión
                ModelState.AddModelError(string.Empty, "No se pudo recuperar la información de la base de datos. Por favor, intente nuevamente más tarde.");
                Console.WriteLine("Error al acceder a la base de datos: " + ex.Message);

                // Manejo alternativo: Inicializar una lista vacía para evitar errores en la vista
                DetalleEstudiantes = new List<Estudiante>();
            }
        }
 // Método que se ejecuta en la solicitud POST, en este caso, simplemente recarga la lista de estudiantes.
        public async Task OnPostAsync()
        {
            try
            {
                // Recupera todos los estudiantes y los asigna a la propiedad DetalleEstudiantes.
                DetalleEstudiantes = await _context.Estudiantes.ToListAsync();
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error si falla la conexión
                ModelState.AddModelError(string.Empty, "No se pudo recuperar la información de la base de datos. Por favor, intente nuevamente más tarde.");
                Console.WriteLine("Error al acceder a la base de datos: " + ex.Message);

                // Manejo alternativo: Inicializar una lista vacía para evitar errores en la vista
                DetalleEstudiantes = new List<Estudiante>();
            }
        }
    }
}

        
    
