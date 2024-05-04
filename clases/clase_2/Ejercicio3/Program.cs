using System;

namespace Ejercicio3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sexo (H/M): ");
            string sexo = Console.ReadLine();

            Console.WriteLine("Peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Persona persona1 = new Persona(nombre, edad, sexo, peso, altura);

            Persona persona2 = new Persona(nombre, edad, sexo);

            Persona persona3 = new Persona();
            persona3.SetNombre("Jorge");
            persona3.SetEdad(16);
            persona3.SetSexo("H");
            persona3.SetPeso(62);
            persona3.SetAltura(1.65);

            // Verificaciones para la persona 1
            Console.WriteLine("\nPersona 1:");
            if (persona1.CalcularIMC() == -1)
            {
                Console.WriteLine("Está en su peso ideal.");
            }
            else if (persona1.CalcularIMC() == 0)
            {
                Console.WriteLine("Está por debajo de su peso ideal.");
            }
            else
            {
                Console.WriteLine("Tiene sobrepeso.");
            }

            if (persona1.EsMayorDeEdad())
            {
                Console.WriteLine("Es mayor de edad.");
            }
            else
            {
                Console.WriteLine("No es mayor de edad.");
            }

            Console.WriteLine(persona1.ToString());

            // Verificaciones para la persona 2
            Console.WriteLine("\nPersona 2:");
            if (persona2.CalcularIMC() == -1)
            {
                Console.WriteLine("Está en su peso ideal.");
            }
            else if (persona2.CalcularIMC() == 0)
            {
                Console.WriteLine("Está por debajo de su peso ideal.");
            }
            else
            {
                Console.WriteLine("Tiene sobrepeso.");
            }

            if (persona2.EsMayorDeEdad())
            {
                Console.WriteLine("Es mayor de edad.");
            }
            else
            {
                Console.WriteLine("No es mayor de edad.");
            }

            Console.WriteLine(persona2.ToString());

            // Verificaciones para la persona 3
            Console.WriteLine("\nPersona 3:");
            if (persona3.CalcularIMC() == -2)
            {
                Console.WriteLine("Está en su peso ideal.");
            }
            else if (persona3.CalcularIMC() == 0)
            {
                Console.WriteLine("Está por debajo de su peso ideal.");
            }
            else
            {
                Console.WriteLine("Tiene sobrepeso.");
            }

            if (persona3.EsMayorDeEdad())
            {
                Console.WriteLine("Es mayor de edad.");
            }
            else
            {
                Console.WriteLine("No es mayor de edad.");
            }

            Console.WriteLine(persona3.ToString());

            // Pausar consola
            Console.Read();
        }
    }
}
