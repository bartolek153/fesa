using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_4
{
    public class Funcionario
    {
        private int _codigo;
        private string _nome;
        private string _rg;
        private double _salario;

        public int Codigo 
        {
            get
            {
                return _codigo;
            }
            set
            {
                if (value < 0)
                    throw new Exception("Código deve ser maior que 0");

                _codigo = value;
            }
        }

        public string Nome
        {
            get => _nome;
            set
            {
                if (value.Trim().Length == 0)
                    throw new Exception("Nome não pode ser nulo");

                _nome = value;
            }
        }

        public string Rg
        {
            get => _rg;
            set
            {
                if (value.Replace(".", "").Length != 9)
                    throw new Exception("RG deve conter 9 caracteres");

                _rg = value;
            }
        }
        public double Salario
        {
            get => _salario;
            set
            {
                if (value < 0)
                    throw new Exception("Salário não pode ser <= 0");

                _salario = value;
            }
        }

        public double GetINSS() => _salario * 0.11;
        public double CalculaSalario() => _salario - GetINSS();

    }
}
