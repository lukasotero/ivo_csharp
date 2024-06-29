using System;

namespace Ejercicio6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Serie[] s1 = new Serie[5];
            Videojuego[] s2 = new Videojuego[5];

            int aux1 = 0, aux2 = 0, cont1 = 0, cont2 = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el nombre de la serie numero {0}", i);
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el numero de temporadas de la serie numero {0}", i);
                int numtemp = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Ingrese el nombre del genero de la serie numero {0}", i);
                string genero = Console.ReadLine();

                Console.WriteLine("Ingrese el nombre del creador de la serie numero {0}", i);
                string creador = Console.ReadLine();

                Console.WriteLine("Indique si quiere devorlver la serie poniendo a o b si no quiere");
                char aux4 = Convert.ToChar(Console.ReadLine());

                s1[i] = new Serie(nombre, numtemp, genero, creador);

                if (aux4 == 'a')
                {
                    s1[i].Entregar();
                }
                if (aux4 == 'b')
                {
                    s1[i].Devolver();
                }
                if (aux1 < s1[i].Numdetemp)
                {
                    aux1 = i;
                }
                if (s1[i].IsEntregado() == true)
                {
                    cont1++;
                }
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el nombre del videojuego numero {0}", i);
                string nombre2 = Console.ReadLine();

                Console.WriteLine("Ingrese el numero de horas del videojuego numero {0}", i);
                int numh = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Ingrese el nombre del genero del videojuego numero {0}", i);
                string genero2 = Console.ReadLine();

                Console.WriteLine("Ingrese el nombre de la compañia del videojuego numero {0}", i);
                string compañia = Console.ReadLine();

                Console.WriteLine("Indique si quiere devorlver el videojuego poniendo a o b si no quiere");
                char aux3 = Convert.ToChar(Console.ReadLine());

                s2[i] = new Videojuego(nombre2, numh, genero2, compañia);
                if (aux3 == 'a')
                {
                    s2[i].Entregar();
                }
                else if (aux3 == 'b')
                {
                    s2[i].Devolver();
                }

                if (aux2 < s2[i].Horasest)
                {
                    aux2 = i;
                }

                if (s2[i].IsEntregado() == true)
                {
                    cont2++;
                }
            }

            Console.WriteLine("La cantidad de serie entregadas son {0}", cont1);
            Console.WriteLine("La cantidad de videojuegos entregados son {0}", cont2);
            Console.WriteLine(s1[aux1]);
            Console.WriteLine(s2[aux2]);
        }
    }
}