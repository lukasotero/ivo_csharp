using System;

namespace Ejercicio0
{
    public class Program
    {
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
