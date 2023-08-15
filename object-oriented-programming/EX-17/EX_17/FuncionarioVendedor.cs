using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_17
{
    class FuncionarioVendedor : FuncionarioBase
    {
        public Double MetaDeVendaMesEmReais { get; set; }

        public Double VendasdoMesEmReais { get; set; }

        public Double PorcentagemSobreVendas { get; set; }

        private double salario;

        public override double Salario
        {
            get => salario;
            set
            {
                if (value < 1302)
                    throw new Exception("Valor não pode ser iferior ao salário mínimo de R$ 1302,00");
                salario = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() +
                $"  Meta: {MetaDeVendaMesEmReais:c}" +
                $"  Vendas do mês: {VendasdoMesEmReais:c}" +
                $"  % sobre as vendas: {PorcentagemSobreVendas:F2}";
        }

        public override double CalculoSalario()
        {
            if (VendasdoMesEmReais >= MetaDeVendaMesEmReais)
            {
                double valor = 
                    (VendasdoMesEmReais * (PorcentagemSobreVendas / 100));
                return Salario + valor;
            }
            else
                return base.CalculoSalario();
        }
    }
}
