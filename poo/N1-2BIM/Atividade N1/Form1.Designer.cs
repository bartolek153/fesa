namespace Atividade_N1
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxCarro = new System.Windows.Forms.GroupBox();
            this.chkOficial = new System.Windows.Forms.CheckBox();
            this.nboPortas = new System.Windows.Forms.NumericUpDown();
            this.lblOficial = new System.Windows.Forms.Label();
            this.lblPortas = new System.Windows.Forms.Label();
            this.gbxOnibus = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nboEixos2 = new System.Windows.Forms.NumericUpDown();
            this.gbxTrem = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nboEixos3 = new System.Windows.Forms.NumericUpDown();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cbxOpcoes = new System.Windows.Forms.ComboBox();
            this.lblOpcao = new System.Windows.Forms.Label();
            this.lblCapac = new System.Windows.Forms.Label();
            this.nboCapacidade = new System.Windows.Forms.NumericUpDown();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.nboPeso = new System.Windows.Forms.NumericUpDown();
            this.lblPeso = new System.Windows.Forms.Label();
            this.gboVeiculo = new System.Windows.Forms.GroupBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.cbxModelo = new System.Windows.Forms.ComboBox();
            this.gboModelo = new System.Windows.Forms.GroupBox();
            this.nbxCodMod = new System.Windows.Forms.NumericUpDown();
            this.txtDescMod = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistrarModelo = new System.Windows.Forms.Button();
            this.gboMarca = new System.Windows.Forms.GroupBox();
            this.nbxCodMarca = new System.Windows.Forms.NumericUpDown();
            this.txtDescMarca = new System.Windows.Forms.TextBox();
            this.lblDescMarca = new System.Windows.Forms.Label();
            this.lblCodMarca = new System.Windows.Forms.Label();
            this.btnRegistrarMarca = new System.Windows.Forms.Button();
            this.lblAdd = new System.Windows.Forms.Label();
            this.gbxCaminhao = new System.Windows.Forms.GroupBox();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblPesoCarregado = new System.Windows.Forms.Label();
            this.lblEixos = new System.Windows.Forms.Label();
            this.nboMax = new System.Windows.Forms.NumericUpDown();
            this.nboCarregado = new System.Windows.Forms.NumericUpDown();
            this.nboEixos1 = new System.Windows.Forms.NumericUpDown();
            this.btnVeiculosRegistrados = new System.Windows.Forms.Button();
            this.btnLoadJson = new System.Windows.Forms.Button();
            this.btnSaveJson = new System.Windows.Forms.Button();
            this.btnShowJson = new System.Windows.Forms.Button();
            this.gbxCarro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nboPortas)).BeginInit();
            this.gbxOnibus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nboEixos2)).BeginInit();
            this.gbxTrem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nboEixos3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nboCapacidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nboPeso)).BeginInit();
            this.gboVeiculo.SuspendLayout();
            this.gboModelo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbxCodMod)).BeginInit();
            this.gboMarca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbxCodMarca)).BeginInit();
            this.gbxCaminhao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nboMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nboCarregado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nboEixos1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxCarro
            // 
            this.gbxCarro.Controls.Add(this.chkOficial);
            this.gbxCarro.Controls.Add(this.nboPortas);
            this.gbxCarro.Controls.Add(this.lblOficial);
            this.gbxCarro.Controls.Add(this.lblPortas);
            this.gbxCarro.Location = new System.Drawing.Point(389, 196);
            this.gbxCarro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxCarro.Name = "gbxCarro";
            this.gbxCarro.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxCarro.Size = new System.Drawing.Size(365, 142);
            this.gbxCarro.TabIndex = 1;
            this.gbxCarro.TabStop = false;
            this.gbxCarro.Text = "Carro";
            this.gbxCarro.Visible = false;
            // 
            // chkOficial
            // 
            this.chkOficial.AutoSize = true;
            this.chkOficial.Location = new System.Drawing.Point(186, 88);
            this.chkOficial.Margin = new System.Windows.Forms.Padding(4);
            this.chkOficial.Name = "chkOficial";
            this.chkOficial.Size = new System.Drawing.Size(18, 17);
            this.chkOficial.TabIndex = 23;
            this.chkOficial.UseVisualStyleBackColor = true;
            // 
            // nboPortas
            // 
            this.nboPortas.Location = new System.Drawing.Point(177, 30);
            this.nboPortas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nboPortas.Name = "nboPortas";
            this.nboPortas.Size = new System.Drawing.Size(177, 22);
            this.nboPortas.TabIndex = 22;
            // 
            // lblOficial
            // 
            this.lblOficial.AutoSize = true;
            this.lblOficial.Location = new System.Drawing.Point(131, 89);
            this.lblOficial.Name = "lblOficial";
            this.lblOficial.Size = new System.Drawing.Size(44, 16);
            this.lblOficial.TabIndex = 21;
            this.lblOficial.Text = "Oficial";
            // 
            // lblPortas
            // 
            this.lblPortas.AutoSize = true;
            this.lblPortas.Location = new System.Drawing.Point(25, 32);
            this.lblPortas.Name = "lblPortas";
            this.lblPortas.Size = new System.Drawing.Size(138, 16);
            this.lblPortas.TabIndex = 20;
            this.lblPortas.Text = "Quantidade de Portas";
            // 
            // gbxOnibus
            // 
            this.gbxOnibus.Controls.Add(this.label3);
            this.gbxOnibus.Controls.Add(this.nboEixos2);
            this.gbxOnibus.Location = new System.Drawing.Point(764, 196);
            this.gbxOnibus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxOnibus.Name = "gbxOnibus";
            this.gbxOnibus.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxOnibus.Size = new System.Drawing.Size(365, 142);
            this.gbxOnibus.TabIndex = 3;
            this.gbxOnibus.TabStop = false;
            this.gbxOnibus.Text = "Ônibus";
            this.gbxOnibus.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Quantidade de Eixos";
            // 
            // nboEixos2
            // 
            this.nboEixos2.Location = new System.Drawing.Point(159, 68);
            this.nboEixos2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nboEixos2.Name = "nboEixos2";
            this.nboEixos2.Size = new System.Drawing.Size(177, 22);
            this.nboEixos2.TabIndex = 20;
            // 
            // gbxTrem
            // 
            this.gbxTrem.Controls.Add(this.label4);
            this.gbxTrem.Controls.Add(this.nboEixos3);
            this.gbxTrem.Location = new System.Drawing.Point(389, 342);
            this.gbxTrem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxTrem.Name = "gbxTrem";
            this.gbxTrem.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxTrem.Size = new System.Drawing.Size(365, 75);
            this.gbxTrem.TabIndex = 3;
            this.gbxTrem.TabStop = false;
            this.gbxTrem.Text = "Trem";
            this.gbxTrem.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Quantidade de Eixos";
            // 
            // nboEixos3
            // 
            this.nboEixos3.Location = new System.Drawing.Point(171, 33);
            this.nboEixos3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nboEixos3.Name = "nboEixos3";
            this.nboEixos3.Size = new System.Drawing.Size(177, 22);
            this.nboEixos3.TabIndex = 22;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(12, 446);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(825, 34);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar Veículo";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cbxOpcoes
            // 
            this.cbxOpcoes.FormattingEnabled = true;
            this.cbxOpcoes.Items.AddRange(new object[] {
            "Avião",
            "Avião de Guerra",
            "Caminhao",
            "Carro",
            "Moto",
            "Navio",
            "Navio de Guerra",
            "Ônibus",
            "Trem"});
            this.cbxOpcoes.Location = new System.Drawing.Point(144, 105);
            this.cbxOpcoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxOpcoes.Name = "cbxOpcoes";
            this.cbxOpcoes.Size = new System.Drawing.Size(159, 24);
            this.cbxOpcoes.TabIndex = 5;
            this.cbxOpcoes.SelectedIndexChanged += new System.EventHandler(this.cbxOpcoes_SelectedIndexChanged);
            // 
            // lblOpcao
            // 
            this.lblOpcao.AutoSize = true;
            this.lblOpcao.Location = new System.Drawing.Point(103, 108);
            this.lblOpcao.Name = "lblOpcao";
            this.lblOpcao.Size = new System.Drawing.Size(35, 16);
            this.lblOpcao.TabIndex = 6;
            this.lblOpcao.Text = "Tipo";
            // 
            // lblCapac
            // 
            this.lblCapac.AutoSize = true;
            this.lblCapac.Location = new System.Drawing.Point(32, 68);
            this.lblCapac.Name = "lblCapac";
            this.lblCapac.Size = new System.Drawing.Size(82, 16);
            this.lblCapac.TabIndex = 7;
            this.lblCapac.Text = "Capacidade";
            // 
            // nboCapacidade
            // 
            this.nboCapacidade.Location = new System.Drawing.Point(120, 66);
            this.nboCapacidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nboCapacidade.Name = "nboCapacidade";
            this.nboCapacidade.Size = new System.Drawing.Size(56, 22);
            this.nboCapacidade.TabIndex = 8;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(59, 27);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(127, 22);
            this.txtID.TabIndex = 9;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(32, 30);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 16);
            this.lblID.TabIndex = 10;
            this.lblID.Text = "ID";
            // 
            // nboPeso
            // 
            this.nboPeso.Location = new System.Drawing.Point(292, 27);
            this.nboPeso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nboPeso.Name = "nboPeso";
            this.nboPeso.Size = new System.Drawing.Size(104, 22);
            this.nboPeso.TabIndex = 13;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(245, 30);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(39, 16);
            this.lblPeso.TabIndex = 12;
            this.lblPeso.Text = "Peso";
            // 
            // gboVeiculo
            // 
            this.gboVeiculo.Controls.Add(this.lblModelo);
            this.gboVeiculo.Controls.Add(this.cbxModelo);
            this.gboVeiculo.Controls.Add(this.lblCapac);
            this.gboVeiculo.Controls.Add(this.lblOpcao);
            this.gboVeiculo.Controls.Add(this.cbxOpcoes);
            this.gboVeiculo.Controls.Add(this.nboPeso);
            this.gboVeiculo.Controls.Add(this.nboCapacidade);
            this.gboVeiculo.Controls.Add(this.lblPeso);
            this.gboVeiculo.Controls.Add(this.txtID);
            this.gboVeiculo.Controls.Add(this.lblID);
            this.gboVeiculo.Location = new System.Drawing.Point(723, 12);
            this.gboVeiculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboVeiculo.Name = "gboVeiculo";
            this.gboVeiculo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboVeiculo.Size = new System.Drawing.Size(407, 142);
            this.gboVeiculo.TabIndex = 14;
            this.gboVeiculo.TabStop = false;
            this.gboVeiculo.Text = "Veiculo";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(195, 68);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(53, 16);
            this.lblModelo.TabIndex = 15;
            this.lblModelo.Text = "Modelo";
            // 
            // cbxModelo
            // 
            this.cbxModelo.FormattingEnabled = true;
            this.cbxModelo.Location = new System.Drawing.Point(253, 65);
            this.cbxModelo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxModelo.Name = "cbxModelo";
            this.cbxModelo.Size = new System.Drawing.Size(141, 24);
            this.cbxModelo.TabIndex = 14;
            // 
            // gboModelo
            // 
            this.gboModelo.Controls.Add(this.nbxCodMod);
            this.gboModelo.Controls.Add(this.txtDescMod);
            this.gboModelo.Controls.Add(this.lblMarca);
            this.gboModelo.Controls.Add(this.label1);
            this.gboModelo.Controls.Add(this.cbxMarca);
            this.gboModelo.Controls.Add(this.label2);
            this.gboModelo.Controls.Add(this.btnRegistrarModelo);
            this.gboModelo.Location = new System.Drawing.Point(12, 94);
            this.gboModelo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboModelo.Name = "gboModelo";
            this.gboModelo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboModelo.Size = new System.Drawing.Size(695, 62);
            this.gboModelo.TabIndex = 15;
            this.gboModelo.TabStop = false;
            this.gboModelo.Text = "Modelo";
            // 
            // nbxCodMod
            // 
            this.nbxCodMod.Location = new System.Drawing.Point(79, 25);
            this.nbxCodMod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nbxCodMod.Name = "nbxCodMod";
            this.nbxCodMod.Size = new System.Drawing.Size(48, 22);
            this.nbxCodMod.TabIndex = 20;
            // 
            // txtDescMod
            // 
            this.txtDescMod.Location = new System.Drawing.Point(208, 25);
            this.txtDescMod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescMod.Name = "txtDescMod";
            this.txtDescMod.Size = new System.Drawing.Size(169, 22);
            this.txtDescMod.TabIndex = 22;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(387, 27);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(45, 16);
            this.lblMarca.TabIndex = 14;
            this.lblMarca.Text = "Marca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Descrição";
            // 
            // cbxMarca
            // 
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(437, 25);
            this.cbxMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(111, 24);
            this.cbxMarca.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Código";
            // 
            // btnRegistrarModelo
            // 
            this.btnRegistrarModelo.Location = new System.Drawing.Point(555, 17);
            this.btnRegistrarModelo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrarModelo.Name = "btnRegistrarModelo";
            this.btnRegistrarModelo.Size = new System.Drawing.Size(129, 34);
            this.btnRegistrarModelo.TabIndex = 16;
            this.btnRegistrarModelo.Text = "Registrar Modelo";
            this.btnRegistrarModelo.UseVisualStyleBackColor = true;
            this.btnRegistrarModelo.Click += new System.EventHandler(this.btnRegistrarModelo_Click);
            // 
            // gboMarca
            // 
            this.gboMarca.Controls.Add(this.nbxCodMarca);
            this.gboMarca.Controls.Add(this.txtDescMarca);
            this.gboMarca.Controls.Add(this.lblDescMarca);
            this.gboMarca.Controls.Add(this.lblCodMarca);
            this.gboMarca.Controls.Add(this.btnRegistrarMarca);
            this.gboMarca.Location = new System.Drawing.Point(12, 12);
            this.gboMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboMarca.Name = "gboMarca";
            this.gboMarca.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboMarca.Size = new System.Drawing.Size(695, 71);
            this.gboMarca.TabIndex = 15;
            this.gboMarca.TabStop = false;
            this.gboMarca.Text = "Marca";
            // 
            // nbxCodMarca
            // 
            this.nbxCodMarca.Location = new System.Drawing.Point(79, 28);
            this.nbxCodMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nbxCodMarca.Name = "nbxCodMarca";
            this.nbxCodMarca.Size = new System.Drawing.Size(48, 22);
            this.nbxCodMarca.TabIndex = 14;
            // 
            // txtDescMarca
            // 
            this.txtDescMarca.Location = new System.Drawing.Point(331, 27);
            this.txtDescMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescMarca.Name = "txtDescMarca";
            this.txtDescMarca.Size = new System.Drawing.Size(169, 22);
            this.txtDescMarca.TabIndex = 18;
            // 
            // lblDescMarca
            // 
            this.lblDescMarca.AutoSize = true;
            this.lblDescMarca.Location = new System.Drawing.Point(255, 30);
            this.lblDescMarca.Name = "lblDescMarca";
            this.lblDescMarca.Size = new System.Drawing.Size(69, 16);
            this.lblDescMarca.TabIndex = 19;
            this.lblDescMarca.Text = "Descrição";
            // 
            // lblCodMarca
            // 
            this.lblCodMarca.AutoSize = true;
            this.lblCodMarca.Location = new System.Drawing.Point(21, 30);
            this.lblCodMarca.Name = "lblCodMarca";
            this.lblCodMarca.Size = new System.Drawing.Size(51, 16);
            this.lblCodMarca.TabIndex = 15;
            this.lblCodMarca.Text = "Código";
            // 
            // btnRegistrarMarca
            // 
            this.btnRegistrarMarca.Location = new System.Drawing.Point(563, 21);
            this.btnRegistrarMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrarMarca.Name = "btnRegistrarMarca";
            this.btnRegistrarMarca.Size = new System.Drawing.Size(121, 34);
            this.btnRegistrarMarca.TabIndex = 17;
            this.btnRegistrarMarca.Text = "Registrar Marca";
            this.btnRegistrarMarca.UseVisualStyleBackColor = true;
            this.btnRegistrarMarca.Click += new System.EventHandler(this.btnRegistrarMarca_Click);
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(525, 165);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(149, 16);
            this.lblAdd.TabIndex = 16;
            this.lblAdd.Text = "Informações adicionais:";
            this.lblAdd.Visible = false;
            // 
            // gbxCaminhao
            // 
            this.gbxCaminhao.Controls.Add(this.lblMax);
            this.gbxCaminhao.Controls.Add(this.lblPesoCarregado);
            this.gbxCaminhao.Controls.Add(this.lblEixos);
            this.gbxCaminhao.Controls.Add(this.nboMax);
            this.gbxCaminhao.Controls.Add(this.nboCarregado);
            this.gbxCaminhao.Controls.Add(this.nboEixos1);
            this.gbxCaminhao.Location = new System.Drawing.Point(12, 196);
            this.gbxCaminhao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxCaminhao.Name = "gbxCaminhao";
            this.gbxCaminhao.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxCaminhao.Size = new System.Drawing.Size(365, 142);
            this.gbxCaminhao.TabIndex = 4;
            this.gbxCaminhao.TabStop = false;
            this.gbxCaminhao.Text = "Caminhão";
            this.gbxCaminhao.Visible = false;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(21, 107);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(127, 16);
            this.lblMax.TabIndex = 21;
            this.lblMax.Text = "Quantidade máxima";
            // 
            // lblPesoCarregado
            // 
            this.lblPesoCarregado.AutoSize = true;
            this.lblPesoCarregado.Location = new System.Drawing.Point(21, 70);
            this.lblPesoCarregado.Name = "lblPesoCarregado";
            this.lblPesoCarregado.Size = new System.Drawing.Size(107, 16);
            this.lblPesoCarregado.TabIndex = 20;
            this.lblPesoCarregado.Text = "Peso Carregado";
            // 
            // lblEixos
            // 
            this.lblEixos.AutoSize = true;
            this.lblEixos.Location = new System.Drawing.Point(21, 32);
            this.lblEixos.Name = "lblEixos";
            this.lblEixos.Size = new System.Drawing.Size(132, 16);
            this.lblEixos.TabIndex = 19;
            this.lblEixos.Text = "Quantidade de Eixos";
            // 
            // nboMax
            // 
            this.nboMax.Location = new System.Drawing.Point(167, 105);
            this.nboMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nboMax.Name = "nboMax";
            this.nboMax.Size = new System.Drawing.Size(177, 22);
            this.nboMax.TabIndex = 18;
            // 
            // nboCarregado
            // 
            this.nboCarregado.Location = new System.Drawing.Point(167, 68);
            this.nboCarregado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nboCarregado.Name = "nboCarregado";
            this.nboCarregado.Size = new System.Drawing.Size(177, 22);
            this.nboCarregado.TabIndex = 17;
            // 
            // nboEixos1
            // 
            this.nboEixos1.Location = new System.Drawing.Point(167, 30);
            this.nboEixos1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nboEixos1.Name = "nboEixos1";
            this.nboEixos1.Size = new System.Drawing.Size(177, 22);
            this.nboEixos1.TabIndex = 16;
            // 
            // btnVeiculosRegistrados
            // 
            this.btnVeiculosRegistrados.Location = new System.Drawing.Point(842, 446);
            this.btnVeiculosRegistrados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVeiculosRegistrados.Name = "btnVeiculosRegistrados";
            this.btnVeiculosRegistrados.Size = new System.Drawing.Size(287, 34);
            this.btnVeiculosRegistrados.TabIndex = 17;
            this.btnVeiculosRegistrados.Text = "Ver Veículos Registrados";
            this.btnVeiculosRegistrados.UseVisualStyleBackColor = true;
            this.btnVeiculosRegistrados.Visible = false;
            this.btnVeiculosRegistrados.Click += new System.EventHandler(this.btnVeiculosRegistrados_Click);
            // 
            // btnLoadJson
            // 
            this.btnLoadJson.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadJson.Location = new System.Drawing.Point(12, 415);
            this.btnLoadJson.Margin = new System.Windows.Forms.Padding(1);
            this.btnLoadJson.Name = "btnLoadJson";
            this.btnLoadJson.Size = new System.Drawing.Size(153, 28);
            this.btnLoadJson.TabIndex = 53;
            this.btnLoadJson.Text = "Carregar JSON";
            this.btnLoadJson.UseVisualStyleBackColor = true;
            this.btnLoadJson.Click += new System.EventHandler(this.btnLoadJson_Click);
            // 
            // btnSaveJson
            // 
            this.btnSaveJson.Location = new System.Drawing.Point(12, 383);
            this.btnSaveJson.Name = "btnSaveJson";
            this.btnSaveJson.Size = new System.Drawing.Size(153, 28);
            this.btnSaveJson.TabIndex = 52;
            this.btnSaveJson.Text = "Salvar JSON";
            this.btnSaveJson.UseVisualStyleBackColor = true;
            this.btnSaveJson.Click += new System.EventHandler(this.btnSaveJson_Click);
            // 
            // btnShowJson
            // 
            this.btnShowJson.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowJson.Location = new System.Drawing.Point(12, 351);
            this.btnShowJson.Margin = new System.Windows.Forms.Padding(1);
            this.btnShowJson.Name = "btnShowJson";
            this.btnShowJson.Size = new System.Drawing.Size(153, 28);
            this.btnShowJson.TabIndex = 54;
            this.btnShowJson.Text = "Exibir JSON";
            this.btnShowJson.UseVisualStyleBackColor = true;
            this.btnShowJson.Click += new System.EventHandler(this.btnShowJson_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 494);
            this.Controls.Add(this.btnShowJson);
            this.Controls.Add(this.btnLoadJson);
            this.Controls.Add(this.btnSaveJson);
            this.Controls.Add(this.btnVeiculosRegistrados);
            this.Controls.Add(this.gbxCaminhao);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.gboMarca);
            this.Controls.Add(this.gboModelo);
            this.Controls.Add(this.gboVeiculo);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.gbxTrem);
            this.Controls.Add(this.gbxOnibus);
            this.Controls.Add(this.gbxCarro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Veículos";
            this.gbxCarro.ResumeLayout(false);
            this.gbxCarro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nboPortas)).EndInit();
            this.gbxOnibus.ResumeLayout(false);
            this.gbxOnibus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nboEixos2)).EndInit();
            this.gbxTrem.ResumeLayout(false);
            this.gbxTrem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nboEixos3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nboCapacidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nboPeso)).EndInit();
            this.gboVeiculo.ResumeLayout(false);
            this.gboVeiculo.PerformLayout();
            this.gboModelo.ResumeLayout(false);
            this.gboModelo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbxCodMod)).EndInit();
            this.gboMarca.ResumeLayout(false);
            this.gboMarca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbxCodMarca)).EndInit();
            this.gbxCaminhao.ResumeLayout(false);
            this.gbxCaminhao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nboMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nboCarregado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nboEixos1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxCarro;
        private System.Windows.Forms.GroupBox gbxOnibus;
        private System.Windows.Forms.GroupBox gbxTrem;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cbxOpcoes;
        private System.Windows.Forms.Label lblOpcao;
        private System.Windows.Forms.Label lblCapac;
        private System.Windows.Forms.NumericUpDown nboCapacidade;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.NumericUpDown nboPeso;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.GroupBox gboVeiculo;
        private System.Windows.Forms.GroupBox gboModelo;
        private System.Windows.Forms.GroupBox gboMarca;
        private System.Windows.Forms.Button btnRegistrarModelo;
        private System.Windows.Forms.Button btnRegistrarMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.TextBox txtDescMarca;
        private System.Windows.Forms.Label lblDescMarca;
        private System.Windows.Forms.Label lblCodMarca;
        private System.Windows.Forms.NumericUpDown nbxCodMarca;
        private System.Windows.Forms.NumericUpDown nbxCodMod;
        private System.Windows.Forms.TextBox txtDescMod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.ComboBox cbxModelo;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.GroupBox gbxCaminhao;
        private System.Windows.Forms.NumericUpDown nboCarregado;
        private System.Windows.Forms.NumericUpDown nboEixos1;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblPesoCarregado;
        private System.Windows.Forms.Label lblEixos;
        private System.Windows.Forms.NumericUpDown nboMax;
        private System.Windows.Forms.CheckBox chkOficial;
        private System.Windows.Forms.NumericUpDown nboPortas;
        private System.Windows.Forms.Label lblOficial;
        private System.Windows.Forms.Label lblPortas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nboEixos2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nboEixos3;
        private System.Windows.Forms.Button btnVeiculosRegistrados;
        private System.Windows.Forms.Button btnLoadJson;
        private System.Windows.Forms.Button btnSaveJson;
        private System.Windows.Forms.Button btnShowJson;
    }
}

