using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_15
{
    public static class Helper
    {
        public static List<Categoria> CarregaCategorias()
        {
            if (File.Exists(Constantes.ARQ_CATEGORIAS))
            {
                string[] linhas = File.ReadAllLines(Constantes.ARQ_CATEGORIAS);
                List<Categoria> categorias = new List<Categoria>();
                foreach (string l in linhas)
                {
                    string[] dados = l.Split(',');
                    #region Alternativas de instânciar objeto
                    /*
                    Categoria C = new Categoria();
                    C.Codigo = Convert.ToInt32(dados[0]);
                    C.Descricao = dados[1];
                    lista.Add(C);*/

                    /*
                    lista.Add(new Categoria()
                    {
                        Codigo = Convert.ToInt32(dados[0]),
                        Descricao = dados[1]
                    }); */
                    #endregion

                    categorias.Add(new Categoria(
                        Convert.ToInt32(dados[0]), dados[1]));
                }
                return categorias;
            }
            else
                return new List<Categoria>();

        }
    }
}
