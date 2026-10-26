using Ejercicio2;

namespace Ejercicio2.Data
{
    public class repositoryAlumnos
    {
        public IEnumerable<clsAlumno> ObtenerAlumnos()
        {
            return new List<clsAlumno>
            {
                new clsAlumno { Nombre = "Ana", Apellidos = "García", FechaNacimiento = new DateTime(2004, 5, 12), Curso = "Bachillerato", NumeroExpediente = 1 },
                new clsAlumno { Nombre = "Pedro", Apellidos = "Poley", FechaNacimiento = new DateTime(2007, 7, 15), Curso = "ESO", NumeroExpediente = 2 },
                new clsAlumno { Nombre = "Miguel", Apellidos = "Laso", FechaNacimiento = new DateTime(2007, 12, 20), Curso = "Grado Superior DAM", NumeroExpediente = 3 }

            };
        }
    }
}
