namespace correccionRecuperatorio2
{
    public class Taxi : Vehiculo
    {
        // Atributos
        public string NumeroLicencia { get; set; }
        public double BajadaBandera { get; set; }
        public double PrecioPorKm { get; set; }

        // Constructor
        public Taxi(string patente, string marca, int potenciaCV, string numeroLicencia, double bajadaBandera, double precioPorKm) : base(patente, marca, potenciaCV)
        {
            NumeroLicencia = numeroLicencia;
            BajadaBandera = bajadaBandera;
            PrecioPorKm = precioPorKm;
        }

        // Métodos
        public double CalcularValorViaje(int km)
        {
            return BajadaBandera + (km * PrecioPorKm);
        }

        // ToString
        public override string ToString()
        {
            return base.ToString() + $", NumeroLicencia: {NumeroLicencia}, BajadaBandera: {BajadaBandera}, PrecioPorKm: {PrecioPorKm}";
        }
    }
}