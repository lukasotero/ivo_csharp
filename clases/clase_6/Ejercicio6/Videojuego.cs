namespace Ejercicio6
{
    public class Videojuego
    {
        // Atributos
        private string titulo;
        private int horasEstimadas;
        private bool entregado;
        private string genero;
        private string compania; // Nunca poner tildes o caracteres especiales en los nombres de las variables, en este caso la 'ñ'

        // Constructores
        public Videojuego()
        {
            titulo = "";
            horasEstimadas = 10;
            entregado = false;
            genero = "";
            compania = "";
        }

        public Videojuego(string titulo, int horasEstimadas)
        {
            this.titulo = titulo;
            this.horasEstimadas = horasEstimadas;
            entregado = false;
            genero = "";
            compania = "";
        }

        public Videojuego(string titulo, int horasEstimadas, string genero, string compania)
        {
            this.titulo = titulo;
            this.horasEstimadas = horasEstimadas;
            entregado = false;
            this.genero = genero;
            this.compania = compania;
        }

        // Métodos
        public void Entregar() => entregado = true;
        public void Devolver() => entregado = false;
        public bool IsEntregado() => entregado;

        // Getters y Setters
        public string GetTitulo { get { return titulo; } }
        public string SetTitulo { set { titulo = value; } }
        public int GetHorasEstimadas { get { return horasEstimadas; } }
        public int SetHorasEstimadas { set { horasEstimadas = value; } }
        public string GetGenero { get { return genero; } }
        public string SetGenero { set { genero = value; } }
        public string GetCompania { get { return compania; } }
        public string SetCompania { set { compania = value; } }

        // ToString
        public override string ToString()
        {
            return $"Titulo: {titulo}\nHoras estimadas: {horasEstimadas}\nEntregado: {entregado}\nGénero: {genero}\nCompañía: {compania}";
        }
    }
}
