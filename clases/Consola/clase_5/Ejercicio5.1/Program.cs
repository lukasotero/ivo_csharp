using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5._1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Crear un array de Electrodomesticos de 10 posiciones
            Electrodomestico[] electrodomesticos = new Electrodomestico[10];

            // Asignar a cada posición un objeto de las clases anteriores con valores
            electrodomesticos[0] = new Lavadora(); // Probando el constructor vacío
            electrodomesticos[1] = new Lavadora(200, 25); // Probando constructor con 2 parametros
            electrodomesticos[2] = new Lavadora(50, 100, "gris", 'B', 60); // Probando constructor con todos los parametros
            electrodomesticos[3] = new Lavadora(25, 25, "marron", 'A', 80); // Objeto con errores para comprobar si funcionan las validaciones
            electrodomesticos[4] = new Lavadora(68, 250, "rojo", 'Z', 10); // Objeto con errores para comprobar si funcionan las validaciones
            electrodomesticos[5] = new Television(); // Probando el constructor vacío
            electrodomesticos[6] = new Television(500, 50); // Probando constructor con 2 parametros
            electrodomesticos[7] = new Television(1080, true, 100, "azul", 'B', 60); // Probando constructor con todos los parametros
            electrodomesticos[8] = new Television(720, false, 2800, "verde", 'A', 80); // Objeto con errores para comprobar si funcionan las validaciones
            electrodomesticos[9] = new Television(7200, true, 2000, "negro", 'W', 180); // Objeto con errores para comprobar si funcionan las validaciones

            double totalPrecioElectrodomesticos = 0;
            double totalPrecioLavadoras = 0;
            double totalPrecioTelevisiones = 0;

            for (int i = 0; i < electrodomesticos.Length; i++)
            {
                double precioFinal = electrodomesticos[i].precioFinal();
                totalPrecioElectrodomesticos += precioFinal;

                if (electrodomesticos[i] is Lavadora)
                {
                    totalPrecioLavadoras += precioFinal;
                }
                else if (electrodomesticos[i] is Television)
                {
                    totalPrecioTelevisiones += precioFinal;
                }
            }

            Console.WriteLine($"Total precio de Electrodomésticos: ${totalPrecioElectrodomesticos}");
            Console.WriteLine($"Total precio de Lavadoras: ${totalPrecioLavadoras}");
            Console.WriteLine($"Total precio de Televisores: ${totalPrecioTelevisiones}");

            // Pausear consola
            Console.Read();
        }
    }
}
