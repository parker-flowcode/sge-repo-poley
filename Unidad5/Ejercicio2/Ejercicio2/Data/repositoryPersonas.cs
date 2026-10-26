using Ejercicio2;

namespace Ejercicio2.Data
{
    public class repositoryPersonas
    {
        public IEnumerable<clsPersona> ObtenerPersonas()
        {
            return new List<clsPersona>
            {
                new clsPersona { Nombre = "Ana", Apellidos = "García", FechaNacimiento = new DateTime(2004, 5, 12) },
                new clsPersona { Nombre = "Luis", Apellidos = "Martínez", FechaNacimiento = new DateTime(2003, 8, 3) },
                new clsPersona { Nombre = "María", Apellidos = "López", FechaNacimiento = new DateTime(2005, 1, 20) },
                new clsPersona { Nombre = "Carlos", Apellidos = "Sánchez", FechaNacimiento = new DateTime(2002, 11, 30) },
                new clsPersona { Nombre = "Lucía", Apellidos = "Fernández", FechaNacimiento = new DateTime(2004, 3, 9) },
                new clsPersona { Nombre = "Javier", Apellidos = "Ruiz", FechaNacimiento = new DateTime(2003, 7, 17) },
                new clsPersona { Nombre = "Elena", Apellidos = "Gómez", FechaNacimiento = new DateTime(2005, 12, 5) },
                new clsPersona { Nombre = "Pablo", Apellidos = "Torres", FechaNacimiento = new DateTime(2002, 2, 28) },
                new clsPersona { Nombre = "Sara", Apellidos = "Ramírez", FechaNacimiento = new DateTime(2004, 9, 14) },
                new clsPersona { Nombre = "Miguel", Apellidos = "Vega", FechaNacimiento = new DateTime(2003, 6, 1) }
            };
        }
    }
}