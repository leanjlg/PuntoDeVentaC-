using System;
using System.Collections.Generic;
using System.Text;

namespace PuntoDeVenta
{
    class Cliente : Persona
    {
        //PROPERTIES
        public string Email { get; set; }
        public int NroCliente { get; set; }

        //CONSTRUCTOR
        public Cliente() { }

        public Cliente(string email, int nroCliente, string nombre, string apellido, int dni, DateTime fechaNacimiento):base(nombre,apellido, dni, fechaNacimiento)
        {
            Email = email;
            NroCliente = nroCliente;
          
        }

        public override string ToString()
        {
            // return this.Nombre + " " + this.Apellido +
            return base.ToString() +  " " + this.Email + " " + this.NroCliente;
        }


    }
}
