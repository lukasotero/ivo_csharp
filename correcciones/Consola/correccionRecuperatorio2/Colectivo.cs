namespace correccionRecuperatorio2
{
    public class Colectivo : Vehiculo
    {
        // Atributos
        public int CantidadPasajeros { get; set; }
        public int NumeroLinea { get; set; }
        public int CantidadParadas { get; set; }

        // Constructor
        public Colectivo(string patente, string marca, int potenciaCV, int cantidadPasajeros, int numeroLinea, int cantidadParadas) : base(patente, marca, potenciaCV)
        {
            CantidadPasajeros = cantidadPasajeros;
            NumeroLinea = numeroLinea;
            CantidadParadas = cantidadParadas;
        }

        // Métodos
        public double CalcularValorViaje()
        {
            return CantidadParadas * 75;
        }

        // ToString
        public override string ToString()
        {
            return base.ToString() + $", CantidadPasajeros: {CantidadPasajeros}, NumeroLinea: {NumeroLinea}, CantidadParadas: {CantidadParadas}";
        }
    }
}
