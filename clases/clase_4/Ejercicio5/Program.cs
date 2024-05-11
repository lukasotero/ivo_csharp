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
            electrodomesticos[0] = new Electrodomestico(200, "rojo", 'A', 15);
            electrodomesticos[1] = new Electrodomestico(300, "negro", 'B', 25);
            electrodomesticos[2] = new Electrodomestico(150, "azul", 'C', 10);
            electrodomesticos[3] = new Electrodomestico(400, "gris", 'D', 30);
            electrodomesticos[4] = new Electrodomestico(250, "blanco", 'E', 20);
            electrodomesticos[5] = new Electrodomestico(350, "rojo", 'F', 40);
            electrodomesticos[6] = new Electrodomestico(180, "negro", 'A', 12);
            electrodomesticos[7] = new Electrodomestico(280, "azul", 'B', 22);
            electrodomesticos[8] = new Electrodomestico(220, "gris", 'C', 18);
            electrodomesticos[9] = new Electrodomestico(320, "blanco", 'D', 35);

            double totalPrecio = 0;

            // Mostrar el precio de cada Electrodomestico y la suma total
            for (int i = 0; i < electrodomesticos.Length; i++)
            {
                Console.WriteLine($"Electrodomestico {i + 1}: Precio = ${electrodomesticos[i].PrecioFinal()}");
                totalPrecio += electrodomesticos[i].PrecioFinal();
            }

            Console.WriteLine($"Precio total de los electrodomesticos: ${totalPrecio}");
        }
    }
}
