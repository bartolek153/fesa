using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_17
{
    class FuncionarioGerente : FuncionarioBase
    {
        public double Bonus { get; set; }
        public int DeptoGerenciado { get; set; }

        public override string ToString()
        {
            return base.ToString() +
                $"  Bônus: {Bonus:C} " +
                $"  Gerente do Depto: {DeptoGerenciado}";
        }

        private double salario;


        public override double Salario
        {
            get => salario;
            set
            {
                if (value <= 5000)
                    throw new Exception("Mas ... que absurdo!!!");
                salario = value;
            }
        }

        public override double CalculoSalario()
        {
            return base.CalculoSalario() + Bonus;
        }

    }
}
