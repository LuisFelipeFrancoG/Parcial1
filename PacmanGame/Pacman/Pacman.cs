using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace PacmanGame.Pacman
{
    public class Pacman : Personaje, IMovible
    {
        public Direccion DireccionActual { get; private set; }

        public Pacman(string nombre, int velocidad)
            : base(nombre, velocidad)
        {
            DireccionActual = Direccion.Derecha;
        }

        public override void Mover()
        {
            Console.WriteLine($"{Nombre} se mueve hacia {DireccionActual} a una velocidad de {Velocidad}.");
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Pacman: {Nombre}, Velocidad: {Velocidad}, Dirección: {DireccionActual}");
        }

        public void CambiarDireccion(Direccion nuevaDireccion)
        {
            DireccionActual = nuevaDireccion;
            Console.WriteLine($"Pacman ha cambiado de dirección a {DireccionActual}.");
        }
    }
}