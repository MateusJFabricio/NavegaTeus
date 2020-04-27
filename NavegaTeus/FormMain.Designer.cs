namespace NavegaTeus
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdicionarGuia = new System.Windows.Forms.Button();
            this.btnRemoverGuia = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.btnFixar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowserMain = new System.Windows.Forms.WebBrowser();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flowLayoutPanel1.Controls.Add(this.btnAdicionarGuia);
            this.flowLayoutPanel1.Controls.Add(this.btnRemoverGuia);
            this.flowLayoutPanel1.Controls.Add(this.txtUrl);
            this.flowLayoutPanel1.Controls.Add(this.btnCarregar);
            this.flowLayoutPanel1.Controls.Add(this.btnAtualizar);
            this.flowLayoutPanel1.Controls.Add(this.btnVoltar);
            this.flowLayoutPanel1.Controls.Add(this.btnAvancar);
            this.flowLayoutPanel1.Controls.Add(this.btnFixar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1031, 31);
            this.flowLayoutPanel1.TabIndex = 0;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 490);
            this.panel1.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1031, 490);
            this.tabControl.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowserMain);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1023, 464);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Google";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Enter += new System.EventHandler(this.tabPage_Enter);
            // 
            // webBrowserMain
            // 
            this.webBrowserMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserMain.Location = new System.Drawing.Point(3, 3);
            this.webBrowserMain.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserMain.Name = "webBrowserMain";
            this.webBrowserMain.Size = new System.Drawing.Size(1017, 458);
            this.webBrowserMain.TabIndex = 0;
            this.webBrowserMain.Url = new System.Uri("https://www.google.com/", System.UriKind.Absolute);
            this.webBrowserMain.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowserMain_Navigated);
            this.webBrowserMain.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowserMain_Navigating);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 521);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FormMain";
            this.Text = "NavegaTeus";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAdicionarGuia;
        private System.Windows.Forms.Button btnFixar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnRemoverGuia;
        private System.Windows.Forms.WebBrowser webBrowserMain;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAvancar;
    }
}

