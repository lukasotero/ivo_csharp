namespace Ejercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hay que realizar una estructura while para que el programa no termine en caso de ingresar otro numero
            Console.WriteLine("Ingrese que opcion quiere:");
            Console.WriteLine("1. Añadir contacto");
            Console.WriteLine("2. Listar contactos");
            Console.WriteLine("3. Buscar contacto");
            Console.WriteLine("4. Existe contacto");
            Console.WriteLine("5. Eliminar contacto");
            Console.WriteLine("6. Contactos disponibles");
            Console.WriteLine("7. Agenda llena");
            Console.WriteLine("8. Salir");

            // Hay que realizar un switch para que el usuario pueda elegir que opcion quiere
            int aux = Convert.ToInt32(Console.ReadLine());
        }
    }
}