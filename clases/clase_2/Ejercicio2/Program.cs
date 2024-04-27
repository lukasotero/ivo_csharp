using System;

namespace Ejercicio2
{
    public class Program
    {
        /*
         * Crea una clase llamada "Cuenta" que tendrá los siguientes atributos: titular y cantidad (puede tener decimales).
         * Crear un constructor con ambos atributos.
         * Crea sus propiedades get, set y el método ToString.
         * 
         * Tendrá dos métodos:
         * 1) Ingresar(float cantidad): se ingresa una cantidad a la cuenta,
         *      si la cantidad introducida es negativa, no se hará nada.
         * 2) Retirar(float cantidad): se retira una cantidad a la cuenta,
         *      si restando la cantidad actual a la que nos pasan es negativa, la cantidad de la cuenta pasa a ser 0.
         */

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
