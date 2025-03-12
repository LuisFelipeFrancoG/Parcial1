using System;
using System.Collections.Generic;

namespace PacmanGame.Pacman

{
    // Menú de opciones para gestionar el movimiento de Pacman y de los fantasmas.
    public class MenuPacman
    {
        private Pacman pacman;
        private List<Personaje> fantasmas;

        public MenuPacman()
        {
            // Se inicializa Pacman con una velocidad por defecto.
            pacman = new Pacman("Pacman", 5);

            // Se inicializan los fantasmas con velocidades de ejemplo.
            fantasmas = new List<Personaje>
            {
                new Blinky(6),
                new Pinky(5),
                new Inky(4),
                new Clyde(3)
            };
        }

        public void MostrarMenu()
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("\n--- Menú de Pacman ---");
                Console.WriteLine("1. Mover Pacman");
                Console.WriteLine("2. Cambiar dirección de Pacman");
                Console.WriteLine("3. Mover fantasmas");
                Console.WriteLine("4. Mostrar información de los personajes");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            pacman.Mover();
                            break;
                        case 2:
                            Console.WriteLine("Seleccione dirección: 1. Arriba  2. Abajo  3. Izquierda  4. Derecha");
                            if (int.TryParse(Console.ReadLine(), out int dir))
                            {
                                Direccion nuevaDireccion = Direccion.Derecha;
                                switch (dir)
                                {
                                    case 1:
                                        nuevaDireccion = Direccion.Arriba;
                                        break;
                                    case 2:
                                        nuevaDireccion = Direccion.Abajo;
                                        break;
                                    case 3:
                                        nuevaDireccion = Direccion.Izquierda;
                                        break;
                                    case 4:
                                        nuevaDireccion = Direccion.Derecha;
                                        break;
                                    default:
                                        Console.WriteLine("Dirección no válida.");
                                        break;
                                }
                                pacman.CambiarDireccion(nuevaDireccion);
                            }
                            break;
                        case 3:
                            foreach (Personaje fantasma in fantasmas)
                            {
                                fantasma.Mover();
                            }
                            break;
                        case 4:
                            pacman.MostrarInformacion();
                            foreach (Personaje fantasma in fantasmas)
                            {
                                fantasma.MostrarInformacion();
                            }
                            break;
                        case 5:
                            Console.WriteLine("Saliendo del menú de Pacman.");
                            break;
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida.");
                }
            } while (opcion != 5);
        }
    }
}