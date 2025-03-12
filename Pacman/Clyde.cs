using System;

namespace PacmanGame
{
    // Clase concreta para el fantasma Clyde
    public class Clyde : Personaje
    {
        public Clyde(int velocidad)
            : base("Clyde", velocidad)
        {
        }

        public override void Mover()
        {
            Console.WriteLine("Clyde se mueve aleatoriamente cuando está lejos de Pacman y se acerca cuando está cerca.");
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Fantasma: {Nombre} (Velocidad: {Velocidad})");
        }
    }
}