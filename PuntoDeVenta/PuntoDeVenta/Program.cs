using System;

namespace PuntoDeVenta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo");
            Cliente cli = new Cliente();
            DateTime fecha = new DateTime(1985, 2, 27);
            Cliente cli2 = new Cliente("email", 34, "nombre", "apellido", 837483, fecha);


            Console.WriteLine(cli2.ToString());

            Console.Read();
        }
    }
}
