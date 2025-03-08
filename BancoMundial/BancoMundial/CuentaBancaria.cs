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
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public int NIT { get; set; }
        public decimal Saldo { get; set; }

        public CuentaBancaria(string nombreTitular, string apellido, string direccion, int nIT, decimal saldo)
        {
            NombreTitular = nombreTitular;
            Apellido = apellido;
            Direccion = direccion;
            NIT = nIT;
            Saldo = saldo;
        }

        public abstract void Despositar(decimal Cantidad);

        public abstract decimal Retirar(decimal Cantidad);

        public abstract decimal ConsultarSaldo();

        public abstract void MostrarInformacion();
    }
}
