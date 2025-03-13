using System;

namespace PacmanGame
{
    // Clase concreta para el fantasma Inky
    public class Inky : Personaje
    {
        public Inky(int velocidad)
            : base("Inky", velocidad)
        {
        }

        public override void Mover()
        {
            Console.WriteLine("Inky utiliza la posición de Pacman y la de Blinky para calcular su movimiento.");
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Fantasma: {Nombre} (Velocidad: {Velocidad})");
        }
    }
}