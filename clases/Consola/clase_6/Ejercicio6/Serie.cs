namespace Ejercicio6
{
    public class Serie
    {
        // Atributos
        private string titulo;
        private int numeroTemporadas;
        private bool entregado;
        private string genero;
        private string creador;

        // Constructores
        public Serie()
        {
            numeroTemporadas = 3;
            entregado = false;
            genero = "";
            creador = "";
        }

        public Serie(string titulo, string creador)
        {
            this.titulo = titulo;
            this.creador = creador;
            numeroTemporadas = 3;
            entregado = false;
            genero = "";
        }

        public Serie(string titulo, int numeroTemporadas, string genero, string creador)
        {
            this.titulo = titulo;
            this.numeroTemporadas = numeroTemporadas;
            entregado = false;
            this.genero = genero;
            this.creador = creador;
        }

        // Métodos
        public void Entregar() => entregado = true;
        public void Devolver() => entregado = false;
        public bool IsEntregado() => entregado;

        // Getters y Setters
        public string GetTitulo { get { return titulo; } }
        public string SetTitulo { set { titulo = value; } }
        public int GetNumeroTemporadas { get { return numeroTemporadas; } }
        public int SetNumeroTemporadas { set { numeroTemporadas = value; } }
        public string GetGenero { get { return genero; } }
        public string SetGenero { set { genero = value; } }
        public string GetCreador { get { return creador; } }
        public string SetCreador { set { creador = value; } }

        // ToString
        public override string ToString()
        {
            return "Titulo: " + titulo + "\nNúmero de temporadas: " + numeroTemporadas + "\nEntregado: " + entregado + "\nGénero: " + genero + "\nCreador: " + creador;
        }
    }
}
