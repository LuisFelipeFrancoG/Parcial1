using System;

namespace BancoMundial
{
    public class CuentaCorriente : CuentaBancaria, IAuditable
    {
        public CuentaCorriente(string nombreTitular, string apellidos, string direccion, string nit, decimal saldoInicial)
            : base(nombreTitular, apellidos, direccion, nit, saldoInicial)
        {
        }

        public override void Depositar(decimal cantidad)
        {
            if (cantidad > 0)
            {
                Saldo += cantidad;
                AuditarTransaccion("Depósito", cantidad);
            }
            else
            {
                Console.WriteLine("La cantidad a depositar debe ser mayor que cero.");
            }
        }

        public override void Retirar(decimal cantidad)
        {
            if (cantidad > 0 && Saldo >= cantidad)
            {
                Saldo -= cantidad;
                AuditarTransaccion("Retiro", cantidad);
            }
            else
            {
                Console.WriteLine("No hay suficiente saldo o la cantidad es inválida.");
            }
        }

        public override void ConsultarSaldo()
        {
            Console.WriteLine("Saldo actual: " + Saldo);
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("Información de la cuenta:");
            Console.WriteLine("Titular: " + NombreTitular + " " + Apellidos);
            Console.WriteLine("Dirección: " + Direccion);
            Console.WriteLine("NIT: " + NIT);
            Console.WriteLine("Saldo: " + Saldo);
        }

        public void AuditarTransaccion(string tipo, decimal cantidad)
        {
            Console.WriteLine($"[Auditando] Transacción: {tipo}, Cantidad: {cantidad}");
        }
    }
}