using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_15
{
    public partial class Form1 : Form
    {
        List<Produto> produtos = new List<Produto>();


        public Form1()
        {
            InitializeComponent();

            cbCategoria.DataSource = Helper.CarregaCategorias();
            cbCategoria.DisplayMember = "DescricaoUpper";


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                produtos.Add(new Produto()
                {
                    Codigo = Convert.ToInt32(txtCodigo.Text),
                    Nome = txtDescricao.Text,
                    Categoria = cbCategoria.SelectedItem as Categoria
                });

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = produtos;

                txtCodigo.Clear();
                txtDescricao.Clear();
                cbCategoria.SelectedIndex = -1;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
