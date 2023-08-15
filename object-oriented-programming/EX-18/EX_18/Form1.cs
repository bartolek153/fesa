using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_18
{
    public partial class Form1 : Form
    {
        List<ContaBancaria> contas = new List<ContaBancaria>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ContaCorrente c = new ContaCorrente();
                c.NumeroConta = txtCC.Text;
                c.Nome = txtTitular.Text;
                c.UtilizaTalaoCheque = ckCheque.Checked;
                c.LimiteDecredito = Convert.ToDouble(txtLimite.Text);
                contas.Add(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var c = new ContaPoupanca();
                c.NumeroConta = txtCC.Text;
                c.Nome = txtTitular.Text;
                c.ContaCorrentePai = txtCCAtrelada.Text;
                c.DiaAniversario = Convert.ToInt32(txtdia.Text);
                contas.Add(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResumo.Clear();
            foreach (var c in contas)
            {
                txtResumo.Text += c.ToString() + Environment.NewLine;
            }
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            try
            {
                ContaBancaria conta = contas.Find(c => c.NumeroConta == txtCCOperacao.Text);
                conta.Deposito(Convert.ToDouble(txtValorOperacao.Text));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            try
            {
                ContaBancaria conta = contas.Find(c => c.NumeroConta == txtCCOperacao.Text);
                conta.Saque(Convert.ToDouble(txtValorOperacao.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
