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
            this.dtpDataHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpDataHoraInicio
            // 
            this.dtpDataHoraInicio.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpDataHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataHoraInicio.Location = new System.Drawing.Point(111, 43);
            this.dtpDataHoraInicio.Name = "dtpDataHoraInicio";
            this.dtpDataHoraInicio.Size = new System.Drawing.Size(129, 20);
            this.dtpDataHoraInicio.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Retirada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Devolução";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(439, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Valor por hora";
            // 
            // tbValorHora
            // 
            this.tbValorHora.Location = new System.Drawing.Point(554, 12);
            this.tbValorHora.Name = "tbValorHora";
            this.tbValorHora.ReadOnly = true;
            this.tbValorHora.Size = new System.Drawing.Size(100, 20);
            this.tbValorHora.TabIndex = 2;
            this.tbValorHora.Text = "10.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(451, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Valor por dia";
            // 
            // tbValorDia
            // 
            this.tbValorDia.Location = new System.Drawing.Point(554, 40);
            this.tbValorDia.Name = "tbValorDia";
            this.tbValorDia.ReadOnly = true;
            this.tbValorDia.Size = new System.Drawing.Size(100, 20);
            this.tbValorDia.TabIndex = 2;
            this.tbValorDia.Text = "130.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "FATURA:";
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(382, 262);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(75, 23);
            this.btCalcular.TabIndex = 4;
            this.btCalcular.Text = "Orçamento";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // rtbFaturaCalculada
            // 
            this.rtbFaturaCalculada.Location = new System.Drawing.Point(382, 76);
            this.rtbFaturaCalculada.Name = "rtbFaturaCalculada";
            this.rtbFaturaCalculada.Size = new System.Drawing.Size(172, 162);
            this.rtbFaturaCalculada.TabIndex = 5;
            this.rtbFaturaCalculada.Text = "";
            // 
            // dtpDataHoraFim
            // 
            this.dtpDataHoraFim.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpDataHoraFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataHoraFim.Location = new System.Drawing.Point(111, 69);
            this.dtpDataHoraFim.Name = "dtpDataHoraFim";
            this.dtpDataHoraFim.Size = new System.Drawing.Size(129, 20);
            this.dtpDataHoraFim.TabIndex = 0;
            // 
            // rbBasico
            // 
            this.rbBasico.AutoSize = true;
            this.rbBasico.Checked = true;
            this.rbBasico.Location = new System.Drawing.Point(6, 27);
            this.rbBasico.Name = "rbBasico";
            this.rbBasico.Size = new System.Drawing.Size(57, 17);
            this.rbBasico.TabIndex = 6;
            this.rbBasico.TabStop = true;
            this.rbBasico.Text = "Básico";
            this.rbBasico.UseVisualStyleBackColor = true;
            this.rbBasico.CheckedChanged += new System.EventHandler(this.rbBasico_CheckedChanged);
            // 
            // rbIntermediario
            // 
            this.rbIntermediario.AutoSize = true;
            this.rbIntermediario.Location = new System.Drawing.Point(6, 50);
            this.rbIntermediario.Name = "rbIntermediario";
            this.rbIntermediario.Size = new System.Drawing.Size(85, 17);
            this.rbIntermediario.TabIndex = 6;
            this.rbIntermediario.TabStop = true;
            this.rbIntermediario.Text = "Intermediário";
            this.rbIntermediario.UseVisualStyleBackColor = true;
            this.rbIntermediario.CheckedChanged += new System.EventHandler(this.rbIntemediario_CheckedChanged);
            // 
            // rbLuxo
            // 
            this.rbLuxo.AutoSize = true;
            this.rbLuxo.Location = new System.Drawing.Point(6, 76);
            this.rbLuxo.Name = "rbLuxo";
            this.rbLuxo.Size = new System.Drawing.Size(48, 17);
            this.rbLuxo.TabIndex = 6;
            this.rbLuxo.TabStop = true;
            this.rbLuxo.Text = "Luxo";
            this.rbLuxo.UseVisualStyleBackColor = true;
            this.rbLuxo.CheckedChanged += new System.EventHandler(this.rbLuxo_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbBasico);
            this.groupBox1.Controls.Add(this.rbIntermediario);
            this.groupBox1.Controls.Add(this.rbLuxo);
            this.groupBox1.Location = new System.Drawing.Point(243, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categoria";
            // 
            // cbCarrosDisponiveis
            // 
            this.cbCarrosDisponiveis.FormattingEnabled = true;
            this.cbCarrosDisponiveis.Location = new System.Drawing.Point(12, 100);
            this.cbCarrosDisponiveis.Name = "cbCarrosDisponiveis";
            this.cbCarrosDisponiveis.Size = new System.Drawing.Size(245, 21);
            this.cbCarrosDisponiveis.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(479, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Orçamento";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 177);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 100);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 74);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Aluguel";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Devolução";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(731, 314);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cbCarrosDisponiveis);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rtbFaturaCalculada);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.tbValorDia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbValorHora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDataHoraFim);
            this.Controls.Add(this.dtpDataHoraInicio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpDataHoraInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

