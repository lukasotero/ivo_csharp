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
            // Crear un array de Electrodomesticos de 10 posiciones.
            Electrodomestico[] electrodomesticos = new Electrodomestico[10];

            // Asignar a cada posición un objeto con los valores que desees.
            electrodomesticos[0] = new Electrodomestico(100, "blanco", 'F', 5);
        }
    }
}
