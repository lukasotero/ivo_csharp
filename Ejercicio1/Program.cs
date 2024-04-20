using System;

namespace Ejercicio1
{
    public class Program
    {
        /* 1) Realizar un programa que dada una clase "Cuenta",
         * cuyo atributo es el saldo de la misma permita 'Acreditar' saldo sobre la misma.
         * El valor que se acredita no puede ser menor que 0.

        Debe incluir un método constructor que permita inicializar el valor inicial del saldo.

        Crear los objetos necesarios para realizar las pruebas con los llamados a los métodos correspondientes.
        */

        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta(0);
            Console.WriteLine("Saldo antes: " + cuenta.GetSaldo());

            cuenta.Acreditar(100);

            Console.WriteLine("Saldo después: " + cuenta.GetSaldo());
            Console.Read();
        }
    }
}
