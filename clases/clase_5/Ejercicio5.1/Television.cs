namespace Ejercicio5._1
{
    public class Television : Electrodomestico
    {
        // Atributos
        private double resolucion;
        private bool sintonizadorTDT;

        // Constructores
        public Television() : base()
        {
            resolucion = 20;
            sintonizadorTDT = false;
        }

        public Television(double precioBase, double peso) : base(precioBase, peso)
        {
            resolucion = 20;
            sintonizadorTDT = false;
        }

        public Television(double resolucion, bool sintonizadorTDT, double precioBase, string color, char consumoEnergetico, double peso) : base(precioBase, color, consumoEnergetico, peso)
        {
            this.resolucion = resolucion;
            this.sintonizadorTDT = sintonizadorTDT;
        }

        // Métodos
        public override double precioFinal()
        {
            double precio = base.precioFinal();

            if (resolucion > 40)
            {
                precio += precio * 0.3;
            }

            if (sintonizadorTDT)
            {
                precio += 50;
            }

            return precio;
        }

        // Getters
        public double Resolucion { get { return resolucion; } }
        public bool SintonizadorTDT { get { return sintonizadorTDT; } }
    }
}
