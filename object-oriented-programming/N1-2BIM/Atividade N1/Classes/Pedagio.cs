using System.Collections.Generic;

using Atividade_N1.Interface;

namespace Atividade_N1.Classes
{
    class Pedagio
    {
        private string Id;
        private string Localizacao { get; set; }

        public void Receber(List<IVeiculo> VeiculosAPagar)
        {
            foreach (var v in VeiculosAPagar)
            {
                if (v is Moto)
                {
                    Moto m = (Moto)v;
                    m.PagarPedagio();
                    m.PedagioTotal += m.pedagioPadrao;
                }
                else if (v is Carro)
                {
                    Carro c = (Carro)v;
                    c.PagarPedagio();
                    c.PedagioTotal += c.pedagioPadrao;
                }
                else if (v is Caminhao)
                {
                    Caminhao cam = (Caminhao)v;
                    cam.PagarPedagio();
                    cam.PedagioTotal += cam.pedagioPadrao;
                }
                else
                {
                    Onibus o = (Onibus)v;
                    o.PagarPedagio();
                    o.PedagioTotal += o.pedagioPadrao;
                }
            }
        }

        public double TotalRecebido(List<IVeiculo> VeiculosAPagar)
        {
            double total = 0;

            foreach (var v in VeiculosAPagar)
            {
                if (v is Moto)
                {
                    Moto m = (Moto)v;
                    total = m.PedagioTotal;
                }
                else if (v is Carro)
                {
                    Carro c = (Carro)v;
                    total = c.PedagioTotal;
                }
                else if (v is Caminhao)
                {
                    Caminhao cam = (Caminhao)v;
                    total = cam.PedagioTotal;
                }
                else
                {
                    Onibus o = (Onibus)v;
                    total = o.PedagioTotal;
                }
            }

            return total;
        }
    }
}
