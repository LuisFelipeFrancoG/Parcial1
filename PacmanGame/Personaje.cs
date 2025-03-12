using System;

namespace PacmanGame
{
    public abstract class Personaje
    {
        public string Nombre { get; set; }
        public int Velocidad { get; set; }

        protected Personaje(string nombre, int velocidad)
        {
            Nombre = nombre;
            Velocidad = velocidad;
        }

        public abstract void Mover();
        public abstract void MostrarInformacion();
    }
}