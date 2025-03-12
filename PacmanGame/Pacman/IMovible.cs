using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGame.Pacman

{
    interface IMovible
    {
        void CambiarDireccion(Direccion nuevaDireccion);
    }
}