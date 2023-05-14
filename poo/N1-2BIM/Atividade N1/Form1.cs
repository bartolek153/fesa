using Atividade_N1.Classes;
using Atividade_N1.Interface;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Atividade_N1
{
    public partial class frmPrincipal : Form
    {
        private List<IVeiculo> Veiculos = new List<IVeiculo>();
        private List<Marca> Marcas = new List<Marca>();
        private List<Modelo> Modelos = new List<Modelo>();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistrarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                if (nbxCodMarca.Value <= 0 || string.IsNullOrEmpty(txtDescMarca.Text))
                {
                    throw new Exception("Por favor, insira as informações corretamente.");
                }

                foreach (Marca marca in Marcas)
                {
                    if (marca.Codigo == Convert.ToInt32(nbxCodMarca.Value))
                    {
                        throw new Exception("O código já foi utilizado anteriormente.");
                    }

                    if (marca.Descricao == txtDescMarca.Text)
                    {
                        throw new Exception("A descrição escolhida já existe na lista de marcas.");
                    }
                }

                Marca m = new Marca();
                m.Codigo = (int)nbxCodMarca.Value;
                m.Descricao = txtDescMarca.Text;
                Marcas.Add(m);

                cbxMarca.DataSource = null;
                cbxMarca.DataSource = Marcas;
                cbxMarca.DisplayMember = "Descricao";

                MessageBox.Show("Marca inserida com sucesso!");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnRegistrarModelo_Click(object sender, EventArgs e)
        {
            try
            {
                if (nbxCodMod.Value <= 0 || string.IsNullOrEmpty(txtDescMod.Text) || cbxMarca.SelectedIndex == -1)
                {
                    throw new Exception("Por favor, insira as informações corretamente.");
                }

                foreach (Modelo modelo in Modelos)
                {
                    if (modelo.Codigo == Convert.ToInt32(nbxCodMod.Value))
                    {
                        throw new Exception("O código já foi utilizado anteriormente.");
                    }

                    if (modelo.Descricao == txtDescMod.Text)
                    {
                        throw new Exception("A descrição escolhida já existe na lista de marcas.");
                    }
                }

                Modelo m = new Modelo();
                m.Codigo = (int)nbxCodMod.Value;
                m.Descricao = txtDescMod.Text;
                m.Marca = (Marca)cbxMarca.SelectedItem;
                Modelos.Add(m);

                cbxModelo.DataSource = null;
                cbxModelo.DataSource = Modelos;
                cbxModelo.DisplayMember = "Descricao";

                MessageBox.Show("Modelo inserido com sucesso!");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtID.Text) || nboPeso.Value <= 0 ||
                    cbxModelo.SelectedIndex == -1 || cbxMarca.SelectedIndex == -1
                    || cbxOpcoes.SelectedIndex == -1)
                {
                    throw new Exception("Por favor, insira as informações corretamente.");
                }

                foreach (IVeiculo v in Veiculos)
                {
                    if (v.Id == txtID.Text)
                    {
                        throw new Exception("O ID já foi utilizado anteriormente.");
                    }
                }

                switch (cbxOpcoes.SelectedIndex)
                {
                    case 0:
                        Aviao a = new Aviao();
                        a.Capacidade = (int)nboCapacidade.Value;
                        a.Peso = (int)nboPeso.Value;
                        a.Id = txtID.Text;
                        a.Modelo = (Modelo)cbxModelo.SelectedItem;
                        Veiculos.Add(a);
                        break;

                    case 1:
                        AviaoDeGuerra ag = new AviaoDeGuerra();
                        ag.Capacidade = (int)nboCapacidade.Value;
                        ag.Peso = (int)nboPeso.Value;
                        ag.Id = txtID.Text;
                        ag.Modelo = (Modelo)cbxModelo.SelectedItem;
                        Veiculos.Add(ag);
                        break;

                    case 2:
                        Caminhao c = new Caminhao();
                        c.Capacidade = (int)nboCapacidade.Value;
                        c.Peso = (int)nboPeso.Value;
                        c.Id = txtID.Text;
                        c.Modelo = (Modelo)cbxModelo.SelectedItem;
                        c.quantidadeMax = (double)nboMax.Value;
                        c.QuantidadeDeEixos = (int)nboEixos1.Value;
                        c.PesoCarregado = (double)nboCarregado.Value;
                        Veiculos.Add(c);
                        break;

                    case 3:
                        Carro ca = new Carro();
                        ca.Capacidade = (int)nboCapacidade.Value;
                        ca.Peso = (int)nboPeso.Value;
                        ca.Id = txtID.Text;
                        ca.Modelo = (Modelo)cbxModelo.SelectedItem;
                        ca.QuantidadeDePortas = (int)nboPortas.Value;

                        if (chkOficial.Checked)
                        {
                            ca.Oficial = true;
                        }
                        else
                        {
                            ca.Oficial = false;
                        }

                        Veiculos.Add(ca);
                        break;

                    case 4:
                        Moto m = new Moto();
                        m.Capacidade = (int)nboCapacidade.Value;
                        m.Peso = (int)nboPeso.Value;
                        m.Id = txtID.Text;
                        m.Modelo = (Modelo)cbxModelo.SelectedItem;
                        Veiculos.Add(m);
                        break;

                    case 5:
                        Navio n = new Navio();
                        n.Capacidade = (int)nboCapacidade.Value;
                        n.Peso = (int)nboPeso.Value;
                        n.Id = txtID.Text;
                        n.Modelo = (Modelo)cbxModelo.SelectedItem;
                        Veiculos.Add(n);
                        break;

                    case 6:
                        NavioDeGuerra ng = new NavioDeGuerra();
                        ng.Capacidade = (int)nboCapacidade.Value;
                        ng.Peso = (int)nboPeso.Value;
                        ng.Id = txtID.Text;
                        ng.Modelo = (Modelo)cbxModelo.SelectedItem;
                        Veiculos.Add(ng);
                        break;

                    case 7:
                        Onibus o = new Onibus();
                        o.Capacidade = (int)nboCapacidade.Value;
                        o.Peso = (int)nboPeso.Value;
                        o.Id = txtID.Text;
                        o.Modelo = (Modelo)cbxModelo.SelectedItem;
                        o.QuantidadeDeEixos = (int)nboEixos2.Value;
                        Veiculos.Add(o);
                        break;
                    case 8:
                        Trem t = new Trem();
                        t.Capacidade = (int)nboCapacidade.Value;
                        t.Peso = (int)nboPeso.Value;
                        t.Id = txtID.Text;
                        t.Modelo = (Modelo)cbxModelo.SelectedItem;
                        t.QuantidadeDeVagoes = (int)nboEixos3.Value;
                        Veiculos.Add(t);
                        break;
                }

                MessageBox.Show("Veículo inserido com sucesso!");
                btnVeiculosRegistrados.Visible = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void cbxOpcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxOpcoes.SelectedIndex)
            {
                case 0:
                    lblAdd.Visible = false;
                    gbxCarro.Visible = false;
                    gbxCaminhao.Visible = false;
                    gbxOnibus.Visible = false;
                    gbxTrem.Visible = false;
                    break;
                case 1:
                    lblAdd.Visible = false;
                    gbxCarro.Visible = false;
                    gbxCaminhao.Visible = false;
                    gbxOnibus.Visible = false;
                    gbxTrem.Visible = false;
                    break;
                case 2:
                    lblAdd.Visible = true;
                    gbxCarro.Visible = false;
                    gbxCaminhao.Visible = true;
                    gbxOnibus.Visible = false;
                    gbxTrem.Visible = false;
                    break;
                case 3:
                    lblAdd.Visible = true;
                    gbxCarro.Visible = true;
                    gbxCaminhao.Visible = false;
                    gbxOnibus.Visible = false;
                    gbxTrem.Visible = false;
                    break;
                case 4:
                    lblAdd.Visible = false;
                    gbxCarro.Visible = false;
                    gbxCaminhao.Visible = false;
                    gbxOnibus.Visible = false;
                    gbxTrem.Visible = false;
                    break;
                case 5:
                    lblAdd.Visible = false;
                    gbxCarro.Visible = false;
                    gbxCaminhao.Visible = false;
                    gbxOnibus.Visible = false;
                    gbxTrem.Visible = false;
                    break;
                case 6:
                    lblAdd.Visible = false;
                    gbxCarro.Visible = false;
                    gbxCaminhao.Visible = false;
                    gbxOnibus.Visible = false;
                    gbxTrem.Visible = false;
                    break;
                case 7:
                    lblAdd.Visible = true;
                    gbxCarro.Visible = false;
                    gbxCaminhao.Visible = false;
                    gbxOnibus.Visible = true;
                    gbxTrem.Visible = false;
                    break;
                case 8:
                    lblAdd.Visible = true;
                    gbxCarro.Visible = false;
                    gbxCaminhao.Visible = false;
                    gbxOnibus.Visible = false;
                    gbxTrem.Visible = true;
                    break;
            }
        }

        private void btnVeiculosRegistrados_Click(object sender, EventArgs e)
        {
            frmActions f = new frmActions(Veiculos, Marcas, Modelos);
            Hide();
            f.ShowDialog();
            Show();
        }

        private void btnLoadJson_Click(object sender, EventArgs e)
        {
            var dados = JsonContainer.CarregarDados();

            if (!(dados is null))
            {
                this.Modelos = dados.Modelos;
                this.Marcas = dados.Marcas;
                this.Veiculos = dados.Veiculos;

                cbxModelo.DataSource = this.Modelos;
                cbxModelo.DisplayMember = "Descricao";

                cbxMarca.DataSource = this.Marcas;
                cbxMarca.DisplayMember = "Descricao";

                btnVeiculosRegistrados.Visible = true;
                MessageBox.Show("Dados carregados com sucesso!");
            }
        }

        private void btnSaveJson_Click(object sender, EventArgs e)
        {
            new JsonContainer(Veiculos, Marcas, Modelos).Salvar();
            MessageBox.Show("Dados salvos com sucesso!");
        }

        private void btnShowJson_Click(object sender, EventArgs e)
        {
            JsonContainer.Exibir();
        }
    }
}