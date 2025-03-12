using System;

namespace PacmanGame
{
    // Clase concreta para el fantasma Pinky
    public class Pinky : Personaje
    {
        public Pinky(int velocidad)
            : base("Pinky", velocidad)
        {
        }

        public override void Mover()
        {
            Console.WriteLine("Pinky intenta interceptar a Pacman adelantándose a su posición.");
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Fantasma: {Nombre} (Velocidad: {Velocidad})");
        }
    }
}