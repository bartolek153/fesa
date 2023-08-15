using Atividade_N1.Classes;
using Atividade_N1.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Atividade_N1
{
    public partial class frmActions : Form
    {
        List<IVeiculo> Veiculos;
        List<Marca> Marcas;
        List<Modelo> Modelos;

        string ID;
        string Notif2;
        IVeiculo VeiculoSelecionado;

        public frmActions(List<IVeiculo> veiculos, List<Marca> marcas, List<Modelo> modelos)
        {
            Veiculos = veiculos;
            InitializeComponent();
            Marcas = marcas;
            Modelos = modelos;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                VeiculoSelecionado = Veiculos.Find(x => x.Id == cbxID.Text);
                if (VeiculoSelecionado != null)
                {
                    ID = cbxID.Text;
                    Notif2 = $"Veículo {ID} - ";
                    MostraAcoes(VeiculoSelecionado);
                }
                else
                    throw new Exception("ID não registrada.");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void MostraAcoes(IVeiculo v)
        {
            gbxVelocidade.Visible = true;
            lblTipo.Visible = true;
            btnPedagioTotal.Visible = false;

            if (v is Aviao)
            {
                lblTipo.Text = "Avião";
                gbxAviao.Visible = true;
                gbxMoto.Visible = false;
                gbxCaminhao.Visible = false;
                gbxAviaoG.Visible = false;

                btnAtracar.Visible = false;
                btnLimpador.Visible = true;
                btnAtacar.Visible = false;
                btnPedagio.Visible = false;
            }
            else if (v is AviaoDeGuerra)
            {
                lblTipo.Text = "Avião de Guerra";
                gbxMoto.Visible = false;
                gbxAviao.Visible = false;
                gbxCaminhao.Visible = false;
                gbxAviaoG.Visible = true;

                btnAtracar.Visible = false;
                btnLimpador.Visible = false;
                btnPedagio.Visible = false;
                btnAtacar.Visible = true;
            }
            else if (v is Caminhao)
            {
                lblTipo.Text = "Caminhão";
                gbxMoto.Visible = false;
                gbxAviao.Visible = false;
                gbxAviaoG.Visible = false;
                gbxCaminhao.Visible = true;

                btnAtacar.Visible = false;
                btnAtracar.Visible = false;
                btnLimpador.Visible = true;
                btnPedagio.Visible = true;
                btnPedagioTotal.Visible = ((v as Caminhao).PedagioTotal > 0 ? true : false);
            }
            else if (v is Carro)
            {
                lblTipo.Text = "Carro";
                gbxMoto.Visible = false;
                gbxAviao.Visible = false;
                gbxCaminhao.Visible = false;
                gbxAviaoG.Visible = false;

                btnAtacar.Visible = false;
                btnAtracar.Visible = false;
                btnPedagio.Visible = true;
                btnLimpador.Visible = true;
                btnPedagioTotal.Visible = ((v as Carro).PedagioTotal > 0 ? true : false);
            }
            else if (v is Moto)
            {
                lblTipo.Text = "Moto";
                gbxAviao.Visible = false;
                gbxCaminhao.Visible = false;
                gbxAviaoG.Visible = false;
                gbxMoto.Visible = true;

                btnAtacar.Visible = false;
                btnAtracar.Visible = false;
                btnPedagio.Visible = true;
                btnPedagioTotal.Visible = ((v as Moto).PedagioTotal > 0 ? true : false);
                btnLimpador.Visible = false;
            }
            else if (v is Navio)
            {
                lblTipo.Text = "Navio";
                gbxMoto.Visible = false;
                gbxAviao.Visible = false;
                gbxAviaoG.Visible = false;
                gbxCaminhao.Visible = false;

                btnAtacar.Visible = false;
                btnPedagio.Visible = false;
                btnAtracar.Visible = true;
                btnLimpador.Visible = false;
            }
            else if (v is NavioDeGuerra)
            {
                lblTipo.Text = "Navio de Guerra";
                gbxMoto.Visible = false;
                gbxAviao.Visible = false;
                gbxCaminhao.Visible = false;
                gbxAviaoG.Visible = false;

                btnPedagio.Visible = false;
                btnAtacar.Visible = true;
                btnAtracar.Visible = true;
                btnLimpador.Visible = false;
            }
            else if (v is Onibus)
            {
                lblTipo.Text = "Ônibus";
                gbxMoto.Visible = false;
                gbxAviao.Visible = false;
                gbxCaminhao.Visible = false;
                gbxAviaoG.Visible = false;

                btnAtacar.Visible = false;
                btnAtracar.Visible = false;
                btnPedagio.Visible = true;
                btnPedagioTotal.Visible = ((v as Onibus).PedagioTotal > 0 ? true : false);

                btnLimpador.Visible = true;
            }
            else
            {
                lblTipo.Text = "Trem";
                gbxMoto.Visible = false;
                gbxAviao.Visible = false;
                gbxAviaoG.Visible = false;
                gbxCaminhao.Visible = false;

                btnAtacar.Visible = false;
                btnAtracar.Visible = false;
                btnPedagio.Visible = false;
                btnLimpador.Visible = true;
            }
        }

        private void btnEjetar_Click(object sender, EventArgs e)
        {
            (VeiculoSelecionado as AviaoDeGuerra).Ejetar();

            MessageBox.Show(Notif2 + (VeiculoSelecionado as AviaoDeGuerra).Notif);
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            try
            {
                (VeiculoSelecionado as Caminhao).Carregar((double)nboPeso.Value);

                MessageBox.Show(Notif2 + "está carregando agora "
                    + (VeiculoSelecionado as Caminhao).PesoCarregado + "kg.");
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnDescarregar_Click(object sender, EventArgs e)
        {
            try
            {
                (VeiculoSelecionado as Caminhao).Descarregar((double)nboPeso.Value);

                MessageBox.Show(Notif2 + "está carregando agora "
                    + (VeiculoSelecionado as Caminhao).PesoCarregado + "kg.");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnEmpinar_Click(object sender, EventArgs e)
        {
            (VeiculoSelecionado as Moto).Empinar();

            MessageBox.Show(Notif2 + (VeiculoSelecionado as Moto).Notif);
        }

        private void btnLimpador_Click(object sender, EventArgs e)
        {
            if (VeiculoSelecionado is Aviao)
            {
                (VeiculoSelecionado as Aviao).Limpador(Notif2 +
                    $" está limpando o que está sujo...");

                MessageBox.Show((VeiculoSelecionado as Aviao).Notif);
            }
            else if(VeiculoSelecionado is Caminhao)
            {
                (VeiculoSelecionado as Caminhao).Limpador(Notif2 +
                    $" está limpando o que está limpo...");

                MessageBox.Show((VeiculoSelecionado as Caminhao).Notif);
            }
            else if (VeiculoSelecionado is Carro)
            {
                (VeiculoSelecionado as Carro).Limpador(Notif2 +
                    $" está limpando o que está atrapalhando a visão...");

                MessageBox.Show((VeiculoSelecionado as Carro).Notif);
            }
            else if (VeiculoSelecionado is Onibus)
            {
                (VeiculoSelecionado as Onibus).Limpador(Notif2 +
                    $" está tirando a água...");

                MessageBox.Show((VeiculoSelecionado as Onibus).Notif);
            }
            else
            {
                (VeiculoSelecionado as Trem).Limpador(Notif2 +
                    $" está com o limpador falhando...");

                MessageBox.Show((VeiculoSelecionado as Trem).Notif);
            }
        }

        private void btnPedagio_Click(object sender, EventArgs e)
        {
            if (VeiculoSelecionado is Caminhao)
            {
                (VeiculoSelecionado as Caminhao).PagarPedagio();
                MessageBox.Show(Notif2 + (VeiculoSelecionado as Caminhao).Notif);
            }
            else if (VeiculoSelecionado is Carro)
            {
                (VeiculoSelecionado as Carro).PagarPedagio();
                MessageBox.Show(Notif2 + (VeiculoSelecionado as Carro).Notif);
            }
            else if (VeiculoSelecionado is Moto)
            {
                (VeiculoSelecionado as Moto).PagarPedagio();
                MessageBox.Show(Notif2 + (VeiculoSelecionado as Moto).Notif);
            }
            else
            {
                (VeiculoSelecionado as Onibus).PagarPedagio();
                MessageBox.Show(Notif2 + (VeiculoSelecionado as Onibus).Notif);
            }
            
            btnPedagioTotal.Visible = true;
        }

        private void btnPedagioTotal_Click(object sender, EventArgs e)
        {
            if (VeiculoSelecionado is Caminhao)
            {
                MessageBox.Show(Notif2 + (VeiculoSelecionado as Caminhao).PedagioTotal);
            }
            else if (VeiculoSelecionado is Carro)
            {
                MessageBox.Show(Notif2 + (VeiculoSelecionado as Carro).PedagioTotal);
            }
            else if (VeiculoSelecionado is Moto)
            {
                MessageBox.Show(Notif2 + (VeiculoSelecionado as Moto).PedagioTotal);
            }
            else
            {
                MessageBox.Show(Notif2 + (VeiculoSelecionado as Onibus).PedagioTotal);
            }
        }

        private void btnAtracar_Click(object sender, EventArgs e)
        {
            if (VeiculoSelecionado is NavioDeGuerra)
            {
                (VeiculoSelecionado as NavioDeGuerra).Atracar();
                MessageBox.Show(Notif2 + (VeiculoSelecionado as NavioDeGuerra).Notif);
            }
            else
            {
                (VeiculoSelecionado as Navio).Atracar();
                MessageBox.Show(Notif2 + (VeiculoSelecionado as Navio).Notif);
            }
        }

        private void btnAtacar_Click(object sender, EventArgs e)
        {
            if (VeiculoSelecionado is AviaoDeGuerra)
            {
                (VeiculoSelecionado as AviaoDeGuerra).Atacar();
                MessageBox.Show(Notif2 + (VeiculoSelecionado as AviaoDeGuerra).Notif);
            }
            else
            {
                (VeiculoSelecionado as NavioDeGuerra).Atacar();
                MessageBox.Show(Notif2 + (VeiculoSelecionado as NavioDeGuerra).Notif);
                
            }
        }

        private void btnAcelerar_Click(object sender, EventArgs e)
        {
            int Speed = (int)nboVelocidade.Value;
            if (Speed == 0)
            {
                if (VeiculoSelecionado is Aviao)
                {
                    (VeiculoSelecionado as Aviao).Acelerar();
                    MessageBox.Show(Notif2 + "acelerou!");
                }
                else if (VeiculoSelecionado is AviaoDeGuerra)
                {
                    (VeiculoSelecionado as AviaoDeGuerra).Acelerar();
                    MessageBox.Show(Notif2 + "acelerou!");
                }
                else if (VeiculoSelecionado is Caminhao)
                {
                    (VeiculoSelecionado as Caminhao).Acelerar();
                    MessageBox.Show(Notif2 + "acelerou!");
                }
                else if (VeiculoSelecionado is Carro)
                {
                    (VeiculoSelecionado as Carro).Acelerar();
                    MessageBox.Show(Notif2 + "acelerou!");
                }
                else if (VeiculoSelecionado is Moto)
                {
                    (VeiculoSelecionado as Moto).Acelerar();
                    MessageBox.Show(Notif2 + "acelerou!");
                }
                else if (VeiculoSelecionado is Navio)
                {
                    (VeiculoSelecionado as Navio).Acelerar();
                    MessageBox.Show(Notif2 + "acelerou!");
                }
                else if (VeiculoSelecionado is NavioDeGuerra)
                {
                    (VeiculoSelecionado as NavioDeGuerra).Acelerar();
                    MessageBox.Show(Notif2 + "acelerou!");
                }
                else if (VeiculoSelecionado is Onibus)
                {
                    (VeiculoSelecionado as Onibus).Acelerar();
                    MessageBox.Show(Notif2 + "acelerou!");
                }
                else
                {
                    (VeiculoSelecionado as Trem).Acelerar();
                    MessageBox.Show(Notif2 + "acelerou!");
                }
            }
            else
            {
                if (VeiculoSelecionado is Aviao)
                {
                    (VeiculoSelecionado as Aviao).Acelerar(Speed);
                    MessageBox.Show(Notif2 +
                        (VeiculoSelecionado as Aviao).Notif);
                }
                else if (VeiculoSelecionado is AviaoDeGuerra)
                {
                    (VeiculoSelecionado as AviaoDeGuerra).Acelerar(Speed);
                    MessageBox.Show(Notif2 +
                        (VeiculoSelecionado as AviaoDeGuerra).Notif);
                }
                else if (VeiculoSelecionado is Caminhao)
                {
                    (VeiculoSelecionado as Caminhao).Acelerar(Speed);
                    MessageBox.Show(Notif2 +
                        (VeiculoSelecionado as Caminhao).Notif);
                }
                else if (VeiculoSelecionado is Carro)
                {
                    (VeiculoSelecionado as Carro).Acelerar(Speed);
                    MessageBox.Show(Notif2 +
                        (VeiculoSelecionado as Carro).Notif);
                }
                else if (VeiculoSelecionado is Moto)
                {
                    (VeiculoSelecionado as Moto).Acelerar(Speed);
                    MessageBox.Show(Notif2 +
                        (VeiculoSelecionado as Moto).Notif);
                }
                else if (VeiculoSelecionado is Navio)
                {
                    (VeiculoSelecionado as Navio).Acelerar(Speed);
                    MessageBox.Show(Notif2 +
                        (VeiculoSelecionado as Navio).Notif);
                }
                else if (VeiculoSelecionado is NavioDeGuerra)
                {
                    (VeiculoSelecionado as NavioDeGuerra).Acelerar(Speed);
                    MessageBox.Show(Notif2 +
                        (VeiculoSelecionado as NavioDeGuerra).Notif);
                }
                else if (VeiculoSelecionado is Onibus)
                {
                    (VeiculoSelecionado as Onibus).Acelerar(Speed);
                    MessageBox.Show(Notif2 +
                        (VeiculoSelecionado as Onibus).Notif);
                }
                else
                {
                    (VeiculoSelecionado as Trem).Acelerar(Speed);
                    MessageBox.Show(Notif2 +
                        (VeiculoSelecionado as Trem).Notif);
                }
            }
        }

        private void btnDesacelerar_Click(object sender, EventArgs e)
        {
            int Speed = (int)nboVelocidade.Value;
            if (Speed == 0)
            {
                if (VeiculoSelecionado is Aviao)
                {
                    (VeiculoSelecionado as Aviao).Desacelerar();
                    MessageBox.Show(Notif2 + "desacelerou!");
                }
                else if (VeiculoSelecionado is AviaoDeGuerra)
                {
                    (VeiculoSelecionado as AviaoDeGuerra).Desacelerar();
                    MessageBox.Show(Notif2 + "desacelerou!");
                }
                else if (VeiculoSelecionado is Caminhao)
                {
                    (VeiculoSelecionado as Caminhao).Desacelerar();
                    MessageBox.Show(Notif2 + "desacelerou!");
                }
                else if (VeiculoSelecionado is Carro)
                {
                    (VeiculoSelecionado as Carro).Desacelerar();
                    MessageBox.Show(Notif2 + "desacelerou!");
                }
                else if (VeiculoSelecionado is Moto)
                {
                    (VeiculoSelecionado as Moto).Desacelerar();
                    MessageBox.Show(Notif2 + "desacelerou!");
                }
                else if (VeiculoSelecionado is Navio)
                {
                    (VeiculoSelecionado as Navio).Desacelerar();
                    MessageBox.Show(Notif2 + "desacelerou!");
                }
                else if (VeiculoSelecionado is NavioDeGuerra)
                {
                    (VeiculoSelecionado as NavioDeGuerra).Desacelerar();
                    MessageBox.Show(Notif2 + "desacelerou!");
                }
                else if (VeiculoSelecionado is Onibus)
                {
                    (VeiculoSelecionado as Onibus).Desacelerar();
                    MessageBox.Show(Notif2 + "desacelerou!");
                }
                else
                {
                    (VeiculoSelecionado as Trem).Desacelerar();
                    MessageBox.Show(Notif2 + "desacelerou!");
                }
            }
            else
            {
                if (VeiculoSelecionado is Aviao)
                {
                    (VeiculoSelecionado as Aviao).Desacelerar(Speed);
                    MessageBox.Show(Notif2 +
                        (VeiculoSelecionado as Aviao).Notif);
                }
                else if (VeiculoSelecionado is AviaoDeGuerra)
                {
                    (VeiculoSelecionado as AviaoDeGuerra).Desacelerar(Speed);
                    MessageBox.Show(Notif2 +
                        (VeiculoSelecionado as AviaoDeGuerra).Notif);
                }
                else if (VeiculoSelecionado is Caminhao)
                {
                    (VeiculoSelecionado as Caminhao).Desacelerar(Speed);
                    MessageBox.Show(Notif2 +
                        (VeiculoSelecionado as Caminhao).Notif);
                }
                else if (VeiculoSelecionado is Carro)
                {
                    (VeiculoSelecionado as Carro).Desacelerar(Speed);
                    MessageBox.Show(Notif2 +
                        (VeiculoSelecionado as Carro).Notif);
                }
                else if (VeiculoSelecionado is Moto)
                {
                    (VeiculoSelecionado as Moto).Desacelerar(Speed);
                    MessageBox.Show(Notif2 +
                        (VeiculoSelecionado as Moto).Notif);
                }
                else if (VeiculoSelecionado is Navio)
                {
                    (VeiculoSelecionado as Navio).Desacelerar(Speed);
                    MessageBox.Show(Notif2 +
                        (VeiculoSelecionado as Navio).Notif);
                }
                else if (VeiculoSelecionado is NavioDeGuerra)
                {
                    (VeiculoSelecionado as NavioDeGuerra).Desacelerar(Speed);
                    MessageBox.Show(Notif2 +
                        (VeiculoSelecionado as NavioDeGuerra).Notif);
                }
                else if (VeiculoSelecionado is Onibus)
                {
                    (VeiculoSelecionado as Onibus).Desacelerar(Speed);
                    MessageBox.Show(Notif2 +
                        (VeiculoSelecionado as Onibus).Notif);
                }
                else
                {
                    (VeiculoSelecionado as Trem).Desacelerar(Speed);
                    MessageBox.Show(Notif2 +
                        (VeiculoSelecionado as Trem).Notif);
                }
            }
        }

        private void btnPousar_Click(object sender, EventArgs e)
        {
            if (VeiculoSelecionado is AviaoDeGuerra)
            {
                (VeiculoSelecionado as AviaoDeGuerra).Pousar();
                MessageBox.Show(Notif2 +
                    (VeiculoSelecionado as AviaoDeGuerra).Notif);
            }
            else
            {
                (VeiculoSelecionado as Aviao).Pousar();
                MessageBox.Show(Notif2 +
                            (VeiculoSelecionado as Aviao).Notif);
            }
        }

        private void btnDecolar_Click(object sender, EventArgs e)
        {
            if (VeiculoSelecionado is AviaoDeGuerra)
            {
                (VeiculoSelecionado as AviaoDeGuerra).Decolar();
                MessageBox.Show(Notif2 +
                            (VeiculoSelecionado as AviaoDeGuerra).Notif);
            }
            else
            {
                (VeiculoSelecionado as Aviao).Decolar();
                MessageBox.Show(Notif2 +
                            (VeiculoSelecionado as Aviao).Notif);
            }
        }

        private void btnArremeter_Click(object sender, EventArgs e)
        {
            if (VeiculoSelecionado is AviaoDeGuerra)
            {
                (VeiculoSelecionado as AviaoDeGuerra).Arremeter();
                MessageBox.Show(Notif2 +
                            (VeiculoSelecionado as AviaoDeGuerra).Notif);
            }
            else if (VeiculoSelecionado is Aviao)
            {
                (VeiculoSelecionado as Aviao).Arremeter();
                MessageBox.Show(Notif2 +
                            (VeiculoSelecionado as Aviao).Notif);
            }
        }

        private void btnJSON_Click(object sender, EventArgs e)
        {
        }

        private void btnLoadJson_Click(object sender, EventArgs e)
        {
        }

        private void frmActions_Load(object sender, EventArgs e)
        {
        }
    }
}