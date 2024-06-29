using System;

namespace Ejercicio1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta("Juan", 1000);
            Console.WriteLine(cuenta.ToString());

            cuenta.Ingresar(500);
            Console.WriteLine(cuenta.ToString());

            cuenta.Retirar(2000);
            Console.WriteLine(cuenta.ToString());

            cuenta.Retirar(500);
            Console.WriteLine(cuenta.ToString());

            // Pausar consola
            Console.Read();
        }
    }
}
