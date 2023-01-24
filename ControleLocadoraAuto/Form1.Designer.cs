namespace ControleLocadoraAuto
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dtpDataHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbValorHora = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbValorDia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.rtbFaturaCalculada = new System.Windows.Forms.RichTextBox();
            this.dtpDataHoraFim = new System.Windows.Forms.DateTimePicker();
            this.rbBasico = new System.Windows.Forms.RadioButton();
            this.rbIntermediario = new System.Windows.Forms.RadioButton();
            this.rbLuxo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCarrosDisponiveis = new System.Windows.Forms.ComboBox();
            this.btAlugar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picFotoCarro = new System.Windows.Forms.PictureBox();
            this.panAlugar = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btTelaAluguel = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btTelaDevolucao = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoCarro)).BeginInit();
            this.panAlugar.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpDataHoraInicio
            // 
            this.dtpDataHoraInicio.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpDataHoraInicio.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDataHoraInicio.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataHoraInicio.Location = new System.Drawing.Point(112, 35);
            this.dtpDataHoraInicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDataHoraInicio.Name = "dtpDataHoraInicio";
            this.dtpDataHoraInicio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpDataHoraInicio.Size = new System.Drawing.Size(168, 27);
            this.dtpDataHoraInicio.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Retirada";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Devolução";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(7, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Por hora";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbValorHora
            // 
            this.tbValorHora.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValorHora.Location = new System.Drawing.Point(113, 42);
            this.tbValorHora.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbValorHora.Name = "tbValorHora";
            this.tbValorHora.ReadOnly = true;
            this.tbValorHora.Size = new System.Drawing.Size(80, 27);
            this.tbValorHora.TabIndex = 2;
            this.tbValorHora.Text = "10.00";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(14, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Por dia";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbValorDia
            // 
            this.tbValorDia.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValorDia.Location = new System.Drawing.Point(113, 97);
            this.tbValorDia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbValorDia.Name = "tbValorDia";
            this.tbValorDia.ReadOnly = true;
            this.tbValorDia.Size = new System.Drawing.Size(80, 27);
            this.tbValorDia.TabIndex = 2;
            this.tbValorDia.Text = "130.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(634, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Orçamento";
            // 
            // btCalcular
            // 
            this.btCalcular.BackColor = System.Drawing.Color.Transparent;
            this.btCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCalcular.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.Location = new System.Drawing.Point(670, 382);
            this.btCalcular.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(99, 36);
            this.btCalcular.TabIndex = 4;
            this.btCalcular.Text = "Orçamento";
            this.btCalcular.UseVisualStyleBackColor = false;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // rtbFaturaCalculada
            // 
            this.rtbFaturaCalculada.Location = new System.Drawing.Point(633, 182);
            this.rtbFaturaCalculada.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbFaturaCalculada.Name = "rtbFaturaCalculada";
            this.rtbFaturaCalculada.ReadOnly = true;
            this.rtbFaturaCalculada.Size = new System.Drawing.Size(299, 178);
            this.rtbFaturaCalculada.TabIndex = 5;
            this.rtbFaturaCalculada.Text = "";
            // 
            // dtpDataHoraFim
            // 
            this.dtpDataHoraFim.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpDataHoraFim.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDataHoraFim.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataHoraFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataHoraFim.Location = new System.Drawing.Point(112, 75);
            this.dtpDataHoraFim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDataHoraFim.Name = "dtpDataHoraFim";
            this.dtpDataHoraFim.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpDataHoraFim.Size = new System.Drawing.Size(168, 27);
            this.dtpDataHoraFim.TabIndex = 0;
            // 
            // rbBasico
            // 
            this.rbBasico.AutoSize = true;
            this.rbBasico.Location = new System.Drawing.Point(18, 26);
            this.rbBasico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbBasico.Name = "rbBasico";
            this.rbBasico.Size = new System.Drawing.Size(72, 24);
            this.rbBasico.TabIndex = 6;
            this.rbBasico.Text = "Básico";
            this.rbBasico.UseVisualStyleBackColor = true;
            this.rbBasico.CheckedChanged += new System.EventHandler(this.rbBasico_CheckedChanged);
            // 
            // rbIntermediario
            // 
            this.rbIntermediario.AutoSize = true;
            this.rbIntermediario.Location = new System.Drawing.Point(18, 64);
            this.rbIntermediario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbIntermediario.Name = "rbIntermediario";
            this.rbIntermediario.Size = new System.Drawing.Size(117, 24);
            this.rbIntermediario.TabIndex = 6;
            this.rbIntermediario.Text = "Intermediário";
            this.rbIntermediario.UseVisualStyleBackColor = true;
            this.rbIntermediario.CheckedChanged += new System.EventHandler(this.rbIntemediario_CheckedChanged);
            // 
            // rbLuxo
            // 
            this.rbLuxo.AutoSize = true;
            this.rbLuxo.Location = new System.Drawing.Point(18, 102);
            this.rbLuxo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbLuxo.Name = "rbLuxo";
            this.rbLuxo.Size = new System.Drawing.Size(55, 24);
            this.rbLuxo.TabIndex = 6;
            this.rbLuxo.Text = "Luxo";
            this.rbLuxo.UseVisualStyleBackColor = true;
            this.rbLuxo.CheckedChanged += new System.EventHandler(this.rbLuxo_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbBasico);
            this.groupBox1.Controls.Add(this.rbIntermediario);
            this.groupBox1.Controls.Add(this.rbLuxo);
            this.groupBox1.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox1.Location = new System.Drawing.Point(16, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(222, 141);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categoria";
            // 
            // cbCarrosDisponiveis
            // 
            this.cbCarrosDisponiveis.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCarrosDisponiveis.FormattingEnabled = true;
            this.cbCarrosDisponiveis.Location = new System.Drawing.Point(20, 68);
            this.cbCarrosDisponiveis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCarrosDisponiveis.Name = "cbCarrosDisponiveis";
            this.cbCarrosDisponiveis.Size = new System.Drawing.Size(258, 28);
            this.cbCarrosDisponiveis.TabIndex = 9;
            this.cbCarrosDisponiveis.SelectedIndexChanged += new System.EventHandler(this.cbCarrosDisponiveis_SelectedIndexChanged);
            // 
            // btAlugar
            // 
            this.btAlugar.BackColor = System.Drawing.Color.Transparent;
            this.btAlugar.Enabled = false;
            this.btAlugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlugar.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlugar.Location = new System.Drawing.Point(791, 382);
            this.btAlugar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAlugar.Name = "btAlugar";
            this.btAlugar.Size = new System.Drawing.Size(99, 36);
            this.btAlugar.TabIndex = 4;
            this.btAlugar.Text = "Alugar";
            this.btAlugar.UseVisualStyleBackColor = false;
            this.btAlugar.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.picFotoCarro);
            this.groupBox2.Controls.Add(this.cbCarrosDisponiveis);
            this.groupBox2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Silver;
            this.groupBox2.Location = new System.Drawing.Point(258, 21);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(360, 339);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(16, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Selecione o modelo:";
            // 
            // picFotoCarro
            // 
            this.picFotoCarro.Location = new System.Drawing.Point(20, 139);
            this.picFotoCarro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picFotoCarro.Name = "picFotoCarro";
            this.picFotoCarro.Size = new System.Drawing.Size(320, 180);
            this.picFotoCarro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFotoCarro.TabIndex = 11;
            this.picFotoCarro.TabStop = false;
            // 
            // panAlugar
            // 
            this.panAlugar.BackColor = System.Drawing.Color.Transparent;
            this.panAlugar.Controls.Add(this.groupBox4);
            this.panAlugar.Controls.Add(this.groupBox3);
            this.panAlugar.Controls.Add(this.groupBox2);
            this.panAlugar.Controls.Add(this.groupBox1);
            this.panAlugar.Controls.Add(this.btAlugar);
            this.panAlugar.Controls.Add(this.label6);
            this.panAlugar.Controls.Add(this.btCalcular);
            this.panAlugar.Controls.Add(this.rtbFaturaCalculada);
            this.panAlugar.Location = new System.Drawing.Point(126, 13);
            this.panAlugar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panAlugar.Name = "panAlugar";
            this.panAlugar.Size = new System.Drawing.Size(946, 435);
            this.panAlugar.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtpDataHoraInicio);
            this.groupBox4.Controls.Add(this.dtpDataHoraFim);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox4.Location = new System.Drawing.Point(633, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(299, 126);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datas";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tbValorDia);
            this.groupBox3.Controls.Add(this.tbValorHora);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Silver;
            this.groupBox3.Location = new System.Drawing.Point(16, 207);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(222, 153);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Valores (R$)";
            // 
            // btTelaAluguel
            // 
            this.btTelaAluguel.BackColor = System.Drawing.Color.LightGray;
            this.btTelaAluguel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTelaAluguel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTelaAluguel.ForeColor = System.Drawing.Color.Black;
            this.btTelaAluguel.Location = new System.Drawing.Point(12, 48);
            this.btTelaAluguel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btTelaAluguel.Name = "btTelaAluguel";
            this.btTelaAluguel.Size = new System.Drawing.Size(99, 36);
            this.btTelaAluguel.TabIndex = 12;
            this.btTelaAluguel.Text = "Aluguel";
            this.btTelaAluguel.UseVisualStyleBackColor = false;
            this.btTelaAluguel.Click += new System.EventHandler(this.btTelaAluguel_Click);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Transparent;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Location = new System.Drawing.Point(12, 395);
            this.btSair.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(99, 36);
            this.btSair.TabIndex = 13;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btTelaDevolucao
            // 
            this.btTelaDevolucao.BackColor = System.Drawing.Color.Transparent;
            this.btTelaDevolucao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTelaDevolucao.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTelaDevolucao.Location = new System.Drawing.Point(12, 104);
            this.btTelaDevolucao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btTelaDevolucao.Name = "btTelaDevolucao";
            this.btTelaDevolucao.Size = new System.Drawing.Size(99, 36);
            this.btTelaDevolucao.TabIndex = 14;
            this.btTelaDevolucao.Text = "Devolução";
            this.btTelaDevolucao.UseVisualStyleBackColor = false;
            this.btTelaDevolucao.Click += new System.EventHandler(this.btTelaDevolucao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.Controls.Add(this.btTelaDevolucao);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btTelaAluguel);
            this.Controls.Add(this.panAlugar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Locadora Grupo 5";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoCarro)).EndInit();
            this.panAlugar.ResumeLayout(false);
            this.panAlugar.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpDataHoraInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbValorHora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbValorDia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.RichTextBox rtbFaturaCalculada;
        private System.Windows.Forms.DateTimePicker dtpDataHoraFim;
        private System.Windows.Forms.RadioButton rbBasico;
        private System.Windows.Forms.RadioButton rbIntermediario;
        private System.Windows.Forms.RadioButton rbLuxo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbCarrosDisponiveis;
        private System.Windows.Forms.Button btAlugar;
        private System.Windows.Forms.PictureBox picFotoCarro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panAlugar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btTelaAluguel;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btTelaDevolucao;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

