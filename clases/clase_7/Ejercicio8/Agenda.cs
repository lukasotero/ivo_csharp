using System;

namespace Ejercicio8
{
    public class Agenda
    {
        // Atributos
        private Contacto[] contactos;
        private int contador;

        // Constructor
        public Agenda(int tamaño = 10)
        {
            contactos = new Contacto[tamaño];
            contador = 0;
        }

        // Métodos
        public void añadirContacto(Contacto c)
        {
            if (existeContacto(c))
            {
                Console.WriteLine("El contacto ya existe.\n\n");
                return;
            }

            if (agendaLlena())
            {
                Console.WriteLine("No se pueden agregar más contactos, la agenda está llena.\n\n");
                return;
            }

            contactos[contador++] = c;
            Console.WriteLine("Contacto añadido.\n\n");
        }

        public bool existeContacto(Contacto c)
        {
            for (int i = 0; i < contador; i++)
            {
                if (contactos[i].Equals(c))
                    return true;
            }
            return false;
        }

        public void listarContactos()
        {
            if (contador == 0)
            {
                Console.WriteLine("No hay contactos en la agenda.\n\n");
                return;
            }

            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine($"Nombre: {contactos[i].Nombre}, Teléfono: {contactos[i].Telefono}\n\n");
            }
        }

        public void buscaContacto(string nombre)
        {
            for (int i = 0; i < contador; i++)
            {
                if (contactos[i].Nombre.Equals(nombre))
                {
                    Console.WriteLine($"Teléfono: {contactos[i].Telefono}\n\n");
                    return;
                }
            }
            Console.WriteLine("Contacto no encontrado.\n\n");
        }

        public void eliminarContacto(Contacto c)
        {
            for (int i = 0; i < contador; i++)
            {
                if (contactos[i].Equals(c))
                {
                    for (int j = i; j < contador - 1; j++)
                    {
                        contactos[j] = contactos[j + 1];
                    }
                    contactos[--contador] = null;
                    Console.WriteLine("Contacto eliminado.\n\n");
                    return;
                }
            }
            Console.WriteLine("Contacto no encontrado.\n\n");
        }

        public bool agendaLlena()
        {
            return contador >= contactos.Length;
        }

        public int huecosLibres()
        {
            return contactos.Length - contador;
        }
    }
}
