using System;

namespace Ejercicio8
{
    public class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("1) Añadir contacto");
                Console.WriteLine("2) Listar contactos");
                Console.WriteLine("3) Buscar contacto");
                Console.WriteLine("4) Existe contacto");
                Console.WriteLine("5) Eliminar contacto");
                Console.WriteLine("6) Contactos disponibles");
                Console.WriteLine("7) Agenda llena");
                Console.WriteLine("8) Salir\n");

                Console.Write("Elige una opción: ");
                
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Introduce nombre: ");
                        string nombre = Console.ReadLine();

                        Console.Write("Introduce teléfono: ");
                        string telefono = Console.ReadLine();

                        Contacto nuevoContacto = new Contacto(nombre, telefono);

                        agenda.añadirContacto(nuevoContacto);

                        break;
                    case 2:
                        agenda.listarContactos();
                        break;
                    case 3:
                        Console.Write("Introduce nombre a buscar: ");
                        string nombreABuscar = Console.ReadLine();
                        agenda.buscaContacto(nombreABuscar);
                        break;
                    case 4:
                        Console.Write("Introduce nombre del contacto a verificar: ");
                        string nombreAComprobar = Console.ReadLine();

                        Contacto contactoAComprobar = new Contacto(nombreAComprobar, "");

                        if (agenda.existeContacto(contactoAComprobar))
                        {
                            Console.WriteLine("El contacto existe.");
                        }
                        else
                        {
                            Console.WriteLine("El contacto no existe.");
                        }

                        break;
                    case 5:
                        Console.Write("Introduce nombre del contacto a eliminar: ");
                        string nombreAEliminar = Console.ReadLine();

                        Contacto contactoAEliminar = new Contacto(nombreAEliminar, "");
                        
                        agenda.eliminarContacto(contactoAEliminar);
                        
                        break;
                    case 6:
                        Console.WriteLine($"Contactos disponibles: {agenda.huecosLibres()}");
                        break;
                    case 7:
                        if (agenda.agendaLlena())
                        {
                            Console.WriteLine("La agenda está llena.");
                        }
                        else
                        {
                            Console.WriteLine("La agenda no está llena.");
                        }

                        break;
                    case 8:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                        break;
                }
            }
        }
    }
}
