using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

// Clase abstracta CuentaBancaria
abstract class CuentaBancaria {
    public string Nombre { get; set; }
    public string Apellidos { get; set; }
    public string Direccion { get; set; }
    public string NIT { get; set; }
    protected decimal Saldo;

    public CuentaBancaria(string nombre, string apellidos, string direccion, string nit, decimal saldoInicial) {
        Nombre = nombre;
        Apellidos = apellidos;
        Direccion = direccion;
        NIT = nit;
        Saldo = saldoInicial;
    }

    public abstract void Depositar(decimal cantidad);
    public abstract void Retirar(decimal cantidad);
    public abstract decimal ConsultarSaldo();
    public abstract void MostrarInformacion();
}

// Interfaz IAuditable
interface IAuditable {
    void AuditarTransaccion(string tipo, decimal cantidad);
}

// Clase CuentaCorriente
class CuentaCorriente : CuentaBancaria, IAuditable {
    public CuentaCorriente(string nombre, string apellidos, string direccion, string nit, decimal saldoInicial)
        : base(nombre, apellidos, direccion, nit, saldoInicial) { }

    public override void Depositar(decimal cantidad) {
        Saldo += cantidad;
        Console.WriteLine($"Depósito de {cantidad:C} realizado con éxito.");
        AuditarTransaccion("Depósito", cantidad);
    }

    public override void Retirar(decimal cantidad) {
        if (Saldo >= cantidad) {
            Saldo -= cantidad;
            Console.WriteLine($"Retiro de {cantidad:C} realizado con éxito.");
            AuditarTransaccion("Retiro", cantidad);
        } else {
            Console.WriteLine("Fondos insuficientes para realizar el retiro.");
        }
    }

    public override decimal ConsultarSaldo() {
        return Saldo;
    }

    public override void MostrarInformacion() {
        Console.WriteLine($"Titular: {Nombre} {Apellidos}\nDirección: {Direccion}\nNIT: {NIT}\nSaldo: {Saldo:C}");
    }

    public void AuditarTransaccion(string tipo, decimal cantidad) {
        Console.WriteLine($"[AUDITORÍA] {tipo} de {cantidad:C} registrado correctamente.");
    }
}

// Menú principal
class Program {
    static void Main() {
        Console.WriteLine("Ingrese su nombre:");
        string nombre = Console.ReadLine();
        Console.WriteLine("Ingrese sus apellidos:");
        string apellidos = Console.ReadLine();
        Console.WriteLine("Ingrese su dirección:");
        string direccion = Console.ReadLine();
        Console.WriteLine("Ingrese su NIT:");
        string nit = Console.ReadLine();
        Console.WriteLine("Ingrese el saldo inicial:");
        decimal saldoInicial = Convert.ToDecimal(Console.ReadLine());

        CuentaCorriente cuenta = new CuentaCorriente(nombre, apellidos, direccion, nit, saldoInicial);

        int opcion;
        do {
            Console.WriteLine("\nSeleccione una opción:");
            Console.WriteLine("1. Depositar");
            Console.WriteLine("2. Retirar");
            Console.WriteLine("3. Consultar Saldo");
            Console.WriteLine("4. Mostrar Información");
            Console.WriteLine("5. Salir");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion) {
                case 1:
                    Console.WriteLine("Ingrese la cantidad a depositar:");
                    decimal deposito = Convert.ToDecimal(Console.ReadLine());
                    cuenta.Depositar(deposito);
                    break;
                case 2:
                    Console.WriteLine("Ingrese la cantidad a retirar:");
                    decimal retiro = Convert.ToDecimal(Console.ReadLine());
                    cuenta.Retirar(retiro);
                    break;
                case 3:
                    Console.WriteLine($"Saldo actual: {cuenta.ConsultarSaldo():C}");
                    break;
                case 4:
                    cuenta.MostrarInformacion();
                    break;
                case 5:
                    Console.WriteLine("Saliendo del sistema...");
                    break;
                default:
                    Console.WriteLine("Opción no válida, intente de nuevo.");
                    break;
            }
        } while (opcion != 5);
    }
}
