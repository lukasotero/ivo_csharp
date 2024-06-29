using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
    public class Password
    {
        // Atributos
        private int longitud = 8;
        // private char[] contraseña; - Es muchisimo mas facil trabajar con strings que con arrays de caracteres
        private string password;

        // Constructores
        public Password()
        {
            // Acordate que en el constructor vacio por lo general van los valores default
            longitud = 8; // Agregado en la corrección
            password = generarPassword(); // Agregado en la corrección
        }

        public Password(int l)
        {
            longitud = l; // Acordate que no hace falta cambiar el nombre de variable, podes utilizar el .this
            password = generarPassword();
        }

        /*public char[] Contraseña
        {
            private set { contraseña = value; }
            get { return contraseña; }
        }

        public int Longitud
        {
            private set { longitud = value; }
            get { return longitud; }
        }*/

        // Getters y Setters
        public string getPassword()
        {
            return password;
        }

        public int getLongitud()
        {
            return longitud;
        }

        private void setPassword(string password)
        {
            this.password = password;
        }

        private void setLongitud(int longitud)
        {
            this.longitud = longitud;
        }

        /*public bool esFuerte()
        {
            int mayuscula = 0;
            int minuscula = 0;
            int numero = 0;
            bool tf;
            int i;
            for (i = 0; i < longitud; i++)
            {
                if (contraseña[i] > 64 && contraseña[i] < 91)
                { mayuscula++; }
                else if (contraseña[i] > 96 && contraseña[i] < 123)
                { minuscula++; }
                else if (contraseña[i] > 48 && contraseña[i] < 57)
                { numero++; }
            }
            if (mayuscula < 2 && minuscula < 1 && numero < 5)
            { tf = true; }
            else { tf = false; }
            return tf;
        }*/

        public bool esFuerte()
        {
            int mayusculas = 0;
            int minusculas = 0;
            int numeros = 0;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsUpper(password[i]))
                {
                    mayusculas++;
                }
                else if (char.IsLower(password[i]))
                {
                    minusculas++;
                }
                else if (char.IsDigit(password[i]))
                {
                    numeros++;
                }
            }

            return mayusculas >= 2 && minusculas >= 1 && numeros >= 5;
        }

        /* public char[] generarPassword()
        {
            int c;
            for (int i = 0; i < longitud; i++)
            {
                Random rnd = new Random();
                c = rnd.Next(0, 2);
                switch (c)
                {
                    case 0:
                        Random num = new Random();
                        Contraseña[i] = Convert.ToChar(num.Next(48, 57));
                        break;
                    case 1:
                        Random mayus = new Random();
                        Contraseña[i] = Convert.ToChar(mayus.Next(65, 90));
                        break;
                    case 2:
                        Random min = new Random();
                        Contraseña[i] = Convert.ToChar(min.Next(97, 122));
                        break;
                }
            }
            return contraseña;
        }*/

        public string generarPassword()
        {
            Random random = new Random();
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"; // Todos los caracteres que se pueden utilizar
            StringBuilder password = new StringBuilder(); // StringBuilder es más eficiente que concatenar strings, pero si queres podes usar la concatenación común

            for (int i = 0; i < longitud; i++)
            {
                // .Append agrega un caracter al final del string
                password.Append(caracteres[random.Next(caracteres.Length)]);
            }

            return password.ToString();
        }
    }
}