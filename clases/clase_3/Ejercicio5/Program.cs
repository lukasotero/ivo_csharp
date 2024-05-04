using System;

namespace Ejercicio5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Fecha fecha = new Fecha(9, 2, 2001);
            Console.WriteLine(fecha.ToString() + "\n");
            
            // Probando los getters y setters
            fecha.SetDia(1);
            Console.WriteLine(fecha.GetDia());
            fecha.SetMes(1);
            Console.WriteLine(fecha.GetMes());
            fecha.SetAnio(2024);
            Console.WriteLine(fecha.GetAnio());
            Console.WriteLine("\n" + fecha.ToString());

            // Pausear la consola
            Console.Read();
        }
    }
}
