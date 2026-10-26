using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio2
{
    public class clsAlumno : clsPersona
    {
        public string Curso { get; set; } = string.Empty;

        public int NumeroExpediente { get; set; }


        //public clsAlumno(string nombre, string apellidos,DateTime fechaNacimiento, string curso, int numeroExpediente): base( nombre,  apellidos, fechaNacimiento) { 
            
        //    Nombre = nombre;
        //    Apellidos = apellidos;
        //    FechaNacimiento = fechaNacimiento;
        //    Curso = curso;
        //    NumeroExpediente = numeroExpediente;

        //}

    }

}
