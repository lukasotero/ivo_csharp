using System;

namespace Ejercicio7
{
    public class Raices
    {
        // Atributos
        private double a;
        private double b;
        private double c;

        // Constructor
        public Raices(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        // Métodos
        public void obtenerRaices()
        {
            double x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
            double x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);
        }

        public void obtenerRaiz()
        {
            double x = -b / (2 * a);
            Console.WriteLine("x = " + x);
        }

        public double getDiscriminante()
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }

        public bool tieneRaices()
        {
            return getDiscriminante() >= 0;
        }

        public bool tieneRaiz()
        {
            return getDiscriminante() == 0;
        }

        public void calcular()
        {
            if (tieneRaices())
            {
                obtenerRaices();
            }
            else if (tieneRaiz())
            {
                obtenerRaiz();
            }
            else
            {
                Console.WriteLine("No tiene solución.");
            }
        }
    }
}
