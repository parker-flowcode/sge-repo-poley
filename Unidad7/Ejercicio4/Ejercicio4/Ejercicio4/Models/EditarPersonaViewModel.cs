namespace Ejercicio4.Models
{
    public class EditarPersonaViewModel
    {
        public clsPersona Persona { get; set; } = new();
        public IReadOnlyList<clsDepartamento> Departamentos { get; set; } = [];
    }
}
