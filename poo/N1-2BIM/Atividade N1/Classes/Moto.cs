using Atividade_N1.Interface;

namespace Atividade_N1
{
    class Moto : Modelo, IVeiculo
    {
        private int capacidade;
        private int velocidadeAtual;
        private int peso;
        private string id;
        private Modelo modelo;
        public double pedagioPadrao = 3.50;
        public double PedagioTotal;
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

        public void PagarPedagio()
        {
            Notif = "Pedágio: " + pedagioPadrao;
            PedagioTotal += pedagioPadrao;
        }
        public void Empinar()
        {
            Notif = "empinou!";
        }
    }
}
