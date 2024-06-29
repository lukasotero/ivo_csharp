using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
    public class Program
    {
        static void Main(string[] args)
        {
            // int i; - No hace falta declararlo acá, lo podes declarar cuando lo vas a utilizar
            Console.WriteLine("Ingrese la cantidad de contraseñas");
            int cantidad = Convert.ToInt16(Console.ReadLine()); // Recomendacion: el nombre de las variables bien claras. Cambié de "i" -> "cantidad"
            Password[] passwords = new Password[cantidad]; // Recomendacion: el nombre de las variables bien claras. Cambié de "pa" -> "passwords"

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Ingrese longitud para contraseña numero={0}", i);
                int longitud = Convert.ToInt16(Console.ReadLine());
                passwords[i] = new Password(longitud);
            }

            for (int i = 0; i < cantidad; i++)
            {
                if (passwords[i].esFuerte() == true) // == true es redundante, se puede eliminar
                { Console.WriteLine("Es Fuerte"); }
                else
                { Console.WriteLine("Es Debil"); }

                // Agrego la contraseña para que se vea en consola y verificar si verdaderamente es fuerte o debil.
                Console.WriteLine("Contraseña: {0}", passwords[i].getPassword());
            }

            // Pausear la consola
            Console.Read();
        }
    }
}