using System;

namespace correccionEjercicio4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Fecha f1 = new Fecha(9, 2, 2001); // Una fecha cualquiera para inicializar el objeto

            Console.WriteLine("Ingrese su Dia:");
            int dia = Convert.ToInt16(Console.ReadLine()); // Aca sólo estas guardando en una variable lo que ingreso el usuario
            f1.SetDia(dia); // Tiene que pasar por el Setter para la validación

            Console.WriteLine("Ingrese su Mes");
            int mes = Convert.ToInt16(Console.ReadLine()); // Aca sólo estas guardando en una variable lo que ingreso el usuario
            f1.SetMes(mes); // Tiene que pasar por el Setter para la validación

            Console.WriteLine("Ingrese su Anio");
            int anio = Convert.ToInt16(Console.ReadLine()); // Aca sólo estas guardando en una variable lo que ingreso el usuario
            f1.SetAnio(anio); // Tiene que pasar por el Setter para la validación

            Console.WriteLine(f1.ToString()); // ToString() agregado en la corrección

            // Pausear la consola
            Console.Read();
        }
    }
}
