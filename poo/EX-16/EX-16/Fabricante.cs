using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_16
{
    internal class Fabricante
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public Fabricante(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }

        public override string ToString()
        {
            return $"{Codigo} - {Nome}";
        }
    }
}
