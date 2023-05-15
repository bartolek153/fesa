using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_17
{
    class FuncionarioPeao : FuncionarioBase
    {
        public Double HoraExtraEmReais { get; set; }

        public override double CalculoSalario() => base.CalculoSalario() + HoraExtraEmReais;

        private double salario;

        public override double Salario
        {
            get => salario;
            set
            {
                if (value < 1302)
                    throw new Exception("Valor não pode ser inferior ao salário mínimo de R$ 1302,00");
                salario = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"  Hora extra: {HoraExtraEmReais:c}";
        }
    }
}
