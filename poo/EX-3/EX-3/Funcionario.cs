using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_3
{
    public class Funcionario
    {
        private int _codigo;
        private string _nome;
        private string _rg;
        private double _salario;

        public int GetCodigo() => _codigo;
        public string GetNome() => _nome;
        public string GetRG() => _rg;
        public double GetSalario() => _salario;
        public double GetINSS() => _salario * 0.11;
        public double CalculaSalario() => _salario - GetINSS();

        public void SetCodigo(int codigo)
        {
            if (codigo < 0)
                throw new Exception("Código deve ser maior que 0");

            _codigo = codigo;
        }

        public void SetNome(string nome) 
        {
            if (nome.Trim().Length == 0)
                throw new Exception("Nome não pode ser nulo");

            _nome = nome;
        }

        public void SetRG(string rg)
        {
            if (rg.Replace(".", "").Length != 9)
                throw new Exception("RG deve conter 9 caracteres");

            _rg = rg;
        }

        public void SetSalario(double salario)
        {
            if (salario < 0)
                throw new Exception("Salário não pode ser <= 0");

            _salario = salario;
        }
    }
}
