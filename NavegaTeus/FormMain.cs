using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavegaTeus
{
    public partial class FormMain : Form
    {
        private bool atualizarInfo;

        public string UriAtual { get; private set; }

        public string TituloAtual { get; private set; }

        public FormMain()
        {
            InitializeComponent();

            var browser = new ChromiumWebBrowser("www.google.com");
            browser.Dock = DockStyle.Fill;
            browser.AddressChanged += Browser_AddressChanged;
            browser.TitleChanged += Browser_TitleChanged;

            TabPage tabPage = new TabPage("Google");
            tabPage.Controls.Add(browser);

            tabControl.TabPages[0].Controls.Add(browser);
        }

        private void btnAdicionarGuia_Click(object sender, EventArgs e)
        {
            var browser = new ChromiumWebBrowser("www.google.com");
            browser.Dock = DockStyle.Fill;
            browser.AddressChanged += Browser_AddressChanged;
            browser.TitleChanged += Browser_TitleChanged;

            TabPage tabPage = new TabPage("Google");
            tabPage.Controls.Add(browser);
            tabPage.Click += TabPage_Click;

            tabControl.TabPages.Add(tabPage);
            tabControl.SelectedIndex = tabControl.TabPages.Count - 1;
        }

        private void TabPage_Click(object sender, EventArgs e)
        {
            //var tp = (TabPage)sender;
            //txtUrl.Text = ((ChromiumWebBrowser)tp.Controls[0]).GetBrowser().
        }

        private void Browser_TitleChanged(object sender, CefSharp.TitleChangedEventArgs e)
        {
            atualizarInfo = true;
            TituloAtual = e.Title;
        }

        private void Browser_AddressChanged(object sender, CefSharp.AddressChangedEventArgs e)
        {
            atualizarInfo = true;
            UriAtual = e.Address;
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            ChromiumWebBrowser webBrowser = (ChromiumWebBrowser) tabControl.SelectedTab.Controls[0];
            
            if (txtUrl.TextLength > 0)
            {
                if (txtUrl.Text.StartsWith("www.") || txtUrl.Text.StartsWith("http"))
                {
                    webBrowser.Load(txtUrl.Text);
                }
                else
                {
                    webBrowser.Load(@"https://www.google.com/search?q=" + txtUrl.Text.Replace(" ", "+"));
                }
            }
            
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            WebBrowser webBrowser = (WebBrowser)tabControl.SelectedTab.Controls[0];
            webBrowser.Refresh();
            txtUrl.Text = webBrowser.Url.Host;
        }

        private void btnFixar_Click(object sender, EventArgs e)
        {
            TopMost = !TopMost;
            if (TopMost)
                btnFixar.Text = "Desfixar";
            else
                btnFixar.Text = "Fixar";
        }

        private void btnRemoverGuia_Click(object sender, EventArgs e)
        {
            if (tabControl.TabCount > 1)
            {
                ChromiumWebBrowser webBrowser = (ChromiumWebBrowser) tabControl.SelectedTab.Controls[0];
                webBrowser.TitleChanged -= Browser_TitleChanged;
                webBrowser.AddressChanged -= Browser_AddressChanged;

                int index = tabControl.SelectedIndex;

                tabControl.TabPages.Remove(tabControl.SelectedTab);
                tabControl.SelectedIndex = index - 1;
            }
        }
        private void txtUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnCarregar.PerformClick();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            ((ChromiumWebBrowser)tabControl.SelectedTab.Controls[0]).GetBrowser().GoBack();
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            ((ChromiumWebBrowser)tabControl.SelectedTab.Controls[0]).GetBrowser().GoForward();
        }

        private void timerAtualizaInformacoes_Tick(object sender, EventArgs e)
        {
            if (atualizarInfo)
            {
                txtUrl.Text = UriAtual;
                tabControl.SelectedTab.Text = TituloAtual;
                atualizarInfo = false;
            }
            
        }
    }
}
