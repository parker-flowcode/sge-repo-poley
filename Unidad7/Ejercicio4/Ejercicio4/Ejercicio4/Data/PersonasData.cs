using Ejercicio4.Models;

namespace Ejercicio4.Data
{
    public static class PersonasData
    {
        private static readonly Random random = new();

        private static readonly List<clsDepartamento> departamentos =
        [
            new clsDepartamento { IdDepartamento = 1, NombreDepartamento = "Informática" },
            new clsDepartamento { IdDepartamento = 2, NombreDepartamento = "Recursos Humanos" },
            new clsDepartamento { IdDepartamento = 3, NombreDepartamento = "Marketing" },
            new clsDepartamento { IdDepartamento = 4, NombreDepartamento = "Contabilidad" }
        ];

        private static readonly List<clsPersona> personas =
        [
            new clsPersona { IdPersona = 1, Nombre = "Ana", Apellidos = "García López", Edad = 28, Email = "ana.garcia@empresa.com", IdDepartamento = 1 },
            new clsPersona { IdPersona = 2, Nombre = "Luis", Apellidos = "Martínez Ruiz", Edad = 35, Email = "luis.martinez@empresa.com", IdDepartamento = 2 },
            new clsPersona { IdPersona = 3, Nombre = "Marta", Apellidos = "Sánchez Martín", Edad = 31, Email = "marta.sanchez@empresa.com", IdDepartamento = 3 },
            new clsPersona { IdPersona = 4, Nombre = "Jorge", Apellidos = "Pérez Díaz", Edad = 42, Email = "jorge.perez@empresa.com", IdDepartamento = 4 },
            new clsPersona { IdPersona = 5, Nombre = "Elena", Apellidos = "Navarro Gómez", Edad = 26, Email = "elena.navarro@empresa.com", IdDepartamento = 1 }
        ];

        public static IReadOnlyList<clsPersona> ObtenerPersonas() => personas;

        public static IReadOnlyList<clsDepartamento> ObtenerDepartamentos() => departamentos;

        public static clsPersona ObtenerPersonaAleatoria()
        {
            var posicion = random.Next(personas.Count);
            return personas[posicion];
        }
    }
}
