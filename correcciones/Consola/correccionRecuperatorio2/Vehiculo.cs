namespace correccionRecuperatorio2
{
    public class Vehiculo
    {
        // Atributos
        public string Patente { get; set; }
        public string Marca { get; set; }
        public int PotenciaCV { get; set; }

        // Constructor
        public Vehiculo(string patente, string marca, int potenciaCV)
        {
            Patente = patente;
            Marca = marca;
            PotenciaCV = potenciaCV;
        }

        // Métodos
        public bool EsVeloz()
        {
            return PotenciaCV > 200;
        }

        // ToString
        public override string ToString()
        {
            return $"Patente: {Patente}, Marca: {Marca}, PotenciaCV: {PotenciaCV}";
        }
    }
}
