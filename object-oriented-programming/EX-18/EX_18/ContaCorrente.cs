using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_18
{
    public class ContaCorrente : ContaBancaria
    {
        public Double LimiteDecredito { get; set; }
        public bool UtilizaTalaoCheque { get; set; }

        public override void Saque(double valor)
        {
            if (valor > Saldo + LimiteDecredito)
                throw new Exception("Saldo insuficiente");
            else
                Saldo -= valor;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"  Limite: {LimiteDecredito:c} " +
                $"  Talão de cheque: {UtilizaTalaoCheque} ";
        }
    }
}
