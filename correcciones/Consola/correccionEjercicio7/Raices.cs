using System;

namespace Ejercicio_7
{
    public class Raices
    {
        // Atributos
        private int a; // private en vez de protected, el protected para que las clases hijas puedan acceder a estos atributos
        private int b;
        private int c;

        // Constructor
        public Raices(int num, int num1, int num2)
        {
            a = num;
            b = num1;
            c = num2;
        }

        double res1;
        double res2;
        // bool tf, tf1; // No hacen falta

        // Métodos
        public void obtenerRaices() // no deberia devolver nada, en el enunciado dice "imprime"
        {
            res1 = getDiscriminante();
            double raizCuadrada = Math.Sqrt(res1);
            res1 = ((-b + raizCuadrada) / (2 * a));
            res2 = ((-b - raizCuadrada) / (2 * a));

            Console.WriteLine("La primera raiz es: {0}, y la segunda raiz es: {1}", res1, res2);
        }

        public void obtenerRaiz() // no deberia devolver nada, en el enunciado dice "imprime"
        {
            // return string.Format("La  raiz es :{0}", res1);
            double x = -b / (2 * a);
            Console.WriteLine("x = " + x);
        }

        public int getDiscriminante()
        {
            // int aux = 0; // No hace falta
            int aux = (b * b) - (4 * a * c);
            // int aux = Math.Pow(b, 2) - 4 * a * c; // Podes hacerlo de esta otra manera, con las formulas de matemáticas
            return aux;
        }

        public bool tieneRaices()
        {
            // bool aux = false;
            // aux = true;
            // return aux;
            return getDiscriminante() >= 0; // Si la discriminante es mayor o igual a 0, entonces tiene raíces
        }

        public bool tieneRaiz()
        {
            // bool aux = true;
            // aux = false;
            // return aux;
            return getDiscriminante() == 0; // Si la discriminante es igual a 0, entonces tiene una raíz
        }

        public void Calcular()
        {
            // getDiscriminante(); // Esto no va aca
            // res1 = getDiscriminante(); // Esto no va aca
            // double raizCuadrada = Math.Sqrt(res1); // Esto no va aca
            // res1 = ((-b + raizCuadrada) / (2 * a)); // Esto no va aca
            // res2 = ((-b - raizCuadrada) / (2 * a)); // Esto no va aca

            if (tieneRaices())
            {
                // tf1 = tieneRaiz(); // No hace falta guardar en tf1
                obtenerRaices();
            }
            else if (tieneRaiz())
            {
                // tf1 = tieneRaices(); // No hace falta guardar en tf1
                obtenerRaiz();
            }
            else // Agrego esta condición, lo pide el enunciado
            {
                Console.WriteLine("No tiene solución.");
            }
        }

        // El ToString no lo pide, no hace falta agregarlo si no lo vas a usar
        //public override string ToString()
        //{
        //    string retorno = "";
        //    if (tf1 == false)
        //    {
        //        retorno = obtenerRaiz();
        //    }
        //    else if (tf1 == true)
        //    {
        //        retorno = obtenerRaices();
        //    }
        //    return retorno;
        //}
    }
}