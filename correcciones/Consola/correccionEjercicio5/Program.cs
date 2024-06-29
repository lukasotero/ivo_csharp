using Electrodomesticos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace correccionEjercicio5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Electrodomestico[] electrodomesticos = new Electrodomestico[10];

            electrodomesticos[0] = new Electrodomestico(850, "negro", 'F', 50);
            electrodomesticos[1] = new Electrodomestico(995, "gris", 'D', 68);
            electrodomesticos[2] = new Electrodomestico(654, "negro", 'B', 70);
            electrodomesticos[3] = new Electrodomestico(600, "azul", 'E', 120);
            electrodomesticos[4] = new Electrodomestico(700, "blanco", 'A', 10);
            electrodomesticos[5] = new Electrodomestico(560, "rojo", 'Z', 50);
            electrodomesticos[6] = new Electrodomestico(100, "rojo", 'A', 10);
            electrodomesticos[7] = new Electrodomestico(160, "gris", 'F', 45);
            electrodomesticos[8] = new Electrodomestico(380, "azul", 'B', 30);
            electrodomesticos[9] = new Electrodomestico(215, "negro", 'C', 45);

            float precioTotal = 0;

            for (int i = 0; i < electrodomesticos.Length; i++)
            {
                Console.WriteLine($"Electrodomestico {i + 1}: ${electrodomesticos[i].Preciofinal()}");
                precioTotal += electrodomesticos[i].Preciofinal();
            }

            Console.WriteLine($"Precio Total de los Electrodomesticos: ${precioTotal}");

            // Pausear consola
            Console.Read();
        }
    }
}
