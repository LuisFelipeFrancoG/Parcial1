using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMundial
{
    public abstract class CuentaBancaria
    {
        public string NombreTitular { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string NIT { get; set; }
        public decimal Saldo { get; protected set; }

        protected CuentaBancaria(string nombreTitular, string apellidos, string direccion, string nit, decimal saldoInicial)
        {
            NombreTitular = nombreTitular;
            Apellidos = apellidos;
            Direccion = direccion;
            NIT = nit;
            Saldo = saldoInicial;
        }

        public abstract void Depositar(decimal cantidad);
        public abstract void Retirar(decimal cantidad);
        public abstract void ConsultarSaldo();
        public abstract void MostrarInformacion();
    }
}