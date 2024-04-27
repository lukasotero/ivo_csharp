using System;

namespace Ejercicio3
{
    public class Program
    {
        /*
         * Crear una clase llamada Persona que siga las siguientes condiciones:
         * - Sus atributos son: nombre, edad, DNI, sexo ('H' hombre, 'M' mujer), peso y altura.
         * - No queremos que se accedan directamente a ellos.
         * 
         * Por defecto, todos los atributos menos el DNI serán valores por defecto según su tipo (0 números, cadena vacía para String, etc.). Sexo será hombre por defecto.
         * 
         * Se deben generar varios constructores:
         * 1) Un constructor por defecto (no recibe parámetros).
         * 2) Un constructor con el nombre, edad y sexo, el resto por defecto.
         * 3) Un constructor con todos los atributos como parámetro (menos el DNI que se genera automaticamente).
         * 
         * Los métodos que se implementaran son:
         * 1) CalcularIMC(): calculara si la persona está en su peso ideal (peso en kg/(altura^2  en m)),
         *      si esta fórmula nos da un valor menor que 20 la función devuelve un -1 y significa que está en su peso ideal;
         *      si nos da un valor entre 20 y 25 (incluidos), significa que está por debajo de su peso ideal y la función devuelve un 0;
         *      y si nos da un valor mayor que 25 significa que tiene sobrepeso y la función devuelve un 1.
         * 2) EsMayorDeEdad(): indica si es mayor de edad, devuelve un booleano.
         * 3) ComprobarSexo(char sexo): comprueba que el sexo introducido es correcto.
         *      Si no es correcto, será H. No será visible al exterior.
         * 4) GeneraDNI(): genera un número aleatorio de 8 cifras.
         *      Este método sera invocado cuando se instancie el objeto. No será visible al exterior.
         * 
         * Propiedad set de cada parámetro, excepto de DNI.
         * 
         * Crear un programa que haga lo siguiente:
         * 1) Pedir por teclado el nombre, la edad, sexo, peso y altura.
         * 2) Crear 3 objetos de la clase Persona, el primer objeto obtendrá las anteriores variables pedidas por teclado,
         *      el segundo objeto obtendrá todos los anteriores menos el peso y la altura
         *      y el último por defecto, para este último utiliza las propiedades set para darle a los atributos un valor.
         * 3) Para cada objeto, deberá comprobar si está en su peso ideal,
         *      si tiene sobrepeso o está por debajo con un mensaje.
         * 4) Indicar para cada objeto si es mayor de edad.
         * 5) Por último, mostrar la información de cada objeto (ToString).
         */

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
