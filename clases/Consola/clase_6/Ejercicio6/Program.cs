using System;

namespace Ejercicio6
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Crear dos arrays, uno de Series y otro de Videojuegos, de 5 posiciones cada uno
            Serie[] series = new Serie[5];
            Videojuego[] videojuegos = new Videojuego[5];

            // Crear un objeto en cada posición del array, con valores, se pueden usar distintos constructores
            series[0] = new Serie();
            series[1] = new Serie("The Office", "Greg Daniels");
            series[2] = new Serie("The Mandalorian", 2, "Ciencia Ficción", "Jon Favreau");
            series[3] = new Serie("The Witcher", 1, "Fantasía", "Lauren Schmidt Hissrich");
            series[4] = new Serie("The Walking Dead", 10, "Drama", "Frank Darabont");

            videojuegos[0] = new Videojuego();
            videojuegos[1] = new Videojuego("The Witcher 3: Wild Hunt", 50);
            videojuegos[2] = new Videojuego("Red Dead Redemption 2", 60, "Aventura", "Rockstar Games");
            videojuegos[3] = new Videojuego("The Last of Us Part II", 30, "Aventura", "Naughty Dog");
            videojuegos[4] = new Videojuego("God of War", 40, "Aventura", "Santa Monica Studio");

            // Entregar algunos Videojuegos y Series con el método entregar()
            videojuegos[0].Entregar();
            videojuegos[2].Entregar();
            series[1].Entregar();
            series[4].Entregar();

            // Contar e informar cuantas Series y Videojuegos hay entregados
            int seriesEntregadas = 0;
            int videojuegosEntregados = 0;

            for (int i = 0; i < series.Length;i++)
            {
                if (series[i].IsEntregado())
                {
                    seriesEntregadas++;
                }
            }

            for (int i = 0; i < videojuegos.Length; i++)
            {
                if (videojuegos[i].IsEntregado())
                {
                    videojuegosEntregados++;
                }
            }

            Console.WriteLine($"Hay {seriesEntregadas} series entregadas y {videojuegosEntregados} videojuegos entregados.");

            // Indicar el Videojuego tiene más horas estimadas y la serie con más temporadas. Mostrarlos en pantalla con toda su información (usar el método toString())
            Videojuego videojuegoMasHoras = videojuegos[0];
            Serie serieMasTemporadas = series[0];

            for (int i = 0; i < videojuegos.Length; i++)
            {
                if (videojuegos[i].GetHorasEstimadas > videojuegoMasHoras.GetHorasEstimadas)
                {
                    videojuegoMasHoras = videojuegos[i];
                }
            }

            for (int i = 0; i < series.Length; i++)
            {
                if (series[i].GetNumeroTemporadas > serieMasTemporadas.GetNumeroTemporadas)
                {
                    serieMasTemporadas = series[i];
                }
            }

            Console.WriteLine($"\nEl videojuego con más horas estimadas es...\n{videojuegoMasHoras}");
            Console.WriteLine($"\nLa serie con más temporadas es...\n{serieMasTemporadas}");

            // Pausar la consola
            Console.Read();
        }
    }
}
