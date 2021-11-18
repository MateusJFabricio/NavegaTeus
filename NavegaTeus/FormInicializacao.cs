using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavegaTeus
{
    public partial class FormInicializacao : Form
    {
        private IniFile IniFile;
        public FormInicializacao()
        {
            InitializeComponent();

            IniFile = new IniFile("NavegateusConfig.ini");

            ConfiguraComponentes();
        }

        private void ConfiguraComponentes()
        {
            if (IniFile.Read("InicializarComWindows") == "TRUE")
            {

                cbInicializarWindows.CheckedChanged -= cbInicializarWindows_CheckedChanged;
                cbInicializarWindows.Checked = true;
                cbInicializarWindows.CheckedChanged += cbInicializarWindows_CheckedChanged;
            }else
            {
                btnTestar.Enabled = false;
            }

            if (IniFile.Read("OcultarControles") == "TRUE")
            {
                cbOcultarControles.Checked = true;
            }

            if (IniFile.Read("ExibirDataHora") == "TRUE")
            {
                cbExibirDataHora.Checked = true;
            }

            if (IniFile.Read("ExibirSemana") == "TRUE")
            {
                cbExibirSemana.Checked = true;
            }

            if (IniFile.Read("ExibirTempoProxAtualizacao") == "TRUE")
            {
                cbExibirTempoRestante.Checked = true;
            }

            if (IniFile.Read("AutoRefresh") == "TRUE")
            {
                cbAtualizarPagina.Checked = true;
                dtpIntervaloAtualizacaoPagina.Enabled = true;
                try
                {
                    dtpIntervaloAtualizacaoPagina.Value = DateTime.Parse(IniFile.Read("AutoRefreshTime"));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Houve um erro na conversao da hora salva:" + ex.Message);
                    MessageBox.Show("Foi adicionado o intervalo de 1 hora automaticamente");
                    dtpIntervaloAtualizacaoPagina.Value = new DateTime(0, 0, 0, 1, 0, 0, 0);
                    IniFile.Write("AutoRefreshTime", dtpIntervaloAtualizacaoPagina.Value.ToString());
                }

            }
            else
            {
                dtpIntervaloAtualizacaoPagina.Enabled = false;
            }

            txtPaginaPadrao.Text = IniFile.Read("PaginaPadrao");

            //Carrega a fonte
            TypeConverter converter = TypeDescriptor.GetConverter(typeof(Font));
            try
            {
                Font font = (Font)converter.ConvertFromString(IniFile.Read("DataHoraFonte"));
                fontDialogDataHora.Font = font;
            }
            catch (Exception ex)
            {
                IniFile.Write("DataHoraFonte", converter.ConvertToString(fontDialogDataHora.Font));
            }

            lblFonte.Text = converter.ConvertToString(fontDialogDataHora.Font);

            //Carrega a cor do fundo
            if (IniFile.Read("DataHoraCorFundo") != "")
            {
                try
                {
                    pnlCorFundo.BackColor = Color.FromArgb(Convert.ToInt32(IniFile.Read("DataHoraCorFundo")));
                }
                catch
                {
                    IniFile.Write("DataHoraCorFundo", Color.White.ToArgb().ToString());
                    pnlCorFundo.BackColor = Color.White;
                }
            }
            else
            {
                IniFile.Write("DataHoraCorFundo", Color.White.ToArgb().ToString());
                pnlCorFundo.BackColor = Color.White;
            }
            colorDialogDataHoraFundo.Color = pnlCorFundo.BackColor;

            //Carrega a cor da letra
            if (IniFile.Read("DataHoraCorLetra") != "")
            {
                try
                {
                    pnlCorLetra.BackColor = Color.FromArgb(Convert.ToInt32(IniFile.Read("DataHoraCorLetra")));
                }
                catch
                {
                    IniFile.Write("DataHoraCorLetra", Color.Black.ToArgb().ToString());
                    pnlCorLetra.BackColor = Color.Black;
                }
            }
            else
            {
                IniFile.Write("DataHoraCorLetra", Color.Black.ToArgb().ToString());
                pnlCorLetra.BackColor = Color.Black;
            }
            colorDialogDataHoraLetra.Color = pnlCorLetra.BackColor;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            IniFile.Write("InicializarComWindows", cbInicializarWindows.Checked ? "TRUE" : "FALSE");
            IniFile.Write("OcultarControles", cbOcultarControles.Checked ? "TRUE" : "FALSE");
            IniFile.Write("ExibirDataHora", cbExibirDataHora.Checked ? "TRUE" : "FALSE");
            IniFile.Write("ExibirSemana", cbExibirSemana.Checked ? "TRUE" : "FALSE");
            IniFile.Write("ExibirTempoProxAtualizacao", cbExibirTempoRestante.Checked ? "TRUE" : "FALSE");
            IniFile.Write("AutoRefresh", cbAtualizarPagina.Checked ? "TRUE" : "FALSE");
            IniFile.Write("AutoRefreshTime", dtpIntervaloAtualizacaoPagina.Value.ToString());
            IniFile.Write("PaginaPadrao", txtPaginaPadrao.Text);
            TypeConverter converter = TypeDescriptor.GetConverter(typeof(Font));
            IniFile.Write("DataHoraFonte", converter.ConvertToString(fontDialogDataHora.Font));
            IniFile.Write("DataHoraCorFundo", colorDialogDataHoraFundo.Color.ToArgb().ToString());
            IniFile.Write("DataHoraCorLetra", colorDialogDataHoraLetra.Color.ToArgb().ToString());

            if (cbInicializarWindows.Checked == false)
            {
                string link = Environment.GetFolderPath(Environment.SpecialFolder.Startup) +
                Path.DirectorySeparatorChar +
                Application.ProductName + ".lnk";

                try
                {
                    System.IO.File.Delete(link);
                }
                catch { }
                btnTestar.Enabled = false;
            }
            else
            {
                btnTestar.Enabled = true;
                CreateShortcut();
            }
        }

        private void CreateShortcut()
        {
            string link = Environment.GetFolderPath(Environment.SpecialFolder.Startup) +
                Path.DirectorySeparatorChar +
                Application.ProductName + ".lnk";
            var shell = new WshShell();
            var shortcut = shell.CreateShortcut(link) as IWshShortcut;
            shortcut.TargetPath = Application.ExecutablePath;
            shortcut.WorkingDirectory = Application.StartupPath;
            shortcut.Arguments = "AutoInit";
            shortcut.Description = "Este atalho só funciona se estiver configurado para iniciar com o Windows";
            shortcut.Save();

            link = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                Path.DirectorySeparatorChar + "RunTime.lnk";
            shortcut = shell.CreateShortcut(link) as IWshShortcut;
            shortcut.TargetPath = Application.ExecutablePath;
            shortcut.WorkingDirectory = Application.StartupPath;
            shortcut.Arguments = "AutoInit";
            shortcut.Description = "Este atalho só funciona se estiver configurado para iniciar com o Windows";
            shortcut.Save();
        }

        private void cbAtualizarPagina_CheckedChanged(object sender, EventArgs e)
        {
            dtpIntervaloAtualizacaoPagina.Enabled = cbAtualizarPagina.Checked;
            cbExibirTempoRestante.Enabled = cbAtualizarPagina.Checked;
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            string link = Environment.GetFolderPath(Environment.SpecialFolder.Startup) +
                Path.DirectorySeparatorChar +
                Application.ProductName + ".lnk";

            Process.Start(link);
        }

        private void cbExibirDataHora_CheckedChanged(object sender, EventArgs e)
        {
            //groupBoxFormatoDataHora.Enabled = cbExibirDataHora.Checked;
        }

        private void lblFonte_Click(object sender, EventArgs e)
        {
            fontDialogDataHora.ShowDialog();
            TypeConverter converter = TypeDescriptor.GetConverter(typeof(Font));
            lblFonte.Text = converter.ConvertToString(fontDialogDataHora.Font);
        }

        private void pnlCorFundo_Click(object sender, EventArgs e)
        {
            colorDialogDataHoraFundo.ShowDialog();
            pnlCorFundo.BackColor = colorDialogDataHoraFundo.Color;
        }

        private void pnlCorLetra_Click(object sender, EventArgs e)
        {
            colorDialogDataHoraLetra.ShowDialog();
            pnlCorLetra.BackColor = colorDialogDataHoraLetra.Color;
        }

        private void cbInicializarWindows_CheckedChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
