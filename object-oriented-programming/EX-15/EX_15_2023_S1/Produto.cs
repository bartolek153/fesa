using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_15
{
    public   class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }        
        public Categoria Categoria { get; set; }    
    }
}
