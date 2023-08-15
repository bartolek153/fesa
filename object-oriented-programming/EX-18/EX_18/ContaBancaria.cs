using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_18
{
    public abstract class ContaBancaria
    {
        private string numeroConta;
        public String Nome { get; set; }
        public string NumeroConta
        {
            get => numeroConta;
            set
            {
                if (value.Length == 6 && value[4] == '-')
                    numeroConta = value;
                else
                    throw new Exception("Conta deve estar no formato 9999-9");
            }
        }
        
        public double Saldo { get; protected set; }
        public virtual void Deposito(double valor) => Saldo += valor;
        public abstract void Saque(double valor);

        public override string ToString()
        {
            return $"Conta: {numeroConta} - {Nome} - Saldo:{Saldo:c} ";
        }
    }
}
