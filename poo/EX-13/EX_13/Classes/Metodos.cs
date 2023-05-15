using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_13.Classes
{
    public static class Metodos
    {
        public static bool ValidaNome(string nome)
        {
            if (nome.Trim().IndexOf(' ') == -1)
                return false;
            else
                return true;
        }

        public static bool ValidaData(string data, out int idade, out uint totalSegundosVividos)
        {
            DateTime result;

            if (DateTime.TryParse(data, out result))
            {
                idade = Convert.ToInt32(DateTime.Now.Subtract(result).TotalDays / 365);
                totalSegundosVividos = (uint)DateTime.Now.Subtract(result).TotalSeconds;
                return true;
            }
            else
            {
                totalSegundosVividos = 0;
                idade = 0;
                return false;
            }
        }
    }
}
