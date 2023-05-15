using EX_13.Classes;
using EX_13.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblnformacoes.Text = "";
            cbEstadoCivil.DataSource = Enum.GetValues(typeof(EnumEstadoCivil));
            cbSexo.DataSource = Enum.GetValues(typeof(EnumSexo));
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            try
            {
                int idade;
                uint totalSegundos;
                if (!Metodos.ValidaData(txtData.Text, out idade, out totalSegundos))
                {
                    MessageBox.Show("Data inválida!");
                    return;
                }

                lblnformacoes.Text = $"Idade:{idade} \r\n" +
                    $"Segundos já vividos: {totalSegundos}";

                if (!Metodos.ValidaNome(txtNome.Text))
                {
                    MessageBox.Show("Nome inválido!");
                    return;
                }

                Funcionario f = new Funcionario(
                    txtNome.Text,
                    (EnumSexo)cbSexo.SelectedIndex,
                    (EnumEstadoCivil)cbEstadoCivil.SelectedValue,
                    Convert.ToDateTime(txtData.Text)
                    );

                string dados =
                    f.Nome + Environment.NewLine +
                    f.DataNascimento.ToShortDateString() + Environment.NewLine +
                    (int)f.EstadoCivil + Environment.NewLine +
                    (int)f.Sexo;

                File.WriteAllText("dados.txt", dados);

                MessageBox.Show("Feito!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("dados.txt"))
                {
                    string[] linhas = File.ReadAllLines("dados.txt");
                    txtNome.Text = linhas[0];
                    txtData.Text = linhas[1];

                    int estadoCivilInt = Convert.ToInt32(linhas[2]);

                    cbEstadoCivil.SelectedItem = (EnumEstadoCivil)estadoCivilInt;
                    cbSexo.SelectedIndex = Convert.ToInt32(linhas[3]);
                }
                else
                    MessageBox.Show("Não encontrei dados para carregar!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void cbEstadoCivil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
