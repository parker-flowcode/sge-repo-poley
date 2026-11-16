namespace Ejercicio4.Models
{
    public class clsPersona
    {
        public int IdPersona { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public int Edad { get; set; }
        public string Email { get; set; } = string.Empty;
        public int IdDepartamento { get; set; }
    }
}
