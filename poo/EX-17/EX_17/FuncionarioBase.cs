using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_17
{
    class FuncionarioBase
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
                
        public virtual double Salario { get; set; }

        public virtual double CalculoSalario() => Salario;

        public override string ToString()
        {
            return $"Código: {Codigo} Nome: {Nome} " +
                   $"Salário: {Salario:c} Salário líquido: {CalculoSalario():c}";
        }

    }
}
