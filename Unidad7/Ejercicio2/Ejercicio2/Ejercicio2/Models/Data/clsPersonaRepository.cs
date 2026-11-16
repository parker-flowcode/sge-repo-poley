using Ejercicio2.Models.Entities;

namespace Ejercicio2.Models.Data;

public static class clsPersonaRepository
{
    public static List<clsPersona> ObtenerPersonas()
    {
        return new List<clsPersona>
        {
            new() { Nombre = "Ana", Apellidos = "García López", Edad = 28, Email = "ana.garcia@ejemplo.com" },
            new() { Nombre = "Luis", Apellidos = "Martínez Ruiz", Edad = 35, Email = "luis.martinez@ejemplo.com" },
            new() { Nombre = "Marta", Apellidos = "Sánchez Pérez", Edad = 24, Email = "marta.sanchez@ejemplo.com" },
            new() { Nombre = "Carlos", Apellidos = "Fernández Díaz", Edad = 42, Email = "carlos.fernandez@ejemplo.com" },
            new() { Nombre = "Laura", Apellidos = "Gómez Torres", Edad = 31, Email = "laura.gomez@ejemplo.com" },
            new() { Nombre = "Pablo", Apellidos = "Navarro Martín", Edad = 26, Email = "pablo.navarro@ejemplo.com" }
        };
    }
}
