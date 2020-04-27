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
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnAdicionarGuia_Click(object sender, EventArgs e)
        {
            WebBrowser webBrowser = new WebBrowser();
            webBrowser.Url = new Uri(@"https://www.google.com/");
            webBrowser.Dock = DockStyle.Fill;
            webBrowser.Navigating += webBrowserMain_Navigating;
            webBrowser.Navigated += webBrowserMain_Navigated;

            TabPage tabPage = new TabPage("Google");
            tabPage.Controls.Add(webBrowser);
            tabPage.Enter += tabPage_Enter;

            tabControl.TabPages.Add(tabPage);
            tabControl.SelectedIndex = tabControl.TabPages.Count - 1;
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            WebBrowser webBrowser = (WebBrowser) tabControl.SelectedTab.Controls[0];
            
            webBrowser.Navigate(txtUrl.Text);
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
                WebBrowser webBrowser = (WebBrowser) tabControl.SelectedTab.Controls[0];
                webBrowser.Navigating -= webBrowserMain_Navigating;
                webBrowser.Navigated -= webBrowserMain_Navigated;
                int index = tabControl.SelectedIndex;
                tabControl.SelectedTab.Enter -= tabPage_Enter;

                tabControl.TabPages.Remove(tabControl.SelectedTab);
                tabControl.SelectedIndex = index - 1;
            }
        }

        private void webBrowserMain_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            //txtUrl.Text = e.Url.AbsoluteUri;
            tabControl.SelectedTab.Text = ((WebBrowser)sender).DocumentTitle;
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
            ((WebBrowser)tabControl.SelectedTab.Controls[0]).GoBack();
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl.SelectedTab.Controls[0]).GoForward();
        }

        private void tabPage_Enter(object sender, EventArgs e)
        {
            var tp = (TabPage)sender;
            if (tp.Controls.Count > 0)
                txtUrl.Text = ((WebBrowser)tp.Controls[0]).Url?.AbsoluteUri;
        }

        private void webBrowserMain_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            if (e.Url.AbsoluteUri.StartsWith("http"))
                txtUrl.Text = e.Url.AbsoluteUri;
        }
    }
}
