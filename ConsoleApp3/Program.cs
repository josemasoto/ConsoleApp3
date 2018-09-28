using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta ctaDebito = new Debito(50000, 0);

            Cuenta ctaCredito = new Credito(0, 0);

            Console.WriteLine("Taller Semana 3 ");

            int selec = 0;

            while (selec != 4)
            {
                Console.WriteLine("Seleccione proceso: 1 - Crédito  |  2 - Débito  |  3 - Saldo de Cuentas  |  4 - Salir ");

                string cadselec;

                cadselec = Console.ReadLine();

                selec = Convert.ToInt32(cadselec);

                if (selec == 1)
                {
                    Console.WriteLine("");

                    Console.WriteLine("Seleccionó opción 1 - Crédito ");

                    Console.WriteLine("");

                    Console.WriteLine("Digite monto de venta aplicable a tarjeta de crédito ");

                    decimal monto;

                    monto = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine();

                    ctaCredito.Saldo = ctaCredito.Saldo + monto;

                    Console.WriteLine("");

                    Console.WriteLine("Saldo en Cuenta de Crédito es: " + ctaCredito.Saldo);

                    Console.WriteLine("");

                }
                else if (selec == 2)
                {
                    Console.WriteLine("");

                    Console.WriteLine("Seleccionó opción 2 - Débito ");

                    Console.WriteLine();

                    Console.WriteLine("Digite monto de venta aplicable a tarjeta de débito ");

                    decimal monto;

                    monto = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine();

                    if (monto > ctaDebito.Saldo)
                    {
                        Console.WriteLine("");

                        Console.WriteLine("Transacción no se puede realizar, saldo insuficiente");

                        Console.WriteLine("");
                    }
                    else
                    {
                        ctaDebito.Saldo = ctaDebito.Saldo - monto;

                        Console.WriteLine("");

                        Console.WriteLine("Saldo en la Cuenta de Débito es: " + ctaDebito.Saldo);

                        Console.WriteLine("");
                    }
                }
                else if (selec == 3)
                {
                    Console.WriteLine("");

                    Console.WriteLine("Saldo de Crédito es: " + ctaCredito.Saldo + " Saldo de Débito es: " + ctaDebito.Saldo);

                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("");

                    Console.WriteLine("Opción digitada no es válida ");

                    Console.WriteLine("");
                }
            }
        }
    }
}

