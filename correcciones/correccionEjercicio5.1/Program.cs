using System;

namespace correccionEjercicio5._1
{
    public class Program
    {
        static void Main(string[] args)
        {
            float aux1 = 0; // Recomendación: cambiar el nombre de la variable a 'totalPrecioLavadoras' o algo así, que sea más descriptivo
            float aux2 = 0; // Recomendación: cambiar el nombre de la variable a 'totalPrecioTelevisiones' o algo así, que sea más descriptivo
            float totalPrecioElectrodomesticos = 0;
            Electrodomestico[] s1 = new Electrodomestico[10];

            for (int i = 0; i < 5; i++)
            {
                s1[i] = new Lavadora(10.5f, "rojo", 'A', 2.51f, 3f);
            }

            for (int i = 5; i < 10; i++)
            {
                s1[i] = new Television(12.3f, "negro", 'B', 2.51f, 40f, true);
            }

            for (int i = 0; i < 10; i++)
            {
                if (i < 5)
                {
                    aux1 = aux1 + s1[i].Preciofinal();
                    totalPrecioElectrodomesticos += aux1;
                }

                if (i < 10 && i > 5)
                {
                    aux2 = aux2 + s1[i].Preciofinal();
                    totalPrecioElectrodomesticos += aux2;
                }
            }
            
            Console.WriteLine("El Precio de Todas las Lavadoras es {0}", aux1);
            Console.WriteLine("El Precio de Todas las Televisiones es {0}", aux2);

            // Falta mostrar la suma de todos los Electrodomesticos
            Console.WriteLine("La suma de todos los Electrodomesticos es {0}", totalPrecioElectrodomesticos);

            // Pausear consola
            Console.Read();
        }
    }
}
