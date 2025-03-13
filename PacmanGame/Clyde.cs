using System;

namespace PacmanGame
{
    public class Clyde : Personaje
    {
        public Clyde(string nombre, int velocidad)
            : base(nombre, velocidad)
        {
        }

        public override void Mover()
        {
            // Simulación básica de comportamiento aleatorio
            Random rnd = new Random();
            bool estaCerca = rnd.Next(0, 2) == 0; // 0 o 1
            if (estaCerca)
            {
                Console.WriteLine($"{Nombre} se acerca a Pac-Man porque está cerca, con velocidad {Velocidad}.");
            }
            else
            {
                Console.WriteLine($"{Nombre} se mueve aleatoriamente porque está lejos de Pac-Man, con velocidad {Velocidad}.");
            }
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Fantasma Clyde: {Nombre}, Velocidad: {Velocidad}");
        }
    }
}