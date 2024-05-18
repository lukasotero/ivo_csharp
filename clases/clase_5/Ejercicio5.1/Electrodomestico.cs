namespace Ejercicio5._1
{
    public class Electrodomestico
    {
        // Atributos
        private double precioBase;
        private string color;
        private char consumoEnergetico;
        private double peso;

        // Constructores
        public Electrodomestico()
        {
            precioBase = 100;
            color = "blanco";
            consumoEnergetico = 'F';
            peso = 5;
        }

        public Electrodomestico(double precioBase, double peso)
        {
            this.precioBase = precioBase;
            color = "blanco";
            consumoEnergetico = 'F';
            this.peso = peso;
        }

        public Electrodomestico(double precioBase, string color, char consumoEnergetico, double peso)
        {
            this.precioBase = precioBase;
            this.color = comprobarColor(color);
            this.consumoEnergetico = comprobarConsumoEnergetico(consumoEnergetico);
            this.peso = peso;
        }

        // Métodos
        public char comprobarConsumoEnergetico(char letra)
        {
            if (letra >= 'A' && letra <= 'F')
            {
                return letra;
            }
            else
            {
                return 'F';
            }
        }

        public string comprobarColor(string color)
        {
            switch (color)
            {
                case "blanco":
                case "negro":
                case "rojo":
                case "azul":
                case "gris":
                    return color;
                default:
                    return "blanco";
            }
        }

        public virtual double precioFinal()
        {
            double precio = precioBase;

            switch (consumoEnergetico)
            {
                case 'A':
                    precio += 100;
                    break;
                case 'B':
                    precio += 80;
                    break;
                case 'C':
                    precio += 60;
                    break;
                case 'D':
                    precio += 50;
                    break;
                case 'E':
                    precio += 30;
                    break;
                case 'F':
                    precio += 10;
                    break;
            }

            if (peso < 20)
            {
                precio += 10;
            }
            else if (peso < 50)
            {
                precio += 50;
            }
            else if (peso < 80)
            {
                precio += 80;
            }
            else
            {
                precio += 100;
            }

            return precio;
        }

        // Getters
        public double PrecioBase { get { return precioBase; } }
        public string Color { get { return color; } }
        public char ConsumoEnergetico { get { return consumoEnergetico; } }
        public double Peso { get { return peso; } }
    }
}
