namespace Ejercicio8
{
    internal class Contacto
    {
        protected string num;
        protected string nom;

        public Contacto(string n, string no)
        {
            // Num = n; // Hay que llamar a los atributos y no a los métodos
            // Nom = no; // Hay que llamar a los atributos y no a los métodos
            num = n;
            nom = no;
        }

        public string Num
        {
            set { Num = value; }
            get { return Num; }
        }

        public string Nom
        {
            set { nom = value; }
            get { return nom; }
        }

        // ToString || Se agregó en la corrección
        public override string ToString()
        {
            return "Nombre: " + nom + ", Teléfono: " + num;
        }
    }
}