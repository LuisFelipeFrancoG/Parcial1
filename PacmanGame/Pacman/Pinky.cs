using System;

namespace PacmanGame.Pacman

{
    public class Pinky : Personaje
    {
        public Pinky(string nombre, int velocidad)
            : base(nombre, velocidad)
        {
        }

        public override void Mover()
        {
            Console.WriteLine($"{Nombre} intenta interceptar a Pac-Man adelantándose a su posición con velocidad {Velocidad}.");
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Fantasma Pinky: {Nombre}, Velocidad: {Velocidad}");
        }
    }
}