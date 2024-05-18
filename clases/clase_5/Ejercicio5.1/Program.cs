using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5._1
{
    public class Program
    {
        /*
         Crearemos una clase llamada "Electrodomestico" con las siguientes características:
         
         - Sus atributos son precio base, color, consumo energético (letras entre A y F) y peso. Indica que se podrán heredar.
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
         
         | LETRA	| PRECIO |
         | :---: | :---: |
         | A	|	$100 |
         | B | $80 |
         | C | $60 |
         | D | $50 |
         | E | $30 |
         | F | $10 |
         
         | TAMAÑO | PRECIO |
         | :---: | :---: |
         | Entre 0 y 20kg (no inclusive) | $10 |
         | Entre 20 y 50kg (no inclusive) | $50 |
         | Entre 50 y 80kg (no inclusive) | $80 |
         | Mayor o igual a 80kg | $100 |
         
         Crear una subclase llamada "Lavadora" con las siguientes características:
         - Su atributo es carga, además de los atributos heredados.
         - Por defecto, la carga es de 5 kg.
         
         Los constructores que se implementaran serán:
         - Un constructor por defecto.
         - Un constructor con el precio y peso. El resto por defecto.
         - Un constructor con la carga y el resto de atributos heredados.
         
         Los métodos que se implementara serán:
         - Método get de carga.
         - precioFinal():, si tiene una carga mayor de 30 kg, aumentara el precio $50, sino es así no se incrementara el precio. Las condiciones en la clase Electrodomestico también deben afectar al precio.
         
         Crear una subclase llamada "Television" con las siguientes características:
         - Sus atributos son resolución (en pulgadas) y sintonizador TDT (booleano), además de los atributos heredados.
         - Por defecto, la resolución será de 20 pulgadas y no tendrá sintonizador.
         
         Los constructores que se implementaran serán:
         - Un constructor por defecto.
         - Un constructor con el precio y peso. El resto por defecto.
         - Un constructor con la resolución, sintonizador TDT y el resto de atributos heredados. Recuerda que debes llamar al constructor de la clase padre.
         
         Los métodos que se implementara serán:
         - Método get de resolución y sintonizador TDT.
         - precioFinal(): si tiene una resolución mayor de 40 pulgadas, se incrementara el precio un 30% y si tiene un sintonizador TDT incorporado, aumentara $50. Recuerda que las
         - condiciones que hemos visto en la clase Electrodomestico también deben afectar al precio.
         
         Crear una clase ejecutable que realice lo siguiente:
         - Crear un array de Electrodomesticos de 10 posiciones.
         - Asignar a cada posición un objeto de las clases anteriores con valores.
         - Recorre el array y ejecuta el método precioFinal().
         - Mostrar el precio de cada clase, es decir, el precio de todas las televisiones por un lado, el de las lavadoras por otro y la suma de los Electrodomesticos.
         Por ejemplo, si tenemos un Electrodomestico con un precio final de 300, una lavadora de 200 y una televisión de 500, el resultado final sera de 1000 (300+200+500) para electrodomésticos, 200 para lavadora y 500 para televisión.
         */

        static void Main(string[] args)
        {
            // Crear un array de Electrodomesticos de 10 posiciones
            Electrodomestico[] electrodomesticos = new Electrodomestico[10];

            // Asignar a cada posición un objeto de las clases anteriores con valores
            electrodomesticos[0] = new Lavadora(); // Probando el constructor vacío
            electrodomesticos[1] = new Lavadora(200, 25); // Probando constructor con 2 parametros
            electrodomesticos[2] = new Lavadora(50, 100, "gris", 'B', 60); // Probando constructor con todos los parametros
            electrodomesticos[3] = new Lavadora(25, 25, "marron", 'A', 80); // Objeto con errores para comprobar si funcionan las validaciones
            electrodomesticos[4] = new Lavadora(68, 250, "rojo", 'Z', 10); // Objeto con errores para comprobar si funcionan las validaciones
            electrodomesticos[5] = new Television(); // Probando el constructor vacío
            electrodomesticos[6] = new Television(500, 50); // Probando constructor con 2 parametros
            electrodomesticos[7] = new Television(1080, true, 100, "azul", 'B', 60); // Probando constructor con todos los parametros
            electrodomesticos[8] = new Television(720, false, 2800, "verde", 'A', 80); // Objeto con errores para comprobar si funcionan las validaciones
            electrodomesticos[9] = new Television(7200, true, 2000, "negro", 'W', 180); // Objeto con errores para comprobar si funcionan las validaciones

            double totalPrecioElectrodomesticos = 0;
            double totalPrecioLavadoras = 0;
            double totalPrecioTelevisiones = 0;

            foreach (var electrodomestico in electrodomesticos)
            {
                double precioFinal = electrodomestico.precioFinal();
                totalPrecioElectrodomesticos += precioFinal;

                if (electrodomestico is Lavadora)
                {
                    totalPrecioLavadoras += precioFinal;
                }
                else if (electrodomestico is Television)
                {
                    totalPrecioTelevisiones += precioFinal;
                }
            }

            Console.WriteLine($"Total precio de Electrodomésticos: ${totalPrecioElectrodomesticos}");
            Console.WriteLine($"Total precio de Lavadoras: ${totalPrecioLavadoras}");
            Console.WriteLine($"Total precio de Televisores: ${totalPrecioTelevisiones}");

            // Pausear consola
            Console.Read();
        }
    }
}
