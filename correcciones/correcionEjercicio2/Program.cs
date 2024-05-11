using System;

namespace ejercicio_2
{
    /*
     Crear una clase llamada Persona que siga las siguientes condiciones:

     Sus atributos son: nombre, edad, DNI, sexo('H' hombre, 'M' mujer), peso y altura.No queremos que se accedan directamente a ellos.
     Por defecto, todos los atributos menos el DNI serán valores por defecto según su tipo (0 números, cadena vacía para String, etc.). Sexo será hombre por defecto.
     Se deben generar varios constructores:
     Un constructor por defecto(no recibe parámetros).
     Un constructor con el nombre, edad y sexo, el resto por defecto.
     Un constructor con todos los atributos como parámetro (menos el DNI que se genera automaticamente).
     Los métodos que se implementaran son:

     CalcularIMC() : calculara si la persona está en su peso ideal(peso en kg/(altura^2  en m)), si esta fórmula nos da un valor menor que 20 la función devuelve un -1 y significa que está en su peso ideal; si nos da un valor entre 20 y 25 (incluidos), significa que está por debajo de su peso ideal y la función devuelve un 0; y si nos da un valor mayor que 25 significa que tiene sobrepeso y la función devuelve un 1.
     EsMayorDeEdad() : indica si es mayor de edad, devuelve un booleano.
     ComprobarSexo(char sexo): comprueba que el sexo introducido es correcto.Si no es correcto, será H.No será visible al exterior.
     GeneraDNI(): genera un número aleatorio de 8 cifras.Este método sera invocado cuando se instancie el objeto.No será visible al exterior.
     Propiedad set de cada parámetro, excepto de DNI.
     Crear un programa que haga lo siguiente:

     Pedir por teclado el nombre, la edad, sexo, peso y altura.
     Crear 3 objetos de la clase Persona, el primer objeto obtendrá las anteriores variables pedidas por teclado, el segundo objeto obtendrá todos los anteriores menos el peso y la altura y el último por defecto, para este último utiliza las propiedades set para darle a los atributos un valor.
     Para cada objeto, deberá comprobar si está en su peso ideal, si tiene sobrepeso o está por debajo con un mensaje.
     Indicar para cada objeto si es mayor de edad.
     Por último, mostrar la información de cada objeto (ToString).
     */

    public class Program
    {
        static void Main(string[] args)
        {
            // Primero se le pide al usuario que introduzca los datos
            string nombre = Console.ReadLine();
            int edad = Convert.ToInt16(Console.ReadLine());
            char sexo = Convert.ToChar(Console.ReadLine());
            float peso = float.Parse(Console.ReadLine());
            float altura = float.Parse(Console.ReadLine());

            // Se crean los objetos con los datos introducidos
            //Persona pe1 = new Persona();
            Persona pe1 = new Persona(nombre, edad, sexo, peso, altura);
            //Persona pe2 = new Persona();
            Persona pe2 = new Persona(nombre, edad, sexo);

            // Acordate de usar los Setters creados en la clase Persona
            Persona pe3 = new Persona();
            pe3.Nombre = "Braulio"; // Agregado en la correción
            pe3.Edad = 16; // Agregado en la correción
            pe3.Sexo = 'H'; // Agregado en la correción
            pe3.Peso = 62; // Agregado en la correción
            pe3.Altura = 1.65f; // Agregado en la correción

            if (pe1.Calcularimc() == 1) { Console.WriteLine("Sobrepeso"); }
            else if (pe1.Calcularimc() == 0) { Console.WriteLine("Debajo Peso Ideal"); }
            else if (pe1.Calcularimc() == -1) { Console.WriteLine("Peso Ideal"); }

            if (pe2.Calcularimc() == 1) { Console.WriteLine("Sobrepeso"); }
            else if (pe2.Calcularimc() == 0) { Console.WriteLine("Debajo Peso Ideal"); }
            else if (pe2.Calcularimc() == -1) { Console.WriteLine("Peso Ideal"); }

            if (pe2.Calcularimc() == 1) { Console.WriteLine("Sobrepeso"); }
            else if (pe2.Calcularimc() == 0) { Console.WriteLine("Debajo Peso Ideal"); }
            else if (pe2.Calcularimc() == -1) { Console.WriteLine("Peso Ideal"); }

            if (pe3.Calcularimc() == 1) { Console.WriteLine("Sobrepeso"); }
            else if (pe3.Calcularimc() == 0) { Console.WriteLine("Debajo Peso Ideal"); }
            else if (pe3.Calcularimc() == -1) { Console.WriteLine("Peso Ideal"); }

            if (pe1.MayordeEdad() == true) { Console.WriteLine("Es mayor"); }
            if (pe2.MayordeEdad() == true) { Console.WriteLine("Es mayor"); }
            if (pe3.MayordeEdad() == true) { Console.WriteLine("Es mayor"); }

            // Console.WriteLine(pe1); - Acordate de usar el método ToString
            Console.WriteLine(pe1.ToString());

            // Console.WriteLine(pe2); - Acordate de usar el método ToString
            Console.WriteLine(pe2.ToString());

            // Console.WriteLine(pe3); - Acordate de usar el método ToString
            Console.WriteLine(pe1.ToString());

            // Pausear la consola
            Console.Read();
        }
    }
}