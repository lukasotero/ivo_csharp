using System;

namespace Ejercicio4
{
    public class Program
    {
        /*
         * Crear una clase llamada "Password" con las siguientes características:
         * Que tenga los atributos longitud y contraseña. Por defecto, la longitud será de 8.
         * 
         * Los constructores serán los siguiente:
         * 1) Un constructor por defecto (sin parámetros).
         * 2) Un constructor con la longitud que nosotros le pasemos. Generara una contraseña aleatoria con esa longitud.
         * 
         * Los métodos que implementa serán:
         * 1) esFuerte(): devuelve un booleano si es fuerte o no.
         *      Para que sea fuerte debe tener al menos 2 mayúsculas, 1 minúscula y 5 números.
         *      Opcional: se puede utilizar una Expresión Regular para el chequeo. 
         * 2) generarPassword():  genera la contraseña con la longitud definida.
         * 3) Método get para contraseña y longitud.
         * 4) Método set (privados) para contraseña y longitud.
         * 
         * Crear una clase clase ejecutable:
         * 1) Crear un vector de Passwords con el tamaño que se le indique por teclado.
         * 2) Crear un objeto para cada posición del vector.
         * 3) Indicar también por teclado la longitud de los Password (antes de ingresarlos).
         * 
         * Al final, mostrar la contraseña y si es o no fuerte. Usar este formato para mostrar por pantalla:
         * 1) La contraseña "J98Kp765" es "FUERTE"
         * 2) La contraseña "12345678" es "DEBIL"
         */

        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de contraseñas a generar: ");
            int cantidad = int.Parse(Console.ReadLine());
            Password[] passwords = new Password[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                Console.Write("Ingrese la longitud de la contraseña: ");
                int longitud = int.Parse(Console.ReadLine());
                passwords[i] = new Password(longitud);
            }

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("La contraseña \"{0}\" es \"{1}\"", passwords[i].GetPassword(), passwords[i].EsFuerte() ? "FUERTE" : "DEBIL");
            }

            // Pausar consola
            Console.Read();
        }
    }
}
