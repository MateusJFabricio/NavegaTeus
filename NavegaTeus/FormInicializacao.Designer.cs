namespace NavegaTeus
{
    partial class FormInicializacao
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
            this.cbOcultarControles = new System.Windows.Forms.CheckBox();
            this.cbExibirDataHora = new System.Windows.Forms.CheckBox();
            this.cbAtualizarPagina = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPaginaPadrao = new System.Windows.Forms.TextBox();
            this.cbInicializarWindows = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpIntervaloAtualizacaoPagina = new System.Windows.Forms.DateTimePicker();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnTestar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbExibirTempoRestante = new System.Windows.Forms.CheckBox();
            this.groupBoxFormatoDataHora = new System.Windows.Forms.GroupBox();
            this.pnlCorLetra = new System.Windows.Forms.Panel();
            this.pnlCorFundo = new System.Windows.Forms.Panel();
            this.lblFonte = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fontDialogDataHora = new System.Windows.Forms.FontDialog();
            this.colorDialogDataHoraFundo = new System.Windows.Forms.ColorDialog();
            this.colorDialogDataHoraLetra = new System.Windows.Forms.ColorDialog();
            this.cbExibirSemana = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxFormatoDataHora.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbOcultarControles
            // 
            this.cbOcultarControles.AutoSize = true;
            this.cbOcultarControles.Location = new System.Drawing.Point(16, 61);
            this.cbOcultarControles.Name = "cbOcultarControles";
            this.cbOcultarControles.Size = new System.Drawing.Size(168, 17);
            this.cbOcultarControles.TabIndex = 3;
            this.cbOcultarControles.Text = "Ocultar controles do programa";
            this.cbOcultarControles.UseVisualStyleBackColor = true;
            // 
            // cbExibirDataHora
            // 
            this.cbExibirDataHora.AutoSize = true;
            this.cbExibirDataHora.Location = new System.Drawing.Point(20, 22);
            this.cbExibirDataHora.Name = "cbExibirDataHora";
            this.cbExibirDataHora.Size = new System.Drawing.Size(108, 17);
            this.cbExibirDataHora.TabIndex = 4;
            this.cbExibirDataHora.Text = "Exibir data e hora";
            this.cbExibirDataHora.UseVisualStyleBackColor = true;
            this.cbExibirDataHora.CheckedChanged += new System.EventHandler(this.cbExibirDataHora_CheckedChanged);
            // 
            // cbAtualizarPagina
            // 
            this.cbAtualizarPagina.AutoSize = true;
            this.cbAtualizarPagina.Location = new System.Drawing.Point(16, 95);
            this.cbAtualizarPagina.Name = "cbAtualizarPagina";
            this.cbAtualizarPagina.Size = new System.Drawing.Size(185, 17);
            this.cbAtualizarPagina.TabIndex = 5;
            this.cbAtualizarPagina.Text = "Atualizar pagina automaticamente";
            this.cbAtualizarPagina.UseVisualStyleBackColor = true;
            this.cbAtualizarPagina.CheckedChanged += new System.EventHandler(this.cbAtualizarPagina_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pagina padrão:";
            // 
            // txtPaginaPadrao
            // 
            this.txtPaginaPadrao.Location = new System.Drawing.Point(99, 23);
            this.txtPaginaPadrao.Name = "txtPaginaPadrao";
            this.txtPaginaPadrao.Size = new System.Drawing.Size(650, 20);
            this.txtPaginaPadrao.TabIndex = 7;
            // 
            // cbInicializarWindows
            // 
            this.cbInicializarWindows.AutoSize = true;
            this.cbInicializarWindows.Location = new System.Drawing.Point(16, 26);
            this.cbInicializarWindows.Name = "cbInicializarWindows";
            this.cbInicializarWindows.Size = new System.Drawing.Size(174, 17);
            this.cbInicializarWindows.TabIndex = 8;
            this.cbInicializarWindows.Text = "Inicializar junto com o Windows";
            this.cbInicializarWindows.UseVisualStyleBackColor = true;
            this.cbInicializarWindows.CheckedChanged += new System.EventHandler(this.cbInicializarWindows_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Intervalo de atualizacao da página:";
            // 
            // dtpIntervaloAtualizacaoPagina
            // 
            this.dtpIntervaloAtualizacaoPagina.CustomFormat = "HH:mm";
            this.dtpIntervaloAtualizacaoPagina.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpIntervaloAtualizacaoPagina.Location = new System.Drawing.Point(192, 126);
            this.dtpIntervaloAtualizacaoPagina.Name = "dtpIntervaloAtualizacaoPagina";
            this.dtpIntervaloAtualizacaoPagina.Size = new System.Drawing.Size(99, 20);
            this.dtpIntervaloAtualizacaoPagina.TabIndex = 11;
            this.dtpIntervaloAtualizacaoPagina.Value = new System.DateTime(2021, 11, 17, 10, 0, 0, 0);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(593, 272);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnTestar
            // 
            this.btnTestar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTestar.Location = new System.Drawing.Point(674, 272);
            this.btnTestar.Name = "btnTestar";
            this.btnTestar.Size = new System.Drawing.Size(75, 23);
            this.btnTestar.TabIndex = 13;
            this.btnTestar.Text = "Testar";
            this.btnTestar.UseVisualStyleBackColor = true;
            this.btnTestar.Click += new System.EventHandler(this.btnTestar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPaginaPadrao);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(761, 262);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuracoes";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbInicializarWindows);
            this.groupBox3.Controls.Add(this.cbAtualizarPagina);
            this.groupBox3.Controls.Add(this.dtpIntervaloAtualizacaoPagina);
            this.groupBox3.Controls.Add(this.cbOcultarControles);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(313, 193);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Automacao";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbExibirSemana);
            this.groupBox2.Controls.Add(this.cbExibirTempoRestante);
            this.groupBox2.Controls.Add(this.groupBoxFormatoDataHora);
            this.groupBox2.Controls.Add(this.cbExibirDataHora);
            this.groupBox2.Location = new System.Drawing.Point(331, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 193);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Textos";
            // 
            // cbExibirTempoRestante
            // 
            this.cbExibirTempoRestante.AutoSize = true;
            this.cbExibirTempoRestante.Location = new System.Drawing.Point(20, 45);
            this.cbExibirTempoRestante.Name = "cbExibirTempoRestante";
            this.cbExibirTempoRestante.Size = new System.Drawing.Size(253, 17);
            this.cbExibirTempoRestante.TabIndex = 13;
            this.cbExibirTempoRestante.Text = "Exibir tempo restante para a proxima atualizacao";
            this.cbExibirTempoRestante.UseVisualStyleBackColor = true;
            // 
            // groupBoxFormatoDataHora
            // 
            this.groupBoxFormatoDataHora.Controls.Add(this.pnlCorLetra);
            this.groupBoxFormatoDataHora.Controls.Add(this.pnlCorFundo);
            this.groupBoxFormatoDataHora.Controls.Add(this.lblFonte);
            this.groupBoxFormatoDataHora.Controls.Add(this.label5);
            this.groupBoxFormatoDataHora.Controls.Add(this.label4);
            this.groupBoxFormatoDataHora.Controls.Add(this.label3);
            this.groupBoxFormatoDataHora.Location = new System.Drawing.Point(20, 68);
            this.groupBoxFormatoDataHora.Name = "groupBoxFormatoDataHora";
            this.groupBoxFormatoDataHora.Size = new System.Drawing.Size(392, 106);
            this.groupBoxFormatoDataHora.TabIndex = 12;
            this.groupBoxFormatoDataHora.TabStop = false;
            this.groupBoxFormatoDataHora.Text = "Formato Textos";
            // 
            // pnlCorLetra
            // 
            this.pnlCorLetra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCorLetra.Location = new System.Drawing.Point(90, 72);
            this.pnlCorLetra.Name = "pnlCorLetra";
            this.pnlCorLetra.Size = new System.Drawing.Size(40, 22);
            this.pnlCorLetra.TabIndex = 5;
            this.pnlCorLetra.Click += new System.EventHandler(this.pnlCorLetra_Click);
            // 
            // pnlCorFundo
            // 
            this.pnlCorFundo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCorFundo.Location = new System.Drawing.Point(90, 44);
            this.pnlCorFundo.Name = "pnlCorFundo";
            this.pnlCorFundo.Size = new System.Drawing.Size(40, 22);
            this.pnlCorFundo.TabIndex = 4;
            this.pnlCorFundo.Click += new System.EventHandler(this.pnlCorFundo_Click);
            // 
            // lblFonte
            // 
            this.lblFonte.AutoSize = true;
            this.lblFonte.Location = new System.Drawing.Point(90, 25);
            this.lblFonte.Name = "lblFonte";
            this.lblFonte.Size = new System.Drawing.Size(83, 13);
            this.lblFonte.TabIndex = 3;
            this.lblFonte.Text = "aqui fica a fonte";
            this.lblFonte.Click += new System.EventHandler(this.lblFonte_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cor Letra:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cor Fundo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fonte:";
            // 
            // cbExibirSemana
            // 
            this.cbExibirSemana.AutoSize = true;
            this.cbExibirSemana.Location = new System.Drawing.Point(134, 22);
            this.cbExibirSemana.Name = "cbExibirSemana";
            this.cbExibirSemana.Size = new System.Drawing.Size(91, 17);
            this.cbExibirSemana.TabIndex = 14;
            this.cbExibirSemana.Text = "Exibir semana";
            this.cbExibirSemana.UseVisualStyleBackColor = true;
            // 
            // FormInicializacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 301);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTestar);
            this.Controls.Add(this.btnSalvar);
            this.Name = "FormInicializacao";
            this.Text = "Configuracao da Inicializacao";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxFormatoDataHora.ResumeLayout(false);
            this.groupBoxFormatoDataHora.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox cbOcultarControles;
        private System.Windows.Forms.CheckBox cbExibirDataHora;
        private System.Windows.Forms.CheckBox cbAtualizarPagina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPaginaPadrao;
        private System.Windows.Forms.CheckBox cbInicializarWindows;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpIntervaloAtualizacaoPagina;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnTestar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxFormatoDataHora;
        private System.Windows.Forms.FontDialog fontDialogDataHora;
        private System.Windows.Forms.ColorDialog colorDialogDataHoraFundo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlCorLetra;
        private System.Windows.Forms.Panel pnlCorFundo;
        private System.Windows.Forms.Label lblFonte;
        private System.Windows.Forms.ColorDialog colorDialogDataHoraLetra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbExibirTempoRestante;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbExibirSemana;
    }
}