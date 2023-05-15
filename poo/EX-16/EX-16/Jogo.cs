using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_16
{
    internal class Jogo
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public Dificuldade Dificuldade { get; set; }
        public double Valor { get; set; }
        public Fabricante Fabricante { get; set; }

        public Jogo(int codigo, string descricao, Dificuldade dificuldade, double valor, Fabricante fabricante)
        {
            Codigo = codigo;
            Descricao = descricao;
            Dificuldade = dificuldade;
            Valor = valor;
            Fabricante = fabricante;
        }

        public void AtualizarPreco(int percentualAumento)
        {
            Valor += Valor * percentualAumento / 100.0;
        }

        public void AtualizarPreco(double valorAdicional)
        {
            Valor += valorAdicional;
        }

        public override string ToString()
        {
            return $"Código: {Codigo}, Descrição: {Descricao}, Dificuldade: {Dificuldade}, Valor: {Valor}, Fabricante: {Fabricante}";
        }

    }
}
