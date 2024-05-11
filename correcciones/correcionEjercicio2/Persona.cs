using System;

namespace ejercicio_2
{
    public class Persona
    {
        private string nombre;
        private int edad = 0;
        private int dni; // El DNI no tendria que estar inicializado en 0, segun el enunciado
        private char sexo = 'H';
        private float peso = 0;
        private float altura = 0;
        // int i;
        private Random rnd = new Random();

        // Constructores
        public Persona()
        {
            // Acordate de agregar en el constructor vacio los valores default del enunciado
            nombre = ""; // Agregado en la correción
            edad = 0; // Agregado en la correción
            sexo = "H"; // Agregado en la correción
            peso = 0; // Agregado en la correción
            altura = 0; // Agregado en la correción
            dni = Documento(); // Acordate de generar el DNI y guardarlo en alguna variable
        }

        // No hace falta ponerle otro nombre a los parametros (con el .this podes ayudarte)
        public Persona(string n, int a, char s)
        {
            Nombre = n;
            Edad = a;
            // ComprobarSexo(s);

            // Agregado en la correción
            if (!ComprobarSexo(sexo))
            {
                this.sexo = "H";
            }
            else
            {
                this.sexo = sexo;
            }

            dni = Documento(); // Acordate de generar el DNI y guardarlo en alguna variable
        }

        // No hace falta ponerle otro nombre a los parametros (con el .this podes ayudarte)
        public Persona(string name, int age, char sex, float weight, float height)
        {
            Nombre = name;
            Edad = age;
            // ComprobarSexo(sex);
            // Agregado en la correción
            if (!ComprobarSexo(sexo))
            {
                this.sexo = "H";
            }
            else
            {
                this.sexo = sexo;
            }

            Peso = weight;
            Altura = height;
            dni = Documento(); // Acordate de generar el DNI y guardarlo en alguna variable
        }

        // Métodos
        public int Calcularimc()
        {
            int i = 0;
            peso = peso / (altura * altura);
            if (peso > 25) { i = 1; }
            else if (peso > 20 && peso < 25) { i = 0; }
            else if (peso < 20) { i = -1; }
            return i;
        }

        /*
        public bool MayordeEdad()
        {
            bool valor = true;
            if (edad >= 18) { valor = true; }
            else if (edad < 18) { valor = false; }
            return valor;
        }
        */

        // Forma abreviada de hacer el método MayordeEdad
        public bool MayordeEdad()
        {
            return edad >= 18;
        }

        /*
        public char ComprobarSexo(char sexo)
        {
            char sexo = (sexo != 'H' | sexo != 'M');
            return sexo;
        }
        */

        // Tiene que devolver un boolean
        public bool ComprobarSexo(char sexo)
        {
            return sexo == 'H' || sexo == 'M';
        }

        private void Documento()
        {
            // Random rnd = new Random();
            return rnd.Next(0000000, 99999999);
        }

        // Setters
        public string Nombre { set { nombre = value; } }
        public int Edad { set { edad = value; } }
        public char Sexo { set { sexo = value; } }
        public float Peso { set { peso = value; } }
        public float Altura { set { altura = value; } }

        // ToString
        public override string ToString()
        {
            // return string.Format("El nombre es {0}, su edad es {1}, su sexo es {2}, su peso es {3} y su altura es {4}", nombre, edad, sexo, peso, altura);
            return $"El nombre es {nombre}, su edad es {edad}, su sexo es {sexo}, su peso es {peso} y su altura es {altura}";
        }
    }
}