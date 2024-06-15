using System;

namespace Ejercicio_7
{
    public class Program
    {
        static void Main(string[] args)
        {
            Raices s1 = new Raices(2, 2, -12);
            s1.Calcular();

            // Console.WriteLine(s1); // No hace falta

            // Pausear consola
            Console.ReadLine();
        }
    }
}