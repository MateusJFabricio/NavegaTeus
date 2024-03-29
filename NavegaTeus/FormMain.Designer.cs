﻿namespace NavegaTeus
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.flowLayoutPanelSuperior = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdicionarGuia = new System.Windows.Forms.Button();
            this.btnRemoverGuia = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.btnFixar = new System.Windows.Forms.Button();
            this.btnInicializacao = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblTempoRestante = new System.Windows.Forms.Label();
            this.lblDataHoraSemana = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.timerAtualizaInformacoes = new System.Windows.Forms.Timer(this.components);
            this.timerAutoRefreshPage = new System.Windows.Forms.Timer(this.components);
            this.timerBtnClose = new System.Windows.Forms.Timer(this.components);
            this.timerMouseMonitor = new System.Windows.Forms.Timer(this.components);
            this.timerRelogio = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanelSuperior.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelSuperior
            // 
            this.flowLayoutPanelSuperior.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flowLayoutPanelSuperior.Controls.Add(this.btnAdicionarGuia);
            this.flowLayoutPanelSuperior.Controls.Add(this.btnRemoverGuia);
            this.flowLayoutPanelSuperior.Controls.Add(this.txtUrl);
            this.flowLayoutPanelSuperior.Controls.Add(this.btnCarregar);
            this.flowLayoutPanelSuperior.Controls.Add(this.btnAtualizar);
            this.flowLayoutPanelSuperior.Controls.Add(this.btnVoltar);
            this.flowLayoutPanelSuperior.Controls.Add(this.btnAvancar);
            this.flowLayoutPanelSuperior.Controls.Add(this.btnFixar);
            this.flowLayoutPanelSuperior.Controls.Add(this.btnInicializacao);
            this.flowLayoutPanelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelSuperior.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelSuperior.Name = "flowLayoutPanelSuperior";
            this.flowLayoutPanelSuperior.Size = new System.Drawing.Size(1163, 31);
            this.flowLayoutPanelSuperior.TabIndex = 0;
            // 
            // btnAdicionarGuia
            // 
            this.btnAdicionarGuia.Location = new System.Drawing.Point(3, 3);
            this.btnAdicionarGuia.Name = "btnAdicionarGuia";
            this.btnAdicionarGuia.Size = new System.Drawing.Size(92, 23);
            this.btnAdicionarGuia.TabIndex = 0;
            this.btnAdicionarGuia.Text = "Adicionar Guia";
            this.btnAdicionarGuia.UseVisualStyleBackColor = true;
            this.btnAdicionarGuia.Click += new System.EventHandler(this.btnAdicionarGuia_Click);
            // 
            // btnRemoverGuia
            // 
            this.btnRemoverGuia.Location = new System.Drawing.Point(101, 3);
            this.btnRemoverGuia.Name = "btnRemoverGuia";
            this.btnRemoverGuia.Size = new System.Drawing.Size(90, 23);
            this.btnRemoverGuia.TabIndex = 4;
            this.btnRemoverGuia.Text = "Remover Guia";
            this.btnRemoverGuia.UseVisualStyleBackColor = true;
            this.btnRemoverGuia.Click += new System.EventHandler(this.btnRemoverGuia_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(197, 3);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(490, 20);
            this.txtUrl.TabIndex = 2;
            this.txtUrl.Text = "https://www.google.com/";
            this.txtUrl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrl_KeyPress);
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(693, 3);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(32, 23);
            this.btnCarregar.TabIndex = 5;
            this.btnCarregar.Text = "->";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(731, 3);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(62, 23);
            this.btnAtualizar.TabIndex = 3;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(799, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(38, 23);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "<";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAvancar
            // 
            this.btnAvancar.Location = new System.Drawing.Point(843, 3);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(38, 23);
            this.btnAvancar.TabIndex = 7;
            this.btnAvancar.Text = ">";
            this.btnAvancar.UseVisualStyleBackColor = true;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // btnFixar
            // 
            this.btnFixar.Location = new System.Drawing.Point(887, 3);
            this.btnFixar.Name = "btnFixar";
            this.btnFixar.Size = new System.Drawing.Size(52, 23);
            this.btnFixar.TabIndex = 1;
            this.btnFixar.Text = "Fixar";
            this.btnFixar.UseVisualStyleBackColor = true;
            this.btnFixar.Click += new System.EventHandler(this.btnFixar_Click);
            // 
            // btnInicializacao
            // 
            this.btnInicializacao.Location = new System.Drawing.Point(945, 3);
            this.btnInicializacao.Name = "btnInicializacao";
            this.btnInicializacao.Size = new System.Drawing.Size(82, 23);
            this.btnInicializacao.TabIndex = 8;
            this.btnInicializacao.Text = "Inicializacao";
            this.btnInicializacao.UseVisualStyleBackColor = true;
            this.btnInicializacao.Click += new System.EventHandler(this.btnInicializacao_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.lblTempoRestante);
            this.panelMain.Controls.Add(this.lblDataHoraSemana);
            this.panelMain.Controls.Add(this.btnClose);
            this.panelMain.Controls.Add(this.tabControl);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 31);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1163, 490);
            this.panelMain.TabIndex = 1;
            // 
            // lblTempoRestante
            // 
            this.lblTempoRestante.AutoSize = true;
            this.lblTempoRestante.BackColor = System.Drawing.Color.White;
            this.lblTempoRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempoRestante.Location = new System.Drawing.Point(3, 46);
            this.lblTempoRestante.Name = "lblTempoRestante";
            this.lblTempoRestante.Size = new System.Drawing.Size(408, 31);
            this.lblTempoRestante.TabIndex = 3;
            this.lblTempoRestante.Text = "Proxima Atualizacao: 1 dia 10:08";
            // 
            // lblDataHoraSemana
            // 
            this.lblDataHoraSemana.AutoSize = true;
            this.lblDataHoraSemana.BackColor = System.Drawing.Color.White;
            this.lblDataHoraSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataHoraSemana.Location = new System.Drawing.Point(3, 11);
            this.lblDataHoraSemana.Name = "lblDataHoraSemana";
            this.lblDataHoraSemana.Size = new System.Drawing.Size(381, 31);
            this.lblDataHoraSemana.TabIndex = 0;
            this.lblDataHoraSemana.Text = "Data e hora: 10/12/2021 14:35";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1103, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 44);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1163, 490);
            this.tabControl.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1155, 464);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Google";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // timerAtualizaInformacoes
            // 
            this.timerAtualizaInformacoes.Enabled = true;
            this.timerAtualizaInformacoes.Interval = 500;
            this.timerAtualizaInformacoes.Tick += new System.EventHandler(this.timerAtualizaInformacoes_Tick);
            // 
            // timerAutoRefreshPage
            // 
            this.timerAutoRefreshPage.Interval = 1000;
            this.timerAutoRefreshPage.Tick += new System.EventHandler(this.timerAutoRefreshPage_Tick);
            // 
            // timerBtnClose
            // 
            this.timerBtnClose.Interval = 1000;
            this.timerBtnClose.Tick += new System.EventHandler(this.timerBtnClose_Tick);
            // 
            // timerMouseMonitor
            // 
            this.timerMouseMonitor.Interval = 600;
            this.timerMouseMonitor.Tick += new System.EventHandler(this.timerMouseMonitor_Tick);
            // 
            // timerRelogio
            // 
            this.timerRelogio.Interval = 1000;
            this.timerRelogio.Tick += new System.EventHandler(this.timerRelogio_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 521);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.flowLayoutPanelSuperior);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "NavegaTeus";
            this.flowLayoutPanelSuperior.ResumeLayout(false);
            this.flowLayoutPanelSuperior.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSuperior;
        private System.Windows.Forms.Button btnAdicionarGuia;
        private System.Windows.Forms.Button btnFixar;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnRemoverGuia;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.Timer timerAtualizaInformacoes;
        private System.Windows.Forms.Button btnInicializacao;
        private System.Windows.Forms.Label lblDataHoraSemana;
        private System.Windows.Forms.Timer timerAutoRefreshPage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Timer timerBtnClose;
        private System.Windows.Forms.Timer timerMouseMonitor;
        private System.Windows.Forms.Timer timerRelogio;
        private System.Windows.Forms.Label lblTempoRestante;
    }
}

