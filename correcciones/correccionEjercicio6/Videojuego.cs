namespace Ejercicio6
{
    public class Videojuego
    {
        // Atributos
        protected string titulo;
        protected int horasest;
        protected bool entregado;
        protected string genero;
        protected string compañia;

        // Constructores
        public Videojuego() // Acordate de poner los atributos en el constructor
        {
            titulo = "";
            horasest = 10;
            entregado = false;
            genero = "";
            compañia = "";
        }

        public Videojuego(string t, int he) // Acordate que no es necesario cambiarle el nombre a las variables, se arregla con un this.
        {
            titulo = t;
            horasest = he;
        }

        public Videojuego(string ti, int he, string g, string c) // Acordate que no es necesario cambiarle el nombre a las variables, se arregla con un this.
        {
            titulo = ti;
            horasest = he;
            genero = g;
            compañia = c;
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public int Horasest
        {
            get { return horasest; }
            set { horasest = value; }
        }

        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public string Compañia
        {
            get { return compañia; }
            set { compañia = value; }
        }

        public bool Entregar()
        {
            entregado = true;
            return entregado;
        }

        public bool Devolver()
        {
            entregado = false;
            return entregado;
        }

        public bool IsEntregado() { return entregado; }

        // ToString
        public override string ToString()
        {
            return string.Format("El titulo es {0}, sus horas estimadas son {1},su estado de entrega es {2}, su genero es {3} y su compañia es {4} dias", titulo, horasest, entregado, genero, compañia);
        }
    }
}