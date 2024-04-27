namespace Ejercicio2
{
    public class Cuenta
    {
        // Atributos
        string titular;
        float cantidad;

        // Constructor
        public Cuenta(string titular, float cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        // Métodos
        public void Ingresar(float cantidad)
        {
            if (cantidad > 0)
            {
                this.cantidad += cantidad;
            }
        }

        public void Retirar(float cantidad)
        {
            if (this.cantidad - cantidad < 0)
            {
                this.cantidad = 0;
            }
            else
            {
                this.cantidad -= cantidad;
            }
        }

        // Getter
        public string GetTitular()
        {
            return titular;
        }

        // Setter
        public void SetTitular(string titular)
        {
            this.titular = titular;
        }

        // ToString
        public override string ToString()
        {
            return "Titular: " + titular + "\nCantidad: " + cantidad;
        }
    }
}
