using System;

namespace Ejercicio5
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Crear un array de Electrodomesticos de 10 posiciones
            Electrodomestico[] electrodomesticos = new Electrodomestico[10];

            // Asignar a cada posición un objeto con los valores deseados
            electrodomesticos[0] = new Electrodomestico(); // Constructor vacío para probar si funciona
            electrodomesticos[1] = new Electrodomestico(); // Constructor vacío para probar si funciona
            electrodomesticos[2] = new Electrodomestico(); // Constructor vacío para probar si funciona
            electrodomesticos[3] = new Electrodomestico(300, 100); // Constructor con 2 parametros para probar si funcona
            electrodomesticos[4] = new Electrodomestico(500, 50); // Constructor con 2 parametros para probar si funcona
            electrodomesticos[5] = new Electrodomestico(350, "rojo", 'Z', 40); // Objeto con errores para comprobar si funcionan las validaciones
            electrodomesticos[6] = new Electrodomestico(180, "marron", 'A', 12); // Objeto con errores para comprobar si funcionan las validaciones
            electrodomesticos[7] = new Electrodomestico(280, "violeta", 'W', 22); // Objeto con errores para comprobar si funcionan las validaciones
            electrodomesticos[8] = new Electrodomestico(220, "gris", 'C', 18);
            electrodomesticos[9] = new Electrodomestico(320, "blanco", 'D', 35);

            // Comprobaciones de consumo y color en todos los objetos
            for (int i = 0; i < electrodomesticos.Length; i++)
            {
                electrodomesticos[i].ComprobarConsumoEnergetico(electrodomesticos[i].ConsumoEnergetico);
                electrodomesticos[i].ComprobarColor(electrodomesticos[i].Color);
            }

            double totalPrecio = 0;

            // Mostrar el precio de cada Electrodomestico y la suma total
            for (int i = 0; i < electrodomesticos.Length; i++)
            {
                Console.WriteLine($"Electrodomestico {i + 1}: Precio = ${electrodomesticos[i].PrecioFinal()}");
                totalPrecio += electrodomesticos[i].PrecioFinal();
            }

            Console.WriteLine($"Precio total de los electrodomesticos: ${totalPrecio}");

            // Pausear consola
            Console.Read();
        }
    }
}
