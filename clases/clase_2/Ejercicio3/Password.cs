using System;
using System.Text;

namespace Ejercicio3
{
    public class Password
    {
        // Atributos
        private int longitud;
        private string password;

        // Constructores
        public Password()
        {
            longitud = 8;
            password = GenerarPassword();
        }

        public Password(int longitud)
        {
            this.longitud = longitud;
            password = GenerarPassword();
        }

        // Métodos
        public bool EsFuerte()
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

        // EsFuerte2() con expresión regular - Era opcional
        public bool EsFuerte2()
        {
            return System.Text.RegularExpressions.Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z]{2,})(?=.*\d{5,}).{8,}$");
        }

        public string GenerarPassword()
        {
            Random random = new Random();
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder password = new StringBuilder();

            for (int i = 0; i < longitud; i++)
            {
                password.Append(caracteres[random.Next(caracteres.Length)]);
            }

            return password.ToString();
        }

        // Getters y Setters
        public string GetPassword()
        {
            return password;
        }

        public int GetLongitud()
        {
            return longitud;
        }

        private void SetPassword(string password)
        {
            this.password = password;
        }

        private void SetLongitud(int longitud)
        {
            this.longitud = longitud;
        }
    }
}
