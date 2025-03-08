using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACMAN
{
    public abstract class Personaje
    {
        public string Nombre;

        public string Velocidad;

        public abstract void Mover();
        public abstract string MostrarInformacion();
    }
}
