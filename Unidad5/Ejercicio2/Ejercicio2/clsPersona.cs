using System;

namespace Ejercicio2
{
    public class clsPersona
    {
        public string Nombre { get; set; } = string.Empty;

        public string Apellidos { get; set; } = string.Empty;

        public DateTime FechaNacimiento { get; set; }

        // Edad calculada a partir de FechaNacimiento
        public int Edad
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - FechaNacimiento.Year;
                if (FechaNacimiento.Date > today.AddYears(-age)) age--;
                return age;
            }
        }
    }
}
