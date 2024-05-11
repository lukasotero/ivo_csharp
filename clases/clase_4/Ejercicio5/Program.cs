using System;

namespace Ejercicio5
{
    public class Program
    {
        /*
         Crearemos una clase llamada "Electrodomestico" con las siguientes características:

- Sus atributos son precio base, color, consumo energético (letras entre A y F) y peso. 
- Por defecto, el color sera blanco, el consumo energético sera F, el precioBase es de $100 y el peso de 5 kg.
- Los colores disponibles son blanco, negro, rojo, azul y gris. No importa si el nombre esta en mayúsculas o en minúsculas.

Los constructores que se implementaran serán:
- Un constructor por defecto (sin parámetros).
- Un constructor con el precio y peso. El resto por defecto.
- Un constructor con todos los atributos.

Los métodos que implementara serán:
- Propiedad get de todos los atributos.
- comprobarConsumoEnergetico(char letra): comprueba que la letra es correcta, sino es correcta usara la letra por defecto. Se invocara al crear el objeto y no sera visible.
- comprobarColor(String color): comprueba que el color es correcto, sino lo es usa el color por defecto. Se invocara al crear el objeto y no sera visible.
- precioFinal(): según el consumo energético, aumentara su precio, y según su tamaño, también. Esta es la lista de precios:

| LETRA | PRECIO |
| :---: | :---: |
| A     | $100 |
| B     | $80  |
| C     | $60  |
| D     | $50  |
| E     | $30  |
| F     | $10  |

| TAMAÑO | PRECIO |
| :---: | :---: |
| Entre 0 y 20kg (no inclusive) | $10 |
| Entre 20 y 50kg (no inclusive) | $50 |
| Entre 50 y 80kg (no inclusive) | $80 |
| Mayor o igual a 80kg | $100 |

Ahora crea una clase ejecutable que realice lo siguiente:
- Crear un array de Electrodomesticos de 10 posiciones.
- Asignar a cada posición un objeto con los valores que desees.
- Mostrar el precio de cada Electrodomestico y la suma total.
- Por ejemplo, si tenemos un Electrodomestico con un precio final de 300, otro de 200 y otro de 500, el resultado final será de $1000 (300+200+500).
         */
        static void Main(string[] args)
        {
            // Crear un array de Electrodomesticos de 10 posiciones
            Electrodomestico[] electrodomesticos = new Electrodomestico[10];

            // Asignar a cada posición un objeto con los valores deseados
            electrodomesticos[0] = new Electrodomestico(200, "rojo", 'A', 15);
            electrodomesticos[1] = new Electrodomestico(300, "negro", 'B', 25);
            electrodomesticos[2] = new Electrodomestico(150, "azul", 'C', 10);
            electrodomesticos[3] = new Electrodomestico(400, "gris", 'D', 30);
            electrodomesticos[4] = new Electrodomestico(250, "blanco", 'E', 20);
            electrodomesticos[5] = new Electrodomestico(350, "rojo", 'F', 40);
            electrodomesticos[6] = new Electrodomestico(180, "negro", 'A', 12);
            electrodomesticos[7] = new Electrodomestico(280, "azul", 'B', 22);
            electrodomesticos[8] = new Electrodomestico(220, "gris", 'C', 18);
            electrodomesticos[9] = new Electrodomestico(320, "blanco", 'D', 35);

            double totalPrecio = 0;

            // Mostrar el precio de cada Electrodomestico y la suma total
            for (int i = 0; i < electrodomesticos.Length; i++)
            {
                Console.WriteLine($"Electrodomestico {i + 1}: Precio = ${electrodomesticos[i].PrecioFinal()}");
                totalPrecio += electrodomesticos[i].PrecioFinal();
            }

            Console.WriteLine($"Precio total de los electrodomesticos: ${totalPrecio}");
        }
    }
}
