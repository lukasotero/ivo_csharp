namespace Ejercicio8
{
    internal class Agenda
    {
        protected int id;
        private Contacto[] contactos; // Esta es la manera correcta de crear un array de objetos
        // new Contacto[] c1 = new Contacto[10];

        // Constructor
        public Agenda(int i)
        {
            id = i;
            contactos = new Contacto[i];
        }

        // Métodos
        public void AñadirContactos() // Cambié 'anadirContacto' por 'AñadirContactos'
        {
            int aux = 0;
            int y;

            for (y = 0; y < id; y++)
            {
                if (contactos[y].Nom != null)
                {
                    aux++;
                }
            }

            if (aux == y)
            {
                Console.WriteLine("Esta lleno");
            }
            else
            {
                Console.WriteLine("Introduzaca en que numero de contacto se agendara");
                aux = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Introduzca Nombre");
                string nombre = Console.ReadLine(); // Cambié el nombre de la variable 'aux2' por 'nombre'

                for (y = 0; y <= id; ++y)
                {
                    if (contactos[y].Nom == nombre)
                    {
                        break;
                    }
                }
                if (y == id)
                {
                    nombre = contactos[aux].Nom;
                    Console.WriteLine("Introduzca el numero");
                    contactos[aux].Num = Console.ReadLine();
                }
            }
        }

        public void ExisteContacto() // Cambié 'ExistirContacto' por 'ExisteContacto'
        {
            int y = 0;
            Console.WriteLine("Ingrese el nombre del contacto");
            string nombre = Console.ReadLine(); // Cambié el nombre de la variable 'aux' por 'nombre'

            for (y = 0; y <= id; ++y)
            {
                if (contactos[y].Nom == nombre)
                {
                    break;
                }
            }

            if (y == id)
            {
                Console.WriteLine("No exite ese contacto");
            }
            else
            {
                Console.WriteLine("Ya existe ese contacto");
            }
        }

        public void ListarContacto() // Cambié 'ListaContacto' por 'ListarContacto'
        {
            for (int y = 0; y <= id; ++y)
            {
                Console.WriteLine("Contactos nº{0}", y);
                Console.WriteLine("Nombre : {0} \n Numero : {1}", contactos[y].Nom, contactos[y].Num);
            }
        }

        public void BuscarContacto(string n)
        {
            for (int y = 0; y <= id; ++y)
            {
                if (contactos[y].Nom == n)
                {
                    Console.WriteLine("El Contacto existe y su numero es  {0}", contactos[y].Num);
                    break;
                }
            }
        }

        public void EliminarContacto(string n, string num)
        {
            for (int y = 0; y <= id; y++)
            {
                if (contactos[y].Nom == n & contactos[y].Num == num)
                {
                    contactos[y].Num = "0";
                    contactos[y].Nom = "0";
                    break;
                }
            }
        }

        public bool AgendaLlena()
        {
            return id >= contactos.Length;
        }

        /* public void AgendaLlena()
        {
            for (int y = 0; y <= id; ++y)
            {
                if (contactos[y].Nom == "0")
                {

                }
            }
        }*/

        // Se agregó en la corrección
        public int HuecosLibres()
        {
            return contactos.Length - id;
        }
    }
}