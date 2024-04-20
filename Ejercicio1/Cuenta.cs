using System;

namespace Ejercicio1
{
    public class Cuenta
    {
        // Atributos
        private int saldo;

        // Constructor
        public Cuenta(int saldo)
        {
            this.saldo = saldo;
        }

        // Métodos
        public void Acreditar(int saldo)
        {
            if (saldo > 0)
            {
                this.saldo += saldo;
            } else
            {
                Console.WriteLine("El monto a acreditar no puede ser menor que 0.");
            }
        }

        // Getter
        public int GetSaldo()
        { 
            return saldo; 
        }
    }
}
