namespace Ejercicio1.Models
{

    public class clsPersona
    {
        private string nombre;

        private string apellidos;

        private int edad;

        private int bodycount;

        public clsPersona(string nombre, string apellidos, int edad, int bodycount)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.edad = edad;
            this.bodycount = bodycount;
        }

    }
}
