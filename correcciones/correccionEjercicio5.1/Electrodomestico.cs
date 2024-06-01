using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace correccionEjercicio5._1
{
    // Acordate que el nombre de la clase siempre es en singular, cambié 'Electrodomesticos' por 'Electrodomestico'
    public class Electrodomestico
    {
        protected float preciob = 100; // Recomendación: cambiar el nombre de la variable a 'precioBase'
        protected string color = "blanco";
        protected char consumoelectrico = 'F'; // Recomendación: cambiar el nombre de la variable a 'consumoEnergetico'
        protected float peso = 5;

        // Acordate de llenar el constructor sin parámetros con los valores default
        public Electrodomestico()
        {
            preciob = 100;
            color = "blanco";
            consumoelectrico = 'F';
            peso = 5;
        }

        public Electrodomestico(float pb, float p) // Acordate que podes usar el .this en vez de cambiarle el nombre a la variable
        {
            preciob = pb;
            peso = p;

            // Falta inicializar las variables 'color' y 'consumoenergetico'
            color = "blanco";
            consumoelectrico = 'F';
        }

        public Electrodomestico(float pb2, string c, char ce, float pe) // Acordate que podes usar el this. en vez de cambiarle el nombre a la variable
        {
            preciob = pb2;
            color = c;
            consumoelectrico = ce;
            peso = pe;
        }

        // Getters
        public float Preciob
        {
            get { return preciob; }
        }
        public string Color
        {
            get { return color; }
        }
        public char Consumoelectrico
        {
            get { return consumoelectrico; }
        }
        public float Peso
        {
            get { return peso; }
        }

        // Métodos
        public char ComprobarConsumo(char letra)
        {
            if (letra <= 'A' || letra >= 'F')
            {
                letra = 'F';
            }
            else if (letra >= 'A' && letra <= 'F')
            {

            }
            return letra;
        }

        public string ComprobarColor()
        {
            switch (color)
            {
                case "blanco":
                    break;

                case "negro":
                    break;

                case "rojo":
                    break;

                case "azul":
                    break;

                case "gris":
                    break;

                default:
                    color = "blanco";
                    break;
            }
            return Color;
        }

        public virtual float Preciofinal()
        {
            switch (consumoelectrico)
            {
                case 'A':
                    preciob = preciob + 100;
                    break;
                case 'B':
                    preciob = preciob + 80;
                    break;
                case 'C':
                    preciob = preciob + 60;
                    break;
                case 'D':
                    preciob = preciob + 50;
                    break;
                case 'E':
                    preciob = preciob + 30;
                    break;
                case 'F':
                    preciob = preciob + 10;
                    break;
            }
            if (peso == 0 && peso < 20)
            {
                preciob = preciob + 10;
            }
            else if (peso == 20 && peso < 50)
            {
                preciob = preciob + 50;
            }
            else if (peso == 50 && peso < 80)
            {
                preciob = preciob + 80;
            }
            else if (peso > 80)
            {
                preciob = preciob + 100;
            }
            return Preciob;
        }
    }
}
