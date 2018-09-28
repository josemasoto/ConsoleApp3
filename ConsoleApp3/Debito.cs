using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Debito : Cuenta
    {
        private decimal Transaccion;

        public Debito(decimal saldo, decimal transaccion) : base(saldo)
        {
            this.Transaccion = transaccion;
        }

        //public Debito(decimal saldo) => this.Saldo = saldo;

        public override decimal GetNuevoSaldo()
        {
            base.Saldo = Saldo - Transaccion;
            return Saldo;
        }
    }
}
