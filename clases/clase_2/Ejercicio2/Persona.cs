using System;

namespace Ejercicio2
{
    public class Persona
    {
        // Atributos
        private string nombre;
        private int edad;
        private readonly int dni;
        private string sexo;
        private double peso;
        private double altura;

        private static readonly Random random = new Random();

        // Constructores
        public Persona()
        {
            nombre = "";
            edad = 0;
            sexo = "H";
            peso = 0;
            altura = 0;
            dni = GeneraDNI();
        }

        public Persona(string nombre, int edad, string sexo)
        {
            this.nombre = nombre;
            this.edad = edad;

            // Verificar el sexo antes de asignarle el valor
            if (!ComprobarSexo(sexo))
            {
                this.sexo = "H";
            }
            else
            {
                this.sexo = sexo;
            }

            peso = 0;
            altura = 0;
            dni = GeneraDNI();
        }

        public Persona(string nombre, int edad, string sexo, double peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;

            // Verificar el sexo antes de asignarle el valor
            if (!ComprobarSexo(sexo))
            {
                this.sexo = "H";
            }
            else
            {
                this.sexo = sexo;
            }

            this.peso = peso;
            this.altura = altura;
            dni = GeneraDNI();
        }

        // Métodos
        public int CalcularIMC()
        {
            double imc = peso / Math.Pow(altura, 2);

            if (imc < 20)
            {
                return -1;
            }
            else if (imc >= 20 && imc <= 25)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public bool EsMayorDeEdad()
        {
            return edad >= 18;
        }

        private bool ComprobarSexo(string sexo)
        {
            return sexo == "H" || sexo == "M";
        }

        private int GeneraDNI()
        {
            return random.Next(10000000, 99999999); // Genera un número aleatorio de 8 dígitos
        }

        // Setters
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetEdad(int edad)
        {
            this.edad = edad;
        }

        public void SetSexo(string sexo)
        {
            this.sexo = sexo;
        }

        public void SetPeso(double peso)
        {
            this.peso = peso;
        }

        public void SetAltura(double altura)
        {
            this.altura = altura;
        }


        // ToString
        public override string ToString()
        {
            return "Nombre: " + nombre + ", Edad: " + edad + ", DNI: " + dni + ", Sexo: " + sexo + ", Peso: " + peso + ", Altura: " + altura;
        }
    }
}
