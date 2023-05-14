﻿using System;
using System.Windows.Forms;

using Atividade_N1.Interface;

namespace Atividade_N1
{
    class Onibus : Modelo, IVeiculo
    {
        private int capacidade;
        private int velocidadeAtual;
        private int peso;
        private string id;
        private Modelo modelo;
        private int quantidadeDeEixos;
        public double pedagioPadrao;
        public double PedagioTotal;
        public string Notif;

        public void Limpador(string status)
        {
            Notif = status;
        }
        public int Capacidade
        {
            get => capacidade;
            set
            {
                capacidade = value;
            }
        }
        public int QuantidadeDeEixos
        {
            get => quantidadeDeEixos;
            set
            {
                quantidadeDeEixos = value;
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
            pedagioPadrao = quantidadeDeEixos * 8.5;
            Notif = "Pedágio: " + pedagioPadrao;
            PedagioTotal += pedagioPadrao;
        }
    }
}
