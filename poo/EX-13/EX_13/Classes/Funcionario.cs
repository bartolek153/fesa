using EX_13.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_13.Classes
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public EnumSexo Sexo { get; set; }
        public EnumEstadoCivil EstadoCivil { get; set; }
        public DateTime DataNascimento { get; set; }

        public Funcionario() { }
        public Funcionario(string nome, EnumSexo sexo, EnumEstadoCivil estadoCivil, DateTime dataNascimento)
        {
            Nome = nome;
            Sexo = sexo;
            EstadoCivil = estadoCivil;
            DataNascimento = dataNascimento;
        }
    }
}
