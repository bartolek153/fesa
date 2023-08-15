using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_18
{
    public class ContaPoupanca : ContaBancaria
    {
        public int DiaAniversario { get; set; }
        public string ContaCorrentePai { get; set; }

        public override void Saque(double valor)
        {
            if (Saldo - valor < 0)
                throw new Exception("Saldo insuficiente");
            else
                Saldo -= valor;
        }

        public override string ToString()
        {
            return base.ToString() + 
                $" - CC atrelada: {ContaCorrentePai } " +
                $" - Dia aniversário: {DiaAniversario}";
        }
    }
}
