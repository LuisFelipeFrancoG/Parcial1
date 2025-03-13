using System;

namespace PacmanGame

{
    public class Blinky : Personaje
    {
        public Blinky(string nombre, int velocidad)
            : base(nombre, velocidad)
        {
        }

        public override void Mover()
        {
            
            Console.WriteLine($"{Nombre} persigue a Pac-Man con una velocidad de {Velocidad}.");
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Fantasía: {Nombre}, Velocidad: {Velocidad}");
        }
    }
}