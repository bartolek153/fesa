using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atividade_N1.Interface;

namespace Atividade_N1
{
    class AviaoDeGuerra:Modelo, IVeiculo, IVeiculoDeGuerra, IAviao
    {
        private int capacidade;
        private int velocidadeAtual;
        private int peso;
        private string id;
        private Modelo modelo;
        public string Notif;

        public int Capacidade
        {
            get => capacidade;
            set
            {
                capacidade = value;
            }
        }


        public int VelocidadeAtual
        {
            get => velocidadeAtual;
            set
            {
                velocidadeAtual = value;
            }
        }

        public int Peso
        {
            get => peso;
            set
            {
                peso = value;
            }
        }

        public string Id
        {
            get => id;
            set
            {
                id = value;
            }
        }
        public Modelo Modelo
        {
            get => modelo;
            set
            {
                modelo = value;
            }
        }
        public void Acelerar()
        {
            VelocidadeAtual++;
        }
        public void Desacelerar()
        {
            VelocidadeAtual--;
        }
        public void Acelerar(int Aumento)
        {
            VelocidadeAtual += Aumento;
            Notif = "aumentou em " + Aumento + " km/h";
        }
        public void Desacelerar(int Diminuicao)
        {
            VelocidadeAtual -= Diminuicao;
            Notif = "diminuiu em " + Diminuicao + " km/h";
        }

        public void Pousar()
        {
            Notif = "Pousou";
        }
        public void Decolar()
        {
            Notif = "Decolou";
        }
        public void Arremeter()
        {
            Notif = "Arremeteu";
        }
        public void Atacar()
        {
            Notif = "Atacou";
        }
        public void Ejetar()
        {
            Notif = "Ejetou";
        }
    }
}
