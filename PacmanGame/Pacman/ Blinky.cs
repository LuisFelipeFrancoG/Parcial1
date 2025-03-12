using System;

namespace PacmanGame.Pacman

{
    // Clase concreta para el fantasma Blinky
    public class Blinky : Personaje
    {
        public Blinky(int velocidad)
            : base("Blinky", velocidad)
        {
        }

        public override void Mover()
        {
            Console.WriteLine("Blinky se mueve persiguiendo directamente a Pacman.");
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Fantasma: {Nombre} (Velocidad: {Velocidad})");
        }
    }
}
