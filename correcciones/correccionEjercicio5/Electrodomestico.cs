using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    public class Electrodomestico
    {
        private float preciob = 100;
        private string color = "blanco";
        private char conselectrico = 'F';
        private float peso = 5;

        public Electrodomestico()
        { 
            preciob = 100;
            color = "blanco";
            conselectrico = 'F';
            peso = 5;
        }

        public Electrodomestico(float preciob, float peso)
        {
            this.preciob = preciob;
            this.peso = peso;
        }
        public Electrodomestico(float preciob, string c, char l, float p)
        {
            this.preciob = preciob;
            peso = p;
            conselectrico = l;
            color = ComprobarColor(c);
        }

        public float Preciob
        {
            get { return preciob; }

        }
        public string Color
        {
            get { return color; }

        }
        public char Conselectrico
        {
            get { return conselectrico; }

        }
        public float Peso
        {
            get { return peso; }

        }

        public char ComprobarConsumo(char letra)
        {
            if (letra >= 'A' && letra <= 'F')
            {
                return letra;
            } else
            {
                return 'F';
            }
        }

        public string ComprobarColor(string color)
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
                    return color;
                default:
                    return "blanco";
            }
            return Color;
        }
        public float Preciofinal()
        {
            switch (conselectrico)
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
                case 'F': preciob =+ 10; break;


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