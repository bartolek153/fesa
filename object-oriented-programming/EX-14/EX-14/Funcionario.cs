using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace EX_14
{
    internal class Funcionario : ICadastro
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public bool Pesquisar()
        {
            string filePath = "dados.txt";
            string codigoPesquisa = this.Nome;

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.StartsWith("F|") && line.Contains(codigoPesquisa))
                        return true;
                }
            }

            return false;
        }

        public void Salvar()
        {
            string filePath = "dados.txt";
            string texto = $"F|{Codigo}|{Nome}";

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(texto);
            }
        }
    }
}
