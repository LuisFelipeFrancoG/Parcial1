using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar a Pac-Man y asignarle una dirección inicial
            Pacman pacman = new Pacman("Pac-Man", 5);

            // Instanciar fantasmas: Pinky, Inky y Clyde
            List<Personaje> fantasmas = new List<Personaje>
            {
                new Pinky("Pinky", 4),
                new Inky("Inky", 5),
                new Clyde("Clyde", 3)
            };

            int opcion = 0;
            do
            {
                Console.WriteLine("----- MENÚ PAC-MAN -----");
                Console.WriteLine("1. Mover Pac-Man");
                Console.WriteLine("2. Mover Fantasmas");
                Console.WriteLine("3. Cambiar dirección de Pac-Man");
                Console.WriteLine("4. Mostrar información de personajes");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Ingrese un número válido.");
                    continue;
                }

                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        pacman.Mover();
                        break;
                    case 2:
                        foreach (var fantasma in fantasmas)
                        {
                            fantasma.Mover();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Elija nueva dirección:");
                        Console.WriteLine("1. Arriba");
                        Console.WriteLine("2. Abajo");
                        Console.WriteLine("3. Izquierda");
                        Console.WriteLine("4. Derecha");
                        Console.Write("Seleccione: ");
                        int dir;
                        if (int.TryParse(Console.ReadLine(), out dir) && dir >= 1 && dir <= 4)
                        {
                            // Convertir la selección al enum Direccion (asumiendo que Arriba=0, Abajo=1, Izquierda=2, Derecha=3)
                            Direccion nuevaDireccion = (Direccion)(dir - 1);
                            pacman.CambiarDireccion(nuevaDireccion);
                        }
                        else
                        {
                            Console.WriteLine("Opción de dirección inválida.");
                        }
                        break;
                    case 4:
                        pacman.MostrarInformacion();
                        foreach (var fantasma in fantasmas)
                        {
                            fantasma.MostrarInformacion();
                        }
                        break;
                    case 5:
                        Console.WriteLine("Saliendo del juego...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
                Console.WriteLine();
            } while (opcion != 5);
        }
    }
}