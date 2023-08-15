using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_5
{
    public class Aluno
    {
        private string _nome;
        private double _nota1;
        private double _nota2;

        public string Nome
        {
            get => _nome;
            set
            {
                if (value.Split(" ").Length <= 1)
                    throw new Exception("Nome inválido");
            }
        }
        public double Nota1 
        {
            get => _nota1;
            set
            {
                if (value < 0 || value > 10)
                    throw new Exception("Nota inválida");

                _nota1 = value;
            } 
        }
        public double Nota2 {
            get => _nota2;
            set 
            {
                if (value < 0 || value > 10)
                    throw new Exception("Nota inválida");

                _nota2 = value;
            }
        }
        public double Media 
        { 
            get => (Nota1 + Nota2) / 2;
        }
    }
}
