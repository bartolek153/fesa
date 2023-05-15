using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_15
{
    public class Categoria
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }   


        public Categoria(int codigo, string descricao)
        {
            Codigo = codigo;
            Descricao = descricao;
        }
        public Categoria() { }

        
        public string DescricaoUpper
        {
            get => char.ToUpper(Descricao[0]) +
                    Descricao.Substring(1);
        }

        public override string ToString()
        {
            return Codigo + " - " + Descricao;
        }

    }
}
