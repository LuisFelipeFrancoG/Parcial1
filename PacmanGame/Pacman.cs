using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace PacmanGame
{
    class Pacman : Personaje, IMovible
    {
        private Direccion direccionActual;

        public Pacman(string nombre, int velocidad) : base(nombre, velocidad)
        {
            direccionActual = Direccion.Derecha; // Por defecto, Pacman inicia moviéndose a la derecha
        }

        public override void Mover()
        {
            Console.WriteLine($"{Nombre} se está moviendo en dirección {direccionActual} con velocidad {Velocidad}.");
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Personaje: {Nombre}");
            Console.WriteLine($"Velocidad: {Velocidad}");
            Console.WriteLine($"Dirección actual: {direccionActual}");
        }

        public void CambiarDireccion(Direccion nuevaDireccion)
        {
            direccionActual = nuevaDireccion;
            Console.WriteLine($"{Nombre} ha cambiado de dirección a {direccionActual}.");
        }
    }
}
