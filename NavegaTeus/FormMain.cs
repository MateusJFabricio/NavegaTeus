using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        public bool AutoInit { get; set; }
        public IniFile IniFile { get; set; }
        public DateTime AutoRefreshInterval { get; set; }
        private DateTime LastAutoRefresh = DateTime.Now;
        private DateTime TimebtnClose = DateTime.Now;
        public string PaginaPadrao { get; set; }

        public FormMain(bool autoInit)
        {
            AutoInit = autoInit;
            IniFile = new IniFile("NavegateusConfig.ini");
            InitializeComponent();

            ConfiguraComponentes();
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

            tabControl.Dock = DockStyle.Fill;
            tabControl.TabPages.Add(tabPage);
            tabControl.SelectedIndex = tabControl.TabPages.Count - 1;
        }

        private void ConfiguraComponentes()
        {
            if (AutoInit)
            {
                timerRelogio.Start();
                timerMouseMonitor.Start();
                btnClose.Visible = true;
                tabControl.Visible = false;
                if (IniFile.Read("OcultarControles") == "TRUE")
                {
                    FormBorderStyle = FormBorderStyle.None;
                    WindowState = FormWindowState.Maximized;
                    flowLayoutPanelSuperior.Visible = false;
                }

                //Carrega o label de data a hora
                try
                {
                    lblDataHora.Visible = IniFile.Read("ExibirDataHora") == "TRUE";
                    TypeConverter converter = TypeDescriptor.GetConverter(typeof(Font));
                    lblDataHora.Font = (Font)converter.ConvertFromString(IniFile.Read("DataHoraFonte"));
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Houve um problema ao configurar a fonte da DataHora: " + ex.Message);
                }
                //Carrega as cores do label de data e hora
                try
                {
                    lblDataHora.BackColor = Color.FromArgb(Convert.ToInt32(IniFile.Read("DataHoraCorFundo")));
                    lblDataHora.ForeColor = Color.FromArgb(Convert.ToInt32(IniFile.Read("DataHoraCorLetra")));
                }
                catch (Exception ex)
                {
                    lblDataHora.BackColor = Color.White;
                    lblDataHora.ForeColor = Color.Black;
                    MessageBox.Show("Houve um problema ao configurar as cores configuradas da DataHora: " + ex.Message);
                }
                //Carrega o label de proxima atualizacao
                try
                {
                    lblTempoRestante.Visible = IniFile.Read("ExibirTempoProxAtualizacao") == "TRUE";
                    TypeConverter converter = TypeDescriptor.GetConverter(typeof(Font));
                    lblTempoRestante.Font = (Font)converter.ConvertFromString(IniFile.Read("DataHoraFonte"));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Houve um problema ao configurar a fonte: " + ex.Message);
                }
                // Carrega as cores do label de proxima atualizacao
                try
                {
                    lblTempoRestante.BackColor = Color.FromArgb(Convert.ToInt32(IniFile.Read("DataHoraCorFundo")));
                    lblTempoRestante.ForeColor = Color.FromArgb(Convert.ToInt32(IniFile.Read("DataHoraCorLetra")));
                }
                catch (Exception ex)
                {
                    lblTempoRestante.BackColor = Color.White;
                    lblTempoRestante.ForeColor = Color.Black;
                    MessageBox.Show("Houve um problema ao configurar as cores configuradas da ultima atualizacao: " + ex.Message);
                }


                timerAutoRefreshPage.Enabled = IniFile.Read("AutoRefresh") == "TRUE";
                if (timerAutoRefreshPage.Enabled)
                {
                    try
                    {
                        var autoRefreshInterval = DateTime.Parse(IniFile.Read("AutoRefreshTime"));
                        AutoRefreshInterval = new DateTime(DateTime.MinValue.Year, DateTime.MinValue.Month, DateTime.MinValue.Day, autoRefreshInterval.Hour, autoRefreshInterval.Minute, autoRefreshInterval.Second);
                    }
                    catch (Exception ex)
                    {
                        AutoRefreshInterval = DateTime.MinValue;
                        MessageBox.Show("Houve um problema com a configuracao do intervalor de atualizacao: " + ex.Message);
                        MessageBox.Show("Foi adicionar o intervalo de atualizacao de 1 hora automaticamente");
                    }
                }

                PaginaPadrao = IniFile.Read("PaginaPadrao");

                try
                {
                    var browser = new ChromiumWebBrowser(PaginaPadrao);
                    browser.Dock = DockStyle.Fill;
                    browser.AddressChanged += Browser_AddressChanged;
                    browser.TitleChanged += Browser_TitleChanged;
                    timerBtnClose.Start();
                    panelMain.Controls.Add(browser);
                    lblDataHora.BringToFront();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Houve um problema ao carregar a pagina configurada: " + ex.Message);
                }
                
            }
            else
            {
                btnClose.Visible = false;
                flowLayoutPanelSuperior.Visible = true;
                lblDataHora.Visible = false;
                lblTempoRestante.Visible = false;

                var browser = new ChromiumWebBrowser("www.google.com");
                browser.Dock = DockStyle.Fill;
                browser.AddressChanged += Browser_AddressChanged;
                browser.TitleChanged += Browser_TitleChanged;

                TabPage tabPage = new TabPage("Google");
                tabPage.Controls.Add(browser);

                tabControl.TabPages[0].Controls.Add(browser);
            }
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
            ChromiumWebBrowser webBrowser = (ChromiumWebBrowser)tabControl.SelectedTab.Controls[0];
            webBrowser.GetBrowser().Reload();
            txtUrl.Text = webBrowser.Address;
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

        private void btnInicializacao_Click(object sender, EventArgs e)
        {
            new FormInicializacao().ShowDialog();
        }

        private void timerAutoRefreshPage_Tick(object sender, EventArgs e)
        {
            var now = new DateTime(DateTime.MinValue.Year, DateTime.MinValue.Month, DateTime.MinValue.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            var last = new DateTime(DateTime.MinValue.Year, DateTime.MinValue.Month, DateTime.MinValue.Day, LastAutoRefresh.Hour, LastAutoRefresh.Minute, LastAutoRefresh.Second);
            
            if ((now - last).Ticks > AutoRefreshInterval.Ticks)
            {
                LastAutoRefresh = DateTime.Now;
                ChromiumWebBrowser webBrowser = panelMain.Controls.OfType<ChromiumWebBrowser>().ToList()[0];
                webBrowser.GetBrowser().Reload();
                txtUrl.Text = webBrowser.Address;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timerBtnClose_Tick(object sender, EventArgs e)
        {
            if ((DateTime.Now - TimebtnClose).TotalSeconds > 5)
            {
                timerBtnClose.Stop();
                btnClose.Visible = false;
            }
        }

        private void timerMouseMonitor_Tick(object sender, EventArgs e)
        {
            if (Cursor.Position.X > Width - 100)
            {
                if (Cursor.Position.Y < 100)
                {
                    btnClose.Visible = true;
                    TimebtnClose = DateTime.Now;
                    timerBtnClose.Start();
                }
            }
        }

        private void timerRelogio_Tick(object sender, EventArgs e)
        {
            lblDataHora.Text = "Data e Hora: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            var proximaAtualizacao = LastAutoRefresh.TimeOfDay + AutoRefreshInterval.TimeOfDay;
            double horas = (proximaAtualizacao - DateTime.Now.TimeOfDay).Hours;
            double minutos = (proximaAtualizacao - DateTime.Now.TimeOfDay).Minutes;
            double segundos = (proximaAtualizacao - DateTime.Now.TimeOfDay).Seconds;


            lblTempoRestante.Text = "Proxima Atualizacao em: ";
            if (horas > 0)
            {
                lblTempoRestante.Text += horas.ToString() + " horas e " + minutos.ToString() + " min";
            }else if (minutos > 0)
            {
                lblTempoRestante.Text += minutos.ToString() + " min e " + segundos.ToString() + " seg";
            }else
            {
                lblTempoRestante.Text += segundos.ToString() + " seg";
            }
        }
    }
}
