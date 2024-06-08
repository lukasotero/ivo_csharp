namespace Ejercicio8
{
    public class Contacto
    {
        // Atributos con sus Getters y Setters
        public string Nombre { get; set; }
        public string Telefono { get; set; }

        // Constructor
        public Contacto(string nombre, string telefono)
        {
            Nombre = nombre;
            Telefono = telefono;
        }

        // ToString
        public override string ToString()
        {
            return "Nombre: " + Nombre + ", Teléfono: " + Telefono;
        }

        // Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Contacto other = (Contacto)obj;
            return Nombre == other.Nombre;
        }

        // GetHashCode
        public override int GetHashCode() // Este método se utiliza para obtener un código hash del objeto
        {
            return Nombre.GetHashCode(); // Devuelve el hash del nombre
        }
    }
}
