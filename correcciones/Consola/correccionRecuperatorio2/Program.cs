using System;

namespace correccionRecuperatorio2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Vehiculo vehiculo = new Vehiculo("ABC123", "Ford", 250);
            Console.WriteLine("Vehiculo");
            Console.WriteLine(vehiculo.ToString());
            Console.WriteLine($"Es veloz: {vehiculo.EsVeloz()} \n");

            Taxi taxi = new Taxi("DEF456", "Chevrolet", 150, "123456", 100, 50);
            Console.WriteLine("Taxi");
            Console.WriteLine(taxi.ToString());
            Console.WriteLine($"Valor del viaje: {taxi.CalcularValorViaje(10)} \n");

            Colectivo colectivo = new Colectivo("GHI789", "Fiat", 300, 50, 123, 10);
            Console.WriteLine("Colectivo");
            Console.WriteLine(colectivo.ToString());
            Console.WriteLine($"Valor del viaje: {colectivo.CalcularValorViaje()}");

            Console.Read();
        }
    }
}
