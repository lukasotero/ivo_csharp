namespace Ejercicio6
{
    public class Serie
    {
        // Atributos
        protected string titulo;
        protected int numdetemp = 3;
        protected bool entregado = false;
        protected string genero;
        protected string creador;

        // Constructores
        public Serie() // Acordate de poner los atributos en el constructor
        {
            numdetemp = 3;
            entregado = false;
            genero = "";
            creador = "";
        }

        public Serie(string t, string c) // Acordate que no es necesario cambiarle el nombre a las variables, se arregla con un this.
        {
            t = titulo;
            c = creador;
        }

        public Serie(string t, int nt, string g, string c) 
        {
            t = Titulo;
            nt = Numdetemp;
            g = Genero;
            c = Creador;
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public int Numdetemp
        {
            get { return numdetemp; }
            set { numdetemp = value; }
        }

        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        public string Creador
        {
            get { return creador; }
            set { creador = value; }
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
            return string.Format("El titulo es {0}, su numero de temporadas es {1},su estado de entrega es {2}, su genero es {3} y su creador es {4} dias", titulo, numdetemp, entregado, genero, creador);
        }
    }
}