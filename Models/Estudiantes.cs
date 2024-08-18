namespace EstudiantesWebApp.Models
{
    // Esta clase representa la estructura de los datos
    // que se almacenarán en la base de datos.
    public class Estudiante
    {
        // La propiedad ID actúa como la clave primaria para identificar de manera única
        // a cada estudiante en la base de datos.
        public int ID { get; set; }

        // Propiedad que almacena el nombre del estudiante.
        public string Nombre { get; set; }

        // Propiedad que almacena el apellido del estudiante.
        public string Apellido { get; set; }

        // Propiedad que almacena la edad del estudiante.
        public int Edad { get; set; }

        // Propiedad que almacena el correo electrónico del estudiante.
        public string Correo { get; set; }
    }
}
