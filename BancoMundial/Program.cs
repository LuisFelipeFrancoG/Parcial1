using System;
using Banco;

namespace BancoMundial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese sus apellidos: ");
            string apellidos = Console.ReadLine();
            Console.Write("Ingrese su dirección: ");
            string direccion = Console.ReadLine();
            Console.Write("Ingrese su NIT: ");
            string nit = Console.ReadLine();
            Console.Write("Ingrese el saldo inicial: ");
            decimal saldoInicial = Convert.ToDecimal(Console.ReadLine());

            CuentaCorriente cuenta = new CuentaCorriente(nombre, apellidos, direccion, nit, saldoInicial);

            int opcion = 0;
            do
            {
                Console.WriteLine("----- MENÚ -----");
                Console.WriteLine("1. Depositar");
                Console.WriteLine("2. Retirar");
                Console.WriteLine("3. Consultar Saldo");
                Console.WriteLine("4. Mostrar información de la cuenta");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese cantidad a depositar: ");
                        decimal dep = Convert.ToDecimal(Console.ReadLine());
                        cuenta.Depositar(dep);
                        break;
                    case 2:
                        Console.Write("Ingrese cantidad a retirar: ");
                        decimal ret = Convert.ToDecimal(Console.ReadLine());
                        cuenta.Retirar(ret);
                        break;
                    case 3:
                        cuenta.ConsultarSaldo();
                        break;
                    case 4:
                        cuenta.MostrarInformacion();
                        break;
                    case 5:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
                Console.WriteLine();
            }
            while (opcion != 5);
        }
    }
}