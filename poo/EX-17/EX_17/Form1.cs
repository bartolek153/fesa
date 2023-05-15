using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_17
{
    public partial class Form1 : Form
    {
        List<FuncionarioBase> funcionarios = new List<FuncionarioBase>();


        public Form1()
        {
            InitializeComponent();
        }

        private void PreencheAtributosBasicos(FuncionarioBase f)
        {
            f.Codigo = Convert.ToInt32(txtCodigo.Text);
            f.Nome = txtNome.Text;
            f.Salario = Convert.ToDouble(txtSalario.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionarioPeao f = new FuncionarioPeao();
                PreencheAtributosBasicos(f);
                f.HoraExtraEmReais = Convert.ToDouble(txtValorHExtra.Text);
                funcionarios.Add(f);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionarioGerente f = new FuncionarioGerente();
                PreencheAtributosBasicos(f);
                f.Bonus = Convert.ToDouble(txtBonus.Text);
                f.DeptoGerenciado = Convert.ToInt32(txtDepto.Text);
                funcionarios.Add(f);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionarioVendedor f = new FuncionarioVendedor();
                PreencheAtributosBasicos(f);
                f.MetaDeVendaMesEmReais = Convert.ToDouble(txtMeta.Text);
                f.PorcentagemSobreVendas = Convert.ToDouble(txtPorcentXVendas.Text);
                f.VendasdoMesEmReais = Convert.ToDouble(txtVendasMes.Text);
                funcionarios.Add(f);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            foreach (FuncionarioBase f in funcionarios)
                txtResultado.Text += f.ToString() +
                                     Environment.NewLine;
        }
    }
}
