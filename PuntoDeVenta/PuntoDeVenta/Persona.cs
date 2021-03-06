using System;
using System.Collections.Generic;
using System.Text;

namespace PuntoDeVenta
{
    class Persona
    {
        //PROPERTIES
        public int IdPersona { get; protected set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public DateTime FechaNacimiento { get; set; }
        //CONSTRUCTOR
        public Persona() { }
        public Persona( string nombre, string apellido, int dni, DateTime fechaNacimiento)
        {            
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            FechaNacimiento = fechaNacimiento;
        }

        public override string ToString()
        {
            
          return Nombre + " " + Apellido + " " + Dni + " " + FechaNacimiento;
        }



    }
}
