using System;

namespace Ejercicio3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de contraseñas a generar: ");
            int cantidad = int.Parse(Console.ReadLine());
            Password[] passwords = new Password[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                Console.Write("Ingrese la longitud de la contraseña: ");
                int longitud = int.Parse(Console.ReadLine());
                passwords[i] = new Password(longitud);
            }

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("La contraseña \"{0}\" es \"{1}\"", passwords[i].GetPassword(), passwords[i].EsFuerte() ? "FUERTE" : "DEBIL");
            }

            // Pausar consola
            Console.Read();
        }
    }
}
