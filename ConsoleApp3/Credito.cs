using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
   
    internal class Credito : Cuenta
    {
        private decimal Transaccion;

        public Credito(decimal saldo, decimal transaccion) : base(saldo)
        {
            this.Transaccion = transaccion;
        }

        //public Debito(decimal saldo) => this.Saldo = saldo;

        public override decimal GetNuevoSaldo()
        {
            base.Saldo = Saldo + Transaccion;
            return Saldo;
        }

        public virtual decimal AddCredito(decimal operacion)
        {
            base.Saldo = base.Saldo - operacion;

            return base.Saldo;
        }
    }
}
