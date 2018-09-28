using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Cuenta
    {
        public decimal Saldo { get; set; }

        public Cuenta(decimal saldo)
        {
            this.Saldo = saldo;
        }

        public virtual decimal GetNuevoSaldo(){
            return Saldo;
        }
    }
}
