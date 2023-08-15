namespace Atividade_N1
{
    partial class frmActions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblID = new System.Windows.Forms.Label();
            this.cbxID = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.gbxAviao = new System.Windows.Forms.GroupBox();
            this.btnDecolar = new System.Windows.Forms.Button();
            this.btnArremeter = new System.Windows.Forms.Button();
            this.btnPousar = new System.Windows.Forms.Button();
            this.gbxAviaoG = new System.Windows.Forms.GroupBox();
            this.btnDecolar2 = new System.Windows.Forms.Button();
            this.btnArremeter2 = new System.Windows.Forms.Button();
            this.btnPousar2 = new System.Windows.Forms.Button();
            this.btnEjetar = new System.Windows.Forms.Button();
            this.gbxCaminhao = new System.Windows.Forms.GroupBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.nboPeso = new System.Windows.Forms.NumericUpDown();
            this.btnDescarregar = new System.Windows.Forms.Button();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.gbxMoto = new System.Windows.Forms.GroupBox();
            this.btnEmpinar = new System.Windows.Forms.Button();
            this.lblAcelerar = new System.Windows.Forms.Label();
            this.nboVelocidade = new System.Windows.Forms.NumericUpDown();
            this.btnDesacelerar = new System.Windows.Forms.Button();
            this.lblDesacelerar = new System.Windows.Forms.Label();
            this.btnAcelerar = new System.Windows.Forms.Button();
            this.btnAtacar = new System.Windows.Forms.Button();
            this.btnPedagio = new System.Windows.Forms.Button();
            this.btnAtracar = new System.Windows.Forms.Button();
            this.btnLimpador = new System.Windows.Forms.Button();
            this.gbxVelocidade = new System.Windows.Forms.GroupBox();
            this.btnPedagioTotal = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.gbxAviao.SuspendLayout();
            this.gbxAviaoG.SuspendLayout();
            this.gbxCaminhao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nboPeso)).BeginInit();
            this.gbxMoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nboVelocidade)).BeginInit();
            this.gbxVelocidade.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(188, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 16);
            this.lblID.TabIndex = 20;
            this.lblID.Text = "ID";
            // 
            // cbxID
            // 
            this.cbxID.Location = new System.Drawing.Point(214, 6);
            this.cbxID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxID.Name = "cbxID";
            this.cbxID.Size = new System.Drawing.Size(178, 22);
            this.cbxID.TabIndex = 21;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(398, 6);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(90, 23);
            this.btnSelect.TabIndex = 22;
            this.btnSelect.Text = "Selecionar";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // gbxAviao
            // 
            this.gbxAviao.Controls.Add(this.btnDecolar);
            this.gbxAviao.Controls.Add(this.btnArremeter);
            this.gbxAviao.Controls.Add(this.btnPousar);
            this.gbxAviao.Location = new System.Drawing.Point(12, 43);
            this.gbxAviao.Name = "gbxAviao";
            this.gbxAviao.Size = new System.Drawing.Size(251, 137);
            this.gbxAviao.TabIndex = 23;
            this.gbxAviao.TabStop = false;
            this.gbxAviao.Text = "Avião";
            this.gbxAviao.Visible = false;
            // 
            // btnDecolar
            // 
            this.btnDecolar.Location = new System.Drawing.Point(138, 21);
            this.btnDecolar.Name = "btnDecolar";
            this.btnDecolar.Size = new System.Drawing.Size(107, 61);
            this.btnDecolar.TabIndex = 36;
            this.btnDecolar.Text = "Decolar";
            this.btnDecolar.UseVisualStyleBackColor = true;
            this.btnDecolar.Click += new System.EventHandler(this.btnDecolar_Click);
            // 
            // btnArremeter
            // 
            this.btnArremeter.Location = new System.Drawing.Point(6, 88);
            this.btnArremeter.Name = "btnArremeter";
            this.btnArremeter.Size = new System.Drawing.Size(239, 43);
            this.btnArremeter.TabIndex = 35;
            this.btnArremeter.Text = "Arremeter";
            this.btnArremeter.UseVisualStyleBackColor = true;
            this.btnArremeter.Click += new System.EventHandler(this.btnArremeter_Click);
            // 
            // btnPousar
            // 
            this.btnPousar.Location = new System.Drawing.Point(6, 21);
            this.btnPousar.Name = "btnPousar";
            this.btnPousar.Size = new System.Drawing.Size(107, 61);
            this.btnPousar.TabIndex = 34;
            this.btnPousar.Text = "Pousar";
            this.btnPousar.UseVisualStyleBackColor = true;
            this.btnPousar.Click += new System.EventHandler(this.btnPousar_Click);
            // 
            // gbxAviaoG
            // 
            this.gbxAviaoG.Controls.Add(this.btnDecolar2);
            this.gbxAviaoG.Controls.Add(this.btnArremeter2);
            this.gbxAviaoG.Controls.Add(this.btnPousar2);
            this.gbxAviaoG.Controls.Add(this.btnEjetar);
            this.gbxAviaoG.Location = new System.Drawing.Point(269, 43);
            this.gbxAviaoG.Name = "gbxAviaoG";
            this.gbxAviaoG.Size = new System.Drawing.Size(251, 137);
            this.gbxAviaoG.TabIndex = 24;
            this.gbxAviaoG.TabStop = false;
            this.gbxAviaoG.Text = "Avião de Guerra";
            this.gbxAviaoG.Visible = false;
            // 
            // btnDecolar2
            // 
            this.btnDecolar2.Location = new System.Drawing.Point(138, 21);
            this.btnDecolar2.Name = "btnDecolar2";
            this.btnDecolar2.Size = new System.Drawing.Size(107, 61);
            this.btnDecolar2.TabIndex = 40;
            this.btnDecolar2.Text = "Decolar";
            this.btnDecolar2.UseVisualStyleBackColor = true;
            this.btnDecolar2.Click += new System.EventHandler(this.btnDecolar_Click);
            // 
            // btnArremeter2
            // 
            this.btnArremeter2.Location = new System.Drawing.Point(6, 88);
            this.btnArremeter2.Name = "btnArremeter2";
            this.btnArremeter2.Size = new System.Drawing.Size(107, 43);
            this.btnArremeter2.TabIndex = 39;
            this.btnArremeter2.Text = "Arremeter";
            this.btnArremeter2.UseVisualStyleBackColor = true;
            this.btnArremeter2.Click += new System.EventHandler(this.btnArremeter_Click);
            // 
            // btnPousar2
            // 
            this.btnPousar2.Location = new System.Drawing.Point(6, 21);
            this.btnPousar2.Name = "btnPousar2";
            this.btnPousar2.Size = new System.Drawing.Size(107, 61);
            this.btnPousar2.TabIndex = 38;
            this.btnPousar2.Text = "Pousar";
            this.btnPousar2.UseVisualStyleBackColor = true;
            this.btnPousar2.Click += new System.EventHandler(this.btnPousar_Click);
            // 
            // btnEjetar
            // 
            this.btnEjetar.Location = new System.Drawing.Point(138, 88);
            this.btnEjetar.Name = "btnEjetar";
            this.btnEjetar.Size = new System.Drawing.Size(107, 43);
            this.btnEjetar.TabIndex = 37;
            this.btnEjetar.Text = "Ejetar";
            this.btnEjetar.UseVisualStyleBackColor = true;
            this.btnEjetar.Click += new System.EventHandler(this.btnEjetar_Click);
            // 
            // gbxCaminhao
            // 
            this.gbxCaminhao.Controls.Add(this.lblPeso);
            this.gbxCaminhao.Controls.Add(this.nboPeso);
            this.gbxCaminhao.Controls.Add(this.btnDescarregar);
            this.gbxCaminhao.Controls.Add(this.btnCarregar);
            this.gbxCaminhao.Location = new System.Drawing.Point(526, 43);
            this.gbxCaminhao.Name = "gbxCaminhao";
            this.gbxCaminhao.Size = new System.Drawing.Size(251, 137);
            this.gbxCaminhao.TabIndex = 24;
            this.gbxCaminhao.TabStop = false;
            this.gbxCaminhao.Text = "Caminhão";
            this.gbxCaminhao.Visible = false;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(159, 52);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(74, 16);
            this.lblPeso.TabIndex = 32;
            this.lblPeso.Text = "Massa (kg)";
            // 
            // nboPeso
            // 
            this.nboPeso.Location = new System.Drawing.Point(144, 71);
            this.nboPeso.Name = "nboPeso";
            this.nboPeso.Size = new System.Drawing.Size(101, 22);
            this.nboPeso.TabIndex = 41;
            // 
            // btnDescarregar
            // 
            this.btnDescarregar.Location = new System.Drawing.Point(6, 88);
            this.btnDescarregar.Name = "btnDescarregar";
            this.btnDescarregar.Size = new System.Drawing.Size(124, 43);
            this.btnDescarregar.TabIndex = 40;
            this.btnDescarregar.Text = "Descarregar";
            this.btnDescarregar.UseVisualStyleBackColor = true;
            this.btnDescarregar.Click += new System.EventHandler(this.btnDescarregar_Click);
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(6, 21);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(124, 61);
            this.btnCarregar.TabIndex = 38;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // gbxMoto
            // 
            this.gbxMoto.Controls.Add(this.btnEmpinar);
            this.gbxMoto.Location = new System.Drawing.Point(269, 186);
            this.gbxMoto.Name = "gbxMoto";
            this.gbxMoto.Size = new System.Drawing.Size(251, 137);
            this.gbxMoto.TabIndex = 24;
            this.gbxMoto.TabStop = false;
            this.gbxMoto.Text = "Moto";
            this.gbxMoto.Visible = false;
            // 
            // btnEmpinar
            // 
            this.btnEmpinar.Location = new System.Drawing.Point(6, 30);
            this.btnEmpinar.Name = "btnEmpinar";
            this.btnEmpinar.Size = new System.Drawing.Size(239, 92);
            this.btnEmpinar.TabIndex = 43;
            this.btnEmpinar.Text = "Empinar";
            this.btnEmpinar.UseVisualStyleBackColor = true;
            this.btnEmpinar.Click += new System.EventHandler(this.btnEmpinar_Click);
            // 
            // lblAcelerar
            // 
            this.lblAcelerar.AutoSize = true;
            this.lblAcelerar.Location = new System.Drawing.Point(6, 53);
            this.lblAcelerar.Name = "lblAcelerar";
            this.lblAcelerar.Size = new System.Drawing.Size(58, 16);
            this.lblAcelerar.TabIndex = 28;
            this.lblAcelerar.Text = "Acelerar";
            // 
            // nboVelocidade
            // 
            this.nboVelocidade.Location = new System.Drawing.Point(95, 66);
            this.nboVelocidade.Name = "nboVelocidade";
            this.nboVelocidade.Size = new System.Drawing.Size(44, 22);
            this.nboVelocidade.TabIndex = 26;
            // 
            // btnDesacelerar
            // 
            this.btnDesacelerar.Location = new System.Drawing.Point(145, 74);
            this.btnDesacelerar.Name = "btnDesacelerar";
            this.btnDesacelerar.Size = new System.Drawing.Size(102, 30);
            this.btnDesacelerar.TabIndex = 27;
            this.btnDesacelerar.Text = "Desacelerar";
            this.btnDesacelerar.UseVisualStyleBackColor = true;
            this.btnDesacelerar.Click += new System.EventHandler(this.btnDesacelerar_Click);
            // 
            // lblDesacelerar
            // 
            this.lblDesacelerar.AutoSize = true;
            this.lblDesacelerar.Location = new System.Drawing.Point(6, 81);
            this.lblDesacelerar.Name = "lblDesacelerar";
            this.lblDesacelerar.Size = new System.Drawing.Size(82, 16);
            this.lblDesacelerar.TabIndex = 30;
            this.lblDesacelerar.Text = "Desacelerar";
            // 
            // btnAcelerar
            // 
            this.btnAcelerar.Location = new System.Drawing.Point(145, 46);
            this.btnAcelerar.Name = "btnAcelerar";
            this.btnAcelerar.Size = new System.Drawing.Size(75, 31);
            this.btnAcelerar.TabIndex = 31;
            this.btnAcelerar.Text = "Acelerar";
            this.btnAcelerar.UseVisualStyleBackColor = true;
            this.btnAcelerar.Click += new System.EventHandler(this.btnAcelerar_Click);
            // 
            // btnAtacar
            // 
            this.btnAtacar.Location = new System.Drawing.Point(711, 261);
            this.btnAtacar.Name = "btnAtacar";
            this.btnAtacar.Size = new System.Drawing.Size(66, 62);
            this.btnAtacar.TabIndex = 32;
            this.btnAtacar.Text = "Atacar";
            this.btnAtacar.UseVisualStyleBackColor = true;
            this.btnAtacar.Visible = false;
            this.btnAtacar.Click += new System.EventHandler(this.btnAtacar_Click);
            // 
            // btnPedagio
            // 
            this.btnPedagio.Location = new System.Drawing.Point(626, 194);
            this.btnPedagio.Name = "btnPedagio";
            this.btnPedagio.Size = new System.Drawing.Size(151, 30);
            this.btnPedagio.TabIndex = 39;
            this.btnPedagio.Text = "Pagar Pedágio";
            this.btnPedagio.UseVisualStyleBackColor = true;
            this.btnPedagio.Visible = false;
            this.btnPedagio.Click += new System.EventHandler(this.btnPedagio_Click);
            // 
            // btnAtracar
            // 
            this.btnAtracar.Location = new System.Drawing.Point(626, 262);
            this.btnAtracar.Name = "btnAtracar";
            this.btnAtracar.Size = new System.Drawing.Size(79, 61);
            this.btnAtracar.TabIndex = 41;
            this.btnAtracar.Text = "Atracar";
            this.btnAtracar.UseVisualStyleBackColor = true;
            this.btnAtracar.Visible = false;
            this.btnAtracar.Click += new System.EventHandler(this.btnAtracar_Click);
            // 
            // btnLimpador
            // 
            this.btnLimpador.Location = new System.Drawing.Point(532, 195);
            this.btnLimpador.Name = "btnLimpador";
            this.btnLimpador.Size = new System.Drawing.Size(88, 61);
            this.btnLimpador.TabIndex = 46;
            this.btnLimpador.Text = "Limpador";
            this.btnLimpador.UseVisualStyleBackColor = true;
            this.btnLimpador.Visible = false;
            this.btnLimpador.Click += new System.EventHandler(this.btnLimpador_Click);
            // 
            // gbxVelocidade
            // 
            this.gbxVelocidade.Controls.Add(this.lblAcelerar);
            this.gbxVelocidade.Controls.Add(this.btnDesacelerar);
            this.gbxVelocidade.Controls.Add(this.nboVelocidade);
            this.gbxVelocidade.Controls.Add(this.lblDesacelerar);
            this.gbxVelocidade.Controls.Add(this.btnAcelerar);
            this.gbxVelocidade.Location = new System.Drawing.Point(12, 186);
            this.gbxVelocidade.Name = "gbxVelocidade";
            this.gbxVelocidade.Size = new System.Drawing.Size(251, 137);
            this.gbxVelocidade.TabIndex = 47;
            this.gbxVelocidade.TabStop = false;
            this.gbxVelocidade.Text = "Velocidade";
            this.gbxVelocidade.Visible = false;
            // 
            // btnPedagioTotal
            // 
            this.btnPedagioTotal.Location = new System.Drawing.Point(626, 226);
            this.btnPedagioTotal.Name = "btnPedagioTotal";
            this.btnPedagioTotal.Size = new System.Drawing.Size(151, 29);
            this.btnPedagioTotal.TabIndex = 48;
            this.btnPedagioTotal.Text = "Pedágios Pagos";
            this.btnPedagioTotal.UseVisualStyleBackColor = true;
            this.btnPedagioTotal.Visible = false;
            this.btnPedagioTotal.Click += new System.EventHandler(this.btnPedagioTotal_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(494, 9);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(35, 16);
            this.lblTipo.TabIndex = 49;
            this.lblTipo.Text = "Tipo";
            this.lblTipo.Visible = false;
            // 
            // frmActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 339);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.btnPedagioTotal);
            this.Controls.Add(this.gbxVelocidade);
            this.Controls.Add(this.btnAtracar);
            this.Controls.Add(this.btnPedagio);
            this.Controls.Add(this.btnLimpador);
            this.Controls.Add(this.btnAtacar);
            this.Controls.Add(this.gbxAviaoG);
            this.Controls.Add(this.gbxCaminhao);
            this.Controls.Add(this.gbxMoto);
            this.Controls.Add(this.gbxAviao);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.cbxID);
            this.Controls.Add(this.lblID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmActions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ações de Veículo";
            this.Load += new System.EventHandler(this.frmActions_Load);
            this.gbxAviao.ResumeLayout(false);
            this.gbxAviaoG.ResumeLayout(false);
            this.gbxCaminhao.ResumeLayout(false);
            this.gbxCaminhao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nboPeso)).EndInit();
            this.gbxMoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nboVelocidade)).EndInit();
            this.gbxVelocidade.ResumeLayout(false);
            this.gbxVelocidade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox cbxID;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.GroupBox gbxAviao;
        private System.Windows.Forms.GroupBox gbxAviaoG;
        private System.Windows.Forms.GroupBox gbxCaminhao;
        private System.Windows.Forms.GroupBox gbxMoto;
        private System.Windows.Forms.Label lblAcelerar;
        private System.Windows.Forms.NumericUpDown nboVelocidade;
        private System.Windows.Forms.Button btnDesacelerar;
        private System.Windows.Forms.Label lblDesacelerar;
        private System.Windows.Forms.Button btnAcelerar;
        private System.Windows.Forms.Button btnAtacar;
        private System.Windows.Forms.Button btnDecolar;
        private System.Windows.Forms.Button btnArremeter;
        private System.Windows.Forms.Button btnPousar;
        private System.Windows.Forms.Button btnDecolar2;
        private System.Windows.Forms.Button btnArremeter2;
        private System.Windows.Forms.Button btnPousar2;
        private System.Windows.Forms.Button btnEjetar;
        private System.Windows.Forms.Button btnDescarregar;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Button btnPedagio;
        private System.Windows.Forms.Button btnEmpinar;
        private System.Windows.Forms.Button btnAtracar;
        private System.Windows.Forms.Button btnLimpador;
        private System.Windows.Forms.GroupBox gbxVelocidade;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.NumericUpDown nboPeso;
        private System.Windows.Forms.Button btnPedagioTotal;
        private System.Windows.Forms.Label lblTipo;
    }
}