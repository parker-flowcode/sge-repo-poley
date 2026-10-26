using System;
using System.Collections.Generic;
using Ejercicio2.Data;


namespace Ejercicio2
{
    internal class Program
    {
        private static void Main()
        {
            var repositoryAlumno = new repositoryAlumnos();
            var alumnos = repositoryAlumno.ObtenerAlumnos();
            var repositoryPersonas = new repositoryPersonas();
            var personas = repositoryPersonas.ObtenerPersonas();
            MostrarPersonas(personas);
            MostrarAlumnos(alumnos);

        }

        private static void MostrarPersonas(IEnumerable<clsPersona> personas)
        {
            Console.WriteLine("Listado de personas:");
            int i = 1;
            foreach (var a in personas)
            {
                Console.WriteLine($"{i++}. {a.Nombre} {a.Apellidos} - Nac: {a.FechaNacimiento:dd/MM/yyyy} - Edad: {a.Edad}");
            }
        }

        private static void MostrarAlumnos(IEnumerable<clsAlumno> alumnos)
        {
            Console.WriteLine("Listado de alumnos:");
            int i = 1;
            foreach (var a in alumnos)
            {
                Console.WriteLine($"{i++}. {a.Nombre} {a.Apellidos} - Nac: {a.FechaNacimiento:dd/MM/yyyy} - Edad: {a.Edad} - Curso: {a.Curso} - Numero Expediente: {a.NumeroExpediente}");
            }
        }
    }
}
