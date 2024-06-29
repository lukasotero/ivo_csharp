namespace Ejercicio5._1
{
    public class Lavadora : Electrodomestico
    {
        // Atributos
        private double carga;

        // Constructores
        public Lavadora() : base()
        {
            carga = 5;
        }

        public Lavadora(double precioBase, double peso) : base(precioBase, peso)
        {
            carga = 5;
        }

        public Lavadora(double carga, double precioBase, string color, char consumoEnergetico, double peso) : base(precioBase, color, consumoEnergetico, peso)
        {
            this.carga = carga;
        }

        // Métodos
        public override double precioFinal()
        {
            double precio = base.precioFinal();
            if (Carga > 30)
            {
                precio += 50;
            }
            return precio;
        }

        // Getters
        public double Carga { get { return carga; } }
    }
}
